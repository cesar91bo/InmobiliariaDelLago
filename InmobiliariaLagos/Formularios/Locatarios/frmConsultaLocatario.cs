using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAcces;
using Dominio;

namespace InmobiliariaLagos.Formularios.Locatarios
{
    public partial class frmConsultaLocatario : FormBase
    {
        #region Mover el Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        #endregion
        //LocatarioCN locatario = new LocatarioCN();
        public Int32 NroLocatario;
        public frmConsultaLocatario()
        {
            InitializeComponent();
        }

        private void frmConsultaLocatario_Load(object sender, EventArgs e)
        {
            var dt = new DataTable();
            dt.Columns.Add("IdBusqueda");
            dt.Columns.Add("Descripcion");
            dt.Rows.Add("NroCliente", "Nro. Locatario");
            dt.Rows.Add("ApellidoNombre", "Apellido y Nombre");
            dt.Rows.Add("Direccion", "Dirección");
            dt.Rows.Add("Telefono", "Teléfono");
            dt.Rows.Add("Documento", "Documento");
            CrearColumnas();
            MostrarLocatarios();
            AlternarColor();
        }

        private void CrearColumnas()
        {
            lvListaLoc.Columns.Add("Nro. Locatario", 100, HorizontalAlignment.Left);
            lvListaLoc.Columns.Add("Apellido y Nombre", 200, HorizontalAlignment.Left);
            lvListaLoc.Columns.Add("Direccion", 200, HorizontalAlignment.Left);
            lvListaLoc.Columns.Add("Teléfono", 110, HorizontalAlignment.Left);
            lvListaLoc.Columns.Add("Documento", 150, HorizontalAlignment.Left);
        }

        public void MostrarLocatarios()
        {
            lvListaLoc.Items.Clear();
            List<ClientesDto> locatarios;
            ClienteCN clienteCN = new ClienteCN();
            locatarios = clienteCN.ListarClientes();

            if (locatarios == null) return;
            foreach (ClientesDto loc in locatarios)
            {
                var item = new ListViewItem(){ Tag = loc.NroCliente, Text = loc.NroCliente.ToString() };
                item.SubItems.Add(loc.ApellidoyNombre);
                item.SubItems.Add(loc.Direccion);
                item.SubItems.Add(loc.Telefono != null ? loc.Telefono : "-");
                item.SubItems.Add(loc.NroDocumento != null ? loc.NroDocumento.ToString() : "-");
                lvListaLoc.Items.Add(item);
            }

        }

        public void AlternarColor()
        {
            for (int i = 0; i < lvListaLoc.Items.Count; i++)
            {
                if (lvListaLoc.Items[i].Index % 2 != 0)
                {
                    lvListaLoc.Items[i].BackColor = Color.Gray;
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvListaLoc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SeleccionLv();
        }

        private void SeleccionLv()
        {
            NroLocatario = Convert.ToInt32(lvListaLoc.SelectedItems[0].Tag);
            DialogResult = DialogResult.OK;
        }

        private void frmConsultaLocatario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
