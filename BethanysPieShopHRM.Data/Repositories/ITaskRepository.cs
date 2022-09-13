using System.Collections.Generic;
using BethanysPieShopHRM.Shared;

namespace BethanysPieShopHRM.Api.Models
{
    public interface ITaskRepository
    {
        IEnumerable<HRTask> GetAllTasks();
        HRTask GetTaskById(int taskId);
        HRTask AddTask(HRTask task);
    }
}
