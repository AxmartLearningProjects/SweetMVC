using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SweetMVC.Models
{
    public class Bakery
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal Bakery_Value { get; set; }
        public DateTime Founding_Date { get; set; }

    }
}
