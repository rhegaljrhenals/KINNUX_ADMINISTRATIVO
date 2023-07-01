<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfExistenciasPorEmpresas.aspx.vb" Inherits="Reportes_wfExistencias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
        <td class="titleseccion"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="5%" align="center">

                <asp:ImageButton ID="ImageButton7" runat="server" Height="40px" 
                    ImageUrl="~/Imagenes/buscar.png" ToolTip="Buscar" Width="40px" />

              </td>
            <td width="5%" align="center">

                <asp:ImageButton ID="ImageButton8" runat="server" Height="40px" 
                    ImageUrl="~/Imagenes/exportarexcel.png" ToolTip="Exportar a Excell" 
                    Width="40px" />
              </td>
            <td width="5%" align="center">

                &nbsp;</td>
                          <td width="90%">Existencias De Productos Por Paises</td>
            </tr>
          </table></td>
      </tr>
    </table>
    <table cellpadding="0" cellspacing="0" class="style1" style="width: 100%">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" style="font-family: 'Courier New', Courier, monospace">
                Seleccione Empresa(Pais):</td>
            <td align="left">
                <asp:DropDownList ID="DropDownList1" runat="server" Width="300px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <asp:Panel ID="Panel2" runat="server" Height="400px" ScrollBars="Vertical">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                        CellPadding="3" Width="100%">
                        <Columns>
                            <asp:BoundField DataField="idProducto" HeaderText="Id Producto" />
                            <asp:BoundField DataField="nombreProducto" HeaderText="Descripcion Productos" />
                            <asp:BoundField DataField="cantBodPaisProducto" HeaderText="Existencias">
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
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
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

