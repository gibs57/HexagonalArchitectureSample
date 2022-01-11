using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HexaArchitecture.DomainApi.Model.Visitor
{
    public class Site
    {
        public int SiteID { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string SmallAddress { get; set; }

        [Required]
        public bool Enabled { get; set; }
    }
}
