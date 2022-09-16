using BethanysPieShopHRM.Shared;
using BethanysPieShopHRM.UI.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.UI.Pages
{
    public partial class SurveyEdit
    {
        public bool Saved { get; set; } = false;

        public Survey Survey { get; set; } = new Survey();

        public string Message { get; set; }

        [Inject]
        private ISurveyDataService surveyService { get; set; }

        [Inject]
        private NavigationManager navManager { get; set; }

        [Parameter]
        public int SurveyId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Saved = false;

            if (SurveyId != 0)
            {
                Survey = await surveyService.GetSurveyById(SurveyId);
            }
        }

        protected async Task HandleValidSubmit()
        {
            var result = await surveyService.AddSurvey(Survey);

            if (result != null)
            {
                navManager.NavigateTo("Surveys");
            }
            else
            {
                Message = "An error has occured";
            }
        }
    }
}
