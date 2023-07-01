Imports System.Data

Partial Class Bodega_Principal_wfDespachos
    Inherits System.Web.UI.Page

    Dim encabezadoPedido As New clsEncabezadoPedido
    Dim detallePedido As New clsDetallePedido
    Dim encabezadoDespacho As New clsTTEncDesProductoPais
    Dim productos As New clsProducto
    Dim tablaTemporal As New clsTablaTemporal
    Dim detDesProductoPais As New clsTTDetDesproductoPais
    Dim TT As New DataTable
    Dim bodegaPrincipal As New clsBodegaPrincipal
    Dim TTCajaDesProductoPais As New clsTTCajaDesProductoPais
    Dim pedidos As New clsTTEncPedProductoBod
    Dim itemDetalledespacho As New clsItemDetalle

    Protected Sub ImageButton9_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
        Me.Label2.Text = ""
        If Me.TextBox1.Text <> "" Then
            mostrarEncabezadoPedido(Me.TextBox1.Text)
            If Me.TextBox1.Text <> "" Then
                'mostrarDetallePedido(Me.TextBox1.Text)
                'actualizaGrillaPedido()
                'actualizaCantidades()
                llenarItemDetalleDespacho()
                If Me.GridView2.Rows.Count <> 0 Then
                    calcularTotales()
                Else
                    Me.TextBox12.Text = 0
                    Me.TextBox13.Text = 0
                End If
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End If
    End Sub

    Sub actualizaCantidades()
        Dim j As Integer
        ' actualiza nuevamente las cantidades
        For j = 0 To Me.GridView2.Rows.Count - 1
            Me.GridView2.Rows(j).Cells(6).Text = (Val(Me.GridView2.Rows(j).Cells(2).Text) - Val(Me.GridView2.Rows(j).Cells(5).Text))
        Next
    End Sub

    'Sub llenarComboProductoIngresoDespacho()
    '    Dim y As Integer
    '    For y = 0 To Me.GridView2.Rows.Count - 1
    '        If Me.GridView2.Rows(y).Cells(6).Text <> 0 Then

    '        End If
    '    Next
    'End Sub

    Sub actualizaGrillaPedido()
        Dim y As Integer
        Dim k As Integer
        Dim tabla As New DataTable
        Dim idProductoTabla As Integer
        Dim idProductoGrilla As Integer
        With detDesProductoPais
            .idEncDesProductoPais = Me.TextBox1.Text
            tabla = .obtenerDetalleDespachoPorIdPedido
            If tabla.Rows.Count <> 0 Then
                For y = 0 To tabla.Rows.Count - 1
                    idProductoTabla = tabla.Rows(y).Item("idProducto")
                    For k = 0 To Me.GridView2.Rows.Count - 1
                        idProductoGrilla = Me.GridView2.Rows(y).Cells(0).Text
                        If idProductoTabla = idProductoGrilla Then
                            Me.GridView2.Rows(y).Cells(5).Text = tabla.Rows(y).Item("cantdetDesProductoPais")
                            Me.GridView2.Rows(y).Cells(6).Text = (Me.GridView2.Rows(y).Cells(2).Text - Me.GridView2.Rows(y).Cells(5).Text)
                        End If
                    Next
                Next
            End If
        End With
    End Sub

    Sub mostrarEncabezadoPedido(ByVal idPedido As Integer)
        Dim tabla As New DataTable
        With encabezadoPedido
            .idEncPedProductoBod = idPedido
            tabla = .ObtenerPedidoPorIdPedido
            If tabla.Rows.Count <> 0 Then
                Me.TextBox1.Text = tabla.Rows(0).Item("idEncPedProductoBod")
                Me.TextBox6.Text = tabla.Rows(0).Item("fechaEncPedProductoBod")
                Me.TextBox3.Text = tabla.Rows(0).Item("idEmpresa")
            Else
                Me.TextBox1.Text = ""
                Me.TextBox6.Text = ""
                Me.TextBox3.Text = ""
                Me.Label2.Text = "Pedido no existe en el sistema...! o está confirmado"
            End If
        End With
    End Sub

    Sub calcularTotales()
        '-------------------------------------
        ' suma cantidad
        Dim sumaCantidad As Double = 0
        Dim sumanSubtotal As Double = 0
        Dim y As Integer
        For y = 0 To Me.GridView2.Rows.Count - 1
            sumaCantidad += Me.GridView2.Rows(y).Cells(2).Text
            sumanSubtotal += Me.GridView2.Rows(y).Cells(4).Text
        Next
        Me.TextBox12.Text = FormatNumber(sumaCantidad, 0)
        Me.TextBox13.Text = FormatNumber(sumanSubtotal, 0)
    End Sub

    Sub mostrarDetallePedido(ByVal idPedido As Integer)
        Dim tabla As New DataTable
        With detallePedido
            .idEncPedProductoBod = idPedido
            tabla = .obtenerDetallePedidoPorIdPedido()
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
                '
                Me.DropDownList3.DataSource = tabla
                Me.DropDownList3.DataTextField = "nombreProducto"
                Me.DropDownList3.DataValueField = "idProducto"
                Me.DropDownList3.DataBind()
                '
                Me.DropDownList3.Items.Insert(0, "Seleccione El Producto")
                '--------------------------------------------------------------
                muestraExistenciasEnBodega()
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
                '
            End If
        End With
    End Sub

    Sub muestraExistenciasEnBodega()
        Dim tabla As New DataTable
        Dim y As Integer
        For y = 0 To Me.GridView2.Rows.Count - 1
            With bodegaPrincipal
                .idproducto = Me.GridView2.Rows(y).Cells(0).Text
                tabla = .obtieneExistenciaEnBodegaPorIdProducto()
                If tabla.Rows.Count <> 0 Then
                    Me.GridView2.Rows(y).Cells(7).Text = tabla.Rows(0).Item("cantBodPrincipal")
                Else
                    Me.GridView2.Rows(y).Cells(7).Text = 0
                End If
            End With
        Next
    End Sub

    Sub grabarEncabezadodespacho()
        Dim valor As Double = 0
        Dim y As Integer
        '--------------------------------------------------------------------------
        ' calcula el valor
        Dim itemCorrecto As String = "no"
        Dim tabla As New DataTable
        For y = 0 To Me.GridView6.Rows.Count - 1
            If Val(Me.GridView6.Rows(y).Cells(7).Text) <> 0 Then
                valor += Val(Me.GridView6.Rows(y).Cells(7).Text)
            End If
        Next
        '--------------------------------------------------------------------------
        '
        With encabezadoDespacho
            .idEncDesProductoPais = 0
            .fechaEncDesProductoPais = Me.TextBox14.Text
            .idEncPedProductoBod = Me.TextBox1.Text
            .IdEmpresa = Me.TextBox3.Text
            .valorEncDesProductoPais = valor
            .guiaEncDesProductoPais = Me.TextBox15.Text
            .dirEnvioEncDesProductoPais = Me.TextBox19.Text
            .observEncDesProductoPais = ""
            .procesadoEncDesProductoPais = "Si"
            .confirEncDesProductoPais = "no"
            .estadoEncDesProductoPais = 1
            .grabarEncabezadoDespachoPais()
        End With
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            'crearTabla()
            Me.ImageButton12.Visible = False
            Me.panelError.Visible = False
            Session("itemAgregado") = 0
            Me.TextBox1.Focus()
            '
            Me.Label17.Visible = False
            Me.Label18.Visible = False
            Me.Label19.Visible = False
            '
            Me.MultiView2.ActiveViewIndex = 1
            mostrarPedidos()
            Me.ImageButton15.Visible = False
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub vaciarProductoRejilla()
        Dim tabAgre As New DataTable
        tabAgre.Clear()
        Session("tabSes") = tabAgre
    End Sub

    Sub mostrarGrilla()
        Dim tablaRes As New DataTable
        tablaRes = CType(Session("tabSes"), DataTable)
        Me.GridView6.DataSource = tablaRes
        Me.GridView6.DataBind()
    End Sub

    Protected Sub ImageButton12_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton12.Click
        grabarEncabezadodespacho()
        grabarTTdesDesProductoPais()
        grabarTTCajaDesProductoPais()
        actualizaExistenciasBodegaPrincipal()
        '
        actualizarDetallePedido()
        actualizaConfirmacionEncabezadoPedido()
        '
        limpiarAreaDespacho()
        limpiarAreaPedido()
        mostrarVentana()
        Me.ImageButton12.Visible = False
        '
        Me.GridView5.DataSource = Nothing
        Me.GridView5.DataBind()
        '
        Session("itemAgregado") = 0
    End Sub

    Sub actualizaConfirmacionEncabezadoPedido()
        Dim tipo As String
        Dim despachoCompleto As String = "no"
        Dim y As Integer
        Dim tabla As New DataTable
        With detallePedido
            .idEncPedProductoBod = Me.TextBox1.Text
            tabla = .obtenerDetallePedidoActualizaConfirmacion
            If tabla.Rows.Count <> 0 Then
                For y = 0 To tabla.Rows.Count - 1
                    If tabla.Rows(y).Item("cantDetPedProductoBod") = tabla.Rows(y).Item("cantEntregaDetPedProductoBod") Then
                        despachoCompleto = "si"
                    Else
                        despachoCompleto = "no"
                        Exit For
                    End If
                Next
            End If
        End With
        '
        If despachoCompleto = "no" Then
            tipo = "Pr"
        Else
            tipo = "Si"
        End If
        With pedidos
            .idEncPedProductoBod = Val(Me.TextBox1.Text)
            .actualizaTTEncPedProductoBodconfirEncPedProductoBod(tipo)
        End With
    End Sub

    Sub actualizarDetallePedido()
        Dim y As Integer
        For y = 0 To Me.GridView6.Rows.Count - 1
            If Val(Me.GridView6.Rows(y).Cells(5).Text) <> 0 Then
                With detallePedido
                    .idEncPedProductoBod = Val(Me.TextBox1.Text)
                    .idProducto = Me.GridView6.Rows(y).Cells(1).Text
                    .cantEntregaDetPedProductoBod = Val(Me.GridView6.Rows(y).Cells(5).Text)
                    .actualizaTTDetPedProductoBodcantEntregaDetPedProductoBod()
                End With
            End If
        Next
    End Sub

    Sub mostrarVentana()
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('Despacho Registrado En El Sistema...!');", True)
    End Sub

    Sub limpiarAreaPedido()
        Me.TextBox1.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox4.Text = ""
        Me.TextBox6.Text = ""
        Me.TextBox12.Text = ""
        Me.TextBox13.Text = ""
        '
        Me.GridView2.DataSource = Nothing
        Me.GridView2.DataBind()
    End Sub

    Sub limpiarAreaDespacho()
        Me.TextBox14.Text = ""
        Me.TextBox15.Text = ""
        Me.panelError.Visible = False
        Me.GridView6.DataSource = Nothing
        Me.GridView6.DataBind()
        '
    End Sub

    Sub grabarTTCajaDesProductoPais()
        Dim y As Integer
        Dim k As Integer
        Dim tabla As New DataTable
        For y = 0 To Me.GridView6.Rows.Count - 1
            If Val(Me.GridView6.Rows(y).Cells(7).Text) <> 0 Then
                For k = 1 To Val(Me.GridView6.Rows(y).Cells(3).Text)
                    With TTCajaDesProductoPais
                        .idCajaDesProductoPais = 0
                        .conseCajaDesProductoPais = k
                        .idEncDesProductoPais = Me.TextBox1.Text
                        .idProducto = Me.GridView6.Rows(y).Cells(1).Text
                        .cantCajaDesProductoPais = Val(Me.GridView6.Rows(y).Cells(4).Text)
                        .cantRecCajaDesProductoPais = 0
                        .cantFalCajaDesProductoPais = 0
                        .cantMalCajaDesProductoPais = 0
                        .altaCajaDesProductoPais = "No"
                        .fecrCajaDesProductoPais = Me.TextBox14.Text
                        .grabarTTCajaDesProductoPais()
                    End With
                Next
            End If
        Next
    End Sub

    Function validaCantidades() As String
        Dim correcto As String = "si"
        Dim cantidadPedido As Integer
        Dim idProductoPedido As Integer
        '
        Dim cantidadDespacho As Integer
        Dim idProductoDespacho As Integer
        '
        Dim y As Integer
        Dim k As Integer
        For y = 0 To Me.GridView2.Rows.Count - 1
            cantidadPedido = Me.GridView2.Rows(y).Cells(6).Text
            idProductoPedido = Me.GridView2.Rows(y).Cells(0).Text
            Dim sumaCantidadDespacho As Double = 0
            For k = 0 To Me.GridView6.Rows.Count - 1
                cantidadDespacho = Me.GridView6.Rows(k).Cells(6).Text
                idProductoDespacho = Me.GridView6.Rows(k).Cells(0).Text
                If idProductoPedido = idProductoDespacho Then
                    sumaCantidadDespacho += cantidadDespacho
                End If
            Next
            If sumaCantidadDespacho > cantidadPedido Then
                correcto = "no"
                Exit For
            Else
                correcto = "si"
            End If
        Next
        Return correcto
    End Function

    Sub actualizaExistenciasBodegaPrincipal()
        Dim tabla As New DataTable
        For y = 0 To Me.GridView6.Rows.Count - 1
            If Val(Me.GridView6.Rows(y).Cells(5).Text) <> 0 Then
                With bodegaPrincipal
                    .idproducto = Me.GridView6.Rows(y).Cells(1).Text
                    .cantBodPrincipal = Val(Me.GridView6.Rows(y).Cells(5).Text)
                    .actualizaExistencias()
                End With
            End If
        Next
    End Sub

    Sub grabarTTdesDesProductoPais()
        Dim tabla As New DataTable
        Dim y As Integer
        For y = 0 To Me.GridView6.Rows.Count - 1
            If Val(Me.GridView6.Rows(y).Cells(7).Text) <> 0 Then
                With detDesProductoPais
                    .idDetDesProductoPais = 0
                    .idEncDesProductoPais = Me.TextBox1.Text
                    .idProducto = Me.GridView6.Rows(y).Cells(1).Text
                    .cantdetDesProductoPais = Val(Me.GridView6.Rows(y).Cells(5).Text)
                    .valorDetDesProductoPais = Val(Me.GridView6.Rows(y).Cells(6).Text)
                    .subtotalDetDesProductoPais = Val(Me.GridView6.Rows(y).Cells(7).Text)
                    .ncajasDetDesProductoPais = Val(Me.GridView6.Rows(y).Cells(3).Text)
                    .grabarTTDetDesproductoPais()
                End With
            End If
        Next
    End Sub

    Sub mostrarPedidos()
        Dim tabla As New DataTable
        Dim tipoProceso As String = ""
        With pedidos
            tabla = .obtenerPedidosParaDespachar(tipoProceso)
            If tabla.Rows.Count <> 0 Then
                Me.GridView5.DataSource = tabla
                Me.GridView5.DataBind()
                '
                'Me.Label16.Text = "(" & Me.GridView5.Rows.Count & ")" & " pedidos pendientes por despachar...!"
            Else
                Me.GridView5.DataSource = Nothing
                Me.GridView5.DataBind()
                '
                'Me.Label16.Text = "No existen pedidos pendientes por despachar...!"
            End If
        End With
    End Sub


    Protected Sub GridView5_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView5.SelectedIndexChanging
        limpiarAreaDespacho()
        limpiarAreaPedido()
        Session("itemAgregado") = 0
        '
        Me.TextBox1.Text = Me.GridView5.Rows(e.NewSelectedIndex).Cells(1).Text
        Me.TextBox1.Text = Me.GridView5.Rows(e.NewSelectedIndex).Cells(1).Text
        Me.TextBox4.Text = Me.GridView5.Rows(e.NewSelectedIndex).Cells(4).Text
        Me.Label2.Text = ""
        If Me.TextBox1.Text <> "" Then
            mostrarEncabezadoPedido(Me.TextBox1.Text)
            If Me.TextBox1.Text <> "" Then
                llenarItemDetalleDespacho()
                mostrarDetallePedido(Me.TextBox1.Text)
                If Me.GridView2.Rows.Count <> 0 Then
                    calcularTotales()
                Else
                    Me.TextBox12.Text = 0
                    Me.TextBox13.Text = 0
                End If
                Me.TextBox14.Text = Now.Date.ToString("yyyy/MM/dd")
                '
                Session("accion") = "nuevo"
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End If
        Me.MultiView2.ActiveViewIndex = 0
    End Sub

    Sub llenarItemDetalleDespacho()
        Dim tabla As New DataTable
        With itemDetalledespacho
            tabla = .obtenerItems
            If tabla.Rows.Count <> 0 Then
                Me.GridView6.DataSource = tabla
                Me.GridView6.DataBind()
            Else
                Me.GridView6.DataSource = Nothing
                Me.GridView6.DataBind()
            End If
        End With
    End Sub

    Protected Sub ImageButton13_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton13.Click
        Dim mensajeError As String = Nothing
        Dim huboError As String = "no"
        Me.panelError.Visible = False
        Me.ImageButton12.Visible = False
        '
        Me.Label15.Text = ""
        '
        'calculaValores()
        '
        If Me.TextBox14.Text = "" Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "- Seleccione la fecha del despacho"
        End If
        '
        If Me.TextBox15.Text = "" Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "- Ingrese el numero de guia"
        Else
            ' valida el numero de guia
            Dim tabla As New DataTable
            With encabezadoDespacho
                .guiaEncDesProductoPais = Me.TextBox15.Text
                tabla = .validaNumeroGuia
                If tabla.Rows.Count <> 0 Then
                    huboError = "si"
                    mensajeError = mensajeError & "<br>" & "- El número de guia ya está registrado en el sistema...!"
                End If
            End With
        End If
        '-----------------------------------------------------------------------------------
        Dim y As Integer
        Dim hayRegistro As String = "no"
        For y = 0 To Me.GridView6.Rows.Count - 1
            If Val(Me.GridView6.Rows(y).Cells(5).Text) <> 0 Then
                'If IsNothing(Me.GridView6.Rows(y).Cells(1).Text).ToString Then
                hayRegistro = "si"
                Exit For
            Else
                hayRegistro = "no"
            End If
        Next
        If hayRegistro = "no" Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "- Debe ingresar el detalle del despacho"
        Else
            '---------------------------------------------------------------------------------
            ' valida las cantidades a despachar
            Dim hayErroresEnCantidades As String = "no"
            Dim k As Integer
            For y = 0 To Me.GridView2.Rows.Count - 1
                Dim codigo1 As String
                Dim cantidadadespachar As Double
                Dim sumacantidad As Double = 0
                codigo1 = Me.GridView2.Rows(y).Cells(0).Text
                cantidadadespachar = Val(Me.GridView2.Rows(y).Cells(6).Text)
                For k = 0 To Me.GridView6.Rows.Count - 1
                    Dim codigo2 As String
                    Dim cantidadDespachada As Double
                    If Val(Me.GridView6.Rows(y).Cells(6).Text) <> 0 Then
                        codigo2 = Me.GridView6.Rows(k).Cells(1).Text
                        cantidadDespachada = Val(Me.GridView6.Rows(k).Cells(5).Text)
                        If codigo1 = codigo2 Then
                            sumacantidad += Val(Me.GridView6.Rows(k).Cells(5).Text)
                        End If
                    End If
                Next
                If sumacantidad > cantidadadespachar Then
                    hayErroresEnCantidades = "si"
                    huboError = "si"
                    mensajeError = mensajeError & "<br>" & "- Existe un error en las cantidades del detalle del despacho"
                    Exit For
                Else
                    hayErroresEnCantidades = "no"
                End If
            Next
            If hayErroresEnCantidades = "no" Then
                ' valida que el total a despachar no sobrepase las esxistentes en bodega
                Dim entradaValida As String
                entradaValida = validaExistenciasEnBodega()
                If entradaValida = "no" Then
                    huboError = "si"
                    mensajeError = mensajeError & "<br>" & "- Las cantidades del despacho no debe superar las existencias en bodega"
                End If
            End If
        End If
        '
        '
        If huboError = "si" Then
            Me.Label15.ForeColor = Drawing.Color.Red
            Me.Label14.Visible = True
            Me.Image2.ImageUrl = "~/Imagenes/Error 2.png"
            Me.panelError.Visible = True
            Me.Label15.Text = mensajeError
            Me.ImageButton12.Visible = False
            Exit Sub
        Else
            Me.Label15.ForeColor = Drawing.Color.Blue
            Me.Label14.Visible = False
            Me.Image2.ImageUrl = "~/Imagenes/Check Mark.png"
            Me.panelError.Visible = True
            Me.Label15.Text = "Despacho configurado Correctamente...!" & "<br>" & "Relice el proceso de grabar el despacho"
            Me.ImageButton12.Visible = True
        End If
    End Sub

    Function validaExistenciasEnBodega() As String
        Dim y As Integer
        Dim k As Integer
        Dim entradavalida As String = "si"
        For y = 0 To Me.GridView2.Rows.Count - 1
            Dim codigo1 As String
            Dim existencias As Double
            Dim sumacantidad As Double = 0
            codigo1 = Me.GridView2.Rows(y).Cells(0).Text
            existencias = Val(Me.GridView2.Rows(y).Cells(7).Text)
            For k = 0 To Me.GridView6.Rows.Count - 1
                Dim codigo2 As String
                Dim cantidadDespachada As Double
                If Val(Me.GridView6.Rows(y).Cells(5).Text) <> 0 Then
                    codigo2 = Me.GridView6.Rows(k).Cells(1).Text
                    cantidadDespachada = Val(Me.GridView6.Rows(k).Cells(5).Text)
                    If codigo1 = codigo2 Then
                        sumacantidad += Val(Me.GridView6.Rows(k).Cells(5).Text)
                    End If
                End If
            Next
            If sumacantidad > existencias Then
                entradavalida = "no"
                Exit For
            Else
                entradavalida = "si"
            End If
        Next
        Return entradavalida
    End Function

    Sub calculaValores()
        Dim tabla As New DataTable
        Dim fila As GridViewRow
        Dim y As Integer
        For y = 0 To Me.GridView6.Rows.Count - 1
            fila = Me.GridView6.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView6.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim producto As DropDownList = CType(Me.GridView6.Rows(y).FindControl("DropDownList2"), DropDownList)
                Dim cajas As TextBox = CType(Me.GridView6.Rows(y).FindControl("TextBox22"), TextBox)
                Dim unidadesxCajas As TextBox = CType(Me.GridView6.Rows(y).FindControl("TextBox23"), TextBox)
                Dim precio As TextBox = CType(Me.GridView6.Rows(y).FindControl("TextBox24"), TextBox)
                Dim totalCantidad As TextBox = CType(Me.GridView6.Rows(y).FindControl("TextBox25"), TextBox)
                Dim subtotal As TextBox = CType(Me.GridView6.Rows(y).FindControl("TextBox26"), TextBox)
                If c1.Checked = True Then
                    If producto.SelectedIndex > 0 And Val(cajas.Text) <> 0 And Val(unidadesxCajas.Text) <> 0 And Val(precio.Text) <> 0 Then
                        totalCantidad.Text = Val(cajas.Text) * Val(unidadesxCajas.Text)
                        subtotal.Text = Val(totalCantidad.Text) * Val(precio.Text)
                    End If
                End If
            End If
        Next
    End Sub

    Protected Sub ImageButton11_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton11.Click
        limpiarAreaDespacho()
        limpiarAreaPedido()
    End Sub

    Sub actulizaPrecio()
        Dim tabla As New DataTable
        Dim y As Integer
        For y = 0 To Me.GridView6.Rows.Count - 1
            If Val(Me.GridView6.Rows(y).Cells(1).Text) <> 0 Then
                With productos
                    .idPais = 57
                    .idProducto = Me.GridView6.Rows(y).Cells(1).Text
                    tabla = .obtenerPreciosPorProductos
                    If tabla.Rows.Count <> 0 Then
                        Me.GridView6.Rows(y).Cells(6).Text = tabla.Rows(0).Item("precioProductoPais")
                    End If
                End With
            End If
        Next
    End Sub

    Protected Sub ImageButton14_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton14.Click
        Dim huboError As String = "no"
        Dim mensajeError As String = ""
        Me.Label17.Visible = False
        Me.Label18.Visible = False
        Me.Label19.Visible = False
        If Me.DropDownList3.SelectedIndex = 0 Then
            huboError = "si"
            Me.Label17.Visible = True
        End If
        '
        If Val(Me.TextBox27.Text) <= 0 Or Not IsNumeric(Me.TextBox27.Text) Or IsNothing(Me.TextBox27.Text) Then
            huboError = "si"
            Me.Label18.Visible = True
        End If
        '
        If Val(Me.TextBox28.Text) <= 0 Or Not IsNumeric(Me.TextBox28.Text) Or IsNothing(Me.TextBox28.Text) Then
            huboError = "si"
            Me.Label19.Visible = True
        End If
        '
        If huboError = "si" Then
            Exit Sub
            Me.TextBox30.Focus()
        End If
        agregarItem()
    End Sub

    Sub agregarItem()
        If Session("accion") = "nuevo" Then
            Me.GridView6.Rows(Session("itemAgregado")).Cells(1).Text = Me.DropDownList3.SelectedValue
            actulizaPrecio()
            Me.GridView6.Rows(Session("itemAgregado")).Cells(2).Text = Me.DropDownList3.SelectedItem.Text
            Me.GridView6.Rows(Session("itemAgregado")).Cells(3).Text = Me.TextBox27.Text
            Me.GridView6.Rows(Session("itemAgregado")).Cells(4).Text = Me.TextBox28.Text
            Me.GridView6.Rows(Session("itemAgregado")).Cells(5).Text = Val(Me.TextBox27.Text) * Val(Me.TextBox28.Text)
            Me.GridView6.Rows(Session("itemAgregado")).Cells(7).Text = Val(Me.GridView6.Rows(Session("itemAgregado")).Cells(5).Text) * Val(Me.GridView6.Rows(Session("itemAgregado")).Cells(6).Text)
            Me.TextBox27.Text = ""
            Me.TextBox28.Text = ""
            calcularCantidad()
            Session("itemAgregado") += 1
        Else
            Me.GridView6.Rows(Session("fila")).Cells(1).Text = Me.DropDownList3.SelectedValue
            actulizaPrecio()
            Me.GridView6.Rows(Session("fila")).Cells(2).Text = Me.DropDownList3.SelectedItem.Text
            Me.GridView6.Rows(Session("fila")).Cells(3).Text = Me.TextBox27.Text
            Me.GridView6.Rows(Session("fila")).Cells(4).Text = Me.TextBox28.Text
            Me.GridView6.Rows(Session("fila")).Cells(5).Text = Val(Me.TextBox27.Text) * Val(Me.TextBox28.Text)
            Me.GridView6.Rows(Session("fila")).Cells(7).Text = Val(Me.GridView6.Rows(Session("fila")).Cells(5).Text) * Val(Me.GridView6.Rows(Session("fila")).Cells(6).Text)
            Me.TextBox27.Text = ""
            Me.TextBox28.Text = ""
            calcularCantidad()
        End If
        Me.Label17.Visible = False
        Me.Label18.Visible = False
        Me.Label19.Visible = False
        Me.TextBox30.Focus()
    End Sub

    Sub calcularCantidad()
        Dim cantidad As Double = 0
        Dim y As Integer
        For y = 0 To Me.GridView6.Rows.Count - 1
            If Val(Me.GridView6.Rows(y).Cells(5).Text) <> 0 Then
                cantidad += Val(Me.GridView6.Rows(y).Cells(5).Text)
            End If
        Next
        Me.TextBox29.Text = cantidad
    End Sub

    Protected Sub GridView6_SelectedIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView6.SelectedIndexChanging
        Me.DropDownList3.SelectedValue = Me.GridView6.Rows(e.NewSelectedIndex).Cells(1).Text
        Me.TextBox27.Text = Me.GridView6.Rows(e.NewSelectedIndex).Cells(3).Text
        Me.TextBox28.Text = Me.GridView6.Rows(e.NewSelectedIndex).Cells(4).Text
        Session("fila") = (Val(Me.GridView6.Rows(e.NewSelectedIndex).Cells(0).Text) - 1)
        Session("accion") = "modificar"
        Me.TextBox30.Focus()
    End Sub

    Protected Sub ImageButton16_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton16.Click
        Session("accion") = "nuevo"
        Me.TextBox27.Text = ""
        Me.TextBox28.Text = ""
        Me.DropDownList3.SelectedIndex = 0
    End Sub

    Protected Sub ImageButton17_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton17.Click
        Me.MultiView2.ActiveViewIndex = 1
        mostrarPedidos()
    End Sub

    
End Class
