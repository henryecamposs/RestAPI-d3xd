using System;
using System.Data;

namespace wResAPI_d3xd
{
    public partial class frmDivisas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new ServiceAPI().GetMonedas();
            gridView.DataSource = dt;
            gridView.DataBind();
        }
    }
}