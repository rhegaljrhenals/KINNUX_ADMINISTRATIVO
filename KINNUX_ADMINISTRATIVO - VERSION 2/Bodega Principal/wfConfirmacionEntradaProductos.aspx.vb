Imports System.Data

Partial Class Bodega_Principal_wfConfirmacionEntradaProductos
    Inherits System.Web.UI.Page

    Dim objTTEncEntProductoBod As New clsTTEncEntProductoBod
    Dim detalleEntProductoBodega As New clsTTDetEntProductoBod
    Dim detalleEnCajaProductoBod As New clsTTCajaEntProductoBod
    Dim bodegaPrinipal As New clsBodegaPrincipal

    Sub actualizaGrillaConfirmacionEntrada()
        Dim tabla As New DataTable
        Dim fila As GridViewRow
        Dim y As Integer
        For y = 0 To Me.GridView2.Rows.Count - 1
            fila = Me.GridView2.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView2.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim recibidas As TextBox = CType(Me.GridView2.Rows(y).FindControl("TextBox2"), TextBox)
                Dim faltantes As TextBox = CType(Me.GridView2.Rows(y).FindControl("TextBox3"), TextBox)
                Dim malEstado As TextBox = CType(Me.GridView2.Rows(y).FindControl("TextBox4"), TextBox)
                With detalleEnCajaProductoBod
                    .idCajaEntProductoBod = Me.GridView2.Rows(y).Cells(0).Text
                    tabla = .obtenerdetalleCajaPorIdCaja
                    If tabla.Rows.Count <> 0 Then
                        recibidas.Text = tabla.Rows(0).Item("cantRecCajaEntProductoBod")
                        faltantes.Text = tabla.Rows(0).Item("cantFalCajaEntProductoBod")
                        malEstado.Text = tabla.Rows(0).Item("cantMalCajaEntProductoBod")
                    End If
                End With
            End If
        Next
    End Sub

    Sub mostrarDetalleCajaEntradaProductoBod()
        Dim tabla As New DataTable
        With detalleEnCajaProductoBod
            .idEncEntProductoBod = Me.Label18.Text
            tabla = .obtenerDetalleCajaEntProductoBod
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End With
    End Sub

    Sub mostrarDetalleEntradaProductoBod()
        Dim tabla As New DataTable
        With detalleEntProductoBodega
            .idEncEntProductoBod = Me.Label18.Text
            tabla = .ObtenerDetEntProductoBodPorIdEntrada
            If tabla.Rows.Count <> 0 Then
                Me.GridView1.DataSource = tabla
                Me.GridView1.DataBind()
            Else
                Me.GridView1.DataSource = Nothing
                Me.GridView1.DataBind()
            End If
        End With
    End Sub

    Sub mostrarEncabezado()
        Dim tabla As New datatable
        With objTTEncEntProductoBod
            .idEncEntProductoBod = Me.Label18.Text
            tabla = .obtenerTTEncEntProductoBodPorIdEntrada
            If tabla.Rows.Count <> 0 Then
                Me.Label2.Text = tabla.Rows(0).Item("fechaEncEntProductoBod")
                Me.Label3.Text = tabla.Rows(0).Item("idProveedor")
                Me.Label9.Text = tabla.Rows(0).Item("nombreProveedor")
                Me.Label4.Text = FormatNumber(tabla.Rows(0).Item("valorEncProductoBod"), 0)
                Me.Label5.Text = tabla.Rows(0).Item("guiaEncEntProductoBod")
                Me.Label6.Text = tabla.Rows(0).Item("procesaEncEntProductoBod")
                Me.Label7.Text = tabla.Rows(0).Item("confirEncEntProductoBod")
            Else
                Me.GridView1.DataSource = Nothing
                Me.GridView1.DataBind()
                '
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
                '
                Me.Label2.Text = ""
                Me.Label3.Text = ""
                Me.Label4.Text = ""
                Me.Label5.Text = ""
                Me.Label6.Text = ""
                Me.Label7.Text = ""
                Me.Label9.Text = ""
                '
            End If
        End With
    End Sub

    Protected Sub ImageButton15_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton15.Click
        Dim mensajeError As String = Nothing
        Dim huboError As String = "no"
        Me.panelError.Visible = False
        Me.Label15.Text = ""
        '
        '-----------------------------------------------------------------------------------
        ' valida la seleccion de productos
        Dim siHuboError As String
        siHuboError = validaSeleccionProductos()
        If siHuboError = "si" Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "- Debe Seleccionar por lo menos un producto...!"
        Else
            Dim ingresoDatosCorrectos As String
            'ingresoDatosCorrectos = validaIngresoDatos()
            ingresoDatosCorrectos = confirmaEntrada()
            If ingresoDatosCorrectos = "No" Then
                huboError = "si"
                mensajeError = mensajeError & "<br>" & "- Ingrese los datos correctamente"
            End If
        End If
        '
        '----------------------------------------------------------
        Dim datosCorrectos As String = ""
        datosCorrectos = validaEntrada()
        If datosCorrectos = "No" Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "- Hubo un error en la entrada de los productos"
        End If
        '
        If huboError = "si" Then
            Me.panelError.Visible = True
            Me.Label15.Text = mensajeError
            Exit Sub
        End If
        grabar()
        limpiar()
        mostrarVentana()
    End Sub

    Function validaSeleccionProductos() As String
        Dim hayError As String = "si"
        Dim fila As GridViewRow
        Dim y As Integer
        For y = 0 To Me.GridView2.Rows.Count - 1
            fila = Me.GridView2.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView2.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim recibidas As TextBox = CType(Me.GridView2.Rows(y).FindControl("TextBox2"), TextBox)
                Dim faltantes As TextBox = CType(Me.GridView2.Rows(y).FindControl("TextBox3"), TextBox)
                Dim malEstado As TextBox = CType(Me.GridView2.Rows(y).FindControl("TextBox4"), TextBox)
                If c1.Checked = True Then
                    hayError = "no"
                    Exit For
                Else
                    hayError = "si"
                End If
            End If
        Next
        Return hayError
    End Function

    Function validaIngresoDatos() As String
        Dim datosCorrectos As String = "si"
        Dim fila As GridViewRow
        Dim y As Integer
        For y = 0 To Me.GridView1.Rows.Count - 1
            fila = Me.GridView1.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView2.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim recibidas As TextBox = CType(Me.GridView2.Rows(y).FindControl("TextBox2"), TextBox)
                Dim faltantes As TextBox = CType(Me.GridView2.Rows(y).FindControl("TextBox3"), TextBox)
                Dim malEstado As TextBox = CType(Me.GridView2.Rows(y).FindControl("TextBox4"), TextBox)
                If c1.Checked = True Then
                    If (Val(recibidas.Text) = 0 Or (recibidas.Text Is Nothing)) Or (Val(faltantes.Text) = 0 Or (faltantes.Text Is Nothing)) Or (Val(malEstado.Text) = 0 Or (malEstado.Text Is Nothing)) Then
                        datosCorrectos = "No"
                        Exit For
                    Else
                        datosCorrectos = "Si"
                    End If
                End If
            End If
        Next
        Return datosCorrectos
    End Function

    Function validaEntrada() As String
        Dim datosCorrectos As String = ""
        Dim tabla As New DataTable
        Dim fila As GridViewRow
        For y = 0 To Me.GridView1.Rows.Count - 1
            fila = Me.GridView1.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView2.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim recibidas As TextBox = CType(Me.GridView2.Rows(y).FindControl("TextBox2"), TextBox)
                Dim faltantes As TextBox = CType(Me.GridView2.Rows(y).FindControl("TextBox3"), TextBox)
                Dim malEstado As TextBox = CType(Me.GridView2.Rows(y).FindControl("TextBox4"), TextBox)
                If Val(recibidas.Text) <> 0 And Val(faltantes.Text) <> 0 And Val(malEstado.Text) <> 0 Then
                    If c1.Checked = False Then
                        datosCorrectos = "No"
                        Exit For
                    Else
                        datosCorrectos = "Si"
                    End If
                End If
            End If
        Next
        Return datosCorrectos
    End Function


    Sub mostrarVentana()
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('Entrada Confirmada Satisfactoriamente...!');", True)
    End Sub

    Sub limpiar()
        Me.GridView1.DataSource = Nothing
        Me.GridView1.DataBind()
        '
        Me.GridView2.DataSource = Nothing
        Me.GridView2.DataBind()
        '
        Me.GridView3.DataSource = Nothing
        Me.GridView3.DataBind()
        '
        Me.Label2.Text = ""
        Me.Label3.Text = ""
        Me.Label4.Text = ""
        Me.Label5.Text = ""
        Me.Label6.Text = ""
        Me.Label7.Text = ""
        Me.Label9.Text = ""
        Me.panelError.Visible = False
    End Sub

    Sub grabar()
        grabarEntrada()
        actualizaExistenciaBodPrincipal()
        actualizaProceso()
    End Sub

    Sub actualizaProceso()
        Dim hayQueActualizar As String = "no"
        Dim tabla As New DataTable
        Dim y As Integer
        With detalleEnCajaProductoBod
            .idEncEntProductoBod = Me.Label18.Text
            tabla = .obtenerdetalleCajaPorIdEncabezado
            If tabla.Rows.Count <> 0 Then
                For y = 0 To tabla.Rows.Count - 1
                    If tabla.Rows(y).Item("altaCajaEntProductoBod") = "No" Then
                        hayQueActualizar = "no"
                        Exit For
                    Else
                        hayQueActualizar = "si"
                    End If
                Next
                '
                If hayQueActualizar = "si" Then
                    With objTTEncEntProductoBod
                        .idEncEntProductoBod = Me.Label18.Text
                        .ActualizaProcesoTTEncEntProductoBod(2)
                    End With
                Else
                    With objTTEncEntProductoBod
                        .idEncEntProductoBod = Me.Label18.Text
                        .ActualizaProcesoTTEncEntProductoBod(1)
                    End With
                End If
            End If
        End With
        '
    End Sub

    Sub actualizaExistenciaBodPrincipal()
        Dim fila As GridViewRow
        Dim y As Integer
        For y = 0 To Me.GridView2.Rows.Count - 1
            fila = Me.GridView2.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView2.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim recibidas As TextBox = CType(Me.GridView2.Rows(y).FindControl("TextBox2"), TextBox)
                Dim faltantes As TextBox = CType(Me.GridView2.Rows(y).FindControl("TextBox3"), TextBox)
                Dim malEstado As TextBox = CType(Me.GridView2.Rows(y).FindControl("TextBox4"), TextBox)
                If c1.Checked = True Then
                    With bodegaPrinipal
                        .idproducto = Me.GridView2.Rows(y).Cells(1).Text
                        .cantBodPrincipal = Val(recibidas.Text) + Val(malEstado.Text)
                        .actualizaExistenciaEntradaProductos()
                    End With
                End If
            End If
        Next
    End Sub

    Function confirmaEntrada() As String
        Dim entradaValida As String = "no"
        Dim recibidasMalEstado As Double
        Dim cantidadEntregada As Integer
        Dim totalIngreso As Double
        Dim fila As GridViewRow
        Dim y As Integer
        For y = 0 To Me.GridView2.Rows.Count - 1
            fila = Me.GridView2.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                cantidadEntregada = Me.GridView2.Rows(y).Cells(4).Text
                Dim c1 As CheckBox = CType(Me.GridView2.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim recibidas As TextBox = CType(Me.GridView2.Rows(y).FindControl("TextBox2"), TextBox)
                Dim faltantes As TextBox = CType(Me.GridView2.Rows(y).FindControl("TextBox3"), TextBox)
                Dim malEstado As TextBox = CType(Me.GridView2.Rows(y).FindControl("TextBox4"), TextBox)
                If c1.Checked = True Then
                    recibidasMalEstado = (Val(recibidas.Text) + Val(malEstado.Text))
                    totalIngreso = (recibidasMalEstado - Val(faltantes.Text))
                    If totalIngreso <= cantidadEntregada Then
                        entradaValida = "Si"
                    Else
                        entradaValida = "No"
                        Exit For
                    End If
                End If
            End If
        Next
        Return entradaValida
    End Function

    Sub grabarEntrada()
        Dim fila As GridViewRow
        Dim y As Integer
        For y = 0 To Me.GridView2.Rows.Count - 1
            fila = Me.GridView2.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView2.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim recibidas As TextBox = CType(Me.GridView2.Rows(y).FindControl("TextBox2"), TextBox)
                Dim faltantes As TextBox = CType(Me.GridView2.Rows(y).FindControl("TextBox3"), TextBox)
                Dim malEstado As TextBox = CType(Me.GridView2.Rows(y).FindControl("TextBox4"), TextBox)
                If c1.Checked = True Then
                    With detalleEnCajaProductoBod
                        .idCajaEntProductoBod = Me.GridView2.Rows(y).Cells(0).Text
                        .cantRecCajaEntProductoBod = recibidas.Text
                        .cantFalCajaEntProductoBod = faltantes.Text
                        .cantMalCajaEntProductoBod = malEstado.Text
                        .altaCajaEntProductoBod = "Si"
                        .confirmaEntrada()
                    End With
                End If
            End If
        Next
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            Me.panelError.Visible = False
            nuevo()
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub nuevo()
        Me.Panel6.Visible = False
        Me.MultiView3.ActiveViewIndex = 1
        mostrarEntradasSinConfirmar()
    End Sub

    Sub mostrarEntradasSinConfirmar()
        Dim tabla As New DataTable
        Me.Panel6.Visible = False
        With objTTEncEntProductoBod
            tabla = .obtenerEntradasPorTipoproceso
            If tabla.Rows.Count <> 0 Then
                Me.Panel6.Visible = True
                Me.GridView3.DataSource = tabla
                Me.GridView3.DataBind()
                Me.Label17.Text = Me.GridView3.Rows.Count & " Entradas sin confirmar"
            Else
                Me.GridView3.DataSource = Nothing
                Me.GridView3.DataBind()
                Me.Label17.Text = "No hay Entradas sin confirmar"
            End If
        End With
    End Sub

    Sub mostrarEntradasPorTipo()
        Dim tabla As New DataTable
        Dim tipoProceso As String = ""
        With objTTEncEntProductoBod
            tabla = .obtenerEntradasPorTipoproceso()
            If tabla.Rows.Count <> 0 Then
                Me.GridView3.DataSource = tabla
                Me.GridView3.DataBind()
                '
                Me.Label17.Text = "(" & Me.GridView3.Rows.Count & ") " & "entradas pendientes por confirmar...!"
            Else
                Me.GridView3.DataSource = Nothing
                Me.GridView3.DataBind()
                '
                Me.Label17.Text = "No existen entradas pendientes por confirmar...!"
            End If
        End With
    End Sub

    Protected Sub GridView3_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView3.SelectedIndexChanging
        Me.Label18.Text = Me.GridView3.Rows(e.NewSelectedIndex).Cells(1).Text
        If Me.Label18.Text <> "" Then
            mostrarEncabezado()
            mostrarDetalleEntradaProductoBod()
            mostrarDetalleCajaEntradaProductoBod()
            actualizaGrillaConfirmacionEntrada()
            Me.MultiView3.ActiveViewIndex = 0
        End If
    End Sub

    Protected Sub ImageButton17_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton17.Click
        Me.Panel6.Visible = False
        Me.MultiView3.ActiveViewIndex = 1
        mostrarEntradasSinConfirmar()
    End Sub
End Class
