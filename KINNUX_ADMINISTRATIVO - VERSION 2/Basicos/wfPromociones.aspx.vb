Imports System.Data

Partial Class Basicos_wfPromociones
    Inherits System.Web.UI.Page

    Dim pais As New clsPaise
    Dim productos As New clsProducto
    Dim papelerias As New clsPapeleria
    Dim paquetes As New clsPaquete   
    Dim premios As New clsPremio
    Dim equipoM As New clsEquipos
    Dim promociones As New clsPromocion
    Dim paqueteProductoPromocion As New clsPaqueteProductoPromocion
    Dim paquetePapeleriaProm As New clsPaquetePapeleriaProm
    Dim paquetePremioProm As New clsPaquetePremioProm
    Dim paqueteEquipomProm As New clsPaqueteEquipomProm


    Protected Sub DropDownList23_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList23.SelectedIndexChanged
        If Me.DropDownList23.SelectedIndex > 0 Then
            cargarProducto()
            cargarPapelerias()
            cargarPremios()
            cargarEquipos()
        End If
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
            cargarPromociones()
            nuevo()
            Me.panelError.Visible = False
            Me.TabContainer1.ActiveTabIndex = 0
        End If
        If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
            Response.Redirect("~/Default.aspx")
        End If

    End Sub

    Sub cargarPromociones()
        Dim tabla As New DataTable
        With promociones
            tabla = .obtenerPromociones
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
        Me.DropDownList23.SelectedIndex = 0
        Me.DropDownList24.SelectedIndex = 0
        Me.TextBox15.Text = ""
        Me.TextBox16.Text = ""
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
        If Me.TextBox15.Text = "" Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "- Seleccione la fecha Inicial"
        End If
        '
        If Me.TextBox16.Text = "" Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "- Seleccione la fecha final"
        End If
        '
        If Me.DropDownList24.SelectedIndex = 0 Or Me.DropDownList24.SelectedIndex = -1 Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "- Seleccione el paquete"
        End If
        '
        '-------------------------------------------
        ' valida la seleccion y configuracion de las promociones
        Dim huboSeleccion As String
        huboSeleccion = validaSeleccion
        If huboSeleccion = "no" Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "- Debe Seleccionar (Productos, papelerias, premios y equipos) en la promocion"
        End If
        '-------------------------------------------

        If huboError = "si" Then
            Me.panelError.Visible = True
            Me.Label15.Text = mensajeError
            Exit Sub
        End If
        '
        grabarPromocion()
        grabarPromocionPais()
        grabarPaqueteProducto()
        grabarPaquetePapeleria()
        grabarPaquetePremio()
        grabarPaqueteEquiposM()
        cargarPromociones()
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
                        With paquetePremioProm
                            .idPaqPremioProm = 0
                            .idPremio = Me.GridView5.Rows(y).Cells(1).Text
                            .cantPaqPremioProm = cantidad.Text
                            .idPromocion = 0
                            .accionDetallePremioProm = 0
                            .grabarPaquetePremioProm(1)
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
                            With paquetePremioProm
                                .idPaqPremioProm = Me.TextBox8.Text
                                .idPremio = Me.GridView5.Rows(y).Cells(1).Text
                                .cantPaqPremioProm = cantidad.Text
                                .idPromocion = Val(Me.TextBox7.Text)
                                .accionDetallePremioProm = 1
                                .grabarPaquetePremioProm(2)
                            End With
                        End If
                    Else
                        With paquetePremioProm
                            .idPaqPremioProm = Me.TextBox8.Text
                            .idPremio = Me.GridView5.Rows(y).Cells(1).Text
                            .cantPaqPremioProm = 0
                            .idPromocion = Val(Me.TextBox7.Text)
                            .accionDetallePremioProm = 2
                            .grabarPaquetePremioProm(2)
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
                        With paquetePapeleriaProm
                            .idPaqPapeleriaProm = 0
                            .idPapeleria = Me.GridView4.Rows(y).Cells(1).Text
                            .cantPaqPapeleriaProm = cantidad.Text
                            .idPromocion = 0
                            .accionDetallePapeleriaProm = 0
                            .grabarPaquetePapeleriaProm(1)
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
                            With paquetePapeleriaProm
                                .idPaqPapeleriaProm = Me.TextBox8.Text
                                .idPapeleria = Me.GridView4.Rows(y).Cells(1).Text
                                .cantPaqPapeleriaProm = cantidad.Text
                                .idPromocion = Val(Me.TextBox7.Text)
                                .accionDetallePapeleriaProm = 1
                                .grabarPaquetePapeleriaProm(2)
                            End With
                        End If
                    Else
                        With paquetePapeleriaProm
                            .idPaqPapeleriaProm = Me.TextBox8.Text
                            .idPapeleria = Me.GridView4.Rows(y).Cells(1).Text
                            .cantPaqPapeleriaProm = 0
                            .idPromocion = Val(Me.TextBox7.Text)
                            .accionDetallePapeleriaProm = 2
                            .grabarPaquetePapeleriaProm(2)
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
                        With paqueteProductoPromocion
                            .idPaqProductoProm = 0
                            .idProducto = Me.GridView3.Rows(y).Cells(1).Text
                            .idPromocion = 0
                            .cantPaqProductoProm = cantidad.Text
                            .accionDetalleProductoProm = 0
                            .grabarPaqueteProductoProm(1)
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
                            With paqueteProductoPromocion
                                .idPaqProductoProm = 0
                                .idProducto = Me.GridView3.Rows(y).Cells(1).Text
                                .idPromocion = Val(Me.TextBox7.Text)
                                .cantPaqProductoProm = cantidad.Text
                                .accionDetalleProductoProm = 1
                                .grabarPaqueteProductoProm(2)
                            End With
                        End If
                    Else
                        With paqueteProductoPromocion
                            .idPaqProductoProm = Me.TextBox8.Text
                            .idProducto = Me.GridView3.Rows(y).Cells(1).Text
                            .idPromocion = Val(Me.TextBox7.Text)
                            .cantPaqProductoProm = 0
                            .accionDetalleProductoProm = 2
                            .grabarPaqueteProductoProm(2)
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
                        With paqueteEquipomProm
                            .idPaqEquipomProm = 0
                            .idEquipom = Me.GridView6.Rows(y).Cells(1).Text
                            .cantPaqEquipomProm = cantidad.Text
                            .idPromocion = Val(Me.TextBox7.Text)
                            .accionDetalleEquipomProm = 0
                            .grabarPaqueteEquipomProm(1)
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
                            With paqueteEquipomProm
                                .idPaqEquipomProm = Me.TextBox8.Text
                                .idEquipom = Me.GridView6.Rows(y).Cells(1).Text
                                .cantPaqEquipomProm = cantidad.Text
                                .idPromocion = Val(Me.TextBox7.Text)
                                .accionDetalleEquipomProm = 1
                                .grabarPaqueteEquipomProm(2)
                            End With
                        End If
                    Else
                        With paqueteEquipomProm
                            .idPaqEquipomProm = Me.TextBox8.Text
                            .idEquipom = Me.GridView6.Rows(y).Cells(1).Text
                            .cantPaqEquipomProm = 0
                            .idPromocion = Val(Me.TextBox7.Text)
                            .accionDetalleEquipomProm = 2
                            .grabarPaqueteEquipomProm(2)
                        End With
                    End If
                End If
            Next
        End If
    End Sub

    Sub grabarPromocion()
        With promociones
            If Session("accion") = 1 Then
                .idPromocion = 0
            Else
                .idPromocion = Val(Me.TextBox7.Text)
            End If
            .idPaquete = Me.DropDownList24.SelectedValue
            .promocionFechaInicial = Me.TextBox15.Text
            .promocionFechaFinal = Me.TextBox16.Text
            .grabarPromocion(Session("accion"))
        End With
    End Sub

    Sub grabarPromocionPais()
        With promociones
            If Session("accion") = 1 Then
                .idPromocionPais = 0
                .idPromocion = 0
            Else
                .idPromocionPais = Val(Me.TextBox8.Text)
                .idPromocion = Val(Me.TextBox8.Text)
            End If
            .idPais = Me.DropDownList23.SelectedValue
            .idPais = Me.DropDownList23.SelectedValue
            .grabarPromocionpais(Session("accion"))
        End With
    End Sub

    Protected Sub GridView2_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        Me.TextBox7.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(1).Text
        Me.TextBox8.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(4).Text
        '
        Me.TextBox15.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(2).Text
        Me.TextBox16.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(3).Text
        '
        Me.DropDownList23.SelectedValue = Me.GridView2.Rows(e.NewSelectedIndex).Cells(5).Text
        Me.DropDownList24.SelectedValue = Me.GridView2.Rows(e.NewSelectedIndex).Cells(7).Text

        'Me.TextBox1.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(2).Text
        'Me.TextBox3.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(3).Text
        'Me.TextBox9.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(5).Text
        'Me.TextBox10.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(6).Text
        ''
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
        With paqueteProductoPromocion
            .idPromocion = Val(Me.TextBox7.Text)
            tabla = .obtenerProductosPorIdPromocion
            If tabla.Rows.Count <> 0 Then
                For k = 0 To tabla.Rows.Count - 1
                    Dim idProducto As Integer = tabla.Rows(k).Item("idProducto")
                    Dim cantidad As Integer = tabla.Rows(k).Item("cantPaqProductoProm")
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
        With paquetePapeleriaProm
            .idPromocion = Val(Me.TextBox7.Text)
            tabla = .obtenerPapeleriaPorIdPromocion
            If tabla.Rows.Count <> 0 Then
                For k = 0 To tabla.Rows.Count - 1
                    Dim idPapeleria As Integer = tabla.Rows(k).Item("idPapeleria")
                    Dim cantidad As Integer = tabla.Rows(k).Item("cantPaqPapeleriaProm")
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
        With paquetePremioProm
            .idPromocion = Val(Me.TextBox7.Text)
            tabla = .obtenerPapeleriaPorIdPromocion
            If tabla.Rows.Count <> 0 Then
                For k = 0 To tabla.Rows.Count - 1
                    Dim idPremio As Integer = tabla.Rows(k).Item("idPremio")
                    Dim cantidad As Integer = tabla.Rows(k).Item("cantPaqPremioProm")
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
        With paqueteEquipomProm
            .idPromocion = Val(Me.TextBox7.Text)
            tabla = .obtenerEquipomPorIdPromocion
            If tabla.Rows.Count <> 0 Then
                For k = 0 To tabla.Rows.Count - 1
                    Dim idEquiposM As Integer = tabla.Rows(k).Item("idEquipoM")
                    Dim cantidad As Integer = tabla.Rows(k).Item("cantPaqEquipoMProm")
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
