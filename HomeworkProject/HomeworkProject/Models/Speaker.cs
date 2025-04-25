using System;
using HomeworkProject.Interfaces;
using HomeworkProject.Services;
using HomeworkProject.Exceptions;
using System.Collections.Generic;

namespace HomeworkProject.Models
{
    public class Speaker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? Exp { get; set; }
        public bool HasBlog { get; set; }
        public string BlogURL { get; set; }
        public WebBrowser Browser { get; set; }
        public List<string> Certifications { get; set; }
        public string Employer { get; set; }
        public int RegistrationFee { get; set; }
        public List<Session> Sessions { get; set; }

        private readonly ISpeakerValidator _validator;
        private readonly SessionApprovalService _sessionService;
        private readonly RegistrationFeeCalculator _feeCalculator;

        public Speaker(
            ISpeakerValidator validator,
            SessionApprovalService sessionService,
            RegistrationFeeCalculator feeCalculator
            )
        {
            _validator = validator;
            _sessionService = sessionService;
            _feeCalculator = feeCalculator;
        }

        public int? Register(IRepository repository)
        {
            _validator.ValidatePresonalInfo(this);

            bool eligible = _validator.MeetsBasicRequirements(this) || (_validator.HasValidEmailDomain(this) && _validator.HasValidBrowser(this));

            if (!eligible)
            {
                throw new SpeakerRequirementsNotMetException("Speaker does not meet requirements.");
            }

            _sessionService.ApproveSessions(Sessions);
            RegistrationFee = _feeCalculator.Calculate(Exp);
            return repository.SaveSpeaker(this);
        }
    }
}
