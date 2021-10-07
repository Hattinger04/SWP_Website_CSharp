using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen.Models
{
    // Implementieren des Interfaces
    class RepositoryDB : IRepository
    {
        public void Close()
        {
            // hier würde der Code stehen, um die Verbindung zur DB zu schließen
            throw new NotImplementedException();
        }

        public bool Insert(Person p)
        {
            // Code um eine Person in der DB abzuspeichern 
            throw new NotImplementedException();
        }

        public void Open()
        {
            // Code, um die Verbindung zu öffnen
            throw new NotImplementedException();
        }
    }
}
