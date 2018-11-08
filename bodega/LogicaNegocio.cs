using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bodega
{
    class LogicaNegocio
    {
        public static void RealizarPedido(string cliente, dsProductos.productosRow producto, int cantidad)
        {
            // Agregar un pedido
            dsPedidosTableAdapters.pedidosTableAdapter adaptador = new dsPedidosTableAdapters.pedidosTableAdapter();
            dsPedidos datos = new dsPedidos();
            adaptador.Fill(datos.pedidos);
            // Añadir el pedido a la tabla pedidos desde "datos"
            int pedido = datos.pedidos.Count + 1;
            string clave = producto.Clave;
            float coste = producto.PVP * cantidad;
            DateTime fecha = DateTime.Now;
            bool servido = false;
            datos.pedidos.AddpedidosRow(pedido, cliente, clave, cantidad, coste, fecha, servido);
            // Actualizar la base de datos desde "datos"
            adaptador.Update(datos);
        }

    }
}
