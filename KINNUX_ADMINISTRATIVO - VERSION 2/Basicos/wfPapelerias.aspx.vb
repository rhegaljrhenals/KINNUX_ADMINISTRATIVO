Imports System.Data

Partial Class Basicos_wfPapelerias
    Inherits System.Web.UI.Page

    Dim pais As New clsPaise
    Dim linea As New clsLineaArticulo
    Dim objOperacione As New clsOperacione
    Dim papeleria As New clsPapeleria

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarPais()
            'cargarPapeleria()
            nuevo()
            Me.panelError.Visible = False
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub cargarPais()
        Dim tabla As New DataTable
        With pais
            tabla = .MostrarPaise
            Me.GridView3.DataSource = tabla
            Me.GridView3.DataBind()
        End With
    End Sub

    'Sub cargarPapeleria()
    '    Dim tabla As New DataTable
    '    With papeleria
    '        tabla = .obtenerPapeleria
    '        Me.GridView2.DataSource = tabla
    '        Me.GridView2.DataBind()
    '    End With
    'End Sub

    'Sub cargarPais()
    '    Dim tabla As New DataTable
    '    With pais
    '        tabla = .MostrarPaise
    '        Me.DropDownList23.DataSource = tabla
    '        Me.DropDownList23.DataTextField = "nombrePais"
    '        Me.DropDownList23.DataValueField = "codigoPais"
    '        Me.DropDownList23.DataBind()
    '    End With
    '    Me.DropDownList23.Items.Insert(0, "Seleccione Pais")
    'End Sub

    Protected Sub ImageButton8_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton8.Click
        Dim mensajeError As String = Nothing
        Dim huboError As String = "no"
        Me.panelError.Visible = False
        Me.Label15.Text = ""
        '
        If Me.TextBox1.Text = "" Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "- Ingrese el nombre de la papeleria"
        End If
        '
        '-----------------------------------------------------------------------------------
        ' valida la seleccion de productos
        Dim siHuboError As String
        siHuboError = validaSeleccionProductos()
        If siHuboError = "si" Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "* Debe seleccionar por lo menos un pais para su ingreso"
        Else
            Dim ingresoDatosCorrectos As String
            ingresoDatosCorrectos = validaIngresoDatos()
            If ingresoDatosCorrectos = "No" Then
                huboError = "si"
                mensajeError = mensajeError & "<br>" & "* Hay un error en el ingreso de los datos"
            End If
        End If
        '
        '----------------------------------------------------------
        Dim datosCorrectos As String = ""
        datosCorrectos = validaEntrada()
        If datosCorrectos = "No" Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "* Hubo un error en la entrada de los valores de los productos"
        End If
        '----------------------------------------------------------
        If huboError = "si" Then
            Me.panelError.Visible = True
            Me.Label15.Text = mensajeError
            Exit Sub
        End If
        '
        grabarPapeleria()
        grabarPapeleriaPais()
        'cargarPapeleria()
        nuevo()
        mostrarVentana()
        cargarPais()
    End Sub

    Sub mostrarVentana()
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('Papeleria Registrada En El Sistema...!');", True)
    End Sub

    Function validaEntrada() As String
        Dim datosCorrectos As String = ""
        Dim tabla As New DataTable
        Dim fila As GridViewRow
        For y = 0 To Me.GridView3.Rows.Count - 1
            fila = Me.GridView3.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim precioPais As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox8"), TextBox)
                Dim precioLocal As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox9"), TextBox)
                Dim stock As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox11"), TextBox)
                If Val(precioPais.Text) <> 0 And Val(precioLocal.Text) <> 0 And Val(stock.Text) <> 0 Then
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

    Function validaIngresoDatos() As String
        Dim datosCorrectos As String = "si"
        Dim fila As GridViewRow
        Dim y As Integer
        For y = 0 To Me.GridView3.Rows.Count - 1
            fila = Me.GridView3.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim precioPais As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox8"), TextBox)
                Dim precioLocal As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox9"), TextBox)
                Dim stock As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox11"), TextBox)
                If c1.Checked = True Then
                    If (Val(precioPais.Text) = 0 Or (precioPais.Text Is Nothing)) Or (Val(precioLocal.Text) = 0 Or (precioLocal.Text Is Nothing)) Or (Val(stock.Text) = 0 Or (stock.Text Is Nothing)) Then
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

    Sub nuevo()
        'Me.DropDownList23.SelectedIndex = 0
        Me.TextBox1.Text = Nothing
        'Me.TextBox3.Text = Nothing
        Me.TextBox7.Text = Nothing
        
        '
        Me.DropDownList25.SelectedIndex = 0
        Me.panelError.Visible = False
        Session("accion") = 1
        '
        Me.TextBox1.Focus()
    End Sub

    Sub grabarPapeleria()
        With papeleria
            If Session("accion") = 1 Then
                .idPapeleria = 0
            Else
                .idPapeleria = Val(Me.TextBox7.Text)
            End If
            .nombrePapeleria = Me.TextBox1.Text.ToUpper
            .grabarPapeleria(Session("accion"))
        End With
    End Sub

    Sub grabarPapeleriaPais()
        Dim y As Integer
        Dim tabla As New DataTable
        Dim fila As GridViewRow
        If Session("accion") = 1 Then ' si va a grabar por primera vez
            For y = 0 To Me.GridView3.Rows.Count - 1
                fila = Me.GridView3.Rows(y)
                If fila.RowType = DataControlRowType.DataRow Then
                    Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                    Dim precioPais As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox8"), TextBox)
                    Dim precioLocal As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox9"), TextBox)
                    Dim stock As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox11"), TextBox)
                    If c1.Checked = True Then
                        With papeleria
                            .idPapeleria = 0
                            .idPais = Me.GridView3.Rows(y).Cells(1).Text
                            .precioPapeleria = precioPais.Text
                            .precioLocalPapeleria = precioLocal.Text
                            .stockPapeleria = stock.Text
                            .estadoPapeleria = Me.DropDownList25.SelectedValue
                            .grabarPapeleriaPais(1, "no")
                        End With
                    End If
                End If
            Next
        Else
            Dim chequeado As String = ""
            For y = 0 To Me.GridView3.Rows.Count - 1
                fila = Me.GridView3.Rows(y)
                If fila.RowType = DataControlRowType.DataRow Then
                    Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                    Dim precioPais As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox8"), TextBox)
                    Dim precioLocal As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox9"), TextBox)
                    Dim stock As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox11"), TextBox)
                    If c1.Checked = True Then
                        chequeado = "Si"
                        With papeleria
                            .idPapeleria = Me.TextBox7.Text
                            .idPais = Me.GridView3.Rows(y).Cells(1).Text
                            .precioPapeleria = precioPais.Text
                            .precioLocalPapeleria = precioLocal.Text
                            .stockPapeleria = stock.Text
                            .estadoPapeleria = Me.DropDownList25.SelectedValue
                            .grabarPapeleriaPais(Session("accion"), chequeado)
                        End With
                    Else
                        chequeado = "No"

                    End If
                    '
                End If
            Next y
        End If
    End Sub

    Protected Sub ImageButton7_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
        nuevo()
    End Sub
End Class
