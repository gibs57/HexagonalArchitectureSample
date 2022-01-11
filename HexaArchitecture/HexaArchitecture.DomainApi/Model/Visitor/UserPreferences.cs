using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HexaArchitecture.DomainApi.Model.Visitor
{
    public class UserPreferences
    {
        [Required]
        [Key]
        [ForeignKey("User")]
        public string EmployeeID { get; set; }

        [Required]
        public User User { get; set; }

        public string PhoneNumber { get; set; }
        public int? Site { get; set; }
        public string DelegationEmployeeID { get; set; }

        [Required]
        public bool AskID { get; set; } = true;

        [Required]
        public bool TransmitterSendSMS { get; set; } = true;

        [Required]
        public bool TransmitterSendEmail { get; set; } = true;

        [Required]
        public bool IsDelegation { get; set; } = false;

        [Required]
        public bool DelegationSendSMS { get; set; } = true;

        [Required]
        public bool DelegationSendEmail { get; set; } = true;

        [Required]
        public bool LetVisitorsPass { get; set; }
    }
}
