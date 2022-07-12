using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Enities
{
    public class Task : RootEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Enums.TaskStatus Status { get; set; }
        public string CreatedBy { get; set; }
        public string ProjectId { get; set; }
        public string AssignedProjectMemberId { get; set; }

        public void CheckTaskStatus(string projectMemberId)
        {
            if (Status == Enums.TaskStatus.Finished)
            {
                throw new Exception("The task can not be assigned when it's Finished.");
            }

            AssignedProjectMemberId = projectMemberId;
        }

        public void UpdateStatus(string userId, Enums.TaskStatus status)
        {
            if (userId.Equals(CreatedBy))
            {
                Status = status;
                
            }
            else
            {
                throw new Exception("Only the task assignee can update task status.");
            }            
        }
    }
}
