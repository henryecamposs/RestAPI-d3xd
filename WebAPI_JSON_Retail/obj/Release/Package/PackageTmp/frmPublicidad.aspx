<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPublicidad.aspx.cs" Inherits="wResAPI_d3xd.frmPublicidad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

    <link href="Main_Style.css" rel="stylesheet" type="text/css" />


    <style type="text/css">
        .auto-style32 {
            clear: both;
            width: 60%;
            height: 300px;
        }
       
        </style>


</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table align="center" cellpadding="0" cellspacing="0" style="width: 90%; height: 449px">
                <tr>
                    <td class="TD_logo">
                        <img alt="" class="LogoKSS_Image" src="Imagenes/KssLogo.png" /></td>
                    <td class="Encabezado-Centro">Verificador de Precios&nbsp;WEBDroid V 3.0<br />
                        <asp:Label ID="lblNombreEmpresa" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="Encabezado-Fondo" colspan="2">
                        <asp:LinkButton ID="LinkButton5" runat="server" CssClass="Menu-hz" PostBackUrl="~/Default.aspx">Inicio</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton6" runat="server" CssClass="Menu-hz" PostBackUrl="~/frmConfig.aspx">Configuración</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton7" runat="server" CssClass="Menu-hz" PostBackUrl="~/frmVerificador.aspx">Precios</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton8" runat="server" CssClass="Menu-hz" PostBackUrl="~/frmDivisas.aspx">Divisas</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton1" runat="server" CssClass="Menu-hz" PostBackUrl="~/frmInventario.aspx">Inventario</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton2" runat="server" CssClass="Menu-hz" PostBackUrl="~/frmPublicidad.aspx">Publicidad</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td class="clear" colspan="2">
                        <table style="width: 100%; height: 100%">
                            <tr>
                                <td align="right" colspan="3" class="EncabezadoTabla">Archivos de Publicidad</td>
                            </tr>
                            <tr>
                              <td class="clear" >
                                 <asp:ListBox ID="lstPublicidad" runat="server" Height="300px" Width="90%" AutoPostBack="True" ></asp:ListBox>
                               </td>
                               <td class="auto-style32" >
                                 <asp:Image ID="ImgPublicidad" runat="server" Width="450px" Height="300px" ImageUrl="~/Imagenes/KssLogo.png" />
                               </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td class="TD_BannerKss" colspan="2">
                        <img alt="" class="BannerKSS_Image" src="Imagenes/Banner%20kalixto.png" /></td>
                </tr>
            </table>


        </div>
    </form>
</body>
</html>
