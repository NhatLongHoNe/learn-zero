using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Asd.AbpZeroTemplate.Authorization.Users;
using Asd.AbpZeroTemplate.Configuration;
using Asd.AbpZeroTemplate.ErpSignIn.Dto;
using Asd.AbpZeroTemplate.MultiTenancy;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Asd.AbpZeroTemplate.ErpSignIn
{
    public class ErpSignInAppService : AbpZeroTemplateAppServiceBase, IErpSignInAppService
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ErpSignInAppService(
            IWebHostEnvironment env)
        {
            _appConfiguration = env.GetAppConfiguration();
        }

        public async Task<ErpCurrentUserDto> SignInUser(string token, string code)
        {
            try
            {
                // implement ERP SignIn
                var erpSignInUrl = _appConfiguration["App:ErpSignInUrl"];
                var erpSignInAppId = _appConfiguration["App:ErpSignInAppId"];
                var erpSignInAppSecret = _appConfiguration["App:ErpSignInAppSecret"];

                var client = new HttpClient();

                var jsonInString = JsonConvert.SerializeObject(new
                {
                    token,
                    code,
                    appId = erpSignInAppId,
                    appSecret = erpSignInAppSecret
                });

                var remoteUrl = erpSignInUrl;

                var response = await (client.PostAsync(remoteUrl, new StringContent(jsonInString, Encoding.UTF8, "application/json"))).Result.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject<GetUserExternalresult>(response);
                //Logger.Error("ERP: " + JsonConvert.SerializeObject(result));
                if (result.Success)
                {
                    var userInfo = result.Data;
                    var user = UserManager.Users.FirstOrDefault(p => p.UserName == userInfo.Username);
                    //Logger.Error("ABP: " + JsonConvert.SerializeObject(user));

                    if (user != null)
                    {
                        var newPassword = GeneratePassword(32);

                        bool success = (await UserManager.ChangePasswordAsync(user, newPassword)).Succeeded;
                        while (!success)
                        {
                            newPassword = GeneratePassword(32);
                            success = (await UserManager.ChangePasswordAsync(user, newPassword)).Succeeded;
                        }

                        userInfo.OneTimePassword = newPassword;

                        return userInfo;
                    }
                    else
                    {
                        return new ErpCurrentUserDto();
                    }
                }
                else
                {
                    return new ErpCurrentUserDto();
                }
            }
            catch (Exception ex)
            {
                Logger.Error("ERP: " + ex.ToString());
                return new ErpCurrentUserDto();
            }
        }

        private string GeneratePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
    }
}
