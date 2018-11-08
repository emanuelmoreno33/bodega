using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bodega
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuNuevoCliente_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "formNuevoCliente")
                {
                    f.Activate();
                    return;
                }
            }
            formNuevoCliente formHijo = new formNuevoCliente();
            formHijo.MdiParent = this;
            formHijo.WindowState = FormWindowState.Maximized;
            formHijo.Show();

        }

        private void menuRealizarPedido_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "formRealizarPedido")
                {
                    f.Activate();
                    return;
                }
            }
            formRealizarPedido formHijo = new formRealizarPedido();
            formHijo.MdiParent = this;
            formHijo.WindowState = FormWindowState.Maximized;
            formHijo.Show();
        }

        private void menuMostrarPedidos_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "formMostrarPedido")
                {
                    f.Activate();
                    return;
                }
            }
            formMostrarPedido formHijo = new formMostrarPedido();
            formHijo.MdiParent = this;
            formHijo.WindowState = FormWindowState.Maximized;
            formHijo.Show();

        }
    }
}
