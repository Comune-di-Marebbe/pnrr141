﻿using DocumentFormat.OpenXml.Office2010.Excel;
using ICWebApp.Application.Interface.Helper;
using ICWebApp.Application.Interface.Provider;
using ICWebApp.Application.Interface.Services;
using ICWebApp.Domain.DBModels;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace ICWebApp.Components.Components.Homepage.Frontend.Documents
{
    public partial class DocumentsItemTeaser
    {
        [Inject] IFILEProvider FileProvider { get; set; }
        [Inject] IHOMEProvider HOMEProvider { get; set; }
        [Inject] ISessionWrapper SessionWrapper { get; set; }
        [Inject] ITEXTProvider TextProvider { get; set; }
        [Inject] ILANGProvider LANGProvider { get; set; }
        [Inject] IImageHelper ImageHelper { get; set; }
        [Inject] NavigationManager NavManager { get; set; }
        [Inject] IBusyIndicatorService BusyIndicatorService { get; set; }
        [Parameter] public V_HOME_Document Document { get; set; }

        private void OnClick()
        {
            if (Document != null)
            {
                BusyIndicatorService.IsBusy = true;
                NavManager.NavigateTo("/hp/Document/" + Document.ID);
                StateHasChanged();
            }
        }
        private void OnClickType()
        {
            if (Document != null)
            {
                BusyIndicatorService.IsBusy = true;
                NavManager.NavigateTo("/hp/Type/Document/" + Document.Type_ID);
                StateHasChanged();
            }
        }
    }
}
