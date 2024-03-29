﻿using BethanysPieShopHRM.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.UI.Services
{
    public interface IJobDataService
    {
        Task AddJob(Job newJob);
        Task DeleteJob(int jobId);
        Task<IEnumerable<Job>> GetAllJobs();
        Task<Job> GetJobById(int jobId);
        Task UpdateJob(Job job);
    }
}