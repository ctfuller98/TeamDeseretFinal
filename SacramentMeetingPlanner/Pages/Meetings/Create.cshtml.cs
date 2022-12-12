using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Migrations;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Pages.Meetings
{
    public class CreateModel : PageModel
    {
        private readonly SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext _context;

        public CreateModel(SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var memberQuery = from m in _context.Member orderby m.LastName select m.FullName;
            Members = new SelectList(await memberQuery.ToListAsync());


            var memberCallingQuery = from m in _context.Member orderby m.LastName select m.CallingAndName;
             CallingMembers = new SelectList(await memberCallingQuery.ToListAsync());
            
            return Page();
        }

        [BindProperty]
        public Meeting Meeting { get; set; }
        public SelectList ? Members { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? MemberList { get; set; }

        //Members with Callings
        public Meeting CallingMeeting { get; set; }
        public SelectList? CallingMembers { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

          if(Meeting.SpeakerOne == "No Speaker" && Meeting.SpeakerTwo == "No Speaker" && Meeting.SpeakerThree == "No Speaker" && Meeting.SpeakerFour == "No Speaker")
            {
                Meeting.SpeakerOne = "Fast Sunday";
                Meeting.SpeakerTwo = "";
                Meeting.SpeakerThree = "";
                Meeting.SpeakerFour = "";
                Meeting.TopicChoiceTwo = null;
                Meeting.TopicChoiceThree = null;
                Meeting.TopicChoiceFour = null;
                Meeting.TopicChoice = Topic.Any;
            }

            _context.Meeting.Add(Meeting);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
