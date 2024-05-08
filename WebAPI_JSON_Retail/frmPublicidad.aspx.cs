using kssLibWeb;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Net;

namespace wResAPI_d3xd
{
    public partial class frmPublicidad : System.Web.UI.Page
    {
        clsConfigAPPXML clsConfig;
        CultureInfo cultureInfo = CultureInfo.GetCultureInfo("es-VE");
        string publicidadFolder = "~"+ ConfigurationManager.AppSettings["PublicidadFolder"];
        int ItemSelected = 0;
        string FileSelected = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            clsConfig = new clsConfigAPPXML();
            clsConfig.leer_config();
            lstPublicidad.SelectedIndexChanged += LstPublicidad_SelectedIndexChanged;
            //Button1.Click += Button1_Click;
            if (!IsPostBack)
                loadList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Eliminar Publicidad
            var uri = new Uri(Server.MapPath("/publicidad"), UriKind.Absolute);
            System.IO.File.Delete(uri.LocalPath);
            loadList();
        }

        private void LstPublicidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPublicidad.SelectedIndex >= 0)
            {
                ItemSelected = lstPublicidad.SelectedIndex;
                FileSelected ="/"+ lstPublicidad.SelectedItem.Text;
                ImgPublicidad.ImageUrl = publicidadFolder + FileSelected;
            }
            else
            {
                ItemSelected = -1;
                FileSelected = "";
                ImgPublicidad.ImageUrl = "~/Imagenes/KssLogo.png";
            }
        }

        private void loadList()

        {
            lstPublicidad.Items.Clear();
            Response.Write(System.Web.HttpContext.Current.Server.MapPath(publicidadFolder));
            string path = System.Web.HttpContext.Current.Server.MapPath(publicidadFolder);
            var files = System.IO.Directory.GetFiles(path);
            if (files != null)
            {
                foreach (string item in files)
                {
                    lstPublicidad.Items.Add(System.IO.Path.GetFileName(item).ToUpper());
                }
                if (lstPublicidad.Items.Count > 0)
                {
                    lstPublicidad.SelectedIndex = 0;
                }
                LstPublicidad_SelectedIndexChanged(lstPublicidad, null);

            }
        }


    }
}
