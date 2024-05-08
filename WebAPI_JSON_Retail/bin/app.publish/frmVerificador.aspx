<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmVerificador.aspx.cs" Inherits="wResAPI_d3xd.frmVerificador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

    <link href="Main_Style.css" rel="stylesheet" type="text/css" />


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
                                <td align="right" colspan="3" class="EncabezadoTabla">Consultar Precios</td>
                            </tr>
                            <tr>
                                <td align="right" class="TD_LabelDatos">Código:</td>
                                <td align="center">
                                    <asp:TextBox ID="txtCodigoBarras" runat="server" Width="486px" MaxLength="50" CssClass="TD_Datos"></asp:TextBox>
                                </td>
                                <td align="center" class="auto-style20">
                                    <asp:Button ID="btnOK" runat="server" BackColor="#66CCFF" Text="OK" CssClass="TD_Datos" OnClick="btnOK_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td align="right" colspan="3" style="vertical-align: middle; text-align: left">
                                    <asp:Panel ID="Panel2" runat="server" Height="266px">
                                        <table align="center" cellpadding="0" cellspacing="0" style="width: 100%; height: 100%">
                                            <tr style="padding: 5px; vertical-align: middle; text-align: center;">
                                                <td colspan="2" class="auto-style30">

                                                    <asp:TextBox ID="lbl_producto" runat="server" BackColor="#000066" BorderStyle="Outset" BorderWidth="3px" Font-Bold="True" Font-Names="consolas" Font-Size="30pt" ForeColor="White" Height="100%" ReadOnly="True" TextMode="MultiLine" Width="90%"></asp:TextBox>

                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style32">Precio Base:</td>
                                                <td class="TD_Datos">
                                                    <asp:Label ID="lblPrecioBase" runat="server" CssClass="TD_Datos" Text="0.00"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style31">
                                                    <asp:Label ID="lblLabelIVA" runat="server" CssClass="TD_Datos" Text="IVA:"></asp:Label>
                                                </td>
                                                <td class="TD_Datos">
                                                    <asp:Label ID="lblIVA" runat="server" CssClass="TD_Datos" Text="0.00"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style32">Precio:</td>
                                                <td class="TD_Datos">
                                                    <asp:Label ID="lblPrecio" runat="server" CssClass="TD_Datos" Text="0.00" Font-Bold="True" Font-Size="20pt"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="clear" colspan="2">
                                                    <asp:Label ID="lblPrecioBase0" runat="server" CssClass="TD_Datos" Text="Fecha Actualizacion BD:"></asp:Label>
                                                    <asp:Label ID="lblFechaActualizacion" runat="server" CssClass="TD_Datos" Font-Bold="True" Text="01/01/2001"></asp:Label>
                                                </td>
                                            </tr>
                                            
                                        </table>
                                    </asp:Panel>
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
