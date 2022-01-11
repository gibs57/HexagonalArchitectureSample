using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HexaArchitecture.DomainApi.Model.Visitor
{
    public class Visit
    {
        [Key]
        public int VisitID { get; set; }
        public int? GroupVisitID { get; set; }
        public int VisitorID { get; set; }

        [Required]
        public string TransmitterEmployeeID { get; set; }
        [Required]
        public string TransmitterFullname { get; set; }
        public string TransmitterMobilePhone { get; set; }

        [Required]
        public string VisitedEmployeeID { get; set; }
        [Required]
        public string VisitedFullname { get; set; }

        public int SiteID { get; set; }
        public bool IsReducedMobility { get; set; }
        public bool IsIdentityMandatory { get; set; }
        public bool IsAllowedToPass { get; set; }
        public string Note { get; set; }

        public DateTime VisitRegistrationDate { get; set; }
        public DateTime VisitDate { get; set; }
        public DateTime? VisitBeginDate { get; set; }
        public DateTime? VisitEndDate { get; set; }
        public string BadgeNumber { get; set; }
        public string MessageSentTo { get; set; }
        public VisitStatus VisitStatus { get; set; }
        public VisitType VisitType { get; set; }

        public Visitor Visitor { get; set; }
        public Site Site { get; set; }

        // These fields are inverted compared to normal logic because of an issue with EFCore 1.x & 2.x related to default bool columns with a default value of 'true'
        // One way to fix this is using nullable types but we don't want NULL inside our database
        // see https://github.com/aspnet/EntityFrameworkCore/issues/7089
        // EFCore 3.0 will probably fix this behavior https://github.com/aspnet/EntityFrameworkCore/issues/15182
        public bool DontSendSMSToTransmitter { get; set; }
        public bool DontSendEmailToTransmitter { get; set; }
        public bool DontSendSMSToVisited { get; set; }
        public bool DontSendEmailToVisited { get; set; }
    }

    /// <summary>Repertory all visit status on stadium</summary>
    public enum VisitStatus
    {
        /// <summary>Visit expected</summary>
        [Display(Name = "Expected")]
        EXPECTED = 0,

        /// <summary>Visit began</summary>
        [Display(Name = "Began")]
        BEGAN = 1,

        /// <summary>Visit finished</summary>
        [Display(Name = "Finished")]
        FINISHED = 2,

        /// <summary>Waiting before inform visited (Only for visit grouped)</summary>
        [Display(Name = "Waiting")]
        WAITING = 3,

        /// <summary>Visit started but not ended</summary>
        [Display(Name = "Not ended")]
        NOTENDED = 4,

        /// <summary>Visit abandonned (never started)</summary>
        [Display(Name = "Abandonned")]
        ABANDONNED = 5,
    }

    /// <summary>Repertory all visit type</summary>
    public enum VisitType
    {
        /// <summary>Classic visit (visite classique)/summary>
        [Display(Name = "Classic visit")]
        CLASSIC = 0,

        /// <summary>Broadcast/Antenna speaker (Intervenant antenne)/summary>
        [Display(Name = "Broadcast speaker")]
        BROADCASTSPEAKER = 1,

        /// <summary>Lunch or event B to B (Déjeuner ou Evenement B to B)</summary>
        [Display(Name = "Lunch or event B to B")]
        LUNCHEVENT = 2,

        /// <summary>Presse conference projection (Projéction conférence de presse)</summary>
        [Display(Name = "Presse conference projection")]
        PRESSCONFERENCE = 3
    }
}
