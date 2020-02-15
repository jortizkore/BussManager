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

        public frmPerdidaAccesorio()
        {
            InitializeComponent();
        }

        private void frmPerdidaAccesorio_Load(object sender, EventArgs e)
        {
            CargarAccesorios();
            CargarResponsables();
        }

        private void CargarAccesorios()
        {
            servicioAcc = new ServicioAccesorio();
            CmbAccesorioPerdiada.DataSource = servicioAcc.TraerAccesorios();
            CmbAccesorioPerdiada.ValueMember = "ID";
            CmbAccesorioPerdiada.DisplayMember = "Descripcion";
        }

        private void CargarResponsables()
        {
            ServicioRecursoHumano rh = new ServicioRecursoHumano();
            cmbResponsable.DataSource = rh.TraerRecursosHumanos();
            cmbResponsable.ValueMember = "Id";
            cmbResponsable.DisplayMember = "Nombre";
        }

        private void CmdReportarPerdida_Click(object sender, EventArgs e)
        {
            PerdiadAcceorio pa = new PerdiadAcceorio();
            pa.Accesorio = CmbAccesorioPerdiada.Text.ToString();
            pa.Cantidad = Convert.ToInt32(numCantidadPerdida.Value.ToString());
            pa.Costo = numCostoUnidadPerdida.Value;
            pa.Fecha = dtFechaPerdida.Value;
            pa.TipoPerdida = txtTipoPerdida.Text;
            pa.Responsable = Convert.ToInt32(cmbResponsable.SelectedValue.ToString());

            try
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
            catch (Exception ex)
            {
                MessageManager.ErrorMessage(ex.Message);
            }
        }

        private void CmbAccesorioPerdiada_SelectedIndexChanged(object sender, EventArgs e)
        {
            servicioAcc = new ServicioAccesorio();
            try
            {
                var accID = CmbAccesorioPerdiada.SelectedValue.ToString();
                accesocioSeleccionado = servicioAcc.TraerAccesorio(Convert.ToInt32(accID));
                numCostoUnidadPerdida.Value = accesocioSeleccionado.Costo;
            }
            catch (Exception)
            {
                
            }
            
        }

        void LimpiarFormularioPerdidas()
        {

        }
    }
}
