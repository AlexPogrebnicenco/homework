using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkProject.Models;

namespace HomeworkProject.Interfaces
{
    public interface IRepository
    {
        int SaveSpeaker(Speaker speaker);
    }
}
