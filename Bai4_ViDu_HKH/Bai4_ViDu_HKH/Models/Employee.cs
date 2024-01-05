using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai4_ViDu_HKH.Models
{
    public class Employee
    {
        public string id { get; set; }
        public string name { get; set; }
        public int amount { get; set; }
        public double salary { get; set; }
        public double bonus 
        { 
            get
            {
                if (amount >= 27) return salary * 0.1;
                else if (amount >= 24) return salary * 0.05;
                else return 0;
            }
        }
        public double total 
        { 
            get
            {
                return salary + bonus;
            }
        }
        public Employee()
        {

        }
        public Employee(string id, string name, int amount, double salary)
        {
            this.id = id;
            this.name = name;
            this.amount = amount;
            this.salary = salary;
        }
    }
}