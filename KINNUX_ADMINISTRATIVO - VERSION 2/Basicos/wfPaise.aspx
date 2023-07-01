<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfPaise.aspx.vb" Inherits="Seguridad_wfGrupoUsuario" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
                
    .header_bottom_image
    {
    background: url(../images/grupo usuario.jpg) left top no-repeat;
    border-left:2px solid #FFF;
    border-bottom:2px solid #FFF;
    height:123px;
    }
        .style6
        {
        }
        .style7
        {
            color: #000066;
            width: 108px;
        }
        </style>



<script type="text/javascript">
    function CallPrint(strid) {
        var prtContent = document.getElementById(strid);
        var WinPrint = window.open('', '', 'letf=0,top=0,width=400,height=400,toolbar=0,scrollbars=0,status=0');
        WinPrint.document.write(prtContent.innerHTML);
        WinPrint.document.close();
        WinPrint.focus();
        WinPrint.print();
        WinPrint.close();

    }
  </script>



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
        <td class="titleseccion"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
          <td width="5%" align="center">
            <asp:ImageButton ID="ImageButton5" runat="server" Height="40px" 
                ImageUrl="~/Imagenes/nuevo.png" ToolTip="Nuevo" 
                Width="40px" />
              </td>
          <td width="5%" align="center">
            <asp:ImageButton ID="ImageButton1" runat="server" Height="40px" 
                ImageUrl="~/Imagenes/guardar.png" ToolTip="Grabar" 
                Width="40px" />
              </td>
                          <td width="90%">Paises</td>
            </tr>
          </table></td>
      </tr>
    </table>
    <asp:Panel ID="Panel2" runat="server" Width="90%">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <table cellpadding="2" class="style1" style="width: 100%">
                    <tr>
                        <td class="style6" colspan="1">
                            &nbsp;</td>
                        <td align="left" colspan="1">
                            <asp:Label ID="Label1" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style7" align="left" colspan="1">
                            Id Pais:</td>
                        <td align="left" colspan="1">
                            <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" 
                                style="margin-left: 0px" Width="75px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style7" colspan="1">
                            Codigo Pais:</td>
                        <td align="left" colspan="1">
                            <asp:TextBox ID="TextBox3" runat="server" Width="80px"></asp:TextBox>
                            &nbsp;<asp:Label ID="Label3" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style7" align="left" colspan="1">
                            Nombre Pais:</td>
                        <td align="left" colspan="1">
                            <asp:TextBox ID="TextBox2" runat="server" Width="228px"></asp:TextBox>
                            &nbsp;<asp:Label ID="Label2" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style7" colspan="1">
                            Prefijo Pais:</td>
                        <td align="left" colspan="1">
                            <asp:TextBox ID="TextBox4" runat="server" Width="80px"></asp:TextBox>
                            &nbsp;<asp:Label ID="Label4" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style7" colspan="1">
                            Estado:</td>
                        <td align="left" colspan="1">
                            <asp:DropDownList ID="DropDownList1" runat="server" Width="228px">
                                <asp:ListItem Value="1">Activo</asp:ListItem>
                                <asp:ListItem Value="2">Eliminado</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6" colspan="1">
                            &nbsp;</td>
                        <td colspan="1">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="left" class="style6" colspan="2">
                            <asp:Label ID="Label5" runat="server" style="color: #003300; font-weight: 700" 
                                Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Panel ID="Panel3" runat="server" Height="400px" ScrollBars="Both">
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3" style="font-size: x-small" Width="100%">
                                    <Columns>
                                        <asp:CommandField SelectText="Seleccione" ShowSelectButton="True" />
                                        <asp:BoundField DataField="idpais" HeaderText="Id Pais" />
                                        <asp:BoundField DataField="codigopais" HeaderText="Codigo Pais" />
                                        <asp:BoundField DataField="nombrepais" HeaderText="Nombre Pais" />
                                        <asp:BoundField DataField="prefijopais" HeaderText="Prefijo" />
                                        <asp:BoundField DataField="estadopais" HeaderText="Estado" />
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
                            <br />
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="ImageButton1" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="ImageButton5" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
</asp:Panel>
<br />
    <p>
        &nbsp;</p>
</asp:Content>

