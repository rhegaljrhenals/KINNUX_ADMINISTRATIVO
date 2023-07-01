<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfSucursale.aspx.vb" Inherits="Basicos_wfSucursale" %>

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
        .style11
        {
            width: 111px;
        }
        .style12
        {
            color: #000066;
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
                ImageUrl="~/Imagenes/nuevo.png" ToolTip="Nuevo Grupo Usuario" 
                Width="40px" />

              </td>
          <td width="5%" align="center">

            <asp:ImageButton ID="ImageButton1" runat="server" Height="40px" 
                ImageUrl="~/Imagenes/guardar.png" ToolTip="Grabar Usuario" 
                Width="40px" />

              </td>
                          <td width="90%">Sucursales</td>
            </tr>
          </table></td>
      </tr>
    </table>
    <asp:Panel ID="Panel3" runat="server" Width="90%">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <table cellpadding="2" class="style1">
                    <tr>
                        <td class="style11">
                            &nbsp;</td>
                        <td align="left">
                            <asp:Label ID="Label1" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style12" align="left">
                            Id Sucursal:</td>
                        <td align="left">
                            <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" 
                                style="margin-left: 0px" Width="75px" CssClass="campver"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style12" align="left">
                            Nombre Sucursal:</td>
                        <td align="left">
                            <asp:TextBox ID="TextBox2" runat="server" Width="350px" CssClass="campver"></asp:TextBox>
                            &nbsp;<asp:Label ID="Label2" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style12">
                            Direccion:</td>
                        <td align="left">
                            <asp:TextBox ID="TextBox3" runat="server" Width="350px" CssClass="campver"></asp:TextBox>
                            &nbsp;<asp:Label ID="Label3" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style12">
                            Telefono:</td>
                        <td align="left">
                            <asp:TextBox ID="TextBox4" runat="server" Width="350px" CssClass="campver"></asp:TextBox>
                            &nbsp;<asp:Label ID="Label4" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style12">
                            Ciudad:</td>
                        <td align="left">
                            <asp:TextBox ID="TextBox5" runat="server" Width="350px" CssClass="campver"></asp:TextBox>
                            &nbsp;<asp:Label ID="Label5" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style12" align="left">
                            Departamento:</td>
                        <td align="left">
                            <asp:TextBox ID="TextBox6" runat="server" Width="350px" CssClass="campver"></asp:TextBox>
                            <asp:Label ID="Label6" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style12">
                            Empresa:</td>
                        <td align="left">
                            <asp:DropDownList ID="DropDownList2" runat="server" Width="228px" 
                                CssClass="campver">
                            </asp:DropDownList>
                            <asp:ImageButton ID="ImageButton6" runat="server" Height="30px" 
                                ImageUrl="~/Imagenes/buscar.png" ToolTip="Sucursales Por Empresas" 
                                Width="30px" />
                            &nbsp;<asp:Label ID="Label7" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style12">
                            Estado:</td>
                        <td align="left">
                            <asp:DropDownList ID="DropDownList1" runat="server" Width="228px" 
                                CssClass="campver">
                                <asp:ListItem Value="1">Activo</asp:ListItem>
                                <asp:ListItem Value="2">Eliminado</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style12">
                            &nbsp;</td>
                        <td align="left">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="left" class="style12" colspan="2">
                            <asp:Label ID="Label8" runat="server" style="color: #003300; font-weight: 700" 
                                Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style12" colspan="2">
                            <asp:Panel ID="Panel2" runat="server" BorderStyle="None" Height="400px" 
                                ScrollBars="Both" Width="100%">
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" 
                                    CellPadding="3" style="font-size: x-small" Width="100%">
                                    <Columns>
                                        <asp:CommandField SelectText="Seleccione" ShowSelectButton="True" />
                                        <asp:BoundField DataField="idsucursal" HeaderText="Id Sucursal" />
                                        <asp:BoundField DataField="nombresucursal" HeaderText="Nombre Sucursal" />
                                        <asp:BoundField DataField="direccionsucursal" HeaderText="Direccion Sucursal" />
                                        <asp:BoundField DataField="telefonosucursal" HeaderText="Telefono" />
                                        <asp:BoundField DataField="idempresa" HeaderText="Id Empresa" />
                                        <asp:BoundField DataField="nombreEmpresa" HeaderText="Nombre Empresa" />
                                        <asp:BoundField DataField="ciudadsucursal" HeaderText="Ciudad" />
                                        <asp:BoundField DataField="dptosucursal" HeaderText="Departamento" />
                                        <asp:BoundField DataField="estadosucursal" HeaderText="Id Estado" />
                                        <asp:BoundField DataField="nombreestado" HeaderText="Nombre Estado" />
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

