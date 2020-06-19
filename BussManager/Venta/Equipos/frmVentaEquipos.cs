using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using BussManager.Inventario;
using BussManager.Settings;
using System.Windows.Forms;

namespace BussManager.Venta.Equipos
{
    public partial class frmVentaEquipos : Form
    {

        Inventario.Equipos.EquipoMovil servEquipoMovil = new Inventario.Equipos.EquipoMovil();
        Inventario.Equipos.Equipo movilSeleccionado = null;
        List<Inventario.Equipos.Equipo> listaVentaEquipos = new List<Inventario.Equipos.Equipo>();

        public frmVentaEquipos()
        {
            InitializeComponent();
        }

        void LimpiarFrmVentaEquipos()
        {
            CargarCmbEquipos();

            lblCantidadEnLista.Text = "0";
            lblClase.Text = "-";
            lblClaseModelo.Text = "-";
            lblIMEI.Text = "-";
            lblTotalApagar.Text = "-";
            numPrecio.Minimum = 0;
            numPrecio.Value = 0;

            movilSeleccionado = null;
            listaVentaEquipos.Clear();
            refrescarListViewVentas();
            refreshTotals();
        }

        private void frmVentaEquipos_Load(object sender, EventArgs e)
        {
            numPrecio.Maximum = 9999999;
            CargarCmbEquipos();
        }   

        private void CargarCmbEquipos()
        {
            var servModelo = new Settings.modelo_equipos.modeloEqupos();
            var equipos = servEquipoMovil.TraerTodosParaCombo();
            cmbEquipos.DataSource = equipos;
            cmbEquipos.DisplayMember = "descripcion";
            cmbEquipos.ValueMember = "IMEI";
        }

        private void cmbEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var imeiEquipo = cmbEquipos.SelectedValue.ToString();
            movilSeleccionado = servEquipoMovil.TraerEquipo(imeiEquipo);
            if (movilSeleccionado.precio > 0)
                calcuarGananciaMinima();
            refreshLabels();
        }

        void calcuarGananciaMinima()
        {
            try
            {
                var gananciaMinima = Convert.ToDecimal(movilSeleccionado.costo * Convert.ToDecimal("0.05"));
                gananciaMinima = gananciaMinima < 500 ? 500 : gananciaMinima;

                numPrecio.Minimum = movilSeleccionado.costo;// + gananciaMinima;

            }
            catch (Exception ex)
            {
                MessageManager.AlerMessage("Problemas al cargar los datos: " + ex.Message);
            }
            
        }

        void refreshLabels()
        {
            try
            {
                Settings.clase_equipos.ClaseEquipo servClase = new Settings.clase_equipos.ClaseEquipo();

                lblClase.Text = servClase.TraerClase(movilSeleccionado.clase);
                lblClaseModelo.Text = movilSeleccionado.codigoModelo;
                lblIMEI.Text = movilSeleccionado.IMEI;
                numPrecio.Value = movilSeleccionado.precio;
            }
            catch (Exception ex)
            {
                MessageManager.AlerMessage("Problemas al cargar los datos: " + ex.Message);

            }

        }

        private void addMovil_Click(object sender, EventArgs e)
        {
            if (movilSeleccionado.IMEI == null ||
                movilSeleccionado.IMEI.Trim() == "")
                return;

            if (listaVentaEquipos.Any(eq => eq.IMEI == movilSeleccionado.IMEI))
            {
                MessageManager.InfoMessage("Este equipo ya está en lista");
            }
            else
            {
                movilSeleccionado.precio = numPrecio.Value;
                listaVentaEquipos.Add(movilSeleccionado);
                refrescarListViewVentas();
            }
        }

        void fijarColumnsSize()
        {
            for (int i = 0; i < lstVentaEquipos.Columns.Count; i++)
            {
                lstVentaEquipos.Columns[i].Width = lstVentaEquipos.Width / lstVentaEquipos.Columns.Count;
            }
        }

        void refreshTotals()
        {
            lblTotalApagar.Text = listaVentaEquipos.Sum(x => x.precio).ToString("c");
            lblCantidadEnLista.Text = listaVentaEquipos.Count.ToString("n");
        }

        void refrescarListViewVentas()
        {
            lstVentaEquipos.Items.Clear();

            foreach (var cel in listaVentaEquipos)
            {
                Settings.modelo_equipos.modeloEqupos servModeloEquipo = new Settings.modelo_equipos.modeloEqupos();
                Settings.clase_equipos.ClaseEquipo servClase = new Settings.clase_equipos.ClaseEquipo();

                ListViewItem item = new ListViewItem();
                item.Text = servModeloEquipo.TraerModelo(cel.modelo);
                item.SubItems.Add(cel.IMEI);
                item.SubItems.Add(cel.precio.ToString("c"));
                item.SubItems.Add(servClase.TraerClase(cel.clase));
                item.SubItems.Add(cel.codigoModelo);
                lstVentaEquipos.Items.Add(item);
            }
            lstVentaEquipos.FullRowSelect = true;
            lstVentaEquipos.View = View.Details;
            fijarColumnsSize();
            lstVentaEquipos.Refresh();
            refreshTotals();
        }

        void Limpiar()
        {
            CargarCmbEquipos();

            lblCantidadEnLista.Text = string.Empty;
            lblTotalApagar.Text = string.Empty;
            lblIMEI.Text = "--";
            lblClase.Text = "--";
            lblClaseModelo.Text = "--";
            numPrecio.Value = 0;
        }

        private void frmVentaEquipos_Resize(object sender, EventArgs e)
        {
            fijarColumnsSize();
        }

        private void cmdFacturar_Click(object sender, EventArgs e)
        {
            if (listaVentaEquipos.Count < 1)
                return;

            if (servEquipoMovil.venderListaEquipos(listaVentaEquipos))
            {
                Factura fac = new Factura(listaVentaEquipos);   
                servEquipoMovil = new Inventario.Equipos.EquipoMovil();

                var ventaCompleta = servEquipoMovil.venderListaEquipos(listaVentaEquipos);
                if (ventaCompleta)
                {
                    fac.CrearFactura();
                    var verFactura =
                        MessageManager.Question("Quieres ver la factura?") == DialogResult.Yes ? true : false;

                    if (verFactura)
                        Process.Start(fac.NombreFactura());
                }
            }

            LimpiarFrmVentaEquipos();
        }

    }
}
