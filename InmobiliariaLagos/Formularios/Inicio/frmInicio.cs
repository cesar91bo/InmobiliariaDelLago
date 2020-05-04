using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dominio;

namespace InmobiliariaLagos
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        #region Mover el Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        #endregion

        #region Efectos del Formulario
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {

            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }

        }

        private void Ingresar()
        {
            UsuarioCN usuario = new UsuarioCN();
            var validLogin = usuario.LoginUser(txtuser.Text, txtpass.Text);

            if (validLogin == true)
            {
                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.Show();
                this.Hide();
            }
            else
            {
                msjError("Usuario o Contraseña Incorrecta. \n Por favor pruebe de nuevo o cominíquese a CABL & Asociado.");
                txtpass.Clear();
                txtpass.Focus();
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion


        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (Validaciones() == true)
            {
                Ingresar();
                
            }           
        }

        private void msjError(string msj)
        {
                lblErrorMessage.Text = "    " + msj;
                lblErrorMessage.Visible = true;

        }

        public bool Validaciones()
        {
            if (txtuser.Text != "USUARIO" && txtpass.Text != "CONTRASEÑA")
            {
                return true;
            }
            
            if (txtuser.Text == "USUARIO")
            {
                msjError("Ingrese el Usuario.");
            }
            else
            {
                msjError("Ingrese la Contraseña.");
            }
            return false;
        }

        private void frmInicio_Enter(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (Validaciones() == true)
                    {
                        Ingresar();

                    }
                }
            }
            catch (Exception ex)
            {
                msjError(ex.Message);
            }
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
