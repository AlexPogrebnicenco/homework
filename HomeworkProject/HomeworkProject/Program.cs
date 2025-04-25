using System;
using System.Collections.Generic;
using System.Linq;
using HomeworkProject.Models;
using HomeworkProject.Services;
using HomeworkProject.Interfaces;

namespace HomeworkProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var validator = new SpeakerValidator();
            var sessionService = new SessionApprovalService();
            var feeCalculator = new RegistrationFeeCalculator();

            var speaker = new Speaker(validator, sessionService, feeCalculator)
            {
                FirstName = "Sasha",
                LastName = "Pogrebnicenco",
                Email = "sasha@awesome.dev",
                Exp = 6,
                HasBlog = true,
                BlogURL = "https://myblog.com",
                Certifications = new List<string> { "MCP", "MVP", "MCTS", "MCSA" },
                Employer = "Microsoft",
                Browser = new WebBrowser("Chrome", 109),
                Sessions = new List<Session>
                {
                    new Session
                    {
                        Title = "Intro to ASP.NET Core",
                        Description = "A cool intro to clean backend"
                    }
                }
            };

            var repository = new FakeRepository();

            try
            {
                int? id = speaker.Register(repository);
                Console.WriteLine($"Speaker registered with ID: {id}");
                Console.WriteLine($"Registration fee: {speaker.RegistrationFee}$");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Registration failed: {ex.Message}");
            }

            Console.ReadLine();
        }

        private class FakeRepository : IRepository
        {
            public int SaveSpeaker(Speaker speaker)
            {
                return 123; 
            }
        }
    }
}
