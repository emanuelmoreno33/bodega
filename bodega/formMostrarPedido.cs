using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bodega
{
    public partial class formMostrarPedido : bodega.formPlantilla
    {
        public formMostrarPedido()
        {
            InitializeComponent();
        }

        private void pedidosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void formMostrarPedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPedidos.pedidos' Puede moverla o quitarla según sea necesario.
            this.pedidosTableAdapter.Fill(this.dsPedidos.pedidos);
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (pedidosBindingSource.Position < 0) return;
            int pos = pedidosBindingSource.Position;
            if (!dsPedidos.pedidos[pos].Servido)
            {
                dsPedidos.pedidos[pos].Servido = true;
                pedidosTableAdapter.Update(dsPedidos.pedidos);
            }
            else
                MessageBox.Show("Ese pedido ya fue servido");
            Close();

        }
    }
}
