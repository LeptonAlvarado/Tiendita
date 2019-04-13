using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas
{
    class Producto
    {
        private string _nombre;
        private int _cantidad;
        private double _precio;
        private double _total;

        public string Nombre
        {
            get { return _nombre; }
        }

        public int Cantidad
        {
            set { _cantidad = value; }
            get { return _cantidad; }
        }

        public double Precio
        {
            get { return  _precio; }
        }

        public double Total
        {
            get { return _total; }
        }
              
        public Producto(string producto, int cantidad, double precio, double importe)
        {
            _nombre = producto;
            _cantidad = cantidad;
            _precio = precio;
            _total = importe;
        }


    }
}
