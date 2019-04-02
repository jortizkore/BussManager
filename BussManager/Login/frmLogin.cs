using System;
using BussManager.Login;
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
            Credenciales credentiales = new Credenciales
            {
                usuario = txtUsuario.Text,
                contrasenia = txtContrasenia.Text
            };
            if (servicioDeLogin.DoLogin(credentiales))
            {
                this.Close();
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginImage_Click(object sender, EventArgs e)
        {

        }
    }
}
