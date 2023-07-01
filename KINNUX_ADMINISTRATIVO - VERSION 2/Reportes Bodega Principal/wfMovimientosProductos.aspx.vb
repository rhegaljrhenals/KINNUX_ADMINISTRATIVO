Imports System.Data

Partial Class Reportes_Bodega_Principal_wfMovimientosProductos
    Inherits System.Web.UI.Page

    Dim empresas As New clsEmpresa
    Dim sucursales As New clsSucursale
    Dim bodegaPunto As New clsTTBodPuntoProducto
    Dim bodegaPais As New clsTTBodPaisProducto
    Dim pedidosPais As New clsTTBodPaisProducto
    Dim detalleDespachoaPuntos As New clsTTEncDesProductoPunto
    Dim detalleDespachoPaisPais As New clsTTEncDesProductoPaisPais

    Sub cargarPaises()
        Dim tabla As New DataTable
        With empresas
            tabla = .MostrarEmpresaGeneral
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList7.DataSource = tabla
                Me.DropDownList7.DataTextField = "nombreempresa"
                Me.DropDownList7.DataValueField = "idempresa"
                Me.DropDownList7.DataBind()
            Else
                Me.DropDownList7.DataSource = Nothing
                Me.DropDownList7.DataBind()
            End If
            Me.DropDownList7.Items.Insert(0, "Seleccione Empresa")
        End With
    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarPaises()
            cargarAno()
            Me.Menu1.Visible = False
        End If
    End Sub

    Sub cargarAno()
        Dim y As Integer
        For y = 2011 To Now.Year
            Me.DropDownList1.Items.Add(y)
            Me.DropDownList4.Items.Add(y)

        Next
        Me.DropDownList1.Items.Insert(0, "Año")
        Me.DropDownList4.Items.Insert(0, "Año")
    End Sub

    Protected Sub ImageButton7_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
        Me.Menu1.Visible = False
        Me.Panel6.Visible = False
        '
        Me.Label4.Text = ""
        Me.Label5.Text = ""
        Me.Label6.Text = ""
        '
        If Me.DropDownList1.SelectedIndex = 0 Or Me.DropDownList2.SelectedIndex = 0 Or Me.DropDownList3.SelectedIndex = 0 Then
            Me.Label4.Text = "Seleccione la fecha inicial correctamente...!"
            Exit Sub
        End If
        '
        If Me.DropDownList4.SelectedIndex = 0 Or Me.DropDownList5.SelectedIndex = 0 Or Me.DropDownList6.SelectedIndex = 0 Then
            Me.Label5.Text = "Seleccione la facha final correctamente...!"
            Exit Sub
        End If
        '
        If Me.DropDownList7.SelectedIndex = 0 Then
            Me.Label6.Text = "Seleccione la empresa o pais...!"
            Exit Sub
        End If
        '
        mostrarExistencias()
    End Sub

    Sub mostrarExistencias()
        Dim tabla As New DataTable
        With bodegaPais
            .idEmpresa = Me.DropDownList7.SelectedValue
            tabla = .obtenerExistenciasPorEmpresas
            If tabla.Rows.Count <> 0 Then
                Me.GridView3.DataSource = tabla
                Me.GridView3.DataBind()
            Else
                '
                Me.GridView3.DataSource = Nothing
                Me.GridView3.DataBind()
            End If
        End With
        '
    End Sub

    Sub mostrarDetallePedidoPais(ByVal idProducto As Integer)
        Me.MultiView1.ActiveViewIndex = 0
        Dim tabla As New DataTable
        With pedidosPais
            .idEmpresa = Me.DropDownList7.SelectedValue
            .idProducto = idProducto
            .fechaInicial = Me.DropDownList1.SelectedItem.Text & "/" & Me.DropDownList2.SelectedValue & "/" & Me.DropDownList3.SelectedValue
            .fechaFinal = Me.DropDownList4.SelectedItem.Text & "/" & Me.DropDownList5.SelectedValue & "/" & Me.DropDownList6.SelectedValue
            tabla = .obtenerPedidosPorProductos
            If tabla.Rows.Count <> 0 Then
                Me.GridView6.DataSource = tabla
                Me.GridView6.DataBind()
                ' mostrarTotales
                mostrarTotalesPedidos()
            Else
                Me.GridView6.DataSource = Nothing
                Me.GridView6.DataBind()
            End If
        End With
    End Sub

    Sub mostrarTotalesPedidos()
        Dim y As Integer
        Dim suma As Double = 0
        For y = 0 To Me.GridView6.Rows.Count - 1
            suma += CDbl(Me.GridView6.Rows(y).Cells(3).Text)
        Next
        Me.GridView6.FooterRow.Cells(3).Text = FormatNumber(suma, 0)
        Me.GridView6.FooterRow.Cells(0).Text = "Total:"
    End Sub

    Protected Sub GridView3_SelectedIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView3.SelectedIndexChanging
        Me.Panel6.Visible = True
        Me.Menu1.Visible = True
        Menu1.SelectedValue.Equals("Entradas")
        mostrarDetallePedidoPais(Me.GridView3.Rows(e.NewSelectedIndex).Cells(1).Text)
        mostrarDetalleDespachoPuntos(Me.GridView3.Rows(e.NewSelectedIndex).Cells(1).Text)
        mostrarDetalleDespachoPaisPais(Me.GridView3.Rows(e.NewSelectedIndex).Cells(1).Text)
    End Sub

    Sub mostrarDetalleDespachoPaisPais(ByVal idProducto As Integer)
        Dim tabla As New DataTable
        With detalleDespachoPaisPais
            .idEmpresa = Me.DropDownList7.SelectedValue
            .idProducto = idProducto
            .fechaInicial = Me.DropDownList1.SelectedItem.Text & "/" & Me.DropDownList2.SelectedValue & "/" & Me.DropDownList3.SelectedValue
            .fechaFinal = Me.DropDownList4.SelectedItem.Text & "/" & Me.DropDownList5.SelectedValue & "/" & Me.DropDownList6.SelectedValue
            tabla = .obtenerDespachosPaises
            If tabla.Rows.Count <> 0 Then
                Me.GridView8.DataSource = tabla
                Me.GridView8.DataBind()
                ' mostrar totales
                mostrarTotalesDespachosPaisPais()
            Else
                Me.GridView8.DataSource = Nothing
                Me.GridView8.DataBind()
            End If
        End With
    End Sub

    Sub mostrarTotalesDespachosPaisPais()
        Dim y As Integer
        Dim suma1 As Double = 0
        Dim suma2 As Double = 0
        Dim suma3 As Double = 0
        '
        For y = 0 To Me.GridView8.Rows.Count - 1
            suma1 += Val(Me.GridView8.Rows(y).Cells(5).Text)
            suma2 += Val(Me.GridView8.Rows(y).Cells(6).Text)
            suma3 += Val(Me.GridView8.Rows(y).Cells(7).Text)
        Next
        Me.GridView8.FooterRow.Cells(5).Text = FormatNumber(suma1, 0)
        Me.GridView8.FooterRow.Cells(6).Text = FormatNumber(suma2, 0)
        Me.GridView8.FooterRow.Cells(7).Text = FormatNumber(suma3, 0)
        Me.GridView8.FooterRow.Cells(0).Text = "Total:"
    End Sub

    Sub mostrarDetalleDespachoPuntos(ByVal idProducto As Integer)
        Dim tabla As New DataTable
        With detalleDespachoaPuntos
            .idEmpresa = Me.DropDownList7.SelectedValue
            .idProducto = idProducto
            .fechaInicial = Me.DropDownList1.SelectedItem.Text & "/" & Me.DropDownList2.SelectedValue & "/" & Me.DropDownList3.SelectedValue
            .fechaFinal = Me.DropDownList4.SelectedItem.Text & "/" & Me.DropDownList5.SelectedValue & "/" & Me.DropDownList6.SelectedValue
            tabla = .obtenerDespachosaPuntos
            If tabla.Rows.Count <> 0 Then
                Me.GridView7.DataSource = tabla
                Me.GridView7.DataBind()
                ' mostrar totales
                mostrarTotalesDespachos()
            Else
                Me.GridView7.DataSource = Nothing
                Me.GridView7.DataBind()
            End If
        End With
    End Sub

    Sub mostrarTotalesDespachos()
        Dim y As Integer
        Dim suma1 As Double = 0
        Dim suma2 As Double = 0
        Dim suma3 As Double = 0
        '
        For y = 0 To Me.GridView7.Rows.Count - 1
            suma1 += Val(Me.GridView7.Rows(y).Cells(6).Text)
            suma2 += Val(Me.GridView7.Rows(y).Cells(7).Text)
            suma3 += Val(Me.GridView7.Rows(y).Cells(8).Text)
        Next
        Me.GridView7.FooterRow.Cells(6).Text = FormatNumber(suma1, 0)
        Me.GridView7.FooterRow.Cells(7).Text = FormatNumber(suma2, 0)
        Me.GridView7.FooterRow.Cells(8).Text = FormatNumber(suma3, 0)
        Me.GridView7.FooterRow.Cells(0).Text = "Total:"
    End Sub

    Protected Sub Menu1_MenuItemClick(sender As Object, e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu1.MenuItemClick
        Select Case e.Item.Text
            Case "Entradas"
                Me.MultiView1.ActiveViewIndex = 0
            Case "Salidas"
                Me.MultiView1.ActiveViewIndex = 1
            Case "Resumen"
                Me.MultiView1.ActiveViewIndex = 2
        End Select
    End Sub

End Class
