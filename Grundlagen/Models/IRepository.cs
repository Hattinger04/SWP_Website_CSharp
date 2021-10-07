using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen.Models
{
    // Interface: Schnittstelle
    // gibt nur die Methodenköpfe vor - es ist kein Programmcode vorhanden
    // Interface ist ein Vertrag für eine Klasse - diese muss alle Methoden ausprogrammieren 

    interface IRepository
    {
        void Open();
        void Close();
        bool Insert(Person p); 
        
        //usw.
    }
}
