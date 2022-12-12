using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SacramentMeetingPlanner.Models
{
    public class Meeting
    {
        public int Id { get; set; }

        [Display(Name = "Meeting Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime MeetingDate { get; set; }


        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string? Conductor { get; set; }


        [Display(Name = "Opening Hymn")]
        [StringLength(200)]
        [Required]
        public string OpeningHymnNumber { get; set; }


        [Display(Name = "Sacrament Hymn")]
        [StringLength(200)]
        [Required]
        public string SacramentHymnNumber { get; set; }


        [Display(Name = "Rest Hymn")]
        [StringLength(200)]
        public string? RestHymnNumber { get; set; }


        [Display(Name = "Closing Hymn")]
        [StringLength(200)]
        [Required]
        public string ClosingHymnNumber { get; set; }


        [Display(Name = "Opening Prayer")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string? OpeningPrayer { get; set; }


        [Display(Name = "Closing Prayer")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string? ClosingPrayer { get; set; }

        public ICollection<Member> Members { get; set; }
    }
}
