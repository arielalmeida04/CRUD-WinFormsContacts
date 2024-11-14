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
    public partial class Main : Form
    {
        private BusinessLogicLayer _businessLogicLayer;
        private bool _isEnglish = true;
        public Main()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
            

        }
        #region Events
        private void bttAdd_Click(object sender, EventArgs e)
        {
            OpenContactsDetails();
            
        }
        private void Main_Load(object sender, EventArgs e)
        {
            PopulateContacts();
        }

        private void dgContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dgContacts.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString()=="Edit" || cell.Value.ToString()=="Editar" || cell.Value.ToString()=="Edit/Editar") 
            { 
                ContactsDetails contactsDetails = new ContactsDetails();
                contactsDetails.LoadContacts(new Contacts
                {
                    Id = int.Parse(dgContacts.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    FirstName = dgContacts.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    LastName = dgContacts.Rows[e.RowIndex ].Cells[2].Value.ToString(),
                    Phone = dgContacts.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Address = dgContacts.Rows[e.RowIndex].Cells[4].Value.ToString(),
                });


                //Esta es una forma de cargar los contactos y los cambios
                contactsDetails.ShowDialog(this);
                PopulateContacts();
                
                
                //OpenContactsDetails();
            }
            else if (cell.Value.ToString()== "Delete" || cell.Value.ToString()=="Eliminar" || cell.Value.ToString()=="Delete/Eliminar")
            {
                DeleteContact(int.Parse(dgContacts.Rows[e.RowIndex].Cells[0].Value.ToString()));
                PopulateContacts();
            }
        
        
        }
        private void tbxIdioma_Click(object sender, EventArgs e)
        {

            _isEnglish = !_isEnglish;


            if (_isEnglish)
            {
                tbxIdioma.Text = "Español-es";
                CambiarColumnasDataGridView("en");
            }
            else
            {
                tbxIdioma.Text = "Inglés-en";
                CambiarColumnasDataGridView("es");
            }
        }

        private void bttSearch_Click(object sender, EventArgs e)
        {
            PopulateContacts(txbSearch.Text);
            txbSearch.Text = string.Empty;
        }
        #endregion

        #region Meths Private

        private void OpenContactsDetails()
        {
            //llamo a la venta modal para cargar los contactos y cada vez que lo guarde actualiza la DataGrid en tiempo real
            ContactsDetails cds = new ContactsDetails();
            while (cds.ShowDialog() == DialogResult.OK)
            {
                PopulateContacts();
            }
            
            cds.Dispose();
           
            //Que es mejor?  Como lo hice en las lineas de arriba o las de abajo?
            // PopulateContacts();
        }


        

        private void CambiarColumnasDataGridView(string idioma)
        {
            if (idioma == "en")
            {
                dgContacts.Columns[0].HeaderText = "ID";
                dgContacts.Columns[1].HeaderText = "First Name";
                dgContacts.Columns[2].HeaderText = "Last Name";
                dgContacts.Columns[3].HeaderText = "Phone";
                dgContacts.Columns[4].HeaderText = "Address";
                dgContacts.Columns[5].HeaderText = "Edit";
                dgContacts.Columns[6].HeaderText = "Delete";

            }
            else if (idioma == "es")
            {
                dgContacts.Columns[0].HeaderText = "ID";
                dgContacts.Columns[1].HeaderText = "Nombre";
                dgContacts.Columns[2].HeaderText = "Apellido";
                dgContacts.Columns[3].HeaderText = "Teléfono";
                dgContacts.Columns[4].HeaderText = "Dirección";
                dgContacts.Columns[5].HeaderText = "Editar";
                dgContacts.Columns[6].HeaderText = "Eliminar";

            }
        }

        private void DeleteContact(int id)
        {
            _businessLogicLayer.DeleteContact(id);
        }







        #endregion
        
        #region Meths PUBLIC
        public void PopulateContacts(string search = null)
        {

            List<Contacts> listacontactos = _businessLogicLayer.GetContacts(search);
            dgContacts.DataSource = listacontactos;
        }
        #endregion

    }
}
