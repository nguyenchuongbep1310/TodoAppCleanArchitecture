using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Enities
{
    public class ProjectMember : RootEntity
    {
        public string UserId { get; set; }
        public string ProjectId { get; set; }
        public string Role { get; set; }
    }
}
