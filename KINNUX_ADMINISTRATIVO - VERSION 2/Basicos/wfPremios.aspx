<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfPremios.aspx.vb" Inherits="Basicos_wfPremios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
    <style type="text/css">
        
        .ModalPopupBG
        {
            background-color: #666699;
            filter: alpha(opacity=50);
            opacity: 0.7;
        }
        
        .style13
        {
            color: #000066;
            font-weight: bold;
            height: 35px;
            width: 38px;
            border-left-color: #A0A0A0;
            border-right-color: #C0C0C0;
            border-top-color: #A0A0A0;
            border-bottom-color: #C0C0C0;
        }
        .style16
        {
            width: 287px;
            color: #000066;
        }
        .style17
        {
            height: 22px;
        }
        .style18
        {
            height: 17px;
            background-color: #006699;
        }
        .style19
        {
            height: 18px;
        }
        .style20
        {
            color: #000066;
        }
        .style21
        {
            height: 17px;
            background-color: #006699;
            color: #FFFFFF;
            font-weight: bold;
        }
        .style22
        {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
        <td class="titleseccion"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
          <td width="5%" align="center">
                    <asp:ImageButton runat="server" ImageUrl="~/Imagenes/nuevo.png" 
                                                        Height="40px" ToolTip="Nuevo" Width="40px" 
                        ID="ImageButton7">
                    </asp:ImageButton>

              </td>
          <td width="5%" align="center">
                    <asp:ImageButton runat="server" ImageUrl="~/Imagenes/guardar.png" 
                                                        Height="40px" ToolTip="Grabar" 
                        Width="40px" ID="ImageButton8">
                    </asp:ImageButton>

              </td>
          <td width="5%" align="center">

                                                    &nbsp;</td>
                          <td width="90%">Premios</td>
            </tr>
          </table></td>
      </tr>
    </table>
    <table cellpadding="2" cellspacing="0" class="style1" 
        style="width: 100%; font-family: 'Courier New', Courier, monospace;">
        <tr>
            <td align="left" colspan="2">
                <asp:Panel ID="panelError" 
                    runat="server" BorderColor="Red" 
                                                                        BorderStyle="Groove" 
                    BorderWidth="1px" Height="164px">
                    <img alt="" class="style13" src="../Imagenes/Remove%20Mark.png" />
                    <asp:Label ID="Label14" runat="server" style="color: #FF0000">Errores Encontrados</asp:Label>
                    <br />
                    <asp:Label ID="Label15" runat="server" style="color: #FF0000"></asp:Label>
                    <br />
                    <br />
                    <br />
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <table cellpadding="2" cellspacing="0" class="style1">
                            <tr>
                                <td class="style16">
                                    id:</td>
                                <td>
                                    <asp:TextBox ID="TextBox7" runat="server" ReadOnly="True" Width="50px"></asp:TextBox>
                                    <asp:TextBox ID="TextBox8" runat="server" ReadOnly="True" Width="50px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style16">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style16">
                                    Pais:</td>
                                <td>
                                    <asp:DropDownList ID="DropDownList23" runat="server" Width="250px">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="style16">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style16">
                                    Nombre premio:</td>
                                <td>
                                    <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 0px" 
                                        Width="250px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style16">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style16">
                                    Precio Premio:</td>
                                <td>
                                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style16">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style16">
                                    Estado:</td>
                                <td>
                                    <asp:DropDownList ID="DropDownList25" runat="server" Width="250px">
                                        <asp:ListItem Value="1">Activo</asp:ListItem>
                                        <asp:ListItem Value="0">Inactivo</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" class="style14" colspan="2">
                <asp:Panel ID="Panel3" runat="server" Height="400px" ScrollBars="Vertical">
                    <asp:GridView ID="GridView2" runat="server" 
    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
    CellPadding="3" AutoGenerateColumns="False" style="font-size: small" Width="100%">
                        <Columns>
                            <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
                            <asp:BoundField DataField="idPremio" HeaderText="Id" />
                            <asp:BoundField DataField="nombrePremio" HeaderText="Nombre Premio" />
                            <asp:BoundField DataField="idPremioPais" HeaderText="Id Premio Pais" />
                            <asp:BoundField DataField="precioPremioPais" HeaderText="Precio" />
                            <asp:BoundField DataField="estadoPremioPais" HeaderText="Estado" />
                            <asp:BoundField DataField="codigoPais" HeaderText="CodigoPais" />
                            <asp:BoundField DataField="nombrePais" HeaderText="Pais" />
                        </Columns>
                        <FooterStyle BackColor="White" ForeColor="#000066" />
                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                        <RowStyle ForeColor="#000066" />
                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#007DBB" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#00547E" />
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td align="left" class="style17">
                <asp:Panel ID="Panel4" runat="server" Height="153px" Width="424px" 
                    BackColor="#FFFFCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px">
                    <table cellpadding="0" cellspacing="0" class="style1">
                        <tr>
                            <td class="style21">
                                Confirmación</td>
                            <td align="right" class="style18">
                                <asp:ImageButton ID="ImageButton9" runat="server" Height="20px" 
                                    ImageUrl="~/Imagenes/xkill.png" ToolTip="Cerrar" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style19" colspan="2">
                                <asp:Image ID="Image2" runat="server" Height="40px" 
                                    ImageUrl="~/Imagenes/Info 2.png" />
                                &nbsp;<span class="style20">Premio Grabado Satisfactoriamente...!</span></td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="center" class="style22" colspan="2">
                                <asp:Button ID="Button1" runat="server" Text="Aceptar" />
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2">
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            <td align="left" class="style17">
                </td>
        </tr>
        <tr>
            <td align="left" class="style14">
                &nbsp;</td>
            <td align="left">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

