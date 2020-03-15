using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussManager.Venta.Accesorios
{
    class Factura
    {
        string Header { get; set; }
        string Body { get; set; }
        string Footer { get; set; }

        private string NombreEmpresa = "Jasmayri Multiservice";
        private string Direccion = "Av. Los restauradores #56 Sabana Perdida Santo Domingo Norte";
        private string RNC = "N/A";
        private string NumeroTelefono = "829-592-8225";
        private string textoFooter = "Gracias por su compra";
        private string rutaFactura = "c:\\temp\\";

        public Factura()
        {
            LlenarHeader();
            LenarFooter();
        }

        public Factura(List<VentaAccesorio> ventas)
        {
            LlenarHeader();
            LenarFooter();
            LlenarVentas(ventas);
        }

        public void LlenarVentas(List<VentaAccesorio> ventas)
        {
            Body += "-------------------------------------------------" + Environment.NewLine;
            Body += ajustarTexto("Articulo", 20) 
                 + ajustarTexto("|Cantidad", 20)
                 + ajustarTexto("|Precio unidad", 20)
                 + ajustarTexto("|Total", 20)
                 + Environment.NewLine;

            foreach (var item in ventas)
            {
                Body += ajustarTexto(item.Accesorio, 20)
                 + "|" + ajustarTexto(item.Cantidad.ToString(), 20)
                 + "|" + ajustarTexto(item.Preciounidad.ToString("c"), 20)
                 + "|" + ajustarTexto((item.Preciounidad * item.Cantidad).ToString("c"), 20)
                 + "|" + Environment.NewLine;
            }

        }

        string ajustarTexto(string texto, int espacio)
        {
            return texto.PadLeft(espacio - texto.Length);
        }

        private void LenarFooter()
        {
            Footer = "".PadRight(40, ' ') + textoFooter + Environment.NewLine;
        }

        private void LlenarHeader()
        {
            Header = "".PadRight(30, '*') + NombreEmpresa + "".PadRight(30,'*') + Environment.NewLine;
            Header += "".PadRight(15, ' ') + Direccion + "".PadRight(15, ' ') + Environment.NewLine;
            Header += "".PadRight(40, ' ') + "RNC: " + RNC + Environment.NewLine;
        }

        public void CrearFactura()
        {
            string factNumero = DateTime.Now.ToString("HHmmss")
        }

    }
}
