using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussManager.Settings.Tipo_reparaciones;

namespace BussManager.Settings.Tipo_reparaciones
{
    public partial class frmTipoReparaciones : Form
    {
        public frmTipoReparaciones()
        {
            InitializeComponent();
        }

        private void frmTipoReparaciones_Load(object sender, EventArgs e)
        {
            LlenarGridReparaciones();
        }

        private void LlenarGridReparaciones()
        {
            var tr = new TipoReparacionesEquipos();
            gridTipoReparaciones.DataSource = tr.TraerTiposReparacion();
            gridTipoReparaciones.AutoResizeColumns();
        }

        private void cmdInsertarTipoReparacion_Click(object sender, EventArgs e)
        {
            var puedeInsertar = txtTipoReparacion.Text.Length > 0;

            if (puedeInsertar)
            {
                var tipoReparacion = new TipoReparacionesEquipos();
                var id = int.Parse(lblIdModificarTipoReparacion.Text);
                var tipo = txtTipoReparacion.Text;

                var editar = id > 0;
                var realizado = editar ?
                    tipoReparacion.ModificarTipoReparacion(id, tipo)
                    : tipoReparacion.GuardarTipoReparacion(tipo);

                if (realizado)
                {
                    MessageManager.InfoMessage("Registro afectado con éxito");
                }
                else
                {
                    MessageManager.InfoMessage("Acción no realizada");
                }
            }
            clean();
        }

        private void gridTipoReparaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var id = gridTipoReparaciones
                    .Rows[e.RowIndex].Cells[0].Value.ToString();
                var tipo = gridTipoReparaciones
                    .Rows[e.RowIndex].Cells[1].Value.ToString();

                lblIdModificarTipoReparacion.Text = id;
                txtTipoReparacion.Text = tipo;
            }
            catch (Exception)
            {
                clean();
            }
        }

        private void clean()
        {
            lblIdModificarTipoReparacion.Text = "0";
            txtTipoReparacion.Text = string.Empty;
            LlenarGridReparaciones();
        }
    }
}
