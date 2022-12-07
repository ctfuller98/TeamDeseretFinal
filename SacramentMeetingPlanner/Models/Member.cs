using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;

namespace SacramentMeetingPlanner.Models
{
    public class Member
    {
        public int ID { get; set; }

        [Display (Name = "First Name")]
        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        public string LastName { get; set; }

        [Display (Name = "Title")]
        [Required]
        public Title MemberTitle { get; set; }
    }

    public enum Title
    {
        President,
        Bishop,
        Elder,
        Sister,
        Brother,
        Patriarch
    }
}
