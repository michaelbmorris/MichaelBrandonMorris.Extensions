using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using MichaelBrandonMorris.Extensions.PrimitiveExtensions;

namespace MichaelBrandonMorris.Extensions.PrincipalExtensions
{
    /// <summary>
    ///     Class UserPrincipalExtensions.
    /// </summary>
    /// TODO Edit XML Comment Template for UserPrincipalExtensions
    public static class UserPrincipalExtensions
    {
        /// <summary>
        ///     The assistant
        /// </summary>
        /// TODO Edit XML Comment Template for Assistant
        private const string Assistant = "assistant";

        /// <summary>
        ///     The city
        /// </summary>
        /// TODO Edit XML Comment Template for City
        private const string City = "l";

        /// <summary>
        ///     The comment
        /// </summary>
        /// TODO Edit XML Comment Template for Comment
        private const string Comment = "comment";

        /// <summary>
        ///     The company
        /// </summary>
        /// TODO Edit XML Comment Template for Company
        private const string Company = "company";

        /// <summary>
        ///     The country
        /// </summary>
        /// TODO Edit XML Comment Template for Country
        private const string Country = "c";

        /// <summary>
        ///     The department
        /// </summary>
        /// TODO Edit XML Comment Template for Department
        private const string Department = "department";

        /// <summary>
        ///     The direct reports
        /// </summary>
        /// TODO Edit XML Comment Template for DirectReports
        private const string DirectReports = "directReports";

        /// <summary>
        ///     The division
        /// </summary>
        /// TODO Edit XML Comment Template for Division
        private const string Division = "division";

        /// <summary>
        ///     The employee number
        /// </summary>
        /// TODO Edit XML Comment Template for EmployeeNumber
        private const string EmployeeNumber = "employeeNumber";

        /// <summary>
        ///     The employee number hash
        /// </summary>
        /// TODO Edit XML Comment Template for EmployeeNumberHash
        private const string EmployeeNumberHash = "employeeNumberHash";

        /// <summary>
        ///     The fax
        /// </summary>
        /// TODO Edit XML Comment Template for Fax
        private const string Fax = "facsimileTelephoneNumber";

        /// <summary>
        ///     The home address
        /// </summary>
        /// TODO Edit XML Comment Template for HomeAddress
        private const string HomeAddress = "homePostalAddress";

        /// <summary>
        ///     The home phone
        /// </summary>
        /// TODO Edit XML Comment Template for HomePhone
        private const string HomePhone = "homePhone";

        /// <summary>
        ///     The initials
        /// </summary>
        /// TODO Edit XML Comment Template for Initials
        private const string Initials = "initials";

        /// <summary>
        ///     The manager
        /// </summary>
        /// TODO Edit XML Comment Template for Manager
        private const string Manager = "manager";

        /// <summary>
        ///     The mobile
        /// </summary>
        /// TODO Edit XML Comment Template for Mobile
        private const string Mobile = "mobile";

        /// <summary>
        ///     The notes
        /// </summary>
        /// TODO Edit XML Comment Template for Notes
        private const string Notes = "info";

        /// <summary>
        ///     The pager
        /// </summary>
        /// TODO Edit XML Comment Template for Pager
        private const string Pager = "pager";

        /// <summary>
        ///     The sip
        /// </summary>
        /// TODO Edit XML Comment Template for Sip
        private const string Sip = "msRTCSIP-PrimaryUserAddress";

        /// <summary>
        ///     The state
        /// </summary>
        /// TODO Edit XML Comment Template for State
        private const string State = "st";

        /// <summary>
        ///     The street address
        /// </summary>
        /// TODO Edit XML Comment Template for StreetAddress
        private const string StreetAddress = "streetAddress";

        /// <summary>
        ///     The suffix
        /// </summary>
        /// TODO Edit XML Comment Template for Suffix
        private const string Suffix = "generationQualifier";

        /// <summary>
        ///     The title
        /// </summary>
        /// TODO Edit XML Comment Template for Title
        private const string Title = "title";

        /// <summary>
        ///     The user account control
        /// </summary>
        /// TODO Edit XML Comment Template for UserAccountControl
        private const string UserAccountControl = "userAccountControl";

        /// <summary>
        ///     The voip
        /// </summary>
        /// TODO Edit XML Comment Template for Voip
        private const string Voip = "ipPhone";

        /// <summary>
        ///     Finds the name of the by distinguished.
        /// </summary>
        /// <param name="principalContext">The principal context.</param>
        /// <param name="distinguishedName">Name of the distinguished.</param>
        /// <returns>UserPrincipal.</returns>
        /// TODO Edit XML Comment Template for FindByDistinguishedName
        public static UserPrincipal FindByDistinguishedName(
            PrincipalContext principalContext,
            string distinguishedName)
        {
            return UserPrincipal.FindByIdentity(
                principalContext,
                IdentityType.DistinguishedName,
                distinguishedName);
        }

