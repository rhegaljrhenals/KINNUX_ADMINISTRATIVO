Imports System.Data

Partial Class Bodega_Principal_wfEntradaBodegaPrincipal
    Inherits System.Web.UI.Page

    Dim productos As New clsProducto
    Dim bodegaPrincipal As New clsBodegaPrincipal
    Dim proveedores As New clsProveedore
    Dim objTTEncEntProductoBod As New clsTTEncEntProductoBod
    Dim objTTDetEntProductoBod As New clsTTDetEntProductoBod
    Dim objTTCajaEntProductoBod As New clsTTCajaEntProductoBod

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarProveedores()
            cargarAno()
            'cargarProductos()
            limpiar()
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub cargarAno()
        Dim y As Integer
        For y = 2012 To Now.Year
            Me.DropDownList4.Items.Add(y)
        Next
        Me.DropDownList4.Items.Insert(0, "Año")
    End Sub

    Sub cargarProveedores()
        Dim tabla As New DataTable
        With proveedores
            tabla = .obtieneProveedoreTodos
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList1.DataSource = tabla
                Me.DropDownList1.DataTextField = "nombreProveedor"
                Me.DropDownList1.DataValueField = "idProveedor"
                Me.DropDownList1.DataBind()
            Else
                Me.DropDownList1.DataSource = Nothing
                Me.DropDownList1.DataBind()
            End If
            Me.DropDownList1.Items.Insert(0, "Seleccione Proveedor")
        End With
    End Sub

    Sub cargarProductos()
        Dim tabla As New DataTable
        With productos
            .idPais = 57 'Session("pais")
            tabla = .obtenerProductos
            If tabla.Rows.Count <> 0 Then
                Me.GridView1.DataSource = tabla
                Me.GridView1.DataBind()
            Else
                Me.GridView1.DataSource = Nothing
                Me.GridView1.DataBind()
            End If
        End With
    End Sub

    Sub nuevo()
        Session("accion") = 1
    End Sub

    Protected Sub ImageButton12_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton12.Click
        Dim mensajeError As String = Nothing
        Dim huboError As String = "no"
        Me.panelError.Visible = False
        Me.Label15.Text = ""
        '
        If Me.DropDownList1.SelectedIndex = 0 Or Me.DropDownList1.SelectedIndex = -1 Then
            huboError = "si"
            mensajeError = "- Seleccione el proveedor"
        End If
        '
        If Me.TextBox1.Text = "" Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "- Ingrese le numero de guia"
        End If
        '
        'If Me.TextBox6.Text = "" Then
        '    huboError = "si"
        '    mensajeError = mensajeError & "<br>" & "- Seleccione la fecha"
        'End If
        '
        'If Me.DropDownList4.SelectedIndex = 0 Or Me.DropDownList2.SelectedIndex = 0 Or Me.DropDownList3.SelectedIndex = 0 Then
        '    mensajeError = mensajeError & "<br>" & "- Seleccione la fecha correctamente...!"
        'End If
        '----------------------------------------------------------------------------------
        ' valida el numero de guia
        Dim tabla As New DataTable
        With objTTEncEntProductoBod
            .guiaEncEntProductoBod = Me.TextBox1.Text
            tabla = .validaNumeroGuia
            If tabla.Rows.Count <> 0 Then
                huboError = "si"
                mensajeError = mensajeError & "<br>" & "- El número de guia ya está registrado en el sistema...!"
            End If
        End With
        '----------------------------------------------------------------------------------
        '-----------------------------------------------------------------------------------
        ' valida la seleccion de productos 
        Dim siHuboError As String
        siHuboError = validaSeleccionProductos()
        If siHuboError = "si" Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "- Debe Seleccionar por lo menos un producto...!"
        Else
            Dim ingresoDatosCorrectos As String
            ingresoDatosCorrectos = validaIngresoDatos()
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
        '----------------------------------------------------------
        If huboError = "si" Then
            Me.panelError.Visible = True
            Me.Label15.Text = mensajeError
            Exit Sub
        End If
        '
        grabarTTEncEntProductoBod()
        grabarTTDetEntProductoBod()
        grabarTTCajaEntProductoBod()
        ClientScript.RegisterStartupScript(Me.GetType(), "myalert", "alert('" + "Entrada Ingresada al sistema...!" + "');", True)
        limpiar()
    End Sub

    Function validaIngresoDatos() As String
        Dim datosCorrectos As String = "si"
        Dim fila As GridViewRow
        Dim y As Integer
        For y = 0 To Me.GridView1.Rows.Count - 1
            fila = Me.GridView1.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView1.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim cajas As TextBox = CType(Me.GridView1.Rows(y).FindControl("TextBox4"), TextBox)
                Dim unidade As TextBox = CType(Me.GridView1.Rows(y).FindControl("TextBox5"), TextBox)
                'Dim precio As TextBox = CType(Me.GridView1.Rows(y).FindControl("TextBox6"), TextBox)
                If c1.Checked = True Then
                    If (Val(cajas.Text) = 0 Or (cajas.Text Is Nothing)) Or (Val(unidade.Text) = 0 Or (unidade.Text Is Nothing)) Then
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
                Dim c1 As CheckBox = CType(Me.GridView1.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim cajas As TextBox = CType(Me.GridView1.Rows(y).FindControl("TextBox4"), TextBox)
                Dim unidade As TextBox = CType(Me.GridView1.Rows(y).FindControl("TextBox5"), TextBox)
                If Val(cajas.Text) <> 0 And Val(unidade.Text) <> 0 Then
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

    Function validaSeleccionProductos() As String
        Dim hayError As String = "si"
        Dim fila As GridViewRow
        Dim y As Integer
        For y = 0 To Me.GridView1.Rows.Count - 1
            fila = Me.GridView1.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView1.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim cajas As TextBox = CType(Me.GridView1.Rows(y).FindControl("TextBox4"), TextBox)
                Dim unidade As TextBox = CType(Me.GridView1.Rows(y).FindControl("TextBox5"), TextBox)
                'Dim precio As TextBox = CType(Me.GridView1.Rows(y).FindControl("TextBox6"), TextBox)
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

    Sub limpiar()
        Me.TextBox1.Text = ""
        Me.DropDownList1.SelectedIndex = 0
        cargarProductos()
        Me.panelError.Visible = False
        '
        Me.TextBox6.Text = Now.Date.ToString("yyyy/MM/dd")
    End Sub

    Sub grabarTTDetEntProductoBod()
        Dim fila As GridViewRow
        Dim precio As Double
        Dim y As Integer
        For y = 0 To Me.GridView1.Rows.Count - 1
            fila = Me.GridView1.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView1.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim cajas As TextBox = CType(Me.GridView1.Rows(y).FindControl("TextBox4"), TextBox)
                Dim unidade As TextBox = CType(Me.GridView1.Rows(y).FindControl("TextBox5"), TextBox)
                'Dim precio As TextBox = CType(Me.GridView1.Rows(y).FindControl("TextBox6"), TextBox)
                precio = Val(Me.GridView1.Rows(y).Cells(5).Text)
                If c1.Checked = True And Not (cajas.Text Is Nothing) And Not (unidade.Text Is Nothing) Then
                    With objTTDetEntProductoBod
                        .idDetEntProductoBod = 0
                        .idEncEntProductoBod = 0
                        .idProducto = Me.GridView1.Rows(y).Cells(1).Text
                        .cantDetEntProductoBod = unidade.Text
                        .valorDetEntProductoBod = precio
                        .subtotalDetEntProductoBod = (precio * (cajas.Text * unidade.Text))
                        .cantRecDetEntProductoBod = 0
                        .ncajasDetEntproductoBod = cajas.Text
                        .grabarTTDetEntProductoBod()
                    End With
                End If
            End If
        Next
    End Sub

    Sub grabarTTEncEntProductoBod()
        '-----------------------------------------------------------------------------
        ' calcula el valor total
        Dim valorTotal As Double = 0
        Dim precio As Double
        Dim fila As GridViewRow
        Dim y As Integer
        For y = 0 To Me.GridView1.Rows.Count - 1
            fila = Me.GridView1.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView1.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim cajas As TextBox = CType(Me.GridView1.Rows(y).FindControl("TextBox4"), TextBox)
                Dim unidade As TextBox = CType(Me.GridView1.Rows(y).FindControl("TextBox5"), TextBox)
                'Dim precio As TextBox = CType(Me.GridView1.Rows(y).FindControl("TextBox6"), TextBox)
                precio = Val(Me.GridView1.Rows(y).Cells(5).Text)
                If c1.Checked = True And Not (cajas.Text Is Nothing) And Not (unidade.Text Is Nothing) Then
                    valorTotal += ((Val(cajas.Text) * Val(unidade.Text)) * precio)
                End If
            End If
        Next
        '-----------------------------------------------------------------------------
        With objTTEncEntProductoBod
            .idEncEntProductoBod = 0
            .fechaEncEntProductoBod = Me.TextBox6.Text 'Me.Calendar1.SelectedDate.ToString("yyyy/MM/dd") 'Me.TextBox6.Text 'Me.DropDownList4.SelectedItem.Text & "/" & Me.DropDownList2.SelectedValue & "/" & Me.DropDownList3.SelectedValue 'Me.TextBox2.Text
            .idProveedor = Me.DropDownList1.SelectedValue
            .valorEncProductoBod = valorTotal
            .guiaEncEntProductoBod = Me.TextBox1.Text
            .procesaEncEntProductoBod = "Si"
            .confirEncEntProductoBod = "No"
            .estadoEncEntProductoBod = 1
            .observEncEntProdcutoBod = "" 'Me.TextBox3.Text
            .grabarTTEncEntProductoBod()
        End With
    End Sub

    Sub grabarTTCajaEntProductoBod()
        Dim fila As GridViewRow
        Dim y As Integer
        Dim k As Integer
        Dim precio As Double
        For y = 0 To Me.GridView1.Rows.Count - 1
            fila = Me.GridView1.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView1.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim cajas As TextBox = CType(Me.GridView1.Rows(y).FindControl("TextBox4"), TextBox)
                Dim unidade As TextBox = CType(Me.GridView1.Rows(y).FindControl("TextBox5"), TextBox)
                'Dim precio As TextBox = CType(Me.GridView1.Rows(y).FindControl("TextBox6"), TextBox)
                precio = Val(Me.GridView1.Rows(y).Cells(5).Text)
                If c1.Checked = True And Not (cajas.Text Is Nothing) And Not (unidade.Text Is Nothing) Then
                    For k = 1 To cajas.Text
                        With objTTCajaEntProductoBod
                            .idCajaEntProductoBod = 0
                            .conseCajaEntProductoBod = k
                            .idEncEntProductoBod = 0
                            .idProducto = Me.GridView1.Rows(y).Cells(1).Text
                            .cantCajaEntProductoBod = unidade.Text
                            .cantRecCajaEntProductoBod = unidade.Text
                            .cantFalCajaEntProductoBod = 0
                            .cantMalCajaEntProductoBod = 0
                            .altaCajaEntProductoBod = "No"
                            .fecRCajaEntProductoBod = Me.TextBox6.Text 'Me.Calendar1.SelectedDate.ToString("yyyy/MM/dd") 'Me.TextBox6.Text 'Me.DropDownList4.SelectedItem.Text & "/" & Me.DropDownList2.SelectedValue & "/" & Me.DropDownList3.SelectedValue
                            .grabarTTCajaEntProductoBod()
                        End With
                    Next
                End If
            End If
        Next
    End Sub

    Protected Sub ImageButton11_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton11.Click
        limpiar()
    End Sub
End Class
