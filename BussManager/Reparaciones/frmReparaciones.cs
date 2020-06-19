using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussManager.Inventario;
using BussManager.recursos_humanos;
using BussManager.Reparaciones;
using BussManager.Venta;
using BussManager.Settings;

namespace BussManager.Reparaciones
{
    public partial class frmReparaciones : Form
    {

        Reparaciones servReparaciones = new Reparaciones();

        public frmReparaciones()
        {
            InitializeComponent();
        }

        private void frmReparaciones_Load(object sender, EventArgs e)
        {
            LlenarComboMarca();
            LlenarComboTecnicos();
            LlenarComboTipoReparaciones();
        }

        void LimpiarFrmReparaciones()
        {
            cmbReparacionMarcaEquipo.SelectedValue = 0;
            cmbTecnicoReparacion.SelectedValue = 0;
            cmbTipoReparacion.SelectedValue = 0;

            numCostoReparacion.Value = 0;
            numPrecioReparacion.Value = 0;
            nunmIdCompraReparacion.Value = 0;

            dtFechaReparacion.Value = DateTime.Today;
            txtComentarioReparacion.Text = string.Empty;
            txtIMEIReparacion.Text = string.Empty;
        }

        void LlenarComboMarca()
        {
            Settings.modelo_equipos.modeloEqupos modelos = new Settings.modelo_equipos.modeloEqupos();
            cmbReparacionMarcaEquipo.DataSource = modelos.TraerModelos();
            cmbReparacionMarcaEquipo.DisplayMember = "Descripcion";
            cmbReparacionMarcaEquipo.ValueMember = "id_modelo";
        }

        void LlenarComboTipoReparaciones()
        {
            Settings.Tipo_reparaciones.TipoReparacionesEquipos tipoReparaciones = new Settings.Tipo_reparaciones.TipoReparacionesEquipos();
            cmbTipoReparacion.DataSource = tipoReparaciones.TraerTiposReparacion();
            cmbTipoReparacion.DisplayMember = "Descripcion";
            cmbTipoReparacion.ValueMember = "id";
        }
        void LlenarComboTecnicos()
        {
            ServicioRecursoHumano servRH = new ServicioRecursoHumano();
            cmbTecnicoReparacion.DataSource = servRH.TraerTecnicos();
            cmbTecnicoReparacion.DisplayMember = "usuario";
            cmbTecnicoReparacion.ValueMember = "id"; 

        }

        private void btnGuardarReparacion_Click(object sender, EventArgs e)
        {
            try
            {
                servReparaciones = new Reparaciones();
                var reparacion = new Reparacion()
                {
                    Marca = int.Parse(cmbReparacionMarcaEquipo.SelectedValue.ToString()),
                    Tipo = int.Parse(cmbTipoReparacion.SelectedValue.ToString()),
                    Compra = int.Parse(nunmIdCompraReparacion.Value.ToString()),
                    Comentario = txtComentarioReparacion.Text,
                    Costo = numCostoReparacion.Value,
                    Precio = numPrecioReparacion.Value,
                    Fecha = dtFechaReparacion.Value,
                    IMEI = txtIMEIReparacion.Text,
                    Tecnico = int.Parse(cmbTecnicoReparacion.SelectedValue.ToString())
                };
                
                servReparaciones.GuardarReparacion(reparacion);
                MessageManager.InfoMessage("Trabajo almacenado con éxito");
            }
            catch (Exception ex)
            {
                MessageManager.ErrorMessage(ex.Message);
            }
            finally
            {
                LimpiarFrmReparaciones();
            }
        }

    }
}
