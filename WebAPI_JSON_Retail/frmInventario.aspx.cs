using System;
using System.Data;

namespace wResAPI_d3xd
{
    public partial class frmInventario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Program.Main();
            DataTable dt = new ServiceAPI().getInventario();
            gridView.DataSource = dt;
            gridView.DataBind();
        }
    }
}