﻿using ICWebApp.Application.Interface.Provider;
using ICWebApp.Application.Interface.Services;
using ICWebApp.Domain.DBModels;
using Microsoft.AspNetCore.Components;
using Telerik.Blazor.Components;
using Telerik.Blazor.Components.Editor;

namespace ICWebApp.Components.Pages.Form.Admin.SubPages
{
    public partial class PaymentAdd
    {
        [Inject] IBusyIndicatorService BusyIndicatorService { get; set; }
        [Inject] ISessionWrapper SessionWrapper { get; set; }
        [Inject] IFORMDefinitionProvider FormDefinitionProvider { get; set; }
        [Inject] ITEXTProvider TextProvider { get; set; }
        [Inject] IAUTHProvider AuthProvider { get; set; }
        [Inject] ILANGProvider LangProvider { get; set; }
        [Inject] NavigationManager NavManager { get; set; }
        [Parameter] public string DefinitionID { get; set; }
        [Parameter] public string ID { get; set; }
        [Parameter] public string ActiveIndex { get; set; }
        [Parameter] public string WizardIndex { get; set; }
        private FORM_Definition_Payment_Position Data { get; set; }
        private List<LANG_Languages>? Languages { get; set; }
        private Guid? CurrentLanguage { get; set; }
        private List<IEditorTool> Tools { get; set; } =
        new List<IEditorTool>()
        {
            new EditorButtonGroup(new Bold(), new Italic(), new Underline()),
            new EditorButtonGroup(new AlignLeft(), new AlignCenter(), new AlignRight()),
            new UnorderedList(),
            new EditorButtonGroup(new CreateLink(), new Unlink()),
            new InsertTable(),
            new DeleteTable(),
            new EditorButtonGroup(new AddRowBefore(), new AddRowAfter(), new DeleteRow(), new MergeCells(), new SplitCell())
        };
        public List<string> RemoveAttributes { get; set; } = new List<string>() { "data-id" };
        public List<string> StripTags { get; set; } = new List<string>() { "font" };

        protected override async Task OnInitializedAsync()
        {
            if(DefinitionID == null)
            {
                BusyIndicatorService.IsBusy = true;
                StateHasChanged();
                NavManager.NavigateTo("/Form/Definition");
            }

            Languages = await LangProvider.GetAll();

            if (ID == "New")
            {
                Data = new FORM_Definition_Payment_Position();
                Data.ID = Guid.NewGuid();
                Data.FORM_Definition_ID = Guid.Parse(DefinitionID);

                await FormDefinitionProvider.SetDefinitionPayment(Data);

                if (Languages != null)
                {
                    foreach (var l in Languages)
                    {
                        if (Data.FORM_Definition_Payment_Position_Extended == null)
                        {
                            Data.FORM_Definition_Payment_Position_Extended = new List<FORM_Definition_Payment_Position_Extended>();
                        }

                        if (Data.FORM_Definition_Payment_Position_Extended.FirstOrDefault(p => p.LANG_Languages_ID == l.ID) == null)
                        {
                            var dataE = new FORM_Definition_Payment_Position_Extended()
                            {
                                FORM_Definition_Payment_Position_ID = Data.ID,
                                LANG_Languages_ID = l.ID
                            };

                            await FormDefinitionProvider.SetDefinitionPaymentExtended(dataE);
                            Data.FORM_Definition_Payment_Position_Extended.Add(dataE);
                        }

                    }
                }

                Data = await FormDefinitionProvider.GetDefinitionPayment(Data.ID);

                var count = await FormDefinitionProvider.GetDefinitionPaymentList(Guid.Parse(DefinitionID));

                if (count != null && count.Count > 0)
                {
                    Data.SortOrder = count.Count + 1;
                }
                else
                {
                    Data.SortOrder = 1;
                }
            }
            else
            {
                Data = await FormDefinitionProvider.GetDefinitionPayment(Guid.Parse(ID));

                if (Data != null && Languages != null && Data.FORM_Definition_Payment_Position_Extended != null &&
                    Data.FORM_Definition_Payment_Position_Extended.Count < Languages.Count)
                {
                    foreach (var l in Languages)
                    {
                        if (Data.FORM_Definition_Payment_Position_Extended.FirstOrDefault(p => p.LANG_Languages_ID == l.ID) == null)
                        {
                            var dataE = new FORM_Definition_Payment_Position_Extended()
                            {
                                ID = Guid.NewGuid(),
                                FORM_Definition_Payment_Position_ID = Data.ID,
                                LANG_Languages_ID = l.ID
                            };

                            Data.FORM_Definition_Payment_Position_Extended.Add(dataE);
                        }
                    }
                }

                if (Data == null)
                {
                    ReturnToPreviousPage();
                }
            }

            if (Languages != null)
            {
                CurrentLanguage = Languages.FirstOrDefault().ID;
            }

            BusyIndicatorService.IsBusy = false;
            StateHasChanged();

            await base.OnInitializedAsync();
        }
        private async void ReturnToPreviousPage()
        {
            if (ID == "New" && Data != null)
            {
                await FormDefinitionProvider.RemoveDefinitionProperty(Data.ID, true);
            }

            BusyIndicatorService.IsBusy = true;
            StateHasChanged();
            NavManager.NavigateTo("/Form/Definition/Add/" + DefinitionID + "/" + WizardIndex + "/" + ActiveIndex);
        }
        private async void SaveForm()
        {
            BusyIndicatorService.IsBusy = true;
            StateHasChanged();

            foreach (var e in Data.FORM_Definition_Payment_Position_Extended)
            {
                await FormDefinitionProvider.SetDefinitionPaymentExtended(e);
            }

            await FormDefinitionProvider.SetDefinitionPayment(Data);
            NavManager.NavigateTo("/Form/Definition/Add/" + DefinitionID + "/" + WizardIndex + "/" + ActiveIndex);
        }
        private void LanguageChanged()
        {
            StateHasChanged();
        }
    }
}
