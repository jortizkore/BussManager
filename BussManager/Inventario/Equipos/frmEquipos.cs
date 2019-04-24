using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussManager.Inventario.Equipos;
using BussManager.Settings.modelo_equipos;
using BussManager.Settings.clase_equipos;
using System.Windows.Forms;

namespace BussManager.Inventario.Equipos
{
    public partial class frmEquipos : Form
    {

        EquipoMovil celular;
        ClaseEquipo clase;
        modeloEqupos modelo;

        public frmEquipos()
        {
            InitializeComponent();
        }

        private void frmEquipos_Load(object sender, EventArgs e)
        {
            LlenarGridCelulares();
            LlenarCombos();
        }

        void LlenarCombos()
        {
            LlenarComboClases();
            LlenarComboModelos();
        }

        void LlenarComboClases()
        {
            clase = new ClaseEquipo();
            cmbClaseEquipo.DataSource = clase.TraerClases();
            cmbClaseEquipo.DisplayMember = "descripcion";
            cmbClaseEquipo.ValueMember = "id";
        }

        void LlenarComboModelos()
        {

            modelo = new modeloEqupos();
            cmbEquipoCelular.DataSource = modelo.TraerModelos();
            cmbEquipoCelular.DisplayMember = "descripcion";
            cmbEquipoCelular.ValueMember = "id_modelo";
        }

        void LlenarGridCelulares()
        {
            celular = new EquipoMovil();
            clase = new ClaseEquipo();
            modelo = new modeloEqupos();

            var listaCelulares = celular.TraerTodos();
            var listaMostrarCelulares = new List<CelularParaGrid>();

            foreach (var cel in listaCelulares)
            {
                listaMostrarCelulares.Add(
                    new CelularParaGrid
                    {
                        modelo = modelo.TraerModelo(cel.modelo),
                        clase = clase.TraerClase(cel.clase),
                        imei = cel.IMEI,
                        costo = cel.costo.ToString(),
                        precio = cel.precio.ToString()
                    });
            }

            grdEquipos.DataSource = listaMostrarCelulares;
            grdEquipos.AutoResizeColumns();
        }

        private void btnGuardarEquipo_Click(object sender, EventArgs e)
        {
            celular = new EquipoMovil();
            var marca = int.Parse(cmbEquipoCelular.SelectedValue.ToString());
            var clase = int.Parse(cmbClaseEquipo.SelectedValue.ToString());
            var imei = txtImeiEquipo.Text;
            var costo = decimal.Parse(txtCostoEquipo.Text);
            var precio = decimal.Parse(txtPrecioEquipo.Text);

            if (celular.GuardarEquipo(marca, clase, imei, costo, precio))
            {
                Settings.MessageManager.InfoMessage("Almacenado con éxito");
            }
            else
            {
                Settings.MessageManager.AlerMessage("Error al intentar realizar el cambio!");
            }

            Limpiar();
        }

        void Limpiar()
        {
            txtCostoEquipo.Text = string.Empty;
            txtPrecioEquipo.Text = string.Empty;
            txtImeiEquipo.Text = string.Empty;
            txtFiltrarEquipo.Text = string.Empty;

            cmbClaseEquipo.SelectedIndex = 0;
            cmbEquipoCelular.SelectedIndex = 0;

            LlenarGridCelulares();
        }

        private void cmbEquipoCelular_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarEquipo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class CelularParaGrid
    {
        public string modelo { get; set; }
        public string clase { get; set; }
        public string imei { get; set; }
        public string costo { get; set; }
        public string precio { get; set; }
    }
}
