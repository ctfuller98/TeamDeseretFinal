using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Meeting Meeting { get; set; }
        

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
