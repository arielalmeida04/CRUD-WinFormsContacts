namespace Proyecto1Repositorio
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgContacts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.bttSearch = new System.Windows.Forms.Button();
            this.bttAdd = new System.Windows.Forms.Button();
            this.tbxIdioma = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgContacts
            // 
            this.dgContacts.AutoGenerateColumns = false;
            this.dgContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.dgContacts.DataSource = this.contactsBindingSource;
            this.dgContacts.Location = new System.Drawing.Point(12, 106);
            this.dgContacts.Name = "dgContacts";
            this.dgContacts.Size = new System.Drawing.Size(776, 332);
            this.dgContacts.TabIndex = 0;
            this.dgContacts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgContacts_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(99, 57);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(577, 29);
            this.txbSearch.TabIndex = 2;
            // 
            // bttSearch
            // 
            this.bttSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSearch.Location = new System.Drawing.Point(682, 30);
            this.bttSearch.Name = "bttSearch";
            this.bttSearch.Size = new System.Drawing.Size(106, 31);
            this.bttSearch.TabIndex = 3;
            this.bttSearch.Text = "Search";
            this.bttSearch.UseVisualStyleBackColor = true;
            this.bttSearch.Click += new System.EventHandler(this.bttSearch_Click);
            // 
            // bttAdd
            // 
            this.bttAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAdd.Location = new System.Drawing.Point(682, 67);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(106, 30);
            this.bttAdd.TabIndex = 4;
            this.bttAdd.Text = "Add";
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // tbxIdioma
            // 
            this.tbxIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIdioma.Location = new System.Drawing.Point(12, 2);
            this.tbxIdioma.Name = "tbxIdioma";
            this.tbxIdioma.Size = new System.Drawing.Size(106, 27);
            this.tbxIdioma.TabIndex = 5;
            this.tbxIdioma.Text = "Idioma";
            this.tbxIdioma.UseVisualStyleBackColor = true;
            this.tbxIdioma.Click += new System.EventHandler(this.tbxIdioma_Click);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit/Editar";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete/Eliminar";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // contactsBindingSource
            // 
            this.contactsBindingSource.DataSource = typeof(Proyecto1Repositorio.Class_Business.Contacts);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxIdioma);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.bttSearch);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgContacts);
            this.Name = "Main";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgContacts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button bttSearch;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.BindingSource contactsBindingSource;
        private System.Windows.Forms.Button tbxIdioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}

