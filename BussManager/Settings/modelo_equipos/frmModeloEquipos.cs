using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BussManager.Settings.modelo_equipos
{
    public partial class frmModeloEquipos : Form
    {
        modeloEqupos modeloEquipos;
        public frmModeloEquipos()
        {
            InitializeComponent();
        }

        private void frmModeloEquipos_Load(object sender, EventArgs e)
        {
            LlenarGridModeloEquipos();
        }

        private void LlenarGridModeloEquipos()
        {
            modeloEquipos = new modeloEqupos();
            gridModeloEquipos.DataSource = modeloEquipos.TraerModelos();
            gridModeloEquipos.AutoResizeColumns();
        }

        private void cmdInsertarModelo_Click(object sender, EventArgs e)
        {
            modeloEquipos = new modeloEqupos();
            if (modeloEquipos.GuardarModelo(txtInsertarModelo.Text))
            {
                // TODO limpiar text box
            }
            else
            {
                MessageManager.AlerMessage("Este equipo no fué insertado, verifique si ya existe!");
            }
            LlenarGridModeloEquipos();
        }

        private void txtFiltrarModelo_TextChanged(object sender, EventArgs e)
        {
            modeloEquipos = new modeloEqupos();
            var filtro = txtFiltrarModelo.Text.Trim();
            var dataFiltrada = filtro == "" ? 
                                modeloEquipos.TraerModelos() 
                                : FiltrarData(filtro);

            gridModeloEquipos.DataSource = dataFiltrada;
        }
        private List<modelo> FiltrarData(string filtro)
        {
            modeloEquipos = new modeloEqupos();
            var filterdData = modeloEquipos
                                .TraerModelos()
                                .FindAll(m => m.descripcion.ToLower()
                                .Contains(filtro.ToLower()))
                                .ToList();

            return filterdData;
        }

        private void gridModeloEquipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var id = gridModeloEquipos.Rows[e.RowIndex].Cells[0].Value.ToString();
                var modeloActual = gridModeloEquipos.Rows[e.RowIndex].Cells[1].Value.ToString();

                lblIDModificar.Text = id;
                txtEditarModelo.Text = modeloActual;

                tabControl1.SelectTab(1);
            }
            catch (Exception)
            {
                LlenarGridModeloEquipos();
            }
        }

        private void cmdEditarModelo_Click(object sender, EventArgs e)
        {
            var id = int.Parse(lblIDModificar.Text);
            var nuevaDescripcion = txtEditarModelo.Text;
            modeloEquipos = new modeloEqupos();
            modeloEquipos.ModificarModelo(id, nuevaDescripcion);
            LlenarGridModeloEquipos();
        }
    }
}
