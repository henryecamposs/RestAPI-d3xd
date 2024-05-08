using kssLibWeb;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Data;
using System.Globalization;
using wResAPI_d3xd.Entities.RetailShop;
using webAPI_Retail;
using System.Collections.Generic;
using wResAPI_d3xd.Entities;
using wresapi_d3xd.Entities;

namespace wResAPI_d3xd
{
    public partial class frmVerificador : System.Web.UI.Page
    {
        CultureInfo cultureInfo = CultureInfo.GetCultureInfo("es-VE");
        protected void Page_Load(object sender, EventArgs e)
        {
            Program.Main();
            Limpiar();
        }

        INVEN loadItemEncontrado()
        {
            return null;
        }
        protected void btnOK_Click(object sender, EventArgs e)
        {
            Limpiar();
            try
            {
                RestAPI service = new RestAPI(Program.urlServerAPI);
                JObject uservalue = service.GetProductoPorBarra(txtCodigoBarras.Text);
                //JObject uservalue = service.getIVAs( );
                if (txtCodigoBarras.Text.Length > 0)
                {
                    var dt1 = JsonConvert.DeserializeObject(((dynamic)uservalue).Value.ToString());
                    double IVA = 0;
                    if (dt1 != null)
                    {
                        if (dt1 is JArray jsonArray)
                        {
                            foreach (var dr in dt1)
                            {
                                //INVEN inven_entity = clsStatic.RellenarDatarowToClass(dr, new INVEN());
                                inven_verificador inven_entity = JSONParser.parserInvenTable(uservalue);
                                if (inven_entity != null)
                                {
                                    string codigo = inven_entity.codigo?.Trim();
                                    string descr = inven_entity.descr?.Trim();
                                    Double precio = inven_entity.precio;
                                    int tiva = Convert.ToInt16(inven_entity.tiva);
                                    string barra = inven_entity.barra?.Trim();
                                    lbl_producto.Text = descr;
                                    lblPrecio.Text = precio.ToString("N2", cultureInfo);
                                    if (tiva > 0)
                                    {
                                        var drIVA = new ServiceAPI().getIVA_Tipo(tiva);
                                        if (drIVA!=null)
                                        {
                                            lblLabelIVA.Text = $"IVA {Convert.ToDecimal(drIVA.valor).ToString("N2")}%:";
                                            IVA = Convert.ToDouble(drIVA.valor) / 100 + 1;
                                        }
                                        else
                                        {
                                            lblLabelIVA.Text = "IVA 16,00%";
                                            IVA = 1.16;
                                        }
                                        double precioBase = precio / IVA;
                                        lblPrecioBase.Text = precioBase.ToString("N2", cultureInfo);
                                        lblIVA.Text = (precio - precioBase).ToString("N2", cultureInfo);
                                    }
                                    else
                                    {
                                        lblLabelIVA.Text = "Excento:";
                                        lblPrecioBase.Text = precio.ToString("N2", cultureInfo);
                                        lblIVA.Text = "*PRODUCTO EXCENTO*";
                                    }
                                }

                            }
                        }
                        else
                        {
                            inven_verificador inven_entity = JSONParser.parserInvenTable(uservalue);
                            if (inven_entity != null)
                            {
                                string codigo = inven_entity.codigo?.Trim();
                                string descr = inven_entity.descr?.Trim();
                                Double precio = inven_entity.precio;
                                int tiva = Convert.ToInt16(inven_entity.tiva);
                                string barra = inven_entity.barra?.Trim();
                                lbl_producto.Text = descr;
                                lblPrecio.Text = precio.ToString("N2", cultureInfo);
                                if (tiva > 0)
                                {
                                    var drIVA = new ServiceAPI().getIVA_Tipo(tiva);
                                    if (drIVA != null)
                                    {
                                        lblLabelIVA.Text = $"IVA {Convert.ToDecimal(drIVA.valor).ToString("N2")}%:";
                                        IVA = Convert.ToDouble(drIVA.valor) / 100 + 1;
                                    }
                                    else
                                    {
                                        lblLabelIVA.Text = "IVA 16,00%";
                                        IVA = 1.16;
                                    }
                                    double precioBase = precio / IVA;
                                    lblPrecioBase.Text = precioBase.ToString("N2", cultureInfo);
                                    lblIVA.Text = (precio - precioBase).ToString("N2", cultureInfo);
                                }
                                else
                                {
                                    lblLabelIVA.Text = "Excento:";
                                    lblPrecioBase.Text = precio.ToString("N2", cultureInfo);
                                    lblIVA.Text = "*PRODUCTO EXCENTO*";
                                }
                            }
                        }


                    }
                    else
                    {
                        lbl_producto.Text = "*PRODUCTO NO EXISTE!!*";
                    }
                }
                uservalue = service.GetFechaArchivo("");
                string FechaActualizada = ((dynamic)uservalue).Value.ToString();
                lblFechaActualizacion.Text = FechaActualizada;
                uservalue = service.GetNombreEmpresa();
                string NombreEmpresa = ((dynamic)uservalue).Value.ToString();
                lblNombreEmpresa.Text = NombreEmpresa;

            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
            txtCodigoBarras.Text = "";
            txtCodigoBarras.Focus();
        }
        void Limpiar()
        {
            lbl_producto.Text = "";
            lblIVA.Text = "0.00";
            lblPrecio.Text = "0.00";
            lblPrecioBase.Text = "0.00";
        }

    }
}
//var des = (MyClass)Newtonsoft.Json.JsonConvert.DeserializeObject(u.ToString(), typeof(MyClass));
//string response = des.data.Count.ToString();
//dynamic json = JObject.(uservalue);
//inven_table inven = new inven_table(((dynamic)uservalue).Value.ToString());
//Console.WriteLine("Name : " + inven.codigo);
//Console.WriteLine("Teamname : " + inven.precio);
//Console.WriteLine("Email : " + inven.tiva);
//Console.WriteLine("Players:");
//foreach (var player in inven.players)
//    Console.WriteLine(player);
//}