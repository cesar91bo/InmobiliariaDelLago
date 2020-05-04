using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using InmobiliariaLagos.Formularios;

namespace InmobiliariaLagos
{
    public partial class frmPrincipal : Form
    {
        #region Propiedades del Panel
        /* se declara campos de forma privada para almacenar el botón actual y un panel para
        aplicar un borde izquierdo al boton*/
        private IconButton botonActual;
        private Panel leftBorderBtn;

        // Se declara un campo del tipo formulario para almacenar el formulario actual
        private Form formHijoActual;

        #endregion

        // Constructor
        public frmPrincipal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            /*se necesita integrar el panel del borde izquierdo del boton a los controles 
             del panelMenu */
            panelMenu.Controls.Add(leftBorderBtn);

            // Oculta la barra por defecto 
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            //Para que no oculte la barra de tarea
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        /*Estructura de colores que se pasara al método ActivarBoton, cuando se
        hacer clic en algún botón*/
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(253, 185, 109);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Método para resalatar el botón activo
        private void ActivarBoton(object btnRemitente, Color color)
        {
            DesactivarBoton();
            if (btnRemitente != null)
            {
                // Botón
                botonActual = (IconButton)btnRemitente;
                botonActual.BackColor = Color.FromArgb(37, 36, 81);
                botonActual.ForeColor = color;
                botonActual.TextAlign = ContentAlignment.MiddleCenter;
                botonActual.IconColor = color;
                botonActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                botonActual.ImageAlign = ContentAlignment.MiddleRight;

                //Borde Izquierdo del botón
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, botonActual.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icono actual para el formulario hijo
                iconoFormularioHijoActual.IconChar = botonActual.IconChar;
                iconoFormularioHijoActual.IconColor = color;
            }
        }

        // Para desactivar el resaltado del botón
        private void DesactivarBoton()
        {
            if (botonActual != null)
            {
                // Botón
                botonActual.BackColor = Color.FromArgb(54, 62, 143);
                botonActual.ForeColor = Color.Gainsboro;
                botonActual.TextAlign = ContentAlignment.MiddleLeft;
                botonActual.IconColor = Color.Gainsboro;
                botonActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                botonActual.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color1);
            AbrirFormularioHijo(new frmNuevoRecibo());
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color2);
            AbrirFormularioHijo(new frmConsultaRecibo());
        }

        private void btnPropietarios_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color3);
            AbrirFormularioHijo(new frmPropietario());
        }

        private void btnLocatarios_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color6);
            AbrirFormularioHijo(new frmLocatario());
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color5);
            AbrirFormularioHijo(new frmConfiguracion());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (formHijoActual != null)
            {
                formHijoActual.Close();
            }
            
            Reset();
        }

        private void Reset()
        {
            DesactivarBoton();
            leftBorderBtn.Visible = false;
            iconoFormularioHijoActual.IconChar = IconChar.Home;
            iconoFormularioHijoActual.IconColor = Color.White;
            lblTituloFormularioHijo.Text = "Home";
        }

        #region Mover el Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        //Método para abrir formularios
        private void AbrirFormularioHijo(Form formularioHijo)
        {
            if (formHijoActual != null)
            {
                //Abre un solo formulario
                formHijoActual.Close();
            }
            formHijoActual = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            panelEscritorio.Controls.Add(formularioHijo);
            panelEscritorio.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
            lblTituloFormularioHijo.Text = formularioHijo.Text;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btmMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

    }
}
