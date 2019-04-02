using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BussManager.Settings.clase_equipos
{
    public partial class frmClases : Form
    {


        public frmClases()
        {
            InitializeComponent();
        }

        private void frmClases_Load(object sender, EventArgs e)
        {
            LlenarGridClase();
        }

        private void LlenarGridClase()
        {
            var claseEquipo = new ClaseEquipo();
            gridClases.DataSource = claseEquipo.TraerClases();
            gridClases.AutoResizeColumns();
        }

        private void cmdInsertarClase_Click(object sender, EventArgs e)
        {
            var puedeIsertar = txtInsertarClase.Text.Length > 0
                            && txtInsertarComentarioClase.Text.Length > 0;

            if (puedeIsertar)
            {
                var claseEquipo = new ClaseEquipo();
                if (claseEquipo.GuardarClase(txtInsertarClase.Text,
                                         txtInsertarComentarioClase.Text))
                {
                    MessageManager.InfoMessage("Clase insertada con éxito");
                }
                else
                {
                    MessageManager.AlerMessage("Registro no insertado ");
                }
                LlenarGridClase();
            }
        }

        private void cmdModificarClase_Click(object sender, EventArgs e)
        {
            var id = int.Parse(lblIDModificarClase.Text);
            var puedeEditar = txtModificarClase.Text.Length > 0
                && txtModificaComentarioClase.Text.Length > 0
                && id > 0;

            if (puedeEditar)
            {
                var claseEquipo = new ClaseEquipo();
                if (claseEquipo.ModificarClase(id, txtModificarClase.Text,
                                         txtModificaComentarioClase.Text))
                {
                    MessageManager.InfoMessage("Clase modificada con éxito");
                }
                else
                {
                    MessageManager.AlerMessage("Registro no modificado, verifique que los campos estén llenos");
                }
                LlenarGridClase();
            }
        }

        private void gridClases_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var id = gridClases.Rows[e.RowIndex].Cells[0].Value.ToString();
                var clase = gridClases.Rows[e.RowIndex].Cells[1].Value.ToString();
                var comentario = gridClases.Rows[e.RowIndex].Cells[2].Value.ToString();

                lblIDModificarClase.Text = id;
                txtModificarClase.Text = clase;
                txtModificaComentarioClase.Text = comentario;

                tabControlClases.SelectTab(1);
            }
            catch (Exception)
            {
                LlenarGridClase();
            }

        }
    }
}
