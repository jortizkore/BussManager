using System;
using BussManager.Login;
using BussManager.Settings;
using System.Windows.Forms;

namespace BussManager.Login
{
    public partial class frmLogin : Form
    {
        Login servicioDeLogin = new Login();
        Dashboard dashboard = new Dashboard();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            Loguear();
            Settings.InformacionDeEmpresa.CargarInformacion();
        }

        private void Loguear()
        {
            Credenciales credentiales = new Credenciales
            {
                usuario = txtUsuario.Text,
                contrasenia = txtContrasenia.Text
            };
            if (servicioDeLogin.DoLogin(credentiales))
            {
                Dashboard frm = new Dashboard();
                frm.Show();
                UsuarioLogueado.frm = this;
                this.Hide();
                LimpiparControles();
            }
        }

        void LimpiparControles()
        {
            txtContrasenia.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtUsuario.Focus();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginImage_Click(object sender, EventArgs e)
        {

        }

        private void txtContrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                Loguear();
            }
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
