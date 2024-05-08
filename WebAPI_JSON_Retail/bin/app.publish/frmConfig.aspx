<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmConfig.aspx.cs" Inherits="wResAPI_d3xd.frmConfig" StylesheetTheme="" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>




    <link href="Main_Style.css" rel="stylesheet" type="text/css" />



    <style type="text/css">
        .auto-style30 {
            height: 30px;
            widrh: 100px
        }

        .auto-style32 {
            height: 34px;
            widrh: 100px;
        }
        .auto-style33 {
            height: 34px;
            widrh: 100px;
            width: 181px;
        }
        .auto-style36 {
            height: 36px;
            widrh: 100px;
            width: 181px;
        }
        .auto-style37 {
            height: 36px;
            widrh: 100px;
        }
        .auto-style38 {
            height: 28px;
            widrh: 100px;
            width: 181px;
        }
        .auto-style39 {
            height: 28px;
            widrh: 100px;
        }
        .auto-style40 {
            height: 34px;
            widrh: 100px;
            width: 113px;
        }
        .auto-style41 {
            height: 30px;
            widrh: 100px;
            width: 127px;
        }
        .auto-style42 {
            height: 30px;
            widrh: 100px;
            width: 181px;
        }
        .auto-style43 {
            height: 34px;
            widrh: 100px;
            width: 142px;
        }
        .auto-style44 {
            height: 30px;
            widrh: 100px;
            width: 142px;
        }
        .auto-style45 {
            height: 30px;
            widrh: 100px;
            width: 113px;
        }
    </style>



