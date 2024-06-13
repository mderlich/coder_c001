using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005
{
    public class Producto
    {
        private int _codigo;
        private string _descripcion;
        private double _precioDeCompra;
        private double _precioDeVenta;
        private string _categoria;

        public Producto(int codigo, string descripcion, double precioDeCompra, double precioDeVenta, string categoria)
        {
            this._codigo = codigo;
            this._descripcion = descripcion;
            this._precioDeCompra = precioDeCompra;
            this._precioDeVenta = precioDeVenta;
            this._categoria = categoria;
        }
        public bool hayPrecioDeVenta()
        {
            return this._precioDeVenta > 0;
        }
    }
}
