using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using MichaelBrandonMorris.Extensions.PrimitiveExtensions;

namespace MichaelBrandonMorris.Extensions.PrincipalExtensions
{
    /// <summary>
    /// Provides useful extensions for the <see cref="UserPrincipal"/> class.
    /// </summary>
    public static class UserPrincipalExtensions
    {
        private const string Assistant = "assistant";
        private const string City = "l";
        private const string Comment = "comment";
        private const string Company = "company";
        private const string Country = "c";
        private const string Department = "department";
        private const string DirectReports = "directReports";
        private const string Division = "division";
        private const string Fax = "facsimileTelephoneNumber";
        private const string HomeAddress = "homePostalAddress";
        private const string HomePhone = "homePhone";
        private const string Initials = "initials";
        private const string Manager = "manager";
        private const string Mobile = "mobile";
        private const string Notes = "info";
        private const string Pager = "pager";
        private const string Sip = "msRTCSIP-PrimaryUserAddress";
        private const string State = "st";
        private const string StreetAddress = "streetAddress";
        private const string Suffix = "generationQualifier";
        private const string Title = "title";
        private const string UserAccountControl = "userAccountControl";
        private const string Voip = "ipPhone";

        /// <summary>
        /// Gets the assistant property of this <see cref="UserPrincipal"/>'s 
        /// underlying <see cref="DirectoryEntry"/>.
        /// </summary>
        public static string GetAssistant(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Assistant);
        }

        /// <summary>
        /// Gets the city property of this <see cref="UserPrincipal"/>'s 
        /// underlying <see cref="DirectoryEntry"/>.
        /// </summary>
        public static string GetCity(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(City);
        }

