using BussManager.Settings;
using BussManager.Venta.Accesorios;
using BussManager.Venta.Equipos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussManager.Venta
{
    class Factura
    {
        string Header { get; set; }
        string Body { get; set; }
        string Footer { get; set; }

        private string ArchivoFactura = "";

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
        public Factura(List<Inventario.Equipos.Equipo> equipos)
        {
            LlenarHeader();
            LenarFooter();
            LlenarVentas(equipos);
        }

        public void LlenarVentas(List<VentaAccesorio> ventas)
        {

            string factNum = DateTime.Now.ToString("HHmmssff");
            ArchivoFactura = factNum + ".txt";

            Body += "".PadLeft(64, '-')
                + Environment.NewLine;

            Body += ajustarTexto("Cant", 4)
                 + ajustarTexto("|Artiulo", 20)
                 + ajustarTexto("|Precio unidad", 20)
                 + ajustarTexto("|Total", 20)
                 + Environment.NewLine;

            foreach (var item in ventas)
            {
                Body += ajustarTexto(item.Cantidad.ToString(), 4)
                 + ajustarTexto(item.Accesorio, 20)
                 + ajustarTexto(item.Preciounidad.ToString("c"), 20)
                 + ajustarTexto((item.Preciounidad * item.Cantidad).ToString("c"), 20)
                 + Environment.NewLine;
            }

            Body += Environment.NewLine + "".PadLeft(64,'-');
            Body += Environment.NewLine;
            Body += "Articulos vendidos: " + ventas.Sum(x => x.Cantidad).ToString();
            Body += Environment.NewLine;
            Body += "Total a pagar: " + ventas.Sum(x => x.Preciounidad * x.Cantidad).ToString();

        }

        public void LlenarVentas(List<Inventario.Equipos.Equipo> equipos)
        {
            string factNum = DateTime.Now.ToString("HHmmssff");
            ArchivoFactura = factNum + ".txt";

            Body += "".PadLeft(64, '-')
                + Environment.NewLine;

            Body += ajustarTexto("Cant", 4)
                 + ajustarTexto("|Artiulo", 20)
                 + ajustarTexto("|Precio unidad", 20)
                 + ajustarTexto("|Total", 20)
                 + Environment.NewLine;

            foreach (var item in equipos)
            {
                Settings.modelo_equipos.modeloEqupos servModelo = new Settings.modelo_equipos.modeloEqupos();
                Settings.clase_equipos.ClaseEquipo servClase = new Settings.clase_equipos.ClaseEquipo();


                Body += ajustarTexto("1", 4)
                 + ajustarTexto(servModelo.TraerModelo(item.modelo), 20)
                 + ajustarTexto(item.precio.ToString("c"), 20)
                 + ajustarTexto(item.precio.ToString("c"), 20)
                 + Environment.NewLine;
            }

            Body += Environment.NewLine + "".PadLeft(64, '-');
            Body += Environment.NewLine;
            Body += "Articulos vendidos: " + equipos.Count.ToString("n");
            Body += Environment.NewLine;
            Body += "Total a pagar: " + equipos.Sum(x => x.precio).ToString();

        }

        string ajustarTexto(string texto, int espacio)
        {
            if (texto.Length > espacio)
            {
                texto = texto.Substring(0, espacio);
                return texto;
            }

            var result = texto.PadRight(espacio, ' ');
            return result;
        }

        private void LenarFooter()
        {
            Footer = "".PadRight(15, ' ') + textoFooter + Environment.NewLine;
        }

        private void LlenarHeader()
        {  
            Header = "".PadRight(10, '*') + NombreEmpresa + "".PadRight(10, '*') + Environment.NewLine;
            Header += "Avenida los Restauradores #14".PadLeft(30, ' ') + Environment.NewLine;
            Header += "Sabana Perdida".PadLeft(15, ' ') + Environment.NewLine;
            Header += "Santo Domingo Norte".PadLeft(20, ' ') + Environment.NewLine;
            Header += "".PadRight(15, ' ') + "RNC: " + RNC + Environment.NewLine;
        }

        public string NombreFactura()
        {
            return rutaFactura + ArchivoFactura;
        }

        public bool CrearFactura()
        {
            try
            {
                var archivo = File.Create(rutaFactura + ArchivoFactura);
                StreamWriter escritor = new StreamWriter(archivo);
                escritor.Write(Header + Environment.NewLine
                                + Body + Environment.NewLine
                                + Footer);
                escritor.Close();
                archivo.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageManager.ErrorMessage("La factura no pudo ser creada." +
                    Environment.NewLine
                    + ex.Message + "|" + ex.InnerException + "|" + ex.StackTrace);
                return false;
            }


        }

    }
}
