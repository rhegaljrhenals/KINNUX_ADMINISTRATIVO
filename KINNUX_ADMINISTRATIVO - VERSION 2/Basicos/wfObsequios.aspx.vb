Imports System.Data

Partial Class Basicos_wfObsequios
    Inherits System.Web.UI.Page

    Dim pais As New clsPaise
    Dim productos As New clsProducto
    Dim papelerias As New clsPapeleria
    Dim paquetes As New clsPaquete
    Dim premios As New clsPremio
    Dim equipoM As New clsEquipos
    Dim promociones As New clsPromocion
    Dim paqueteProductoObs As New clsPaqueteProductoObs
    Dim paquetePapeleriaObs As New clsPaquetePapeleriaObs
    Dim paquetePremioObs As New clsPaquetePremioObs
    Dim paqueteEquipomObs As New clsPaqueteEquipomObs
    '
    Dim obsequio As New clsObsequio


    Protected Sub DropDownList23_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList23.SelectedIndexChanged
        If Me.DropDownList23.SelectedIndex > 0 Then
            cargarProducto()
            cargarPapelerias()
            cargarPremios()
            cargarEquipos()
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub cargarEquipos()
        Dim tabla As New DataTable
        With equipoM
            .idPais = Me.DropDownList23.SelectedValue
            tabla = .obtenerEquiposPorPais
            If tabla.Rows.Count <> 0 Then
                Me.GridView6.DataSource = tabla
                Me.GridView6.DataBind()
            Else
                Me.GridView6.DataSource = Nothing
                Me.GridView6.DataBind()
            End If
        End With
    End Sub

    Sub cargarPremios()
        Dim tabla As New DataTable
        With premios
            .idPais = Me.DropDownList23.SelectedValue
            tabla = .obtenerPremiosPorPais
            If tabla.Rows.Count <> 0 Then
                Me.GridView5.DataSource = tabla
                Me.GridView5.DataBind()
            Else
                Me.GridView5.DataSource = Nothing
                Me.GridView5.DataBind()
            End If
        End With
    End Sub

    Sub cargarPapelerias()
        Dim tabla As New DataTable
        With papelerias
            .idPais = Me.DropDownList23.SelectedValue
            tabla = .papeleriaPorPais
            If tabla.Rows.Count <> 0 Then
                Me.GridView4.DataSource = tabla
                Me.GridView4.DataBind()
                '
            Else
                Me.GridView4.DataSource = Nothing
                Me.GridView4.DataBind()
            End If
        End With
    End Sub

    Sub cargarProducto()
        Dim tabla As New DataTable
        With productos
            .idPais = Me.DropDownList23.SelectedValue
            tabla = .productosPorPais
            If tabla.Rows.Count <> 0 Then
                Me.GridView3.DataSource = tabla
                Me.GridView3.DataBind()
                '
            Else
                Me.GridView3.DataSource = Nothing
                Me.GridView3.DataBind()
            End If
        End With
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarPais()
            cargarPaquetes()
            cargarObsequios()
            nuevo()
            Me.panelError.Visible = False
            Me.TabContainer2.ActiveTabIndex = 0
        End If
    End Sub

    Sub cargarObsequios()
        Dim tabla As New DataTable
        With obsequio
            tabla = .obtenerObsequio
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End With
    End Sub

    Sub cargarPaquetes()
        Dim tabla As New DataTable
        With paquetes
            tabla = .obtenerPaquetes
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList24.DataSource = tabla
                Me.DropDownList24.DataTextField = "nombrePaquete"
                Me.DropDownList24.DataValueField = "idPaquete"
                Me.DropDownList24.DataBind()
            Else
                Me.DropDownList24.DataSource = Nothing
                Me.DropDownList24.DataBind()
            End If
            Me.DropDownList24.Items.Insert(0, "Seleccione Paquete")
        End With
    End Sub

    Sub nuevo()
        Session("accion") = 1
        '
        Me.TextBox7.Text = Nothing
        Me.TextBox8.Text = Nothing
        Me.TextBox15.Text = Nothing
        Me.DropDownList23.SelectedIndex = 0
        Me.DropDownList24.SelectedIndex = 0
        Me.DropDownList23.Focus()
        '-------------------------------------------
        Me.GridView3.DataSource = Nothing
        Me.GridView3.DataBind()
        '
        Me.GridView4.DataSource = Nothing
        Me.GridView4.DataBind()
        '
        Me.GridView5.DataSource = Nothing
        Me.GridView5.DataBind()
        '
        Me.GridView6.DataSource = Nothing
        Me.GridView6.DataBind()
        '-------------------------------------------
        Me.panelError.Visible = False
    End Sub

    Sub cargarPais()
        Dim tabla As New DataTable
        With pais
            tabla = .MostrarPaise
            Me.DropDownList23.DataSource = tabla
            Me.DropDownList23.DataTextField = "nombrePais"
            Me.DropDownList23.DataValueField = "codigoPais"
            Me.DropDownList23.DataBind()
        End With
        Me.DropDownList23.Items.Insert(0, "Seleccione Pais")
    End Sub

    Protected Sub ImageButton8_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton8.Click
        Dim mensajeError As String = Nothing
        Dim huboError As String = "no"
        Me.panelError.Visible = False
        Me.Label15.Text = ""
        '
        If Me.DropDownList23.SelectedIndex = 0 Or Me.DropDownList23.SelectedIndex = -1 Then
            huboError = "si"
            mensajeError = "- Seleccione el pais"
        End If
        ''
        If Me.DropDownList24.SelectedIndex = 0 Or Me.DropDownList24.SelectedIndex = -1 Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "- Seleccione el paquete"
        End If
        '
        '-------------------------------------------
        ' valida la seleccion y configuracion de las promociones
        Dim huboSeleccion As String
        huboSeleccion = validaSeleccion()
        If huboSeleccion = "no" Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "- Debe Seleccionar (Productos, papelerias, premios y equipos) en la configuración del obsequio"
        End If
        '-------------------------------------------

        If huboError = "si" Then
            Me.panelError.Visible = True
            Me.Label15.Text = mensajeError
            Exit Sub
        End If
        '
        grabarObsequio()
        grabarObsequioPais()
        '
        grabarPaqueteProducto()
        grabarPaquetePapeleria()
        grabarPaquetePremio()
        grabarPaqueteEquiposM()
        cargarObsequios()
        nuevo()
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
                        With paquetePremioObs
                            .idPaqPremioObs = 0
                            .idPremio = Me.GridView5.Rows(y).Cells(1).Text
                            .cantPaqPremioObs = cantidad.Text
                            .idObsequio = 0
                            .accionDetallePremioObs = 0
                            .grabarPaquetePremioObs(1)
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
                            With paquetePremioObs
                                .idPaqPremioObs = Me.TextBox8.Text
                                .idPremio = Me.GridView5.Rows(y).Cells(1).Text
                                .cantPaqPremioObs = cantidad.Text
                                .idObsequio = Val(Me.TextBox7.Text)
                                .accionDetallePremioObs = 1
                                .grabarPaquetePremioObs(2)
                            End With
                        End If
                    Else
                        With paquetePremioObs
                            .idPaqPremioObs = Me.TextBox8.Text
                            .idPremio = Me.GridView5.Rows(y).Cells(1).Text
                            .cantPaqPremioObs = 0
                            .idObsequio = Val(Me.TextBox7.Text)
                            .accionDetallePremioObs = 2
                            .grabarPaquetePremioObs(2)
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
                        With paquetePapeleriaObs
                            .idPaqPapeleriaObs = 0
                            .idPapeleria = Me.GridView4.Rows(y).Cells(1).Text
                            .cantPaqPapeleriaObs = cantidad.Text
                            .idObsequio = 0
                            .accionDetallePapeleriaObs = 0
                            .grabarPaquetePapeleriaObs(1)
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
                            With paquetePapeleriaObs
                                .idPaqPapeleriaObs = Me.TextBox8.Text
                                .idPapeleria = Me.GridView4.Rows(y).Cells(1).Text
                                .cantPaqPapeleriaObs = cantidad.Text
                                .idObsequio = Val(Me.TextBox7.Text)
                                .accionDetallePapeleriaObs = 1
                                .grabarPaquetePapeleriaObs(2)
                            End With
                        End If
                    Else
                        With paquetePapeleriaObs
                            .idPaqPapeleriaObs = Me.TextBox8.Text
                            .idPapeleria = Me.GridView4.Rows(y).Cells(1).Text
                            .cantPaqPapeleriaObs = 0
                            .idObsequio = Val(Me.TextBox7.Text)
                            .accionDetallePapeleriaObs = 2
                            .grabarPaquetePapeleriaObs(2)
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
                        With paqueteProductoObs
                            .idPaqProductoObs = 0
                            .idProducto = Me.GridView3.Rows(y).Cells(1).Text
                            .idObsequio = 0
                            .cantPaqProductoObs = cantidad.Text
                            .accionDetalleProductoObs = 0
                            .grabarPaqueteProductoObs(1)
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
                            With paqueteProductoObs
                                .idPaqProductoObs = Val(Me.TextBox7.Text)
                                .idProducto = Me.GridView3.Rows(y).Cells(1).Text
                                .idObsequio = Val(Me.TextBox7.Text)
                                .cantPaqProductoObs = cantidad.Text
                                .accionDetalleProductoObs = 1
                                .grabarPaqueteProductoObs(2)
                            End With
                        End If
                    Else
                        With paqueteProductoObs
                            .idPaqProductoObs = Val(Me.TextBox7.Text)
                            .idProducto = Me.GridView3.Rows(y).Cells(1).Text
                            .idObsequio = Val(Me.TextBox7.Text)
                            .cantPaqProductoObs = 0
                            .accionDetalleProductoObs = 2
                            .grabarPaqueteProductoObs(2)
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
                        With paqueteEquipomObs
                            .idPaqEquipomObs = 0
                            .idEquipom = Me.GridView6.Rows(y).Cells(1).Text
                            .cantPaqEquipomObs = cantidad.Text
                            .idObsequio = Val(Me.TextBox7.Text)
                            .accionDetalleEquipomObs = 0
                            .grabarPaqueteEquipomObs(1)
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
                            With paqueteEquipomObs
                                .idPaqEquipomObs = Me.TextBox8.Text
                                .idEquipom = Me.GridView6.Rows(y).Cells(1).Text
                                .cantPaqEquipomObs = cantidad.Text
                                .idObsequio = Val(Me.TextBox7.Text)
                                .accionDetalleEquipomObs = 1
                                .grabarPaqueteEquipomObs(2)
                            End With
                        End If
                    Else
                        With paqueteEquipomObs
                            .idPaqEquipomObs = Me.TextBox8.Text
                            .idEquipom = Me.GridView6.Rows(y).Cells(1).Text
                            .cantPaqEquipomObs = 0
                            .idObsequio = Val(Me.TextBox7.Text)
                            .accionDetalleEquipomObs = 2
                            .grabarPaqueteEquipomObs(2)
                        End With
                    End If
                End If
            Next
        End If
    End Sub

    Sub grabarObsequio()
        With obsequio
            If Session("accion") = 1 Then
                .idObsequio = 0
            Else
                .idObsequio = Val(Me.TextBox7.Text)
            End If
            .idPaquete = Me.DropDownList24.SelectedValue
            .nombreObsequio = Me.TextBox15.Text
            .grabarObsequio(Session("accion"))
        End With
    End Sub

    Sub grabarObsequioPais()
        With obsequio
            If Session("accion") = 1 Then
                .idObsequioPais = 0
                .idObsequio = 0
            Else
                .idObsequioPais = Val(Me.TextBox8.Text)
                .idObsequio = Val(Me.TextBox8.Text)
            End If
            .idPais = Me.DropDownList23.SelectedValue
            .grabarObsequiopais(Session("accion"))
        End With
    End Sub

    Protected Sub GridView2_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        Me.TextBox7.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(1).Text
        Me.TextBox8.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(3).Text
        Me.TextBox15.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(2).Text
        '
        Me.DropDownList23.SelectedValue = Me.GridView2.Rows(e.NewSelectedIndex).Cells(5).Text
        Me.DropDownList24.SelectedValue = Me.GridView2.Rows(e.NewSelectedIndex).Cells(3).Text
        '--------------------------------------------
        cargarProducto()
        cargarPapelerias()
        cargarPremios()
        cargarEquipos()
        '
        mostrarDetalleProducto()
        mostrarDetallePapeleria()
        mostrarDetallePremios()
        mostrarDetalleEquiposM()
        '--------------------------------------------
        Session("accion") = 2
    End Sub

    Protected Sub ImageButton7_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
        nuevo()
    End Sub

    Sub mostrarDetalleProducto()
        Dim fila As GridViewRow
        Dim y, k As Integer
        Dim tabla As New DataTable
        With paqueteProductoObs
            .idObsequio = Val(Me.TextBox7.Text)
            tabla = .obtenerProductosPorIdObs
            If tabla.Rows.Count <> 0 Then
                For k = 0 To tabla.Rows.Count - 1
                    Dim idProducto As Integer = tabla.Rows(k).Item("idProducto")
                    Dim cantidad As Integer = tabla.Rows(k).Item("cantPaqProductoObs")
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
        With paquetePapeleriaObs
            .idObsequio = Val(Me.TextBox7.Text)
            tabla = .obtenerPapeleriaPorIdObs
            If tabla.Rows.Count <> 0 Then
                For k = 0 To tabla.Rows.Count - 1
                    Dim idPapeleria As Integer = tabla.Rows(k).Item("idPapeleria")
                    Dim cantidad As Integer = tabla.Rows(k).Item("cantPaqPapeleriaObs")
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
        With paquetePremioObs
            .idObsequio = Val(Me.TextBox7.Text)
            tabla = .obtenerPremioPorIdObs
            If tabla.Rows.Count <> 0 Then
                For k = 0 To tabla.Rows.Count - 1
                    Dim idPremio As Integer = tabla.Rows(k).Item("idPremio")
                    Dim cantidad As Integer = tabla.Rows(k).Item("cantPaqPremioObs")
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
        With paqueteEquipomObs
            .idObsequio = Val(Me.TextBox7.Text)
            tabla = .obtenerEquipomPorIdObs
            If tabla.Rows.Count <> 0 Then
                For k = 0 To tabla.Rows.Count - 1
                    Dim idEquiposM As Integer = tabla.Rows(k).Item("idEquipoM")
                    Dim cantidad As Integer = tabla.Rows(k).Item("cantPaqEquipomObs")
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

End Class
