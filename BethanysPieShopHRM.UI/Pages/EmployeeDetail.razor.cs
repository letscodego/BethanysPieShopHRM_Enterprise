﻿using System.Collections.Generic;
using System.Threading.Tasks;
using BethanysPieShopHRM.ComponentsLibrary.Map;
using BethanysPieShopHRM.UI.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;

namespace BethanysPieShopHRM.UI.Pages
{
    public partial class EmployeeDetail
    {
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        [Inject]
        public IJobCategoryDataService JobCategoryDataService{ get; set; }

        [Parameter]
        public int EmployeeId { get; set; }

        public List<Marker> MapMarkers { get; set; } = new List<Marker>();

        protected string JobCategory = string.Empty;

        public Employee Employee { get; set; } = new Employee()
        {
            Address = new Address(),
            Contact = new Contact(),
            JobCategoryId = 1,
            BirthDate = DateTime.Now,
            JoinedDate = DateTime.Now
        };

        protected override async Task OnInitializedAsync()
        {
            Employee = await EmployeeDataService.GetEmployeeDetails(EmployeeId);

            MapMarkers = new List<Marker>
            {
                new Marker{Description = $"{Employee.FirstName} {Employee.LastName}",  ShowPopup = false, X = Employee.Address.Longitude, Y = Employee.Address.Latitude}
            };
            JobCategory = (await JobCategoryDataService.GetJobCategoryById(Employee.JobCategoryId)).JobCategoryName;
        }
    }
}
