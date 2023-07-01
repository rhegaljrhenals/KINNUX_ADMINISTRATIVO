Imports System.Data

Partial Class Basicos_wfPaquetes
    Inherits System.Web.UI.Page

    Dim pais As New clsPaise
    Dim productos As New clsProducto
    Dim papelerias As New clsPapeleria
    Dim paquetes As New clsPaquete
    Dim paqueteProducto As New clsPaqueteProducto
    Dim paquetePapeleria As New clsPaquetePapeleria
    Dim premios As New clsPremio
    Dim paquetePremio As New clsPaquetePremio
    Dim paqueteEquiposM As New clsPaqueteEquipoM
    Dim equipoM As New clsEquipos
    Dim paquete As New clsTBPaquete
    Dim operaciones As New clsOperacione

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarPais()
            cargarProductos()
            cargarPaquetes()
            cargarPaqueteInicialyFinal()
            cargarPaquetesNoAscenso()
            Me.MultiView2.ActiveViewIndex = 0
            nuevo()
            Me.panelError.Visible = False
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    Sub cargarPaquetesNoAscenso()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from tbpaquete where ascenso='no' order by idpaquete"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList28.DataSource = tabla
                Me.DropDownList28.DataTextField = "nombrepaquete"
                Me.DropDownList28.DataValueField = "idPaquete"
                Me.DropDownList28.DataBind()
            Else
                Me.DropDownList28.DataSource = Nothing
                Me.DropDownList28.DataBind()
            End If
        End With
        Me.DropDownList28.Items.Insert(0, "Seleccione el paquete")
    End Sub

    Sub cargarPaqueteInicialyFinal()
        Dim tabla As New DataTable
        With paquete
            tabla = .obtenerPaquetesNoAscensos
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList26.DataSource = tabla
                Me.DropDownList26.DataTextField = "nombrepaquete"
                Me.DropDownList26.DataValueField = "idPaquete"
                Me.DropDownList26.DataBind()
                '
                Me.DropDownList27.DataSource = tabla
                Me.DropDownList27.DataTextField = "nombrepaquete"
                Me.DropDownList27.DataValueField = "idPaquete"
                Me.DropDownList27.DataBind()
            Else
                Me.DropDownList26.DataSource = Nothing
                Me.DropDownList26.DataBind()
                '
                Me.DropDownList27.DataSource = Nothing
                Me.DropDownList27.DataBind()

            End If
        End With
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

    Sub cargarPaquetes()
        Dim tabla As New DataTable
        With paquetes
            tabla = .obtenerPaquetes
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End With
    End Sub

    Sub nuevo()
        Session("accion") = 1
        '
        Me.RadioButton2.Checked = True
        Me.RadioButton3.Checked = True
        Me.RadioButton5.Checked = True
        Me.RadioButton7.Checked = True
        Me.Panel13.Visible = False
        '
        Me.TextBox17.Text = "0"
        Me.TextBox7.Text = Nothing
        Me.TextBox1.Text = Nothing
        Me.TextBox3.Text = Nothing
        Me.CheckBox6.Checked = False
        Me.Panel12.Visible = False
        '
        Me.panelError.Visible = False
        cargarProductos()
        cargarPapelerias()
        cargarPais()
        '
        Me.TextBox1.Focus()
        '-------------------------------------------
        Me.MultiView2.ActiveViewIndex = 0
        Me.ImageButton8.Visible = True
    End Sub

    Protected Sub ImageButton8_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton8.Click
        Dim mensajeError As String = Nothing
        Dim huboError As String = "no"
        Me.panelError.Visible = False
        Me.Label15.Text = ""
        '
        If Me.TextBox1.Text = "" Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "- Ingrese el nombre del paquete"
        End If
        '
        If Me.TextBox3.Text Is Nothing Or Val(Me.TextBox3.Text) <= 0 Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "- ingrese los puntos del paquete correctamente"
        End If
        ''
        If Me.RadioButton1.Checked = True And Me.DropDownList28.SelectedIndex = 0 Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "- Debe seleccionar el paquete equivalente...!"
        End If
        '-------------------------------------------
        ' valida la seleccion de productos
        Dim huboSeleccion As String
        huboSeleccion = validaSeleccionProductos()
        If huboSeleccion = "si" Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "- Debe Seleccionar por lo menos un productos con su cantidad"
        Else
            Dim ingresoDatosCorrectos As String
            ingresoDatosCorrectos = validaIngresoDatos()
            If ingresoDatosCorrectos = "No" Then
                huboError = "si"
                mensajeError = mensajeError & "<br>" & "- Ingrese los datos correctamente en los productos"
            End If
        End If
        '-------------------------------------------
        '-------------------------------------------
        ' valida seleccion de los precios
        Dim huboSeleccionPrecio As String
        huboSeleccionPrecio = validaSeleccionProductosPrecios()
        If huboSeleccion = "si" Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "- Ingrese los valores de los precios del paquete correctamente"
        Else
            Dim ingresoDatosCorrectos As String
            ingresoDatosCorrectos = validaIngresoDatosPrecios()
            If ingresoDatosCorrectos = "No" Then
                huboError = "si"
                mensajeError = mensajeError & "<br>" & "- Ingrese los precios del paquete correctamente"
            End If
        End If
        '-------------------------------------------
        If huboError = "si" Then
            Me.panelError.Visible = True
            Me.Label15.Text = mensajeError
            Exit Sub
        End If
        '
        grabarPaquete()
        grabarPaquetePais()
        grabarPaqueteProducto()
        grabarPaquetePapeleria()
        'grabarPaquetePremio()
        'grabarPaqueteEquiposM()
        '
        cargarPaquetes()
        mostrarVentana()
        '----------------------------------------------
        nuevo()
        '----------------------------------------------
    End Sub

    Function validaIngresoDatosPrecios() As String
        Dim datosCorrectos As String = "si"
        Dim fila As GridViewRow
        Dim y As Integer
        For y = 0 To Me.GridView7.Rows.Count - 1
            fila = Me.GridView7.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView7.Rows(y).FindControl("CheckBox5"), CheckBox)
                Dim precio As TextBox = CType(Me.GridView7.Rows(y).FindControl("TextBox15"), TextBox)
                Dim precioLocal As TextBox = CType(Me.GridView7.Rows(y).FindControl("TextBox16"), TextBox)
                If c1.Checked = True Then
                    If (Val(precio.Text) = 0 Or (precio.Text Is Nothing)) Or (Val(precioLocal.Text) = 0 Or (precioLocal.Text Is Nothing)) Then
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

    Function validaSeleccionProductosPrecios() As String
        Dim hayError As String = "si"
        Dim fila As GridViewRow
        Dim y As Integer
        For y = 0 To Me.GridView7.Rows.Count - 1
            fila = Me.GridView7.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView7.Rows(y).FindControl("CheckBox5"), CheckBox)
                Dim precio As TextBox = CType(Me.GridView7.Rows(y).FindControl("TextBox15"), TextBox)
                Dim precioLocal As TextBox = CType(Me.GridView7.Rows(y).FindControl("TextBox16"), TextBox)
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

    Sub mostrarVentana()
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('Paquete Registrado En El Sistema...!');", True)
    End Sub

    Sub cargarPais()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from tbempresa order by idpais"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.GridView7.DataSource = tabla
                Me.GridView7.DataBind()
            Else
                Me.GridView7.DataSource = Nothing
                Me.GridView7.DataBind()
            End If
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
        For y = 0 To Me.GridView5.Rows.Count - 1
            fila = Me.GridView5.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView5.Rows(y).FindControl("CheckBox3"), CheckBox)
                Dim cantidad As TextBox = CType(Me.GridView5.Rows(y).FindControl("TextBox13"), TextBox)
                If c1.Checked = True And Not (cantidad.Text Is Nothing) Then
                    If c1.Checked = True And Not (cantidad.Text Is Nothing) Then
                        cuentaSeleccionPremio += 1
                        Exit For
                    Else
                        cuentaSeleccionPremio = 0
                    End If
                End If
            End If
        Next
        '---------------------------------------------------------------------------
        '---------------------------------------------------------------------------
        ' equipos
        For y = 0 To Me.GridView6.Rows.Count - 1
            fila = Me.GridView6.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView6.Rows(y).FindControl("CheckBox4"), CheckBox)
                Dim cantidad As TextBox = CType(Me.GridView6.Rows(y).FindControl("TextBox14"), TextBox)
                If c1.Checked = True And Not (cantidad.Text Is Nothing) Then
                    If c1.Checked = True And Not (cantidad.Text Is Nothing) Then
                        cuentaSeleccionEquipo += 1
                        Exit For
                    Else
                        cuentaSeleccionEquipo = 0
                    End If
                End If
            End If
        Next
        '---------------------------------------------------------------------------
        If (cuentaSeleccionProducto = 0 And cuentaSeleccionPapeleria = 0 And cuentaSeleccionPremio = 0 And cuentaSeleccionEquipo = 0) Then
            Return "no"
        Else
            Return "si"
        End If
    End Function


    Sub grabarPaquetePremio()
        Dim y As Integer
        Dim fila As GridViewRow
        If Session("accion") = 1 Then
            For y = 0 To Me.GridView5.Rows.Count - 1
                fila = Me.GridView5.Rows(y)
                If fila.RowType = DataControlRowType.DataRow Then
                    Dim c1 As CheckBox = CType(Me.GridView5.Rows(y).FindControl("CheckBox3"), CheckBox)
                    Dim cantidad As TextBox = CType(Me.GridView5.Rows(y).FindControl("TextBox13"), TextBox)
                    If c1.Checked = True And Not (cantidad.Text Is Nothing) Then
                        With paquetePremio
                            .idPaqPremio = 0
                            .idPremio = Me.GridView5.Rows(y).Cells(1).Text
                            .cantPaqPremio = cantidad.Text
                            .accionDetallePremio = 0
                            .grabarPaquetePremio(1)
                        End With
                    End If
                End If
            Next
        Else
            For y = 0 To Me.GridView5.Rows.Count - 1
                fila = Me.GridView5.Rows(y)
                If fila.RowType = DataControlRowType.DataRow Then
                    Dim c1 As CheckBox = CType(Me.GridView5.Rows(y).FindControl("CheckBox3"), CheckBox)
                    Dim cantidad As TextBox = CType(Me.GridView5.Rows(y).FindControl("TextBox13"), TextBox)
                    If c1.Checked = True Then ' si está seleccionado
                        If Not cantidad.Text Is Nothing Then ' si la cantidad no está en blanco
                            With paquetePremio
                                '.idPaqPremio = Me.TextBox8.Text
                                .idPremio = Me.GridView5.Rows(y).Cells(1).Text
                                .cantPaqPremio = cantidad.Text
                                .accionDetallePremio = 1
                                .grabarPaquetePremio(2)
                            End With
                        End If
                    Else
                        With paquetePremio
                            '.idPaqPremio = Me.TextBox8.Text
                            .idPremio = Me.GridView5.Rows(y).Cells(1).Text
                            .cantPaqPremio = 0
                            .accionDetallePremio = 2
                            .grabarPaquetePremio(2)
                        End With
                    End If
                End If
            Next
        End If
    End Sub

    Sub grabarPaquetePapeleria()
        Dim y As Integer
        Dim fila As GridViewRow
        If Session("accion") = 1 Then
            For y = 0 To Me.GridView4.Rows.Count - 1
                fila = Me.GridView4.Rows(y)
                If fila.RowType = DataControlRowType.DataRow Then
                    Dim c1 As CheckBox = CType(Me.GridView4.Rows(y).FindControl("CheckBox2"), CheckBox)
                    Dim cantidad As TextBox = CType(Me.GridView4.Rows(y).FindControl("TextBox12"), TextBox)
                    If c1.Checked = True And Not (cantidad.Text Is Nothing) Then
                        With paquetePapeleria
                            .idPaqPapeleria = 0
                            .idPapeleria = Me.GridView4.Rows(y).Cells(1).Text
                            .cantPaqPapeleria = cantidad.Text
                            .accionDetallePapeleria = 0
                            .grabarPaquetePapeleria(1)
                        End With
                    End If
                End If
            Next
        Else
            For y = 0 To Me.GridView4.Rows.Count - 1
                fila = Me.GridView4.Rows(y)
                If fila.RowType = DataControlRowType.DataRow Then
                    Dim c1 As CheckBox = CType(Me.GridView4.Rows(y).FindControl("CheckBox2"), CheckBox)
                    Dim cantidad As TextBox = CType(Me.GridView4.Rows(y).FindControl("TextBox12"), TextBox)
                    If c1.Checked = True Then ' si está seleccionado
                        If Not cantidad.Text Is Nothing Then ' si la cantidad no está en blanco
                            With paquetePapeleria
                                '.idPaqPapeleria = Me.TextBox8.Text
                                .idPapeleria = Me.GridView4.Rows(y).Cells(1).Text
                                .cantPaqPapeleria = cantidad.Text
                                .accionDetallePapeleria = 1
                                .grabarPaquetePapeleria(2)
                            End With
                        End If
                    Else
                        With paquetePapeleria
                            '.idPaqPapeleria = Me.TextBox8.Text
                            .idPapeleria = Me.GridView4.Rows(y).Cells(1).Text
                            .cantPaqPapeleria = 0
                            .accionDetallePapeleria = 2
                            .grabarPaquetePapeleria(2)
                        End With
                    End If
                End If
            Next
        End If
    End Sub

    Sub grabarPaqueteProducto()
        Dim y As Integer
        Dim fila As GridViewRow
        If Session("accion") = 1 Then
            For y = 0 To Me.GridView3.Rows.Count - 1
                fila = Me.GridView3.Rows(y)
                If fila.RowType = DataControlRowType.DataRow Then
                    Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                    Dim cantidad As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox11"), TextBox)
                    If c1.Checked = True And Not (cantidad.Text Is Nothing) Then
                        With paqueteProducto
                            .idPaqProducto = 0
                            .idProducto = Me.GridView3.Rows(y).Cells(1).Text
                            .cantPaqProducto = cantidad.Text
                            .accionDetalleProducto = 0
                            .grabarPaqueteProducto(1)
                        End With
                    End If
                End If
            Next
        Else
            For y = 0 To Me.GridView3.Rows.Count - 1
                fila = Me.GridView3.Rows(y)
                If fila.RowType = DataControlRowType.DataRow Then
                    Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                    Dim cantidad As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox11"), TextBox)
                    If c1.Checked = True Then ' si está seleccionado
                        If Not cantidad.Text Is Nothing Then ' si la cantidad no está en blanco
                            With paqueteProducto
                                .idPaqProducto = Me.TextBox7.Text
                                .idProducto = Me.GridView3.Rows(y).Cells(1).Text
                                .cantPaqProducto = cantidad.Text
                                .accionDetalleProducto = 1
                                .grabarPaqueteProducto(2)
                            End With
                        End If
                    Else
                        With paqueteProducto
                            .idPaqProducto = Me.TextBox7.Text
                            .idProducto = Me.GridView3.Rows(y).Cells(1).Text
                            .cantPaqProducto = 0
                            .accionDetalleProducto = 2
                            .grabarPaqueteProducto(2)
                        End With
                    End If
                End If
            Next
        End If
    End Sub

    Sub grabarPaqueteEquiposM()
        Dim y As Integer
        Dim fila As GridViewRow
        If Session("accion") = 1 Then
            For y = 0 To Me.GridView6.Rows.Count - 1
                fila = Me.GridView6.Rows(y)
                If fila.RowType = DataControlRowType.DataRow Then
                    Dim c1 As CheckBox = CType(Me.GridView6.Rows(y).FindControl("CheckBox4"), CheckBox)
                    Dim cantidad As TextBox = CType(Me.GridView6.Rows(y).FindControl("TextBox14"), TextBox)
                    If c1.Checked = True And Not (cantidad.Text Is Nothing) Then
                        With paqueteEquiposM
                            .idPaqEquipoM = 0
                            .idEquipoM = Me.GridView6.Rows(y).Cells(1).Text
                            .cantPaqEquipoM = cantidad.Text
                            .accionDetalleEquipoM = 0
                            .grabarPaqueteEquiposM(1)
                        End With
                    End If
                End If
            Next
        Else
            For y = 0 To Me.GridView6.Rows.Count - 1
                fila = Me.GridView6.Rows(y)
                If fila.RowType = DataControlRowType.DataRow Then
                    Dim c1 As CheckBox = CType(Me.GridView6.Rows(y).FindControl("CheckBox4"), CheckBox)
                    Dim cantidad As TextBox = CType(Me.GridView6.Rows(y).FindControl("TextBox14"), TextBox)
                    If c1.Checked = True Then ' si está seleccionado
                        If Not cantidad.Text Is Nothing Then ' si la cantidad no está en blanco
                            With paqueteEquiposM
                                '.idPaqEquipoM = Me.TextBox8.Text
                                .idEquipoM = Me.GridView6.Rows(y).Cells(1).Text
                                .cantPaqEquipoM = cantidad.Text
                                .accionDetalleEquipoM = 1
                                .grabarPaqueteEquiposM(2)
                            End With
                        End If
                    Else
                        With paqueteEquiposM
                            '.idPaqEquipoM = Me.TextBox8.Text
                            .idEquipoM = Me.GridView6.Rows(y).Cells(1).Text
                            .cantPaqEquipoM = 0
                            .accionDetalleEquipoM = 2
                            .grabarPaqueteEquiposM(2)
                        End With
                    End If
                End If
            Next
        End If
    End Sub

    Sub grabarPaquete()
        Dim accion As Integer
        If Me.TextBox7.Text = "" Then
            accion = 1
        Else
            accion = 2
        End If
        '
        With paquete
            If Me.CheckBox6.Checked = True Then
                .paqInicial = Me.DropDownList26.SelectedValue
                .paqFinal = Me.DropDownList27.SelectedValue
                .ascenso = "si"
            Else
                .paqInicial = 0
                .paqFinal = 0
                .ascenso = "no"
            End If
            ' promocion
            Dim promocion As String = ""
            Dim paquete As Integer
            If Me.RadioButton1.Checked = True Then
                promocion = "si"
                paquete = Me.DropDownList28.SelectedValue
            Else
                If Me.RadioButton2.Checked = True Then
                    promocion = "no"
                    paquete = 0
                End If
            End If
            '
            .idPaquete = 0
            .nombrePaquete = Me.TextBox1.Text.ToUpper
            .puntosPaquete = Val(Me.TextBox3.Text)
            .tsPaquete = Val(Me.TextBox17.Text)
            .promocion = promocion
            .paquete = paquete
            .paqueteBase = IIf(Me.RadioButton3.Checked = True, "si", "no")
            .esSuperTs = IIf(Me.RadioButton5.Checked = True, "si", "no")
            .esSuperPaquete = IIf(Me.RadioButton7.Checked = True, "si", "no")
            .grabarTBPaquete(accion)
        End With
    End Sub

    Sub grabarPaquetePais()
        Dim accion As Integer
        Dim y As Integer
        Dim tabla As New DataTable
        Dim fila As GridViewRow
        If Me.TextBox7.Text = "" Then
            accion = 1
        Else
            accion = 2
        End If
        If Me.TextBox7.Text = "" Then ' si va a grabar por primera vez
            For y = 0 To Me.GridView7.Rows.Count - 1
                fila = Me.GridView7.Rows(y)
                If fila.RowType = DataControlRowType.DataRow Then
                    Dim c1 As CheckBox = CType(Me.GridView7.Rows(y).FindControl("CheckBox5"), CheckBox)
                    Dim precioPais As TextBox = CType(Me.GridView7.Rows(y).FindControl("TextBox15"), TextBox)
                    Dim precioLocal As TextBox = CType(Me.GridView7.Rows(y).FindControl("TextBox16"), TextBox)
                    If c1.Checked = True Then
                        With paquetes
                            If accion = 1 Then
                                .idpaquetePais = 0
                            Else
                                .idpaquetePais = Val(Me.TextBox7.Text)
                            End If
                            .idPaquete = 0
                            .idPais = Me.GridView7.Rows(y).Cells(1).Text
                            .precioPaquetePais = Val(precioPais.Text)
                            .precioLocalPaquetePais = Val(precioLocal.Text)
                            .estadoPaquete = 1
                            .grabarPaquetePais(accion, 0)
                        End With
                    End If
                End If
            Next
        Else
            Dim chequeado As String = ""
            For y = 0 To Me.GridView7.Rows.Count - 1
                fila = Me.GridView7.Rows(y)
                If fila.RowType = DataControlRowType.DataRow Then
                    Dim c1 As CheckBox = CType(Me.GridView7.Rows(y).FindControl("CheckBox5"), CheckBox)
                    Dim precioPais As TextBox = CType(Me.GridView7.Rows(y).FindControl("TextBox15"), TextBox)
                    Dim precioLocal As TextBox = CType(Me.GridView7.Rows(y).FindControl("TextBox16"), TextBox)
                    If c1.Checked = True Then
                        chequeado = "Si"
                        With paquetes
                            If accion = 1 Then
                                .idpaquetePais = 0
                            Else
                                .idpaquetePais = Val(Me.TextBox7.Text)
                            End If
                            .idPaquete = Val(Me.TextBox7.Text)
                            .precioPaquetePais = Val(precioPais.Text)
                            .precioLocalPaquetePais = Val(precioLocal.Text)
                            .estadoPaquete = 1
                            .grabarPaquetePais(accion, chequeado)
                        End With
                    Else
                        chequeado = "No"
                    End If
                    '
                End If
            Next y
        End If
    End Sub

    Protected Sub GridView2_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        Me.TextBox7.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(1).Text
        '
        Me.TextBox1.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(2).Text
        Me.TextBox3.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(3).Text
        '
        '--------------------------------------------
        'cargarProducto()
        'cargarPapelerias()
        'cargarPremios()
        mostrarDetalleProducto()
        mostrarDetallePapeleria()
        mostrarDetallePremios()
        mostrarDetalleEquiposM()
        '
        mostrarPreciosPorPais()
        '--------------------------------------------
        Session("accion") = 2
        Me.MultiView2.ActiveViewIndex = 0
        Me.ImageButton8.Visible = True

    End Sub

    Sub mostrarPreciosPorPais()
        Dim codigoPaisTabla As Integer
        Dim codigoPaisGrilla As Integer
        Dim y As Integer
        Dim k As Integer
        Dim tabla As New DataTable
        With paquetes
            .idPaquete = Val(Me.TextBox7.Text)
            tabla = .obtenertbPaquetePaisPorIdPaquete
            If tabla.Rows.Count <> 0 Then
                For y = 0 To tabla.Rows.Count - 1
                    codigoPaisTabla = tabla.Rows(y).Item("idPais")
                    For k = 0 To Me.GridView7.Rows.Count - 1
                        Dim c1 As CheckBox = CType(Me.GridView7.Rows(k).FindControl("CheckBox5"), CheckBox)
                        Dim precioPais As TextBox = CType(Me.GridView7.Rows(k).FindControl("TextBox15"), TextBox)
                        Dim precioLocal As TextBox = CType(Me.GridView7.Rows(k).FindControl("TextBox16"), TextBox)
                        '
                        codigoPaisGrilla = Me.GridView7.Rows(k).Cells(1).Text
                        If codigoPaisTabla = codigoPaisGrilla Then
                            c1.Checked = True
                            precioPais.Text = tabla.Rows(y).Item("precioPaquetePais")
                            precioLocal.Text = tabla.Rows(y).Item("precioLocalPaquetePais")
                        End If
                    Next
                Next
            End If
        End With
    End Sub

    Protected Sub ImageButton7_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
        nuevo()
    End Sub

    Sub mostrarDetalleProducto()
        Dim fila As GridViewRow
        Dim y, k As Integer
        Dim tabla As New DataTable
        With paqueteProducto
            tabla = .obtenerProductosPorIdPaquete(Me.TextBox7.Text)
            If tabla.Rows.Count <> 0 Then
                For k = 0 To tabla.Rows.Count - 1
                    Dim idProducto As Integer = tabla.Rows(k).Item("idProducto")
                    Dim cantidad As Integer = tabla.Rows(k).Item("cantPaqProducto")
                    For y = 0 To Me.GridView3.Rows.Count - 1
                        fila = Me.GridView3.Rows(y)
                        If fila.RowType = DataControlRowType.DataRow Then
                            Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                            Dim c As TextBox = CType(Me.GridView3.Rows(y).FindControl("Textbox11"), TextBox)
                            If idProducto = Me.GridView3.Rows(y).Cells(1).Text Then
                                c1.Checked = True
                                c.Text = cantidad
                                Exit For
                            End If
                        End If
                    Next
                Next
            End If
        End With
    End Sub

    Sub mostrarDetallePapeleria()
        Dim fila As GridViewRow
        Dim y, k As Integer
        Dim tabla As New DataTable
        With paquetePapeleria
            tabla = .obtenerPapeleriaPorIdPaquete(Me.TextBox7.Text)
            If tabla.Rows.Count <> 0 Then
                For k = 0 To tabla.Rows.Count - 1
                    Dim idPapeleria As Integer = tabla.Rows(k).Item("idPapeleria")
                    Dim cantidad As Integer = tabla.Rows(k).Item("cantPaqPapeleria")
                    For y = 0 To Me.GridView4.Rows.Count - 1
                        fila = Me.GridView4.Rows(y)
                        If fila.RowType = DataControlRowType.DataRow Then
                            Dim c1 As CheckBox = CType(Me.GridView4.Rows(y).FindControl("CheckBox2"), CheckBox)
                            Dim c As TextBox = CType(Me.GridView4.Rows(y).FindControl("Textbox12"), TextBox)
                            If idPapeleria = Me.GridView4.Rows(y).Cells(1).Text Then
                                c1.Checked = True
                                c.Text = cantidad
                                Exit For
                            End If
                        End If
                    Next
                Next
            End If
        End With
    End Sub

    Sub mostrarDetallePremios()
        Dim fila As GridViewRow
        Dim y, k As Integer
        Dim tabla As New DataTable
        With paquetePremio
            tabla = .obtenerPremioPorIdPaquete(Me.TextBox7.Text)
            If tabla.Rows.Count <> 0 Then
                For k = 0 To tabla.Rows.Count - 1
                    Dim idPremio As Integer = tabla.Rows(k).Item("idPremio")
                    Dim cantidad As Integer = tabla.Rows(k).Item("cantPaqPremio")
                    For y = 0 To Me.GridView5.Rows.Count - 1
                        fila = Me.GridView5.Rows(y)
                        If fila.RowType = DataControlRowType.DataRow Then
                            Dim c1 As CheckBox = CType(Me.GridView5.Rows(y).FindControl("CheckBox3"), CheckBox)
                            Dim c As TextBox = CType(Me.GridView5.Rows(y).FindControl("Textbox13"), TextBox)
                            If idPremio = Me.GridView5.Rows(y).Cells(1).Text Then
                                c1.Checked = True
                                c.Text = cantidad
                                Exit For
                            End If
                        End If
                    Next
                Next
            End If
        End With
    End Sub

    Sub mostrarDetalleEquiposM()
        Dim fila As GridViewRow
        Dim y, k As Integer
        Dim tabla As New DataTable
        With paqueteEquiposM
            tabla = .obtenerEquiposMPorIdPaquete(Me.TextBox7.Text)
            If tabla.Rows.Count <> 0 Then
                For k = 0 To tabla.Rows.Count - 1
                    Dim idEquiposM As Integer = tabla.Rows(k).Item("idEquipoM")
                    Dim cantidad As Integer = tabla.Rows(k).Item("cantPaqEquipoM")
                    For y = 0 To Me.GridView6.Rows.Count - 1
                        fila = Me.GridView6.Rows(y)
                        If fila.RowType = DataControlRowType.DataRow Then
                            Dim c1 As CheckBox = CType(Me.GridView6.Rows(y).FindControl("CheckBox4"), CheckBox)
                            Dim c As TextBox = CType(Me.GridView6.Rows(y).FindControl("Textbox14"), TextBox)
                            If idEquiposM = Me.GridView6.Rows(y).Cells(1).Text Then
                                c1.Checked = True
                                c.Text = cantidad
                                Exit For
                            End If
                        End If
                    Next
                Next
            End If
        End With
    End Sub

    Protected Sub CheckBox6_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If Me.CheckBox6.Checked = True Then
            Me.Panel12.Visible = True
        Else
            Me.Panel12.Visible = False
        End If
    End Sub

    Protected Sub ImageButton9_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
        Me.MultiView2.ActiveViewIndex = 1
        Me.ImageButton8.Visible = False
    End Sub

    Protected Sub RadioButton1_CheckedChanged(sender As Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If Me.RadioButton1.Checked = True Then
            Me.Panel13.Visible = True
        End If
    End Sub

    Protected Sub RadioButton2_CheckedChanged(sender As Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If Me.RadioButton2.Checked = True Then
            Me.Panel13.Visible = False
        End If

    End Sub
End Class
