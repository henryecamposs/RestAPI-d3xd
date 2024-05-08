<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmConfig.aspx.cs" Inherits="WebAPI_JSON_Retail.frmConfig" StylesheetTheme="" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>




    <link href="Main_Style.css" rel="stylesheet" type="text/css" />


    <style type="text/css">
        .auto-style30 {
            height: 21px;
        }
        .auto-style31 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            font-weight: bold;
            font-style: normal;
            text-align: right;
            vertical-align: middle;
            background-color: #CCFF99;
            padding-right: 10px;
            width: 252px;
        }
        .auto-style32 {
            width: 252px;
        }
        .auto-style33 {
            text-align: left;
            vertical-align: middle;
            height: 30px;
            padding-left: 10px;
            font-family: Arial;
            font-size: medium;
            width: 237px;
        }
        .auto-style34 {
            text-align: left;
            vertical-align: middle;
            height: 30px;
            padding-left: 10px;
            font-family: Arial;
            font-size: medium;
        }
        .auto-style35 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            font-weight: bold;
            font-style: normal;
            text-align: right;
            vertical-align: middle;
            background-color: #CCFF99;
            padding-right: 10px;
            width: 253px;
        }
        .auto-style36 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            font-weight: bold;
            font-style: normal;
            text-align: right;
            vertical-align: middle;
            background-color: #CCFF99;
            padding-right: 10px;
            width: 194px;
        }
    </style>


</head>
<body style="">
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
                <td class="clear" colspan="2">
                    <table style="width:100%; height :100%">
                        <tr>
                            <td>
                        <asp:Panel ID="Panel1" runat="server" Height="95%" Width="95%" BorderColor="#66CCFF" BorderStyle="Solid" BorderWidth="2px">
                            <table align="center" cellpadding="0" cellspacing="0" style="width: 100%; height: 100%">
                                <tr>
                                    <td align="right" bgcolor="#A0CFFE" colspan="2" class="EncabezadoTabla">Configuración de empresa</td>
                                </tr>
                                <tr>
                                    <td align="right" class="auto-style35">Empresa:</td>
                                    <td align="center" class="TD_Datos">
                                        <asp:TextBox ID="txtEmpresaNombre" runat="server" Width="300px" MaxLength="50"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" class="auto-style35">Rif:</td>
                                    <td align="center" class="TD_Datos">
                                        <asp:TextBox ID="txtEmpresarif" runat="server" Width="200px" MaxLength="14"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" class="auto-style35">N° de Estaciones:</td>
                                    <td align="left" class="auto-style34">
                                        <asp:TextBox ID="txtnroEstaciones" runat="server" Width="40px" MaxLength="2"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style30">
                        <asp:Panel ID="Panel2" runat="server" Height="95%" Width="95%" BorderColor="#66CCFF" BorderStyle="Solid" BorderWidth="2px">
                            <table align="center" cellpadding="0" cellspacing="0" style="width: 100%; height: 100%">
                                <tr>
                                    <td align="right" bgcolor="#A0CFFE" colspan="2" class="EncabezadoTabla">Configuración de Sistema</td>
                                </tr>
                                <tr>
                                    <td align="right" class="auto-style31">Directorio de Trabajo:</td>
                                    <td align="center" class="TD_Datos">
                                        <asp:TextBox ID="txt_dirbd" runat="server" Width="95%" MaxLength="150"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" class="auto-style31">Cadena de conexión:</td>
                                    <td align="center" class="TD_Datos">
                                        <asp:TextBox ID="txt_conexionbd" runat="server" Width="95%" Style="margin-left: 0px" MaxLength="150" Enabled="False" ReadOnly="True"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                            </td>
                        </tr>
                        <tr>
                            <td>
                        <asp:Panel ID="Panel3" runat="server" Height="95%" Width="95%" BorderColor="#66CCFF" BorderStyle="Solid" BorderWidth="2px" Visible="False">
                            <table align="center" cellpadding="0" cellspacing="0" style="width: 100%; height: 100%">
                                <tr>
                                    <td align="right" bgcolor="#99CCFF" colspan="4" class="EncabezadoTabla">Serial de Estación</td>
                                </tr>
                                <tr>
                                    <td align="right" class="auto-style36">Estación:</td>
                                    <td align="center" class="TD_Datos" colspan="3">
                                        <asp:TextBox ID="txt_estacion" runat="server" Width="95%" MaxLength="50"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" class="auto-style36">Serial:</td>
                                    <td align="center" class="TD_Datos" colspan="3">
                                        <asp:TextBox ID="txt_serial" runat="server" ReadOnly="True" Width="95%" MaxLength="50"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" class="auto-style36">Clave:</td>
                                    <td align="center" class="TD_Datos" colspan="3">
                                        <asp:TextBox ID="txt_clave" runat="server" Width="95%" MaxLength="50"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" class="auto-style36">tipo de Estación:</td>
                                    <td align="center" class="auto-style33">
                                        <asp:RadioButtonList ID="opt_tipo_est" runat="server" CssClass="label_conf_inf style21" Height="98%" RepeatDirection="Horizontal" Width="100%">
                                            <asp:ListItem Selected="True" Value="0">PC</asp:ListItem>
                                            <asp:ListItem Value="1">Tablet PC</asp:ListItem>
                                            <asp:ListItem Value="2">Otro</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                    <td align="center" class="TD_Datos">
                                        <asp:RadioButtonList ID="opt_est_activo0" runat="server" BackColor="#FF3300" CssClass="label_conf_inf" RepeatDirection="Horizontal" Width="90%">
                                            <asp:ListItem Selected="True" Value="1">Activo</asp:ListItem>
                                            <asp:ListItem Value="0">Inactivo</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                    <td align="center" class="TD_Datos">
                                        <asp:Button ID="btn_agregar_est" runat="server" Text="Agregar" />
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right">
                                        <asp:Button ID="btnGuardarDatos0" runat="server" Text="Cargar Datos" BackColor="#66CCFF" Font-Bold="True" Font-Size="12pt" OnClick="btnGuardarDatos0_Click" />
                                        <asp:Button ID="btnGuardarDatos" runat="server" Text="Guardar" BackColor="#66CCFF" Font-Bold="True" Font-Size="12pt" OnClick="btnGuardarDatos_Click1" />
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
