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

        [Display(Name = "Topic")]
        public Topic TopicChoice { get; set; }

        public string FullName
        {
            get
            {
                var fullName = $"{FirstName} {LastName}";

                return fullName;
            }
           
        }

        public string CallingAndName
        {
            get
            {
                var callingAndName = $"{MemberTitle} {FirstName} {LastName}";

                return callingAndName; 
            }
        }
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

    public enum Topic
    {
        None = 0,
        Any = 1,
        Abortion,
        Abuse,
        Addiction,
        Adoption,
        Adversity,
        Apostle,
        Atonement,
        Baptism,
        Bible,
        Charity,
        Chastity,
        Christmas,
        Communication,
        Conscience,
        Consecration,
        Conversion,
        Covenant,
        Creation,
        Cross,
        Dating,
        Deacon,
        Death,
        Debt,
        Disabilities,
        Dispensations,
        Divorce,
        Easter,
        Education,
        Employment,
        Endowment,
        Family,
        Foreordination,
        Forgiveness,
        Gambling,
        Gardening,
        Garments,
        Godhead,
        Gospel,
        Grace,
        Gratitude,
        Grief,
        Happiness,
        Health,
        Heaven,
        Hell,
        Honesty,
        Hope,
        Humility,
        Immortality,
        Jesus,
        Justice,
        Love,
        Marriage,
        Media,
        Mercy,
        Millennium,
        Ministering,
        Miracles,
        Modesty,
        Mormonism,
        Mormons,
        Mortality,
        Music,
        Noah,
        Obedience,
        Ordinances,
        Paradise,
        Parenting,
        Patriarch,
        Peace,
        Pornography,
        Postmortality,
        Prayer,
        Premortality,
        Priest,
        Priesthood,
        Primary,
        Profanity,
        Prophecy,
        Prophets,
        Quorum,
        Resurrection,
        Revelation,
        Reverence,
        Sacrament,
        Sacrifice,
        Salvation,
        Satan,
        Scriptures,
        Sealing,
        Service,
        Signs,
        Sin,
        Soul,
        Spirit,
        Stewardship,
        Suicide,
        Temples,
        Temptation,
        Testimony,
        Tithing,
        Transgender,
        Transgression,
        Unity,
        Virtue,
        War,
        Witness,
        Worship,
        Zion
    }
}
