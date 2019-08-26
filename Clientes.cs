using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pventa
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proventasDataSet);

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proventasDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.proventasDataSet.Cliente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ciTextBox.Clear();
            nombreTextBox.Text = "";
            apellidoTextBox.Text = "";
            celularTextBox.Text = "";
            direccionTextBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clienteTableAdapter.Insert(ciTextBox.Text,nombreTextBox.Text,apellidoTextBox.Text,celularTextBox.Text,direccionTextBox.Text);
            clienteTableAdapter.Fill(proventasDataSet.Cliente);
        }
    }
}
