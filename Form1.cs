using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SistemaDeVentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Venta miVenta = new Venta();
        double importe;

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            Producto miProducto = new Producto(txtProducto.Text, Convert.ToInt32(txtCantidad.Value),
                Convert.ToDouble(txtCosto.Text), Convert.ToDouble(txtImporte.Text));
            txtSubTotal.Text = miVenta.CalcSubtotal(miProducto.Total).ToString();
            txtIva.Text = miVenta.CalcIva(miVenta.Subtotal).ToString();
            txtTotal.Text = miVenta.CalcTotal(miVenta.Subtotal, miVenta.Iva).ToString();

            lbCuenta.Items.Add("Producto: " + miProducto.Nombre + " Cantidad: " + miProducto.Cantidad
                + " Precio: " + miProducto.Precio + " Importe: " + miProducto.Total);

        }

        private void txtImporte_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(txtCantidad.Value);
            double costo = Convert.ToDouble(txtCosto.Text);

            importe = cantidad * costo;
            txtImporte.Text = importe.ToString();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            txtCambio.Text = miVenta.DarCambio(miVenta.Total, Convert.ToDouble(txtPago.Text)).ToString();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            sfdTicket.ShowDialog();
            string rutaArchivo;
            rutaArchivo = sfdTicket.FileName;
            FileStream fs = new FileStream(rutaArchivo, FileMode.Create);
            StreamWriter escritor = new StreamWriter(fs);

            for (int i = 0; i < lbCuenta.Items.Count; i++)
                escritor.WriteLine(lbCuenta.Items[i].ToString());

            escritor.WriteLine("Subtotal: $" + miVenta.Subtotal);
            escritor.WriteLine("Total: $" + miVenta.Total);
            escritor.WriteLine("IVA incluido: $" + miVenta.Iva);
            escritor.WriteLine("Pago: $" + txtPago.Text);
            escritor.WriteLine("Cambio: $" + miVenta.Cambio);
        }
    }
}
