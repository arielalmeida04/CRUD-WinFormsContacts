using Proyecto1Repositorio.Class_Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Repositorio
{
    //Reglas de negocios y validaciones
    internal class BusinessLogicLayer
    {
        private DataAccessLayer _dataAccessLayer;

        

        public BusinessLogicLayer ( ) 
        { 
            _dataAccessLayer = new DataAccessLayer();
        }


        public Contacts SaveContact(Contacts contact)
        {
            if (contact.Id == 0)
            {
                _dataAccessLayer.InsertContact(contact);
            }
            else 
            {
                _dataAccessLayer.UpdateContact(contact);
            }
          
            return contact;
        }

        public List<Contacts> GetContacts(string searchtext = null)
        {
            return _dataAccessLayer.GetContacts(searchtext);
        }

        public void DeleteContact(int contact)
        {
            _dataAccessLayer.DeleteContact(contact);
        }
    
    }
}
