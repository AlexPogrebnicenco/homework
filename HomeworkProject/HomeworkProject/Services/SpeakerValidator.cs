using System;
using System.Collections.Generic;
using System.Linq;
using HomeworkProject.Models;
using HomeworkProject.Interfaces;

namespace HomeworkProject.Services
{
    public class SpeakerValidator : ISpeakerValidator
    {
        private static readonly List<string> PreferredEmployers = new List<string>
        {
            "Microsoft", "Google", "Fog Creek Software", "37Signals"
        };
        private static readonly List<string> DisallowedEmailDomains = new List<string>
        {
            "aol.com", "hotmail.com", "prodigy.com", "CompuServe.com"
        };


        public void ValidatePresonalInfo(Speaker speaker)
        {
            if (string.IsNullOrWhiteSpace(speaker.FirstName))
                throw new System.ArgumentNullException("First Name is required");

            if (string.IsNullOrWhiteSpace(speaker.LastName))
                throw new System.ArgumentNullException("Last name is required");

            if (string.IsNullOrWhiteSpace(speaker.Email))
                throw new System.ArgumentNullException("Email is required");
        }

        public bool MeetsBasicRequirements(Speaker speaker)
        {
            if (speaker.Exp > 10)
            {
                return true;
            }

            if (speaker.HasBlog)
            {
                return true;
            }

            if ((speaker.Certifications?.Count ?? 0) > 3)
            {
                return true;
            }

            if (PreferredEmployers.Contains(speaker.Employer))
            {
                return true;
            }

            return false;
        }

        public bool HasValidEmailDomain(Speaker speaker)
        {
            var domain = speaker.Email.Split('@').Last();
            return !DisallowedEmailDomains.Contains(domain);
        }

        public bool HasValidBrowser(Speaker speaker)
        {
            return speaker.Browser != null
                && (speaker.Browser.Name != WebBrowser.BrowserName.InternetExplorer
                    || speaker.Browser.MajorVersion >= 9);
        }
    }
}
