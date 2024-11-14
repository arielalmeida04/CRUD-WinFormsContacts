using Proyecto1Repositorio.Class_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1Repositorio
{
    public partial class ContactsDetails : Form
    {
        private BusinessLogicLayer _businessLogicLayer;
        private Contacts _contact;
        public ContactsDetails()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
        }

        #region Events
        private void button1_Click(object sender, EventArgs e)
        {
            SaveContact();
            //  ((Main)this.Parent).PopulateContacts();
        }
        #endregion

        #region Meths PRIVATE

        private void SaveContact()
        {

            Contacts contacts = new Contacts();
            contacts.FirstName = txbFN.Text;
            contacts.LastName = txbLN.Text;
            contacts.Phone = txbPhone.Text;
            contacts.Address = txbAddress.Text;

            contacts.Id = _contact != null ? _contact.Id : 0;

            _businessLogicLayer.SaveContact(contacts);


            ClearTxbContacts();
        }

        private void ContactsDetails_Load(object sender, EventArgs e)
        {

        }
        public void LoadContacts(Contacts contacts)
        {
            _contact = contacts;
            if (contacts != null)
            {


                txbFN.Text = contacts.FirstName;
                txbLN.Text = contacts.LastName;
                txbPhone.Text = contacts.Phone;
                txbAddress.Text = contacts.Address;


            }

        }
        #endregion

        #region Meths PUBLIC
        public void ClearTxbContacts()
        {
            txbFN.Clear();
            txbAddress.Clear();
            txbLN.Clear();
            txbPhone.Clear();
        }
        #endregion

    }
}
