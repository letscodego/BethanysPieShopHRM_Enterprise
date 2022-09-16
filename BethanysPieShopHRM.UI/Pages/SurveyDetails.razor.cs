using BethanysPieShopHRM.Shared;
using BethanysPieShopHRM.UI.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.UI.Pages
{
    public partial class SurveyDetails
    {
        [Inject]
        private ISurveyDataService surveyService { get; set; }

        [Parameter]
        public string SurveyId { get; set; }

        public double AverageRating { get; set; }

        public double LowestRating { get; set; }

        public double HighestRating { get; set; }

        public double Count { get; set; }

        public Survey Survey { get; set; } = new Survey() { Answers = new List<Answer>() };

        protected override async Task OnInitializedAsync()
        {
            Survey = await surveyService.GetSurveyById(int.Parse(SurveyId));

            if (Survey.Answers == null)
            {
                Survey.Answers = new List<Answer>();
            }

            if (Survey.Answers.Count > 0)
            {
                AverageRating = Survey.Answers.Select(x => x.Rating).Sum() / Survey.Answers.Count;

                HighestRating = Survey.Answers.OrderByDescending(x => x.Rating).FirstOrDefault().Rating;

                LowestRating = Survey.Answers.OrderBy(x => x.Rating).FirstOrDefault().Rating;

                Count = Survey.Answers.Count;
            }
        }
    }
}
