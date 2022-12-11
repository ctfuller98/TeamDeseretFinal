using Microsoft.AspNetCore.Mvc.Rendering;

namespace SacramentMeetingPlanner.Models
{
    public class MemberViewModel
    {
        public string SelectedMember { get; set;  }
        public List<SelectListItem> MembersSelectList { get; set; }

        public Member newMember { get; set; }

        public Meeting newMeeting { get; set;  }

    }
}
