using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkProject.Models;

namespace HomeworkProject.Interfaces
{
    public interface ISpeakerValidator
    {
        void ValidatePresonalInfo(Speaker speaker);
        bool MeetsBasicRequirements(Speaker speaker);
        bool HasValidEmailDomain(Speaker speaker);
        bool HasValidBrowser(Speaker speaker);
    }
}
