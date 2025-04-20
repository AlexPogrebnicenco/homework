using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProject
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Product { get; set; }
        public string ProductType { get; set; }
    }
}
