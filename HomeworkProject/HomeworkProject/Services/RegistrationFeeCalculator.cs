using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProject.Services
{
    public class RegistrationFeeCalculator
    {
        public int Calculate(int? experience)
        {
            if (!experience.HasValue) return 500;

            int exp = experience.Value;

            switch (exp)
            {
                case int e when e <= 1: 
                    return 500;
                case int e when e <= 3:
                    return 250;
                case int e when e <= 5:
                    return 100;
                case int e when e <= 9:
                    return 50;
                default:
                    return 0;
            }
        }
    }
}
