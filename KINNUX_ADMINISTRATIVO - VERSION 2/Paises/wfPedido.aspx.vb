Imports System.Data
Imports System.IO

Partial Class Paises_wfPedido
    Inherits System.Web.UI.Page

    'Dim encabezadoPedido As New clsEncabezadoPedido
    'Dim proveedore As New clsProveedore
    'Dim paise As New clsPaise
    'Dim consecutivoPedido As New clsConsecutivoPedido
    'Dim producto As New clsProducto
    'Dim detallePedido As New clsDetallePedido
    'Dim bodegaPrincipal As New clsExistenciaBodegaPrincipal
    'Dim premio As New clsPremio
    'Dim papeleria As New clsPapeleria
    'Dim empresa As New clsEmpresa

    'Sub nuevoPedidoPremio()
    '    Me.DropDownList25.SelectedIndex = 0
    '    Me.TextBox29.Text = ""
    '    Me.TextBox27.Text = ""
    '    '
    '    Me.DropDownList27.SelectedIndex = 0
    '    '
    '    Me.panelErrorPremio.Visible = False
    '    obtenerNumeroPedidoPremio()
    '    '
    '    Me.GridView7.DataSource = Nothing
    '    Me.GridView7.DataBind()
    'End Sub

    'Sub obtenerNumeroPedidoPremio()
    '    Dim tabla As New DataTable
    '    With consecutivoPedido
    '        .descripcion = "Pais-Bodega"
    '        .tipo = "Premio"
    '        tabla = .obtenerNumeroConsecutivo
    '        If tabla.Rows.Count = 0 Then
    '            Session("consecutivoPremio") = 0
    '        Else
    '            Session("consecutivoPremio") = tabla.Rows(0).Item("numero")
    '        End If
    '        Session("consecutivoPremio") += 1
    '        Me.TextBox28.Text = Session("consecutivoPremio")
    '    End With
    'End Sub


    'Sub cargarPaise()
    '    Dim tabla As New DataTable
    '    With paise
    '        tabla = .MostrarPaise
    '        Me.DropDownList24.DataSource = tabla
    '        Me.DropDownList24.DataTextField = "nombrePais"
    '        Me.DropDownList24.DataValueField = "idPais"
    '        Me.DropDownList24.DataBind()
    '        Me.DropDownList24.Items.Insert(0, "Seleccione El Pais")
    '        '
    '        Me.DropDownList25.DataSource = tabla
    '        Me.DropDownList25.DataTextField = "nombrePais"
    '        Me.DropDownList25.DataValueField = "idPais"
    '        Me.DropDownList25.DataBind()
    '        Me.DropDownList25.Items.Insert(0, "Seleccione El Pais")
    '        '
    '        Me.DropDownList28.DataSource = tabla
    '        Me.DropDownList28.DataTextField = "nombrePais"
    '        Me.DropDownList28.DataValueField = "idPais"
    '        Me.DropDownList28.DataBind()
    '        Me.DropDownList28.Items.Insert(0, "Seleccione El Pais")
    '        '
    '        Me.DropDownList31.DataSource = tabla
    '        Me.DropDownList31.DataTextField = "nombrePais"
    '        Me.DropDownList31.DataValueField = "idPais"
    '        Me.DropDownList31.DataBind()
    '        Me.DropDownList31.Items.Insert(0, "Seleccione El Pais")
    '        '
    '        Me.DropDownList32.DataSource = tabla
    '        Me.DropDownList32.DataTextField = "nombrePais"
    '        Me.DropDownList32.DataValueField = "idPais"
    '        Me.DropDownList32.DataBind()
    '        Me.DropDownList32.Items.Insert(0, "Seleccione El Pais")
    '        '
    '        Me.DropDownList33.DataSource = tabla
    '        Me.DropDownList33.DataTextField = "nombrePais"
    '        Me.DropDownList33.DataValueField = "idPais"
    '        Me.DropDownList33.DataBind()
    '        Me.DropDownList33.Items.Insert(0, "Seleccione El Pais")
    '        '
    '    End With
    'End Sub

    'Sub Nuevo()
    '    Me.TextBox1.Text = ""
    '    Me.panelError.Visible = False
    '    Me.Label15.Text = ""
    '    '
    '    Me.DropDownList24.SelectedIndex = 0
    '    '
    '    Me.TextBox24.Text = ""
    '    '
    '    Session("accion") = 1
    '    '
    '    obtenerNumero()
    '    '
    '    Me.GridView5.DataSource = Nothing
    '    Me.GridView5.DataBind()
    'End Sub

    ''Sub actualizaBodegaPrincipal()
    ''    Dim fila As GridViewRow
    ''    Dim productoSeleccionado As String = "no"
    ''    For y = 0 To Me.GridView5.Rows.Count - 1
    ''        fila = Me.GridView5.Rows(y)
    ''        If fila.RowType = DataControlRowType.DataRow Then
    ''            Dim c1 As CheckBox = CType(Me.GridView5.Rows(y).FindControl("CheckBox1"), CheckBox)
    ''            Dim cantidad As TextBox = CType(Me.GridView5.Rows(y).FindControl("TextBox7"), TextBox)
    ''            Dim precio As TextBox = CType(Me.GridView5.Rows(y).FindControl("TextBox26"), TextBox)
    ''            With bodegaPrincipal
    ''                If c1.Checked = True And Val(cantidad.Text) > 0 Then
    ''                    .idExistenciaBodega = 0
    ''                    .idProducto = Me.GridView5.Rows(y).Cells(1).Text
    ''                    .cantidad = Val(cantidad.Text)
    ''                    .tipoProducto = "PRO"
    ''                    .actualizarExistenciaBodegaPrincipal(1)
    ''                End If
    ''            End With
    ''        End If
    ''    Next
    ''End Sub

    'Sub actualizarConsecutivo()
    '    With consecutivoPedido
    '        .descripcion = "Pais-Bodega"
    '        .tipo = "Producto"
    '        .actualizaConsecutivo(Session("consecutivo"))
    '    End With
    'End Sub

    'Sub grabar()
    '    With encabezadoPedido
    '        .idEncabezadoPedido = 0
    '        .idTipoEncabezadoPedido = "PRO"
    '        .fechaEncabezadoPedido = Me.TextBox24.Text
    '        .TipoEnvioPedido = "PRO"
    '        .idSolicitante = Me.DropDownList35.SelectedValue
    '        .idSolicitado = 0
    '        .consecutivoPedido = Val(Me.TextBox25.Text)
    '        .idPais = Me.DropDownList24.SelectedValue
    '        .estadoEncabezadoPedido = Me.DropDownList1.SelectedValue
    '        .proceso = "PAI-BPR"
    '        .actualizarEncabezadoPedido(Session("accion"))
    '    End With
    'End Sub

    'Function validaProducto() As String
    '    Dim fila As GridViewRow
    '    Dim productoSeleccionado As String = "no"
    '    For y = 0 To Me.GridView5.Rows.Count - 1
    '        fila = Me.GridView5.Rows(y)
    '        If fila.RowType = DataControlRowType.DataRow Then
    '            Dim c1 As CheckBox = CType(Me.GridView5.Rows(y).FindControl("CheckBox1"), CheckBox)
    '            Dim cantidad As TextBox = CType(Me.GridView5.Rows(y).FindControl("TextBox7"), TextBox)
    '            Dim precio As TextBox = CType(Me.GridView5.Rows(y).FindControl("TextBox26"), TextBox)
    '            If c1.Checked = True And (Val(cantidad.Text) > 0 And Val(precio.Text) > 0) Then
    '                productoSeleccionado = "si"
    '                Exit For
    '            Else
    '                productoSeleccionado = "no"
    '            End If
    '        End If
    '    Next
    '    Return productoSeleccionado
    'End Function

    'Sub grabarDetallePedido()
    '    Dim y As Integer
    '    Dim fila As GridViewRow
    '    For y = 0 To Me.GridView5.Rows.Count - 1
    '        fila = Me.GridView5.Rows(y)
    '        If fila.RowType = DataControlRowType.DataRow Then
    '            Dim c1 As CheckBox = CType(Me.GridView5.Rows(y).FindControl("CheckBox1"), CheckBox)
    '            Dim cantidad As TextBox = CType(Me.GridView5.Rows(y).FindControl("TextBox7"), TextBox)
    '            Dim precio As TextBox = CType(Me.GridView5.Rows(y).FindControl("TextBox26"), TextBox)
    '            If c1.Checked = True Then
    '                With detallePedido
    '                    .idDetallePedido = 0
    '                    .idEncabezadoPedido = Val(Me.TextBox25.Text)
    '                    .idProducto = Me.GridView5.Rows(y).Cells(1).Text
    '                    .cantidadDetallePedido = Val(cantidad.Text)
    '                    .preciodetallePedido = Val(precio.Text)
    '                    .tipoProducto = "PRO"
    '                    .actualizarDetallepedido(1)
    '                End With
    '            End If
    '        End If
    '    Next
    'End Sub

    'Sub obtenerNumero()
    '    Dim tabla As New DataTable
    '    With consecutivoPedido
    '        .descripcion = "Pais-Bodega"
    '        .tipo = "Producto"
    '        tabla = .obtenerNumeroConsecutivo
    '        If tabla.Rows.Count = 0 Then
    '            Session("consecutivo") = 0
    '        Else
    '            Session("consecutivo") = tabla.Rows(0).Item("numero")
    '        End If
    '        Session("consecutivo") += 1
    '        Me.TextBox25.Text = Session("consecutivo")
    '    End With
    'End Sub

    'Protected Sub DropDownList24_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList24.SelectedIndexChanged
    '    If Me.DropDownList24.SelectedIndex > 0 Then
    '        mostrarProductoPorPais()
    '        mostrarEmpresaPorPais()
    '    End If
    'End Sub

    'Sub mostrarEmpresaPorPais()
    '    Dim tabla As New DataTable
    '    With empresa
    '        .IdPais = Me.DropDownList24.SelectedValue
    '        tabla = .MostrarEmpresaPorPais
    '        If tabla.Rows.Count <> 0 Then
    '            Me.DropDownList35.DataSource = tabla
    '            Me.DropDownList35.DataTextField = "nombreEmpresa"
    '            Me.DropDownList35.DataValueField = "idEmpresa"
    '            Me.DropDownList35.DataBind()
    '            Me.DropDownList35.Items.Insert(0, "Seleccione Empresa")
    '        End If
    '    End With
    'End Sub

    'Sub mostrarProductoPorPais()
    '    Dim tabla As New DataTable
    '    If Me.DropDownList24.SelectedIndex <> -1 Then
    '        With producto
    '            .pais = Me.DropDownList24.SelectedValue
    '            tabla = .obtenerProductoTipoProductoPorPais
    '            Me.GridView5.DataSource = tabla
    '            Me.GridView5.DataBind()
    '        End With
    '    End If
    'End Sub

    'Sub mostrarInformacion()
    '    Dim tabla As New DataTable
    '    With encabezadoPedido
    '        .idEncabezadoPedido = Val(Me.TextBox1.Text)
    '        tabla = .obtenerPedidoPorId
    '        If tabla.Rows.Count <> 0 Then
    '            Me.DropDownList24.SelectedValue = tabla.Rows(0).Item("idPais")
    '            mostrarProductoPorPais()
    '            '
    '            Me.TextBox25.Text = tabla.Rows(0).Item("consecutivoPedido")
    '            Me.TextBox24.Text = tabla.Rows(0).Item("fechaEncabezadoPedido")
    '            '
    '        End If
    '    End With
    'End Sub

    'Sub mostrarProductoPorColeccion()
    '    Dim fila As GridViewRow
    '    Dim y, k As Integer
    '    Dim tabla As New DataTable
    '    With detallePedido
    '        .idEncabezadoPedido = Val(Me.TextBox1.Text)
    '        tabla = .obtenerDetallePedidoPorId
    '        If tabla.Rows.Count <> 0 Then
    '            For k = 0 To tabla.Rows.Count - 1
    '                Dim idProducto As Integer = tabla.Rows(k).Item("idProducto")
    '                Dim cantidad As Integer = tabla.Rows(k).Item("cantidadDetallePedido")
    '                Dim precio As Integer = tabla.Rows(k).Item("precioDetallePedido")
    '                For y = 0 To Me.GridView5.Rows.Count - 1
    '                    fila = Me.GridView5.Rows(y)
    '                    If fila.RowType = DataControlRowType.DataRow Then
    '                        Dim c1 As CheckBox = CType(Me.GridView5.Rows(y).FindControl("CheckBox1"), CheckBox)
    '                        Dim c As TextBox = CType(Me.GridView5.Rows(y).FindControl("Textbox7"), TextBox)
    '                        Dim p As TextBox = CType(Me.GridView5.Rows(y).FindControl("Textbox26"), TextBox)
    '                        If idProducto = Me.GridView5.Rows(y).Cells(1).Text Then
    '                            c1.Checked = True
    '                            c.Text = cantidad
    '                            p.Text = precio
    '                            Exit For
    '                        End If
    '                    End If
    '                Next
    '            Next
    '        End If
    '    End With
    'End Sub

    'Protected Sub ImageButton17_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton17.Click
    '    Nuevo()
    'End Sub

    'Protected Sub ImageButton18_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton18.Click
    '    Dim mensajeError As String = Nothing
    '    Dim huboError As String = "no"
    '    Me.panelError.Visible = False
    '    Me.Label15.Text = ""
    '    '
    '    If Me.DropDownList24.SelectedIndex = 0 Then
    '        huboError = "si"
    '        mensajeError = "- Seleccione el Pais"
    '    End If
    '    '
    '    If Me.DropDownList35.SelectedIndex = 0 Or Me.DropDownList35.SelectedIndex = -1 Then
    '        huboError = "si"
    '        mensajeError = mensajeError & "<br>" & "- Seleccione la empresa"
    '    End If
    '    '
    '    If Me.TextBox24.Text = "" Then
    '        huboError = "si"
    '        mensajeError = mensajeError & "<br>" & "- Ingrese la fecha del pedido"
    '    End If
    '    '
    '    '-----------------------------------------------------
    '    Dim seleccionProducto As String
    '    If Session("accion") = 1 Then
    '        seleccionProducto = validaProducto()
    '        If seleccionProducto = "no" Then
    '            huboError = "si"
    '            mensajeError = mensajeError & "<br>" & "- Debe seleccionar por lo menos un producto con su cantidad"
    '        End If
    '    End If
    '    '-----------------------------------------------------

    '    If huboError = "si" Then
    '        Me.panelError.Visible = True
    '        Me.Label15.Text = mensajeError
    '        Exit Sub
    '    End If
    '    grabar()
    '    grabarDetallePedido()
    '    'actualizaBodegaPrincipal()
    '    actualizarConsecutivo()
    '    '
    '    mostrarProductoPorPais()
    '    Nuevo()
    'End Sub

    'Protected Sub DropDownList25_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList25.SelectedIndexChanged
    '    If Me.DropDownList25.SelectedIndex <> 0 Then
    '        mostrarPremioPorPais()
    '        mostrarEmpresaPorPaisPremios()
    '    Else

    '    End If
    'End Sub

    'Sub mostrarEmpresaPorPaisPremios()
    '    Dim tabla As New DataTable
    '    With empresa
    '        .IdPais = Me.DropDownList25.SelectedValue
    '        tabla = .MostrarEmpresaPorPais
    '        If tabla.Rows.Count <> 0 Then
    '            Me.DropDownList36.DataSource = tabla
    '            Me.DropDownList36.DataTextField = "nombreEmpresa"
    '            Me.DropDownList36.DataValueField = "idEmpresa"
    '            Me.DropDownList36.DataBind()
    '        End If
    '    End With
    'End Sub

    'Sub mostrarPremioPorPais()
    '    Dim tabla As New DataTable
    '    With premio
    '        If Me.DropDownList25.SelectedValue <> 0 Then
    '            .idPais = Me.DropDownList25.SelectedValue
    '            tabla = .obtenerPremiosPorPais
    '            Me.GridView7.DataSource = tabla
    '            Me.GridView7.DataBind()
    '        Else

    '        End If
    '    End With
    'End Sub

    'Protected Sub ImageButton20_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton20.Click
    '    Dim mensajeError As String = Nothing
    '    Dim huboError As String = "no"
    '    Me.panelError.Visible = False
    '    Me.Label17.Text = ""
    '    '
    '    If Me.DropDownList25.SelectedIndex = 0 Then
    '        huboError = "si"
    '        mensajeError = "- Seleccione el Pais"
    '    End If
    '    '
    '    If Me.DropDownList36.SelectedIndex = 0 Or Me.DropDownList36.SelectedIndex = -1 Then
    '        huboError = "si"
    '        mensajeError = mensajeError & "<br>" & "- Seleccione La empresa"
    '    End If
    '    '
    '    If Me.TextBox29.Text = "" Then
    '        huboError = "si"
    '        mensajeError = mensajeError & "<br>" & "- Ingrese la fecha del pedido"
    '    End If
    '    '
    '    '-----------------------------------------------------
    '    Dim seleccionProducto As String
    '    If Session("accion") = 1 Then
    '        seleccionProducto = validaProductoPremio()
    '        If seleccionProducto = "no" Then
    '            huboError = "si"
    '            mensajeError = mensajeError & "<br>" & "- Debe seleccionar por lo menos un producto con su cantidad"
    '        End If
    '    End If
    '    '-----------------------------------------------------

    '    If huboError = "si" Then
    '        Me.panelErrorPremio.Visible = True
    '        Me.Label17.Text = mensajeError
    '        Exit Sub
    '    End If
    '    grabarPedidoPremio()
    'End Sub

    'Function validaProductoPremio() As String
    '    Dim fila As GridViewRow
    '    Dim productoSeleccionado As String = "no"
    '    For y = 0 To Me.GridView7.Rows.Count - 1
    '        fila = Me.GridView7.Rows(y)
    '        If fila.RowType = DataControlRowType.DataRow Then
    '            Dim c1 As CheckBox = CType(Me.GridView7.Rows(y).FindControl("CheckBox2"), CheckBox)
    '            Dim cantidad As TextBox = CType(Me.GridView7.Rows(y).FindControl("TextBox30"), TextBox)
    '            Dim precio As TextBox = CType(Me.GridView7.Rows(y).FindControl("TextBox31"), TextBox)
    '            If c1.Checked = True And (Val(cantidad.Text) > 0 And Val(precio.Text) > 0) Then
    '                productoSeleccionado = "si"
    '                Exit For
    '            Else
    '                productoSeleccionado = "no"
    '            End If
    '        End If
    '    Next
    '    Return productoSeleccionado
    'End Function

    'Sub grabarPedidoPremio()
    '    grabarEncabezadoPedidoPremio()
    '    grabarDetallePedidoPremio()
    '    'actualizaBodegaPrincipalPremio()
    '    actualizarConsecutivoPedidoPremio()
    '    '
    '    mostrarPremioPorPais()
    '    nuevoPedidoPremio()
    'End Sub

    'Sub actualizarConsecutivoPedidoPremio()
    '    With consecutivoPedido
    '        .descripcion = "Pais-Bodega"
    '        .tipo = "Premio"
    '        .actualizaConsecutivo(Session("consecutivoPremio"))
    '    End With
    'End Sub

    ''Sub actualizaBodegaPrincipalPremio()
    ''    Dim fila As GridViewRow
    ''    Dim productoSeleccionado As String = "no"
    ''    For y = 0 To Me.GridView7.Rows.Count - 1
    ''        fila = Me.GridView7.Rows(y)
    ''        If fila.RowType = DataControlRowType.DataRow Then
    ''            Dim c1 As CheckBox = CType(Me.GridView7.Rows(y).FindControl("CheckBox2"), CheckBox)
    ''            Dim cantidad As TextBox = CType(Me.GridView7.Rows(y).FindControl("TextBox30"), TextBox)
    ''            Dim precio As TextBox = CType(Me.GridView7.Rows(y).FindControl("TextBox31"), TextBox)
    ''            With bodegaPrincipal
    ''                If c1.Checked = True And Val(cantidad.Text) > 0 Then
    ''                    .idExistenciaBodega = 0
    ''                    .idProducto = Me.GridView7.Rows(y).Cells(1).Text
    ''                    .cantidad = Val(cantidad.Text)
    ''                    .tipoProducto = "PRE"
    ''                    .actualizarExistenciaBodegaPrincipal(1)
    ''                End If
    ''            End With
    ''        End If
    ''    Next
    ''End Sub

    'Sub grabarDetallePedidoPremio()
    '    Dim y As Integer
    '    Dim fila As GridViewRow
    '    For y = 0 To Me.GridView7.Rows.Count - 1
    '        fila = Me.GridView7.Rows(y)
    '        If fila.RowType = DataControlRowType.DataRow Then
    '            Dim c1 As CheckBox = CType(Me.GridView7.Rows(y).FindControl("CheckBox2"), CheckBox)
    '            Dim cantidad As TextBox = CType(Me.GridView7.Rows(y).FindControl("TextBox30"), TextBox)
    '            Dim precio As TextBox = CType(Me.GridView7.Rows(y).FindControl("TextBox31"), TextBox)
    '            If c1.Checked = True Then
    '                With detallePedido
    '                    .idDetallePedido = 0
    '                    .idEncabezadoPedido = Val(Me.TextBox28.Text)
    '                    .idProducto = Me.GridView7.Rows(y).Cells(1).Text
    '                    .cantidadDetallePedido = Val(cantidad.Text)
    '                    .preciodetallePedido = Val(precio.Text)
    '                    .tipoProducto = "PRE"
    '                    .actualizarDetallepedido(1)
    '                End With
    '            End If
    '        End If
    '    Next
    'End Sub

    'Sub grabarEncabezadoPedidoPremio()
    '    With encabezadoPedido
    '        .idEncabezadoPedido = 0
    '        .idTipoEncabezadoPedido = "PRE"
    '        .fechaEncabezadoPedido = Me.TextBox29.Text
    '        .TipoEnvioPedido = "PRE"
    '        .idSolicitante = Me.DropDownList36.SelectedValue
    '        .idSolicitado = "BPR"
    '        .consecutivoPedido = Val(Me.TextBox28.Text)
    '        .idPais = Me.DropDownList25.SelectedValue
    '        .estadoEncabezadoPedido = Me.DropDownList27.SelectedValue
    '        .proceso = "PAI-BPR"
    '        .actualizarEncabezadoPedido(1)
    '    End With
    'End Sub

    'Protected Sub ImageButton19_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton19.Click
    '    nuevoPedidoPremio()
    'End Sub

    'Protected Sub ImageButton25_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton25.Click
    '    Me.MultiView1.ActiveViewIndex = 0
    '    cargarPedidoProducto()
    'End Sub

    'Sub cargarPedidoProducto()
    '    Dim tabla As New DataTable
    '    With encabezadoPedido
    '        tabla = .obtenerPedidosDePaisesABodegaPrincipal("PRO")
    '        Me.GridView9.DataSource = tabla
    '        Me.GridView9.DataBind()
    '    End With
    'End Sub

    'Protected Sub ImageButton26_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton26.Click
    '    Me.MultiView1.ActiveViewIndex = 1
    '    cargarPedidoPremio()
    'End Sub

    'Sub cargarPedidoPremio()
    '    Dim tabla As New DataTable
    '    With encabezadoPedido
    '        tabla = .obtenerPedidosDeBodegaPrincipalAProveedor("PRE")
    '        Me.GridView10.DataSource = tabla
    '        Me.GridView10.DataBind()
    '    End With
    'End Sub

    'Protected Sub ImageButton22_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton22.Click
    '    nuevoPedidoPapeleria()
    'End Sub

    'Sub nuevoPedidoPapeleria()
    '    Me.DropDownList28.SelectedIndex = 0
    '    Me.TextBox34.Text = ""
    '    Me.TextBox32.Text = ""
    '    '
    '    Me.DropDownList30.SelectedIndex = 0
    '    '
    '    Me.panelErrorPapeleria.Visible = False
    '    obtenerNumeroPedidoPapeleria()
    '    '
    '    Me.GridView11.DataSource = Nothing
    '    Me.GridView11.DataBind()
    'End Sub

    'Sub obtenerNumeroPedidoPapeleria()
    '    Dim tabla As New DataTable
    '    With consecutivoPedido
    '        .descripcion = "Pais-Bodega"
    '        .tipo = "Papeleria"
    '        tabla = .obtenerNumeroConsecutivo
    '        If tabla.Rows.Count = 0 Then
    '            Session("consecutivoPapeleria") = 0
    '        Else
    '            Session("consecutivoPapeleria") = tabla.Rows(0).Item("numero")
    '        End If
    '        Session("consecutivoPapeleria") += 1
    '        Me.TextBox33.Text = Session("consecutivoPapeleria")
    '    End With
    'End Sub

    'Protected Sub DropDownList28_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList28.SelectedIndexChanged
    '    If Me.DropDownList28.SelectedIndex <> 0 Then
    '        mostrarPapeleriaPorPais()
    '        mostrarEmpresaPorPaisPapeleria()
    '    End If
    'End Sub

    'Sub mostrarEmpresaPorPaisPapeleria()
    '    Dim tabla As New DataTable
    '    With empresa
    '        .IdPais = Me.DropDownList28.SelectedValue
    '        tabla = .MostrarEmpresaPorPais
    '        If tabla.Rows.Count <> 0 Then
    '            Me.DropDownList37.DataSource = tabla
    '            Me.DropDownList37.DataTextField = "nombreEmpresa"
    '            Me.DropDownList37.DataValueField = "idEmpresa"
    '            Me.DropDownList37.DataBind()
    '        End If
    '    End With
    'End Sub

    'Sub mostrarPapeleriaPorPais()
    '    Dim tabla As New DataTable
    '    With papeleria
    '        If Me.DropDownList28.SelectedValue <> 0 Then
    '            tabla = .obtenerpapeleriaPorPais(Me.DropDownList28.SelectedValue)
    '            Me.GridView11.DataSource = tabla
    '            Me.GridView11.DataBind()
    '        Else

    '        End If
    '    End With
    'End Sub

    'Protected Sub ImageButton23_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton23.Click
    '    Dim mensajeError As String = Nothing
    '    Dim huboError As String = "no"
    '    Me.panelErrorPapeleria.Visible = False
    '    Me.Label19.Text = ""
    '    '
    '    If Me.DropDownList28.SelectedIndex = 0 Then
    '        huboError = "si"
    '        mensajeError = "- Seleccione el Pais"
    '    End If
    '    '
    '    If Me.DropDownList37.SelectedIndex = 0 Or Me.DropDownList37.SelectedIndex = -1 Then
    '        huboError = "si"
    '        mensajeError = mensajeError & "<br>" & "- Seleccione la empresa"
    '    End If
    '    '
    '    If Me.TextBox34.Text = "" Then
    '        huboError = "si"
    '        mensajeError = mensajeError & "<br>" & "- Ingrese la fecha del pedido"
    '    End If
    '    '
    '    '-----------------------------------------------------
    '    Dim seleccionProducto As String
    '    If Session("accion") = 1 Then
    '        seleccionProducto = validaProductoPapeleria()
    '        If seleccionProducto = "no" Then
    '            huboError = "si"
    '            mensajeError = mensajeError & "<br>" & "- Debe seleccionar por lo menos un item del detalle de la papeleria"
    '        End If
    '    End If
    '    '-----------------------------------------------------

    '    If huboError = "si" Then
    '        Me.panelErrorPapeleria.Visible = True
    '        Me.Label19.Text = mensajeError
    '        Exit Sub
    '    End If
    '    grabarPedidoPapeleria()

    'End Sub

    'Function validaProductoPapeleria() As String
    '    Dim fila As GridViewRow
    '    Dim productoSeleccionado As String = "no"
    '    For y = 0 To Me.GridView11.Rows.Count - 1
    '        fila = Me.GridView11.Rows(y)
    '        If fila.RowType = DataControlRowType.DataRow Then
    '            Dim c1 As CheckBox = CType(Me.GridView11.Rows(y).FindControl("CheckBox3"), CheckBox)
    '            Dim cantidad As TextBox = CType(Me.GridView11.Rows(y).FindControl("TextBox35"), TextBox)
    '            Dim precio As TextBox = CType(Me.GridView11.Rows(y).FindControl("TextBox36"), TextBox)
    '            If c1.Checked = True And (Val(cantidad.Text) > 0 And Val(precio.Text) > 0) Then
    '                productoSeleccionado = "si"
    '                Exit For
    '            Else
    '                productoSeleccionado = "no"
    '            End If
    '        End If
    '    Next
    '    Return productoSeleccionado
    'End Function


    'Sub grabarPedidoPapeleria()
    '    grabarEncabezadoPedidoPapeleria()
    '    grabarDetallePedidoPapeleria()
    '    'actualizaBodegaPrincipalPapeleria()
    '    actualizarConsecutivoPedidoPapeleria()
    '    '
    '    mostrarPapeleriaPorPais()
    '    nuevoPedidoPapeleria()
    '    '
    'End Sub

    'Sub grabarEncabezadoPedidoPapeleria()
    '    With encabezadoPedido
    '        .idEncabezadoPedido = 0
    '        .idTipoEncabezadoPedido = "PAP"
    '        .fechaEncabezadoPedido = Me.TextBox34.Text
    '        .TipoEnvioPedido = "PAP"
    '        .idSolicitante = Me.DropDownList37.SelectedValue
    '        .idSolicitado = "BPR"
    '        .consecutivoPedido = Val(Me.TextBox33.Text)
    '        .idPais = Me.DropDownList28.SelectedValue
    '        .estadoEncabezadoPedido = Me.DropDownList30.SelectedValue
    '        .proceso = "PAI-BPR"
    '        .actualizarEncabezadoPedido(1)
    '    End With
    'End Sub

    'Sub grabarDetallePedidoPapeleria()
    '    Dim y As Integer
    '    Dim fila As GridViewRow
    '    For y = 0 To Me.GridView11.Rows.Count - 1
    '        fila = Me.GridView11.Rows(y)
    '        If fila.RowType = DataControlRowType.DataRow Then
    '            Dim c1 As CheckBox = CType(Me.GridView11.Rows(y).FindControl("CheckBox3"), CheckBox)
    '            Dim cantidad As TextBox = CType(Me.GridView11.Rows(y).FindControl("TextBox35"), TextBox)
    '            Dim precio As TextBox = CType(Me.GridView11.Rows(y).FindControl("TextBox36"), TextBox)
    '            If c1.Checked = True Then
    '                With detallePedido
    '                    .idDetallePedido = 0
    '                    .idEncabezadoPedido = Val(Me.TextBox33.Text)
    '                    .idProducto = Me.GridView11.Rows(y).Cells(1).Text
    '                    .cantidadDetallePedido = Val(cantidad.Text)
    '                    .preciodetallePedido = Val(precio.Text)
    '                    .tipoProducto = "PAP"
    '                    .actualizarDetallepedido(1)
    '                End With
    '            End If
    '        End If
    '    Next
    'End Sub

    ''Sub actualizaBodegaPrincipalPapeleria()
    ''    Dim fila As GridViewRow
    ''    Dim productoSeleccionado As String = "no"
    ''    For y = 0 To Me.GridView11.Rows.Count - 1
    ''        fila = Me.GridView11.Rows(y)
    ''        If fila.RowType = DataControlRowType.DataRow Then
    ''            Dim c1 As CheckBox = CType(Me.GridView11.Rows(y).FindControl("CheckBox3"), CheckBox)
    ''            Dim cantidad As TextBox = CType(Me.GridView11.Rows(y).FindControl("TextBox35"), TextBox)
    ''            Dim precio As TextBox = CType(Me.GridView11.Rows(y).FindControl("TextBox36"), TextBox)
    ''            With bodegaPrincipal
    ''                If c1.Checked = True And Val(cantidad.Text) > 0 Then
    ''                    .idExistenciaBodega = 0
    ''                    .idProducto = Me.GridView11.Rows(y).Cells(1).Text
    ''                    .cantidad = Val(cantidad.Text)
    ''                    .tipoProducto = "PAP"
    ''                    .actualizarExistenciaBodegaPrincipal(1)
    ''                End If
    ''            End With
    ''        End If
    ''    Next
    ''End Sub


    'Sub actualizarConsecutivoPedidoPapeleria()
    '    With consecutivoPedido
    '        .descripcion = "Pais-Bodega"
    '        .tipo = "Papeleria"
    '        .actualizaConsecutivo(Session("consecutivoPapeleria"))
    '    End With
    'End Sub

    'Protected Sub ImageButton27_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton27.Click
    '    Me.MultiView1.ActiveViewIndex = 2
    '    cargarPedidoPapeleria()
    'End Sub

    'Sub cargarPedidoPapeleria()
    '    Dim tabla As New DataTable
    '    With encabezadoPedido
    '        tabla = .obtenerPedidosDeBodegaPrincipalAProveedor("PAP")
    '        Me.GridView12.DataSource = tabla
    '        Me.GridView12.DataBind()
    '    End With
    'End Sub

    'Protected Sub GridView9_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView9.SelectedIndexChanging
    '    Me.TextBox1.Text = Me.GridView9.Rows(e.NewSelectedIndex).Cells(1).Text
    '    mostrarInformacion()
    '    mostrarDetallePedidoProducto()
    '    Session("accion") = 2
    'End Sub

    'Sub mostrarDetallePedidoProducto()
    '    Dim fila As GridViewRow
    '    Dim y, k As Integer
    '    Dim tabla As New DataTable
    '    With detallePedido
    '        .idEncabezadoPedido = Me.TextBox1.Text
    '        tabla = .obtenerDetallePedidoPorId
    '        If tabla.Rows.Count <> 0 Then
    '            For k = 0 To tabla.Rows.Count - 1
    '                Dim idProducto As Integer = tabla.Rows(k).Item("idProducto")
    '                Dim cantidad As Integer = tabla.Rows(k).Item("cantidadDetallePedido")
    '                Dim precio As Integer = tabla.Rows(k).Item("precioDetallePedido")
    '                For y = 0 To Me.GridView5.Rows.Count - 1
    '                    fila = Me.GridView5.Rows(y)
    '                    If fila.RowType = DataControlRowType.DataRow Then
    '                        Dim c1 As CheckBox = CType(Me.GridView5.Rows(y).FindControl("CheckBox1"), CheckBox)
    '                        Dim c As TextBox = CType(Me.GridView5.Rows(y).FindControl("Textbox7"), TextBox)
    '                        Dim p As TextBox = CType(Me.GridView5.Rows(y).FindControl("Textbox26"), TextBox)
    '                        If idProducto = Me.GridView5.Rows(y).Cells(1).Text Then
    '                            c1.Checked = True
    '                            c.Text = cantidad
    '                            p.Text = precio
    '                            Exit For
    '                        End If
    '                    End If
    '                Next
    '            Next
    '        End If
    '    End With
    'End Sub

    'Protected Sub GridView10_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView10.SelectedIndexChanging
    '    Me.TextBox27.Text = Me.GridView10.Rows(e.NewSelectedIndex).Cells(1).Text
    '    mostrarInformacionPremio()
    '    mostrarDetallePedidoPremio()
    '    Session("accionPremio") = 2
    'End Sub

    'Sub mostrarInformacionPremio()
    '    Dim tabla As New DataTable
    '    With encabezadoPedido
    '        .idEncabezadoPedido = Val(Me.TextBox27.Text)
    '        tabla = .obtenerPedidoPorId
    '        If tabla.Rows.Count <> 0 Then
    '            Me.DropDownList25.SelectedValue = tabla.Rows(0).Item("idPais")
    '            mostrarPremioPorPais()
    '            '
    '            Me.TextBox28.Text = tabla.Rows(0).Item("consecutivoPedido")
    '            Me.TextBox29.Text = tabla.Rows(0).Item("fechaEncabezadoPedido")
    '            '
    '        End If
    '    End With
    'End Sub

    'Sub mostrarDetallePedidoPremio()
    '    Dim fila As GridViewRow
    '    Dim y, k As Integer
    '    Dim tabla As New DataTable
    '    With detallePedido
    '        .idEncabezadoPedido = Me.TextBox27.Text
    '        tabla = .obtenerDetallePedidoPorId
    '        If tabla.Rows.Count <> 0 Then
    '            For k = 0 To tabla.Rows.Count - 1
    '                Dim idProducto As Integer = tabla.Rows(k).Item("idProducto")
    '                Dim cantidad As Integer = tabla.Rows(k).Item("cantidadDetallePedido")
    '                Dim precio As Integer = tabla.Rows(k).Item("precioDetallePedido")
    '                For y = 0 To Me.GridView7.Rows.Count - 1
    '                    fila = Me.GridView7.Rows(y)
    '                    If fila.RowType = DataControlRowType.DataRow Then
    '                        Dim c1 As CheckBox = CType(Me.GridView7.Rows(y).FindControl("CheckBox2"), CheckBox)
    '                        Dim c As TextBox = CType(Me.GridView7.Rows(y).FindControl("Textbox30"), TextBox)
    '                        Dim p As TextBox = CType(Me.GridView7.Rows(y).FindControl("Textbox31"), TextBox)
    '                        If idProducto = Me.GridView7.Rows(y).Cells(1).Text Then
    '                            c1.Checked = True
    '                            c.Text = cantidad
    '                            p.Text = precio
    '                            Exit For
    '                        End If
    '                    End If
    '                Next
    '            Next
    '        End If
    '    End With
    'End Sub


    'Protected Sub GridView12_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView12.SelectedIndexChanging
    '    Me.TextBox32.Text = Me.GridView12.Rows(e.NewSelectedIndex).Cells(1).Text
    '    mostrarInformacionPapeleria()
    '    mostrarDetallePedidoPapeleria()
    '    Session("accionPapeleria") = 2
    'End Sub

    'Sub mostrarInformacionPapeleria()
    '    Dim tabla As New DataTable
    '    With encabezadoPedido
    '        .idEncabezadoPedido = Val(Me.TextBox32.Text)
    '        tabla = .obtenerPedidoPorId
    '        If tabla.Rows.Count <> 0 Then
    '            Me.DropDownList28.SelectedValue = tabla.Rows(0).Item("idPais")
    '            mostrarPapeleriaPorPais()
    '            '
    '            Me.TextBox33.Text = tabla.Rows(0).Item("consecutivoPedido")
    '            Me.TextBox34.Text = tabla.Rows(0).Item("fechaEncabezadoPedido")
    '            '
    '        End If
    '    End With
    'End Sub

    'Sub mostrarDetallePedidoPapeleria()
    '    Dim fila As GridViewRow
    '    Dim y, k As Integer
    '    Dim tabla As New DataTable
    '    With detallePedido
    '        .idEncabezadoPedido = Me.TextBox32.Text
    '        tabla = .obtenerDetallePedidoPorId
    '        If tabla.Rows.Count <> 0 Then
    '            For k = 0 To tabla.Rows.Count - 1
    '                Dim idProducto As Integer = tabla.Rows(k).Item("idProducto")
    '                Dim cantidad As Integer = tabla.Rows(k).Item("cantidadDetallePedido")
    '                Dim precio As Integer = tabla.Rows(k).Item("precioDetallePedido")
    '                For y = 0 To Me.GridView11.Rows.Count - 1
    '                    fila = Me.GridView11.Rows(y)
    '                    If fila.RowType = DataControlRowType.DataRow Then
    '                        Dim c1 As CheckBox = CType(Me.GridView11.Rows(y).FindControl("CheckBox3"), CheckBox)
    '                        Dim c As TextBox = CType(Me.GridView11.Rows(y).FindControl("Textbox35"), TextBox)
    '                        Dim p As TextBox = CType(Me.GridView11.Rows(y).FindControl("Textbox36"), TextBox)
    '                        If idProducto = Me.GridView11.Rows(y).Cells(1).Text Then
    '                            c1.Checked = True
    '                            c.Text = cantidad
    '                            p.Text = precio
    '                            Exit For
    '                        End If
    '                    End If
    '                Next
    '            Next
    '        End If
    '    End With
    'End Sub

    'Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    If Me.TextBox37.Text <> "" Then
    '        consultarPedidoProductoPorNumero()
    '    End If
    'End Sub

    'Sub consultarPedidoProductoPorNumero()
    '    Dim tabla As New DataTable
    '    With encabezadoPedido
    '        .consecutivoPedido = Val(Me.TextBox37.Text)
    '        tabla = .obtenerPedidosProductoPorNumero("PRO")
    '        Me.GridView9.DataSource = tabla
    '        Me.GridView9.DataBind()
    '    End With
    'End Sub

    'Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
    '    cargarPedidoProducto()
    'End Sub

    'Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    If Me.DropDownList31.SelectedIndex <> 0 Then
    '        consultaPedidoProductoPorPais()
    '    End If
    'End Sub

    'Sub consultaPedidoProductoPorPais()
    '    Dim tabla As New DataTable
    '    With encabezadoPedido
    '        .idPais = Me.DropDownList31.SelectedValue
    '        tabla = .obtenerPedidosProductoPorPais("PRO")
    '        Me.GridView9.DataSource = tabla
    '        Me.GridView9.DataBind()
    '    End With
    'End Sub

    'Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
    '    If Me.TextBox38.Text <> "" And Me.TextBox39.Text <> "" Then
    '        consultaPedidoProductoPorFecha()
    '    End If
    'End Sub

    'Sub consultaPedidoProductoPorFecha()
    '    Dim tabla As New DataTable
    '    With encabezadoPedido
    '        tabla = .obtenerPedidosProductoPorFecha("PRO", Me.TextBox38.Text, Me.TextBox39.Text)
    '        Me.GridView9.DataSource = tabla
    '        Me.GridView9.DataBind()
    '    End With
    'End Sub

    'Protected Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
    '    cargarPedidoPremio()
    'End Sub

    'Protected Sub Button7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.Click
    '    If Me.TextBox40.Text <> "" Then
    '        consultarPedidoPremioPorNumero()
    '    End If
    'End Sub

    'Sub consultarPedidoPremioPorNumero()
    '    Dim tabla As New DataTable
    '    With encabezadoPedido
    '        .consecutivoPedido = Val(Me.TextBox40.Text)
    '        tabla = .obtenerPedidosPremioPorNumero("PRE")
    '        Me.GridView10.DataSource = tabla
    '        Me.GridView10.DataBind()
    '    End With
    'End Sub

    'Protected Sub Button8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.Click
    '    If Me.TextBox41.Text <> "" And Me.TextBox42.Text <> "" Then
    '        consultaPedidoPremioPorFecha()
    '    End If
    'End Sub

    'Sub consultaPedidoPremioPorFecha()
    '    Dim tabla As New DataTable
    '    With encabezadoPedido
    '        tabla = .obtenerPedidosPremioPorFecha("PRE", Me.TextBox41.Text, Me.TextBox42.Text)
    '        Me.GridView10.DataSource = tabla
    '        Me.GridView10.DataBind()
    '    End With
    'End Sub

    'Protected Sub Button11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button11.Click
    '    If Me.TextBox43.Text <> "" Then
    '        consultarPedidoPapeleriaPorNumero()
    '    End If
    'End Sub

    'Sub consultarPedidoPapeleriaPorNumero()
    '    Dim tabla As New DataTable
    '    With encabezadoPedido
    '        .consecutivoPedido = Val(Me.TextBox43.Text)
    '        tabla = .obtenerPedidosPapeleriaPorNumero("PAP")
    '        Me.GridView12.DataSource = tabla
    '        Me.GridView12.DataBind()
    '    End With
    'End Sub

    'Protected Sub Button9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button9.Click
    '    cargarPedidoPapeleria()
    'End Sub

    'Protected Sub Button12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button12.Click
    '    If Me.TextBox44.Text <> "" And Me.TextBox45.Text <> "" Then
    '        consultaPedidoPapeleriaPorFecha()
    '    End If
    'End Sub

    'Sub consultaPedidoPapeleriaPorFecha()
    '    Dim tabla As New DataTable
    '    With encabezadoPedido
    '        tabla = .obtenerPedidosPapeleriaPorFecha("PAP", Me.TextBox44.Text, Me.TextBox45.Text)
    '        Me.GridView12.DataSource = tabla
    '        Me.GridView12.DataBind()
    '    End With
    'End Sub

    'Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    If IsPostBack = False Then
    '        cargarPaise()
    '        Nuevo()
    '        nuevoPedidoPremio()
    '        nuevoPedidoPapeleria()
    '        Me.TabContainer1.ActiveTabIndex = 0
    '        Session("accion") = 1
    '        Me.panelError.Visible = False
    '    End If

    'End Sub
End Class
