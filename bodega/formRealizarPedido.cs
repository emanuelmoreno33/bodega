using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Transactions;

namespace bodega
{
    public partial class formRealizarPedido : bodega.formPlantilla
    {
        public formRealizarPedido()
        {
            InitializeComponent();
        }



        private void formRealizarPedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsProductos.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.dsProductos.productos);

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            formBuscarCodCliente formBuscar = new formBuscarCodCliente();
            formBuscar.ShowDialog();
            ctCliente.Text = formBuscar.codigoCliente;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Si no se introdujo el código de cliente. solicitarlo
                if (ctCliente.Text.Length == 0) btBuscar.PerformClick();
                // Realizar pedido si hay stock
                if (Convert.ToInt32(ctCantidad.Text) <= dsProductos.productos[productosBindingSource.Position].Stock)
                {
                    TransactionScope tr = new TransactionScope();
                    using (tr)
                    {
                        dsProductos.productosRow producto = dsProductos.productos[productosBindingSource.Position];
                        LogicaNegocio.RealizarPedido(ctCliente.Text, producto, Convert.ToInt32(ctCantidad.Text));
                        dsProductos.productos[productosBindingSource.Position].Stock -= Convert.ToInt32(ctCantidad.Text);
                        productosTableAdapter.Update(dsProductos.productos);
                        tr.Complete();
                    }
                    Close();
                }
                else
                    MessageBox.Show("La cantidad supera el stock");
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ctCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)Keys.Back) && (!(char.IsNumber(e.KeyChar))))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ctCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

    }

}

