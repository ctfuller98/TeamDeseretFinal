using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Pages.Meetings
{
    public class EditModel : PageModel
    {
        private readonly SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext _context;

        public EditModel(SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Meeting Meeting { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {

            var memberQuery = from m in _context.Member orderby m.LastName select m.FullName;
            Members = new SelectList(await memberQuery.ToListAsync());


            var memberCallingQuery = from m in _context.Member orderby m.LastName select m.CallingAndName;
            CallingMembers = new SelectList(await memberCallingQuery.ToListAsync());


            if (id == null || _context.Meeting == null)
            {
                return NotFound();
            }

            var meeting =  await _context.Meeting.FirstOrDefaultAsync(m => m.Id == id);
            if (meeting == null)
            {
                return NotFound();
            }


            Meeting = meeting;
            return Page();
        }
        public SelectList? Members { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? MemberList { get; set; }

        //Members with Callings
        public Meeting CallingMeeting { get; set; }
        public SelectList? CallingMembers { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            var memberQuery = from m in _context.Member orderby m.LastName select m.FullName;
            Members = new SelectList(await memberQuery.ToListAsync());


            var memberCallingQuery = from m in _context.Member orderby m.LastName select m.CallingAndName;
            CallingMembers = new SelectList(await memberCallingQuery.ToListAsync());


            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Meeting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MeetingExists(Meeting.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MeetingExists(int id)
        {
          return _context.Meeting.Any(e => e.Id == id);
        }
    }
}
