using BethanysPieShopHRM.Shared;
using BethanysPieShopHRM.UI.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.UI.Pages
{
    public partial class SurveysOverview
    {
        [Inject]
        private ISurveyDataService surveyService { get; set; }

        public List<Survey> Surveys { get; set; } = new List<Survey>();

        protected override async Task OnInitializedAsync()
        {
            Surveys = (await surveyService.GetAllSurveys()).ToList();
        }

    }
}
