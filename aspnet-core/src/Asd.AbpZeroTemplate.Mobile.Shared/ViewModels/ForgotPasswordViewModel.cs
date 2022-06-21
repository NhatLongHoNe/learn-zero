using System.Threading.Tasks;
using System.Windows.Input;
using Abp.MultiTenancy;
using Acr.UserDialogs;
using Asd.AbpZeroTemplate.ApiClient;
using Asd.AbpZeroTemplate.Authorization.Accounts;
using Asd.AbpZeroTemplate.Authorization.Accounts.Dto;
using Asd.AbpZeroTemplate.Commands;
using Asd.AbpZeroTemplate.Core.Threading;
using Asd.AbpZeroTemplate.Localization;
using Asd.AbpZeroTemplate.ViewModels.Base;
using Asd.AbpZeroTemplate.Views;

namespace Asd.AbpZeroTemplate.ViewModels
{
    public class ForgotPasswordViewModel : XamarinViewModel
    {
        public ICommand SendForgotPasswordCommand => HttpRequestCommand.Create(SendForgotPasswordAsync);

        private readonly IAccountAppService _accountAppService;
        private bool _isForgotPasswordEnabled;

        public ForgotPasswordViewModel(IAccountAppService accountAppService)
        {
            _accountAppService = accountAppService;
        }

        private string _emailAddress;
        public string EmailAddress
        {
            get => _emailAddress;
            set
            {
                _emailAddress = value;
                SetEmailActivationButtonEnabled();
                RaisePropertyChanged(() => EmailAddress);
            }
        }

        public bool IsForgotPasswordEnabled
        {
            get => _isForgotPasswordEnabled;
            set
            {
                _isForgotPasswordEnabled = value;
                RaisePropertyChanged(() => IsForgotPasswordEnabled);
            }
        }

        public void SetEmailActivationButtonEnabled()
        {
            IsForgotPasswordEnabled = !string.IsNullOrWhiteSpace(EmailAddress);
        }

        private async Task SendForgotPasswordAsync()
        {
            await SetBusyAsync(async () =>
            {
                await WebRequestExecuter.Execute(
                    async () =>
                    await _accountAppService.SendPasswordResetCode(new SendPasswordResetCodeInput { EmailAddress = EmailAddress }),
                    PasswordResetMailSentAsync
                );
            });
        }

        private async Task PasswordResetMailSentAsync()
        {
            await UserDialogs.Instance.AlertAsync(L.Localize("PasswordResetMailSentMessage"), L.Localize("MailSent"), L.Localize("Ok"));

            await NavigationService.SetMainPage<LoginView>(clearNavigationHistory: true);
        }
    }
}