        /// <summary>
        ///     Gets the assistant.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetAssistant
        public static string GetAssistant(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Assistant);
        }

        /// <summary>
        ///     Gets the city.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetCity
        public static string GetCity(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(City);
        }

        /// <summary>
        ///     Gets the comment.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetComment
        public static string GetComment(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Comment);
        }

        /// <summary>
        ///     Gets the company.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetCompany
        public static string GetCompany(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Company);
        }

        /// <summary>
        ///     Gets the country.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetCountry
        public static string GetCountry(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Country);
        }

        /// <summary>
        ///     Gets the department.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetDepartment
        public static string GetDepartment(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Department);
        }

        /// <summary>
        ///     Gets the direct report distinguished names.
        /// </summary>
        /// <param name="userPrincipal">The user principal.</param>
        /// <returns>IEnumerable&lt;System.String&gt;.</returns>
        /// TODO Edit XML Comment Template for GetDirectReportDistinguishedNames
        public static IEnumerable<string> GetDirectReportDistinguishedNames(
            this UserPrincipal userPrincipal)
        {
            return userPrincipal.GetProperty(DirectReports)
                .Cast<string>()
                .Where(dn => !dn.IsNullOrWhiteSpace());
        }

        /// <summary>
        ///     Gets the division.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetDivision
        public static string GetDivision(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Division);
        }

        /// <summary>
        ///     Gets the employee number.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetEmployeeNumber
        public static string GetEmployeeNumber(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(EmployeeNumber);
        }

        /// <summary>
        ///     Gets the employee number hash.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetEmployeeNumberHash
        public static string GetEmployeeNumberHash(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(EmployeeNumberHash);
        }

        /// <summary>
        ///     Gets the fax.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetFax
        public static string GetFax(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Fax);
        }

        /// <summary>
        ///     Gets the home address.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetHomeAddress
        public static string GetHomeAddress(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(HomeAddress);
        }

        /// <summary>
        ///     Gets the home phone.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetHomePhone
        public static string GetHomePhone(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(HomePhone);
        }

        /// <summary>
        ///     Gets the initials.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetInitials
        public static string GetInitials(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Initials);
        }

        /// <summary>
        ///     Gets the name of the manager distinguished.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetManagerDistinguishedName
        public static string GetManagerDistinguishedName(
            this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Manager);
        }

        /// <summary>
        ///     Gets the name of the manager.
        /// </summary>
        /// <param name="userPrincipal">The user principal.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetManagerName
        public static string GetManagerName(this UserPrincipal userPrincipal)
        {
            var managerDistinguishedName =
                userPrincipal.GetManagerDistinguishedName();
            if (managerDistinguishedName.IsNullOrWhiteSpace())
            {
                return null;
            }
            using (var managerUserPrincipal = UserPrincipal.FindByIdentity(
                PrincipalContextExtensions.GetPrincipalContext(),
                IdentityType.DistinguishedName,
                managerDistinguishedName))
            {
                return managerUserPrincipal?.Name;
            }
        }

        /// <summary>
        ///     Gets the mobile.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetMobile
        public static string GetMobile(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Mobile);
        }

        /// <summary>
        ///     Gets the notes.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetNotes
        public static string GetNotes(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Notes);
        }

        /// <summary>
        ///     Gets the pager.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetPager
        public static string GetPager(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Pager);
        }

        /// <summary>
        ///     Gets the sip.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetSip
        public static string GetSip(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Sip);
        }

        /// <summary>
        ///     Gets the state.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetState
        public static string GetState(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(State);
        }

        /// <summary>
        ///     Gets the street address.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetStreetAddress
        public static string GetStreetAddress(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(StreetAddress);
        }

        /// <summary>
        ///     Gets the suffix.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetSuffix
        public static string GetSuffix(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Suffix);
        }

        /// <summary>
        ///     Gets the title.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetTitle
        public static string GetTitle(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Title);
        }

        /// <summary>
        ///     Gets the user account control.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetUserAccountControl
        public static string GetUserAccountControl(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(UserAccountControl);
        }

        /// <summary>
        ///     Gets the voip.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetVoip
        public static string GetVoip(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Voip);
        }

        /// <summary>
        ///     Determines whether the specified user is active.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>
        ///     <c>true</c> if the specified user is active;
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsActive
        public static bool IsActive(this UserPrincipal user)
        {
            return !Convert.ToBoolean(
                (int) user.GetProperty(UserAccountControl).Value & 0x0002);
        }
    }
}