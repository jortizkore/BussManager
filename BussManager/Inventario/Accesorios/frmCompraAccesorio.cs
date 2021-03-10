using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussManager.Inventario.Accesorios;
using BussManager.Settings;

namespace BussManager.Inventario.Accesorios
{
    public partial class frmCompraAccesorio : Form
    {
        ServicioAccesorio servicioAccesorio;
        Accesorio accesorioSeleccionado;
        List<Accesorio> listaCompra;

        public frmCompraAccesorio()
        {
            InitializeComponent();
        }

        private void frmCompraAccesorio_Load(object sender, EventArgs e)
        {
            LlenarGridInventarioAccesorio();
            ManejadorDePermisos.ComprobarPermisos(this);
        }

        void LlenarGridInventarioAccesorio()
        {
            servicioAccesorio = new ServicioAccesorio();
            var resultado = servicioAccesorio.TraerAccesorios();
            CalcularTotales(resultado);
            grdCompraAccesorios.DataSource = servicioAccesorio.TraerAccesoriosInventario();
            grdCompraAccesorios.AutoResizeColumns();
        }

        void CalcularTotales(List<Accesorio> list)
        {
            lblCapitalInventario.Text = list.Sum(x => x.Costo).ToString("C");
            lbCantidadInventario.Text = list.Count.ToString();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnInsertarAccesorios_Click(object sender, EventArgs e)
        {
            servicioAccesorio = new ServicioAccesorio();
            accesorioSeleccionado = new Accesorio();
            accesorioSeleccionado.Descripcion = txtCompraAccesorio.Text.Trim() == "" ? "" : txtCompraAccesorio.Text;
            accesorioSeleccionado.Costo = numCostoAccesorio.Value < 0 ? 1 : numCostoAccesorio.Value;
            accesorioSeleccionado.Precio = numPrecioAccesorio.Value < 0 ? 1 : numPrecioAccesorio.Value;

            var mensaje = "Quieres guardar los siguientes datos? \n" +
                          $"Aticulo: {accesorioSeleccionado.Descripcion} | Cantidad: {numCantidadAccesorio.Value.ToString()}\n" +
                          $"Costo: {accesorioSeleccionado.Costo}\n" +
                          $"Precio: {accesorioSeleccionado.Precio}";

            if (MessageManager.Question(mensaje) == DialogResult.Yes)
            {
                try
                {
                    servicioAccesorio.InsertarAccesorio(accesorioSeleccionado, int.Parse(numCantidadAccesorio.Value.ToString()), DateTime.Now.Date);
                    LlenarGridInventarioAccesorio();
                    MessageManager.InfoMessage("Completado!");
                    Limpiar();

                }
                catch (Exception es)
                {
                    MessageManager.ErrorMessage(es.Message);
                }

            }
        }

        void Limpiar()
        {
            txtCompraAccesorio.Text = string.Empty;
            numCantidadAccesorio.Value = 0;
            numCostoAccesorio.Value = 0;
            txtCompraAccesorio.Focus();
        }

        void filtroGridAccesorios()
        {
            var filtro = txtBuscarComprasAccesorios.Text;
            if (filtro.Trim() != "")
            {
                servicioAccesorio = new ServicioAccesorio();
                var resultado = servicioAccesorio.FiltroAccesorios(filtro);
                CalcularTotales(resultado);
                grdCompraAccesorios.DataSource = servicioAccesorio.TraerAccesoriosInventario(txtBuscarComprasAccesorios.Text); 
                grdCompraAccesorios.AutoResizeColumns();
            }
            else
            {
                LlenarGridInventarioAccesorio();
            }
        }

        private void btnBuscarComprasAccesorios_Click(object sender, EventArgs e)
        {
            filtroGridAccesorios();

        }

        private void txtBuscarComprasAccesorios_TextChanged(object sender, EventArgs e)
        {
            filtroGridAccesorios();
        }

        private void grdCompraAccesorios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var selected = grdCompraAccesorios.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCompraAccesorio.Text = selected;
                numCantidadAccesorio.Focus();
            }
            catch (Exception)
            {
                
            }
        }
    }
}
