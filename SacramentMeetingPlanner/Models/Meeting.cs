using System.ComponentModel;
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
        [Range(1, 341)]
        [Required]
        public int OpeningHymnNumber { get; set; }


        [Display(Name = "Sacrament Hymn")]
        [Range(1, 341)]
        [Required]
        public int SacramentHymnNumber { get; set; }


        [Display(Name = "Rest Hymn")]
        [Range(1, 341)]
        public int? RestHymnNumber { get; set; }


        [Display(Name = "Closing Hymn")]
        [Range(1, 341)]
        [Required]
        public int ClosingHymn { get; set; }


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

        [Display(Name = "Speaker")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(50, MinimumLength = 3)]
        public string? SpeakerOne { get; set; }

        [Display(Name = "Speaker Two")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(50, MinimumLength = 3)]
        public string? SpeakerTwo { get; set; }

        [Display(Name = "Speaker Three")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(50, MinimumLength = 3)]
        public string? SpeakerThree { get; set; }

        [Display(Name = "Speaker Four")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(50, MinimumLength = 3)]
        public string? SpeakerFour { get; set; }

        [Display(Name = "Topic")]
        public Topic? TopicChoice { get; set; } = 0;

        [Display(Name = "Topic")]
        public Topic? TopicChoiceTwo { get; set; }

        [Display(Name = "Topic")]
        public Topic? TopicChoiceThree { get; set; }

        [Display(Name = "Topic")]
        public Topic? TopicChoiceFour { get; set; } 
    }
}
