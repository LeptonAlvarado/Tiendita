using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas
{
    class Venta
    {
        private double _subtotal;
        private double _iva;
        private double _total;
        private double _cambio;

        public double Subtotal
        {
            get { return _subtotal; }
        }

        public double Iva
        {
            get { return _iva; }
        }

        public double Total
        {
            get { return _total; }
        }

        public double Cambio
        {
            get { return _cambio; }
        }

        public double CalcSubtotal (double importe)
        {
            _subtotal += importe;
            return _subtotal ;
        }

        public double CalcIva(double subtotal)
        {
            _iva = subtotal * .16;
            return _iva;
        }

        public double CalcTotal(double subtotal, double iva)
        {
            _total = subtotal + iva;
            return _total;
        }

        public double DarCambio(double total, double pago)
        {
            _cambio = pago - total;
            return _cambio;
        }
    }
}
