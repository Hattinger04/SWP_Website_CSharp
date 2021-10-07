using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen.Models
{
    class Lehrer
    {
        private int lehrerID;
        private string firstname;
        private string lastname;
        private int popularity;

        public int LehrerID
        {
            get { return this.lehrerID; }
            private set { 
                if (value > 0) {
                    this.lehrerID = value;
                }
             }
        }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Popularity
        {
            get { return this.popularity; } 
            set
            {
                if(value >= 0 && value <= 10)
                {
                    this.popularity = value; 
                }
            }
        }

        public Lehrer() : this(0, "", "", 5) { }

        public Lehrer(int lehrerID, string firstname, string lastname, int popularity)
        {
            this.LehrerID = lehrerID;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Popularity = popularity; 
        }
        public override string ToString()
        {
            return "ID = " + LehrerID + " Vorname: " + Firstname + " Nachname: " + Lastname + " Beliebtheit: " + Popularity; 
        }
    }
}
