﻿using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using WebApp_UnderTheHood.Auth;
using WebApp_UnderTheHood.Common.Extensions;

namespace WebApp_UnderTheHood.Authorization.PolicyRequirements
{
    public class HRManageProbationRequirement : IAuthorizationRequirement
    {
        public const int DefaultMinimumProbationMonths = 3;

        public HRManageProbationRequirement(int probationMonths)
        {
            ProbationMonths = probationMonths;
        }

        public int ProbationMonths { get; set; }

        public int ProbationDays => ProbationMonths * 30;
    }

    public class HRManageProbationRequirementHandler : AuthorizationHandler<HRManageProbationRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, HRManageProbationRequirement requirement)
        {
            var employmentDate = context.User.FindFirstValue(AppAuthenticationClaims.EmploymentDate.Type)?.TryParseDateTime();
            
            if (employmentDate != null)
            {
                var probationPeriod = DateTime.UtcNow - employmentDate.Value;

                if (probationPeriod.Days > requirement.ProbationDays) context.Succeed(requirement);
            }
            
            return Task.CompletedTask;
        }
    }
}
