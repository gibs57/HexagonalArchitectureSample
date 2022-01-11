using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HexaArchitecture.DomainApi.Model.Visitor
{
    public class User
    {
        [Required]
        public string EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
