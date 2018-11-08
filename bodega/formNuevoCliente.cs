using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bodega
{
    public partial class formNuevoCliente : bodega.formPlantilla
    {
        public formNuevoCliente()
        {
            InitializeComponent();
        }

        private void formNuevoCliente_Load(object sender, EventArgs e)
        {
            this.clientesBindingSource.AddNew();

        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                try
                {
                    this.clientesBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.dsClientes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show(this, "Errores de validacion.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void clienteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (clienteTextBox.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(clienteTextBox, "Introduzca el identificador del cliente");
            }
            else
            {
                errorProvider1.SetError(clienteTextBox, null);
            }
        }

        private void nombreTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (nombreTextBox.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(nombreTextBox, "Introduzca el nombre del cliente");
            }
            else
            {
                errorProvider1.SetError(nombreTextBox, null);
            }
        }

        private void apellidosTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (apellidosTextBox.Text.Length == 0)
            { 
                e.Cancel = true;
                errorProvider1.SetError(apellidosTextBox, "Introduzca el apellido del cliente");
            }
            else
            {
                errorProvider1.SetError(apellidosTextBox, null);
            }
        }

        private void direccionTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (direccionTextBox.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(direccionTextBox, "Introduzca la dirección del cliente");
            }
            else
            {
                errorProvider1.SetError(direccionTextBox, null);
            }
        }

        private void clienteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)&&(!(char.IsNumber(e.KeyChar))) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras y numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void nombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void apellidosTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void direccionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!(char.IsNumber(e.KeyChar))) && (e.KeyChar != (char)Keys.Space) && !(char.IsPunctuation(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten letras y numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void telefonoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)Keys.Back) && (!(char.IsNumber(e.KeyChar))))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private Boolean email_bien_escrito(String email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btValidar_Click(object sender, EventArgs e)
        {
            if (chbvalidar.Checked == false)
            {
                string mail = correo_eTextBox.ToString();
                Boolean valido = email_bien_escrito(mail);

                if (valido == true)
                {
                    btAceptar.Enabled = true;
                    btValidar.Enabled = false;
                    chbvalidar.Enabled = false;
                }
                else
                {
                    btAceptar.Enabled = false;
                    MessageBox.Show("ingrese un correo valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                btAceptar.Enabled = true;
            }

        }
    }
}