        /// <summary>
        /// Gets the comment property of this <see cref="UserPrincipal"/>'s 
        /// underlying <see cref="DirectoryEntry"/>.
        /// </summary>
        public static string GetComment(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Comment);
        }

        /// <summary>
        /// Gets the company property of this <see cref="UserPrincipal"/>'s 
        /// underlying <see cref="DirectoryEntry"/>.
        /// </summary>
        public static string GetCompany(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Company);
        }

        /// <summary>
        /// Gets the country property of this <see cref="UserPrincipal"/>'s 
        /// underlying <see cref="DirectoryEntry"/>.
        /// </summary>
        public static string GetCountry(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Country);
        }

        /// <summary>
        /// Gets the department property of this <see cref="UserPrincipal"/>'s 
        /// underlying <see cref="DirectoryEntry"/>.
        /// </summary>
        public static string GetDepartment(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Department);
        }

        /// <summary>
        /// Gets the distinguished names contained in the direct reports 
        /// property of this <see cref="UserPrincipal"/>'s underlying 
        /// <see cref="DirectoryEntry"/>.
        /// </summary>
        public static IEnumerable<string> GetDirectReportDistinguishedNames(
            this UserPrincipal userPrincipal)
        {
            return userPrincipal.GetProperty(DirectReports).Cast<string>()
                .Where(dn => !dn.IsNullOrWhiteSpace());
        }

        /// <summary>
        /// Gets the division property of this <see cref="UserPrincipal"/>'s 
        /// underlying <see cref="DirectoryEntry"/>.
        /// </summary>
        public static string GetDivision(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Division);
        }

        /// <summary>
        /// Gets the fax property of this <see cref="UserPrincipal"/>'s 
        /// underlying <see cref="DirectoryEntry"/>.
        /// </summary>
        public static string GetFax(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Fax);
        }

        /// <summary>
        /// Gets the home address property of this <see cref="UserPrincipal"/>'s 
        /// underlying <see cref="DirectoryEntry"/>.
        /// </summary>
        public static string GetHomeAddress(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(HomeAddress);
        }

        /// <summary>
        /// Gets the home phone property of this <see cref="UserPrincipal"/>'s 
        /// underlying <see cref="DirectoryEntry"/>.
        /// </summary>
        public static string GetHomePhone(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(HomePhone);
        }

        /// <summary>
        /// Gets the initials property of this <see cref="UserPrincipal"/>'s 
        /// underlying <see cref="DirectoryEntry"/>.
        /// </summary>
        public static string GetInitials(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Initials);
        }

        /// <summary>
        /// Gets the country manager of this <see cref="UserPrincipal"/>'s 
        /// underlying <see cref="DirectoryEntry"/>.
        /// </summary>
        public static string GetManagerDistinguishedName(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Manager);
        }

        /// <summary>
        /// Gets the name of this <see cref="UserPrincipal"/>'s manager.
        /// </summary>
        /// <param name="userPrincipal"></param>
        /// <returns></returns>
        public static string GetManagerName(this UserPrincipal userPrincipal)
        {
            var managerDistinguishedName =
                userPrincipal.GetManagerDistinguishedName();
            if (managerDistinguishedName.IsNullOrWhiteSpace()) return null;
            using (var managerUserPrincipal = UserPrincipal.FindByIdentity(
                PrincipalContextExtensions.GetPrincipalContext(),
                IdentityType.DistinguishedName, managerDistinguishedName))
                return managerUserPrincipal?.Name;
        }

        /// <summary>
        /// Gets the mobile property of this <see cref="UserPrincipal"/>'s 
        /// underlying <see cref="DirectoryEntry"/>.
        /// </summary>
        public static string GetMobile(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Mobile);
        }

        /// <summary>
        /// Gets the country property of this <see cref="UserPrincipal"/>'s 
        /// underlying <see cref="DirectoryEntry"/>.
        /// </summary>
        public static string GetNotes(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Notes);
        }

        /// <summary>
        /// Gets the pager property of this <see cref="UserPrincipal"/>'s 
        /// underlying <see cref="DirectoryEntry"/>.
        /// </summary>
        public static string GetPager(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Pager);
        }

        /// <summary>
        /// Gets the sip property of this <see cref="UserPrincipal"/>'s 
        /// underlying <see cref="DirectoryEntry"/>.
        /// </summary>
        public static string GetSip(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Sip);
        }

        /// <summary>
        /// Gets the state property of this <see cref="UserPrincipal"/>'s 
        /// underlying <see cref="DirectoryEntry"/>.
        /// </summary>
        public static string GetState(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(State);
        }

        /// <summary>
        /// Gets the street address property of this <see cref="UserPrincipal"/>'s 
        /// underlying <see cref="DirectoryEntry"/>.
        /// </summary>
        public static string GetStreetAddress(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(StreetAddress);
        }

        /// <summary>
        /// Gets the suffix property of this <see cref="UserPrincipal"/>'s 
        /// underlying <see cref="DirectoryEntry"/>.
        /// </summary>
        public static string GetSuffix(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Suffix);
        }

        /// <summary>
        /// Gets the title property of this <see cref="UserPrincipal"/>'s 
        /// underlying <see cref="DirectoryEntry"/>.
        /// </summary>
        public static string GetTitle(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Title);
        }

        /// <summary>
        /// Gets the user account control property of this 
        /// <see cref="UserPrincipal"/>'s underlying <see cref="DirectoryEntry"/>.
        /// </summary>
        public static string GetUserAccountControl(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(UserAccountControl);
        }

        /// <summary>
        /// Gets the Voip property of this <see cref="UserPrincipal"/>'s 
        /// underlying <see cref="DirectoryEntry"/>.
        /// </summary>
        public static string GetVoip(this UserPrincipal user)
        {
            return user.GetPropertyValueAsString(Voip);
        }

        /// <summary>
        /// Whether or not this <see cref="UserPrincipal"/>'s underlying 
        /// <see cref="DirectoryEntry"/> is active.
        /// </summary>
        public static bool IsActive(this UserPrincipal user)
        {
            return !Convert.ToBoolean(
                (int) user.GetProperty(UserAccountControl).Value & 0x0002);
        }

        public static UserPrincipal FindByDistinguishedName(
            PrincipalContext principalContext, string distinguishedName)
        {
                return UserPrincipal.FindByIdentity(
                    principalContext,
                    IdentityType.DistinguishedName,
                    distinguishedName);
        }
    }
}