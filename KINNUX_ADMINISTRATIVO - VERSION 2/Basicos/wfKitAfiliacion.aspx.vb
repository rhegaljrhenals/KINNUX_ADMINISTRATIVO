Imports System.Data

Partial Class Basicos_wfPaquetes
    Inherits System.Web.UI.Page

    Dim pais As New clsPaise
    Dim productos As New clsProducto
    Dim papelerias As New clsPapeleria
    Dim encabezadoKit As New clsTTencabezadoKit
    Dim detalleKit As New clsTTDetalleKit
    Dim preciosKit As New clsTTPreciosKit


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarPais()
            cargarProductos()
            cargarPapelerias()
            nuevo()
            Me.panelError.Visible = False
            Me.TabContainer1.ActiveTabIndex = 0
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub cargarPapelerias()
        Dim tabla As New DataTable
        With papelerias
            tabla = .obtenerPapeleria
            If tabla.Rows.Count <> 0 Then
                Me.GridView4.DataSource = tabla
                Me.GridView4.DataBind()
            Else
                Me.GridView4.DataSource = Nothing
                Me.GridView4.DataBind()
            End If
        End With
    End Sub

    Sub cargarProductos()
        Dim tabla As New DataTable
        With productos
            tabla = .obtenerTTProducto
            If tabla.Rows.Count <> 0 Then
                Me.GridView3.DataSource = tabla
                Me.GridView3.DataBind()
            Else
                Me.GridView3.DataSource = Nothing
                Me.GridView3.DataBind()
            End If
        End With
    End Sub

    Sub nuevo()
        Session("accion") = 1
        '
        Me.TextBox7.Text = Nothing
        Me.TextBox1.Text = Nothing
        Me.TextBox3.Text = Nothing
        cargarProductos()
        cargarPais()
        '
        Me.TextBox1.Focus()
        '-------------------------------------------
    End Sub


    Protected Sub ImageButton8_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton8.Click
        Dim mensajeError As String = Nothing
        Dim huboError As String = "no"
        Me.panelError.Visible = False
        Me.Label15.Text = ""
        '
        'If Me.DropDownList23.SelectedIndex = 0 Or Me.DropDownList23.SelectedIndex = -1 Then
        '    huboError = "si"
        '    mensajeError = "- Seleccione el pais"
        'End If
        ' ''
        If Me.TextBox1.Text = "" Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "- Ingrese el nombre del paquete"
        End If
        '
        If Me.TextBox3.Text Is Nothing Or Val(Me.TextBox3.Text) < 0 Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "- ingrese los puntos del paquete correctamente"
        End If
        ''
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
        '************************************************************************************

        '*************************************************************************************
        If huboError = "si" Then
            Me.panelError.Visible = True
            Me.Label15.Text = mensajeError
            Exit Sub
        End If
        '
        grabarEncabezadoKit()
        grabarPreciosKit()
        grabarDetalleKit()
        mostrarVentana()
        '----------------------------------------------
        nuevo()
        '----------------------------------------------
    End Sub

    Sub grabarDetalleKit()
        Dim fila As GridViewRow
        Dim y As Integer
        For y = 0 To Me.GridView3.Rows.Count - 1
            fila = Me.GridView3.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim cantidad As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox11"), TextBox)
                If c1.Checked = True Then
                    With detalleKit
                        .idItemDetalleKit = Me.GridView3.Rows(y).Cells(1).Text
                        .tipoDetalleKit = "pr"
                        .cantidadDetalleKit = cantidad.Text
                        .grabarTTDetalleKit()
                    End With
                End If
            End If
        Next
        ' graba la papeleria
        For y = 0 To Me.GridView4.Rows.Count - 1
            fila = Me.GridView4.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView4.Rows(y).FindControl("CheckBox2"), CheckBox)
                Dim cantidad As TextBox = CType(Me.GridView4.Rows(y).FindControl("TextBox12"), TextBox)
                If c1.Checked = True Then
                    With detalleKit
                        .idItemDetalleKit = Me.GridView4.Rows(y).Cells(1).Text
                        .tipoDetalleKit = "pa"
                        .cantidadDetalleKit = cantidad.Text
                        .grabarTTDetalleKit()
                    End With
                End If
            End If
        Next

    End Sub

    Sub grabarPreciosKit()
        Dim y As Integer
        Dim datosCorrectos As String = ""
        Dim tabla As New DataTable
        Dim fila As GridViewRow
        For y = 0 To Me.GridView7.Rows.Count - 1
            fila = Me.GridView7.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView7.Rows(y).FindControl("CheckBox5"), CheckBox)
                Dim precioPais As TextBox = CType(Me.GridView7.Rows(y).FindControl("TextBox15"), TextBox)
                Dim precioLocal As TextBox = CType(Me.GridView7.Rows(y).FindControl("TextBox16"), TextBox)
                If c1.Checked = True Then
                    With preciosKit
                        .precioPais = precioPais.Text
                        .precioLocal = precioLocal.Text
                        .idPais = Me.GridView7.Rows(y).Cells(1).Text
                        .grabarTTPreciosKit(1)
                    End With
                End If
            End If
        Next
    End Sub

    Sub grabarEncabezadoKit()
        With encabezadoKit
            .idKit = 0
            .nombreKit = Me.TextBox1.Text.ToUpper
            .puntosKit = Val(Me.TextBox3.Text)
            .estadoKit = 1
            .grabarTTencabezadoKit(1)
        End With
    End Sub

    Function validaSeleccionProductos() As String
        Dim hayError As String = "si"
        Dim fila As GridViewRow
        Dim y As Integer
        For y = 0 To Me.GridView3.Rows.Count - 1
            fila = Me.GridView3.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim cantidad As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox11"), TextBox)
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
                Dim cantidad As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox11"), TextBox)
                If c1.Checked = True Then
                    If (Val(cantidad.Text) = 0 Or (cantidad.Text Is Nothing)) Then
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
        For y = 0 To Me.GridView3.Rows.Count - 1
            fila = Me.GridView3.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim cantidad As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox11"), TextBox)
                If Val(cantidad.Text) Then
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
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('Paquete Registrado En El Sistema...!');", True)
    End Sub

    Sub cargarPais()
        Dim tabla As New DataTable
        With pais
            tabla = .MostrarPaise
            Me.GridView7.DataSource = tabla
            Me.GridView7.DataBind()
        End With
    End Sub

    Function validaSeleccion() As String
        Dim cuentaSeleccionProducto As Integer = 0
        Dim cuentaSeleccionPapeleria As Integer = 0
        Dim cuentaSeleccionPremio As Integer = 0
        Dim cuentaSeleccionEquipo As Integer = 0
        '
        Dim y As Integer
        Dim fila As GridViewRow
        '
        '---------------------------------------------------------------------------
        ' productos
        For y = 0 To Me.GridView3.Rows.Count - 1
            fila = Me.GridView3.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim cantidad As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox11"), TextBox)
                If c1.Checked = True And Not (cantidad.Text Is Nothing) Then
                    cuentaSeleccionProducto += 1
                    Exit For
                Else
                    cuentaSeleccionProducto = 0
                End If
            End If
        Next
        '---------------------------------------------------------------------------
        ' papeleria
        For y = 0 To Me.GridView4.Rows.Count - 1
            fila = Me.GridView4.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView4.Rows(y).FindControl("CheckBox2"), CheckBox)
                Dim cantidad As TextBox = CType(Me.GridView4.Rows(y).FindControl("TextBox12"), TextBox)
                If c1.Checked = True And Not (cantidad.Text Is Nothing) Then
                    cuentaSeleccionPapeleria += 1
                    Exit For
                Else
                    cuentaSeleccionPapeleria = 0
                End If
            End If
        Next
        '---------------------------------------------------------------------------
        ' premios
        '---------------------------------------------------------------------------
        If (cuentaSeleccionProducto = 0 And cuentaSeleccionPapeleria = 0 And cuentaSeleccionPremio = 0 And cuentaSeleccionEquipo = 0) Then
            Return "no"
        Else
            Return "si"
        End If
    End Function


    Protected Sub GridView2_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        Me.TextBox7.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(1).Text
        '
        Me.TextBox1.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(2).Text
        Me.TextBox3.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(3).Text
        '
        '--------------------------------------------
        '--------------------------------------------
        Session("accion") = 2
    End Sub



    Protected Sub ImageButton7_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
        nuevo()
    End Sub

End Class
