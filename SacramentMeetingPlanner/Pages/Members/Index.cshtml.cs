using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext _context;

        public IndexModel(SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList WardMembersList { get; set; }
        [BindProperty(SupportsGet = true)]
        public string WardMembers { get; set; }

        public async Task OnGetAsync()
        {
            var members = from m in _context.Member select m;

            /*if (_context.Member != null)
            {
                Member = await _context.Member.ToListAsync();
            }*/

            if (!string.IsNullOrEmpty(SearchString))
            {
                members = members.Where(s => s.LastName.Contains(SearchString)); // || members.Where(s => s.FirstName.Contains(SearchString));
            }

            //Member = await _context.Member.ToListAsync();
            Member = await members.ToListAsync();
        }
    }
}
