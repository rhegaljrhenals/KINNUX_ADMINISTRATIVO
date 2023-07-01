<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfCambiosPosicion.aspx.vb" Inherits="Seguridad_wfCambiosPosicion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
            font-family: "Courier New", Courier, monospace;
        }
        .style2
        {
            width: 100%;
        }
        .style3
        {
            width: 307px;
        }
        .style4
        {
            color: #003366;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
        <td class="titleseccion"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="90%">Actualización De Apalancamientos y Patrocinadores</td>
            <td width="5%" align="center">
                <br />
              </td>
            </tr>
          </table></td>
      </tr>
    </table>
    <table cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                <table cellpadding="0" cellspacing="0" class="style1">
                    <tr>
                        <td>
                            <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" 
                                Text="Cambiar Patrocinador" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td style="width: 400px">
                            &nbsp;</td>
                        <td valign="top">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:MultiView ID="MultiView1" runat="server">
                                <asp:View ID="View1" runat="server">
                                    <table cellpadding="0" cellspacing="0" class="style2">
                                        <tr>
                                            <td bgcolor="#CCCCCC">
                                                <asp:ImageButton ID="ImageButton9" runat="server" Height="40px" 
                                                    ImageUrl="~/Imagenes/guardar.png" ToolTip="Grabar" Width="40px" />
                                            </td>
                                        </tr>
                                    </table>
                                    <br />
                                    <table cellpadding="0" cellspacing="0" class="style2">
                                        <tr>
                                            <td style="width: 400px">
                                                <asp:Panel ID="Panel1" runat="server" BorderColor="Black" BorderStyle="Solid" 
                                                    BorderWidth="1px" Height="200px" Width="450px">
                                                    <table cellpadding="0" cellspacing="0" class="style2">
                                                        <tr>
                                                            <td bgcolor="#006699" colspan="2" style="color: #FFFFFF; text-align: center">
                                                                Patrocinador Actual</td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style4">
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style4">
                                                                Codigo:</td>
                                                            <td>
                                                                <asp:TextBox ID="TextBox1" runat="server" Width="80px"></asp:TextBox>
                                                                <label>
                                                                <asp:Button ID="Button1" runat="server" Height="30px" 
                                                                    style="font-size: medium; font-family: 'Courier New', Courier, monospace; color: #FFFFFF; font-weight: 700; background-color: #006699" 
                                                                    Text="Buscar" Width="100px" />
                                                                </label>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style4">
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style4">
                                                                Afiliado:</td>
                                                            <td>
                                                                <asp:TextBox ID="TextBox7" runat="server" ReadOnly="True" Width="300px"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style4">
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style4">
                                                                Patrocinador:</td>
                                                            <td>
                                                                <asp:TextBox ID="TextBox5" runat="server" ReadOnly="True" Width="80px"></asp:TextBox>
                                                                <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True" Width="250px"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style4">
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                    </table>
                                                </asp:Panel>
                                            </td>
                                            <td style="width: 100px" valign="top">
                                                &nbsp;</td>
                                            <td style="width: 400px" valign="top">
                                                <asp:Panel ID="Panel2" runat="server" BorderColor="Black" BorderStyle="Solid" 
                                                    BorderWidth="1px" Height="200px" Width="450px">
                                                    <table cellpadding="0" cellspacing="0" class="style2">
                                                        <tr>
                                                            <td bgcolor="#006699" colspan="2" style="color: #FFFFFF; text-align: center">
                                                                Nuevo Patrocinador</td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style4">
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style4">
                                                                Codigo:</td>
                                                            <td>
                                                                <asp:TextBox ID="TextBox2" runat="server" Width="80px"></asp:TextBox>
                                                                <label>
                                                                <asp:Button ID="Button2" runat="server" Height="30px" 
                                                                    style="font-size: medium; font-family: 'Courier New', Courier, monospace; color: #FFFFFF; font-weight: 700; background-color: #006699" 
                                                                    Text="Buscar" Width="100px" />
                                                                </label>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style4">
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style4">
                                                                Patrocinador:</td>
                                                            <td>
                                                                <asp:TextBox ID="TextBox6" runat="server" ReadOnly="True" Width="80px"></asp:TextBox>
                                                                <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True" Width="250px"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style4">
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                    </table>
                                                </asp:Panel>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </asp:View>
                                <br />
                                <br />
                            </asp:MultiView>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 400px">
                            &nbsp;</td>
                        <td valign="top">
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

