using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen.Models
{
    // es kann Methoden geben, die abstrakt sind (keinen Programmcode) und welche, die nicht abstrakt sind
    abstract class AbstractClass
    {
        // Normale nicht abstrakte Methode
        public int Do()
        {
            return 10; 
        }
        abstract public string Do2(); 
    }
}
