using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SacramentMeetingPlanner.Data;
using System;
using System.Linq;

namespace SacramentMeetingPlanner.Models

{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SacramentMeetingPlannerContext(
                       serviceProvider.GetRequiredService<
                           DbContextOptions<SacramentMeetingPlannerContext>>()))
            {
                // Look for any members.
                if (context.Member.Any())
                {
                    // DB has been seeded. Do nothing.
                    return;
                }

                context.Member.AddRange(
                    new Member
                    {
                        FirstName = "Cameron",
                        LastName = "Fuller",
                        MemberTitle = Title.Bishop
                    },

                    new Member
                    {
                        FirstName = "Austin",
                        LastName = "Donovan",
                        MemberTitle = Title.President
                    },

                    new Member
                    {

                    }

                );
            }
        }
    }
}
