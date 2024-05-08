using kssLibWeb;
using System;
using System.Configuration;

namespace wResAPI_d3xd
{
    public partial class frmConfig : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Program.Main();
        }
        private bool LoadData()
        {
            bool loaded = Program.clsConfig.leer_config();
            txtEmpresaNombre.Text = Program.empresa_nombre;
            txtEmpresarif.Text = Program.empresa_rif;
            txt_dirbd.Text = Program.DirHuespedServer;
            txt_conexionbd.Text = Program.ConexionHuesped_Server;
            txtServidorAPI.Text = Program.urlServerAPI;
            txtnroEstaciones.Text = Program.nroEstaciones;
            txtCodPetro.Text = Program.codigoPetro;
            txtCodDolar.Text = Program.codigoDolar;
            txtCodBolivar.Text = Program.codigoBolivar;
            txtMonedaBolivar.Text = Program.nomenBolivar;
            txtMonedaDolar.Text = Program.nomenDolar;
            txtMonedaPetro.Text = Program.nomenPetro;
            chkesRemoteAPI.Checked = Program.esRemoteAPI;
            chkesRetailBD.Checked = Program.esRetailBD;
            chkesSQLServer.Checked = Program.esSQLServer;
            return loaded;

        }
        private bool saveData()
        {
            Program.saveAppConfig("empresa_nombre", txtEmpresaNombre.Text);
            Program.saveAppConfig("empresa_rif", txtEmpresarif.Text);
            Program.saveAppConfig("DirHuespedServer", txt_dirbd.Text);
            if (!chkesSQLServer.Checked)
            {
                Program.saveAppConfig("ConexionHuesped_Server", string.Format(Program.loadAppConfig("ConexionHuesped_Server_Template"), txt_dirbd.Text));
            }
            else
            {
                Program.saveAppConfig("ConexionHuesped_Server", txt_conexionbd.Text);
            }

            Program.saveAppConfig("urlServerAPI", txtServidorAPI.Text);
            Program.saveAppConfig("nroEstaciones", txtnroEstaciones.Text);
            Program.saveAppConfig("codigoPetro", txtCodPetro.Text);
            Program.saveAppConfig("codigoDolar", txtCodDolar.Text);
            Program.saveAppConfig("codigoBolivar", txtCodBolivar.Text);
            Program.saveAppConfig("nomenBolivar", txtMonedaBolivar.Text);
            Program.saveAppConfig("nomenDolar", txtMonedaDolar.Text);
            Program.saveAppConfig("nomenPetro", txtMonedaPetro.Text);
            Program.saveAppConfig("esRemoteAPI", chkesRemoteAPI.Checked.ToString());
            Program.saveAppConfig("esRetailBD", chkesRetailBD.Checked.ToString());
            Program.saveAppConfig("esSQLServer", chkesSQLServer.Checked.ToString());
            return true;

        }

        protected void btnGuardarDatos_Click1(object sender, EventArgs e)
        {
            saveData();
        }

        protected void btnGuardarDatos0_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }

}