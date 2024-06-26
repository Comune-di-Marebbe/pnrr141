﻿using ICWebApp.Application.Helper;
using ICWebApp.Application.Interface.Provider;
using ICWebApp.Application.Interface.Services;
using ICWebApp.Domain.DBModels;
using Microsoft.AspNetCore.Components;

namespace ICWebApp.Components.Components.Authorization
{
    public partial class MunicipalChangePasswordComponent
    {
        [Parameter] public AUTH_Municipal_Users User { get; set; }
        [Parameter] public bool IsForceReset { get; set; } = false;
        [Inject] public IAccountService AccountService { get; set; }
        [Inject] public ITEXTProvider TextProvider { get; set; }
        [Inject] public IAUTHProvider AuthProvider { get; set; }
        [Inject] public IBusyIndicatorService BusyIndicatorService { get; set;}
        [Inject] public NavigationManager NavManager { get; set; }
        private MSG_SystemMessages? Message;
        private bool IsValidPassword = false;
        private PasswordHelper pwhelper = new PasswordHelper();
        private string PasswordQuality { get; set; } = "";
        private string Password
        {
            get
            {
                return User.Password;
            }
            set
            {

                User.Password = value;
                PasswordQuality = pwhelper.GetPasswordStrength(value).ToString();
                IsValidPassword = pwhelper.IsValidPassword(value);
                StateHasChanged();
            }
        }

        protected override void OnInitialized()
        {
            StateHasChanged();
            base.OnInitialized();
        }
        private async void HandleValidSubmit()
        {
            if (!IsValidPassword)
            {
                return;
            }

            Message = await AccountService.MunicipalChangePassword(User);
            if (IsForceReset && Message != null && Message.Code == "PASSWORDCHANGE_SUCCESSFULL")
            {
                var ok = await AuthProvider.SetMunicipalUserForcePasswordResetSucceeded(User.ID);
            }
            StateHasChanged();
        }
        private void BackToLogin()
        {
            NavManager.NavigateTo("/Login");
            BusyIndicatorService.IsBusy = true;
            StateHasChanged();
        }
    }
}
