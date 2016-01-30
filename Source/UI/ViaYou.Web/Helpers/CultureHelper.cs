using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace ViaYou.Web.Helpers
{
    public static class CultureHelper
    {
        // Valid cultures
        private static readonly List<string> ValidCultures = new List<string> { "ES", "EN" };
        // Include ONLY cultures you are implementing
        private static readonly List<string> Cultures = new List<string>
        {
            "EN", // first culture is the DEFAULT
            "ES", // Spanish NEUTRAL culture

        };
        /// <summary>
        /// Returns true if the language is a right-to-left language. Otherwise, false.
        /// </summary>
        public static bool IsRighToLeft()
        {
            return Thread.CurrentThread.CurrentCulture.TextInfo.IsRightToLeft;

        }
        /// <summary>
        /// Returns a valid culture name based on "name" parameter. If "name" is not valid, it returns the default culture "en-US"
        /// </summary>
        /// <param name="name" />Culture's name (e.g. en-US)
        public static string GetImplementedCulture(string name)
        {
            // make sure it's not null
            if (string.IsNullOrEmpty(name))
                return GetDefaultCulture(); // return Default culture
            // make sure it is a valid culture first
            if (!ValidCultures.Any(c => c.Equals(name, StringComparison.InvariantCultureIgnoreCase)))
                return GetDefaultCulture(); // return Default culture if it is invalid
            // if it is implemented, accept it
            if (Cultures.Any(c => c.Equals(name, StringComparison.InvariantCultureIgnoreCase)))
                return name; // accept it
            // Find a close match. For example, if you have "en-US" defined and the user requests "en-GB",
            // the function will return closes match that is "en-US" because at least the language is the same (ie English) 
            var n = GetNeutralCulture(name);
            foreach (var c in Cultures)
                if (c.StartsWith(n))
                    return c;
            // else
            // It is not implemented
            return GetDefaultCulture(); // return Default culture as no match found
        }
        /// <summary>
        /// Returns default culture name which is the first name decalared (e.g. en-US)
        /// </summary>
        /// <returns></returns>
        public static string GetDefaultCulture()
        {
            return Cultures[0]; // return Default culture
        }
        public static string GetCurrentCulture()
        {
            return Thread.CurrentThread.CurrentCulture.Name;
        }

        public static string GetCurrentNeutralCulture()
        {
            return GetNeutralCulture(Thread.CurrentThread.CurrentCulture.Name);
        }
        public static string GetNeutralCulture(string name)
        {
            if (name.Length < 2)
                return name;
            return name.Substring(0, 2); // Read first two chars only. E.g. "en", "es"
        }

        public static void SetCurrentCulture(string culture)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
        }
    }
}