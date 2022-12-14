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
                if (context == null || context.Member == null)
                {
                    throw new ArgumentNullException("Null SacramentMeetingPlannerContext");
                }

                // See if there are any Members.
                if (context.Member.Any())
                {
                    // DB has already been seeded.
                    return;
                }

                context.Member.AddRange(
                    new Member
                    {
                        FirstName = "Cameron",
                        LastName = "Fuller",
                        MemberTitle = Title.Bishop,
                        TopicChoice = Topic.Abuse,
                    },

                    new Member
                    {
                        FirstName = "Austin",
                        LastName = "Donovan",
                        MemberTitle = Title.President,
                        TopicChoice = Topic.Suicide,
                    },

                    new Member
                    {
                        FirstName = "Becky",
                        LastName = "Tieman",
                        MemberTitle = Title.Sister,
                        TopicChoice = Topic.Justice,
                    },

                    new Member
                    {
                        FirstName = "Daren",
                        LastName = "Tibbitts",
                        MemberTitle = Title.Brother,
                        TopicChoice = Topic.Creation,
                    },

                    new Member
                    {
                        FirstName = "Rick",
                        LastName = "Smith",
                        MemberTitle = Title.Patriarch,
                        TopicChoice = Topic.Dating,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
