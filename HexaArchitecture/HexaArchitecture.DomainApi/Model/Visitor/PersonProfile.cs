using System;
using System.Collections.Generic;
using System.Text;

namespace HexaArchitecture.DomainApi.Model.Visitor
{
    public class PersonProfile
    {
        #region .ctor

        /// <summary>
        /// Instanciates an empty person profile.
        /// </summary>
        public PersonProfile()
        {
        }

        /// <summary>
        /// Instanciates a valuated person profile.
        /// </summary>
        public PersonProfile(string loginAD, string m6ID, string email, string lastName, string firstName, string fullName)
        {
            LoginAD = loginAD;
            M6Id = m6ID;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            FullName = fullName;
        }

        #endregion

        #region Members of IPersonProfile

        /// <inheritdoc />
        public string LoginAD { get; set; }

        /// <inheritdoc />
        public string M6Id { get; set; }

        /// <inheritdoc />
        public string Email { get; set; }

        /// <inheritdoc />
        public string LastName { get; set; }

        /// <inheritdoc />
        public string FirstName { get; set; }

        /// <inheritdoc />
        public string FullName { get; set; }

        /// <inheritdoc />
        public string DeskPhone { get; set; }

        /// <inheritdoc />
        public string MobilePhone { get; set; }

        /// <inheritdoc />
        public IEnumerable<string> Roles { get; set; }
        #endregion
    }
}