</head>
<body style="">
    <form id="form1" runat="server">
        <div>

            <table align="center" cellpadding="0" cellspacing="0" style="width: 90%; height: 449px">
                <tr>
                    <td class="TD_logo">
                        <img alt="" class="LogoKSS_Image" src="Imagenes/KssLogo.png" /></td>
                    <td class="Encabezado-Centro">Verificador de Precios&nbsp;WEBDroid V 3.0</td>
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
                                <td>
                                    <asp:Panel ID="Panel1" runat="server" Height="100%" Width="95%" BorderColor="#66CCFF" BorderStyle="Solid" BorderWidth="2px">
                                        <table align="center" cellpadding="0" cellspacing="0" style="width: 100%; height: 100%">
                                            <tr>
                                                <td align="right" bgcolor="#A0CFFE" colspan="2" class="EncabezadoTabla">Configuración de empresa</td>
                                            </tr>
                                            <tr>
                                                <td align="right" class="auto-style30">Empresa:</td>
                                                <td align="left" class="auto-style30">
                                                    <asp:TextBox ID="txtEmpresaNombre" Style="margin-left: 5px" runat="server" Width="300px" MaxLength="50"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right" class="auto-style30">Rif:</td>
                                                <td align="left" class="auto-style30">
                                                    <asp:TextBox ID="txtEmpresarif" Style="margin-left: 5px" runat="server" Width="200px" MaxLength="14"></asp:TextBox>
                                                </td>

                                            </tr>
                                            <tr>
                                                <td align="right" class="auto-style30">N° de Estaciones:</td>
                                                <td align="left" class="auto-style30">
                                                    <asp:TextBox ID="txtnroEstaciones" Style="margin-left: 5px" runat="server" Width="40px" MaxLength="2"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style30">
                                    <asp:Panel ID="Panel2" runat="server" Height="100%" Width="95%" BorderColor="#66CCFF" BorderStyle="Solid" BorderWidth="2px">
                                        <table align="left" cellpadding="0" cellspacing="0" style="width: 100%; height: 100%">
                                            <tr>
                                                <td align="right" bgcolor="#A0CFFE" colspan="6" class="EncabezadoTabla">Configuración de Sistema</td>
                                            </tr>

                                            <tr>
                                                <td align="right" class="auto-style33">Config API:</td>

                                                <td align="left" class="auto-style32">
                                                    <asp:CheckBox ID="chkesSQLServer" runat="server" Text="SQL Server" />
                                                </td>
                                                <td align="left" class="auto-style43">
                                                    <asp:CheckBox ID="chkesRemoteAPI" runat="server" Text="API Remota" />
                                                </td>
                                                <td align="left" class="auto-style32">
                                                    <asp:CheckBox ID="chkesRetailBD" runat="server" Checked="True" Text="BD RetailShop" />
                                                </td>
                                                <td align="left" class="auto-style40">&nbsp;</td>
                                                <td align="left" class="auto-style32">&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td align="right" class="auto-style42">Código Bolívares:</td>
                                                <td align="left" class="auto-style30">
                                                    <asp:TextBox ID="txtCodBolivar" runat="server" Style="margin-left: 5px"></asp:TextBox>
                                                </td>
                                                <td align="left" class="auto-style44">Código Dolar:</td>
                                                <td align="left" class="auto-style30">
                                                    <asp:TextBox ID="txtCodDolar" runat="server" Style="margin-left: 5px"></asp:TextBox>
                                                </td>
                                                <td align="left" class="auto-style45">Código Petro:</td>
                                                <td align="left" class="auto-style30">
                                                    <asp:TextBox ID="txtCodPetro" runat="server" Style="margin-left: 5px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right" class="auto-style42">Ref. Bolívar:</td>
                                                <td align="left" class="auto-style30">
                                                    <asp:TextBox ID="txtMonedaBolivar" runat="server" Style="margin-left: 5px"></asp:TextBox>
                                                </td>
                                                <td align="left" class="auto-style44">Ref. Dolar:</td>
                                                <td align="left" class="auto-style30">
                                                    <asp:TextBox ID="txtMonedaDolar" runat="server" Style="margin-left: 5px"></asp:TextBox>
                                                </td>
                                                <td align="left" class="auto-style45">Ref. Petro:</td>
                                                <td align="left" class="auto-style30">
                                                    <asp:TextBox ID="txtMonedaPetro" runat="server" Style="margin-left: 5px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right" class="auto-style36">Servidor API:</td>
                                                <td align="left" class="auto-style37" colspan="5">
                                                    <asp:TextBox ID="txtServidorAPI" runat="server" MaxLength="250" Style="margin-left: 5px" Width="400px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right" class="auto-style38">Directorio de BD:</td>
                                                <td align="left" class="auto-style39" colspan="5">
                                                    <asp:TextBox ID="txt_dirbd" runat="server" MaxLength="150" Style="margin-left: 5px" Width="400px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right" class="auto-style42">Cadena de conexión:</td>
                                                <td align="left" class="auto-style30" colspan="5">
                                                    <asp:TextBox ID="txt_conexionbd" runat="server" Enabled="False" MaxLength="150" ReadOnly="True" Style="margin-left: 5px" Width="400px"></asp:TextBox>
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
                                                <td align="right" class="auto-style30">Estación:</td>
                                                <td align="center" class="auto-style30" colspan="3">
                                                    <asp:TextBox ID="txt_estacion" runat="server" Width="95%" MaxLength="50"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right" class="auto-style30">Serial:</td>
                                                <td align="center" class="auto-style30" colspan="3">
                                                    <asp:TextBox ID="txt_serial" runat="server" ReadOnly="True" Width="95%" MaxLength="50"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right" class="auto-style30">Clave:</td>
                                                <td align="center" class="auto-style30" colspan="3">
                                                    <asp:TextBox ID="txt_clave" runat="server" Width="95%" MaxLength="50"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right" class="auto-style30">tipo de Estación:</td>
                                                <td align="center" class="auto-style30">
                                                    <asp:RadioButtonList ID="opt_tipo_est" runat="server" CssClass="label_conf_inf style21" Height="98%" RepeatDirection="Horizontal" Width="100%">
                                                        <asp:ListItem Selected="True" Value="0">PC</asp:ListItem>
                                                        <asp:ListItem Value="1">Tablet PC</asp:ListItem>
                                                        <asp:ListItem Value="2">Otro</asp:ListItem>
                                                    </asp:RadioButtonList>
                                                </td>
                                                <td align="center" class="auto-style30">
                                                    <asp:RadioButtonList ID="opt_est_activo0" runat="server" BackColor="#FF3300" CssClass="label_conf_inf" RepeatDirection="Horizontal" Width="90%">
                                                        <asp:ListItem Selected="True" Value="1">Activo</asp:ListItem>
                                                        <asp:ListItem Value="0">Inactivo</asp:ListItem>
                                                    </asp:RadioButtonList>
                                                </td>
                                                <td align="center" class="auto-style30">
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
                        <img alt="" class="BannerKSS_Image" src="Imagenes/Banner%20kalixto.png" /></td>
                </tr>
            </table>



        </div>
    </form>
</body>
</html>
