using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnTX1.Models
{
    public class Emps
    {
        public Emps()
        {
        }

        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public string year { get; set; }
        public string month { get; set; }
        public string hobby { get; set; }
        public double salary { get; set; }
        public int number { get; set; }
        public double luongthuc
        {
            get
            {
                if (number >= 25)
                {
                    return salary * 1.1;
                }
                else if (number >= 20)
                {
                    return salary * 1.05;
                }
                else
                {
                    return salary;
                }
            }
        }

        public Emps(string firstname, string lastname, string gender, string year, string month, string hobby, double salary, int number)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.year = year;
            this.month = month;
            this.hobby = hobby;
            this.salary = salary;
            this.number = number;
        }
    }
}