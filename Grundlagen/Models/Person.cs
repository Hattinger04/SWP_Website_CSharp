using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen.Models
{
    class Person
    {
        // fields
        private int personid;
        private decimal salary;

        // Properties   - automatische (falls keien Überprüfung notwendig ist)
        //              - normale (falls keine Überprüfung notwendig ist)
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int PersonId {
            get { return this.personid; }
            private set
            {
                if (value >= 0)
                {
                    this.personid = value;
                }
            }
        }
        public decimal Salary {
            get { return this.salary; }
            set
            {
                if (value >= 0)
                {
                    this.salary = value;
                }
            }
        }
        public DateTime Birthdate { get; set; }
        public string Name { get { return this.Lastname + " " + this.Firstname; } }
        // ctors

        public Person() : this(0, "", "", 0.0m, Department.WI, DateTime.MinValue) {}
        public Person(int id, string firstname, string lastname, decimal salary, Department dep, DateTime birthdate)
        {
            this.PersonId = id;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Salary = salary; 
            
        }

        // ToString + other methods
        public override string ToString()
        {
            return "ID = " + this.PersonId + " " + this.Firstname + " " + this.Lastname + " " + this.Birthdate.ToLongDateString();
        }
    
    }
}
