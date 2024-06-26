﻿using DocumentFormat.OpenXml.Office2010.Excel;
using ICWebApp.Application.Interface.Helper;
using ICWebApp.Application.Interface.Provider;
using ICWebApp.Application.Interface.Services;
using ICWebApp.Application.Provider;
using ICWebApp.Application.Settings;
using ICWebApp.Domain.DBModels;
using Microsoft.AspNetCore.Components;

namespace ICWebApp.Components.Pages.Homepage.Frontend.Organisation
{
    public partial class Detail
    {
        [Inject] ILANGProvider LangProvider { get; set; }
        [Inject] ITEXTProvider TextProvider { get; set; }
        [Inject] IBusyIndicatorService BusyIndicatorService { get; set; }
        [Inject] IBreadCrumbService CrumbService { get; set; }
        [Inject] ISessionWrapper SessionWrapper { get; set; }
        [Inject] IHOMEProvider HomeProvider { get; set; }
        [Inject] IActionBarService ActionBarService { get; set; }
        [Inject] IEnviromentService EnviromentService { get; set; }
        [Inject] IImageHelper ImageHelper { get; set; }
        [Inject] IContactHelper ContactHelper { get; set; }
        [Inject] NavigationManager NavManager { get; set; }
        [Parameter] public string? ID {  get; set; }

        private V_HOME_Organisation? Item;
        private List<V_HOME_Organisation_Person>? People;
        private List<V_HOME_Document>? Documents;

        protected override async void OnParametersSet()
        {
            if (ID == null)
            {
                BusyIndicatorService.IsBusy = true;
                NavManager.NavigateTo("/Hp/Organisation");
                StateHasChanged();
                return;
            }

            Item = await HomeProvider.GetVOrganisation(Guid.Parse(ID), LangProvider.GetCurrentLanguageID());

            if (Item == null)
            {
                BusyIndicatorService.IsBusy = true;
                NavManager.NavigateTo("/Hp/Organisation");
                StateHasChanged();
                return;
            }

            SessionWrapper.PageTitle = Item.Title;
            SessionWrapper.PageSubTitle = null;
            SessionWrapper.PageDescription = Item.DescriptionShort;
            SessionWrapper.ShowTitleSepparation = false;

            CrumbService.ClearBreadCrumb();
            CrumbService.AddBreadCrumb("/Hp/Administration", "HP_MAINMENU_VERWALTUNG", null, null, false);
            CrumbService.AddBreadCrumb("/Hp/Organisation", "HOMEPAGE_FRONTEND_ORGANISATIONS", null, null, false);
            CrumbService.AddBreadCrumb("/Hp/Organisation/" + ID, Item.Title, null, null, true);

            ActionBarService.ClearActionBar();
            ActionBarService.ShowDefaultButtons = true;
            ActionBarService.ShowShareButton = true;

            if(Item != null && SessionWrapper.AUTH_Municipality_ID != null)
            {
                ActionBarService.ThemeList = await HomeProvider.GetThemesByOrganisation(SessionWrapper.AUTH_Municipality_ID.Value, LangProvider.GetCurrentLanguageID(), Item.ID);
                People = await HomeProvider.GetOrganisationVPeople(Item.ID, LangProvider.GetCurrentLanguageID());
                Documents = await HomeProvider.GetDocumentsByOrganisation(SessionWrapper.AUTH_Municipality_ID.Value, LangProvider.GetCurrentLanguageID(), Item.ID);
            }

            BusyIndicatorService.IsBusy = false;
            StateHasChanged();
            base.OnParametersSet();
        }
    }
}
