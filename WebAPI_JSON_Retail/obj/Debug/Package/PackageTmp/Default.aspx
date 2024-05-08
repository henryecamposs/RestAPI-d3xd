<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAPI_JSON_Retail.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    
    <link href="Main_Style.css" rel="stylesheet" type="text/css" />
    
    </head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" cellpadding="0" cellspacing="0" style="width: 90%; height: 449px" >
            <tr>
                <td class="TD_logo">
                    <img alt="" class="LogoKSS_Image" src="Imagenes/KssLogo.png" /></td>
                <td class="Encabezado-Centro">Verificador de Precios&nbsp;WEBDroid V 1.0</td>
            </tr>
            <tr>
                <td class="EncabezadoTabla" colspan="2">
                    <asp:LinkButton ID="LinkButton1" runat="server" CssClass="Menu-hz" PostBackUrl="~/Default.aspx">Inicio</asp:LinkButton>
                    |<asp:LinkButton ID="LinkButton2" runat="server" CssClass="Menu-hz" PostBackUrl="~/frmConfig.aspx">Configuración</asp:LinkButton>
                    |<asp:LinkButton ID="LinkButton3" runat="server" CssClass="Menu-hz" PostBackUrl="~/frmVerificador.aspx">Verificador de Precios</asp:LinkButton>
                    |<asp:LinkButton ID="LinkButton4" runat="server" CssClass="Menu-hz" PostBackUrl="~/Handler1.ashx">Interfáz API</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td  colspan="2">
                    <hr />
                </td>
            </tr>
            <tr>
                <td class="TD_Centro" colspan="2">Nuevo Verificador de Precios que integra tablets con Sistema Operativo Android 3.2 y superiores.<br />
                    Optimizado para funcionar con Bases de datos en linea (via Web) usando la tecnología para servidores Web con Internet Information Server (IIS) a partir de la Versión 7 en adelante.
                    <br />
                    Enlaza, en ésta versión, con un motor de bases de datos FoxPro mediante las librerias de Visual FoxPro 9.0 (VFPOLEDB).<br />
                    Probado con Retail_Shop y DataPro DOS, optimizado para agilizar el consumo de datos y mostrar la información en el menor tiempo posible.</td>
            </tr>
            <tr>
                <td colspan="2">
                    <hr />
                </td>
            </tr>
            <tr>
                <td class="TD_BannerKss" colspan="2">
                    <img alt="" class="BannerKSS_Image" src="Imagenes/Banner%20kalixto.jpg" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
