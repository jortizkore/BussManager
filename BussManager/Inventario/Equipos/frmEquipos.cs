﻿using System;
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
using BussManager.Settings.proveedores;
using BussManager.Settings;
using System.Windows.Forms;

namespace BussManager.Inventario.Equipos
{
    public partial class frmEquipos : Form
    {

        EquipoMovil celular;
        ClaseEquipo clase;
        modeloEqupos modelo;
        ServicioProveedores prov;

        public frmEquipos()
        {
            InitializeComponent();
        }

        void fijarColumnsSize()
        {
            for (int i = 0; i < grdEquipos.Columns.Count; i++)
            {
                grdEquipos.Columns[i].Width = grdEquipos.Width / grdEquipos.Columns.Count;
            }
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
            LlenarComboProveedores();
        }

        void LlenarComboClases()
        {
            clase = new ClaseEquipo();
            cmbClaseEquipo.DataSource = clase.TraerClases();
            cmbClaseEquipo.DisplayMember = "descripcion";
            cmbClaseEquipo.ValueMember = "id";
        }

        void LlenarComboProveedores()
        {
            prov = new ServicioProveedores();
            cmbProveedor.DataSource = prov.TraerProveedores();
            cmbProveedor.DisplayMember = "descripcion";
            cmbProveedor.ValueMember = "id";
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
            prov = new ServicioProveedores();

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
                        precio = cel.precio.ToString(),
                        proveedor = prov.TraerProveedor(cel.proveedor).descripcion,
                        CodModelo = cel.codigoModelo
                    });
            }

            grdEquipos.DataSource = listaMostrarCelulares;
            grdEquipos.AutoResizeColumns();
            lblCantidadEquipos.Text = grdEquipos.RowCount.ToString("n");
            lblTotalEnEquipos.Text = listaMostrarCelulares.Sum(x => decimal.Parse(x.precio)).ToString("c");
        }

        void LlenarGridCelulares(string filtro)
        {
            celular = new EquipoMovil();
            clase = new ClaseEquipo();
            modelo = new modeloEqupos();
            prov = new ServicioProveedores();
            

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
                        precio = cel.precio.ToString(),
                        proveedor = prov.TraerProveedor(cel.proveedor).descripcion,
                        CodModelo = cel.codigoModelo
                    });
            }

            grdEquipos.DataSource = listaMostrarCelulares
                        .Where(cels => cels.modelo.ToLower()
                        .Contains(filtro.ToLower())).ToList();
            grdEquipos.AutoResizeColumns();
        }

        private void btnGuardarEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                celular = new EquipoMovil();
                var equipo = new Equipo();

                equipo.modelo = int.Parse(cmbEquipoCelular.SelectedValue.ToString());
                equipo.clase = int.Parse(cmbClaseEquipo.SelectedValue.ToString());
                equipo.IMEI = txtImeiEquipo.Text;
                equipo.costo= decimal.Parse(txtCostoEquipo.Text);
                equipo.precio = decimal.Parse(txtPrecioEquipo.Text);
                equipo.proveedor = int.Parse(cmbProveedor.SelectedValue.ToString());
                equipo.codigoModelo = txtCodigoModelo.Text;

                if (celular.GuardarEquipo(equipo))
                {
                    MessageManager.InfoMessage("Almacenado con éxito");
                }
                else
                {
                    MessageManager.AlerMessage("Error al intentar realizar el cambio!");
                }
            }
            catch (Exception)
            {
                MessageManager.AlerMessage("Llene todos los campos correctamente!");
            }

            Limpiar();
        }

        void Limpiar()
        {
            txtCostoEquipo.Text = string.Empty;
            txtPrecioEquipo.Text = string.Empty;
            txtImeiEquipo.Text = string.Empty;
            txtFiltrarEquipo.Text = string.Empty;
            txtCodigoModelo.Text = string.Empty;

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

        private void grdEquipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                celular = new EquipoMovil();
                var imei = grdEquipos.Rows[e.RowIndex].Cells[2].Value.ToString();
                var equipo = celular.TraerEquipo(imei);

                txtImeiEquipo.Text = equipo.IMEI;
                txtCostoEquipo.Text = equipo.costo.ToString();
                txtPrecioEquipo.Text = equipo.precio.ToString();
                txtCodigoModelo.Text = equipo.codigoModelo;

                cmbClaseEquipo.SelectedValue = equipo.clase;
                cmbEquipoCelular.SelectedValue = equipo.modelo;
            }
            catch (Exception)
            {
                
            }
        }

        private void txtFiltrarEquipo_TextChanged(object sender, EventArgs e)
        {
            celular = new EquipoMovil();
            var filter = txtFiltrarEquipo.Text;
            if ( filter == "")
            {
                LlenarGridCelulares();
            }
            else
            {
                LlenarGridCelulares(txtFiltrarEquipo.Text);
            }
        }

        private void grdEquipos_Resize(object sender, EventArgs e)
        {
            fijarColumnsSize();
        }
    }

    public class CelularParaGrid
    {
        public string modelo { get; set; }
        public string clase { get; set; }
        public string imei { get; set; }
        public string costo { get; set; }
        public string precio { get; set; }
        public string proveedor { get; set; }
        public string CodModelo { get; set; }
    }
}
