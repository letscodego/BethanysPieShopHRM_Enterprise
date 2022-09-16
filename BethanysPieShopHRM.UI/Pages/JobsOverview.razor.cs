﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShopHRM.UI.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.UI.Pages
{
    public partial class JobsOverview
    {
        [Inject]
        public IJobDataService JobService { get; set; }

        public List<Job> Jobs { get; set; }


        protected override async Task OnInitializedAsync()
        {
            Jobs = (await JobService.GetAllJobs()).ToList();
        }
    }
}
