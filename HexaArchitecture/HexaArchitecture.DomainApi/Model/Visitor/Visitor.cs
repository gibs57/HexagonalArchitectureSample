using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HexaArchitecture.DomainApi.Model.Visitor
{
    public class Visitor
    {
        public int ID { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string Company { get; set; }
        public bool IsPurged { get; set; }

    }
}
