﻿using DocumentFormat.OpenXml.Office2010.Excel;
using ICWebApp.Application.Interface.Provider;
using ICWebApp.Application.Interface.Services;
using ICWebApp.Application.Provider;
using ICWebApp.Domain.DBModels;
using Microsoft.AspNetCore.Components;

namespace ICWebApp.Components.Pages.Homepage.Frontend.Location
{
    public partial class IndexTypes
    {
        [Inject] ILANGProvider LangProvider { get; set; }
        [Inject] ITEXTProvider TextProvider { get; set; }
        [Inject] IBusyIndicatorService BusyIndicatorService { get; set; }
        [Inject] IBreadCrumbService CrumbService { get; set; }
        [Inject] ISessionWrapper SessionWrapper { get; set; }
        [Inject] IHOMEProvider HomeProvider { get; set; }
        [Inject] IEnviromentService EnviromentService { get; set; }
        [Inject] NavigationManager NavManager { get; set; }
        [Parameter] public string? TypeID {  get; set; }

        private V_HOME_Location_Type? Type;
        private List<V_HOME_Location> Items = new List<V_HOME_Location>();
        private List<V_HOME_Location_Type>? Types;
        private string? SearchText;
        int MaxCounter = 6;

        protected override async void OnParametersSet()
        {
            if (TypeID == null)
            {
                BusyIndicatorService.IsBusy = true;
                NavManager.NavigateTo("/Hp/Location");
                StateHasChanged();
                return;
            }

            if (SessionWrapper.AUTH_Municipality_ID != null)
            {
                Types = await HomeProvider.GetLocation_Type(LangProvider.GetCurrentLanguageID());
            }

            if (Types != null)
            {
                Type = Types.FirstOrDefault(p => p.ID == Guid.Parse(TypeID));
            }

            if (Type == null)
            {
                BusyIndicatorService.IsBusy = true;
                NavManager.NavigateTo("/Hp/Location");
                StateHasChanged();
                return;
            }

            SessionWrapper.PageTitle = Type.Type;
            SessionWrapper.PageSubTitle = null;
            SessionWrapper.PageDescription = Type.DescriptionShort;
            SessionWrapper.ShowTitleSepparation = false;
            SessionWrapper.ShowHelpSection = true;
            SessionWrapper.ShowTitleSmall = true;
            SessionWrapper.DataElement = "page-name";

            CrumbService.ClearBreadCrumb();
            CrumbService.AddBreadCrumb("/Hp/Villagelife", "HP_MAINMENU_DORFLEBEN", null, null, false);
            CrumbService.AddBreadCrumb("/Hp/Location", "HOMEPAGE_FRONTEND_LOCATION", null, null, false);
            CrumbService.AddBreadCrumb("/Hp/Location/" + Type.ID.ToString(), Type.Type, null, null, true);

            if (SessionWrapper.AUTH_Municipality_ID != null && Type != null)
            {
                Items = await HomeProvider.GetLocationByType(SessionWrapper.AUTH_Municipality_ID.Value, LangProvider.GetCurrentLanguageID(), Type.ID);
            }

            try
            {
                EnviromentService.ScrollToTop();
            }
            catch { }

            BusyIndicatorService.IsBusy = false;
            StateHasChanged();
            base.OnParametersSet();
        }
        private void OnTypeClicked(Guid ID)
        {
            if (Type != null && ID != Type.ID)
            {
                BusyIndicatorService.IsBusy = true;
                NavManager.NavigateTo("/hp/Type/Location/" + ID);
                StateHasChanged();
            }
        }
        private void ShowMore()
        {
            MaxCounter = MaxCounter + 6;

            if (Items.Count() < MaxCounter)
            {
                MaxCounter = Items.Count();
            }

            StateHasChanged();
        }
    }
}
