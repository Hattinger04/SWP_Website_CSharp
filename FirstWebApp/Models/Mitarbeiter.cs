using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Models
{
    public class Mitarbeiter
    {
        private int mitarbeiterID;
        private decimal gehalt; 
        public int MitarbeiterID
        {
            get { return this.mitarbeiterID; }
            set
            {
                if(value >= 0)
                {
                    this.mitarbeiterID = value; 
                }
            }
        }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public decimal Gehalt { 
            get { return this.gehalt; }
            set
            {
                if(value >= 1500)
                {
                    this.gehalt = value; 
                }
            }
        }
    }
}
