using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen.Models
{
    // Vererbung: ctor's werden nicht vererbt -> müssen nur programmiert werden
    // protected ... ist nur in der Klasse und allen Unterklassen verwendbar 
    class Student : Person
    {

        public string sClass { get; set; }

        public Student() : this(0, "", "", 0.0m, Department.notSpecifified, DateTime.MinValue, "-")
        {

        }
        public Student(int id, string firstname, string lastname, decimal salary, Department dep, DateTime birthdate, string sClass) 
        : base(id, firstname, lastname, salary, dep, birthdate)
        {
            // zusätzliche Felder setzen
            this.sClass = sClass;
        }

        public override string ToString()
        {
            // mit base kann auf die Members der Basisklasse zugegriffen werden 
            // nur auf public und protected members 
            return base.ToString();
        }


    }
}
