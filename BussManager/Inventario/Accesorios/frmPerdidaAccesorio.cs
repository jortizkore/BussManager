using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussManager.recursos_humanos;
using System.Windows.Forms;
using BussManager.Settings;

namespace BussManager.Inventario.Accesorios
{
    public partial class frmPerdidaAccesorio : Form
    {

        ServicioAccesorio servicioAcc = new ServicioAccesorio();
        Accesorio accesocioSeleccionado = new Accesorio();
        int maxCantidadPerdida = 0;
        bool usarFechas = false;

        public frmPerdidaAccesorio()
        {
            InitializeComponent();
        }

        private void frmPerdidaAccesorio_Load(object sender, EventArgs e)
        {
            CargarAccesorios();
            CargarResponsables();
            CargarGridPerdidas();
            ConfigurarFechasFiltros();
            ManejadorDePermisos.ComprobarPermisos(this);
            chUsarFechas.Checked = usarFechas;
        }

        private void ConfigurarFechasFiltros()
        {
            var fechaInicio = DateTime.Now;
        }

        private void CargarGridPerdidas()
        {
            PerdiadAcceorio pa = new PerdiadAcceorio();
            var listaPerdidas = pa.TraerPerdidas();

            gridPerdidas.DataSource = usarFechas?
                                        listaPerdidas = listaPerdidas
                                            .Where(x => (x.Fecha >=
                                            dtFechaInicio.Value &&
                                            x.Fecha <= dtFechaFin.Value) || x.Fecha == dtFechaInicio.Value.Date)
                                            .ToList()
                                        :   listaPerdidas;
            calcularCantidadCosto(listaPerdidas);
        }

        private void CargarGridPerdidas(string filtro)
        {
            PerdiadAcceorio pa = new PerdiadAcceorio();
            var listaPerdidas = pa.TraerPerdidas(filtro);
            gridPerdidas.DataSource = usarFechas ?
                                        listaPerdidas = listaPerdidas
                                            .Where(x => (x.Fecha >=
                                            dtFechaInicio.Value &&
                                            x.Fecha <= dtFechaFin.Value) || x.Fecha == dtFechaInicio.Value.Date)
                                            .ToList()
                                        : listaPerdidas;
            calcularCantidadCosto(listaPerdidas);
        }

        private void calcularCantidadCosto(List<PerdiadAcceorio> lpa)
        {
            lblCantidadPerdiads.Text = lpa.Count.ToString();
            lblCostoPerdidas.Text = lpa.Sum(p => p.Costo).ToString("C");
        }

        private void CargarAccesorios()
        {
            servicioAcc = new ServicioAccesorio();
            CmbAccesorioPerdiada.DataSource = servicioAcc.TraerAccesoriosParaCombo();
            CmbAccesorioPerdiada.ValueMember = "Descripcion";
            CmbAccesorioPerdiada.DisplayMember = "Descripcion";
        }

        private void CargarResponsables()
        {
            ServicioRecursoHumano rh = new ServicioRecursoHumano();
            cmbResponsable.DataSource = rh.TraerVendedores();
            cmbResponsable.ValueMember = "Id";
            cmbResponsable.DisplayMember = "Nombre";
        }

        private void CmdReportarPerdida_Click(object sender, EventArgs e)
        {
            try
            {
                PerdiadAcceorio pa = new PerdiadAcceorio();
                pa.Accesorio = CmbAccesorioPerdiada.Text.ToString();
                pa.Cantidad = Convert.ToInt32(numCantidadPerdida.Value.ToString());
                pa.Costo = numCostoUnidadPerdida.Value;
                pa.Fecha = dtFechaPerdida.Value;
                pa.TipoPerdida = txtTipoPerdida.Text;
                pa.Responsable = Convert.ToInt32(cmbResponsable.SelectedValue.ToString());


                var proceed = MessageManager.Question("Esta seguro de almacenar esta perdida?");
                if (proceed == DialogResult.Yes)
                {
                    if (pa.Guardar())
                    {
                        MessageManager.InfoMessage("Perdiad registrada con éxito!");
                    }
                    else
                    {
                        MessageManager.AlerMessage("Datos inváidos!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageManager.ErrorMessage(ex.Message);
            }
            finally
            {
                LimpiarFormularioPerdidas();
                CargarGridPerdidas();
            }
        }

        private void CmbAccesorioPerdiada_SelectedIndexChanged(object sender, EventArgs e)
        {
            servicioAcc = new ServicioAccesorio();
            try
            {
                var accID = CmbAccesorioPerdiada.SelectedValue.ToString();
                accesocioSeleccionado = servicioAcc.TraerAccesorio(accID);
                numCostoUnidadPerdida.Value = accesocioSeleccionado.Costo;
                maxCantidadPerdida = servicioAcc.TraerCantidadAccesorio(accesocioSeleccionado.Descripcion);
                numCantidadPerdida.Maximum = maxCantidadPerdida;
            }
            catch (Exception)
            {

            }

        }

        void LimpiarFormularioPerdidas()
        {
            CargarAccesorios();
            CargarResponsables();
            numCantidadPerdida.Value = 0;
            numCostoUnidadPerdida.Value = 0;
            txtTipoPerdida.Text = string.Empty;
        }

        private void txtFiltroPerdidas_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFiltroPerdidas.Text.Trim() != "")
                {
                    CargarGridPerdidas(txtFiltroPerdidas.Text);
                }
                else
                {
                    CargarGridPerdidas();
                }
            }
            catch (Exception)
            {

            }
        }

        private void chsarFechas_CheckedChanged(object sender, EventArgs e)
        {
            usarFechas = chUsarFechas.Checked;
            txtFiltroPerdidas.Text = string.Empty;
            CargarGridPerdidas();
        }

        private void dtFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            if(txtFiltroPerdidas.Text.Trim().Length != 0)
            {
                CargarGridPerdidas(txtFiltroPerdidas.Text);
            }
            else
            {
                CargarGridPerdidas();
            }
        }
    }
}
