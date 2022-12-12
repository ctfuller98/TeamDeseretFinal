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
        [Required]
        public string? OpeningPrayer { get; set; }


        [Display(Name = "Closing Prayer")]
        [Required]
        public string? ClosingPrayer { get; set; }

        [Display(Name = "Speaker")]
        public string? SpeakerOne { get; set; }

        [Display(Name = "Speaker Two")]
        public string? SpeakerTwo { get; set; }

        [Display(Name = "Speaker Three")]
        public string? SpeakerThree { get; set; }

        [Display(Name = "Speaker Four")]
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
