using System;
using System.Collections.Generic;
using System.Linq;
using HomeworkProject.Models;
using HomeworkProject.Exceptions;
using System.Diagnostics;

namespace HomeworkProject.Services
{
    public class SessionApprovalService
    {
        private static readonly List<string> OutdatedTechnologies = new List<string> ()
        {
            "Cobol", "Punch Cards", "Commorode", "VBScript"
        };

        public void ApproveSessions(List<Session> sessions)
        {
            if (sessions == null || sessions.Count == 0)
            {
                throw new ArgumentException("Can't register speaker with no session to present");
            }

            bool anyApproved = false;

            foreach (var session in sessions)
            {
                session.IsApproved = !OutdatedTechnologies.Any(tech =>
                    session.Title.IndexOf(tech, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    session.Description.IndexOf(tech, StringComparison.OrdinalIgnoreCase) >= 0);

                if (session.IsApproved) 
                {
                    anyApproved = true;
                }
            }

            if (!anyApproved) 
            {
                throw new NoSessionApprovedException("No session approved.");
            }
        }
    }
}
