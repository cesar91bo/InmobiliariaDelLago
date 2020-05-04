using DataAcces;
using Dominio;
using InmobiliariaLagos.Formularios.Locatarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InmobiliariaLagos.Formularios
{
    public partial class frmNuevoRecibo : Form
    {
        public frmNuevoRecibo()
        {
            InitializeComponent();
        }

        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 i;
                if (Int32.TryParse(txtNroCli.Text, out i) != false)
                {
                    BuscarCli(Convert.ToInt32(txtNroCli.Text));
                }
                else
                {
                    MessageBox.Show("Ingrese Nro. Locatario correcto para realizar la búsqueda", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnListadoCli_Click(object sender, EventArgs e)
        {
            var frm = new frmConsultaLocatario();
            frm.ShowDialog();
            if (frm.DialogResult != DialogResult.OK || frm.NroLocatario <= 0) return;
            BuscarCli(frm.NroLocatario);
        }

        private void BuscarCli(int nroLocatario)
        {
            ClienteCN clienteCN = new ClienteCN();
            var locatario = clienteCN.BuscarLocatarioPorID(nroLocatario);

            if (locatario != null)
            {
                lblCliente.Text = locatario.ApellidoyNombre;
                txtNroCli.Text = locatario.NroCliente.ToString();
            }
            else
            {
                MessageBox.Show("No arrojó ningún resultado con ese valor", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
    }
}
