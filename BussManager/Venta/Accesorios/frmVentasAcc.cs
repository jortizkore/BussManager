using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussManager.Venta;
using BussManager.Settings;
using BussManager.Inventario.Accesorios;
using System.Windows.Forms;

namespace BussManager.Venta.Accesorios
{
    public partial class frmVentasAcc : Form
    {

        Accesorio AccSeleccionado = new Accesorio();
        ServicioAccesorio ServAcc = new ServicioAccesorio();
        List<VentaAccesorio> ListaVentas = new List<VentaAccesorio>();

        public frmVentasAcc()
        {
            InitializeComponent();
        }


        private void cmbArticuloSeleccionado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var result = ServAcc.TraerAccesorio(cmbArticuloSeleccionado.SelectedValue.ToString());
                var CantidadAcc = ServAcc.TraerCantidadAccesorio(result.Descripcion).ToString();
                AccSeleccionado = result;
                lblCantidadEnInventario.Text = CantidadAcc;
                lblPrecioArticulo.Text = result.Precio.ToString("c");
                numCantidad.Maximum = Convert.ToDecimal(CantidadAcc);
            }
            catch (Exception)
            {
            }


        }

        void Limpiar()
        {
            ListaVentas.Clear();
            lstVentas.Items.Clear();
            refreshGridVentas();

        }

        private void CargarComboAcc()
        {
            cmbArticuloSeleccionado.DataSource = ServAcc.TraerAccesoriosParaCombo();
            cmbArticuloSeleccionado.DisplayMember = "Descripcion";
            cmbArticuloSeleccionado.ValueMember = "Descripcion";
        }

        void refreshGridVentas()
        {
            try
            {
                lstVentas.Items.Clear();
                foreach (var item in ListaVentas)
                {
                    ListViewItem lstItem = new ListViewItem();
                    lstItem.Text = item.Accesorio;
                    lstItem.SubItems.Add(item.Cantidad.ToString());
                    lstItem.SubItems.Add(item.Preciounidad.ToString("c"));
                    lstItem.SubItems.Add((item.Cantidad * item.Preciounidad).ToString("c"));
                    lstVentas.Items.Add(lstItem);
                }
                lstVentas.FullRowSelect = true;
                fijarColumnsSize();
                lstVentas.Refresh();
                refreshTotals();

            }
            catch (Exception ex)
            {
                MessageManager.AlerMessage(ex.Message);
            }
        }

        void fijarColumnsSize()
        {
            for (int i = 0; i < lstVentas.Columns.Count; i++)
            {
                lstVentas.Columns[i].Width = lstVentas.Width / lstVentas.Columns.Count;
            }
        }

        void refreshTotals()
        {
            lblCantidadArticulos.Text = ListaVentas.Sum(x => x.Cantidad).ToString();
            lblTotalAPagar.Text = ListaVentas.Sum(x => x.Preciounidad * x.Cantidad).ToString("c");

        }

        private void btnAgregarALaLista_Click(object sender, EventArgs e)
        {
            try
            {
                if (AccSeleccionado.Descripcion == null)
                    return;

                var venta = new VentaAccesorio();
                venta.id_venta = 0;
                venta.Accesorio = cmbArticuloSeleccionado.SelectedValue.ToString();
                venta.FechaVenta = dtFechaFactura.Value;
                venta.Cantidad = Convert.ToInt32(numCantidad.Value);
                venta.Costo = AccSeleccionado.Costo;
                venta.Preciounidad = AccSeleccionado.Precio;

                var existeAcc = ListaVentas.Any(x => x.Accesorio == cmbArticuloSeleccionado.SelectedValue.ToString());
                if (existeAcc)
                {
                    var cantidadInventario = Convert.ToInt32(lblCantidadEnInventario.Text);
                    var actualCantidad = ListaVentas
                        .Where(
                            x => x.Accesorio == cmbArticuloSeleccionado.SelectedValue.ToString()).First().Cantidad;
                    var nuevaCantidad = actualCantidad + (int)numCantidad.Value;
                    if (nuevaCantidad > cantidadInventario)
                    {
                        ListaVentas.Where(x => x.Accesorio == cmbArticuloSeleccionado.SelectedValue.ToString()).First().Cantidad = cantidadInventario;
                        MessageManager.InfoMessage("Se venderá solo la cantidad maxima de inventario.");

                    }
                    else
                    {
                        ListaVentas.Where(x => x.Accesorio == cmbArticuloSeleccionado.SelectedValue.ToString()).First().Cantidad = nuevaCantidad;
                    }
                }
                else
                {
                    ListaVentas.Add(venta);
                }
                refreshGridVentas();
            }
            catch (Exception ex)
            {
                MessageManager.AlerMessage(ex.Message);
            }


        }


        private void frmVentasAcc_SizeChanged(object sender, EventArgs e)
        {
            fijarColumnsSize();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (ListaVentas.Count < 1)
                return;

            VentaAcc ServVenta = new VentaAcc();
            Factura Servfact = new Factura(ListaVentas);
            try
            {
                ServVenta.GuardarListaVenta(ListaVentas);
                if (Servfact.CrearFactura())
                {
                    var verFact = MessageManager.Question("Desea ver la factura?");
                    if (verFact == DialogResult.Yes)
                    {
                        Process.Start(Servfact.NombreFactura());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageManager.AlerMessage(ex.Message);
            }
            finally
            {
                Limpiar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void frmVentasAcc_Load(object sender, EventArgs e)
        {
            CargarComboAcc();
            refreshGridVentas();
        }
    }
}
