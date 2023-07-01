Imports System.Data

Partial Class Basicos_wfProducto
    Inherits System.Web.UI.Page

    Dim pais As New clsPaise
    Dim linea As New clsLineaArticulo
    Dim objOperacione As New clsOperacione
    Dim producto As New clsProducto

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            'cargarPais()
            cargarLineas()
            nuevo()
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub cargarPais()
        Dim tabla As New DataTable
        With pais
            tabla = .MostrarPaise
            If tabla.Rows.Count <> 0 Then
                Me.GridView3.DataSource = tabla
                Me.GridView3.DataBind()
            Else
                Me.GridView3.DataSource = Nothing
                Me.GridView3.DataBind()
            End If
        End With
    End Sub

    Sub cargarLineas()
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select idLinea,nombreLinea from TBlinea where estado=1"
        With objOperacione
            tabla = .DevuelveDato(sql)
            Me.DropDownList24.DataSource = tabla
            Me.DropDownList24.DataTextField = "nombreLinea"
            Me.DropDownList24.DataValueField = "idLinea"
            Me.DropDownList24.DataBind()
        End With
        Me.DropDownList24.Items.Insert(0, "Seleccione Linea")
    End Sub

    Protected Sub ImageButton8_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton8.Click
        Dim mensajeError As String = Nothing
        Dim huboError As String = "no"
        Me.Label17.Visible = False
        Me.Label18.Visible = False
        Me.Label19.Visible = False
        Me.Label20.Text = ""
        Me.Label21.Text = ""
        Me.Label22.Text = ""
        '
        If Me.TextBox1.Text = "" Then
            huboError = "si"
            Me.Label17.Visible = True
        End If
        '
        If Me.TextBox2.Text Is Nothing Or Val(Me.TextBox2.Text) < 0 Then
            huboError = "si"
            Me.Label18.Visible = True
        End If
        '
        If Me.DropDownList24.SelectedIndex = 0 Or Me.DropDownList24.SelectedIndex = -1 Then
            huboError = "si"
            Me.Label19.Visible = True
        End If
        '-----------------------------------------------------------------------------------
        ' valida seleccion de datos
        Dim seSelecciono As String
        seSelecciono = validaSeleccion()
        If seSelecciono = "No" Then
            huboError = "si"
            Me.Label20.Text = "* Debe seleccionar por lo menos un pais"
        Else
            ' valida ingreso de datos
            Dim ingresoDatosCorrectos As String
            ingresoDatosCorrectos = validaIngresoDatos()
            If ingresoDatosCorrectos = "No" Then
                huboError = "si"
                Me.Label21.Text = "* Hay un error en el ingreso de los datos"
            End If
        End If
        '----------------------------------------------------------
        Dim datosCorrectos As String = ""
        datosCorrectos = validaEntrada()
        If datosCorrectos = "No" Then
            huboError = "si"
            Me.Label22.Text = "* Hubo un error en la entrada de los valores de los productos"
        End If
        '----------------------------------------------------------
        '
        If huboError = "si" Then
            Exit Sub
        End If
        '
        grabarProducto()
        grabarProductoPais()
        mostrarVentana()
        nuevo()
    End Sub

    Function validaSeleccionProductos() As String
        Dim hayError As String = "si"
        Dim fila As GridViewRow
        Dim y As Integer
        For y = 0 To Me.GridView3.Rows.Count - 1
            fila = Me.GridView3.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
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
        For y = 0 To Me.GridView3.Rows.Count - 1
            fila = Me.GridView3.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim precioPais As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox9"), TextBox)
                Dim precioLocal As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox10"), TextBox)
                Dim precioPersonalizado As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox12"), TextBox)
                Dim precioElite As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox13"), TextBox)
                Dim stock As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox11"), TextBox)
                If c1.Checked = True Then
                    If (precioPais.Text = "" Or precioLocal.Text = "" Or precioPersonalizado.Text = "" Or precioElite.Text = "" Or stock.Text = "") Then
                        datosCorrectos = "No"
                        Exit For
                    Else
                        datosCorrectos = "si"
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
        For y = 0 To Me.GridView3.Rows.Count - 1
            fila = Me.GridView3.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim precioPais As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox9"), TextBox)
                Dim precioLocal As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox10"), TextBox)
                Dim precioPersonalizado As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox12"), TextBox)
                Dim stock As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox11"), TextBox)
                If Val(precioPais.Text) <> 0 And Val(precioLocal.Text) <> 0 And Val(precioPersonalizado.Text) <> 0 And Val(stock.Text) <> 0 Then
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

    'Function validaEntrada() As String
    '    Dim datosCorrectos As String = ""
    '    Dim tabla As New DataTable
    '    Dim fila As GridViewRow
    '    Dim haySeleccionado As String = "no"
    '    For y = 0 To Me.GridView3.Rows.Count - 1
    '        fila = Me.GridView3.Rows(y)
    '        If fila.RowType = DataControlRowType.DataRow Then
    '            Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
    '            Dim precioPais As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox9"), TextBox)
    '            Dim precioLocal As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox10"), TextBox)
    '            Dim precioPersonalizado As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox12"), TextBox)
    '            Dim stock As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox11"), TextBox)
    '            If Val(precioPais.Text) <> 0 And Val(precioLocal.Text) <> 0 And Val(precioPersonalizado.Text) <> 0 And Val(stock.Text) <> 0 Then
    '                If c1.Checked = False Then
    '                    datosCorrectos = "No"
    '                    Exit For
    '                Else
    '                    datosCorrectos = "Si"
    '                End If
    '            End If
    '        End If
    '    Next
    '    Return datosCorrectos
    'End Function

    Function validaSeleccion() As String
        Dim y As Integer
        Dim tabla As New DataTable
        Dim fila As GridViewRow
        Dim haySeleccionado As String = "no"
        For y = 0 To Me.GridView3.Rows.Count - 1
            fila = Me.GridView3.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim precioPais As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox9"), TextBox)
                Dim precioLocal As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox10"), TextBox)
                Dim precioPersonalizado As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox12"), TextBox)
                Dim stock As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox11"), TextBox)
                If c1.Checked = True Then
                    haySeleccionado = "Si"
                    Exit For
                Else
                    haySeleccionado = "No"
                End If
            End If
        Next
        Return haySeleccionado
    End Function

    Sub mostrarVentana()
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('Producto Registrado En El Sistema...!');", True)
    End Sub

    Sub nuevo()
        Me.MultiView1.ActiveViewIndex = 0
        Me.ImageButton8.Visible = True
        '
        Me.TextBox1.Text = Nothing
        Me.TextBox2.Text = Nothing
        Me.TextBox7.Text = Nothing
        Me.DropDownList24.SelectedIndex = 0
        Session("accion") = 1
        '
        Me.TextBox1.Focus()
        '
        Me.Label17.Visible = False
        Me.Label18.Visible = False
        Me.Label19.Visible = False
        Me.Label20.Text = ""
        Me.Label21.Text = ""
        Me.Label22.Text = ""
        cargarPais()
    End Sub

    Sub grabarProducto()
        Dim accion As Integer
        Dim tokenProducto As Integer = 0
        If Me.TextBox14.Text = "" Then
            tokenProducto = "0"
        Else
            tokenProducto = Me.TextBox14.Text
        End If
        With producto
            If Me.TextBox7.Text = "" Then
                .idProducto = 0
                accion = 1
            Else
                .idProducto = Val(Me.TextBox7.Text)
                accion = 2
            End If
            .nombreProducto = Me.TextBox1.Text.ToUpper
            .puntosProducto = Me.TextBox2.Text
            .idLinea = Me.DropDownList24.SelectedValue
            .tokenProducto = tokenProducto
            .grabarProducto(accion)
        End With
    End Sub

    Sub grabarProductoPais()
        Dim y As Integer
        Dim tabla As New DataTable
        Dim fila As GridViewRow
        Dim accion As Integer
        If Me.TextBox7.Text = "" Then ' si va a grabar por primera vez
            accion = 1
            For y = 0 To Me.GridView3.Rows.Count - 1
                fila = Me.GridView3.Rows(y)
                If fila.RowType = DataControlRowType.DataRow Then
                    Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                    Dim precioPais As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox9"), TextBox)
                    Dim precioLocal As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox10"), TextBox)
                    Dim precioPersonalizado As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox12"), TextBox)
                    Dim precioElite As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox13"), TextBox)
                    Dim stock As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox11"), TextBox)
                    If c1.Checked = True Then
                        With producto
                            .idProducto = 0
                            .precioProductoPais = precioPais.Text
                            .precioProductoPaisLocal = precioLocal.Text
                            .precioProductoPersonal = precioPersonalizado.Text
                            .precioProductoPorcentage = 0
                            .precioProductoStock = stock.Text
                            .precioProductoTipo = "Pre"
                            .precioProductoEstado = 1
                            .idPais = Me.GridView3.Rows(y).Cells(1).Text
                            .precioElite = precioElite.Text
                            .grabarProductoPais(accion, "No")
                        End With
                    End If
                End If
            Next
        Else
            accion = 2
            Dim chequeado As String = ""
            For y = 0 To Me.GridView3.Rows.Count - 1
                fila = Me.GridView3.Rows(y)
                If fila.RowType = DataControlRowType.DataRow Then
                    Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                    Dim precioPais As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox9"), TextBox)
                    Dim precioLocal As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox10"), TextBox)
                    Dim precioPersonalizado As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox12"), TextBox)
                    Dim precioElite As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox13"), TextBox)
                    Dim stock As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox11"), TextBox)
                    If c1.Checked = True Then
                        chequeado = "Si"
                        With producto
                            .idProducto = Me.TextBox7.Text
                            .precioProductoPais = precioPais.Text
                            .precioProductoPaisLocal = precioLocal.Text
                            .precioProductoPersonal = precioPersonalizado.Text
                            .precioProductoPorcentage = 0
                            .precioProductoStock = stock.Text
                            .precioProductoTipo = "Pre"
                            .precioProductoEstado = 1
                            .idPais = Me.GridView3.Rows(y).Cells(1).Text
                            .precioElite = precioElite.Text
                            .grabarProductoPais(accion, chequeado)
                        End With
                    Else
                        chequeado = "No"
                        'With producto
                        '    .idProducto = Me.TextBox7.Text
                        '    .precioProductoPais = precioPais.Text
                        '    .precioProductoPaisLocal = precioLocal.Text
                        '    .precioProductoPersonal = precioPersonalizado.Text
                        '    .precioProductoPorcentage = 0
                        '    .precioProductoStock = stock.Text
                        '    .precioProductoTipo = "Pre"
                        '    .precioProductoEstado = 1
                        '    .idPais = Me.GridView3.Rows(y).Cells(1).Text
                        '    .grabarProductoPais(Session("accion"), chequeado)
                        'End With

                    End If
                    '
                End If
            Next y
        End If
    End Sub

    Protected Sub ImageButton7_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
        nuevo()
    End Sub

    Protected Sub GridView2_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        Me.Label17.Visible = False
        Me.Label18.Visible = False
        Me.Label19.Visible = False
        Me.Label20.Text = ""
        Me.Label21.Text = ""
        '
        Me.TextBox7.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(1).Text
        Me.TextBox1.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(2).Text
        Me.TextBox2.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(3).Text
        Me.DropDownList24.SelectedValue = Val(Me.GridView2.Rows(e.NewSelectedIndex).Cells(4).Text)
        '
        mostrardetalleProducto()
        Me.MultiView1.ActiveViewIndex = 0
        Session("accion") = 2
        Me.ImageButton8.Visible = True

    End Sub

    Sub mostrardetalleProducto()
        Dim y As Integer
        Dim k As Integer
        Dim tabla As New DataTable
        Dim fila As GridViewRow

        With producto
            .idProducto = Val(Me.TextBox7.Text)
            tabla = .obtenerProductoPaisPorIdProducto
            If tabla.Rows.Count <> 0 Then
                For k = 0 To tabla.Rows.Count - 1
                    For y = 0 To Me.GridView3.Rows.Count - 1
                        fila = Me.GridView3.Rows(y)
                        If fila.RowType = DataControlRowType.DataRow Then
                            Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                            Dim precioPais As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox9"), TextBox)
                            Dim precioLocal As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox10"), TextBox)
                            Dim precioPersonalizado As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox12"), TextBox)
                            Dim stock As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox11"), TextBox)
                            Dim precioElite As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox13"), TextBox)
                            If tabla.Rows(k).Item("idPais") = Me.GridView3.Rows(y).Cells(1).Text Then
                                c1.Checked = True
                                precioPais.Text = tabla.Rows(k).Item("precioProductoPais")
                                precioLocal.Text = tabla.Rows(k).Item("precioProductoPaisLocal")
                                precioPersonalizado.Text = tabla.Rows(k).Item("precioProductoPersonal")
                                precioPersonalizado.Text = tabla.Rows(k).Item("precioProductoPersonal")
                                stock.Text = tabla.Rows(k).Item("precioProductoStock")
                                precioElite.Text = tabla.Rows(k).Item("precioeliteunoproductopais")
                            End If
                        End If
                    Next
                Next
            End If
        End With
    End Sub

    Protected Sub ImageButton11_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton11.Click
        Me.MultiView1.ActiveViewIndex = 1
        Me.ImageButton8.Visible = False
        '
        cargarProductos()
    End Sub

    Sub cargarProductos()
        Dim tabla As New DataTable
        With producto
            tabla = .obtenerTTProducto
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End With
    End Sub
End Class
