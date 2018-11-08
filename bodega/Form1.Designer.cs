namespace bodega
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BarraDeMenus = new System.Windows.Forms.MenuStrip();
            this.menuNuevoCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRealizarPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMostrarPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.BarraDeMenus.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraDeMenus
            // 
            this.BarraDeMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNuevoCliente,
            this.menuRealizarPedido,
            this.menuMostrarPedidos});
            this.BarraDeMenus.Location = new System.Drawing.Point(0, 0);
            this.BarraDeMenus.Name = "BarraDeMenus";
            this.BarraDeMenus.Size = new System.Drawing.Size(534, 24);
            this.BarraDeMenus.TabIndex = 1;
            this.BarraDeMenus.Text = "menuStrip1";
            // 
            // menuNuevoCliente
            // 
            this.menuNuevoCliente.Name = "menuNuevoCliente";
            this.menuNuevoCliente.Size = new System.Drawing.Size(94, 20);
            this.menuNuevoCliente.Text = "Nuevo Cliente";
            this.menuNuevoCliente.Click += new System.EventHandler(this.menuNuevoCliente_Click);
            // 
            // menuRealizarPedido
            // 
            this.menuRealizarPedido.Name = "menuRealizarPedido";
            this.menuRealizarPedido.Size = new System.Drawing.Size(99, 20);
            this.menuRealizarPedido.Text = "Realizar Pedido";
            this.menuRealizarPedido.Click += new System.EventHandler(this.menuRealizarPedido_Click);
            // 
            // menuMostrarPedidos
            // 
            this.menuMostrarPedidos.Name = "menuMostrarPedidos";
            this.menuMostrarPedidos.Size = new System.Drawing.Size(105, 20);
            this.menuMostrarPedidos.Text = "Mostrar Pedidos";
            this.menuMostrarPedidos.Click += new System.EventHandler(this.menuMostrarPedidos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 338);
            this.Controls.Add(this.BarraDeMenus);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.BarraDeMenus;
            this.Name = "Form1";
            this.Text = "Bodega";
            this.BarraDeMenus.ResumeLayout(false);
            this.BarraDeMenus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip BarraDeMenus;
        private System.Windows.Forms.ToolStripMenuItem menuNuevoCliente;
        private System.Windows.Forms.ToolStripMenuItem menuRealizarPedido;
        private System.Windows.Forms.ToolStripMenuItem menuMostrarPedidos;
    }
}

