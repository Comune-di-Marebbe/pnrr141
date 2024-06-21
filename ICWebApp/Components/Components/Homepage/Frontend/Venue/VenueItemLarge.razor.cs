﻿using DocumentFormat.OpenXml.Office2010.Excel;
using ICWebApp.Application.Interface.Helper;
using ICWebApp.Application.Interface.Provider;
using ICWebApp.Application.Interface.Services;
using ICWebApp.Domain.DBModels;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace ICWebApp.Components.Components.Homepage.Frontend.Venue
{
    public partial class VenueItemLarge
    {
        [Inject] IFILEProvider FileProvider { get; set; }
        [Inject] IHOMEProvider HOMEProvider { get; set; }
        [Inject] ISessionWrapper SessionWrapper { get; set; }
        [Inject] ITEXTProvider TextProvider { get; set; }
        [Inject] ILANGProvider LANGProvider { get; set; }
        [Inject] IImageHelper ImageHelper { get; set; }
        [Inject] NavigationManager NavManager { get; set; }
        [Inject] IBusyIndicatorService BusyIndicatorService { get; set; }
        [Parameter] public V_HOME_Venue Venue { get; set; }
        [Parameter] public bool TypeClickable { get; set; } = true;

        private void OnTypeItemClicked(Guid ID)
        {
            BusyIndicatorService.IsBusy = true;
            NavManager.NavigateTo("/hp/Type/Venue/" + ID);
            StateHasChanged();
        }
        private void OnItemClicked()
        {
            BusyIndicatorService.IsBusy = true;
            NavManager.NavigateTo("/hp/Venue/" + Venue.ID);
            StateHasChanged();
        }
    }
}
