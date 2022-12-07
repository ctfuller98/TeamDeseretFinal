using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;

namespace SacramentMeetingPlanner.Models
{
    public class Member
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
    }
}
