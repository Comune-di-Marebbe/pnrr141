﻿using ICWebApp.Application.Interface.Provider;
using ICWebApp.Application.Interface.Services;
using ICWebApp.Application.Provider;
using ICWebApp.Application.Services;
using ICWebApp.Domain.DBModels;
using Microsoft.AspNetCore.Components;

namespace ICWebApp.Components.Pages.Legal.Frontend
{
    public partial class Accessibility
    {
        [Inject] private ITEXTProvider TextProvider { get; set; }
        [Inject] private IBreadCrumbService CrumbService { get; set; }
        [Inject] private ISessionWrapper SessionWrapper { get; set; }
        [Inject] private IBusyIndicatorService BusyIndicatorService { get; set; }

        private bool IsDataBusy { get; set; }


        protected override void OnInitialized()
        {
            BusyIndicatorService.IsBusy = true;
            SessionWrapper.PageTitle = TextProvider.Get("MAINMENU_ACCESSIBILITY");
            SessionWrapper.PageDescription = null;

            CrumbService.ClearBreadCrumb();
            CrumbService.AddBreadCrumb("/Accessibility", "MAINMENU_ACCESSIBILITY", null);

            BusyIndicatorService.IsBusy = false;
            StateHasChanged();

            base.OnInitialized();
        }
    }
}
