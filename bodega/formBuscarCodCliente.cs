using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bodega
{
    public partial class formBuscarCodCliente : bodega.formPlantilla
    {
        public string codigoCliente;

        public formBuscarCodCliente()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void formBuscarCodCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                clientesTableAdapter.FillByNombreApellidos(dsClientes.clientes, "%" + ctApellidosNombre.Text + "%");
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                codigoCliente = dsClientes.clientes[clientesBindingSource.Position].Cliente;
                Close();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ctApellidosNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)Keys.Back) && (!(char.IsLetter(e.KeyChar))))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

      
    }
}
