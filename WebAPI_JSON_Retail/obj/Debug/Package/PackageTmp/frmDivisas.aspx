<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDivisas.aspx.cs" Inherits="WebAPI_JSON_Retail.frmDivisas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Divisas</title>
    <link href="Main_Style.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">

        <div>

            <table align="center" cellpadding="0" cellspacing="0" style="width: 90%; height: 449px">
                <tr>
                    <td class="TD_logo">
                        <img alt="" class="LogoKSS_Image" src="Imagenes/KssLogo.png" /></td>
                    <td class="Encabezado-Centro">Verificador de Precios&nbsp;WEBDroid V 1.0<br />
                        <asp:Label ID="lblNombreEmpresa" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="Encabezado-Fondo" colspan="2" style="height:20px;">
                        <asp:LinkButton ID="LinkButton5" runat="server" CssClass="Menu-hz" PostBackUrl="~/Default.aspx">Inicio</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton6" runat="server" CssClass="Menu-hz" PostBackUrl="~/frmConfig.aspx">Configuración</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton7" runat="server" CssClass="Menu-hz" PostBackUrl="~/frmVerificador.aspx">Verificador de Precios</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton8" runat="server" CssClass="Menu-hz" PostBackUrl="~/frmDivisas.aspx">Interfáz API</asp:LinkButton>
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
                                <td align="right" class="EncabezadoTabla">Divisas y Criptomonedas</td>
                            </tr>
                            <tr align="center">
                                <td>
                                    <table style="width: 400px; height: 100%">
                                        <tr>
                                            <td style="width: 50%;" >Moneda</td>
                                            <td style="width: 40%;">Valor</td>
                                            <td style="width: 10%;">Símbolo</td>
                                        </tr>
                                        <tr>
                                            <td></td>
                                        </tr>
                                    </table>

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
                        <img alt="" class="BannerKSS_Image" src="Imagenes/Banner%20kalixto.jpg" /></td>
                </tr>
            </table>


        </div>


    </form>
</body>
</html>
