import { AbpSessionService } from 'abp-ng2-module';
import { Component, Injector, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { accountModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/common/app-component-base';
import { SessionServiceProxy, UpdateUserSignInTokenOutput } from '@shared/service-proxies/service-proxies';
import { UrlHelper } from 'shared/helpers/UrlHelper';
import { ExternalLoginProvider, LoginService } from './login.service';
import { ReCaptchaV3Service } from 'ngx-captcha';
import { AppConsts } from '@shared/AppConsts';

@Component({
    templateUrl: './login.component.html',
    animations: [accountModuleAnimation()],
    styleUrls: ['./login.component.less']
})
export class LoginComponent extends AppComponentBase implements OnInit {
    submitting = false;
    isMultiTenancyEnabled: boolean = this.multiTenancy.isEnabled;
    recaptchaSiteKey: string = AppConsts.recaptchaSiteKey;
    isUseErpSignIn = AppConsts.isUseRemoteSignIn;

    constructor(
        injector: Injector,
        public loginService: LoginService,
        private _router: Router,
        private _sessionService: AbpSessionService,
        private _sessionAppService: SessionServiceProxy,
        private _reCaptchaV3Service: ReCaptchaV3Service
    ) {
        super(injector);
    }

    get multiTenancySideIsTeanant(): boolean {
        return this._sessionService.tenantId > 0;
    }

    get isTenantSelfRegistrationAllowed(): boolean {
        return this.setting.getBoolean('App.TenantManagement.AllowSelfRegistration');
    }

    get isSelfRegistrationAllowed(): boolean {
        if (!this._sessionService.tenantId) {
            return false;
        }

        return this.setting.getBoolean('App.UserManagement.AllowSelfRegistration');
    }

    ngOnInit(): void {
        this.loginService.init();
        if (this._sessionService.userId > 0 && UrlHelper.getReturnUrl() && UrlHelper.getSingleSignIn()) {
            this._sessionAppService.updateUserSignInToken()
                .subscribe((result: UpdateUserSignInTokenOutput) => {
                    const initialReturnUrl = UrlHelper.getReturnUrl();
                    const returnUrl = initialReturnUrl + (initialReturnUrl.indexOf('?') >= 0 ? '&' : '?') +
                        'accessToken=' + result.signInToken +
                        '&userId=' + result.encodedUserId +
                        '&tenantId=' + result.encodedTenantId;

                    location.href = returnUrl;
                });
        }

        this.handleExternalLoginCallbacks();

        // kiểm tra xem có đăng nhập qua erp không

        if (AppConsts.isUseRemoteSignIn ) {

            //this._activatedRoute.queryParams.toPromise().then((params) => {
            const signInToken = this.getParameterByName('token');
            const signInCode = this.getParameterByName('code');

            if (signInToken && signInCode) {
                this.loginService.erpAuthenticate(signInToken, signInCode);

            } else {
                location.href = AppConsts.remoteSignInUrl + '?returnUrl=' + encodeURIComponent(location.href) + '&appId=' + AppConsts.remoteSignIn_AppId;
            }
            //});

            return;
        }
    }

    handleExternalLoginCallbacks(): void {
        let state = UrlHelper.getQueryParametersUsingHash().state;
        let queryParameters = UrlHelper.getQueryParameters();

        if (state && state.indexOf('openIdConnect') >= 0) {
            this.loginService.openIdConnectLoginCallback({});
        }

        if (queryParameters.twitter && queryParameters.twitter === '1') {
            let parameters = UrlHelper.getQueryParameters();
            let token = parameters['oauth_token'];
            let verifier = parameters['oauth_verifier'];
            this.loginService.twitterLoginCallback(token, verifier);
        }
    }

    goLoginErp(){
        location.href = AppConsts.remoteSignOutUrl + '?returnUrl=' + encodeURIComponent(AppConsts.remoteSignInUrl + '?returnUrl=' + encodeURIComponent(AppConsts.appBaseUrl) + '&appId=' + AppConsts.remoteSignIn_AppId);
    }

    getParameterByName(name, url?) {
        if (!url) {
            url = location.href;
        }
        name = name.replace(/[\[\]]/g, '\\$&');
        let regex = new RegExp('[?&]' + name + '(=([^&#]*)|&|#|$)'),
            results = regex.exec(url);
        if (!results) {
            return null;
        }
        if (!results[2]) {
            return '';
        }
        return decodeURIComponent(results[2].replace(/\+/g, ' '));
    }

    login(): void {
        let recaptchaCallback = (token: string) => {
            this.showMainSpinner();

            this.submitting = true;
            this.loginService.authenticate(
                () => {
                    this.submitting = false;
                    this.hideMainSpinner();
                },
                null,
                token
            );
        };

        if (this.useCaptcha) {
            this._reCaptchaV3Service.execute(this.recaptchaSiteKey, 'login', (token) => {
                recaptchaCallback(token);
            });
        } else {
            recaptchaCallback(null);
        }
    }

    externalLogin(provider: ExternalLoginProvider) {
        this.loginService.externalAuthenticate(provider);
    }

    get useCaptcha(): boolean {
        return this.setting.getBoolean('App.UserManagement.UseCaptchaOnLogin');
    }
}
