Imports System.Data

Partial Class Seguridad_wfUsuarios
    Inherits System.Web.UI.Page

    Dim objOperacione As New clsOperacione
    Dim usuarios As New clsTBUsuarios
    Dim pais As New clsPaise
    Dim empresas As New clsEmpresa
    Dim sucursales As New clsSucursale

    Sub cargarEmpresas()
        Dim tabla As New DataTable
        With empresas
            tabla = .MostrarEmpresaGeneral
            Me.DropDownList3.DataSource = tabla
            Me.DropDownList3.DataTextField = "nombreEmpresa"
            Me.DropDownList3.DataValueField = "idEmpresa"
            Me.DropDownList3.DataBind()
            Me.DropDownList3.Items.Insert(0, "Seleccione La Empresa")
            '
            Me.DropDownList5.DataSource = tabla
            Me.DropDownList5.DataTextField = "nombreEmpresa"
            Me.DropDownList5.DataValueField = "idEmpresa"
            Me.DropDownList5.DataBind()
            Me.DropDownList5.Items.Insert(0, "Seleccione La Empresa")
        End With
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarEmpresas()
            CargarUsuariosMundiales()
            cargarUsuariosEmpresas()
            cargarUsuariosSucursales()
            Nuevo()
            Me.MultiView2.ActiveViewIndex = 0
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub cargarUsuariosSucursales()
        Dim tablaUsuario As New DataTable
        With usuarios
            tablaUsuario = .obtenerUsuariosSucursales
            If tablaUsuario.Rows.Count <> 0 Then
                Me.GridView3.DataSource = tablaUsuario
                Me.GridView3.DataBind()
            Else
                Me.GridView3.DataSource = Nothing
                Me.GridView3.DataBind()
            End If
        End With

    End Sub

    Sub cargarUsuariosEmpresas()
        Dim tablaUsuario As New DataTable
        With usuarios
            tablaUsuario = .obtenerUsuariosEmpresas
            If tablaUsuario.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tablaUsuario
                Me.GridView2.DataBind()
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End With
    End Sub

    Sub CargarUsuariosMundiales()
        Dim tablaUsuario As New DataTable
        With usuarios
            tablaUsuario = .obtenerUsuarios
            If tablaUsuario.Rows.Count <> 0 Then
                Me.GridView1.DataSource = tablaUsuario
                Me.GridView1.DataBind()
            Else
                Me.GridView1.DataSource = Nothing
                Me.GridView1.DataBind()
            End If
        End With
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim huboError As String = "no"
        Me.Label2.Text = ""
        Me.Label3.Text = ""
        Me.Label5.Text = ""
        Me.Label6.Text = ""
        Me.Label7.Text = ""
        '
        If Me.TextBox1.Text = "" Then
            If Me.TextBox2.Text = "" Then
                Me.Label2.Text = "* Requerido"
                huboError = "si"
            End If
            '
            If Me.TextBox3.Text = "" Then
                Me.Label3.Text = "* Requerido"
                huboError = "si"
            End If
            '
            If Me.TextBox4.Text = "" Then
                Me.Label5.Text = "* Requerido"
                huboError = "si"
            End If
            '
            If Me.TextBox3.Text <> Me.TextBox4.Text Then
                Me.Label3.Text = "La clave y la confirmacion no son iguales"
                huboError = "si"
            End If
            '
            If Me.TextBox5.Text = "" Then
                Me.Label6.Text = "* Requerido"
                huboError = "si"
            End If
            '
            If Me.TextBox6.Text = "" Then
                Me.Label7.Text = "* Requerido"
                huboError = "si"
            End If
            '
            If huboError = "si" Then
                Exit Sub
            End If
        End If
        '
        Grabar()
        CargarUsuariosMundiales()
        mostrarVentana()
        Nuevo()
    End Sub

    Sub mostrarVentana()
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('Usuario Grabado Satisfactoriamente...!');", True)
    End Sub

    Sub Grabar()
        Dim accion As Integer
        Dim claveEncriptada As String
        With usuarios
            If Me.TextBox1.Text = "" Then
                .idUsuario = 0
                accion = 1
            Else
                .idUsuario = Me.TextBox1.Text
                accion = 2
            End If
            .nombreUsuario = Me.TextBox2.Text
            'claveEncriptada = .encriptarClave(Me.TextBox3.Text)
            .claveUsuario = Me.TextBox3.Text 'claveEncriptada
            .nombreCompletoUsuario = Me.TextBox5.Text.ToUpper
            .emailUsuario = Me.TextBox6.Text.ToLower
            .direccionUsuario = Me.TextBox7.Text.ToUpper
            .telefonoUsuario = Me.TextBox8.Text
            .idSucursal = 0
            .tipoUsuario = 1
            .idPais = 0
            .clave = Me.TextBox3.Text
            .estadoUsuario = Me.DropDownList2.SelectedValue
            .grabarUsuario(accion)
        End With
    End Sub

    Protected Sub ImageButton5_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton5.Click
        nuevo()
    End Sub

    Sub Nuevo()
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox4.Text = ""
        Me.TextBox5.Text = ""
        Me.TextBox6.Text = ""
        Me.TextBox7.Text = ""
        Me.TextBox8.Text = ""
        '
        Me.Label2.Text = ""
        Me.Label3.Text = ""
        Me.Label5.Text = ""
        Me.Label6.Text = ""
        Me.Label7.Text = ""
        '
        Me.TextBox5.Focus()
        Session("accion") = 1
    End Sub

    Protected Sub GridView1_RowDataBound(sender As Object, e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView1.RowDataBound
        Dim fila As GridViewRow
        'Dim y As Integer
        Dim tabla As New DataTable
        fila = e.Row
        If e.Row.RowType = DataControlRowType.DataRow Then
            If e.Row.Cells(4).Text = "Eliminado" Then
                e.Row.ForeColor = Drawing.Color.Red
                'If fila.RowType = DataControlRowType.DataRow Then
                '    Dim eliminar As CheckBox = CType(e.Row.FindControl("CheckBox1"), CheckBox)
                '    eliminar.Visible = False
                'End If
            End If
        End If
    End Sub

    Protected Sub GridView1_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView1.SelectedIndexChanging
        Me.Label2.Text = ""
        Me.Label3.Text = ""
        Me.Label5.Text = ""
        Me.Label6.Text = ""
        Me.Label7.Text = ""
        '
        Me.TextBox1.Text = Me.GridView1.Rows(e.NewSelectedIndex).Cells(1).Text
        mostrarDatosUsuarioMundial(Me.GridView1.Rows(e.NewSelectedIndex).Cells(1).Text)
        Me.TextBox2.Focus()
    End Sub

    Sub mostrarDatosUsuarioMundial(ByVal idusuario As Integer)
        Dim tabla As New DataTable
        With usuarios
            .idUsuario = idusuario
            tabla = .obtenerusuariosPorIdUsuario
            If tabla.Rows.Count <> 0 Then
                ' usuario mundial tipoUsuario=1
                Me.TextBox1.Text = tabla.Rows(0).Item("idUsuario")
                Me.TextBox5.Text = tabla.Rows(0).Item("nombrecompletoUsuario")
                Me.TextBox7.Text = tabla.Rows(0).Item("direccionusuario")
                Me.TextBox8.Text = tabla.Rows(0).Item("telefonoUsuario")
                Me.TextBox6.Text = tabla.Rows(0).Item("emailUsuario")
                Me.TextBox2.Text = tabla.Rows(0).Item("nombreUsuario")
                Me.DropDownList2.SelectedValue = tabla.Rows(0).Item("estadoUsuario")
            End If
        End With
    End Sub

    Sub buscarUsuarioporIdAfiliado()
        Dim tabla As New DataTable
        Me.Label2.Text = ""
        Me.Label3.Text = ""
        Me.Label5.Text = ""
        With usuarios
            If tabla.Rows.Count <> 0 Then
                '
                Me.TextBox1.Text = tabla.Rows(0).Item("idusuario")
                Me.TextBox2.Text = tabla.Rows(0).Item("nombreusuario")
                Me.TextBox5.Text = tabla.Rows(0).Item("nombrecompletousuario")
                Me.TextBox6.Text = tabla.Rows(0).Item("emailusuario")
                Me.DropDownList2.SelectedValue = tabla.Rows(0).Item("estado")
                Session("accion") = 2
            Else
                Me.TextBox1.Text = ""
                Me.TextBox2.Text = "No Encontrado..."
                Me.TextBox5.Text = ""
                Me.TextBox6.Text = ""
                Session("accion") = 1
            End If

        End With
    End Sub

    Protected Sub ImageButton7_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
        Dim huboError As String = "no"
        Me.Label10.Text = ""
        Me.Label11.Text = ""
        Me.Label12.Text = ""
        Me.Label13.Text = ""
        Me.Label14.Text = ""
        '
        If Session("accion") = 1 Then
            If Me.TextBox10.Text = "" Then
                Me.Label10.Text = "* Requerido"
                huboError = "si"
            End If
            '
            If Me.TextBox13.Text = "" Then
                Me.Label11.Text = "* Requerido"
                huboError = "si"
            End If
            '
            If Me.TextBox14.Text = "" Then
                Me.Label12.Text = "* Requerido"
                huboError = "si"
            End If
            '
            If Me.TextBox15.Text <> Me.TextBox16.Text Then
                Me.Label3.Text = "La clave y la confirmacion no son iguales"
                huboError = "si"
            End If
            '
            If Me.TextBox15.Text = "" Then
                Me.Label13.Text = "* Requerido"
                huboError = "si"
            End If
            '
            If Me.TextBox16.Text = "" Then
                Me.Label14.Text = "* Requerido"
                huboError = "si"
            End If
            '
            If huboError = "si" Then
                Exit Sub
            End If
        End If
        '
        GrabarUsuarioPais()
        cargarUsuariosEmpresas()
        mostrarVentana()
        NuevoUsuarioPais()
    End Sub

    Sub NuevoUsuarioPais()
        Me.TextBox9.Text = ""
        Me.TextBox10.Text = ""
        Me.TextBox11.Text = ""
        Me.TextBox12.Text = ""
        Me.TextBox13.Text = ""
        Me.TextBox14.Text = ""
        Me.TextBox15.Text = ""
        Me.TextBox16.Text = ""
        '
        Me.Label10.Text = ""
        Me.Label11.Text = ""
        Me.Label12.Text = ""
        Me.Label13.Text = ""
        Me.Label14.Text = ""
        '
        Me.DropDownList3.SelectedIndex = 0
        Me.TextBox10.Focus()
        Session("accionUsuarioPais") = 1
    End Sub

    Sub GrabarUsuarioPais()
        'Dim claveEncriptada As String
        Dim accion As Integer
        With usuarios
            If Me.TextBox9.Text = "" Then
                .idUsuario = 0
                accion = 1
            Else
                .idUsuario = Me.TextBox9.Text
                accion = 2
            End If
            .nombreUsuario = Me.TextBox14.Text
            'claveEncriptada = .encriptarClave(Me.TextBox15.Text)
            .claveUsuario = Me.TextBox15.Text 'claveEncriptada
            .nombreCompletoUsuario = Me.TextBox10.Text.ToUpper
            .emailUsuario = Me.TextBox13.Text.ToLower
            .direccionUsuario = Me.TextBox11.Text.ToUpper
            .telefonoUsuario = Me.TextBox12.Text
            .idSucursal = 0
            .tipoUsuario = 2
            .idPais = Me.DropDownList3.SelectedValue
            .estadoUsuario = Me.DropDownList4.SelectedValue
            .clave = Me.TextBox15.Text
            .grabarUsuario(accion)
        End With
    End Sub

    Protected Sub GridView2_RowDataBound(sender As Object, e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView2.RowDataBound
        Dim fila As GridViewRow
        Dim tabla As New DataTable
        fila = e.Row
        If e.Row.RowType = DataControlRowType.DataRow Then
            If e.Row.Cells(4).Text = "Eliminado" Then
                e.Row.ForeColor = Drawing.Color.Red
                'If fila.RowType = DataControlRowType.DataRow Then
                '    Dim eliminar As CheckBox = CType(e.Row.FindControl("CheckBox1"), CheckBox)
                '    eliminar.Visible = False
                'End If
            End If
        End If
    End Sub

    Protected Sub GridView2_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        Me.Label10.Text = ""
        Me.Label11.Text = ""
        Me.Label12.Text = ""
        Me.Label13.Text = ""
        Me.Label14.Text = ""
        '
        Me.TextBox9.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(1).Text
        mostrarDatosUsuarioPais(Me.GridView2.Rows(e.NewSelectedIndex).Cells(1).Text)
        Me.TextBox10.Focus()
    End Sub

    Sub mostrarDatosUsuarioPais(ByVal idusuario As Integer)
        Dim tabla As New DataTable
        With usuarios
            .idUsuario = idusuario
            tabla = .obtenerusuariosPorIdUsuario
            If tabla.Rows.Count <> 0 Then
                Me.TextBox9.Text = tabla.Rows(0).Item("idUsuario")
                Me.TextBox10.Text = tabla.Rows(0).Item("nombrecompletoUsuario")
                Me.TextBox11.Text = tabla.Rows(0).Item("direccionusuario")
                Me.TextBox12.Text = tabla.Rows(0).Item("telefonoUsuario")
                Me.TextBox13.Text = tabla.Rows(0).Item("emailUsuario")
                Me.TextBox14.Text = tabla.Rows(0).Item("nombreUsuario")
                Me.DropDownList4.SelectedValue = tabla.Rows(0).Item("estadoUsuario")
                Me.DropDownList3.SelectedValue = tabla.Rows(0).Item("idPais")
            End If
        End With
    End Sub

    Protected Sub ImageButton6_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton6.Click
        NuevoUsuarioPais()
    End Sub

    Protected Sub ImageButton8_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton8.Click
        Me.MultiView2.ActiveViewIndex = 0
        Nuevo()
    End Sub

    Protected Sub ImageButton9_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
        Me.MultiView2.ActiveViewIndex = 1
        NuevoUsuarioPais()
    End Sub

    Protected Sub ImageButton10_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton10.Click
        Me.MultiView2.ActiveViewIndex = 2
        NuevoUsuarioPunto()
    End Sub

    Protected Sub DropDownList5_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles DropDownList5.SelectedIndexChanged
        If Me.DropDownList5.SelectedIndex > 0 Then
            cargarSucursales()
        End If
    End Sub

    Sub cargarSucursales()
        Dim tabla As New DataTable
        With sucursales
            .idEmpresa = Me.DropDownList5.SelectedValue
            tabla = .obtenerSucursalePorEmpresa
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList7.DataSource = tabla
                Me.DropDownList7.DataTextField = "nombresucursal"
                Me.DropDownList7.DataValueField = "idsucursal"
                Me.DropDownList7.DataBind()
            Else
                Me.DropDownList7.DataSource = Nothing
                Me.DropDownList7.DataBind()
            End If
            Me.DropDownList7.Items.Insert(0, "Seleccione Sucursal")
        End With
    End Sub

    Protected Sub ImageButton12_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton12.Click
        Dim huboError As String = "no"
        Me.Label15.Text = ""
        Me.Label16.Text = ""
        Me.Label17.Text = ""
        Me.Label18.Text = ""
        Me.Label19.Text = ""
        Me.Label20.Text = ""
        Me.Label21.Text = ""
        '
        If Me.TextBox17.Text = "" Then
            If Me.TextBox18.Text = "" Then
                Me.Label15.Text = "* Requerido"
                huboError = "si"
            End If
            '
            If Me.TextBox21.Text = "" Then
                Me.Label16.Text = "* Requerido"
                huboError = "si"
            End If
            '
            If Me.DropDownList5.SelectedIndex = 0 Or Me.DropDownList5.SelectedIndex = -1 Then
                Me.Label20.Text = "* Requerido"
                huboError = "si"
            End If
            '
            If Me.DropDownList7.SelectedIndex = 0 Or Me.DropDownList7.SelectedIndex = -1 Then
                Me.Label21.Text = "* Requerido"
                huboError = "si"
            End If
            '
            If Me.TextBox22.Text = "" Then
                Me.Label17.Text = "* Requerido"
                huboError = "si"
            End If
            '
            If Me.TextBox23.Text = "" Then
                Me.Label18.Text = "* Requerido"
                huboError = "si"
            End If
            '
            If Me.TextBox23.Text <> Me.TextBox24.Text Then
                Me.Label18.Text = "* La clave y su confirmacion no coinciden"
                huboError = "si"
            End If
            '
            If Me.TextBox24.Text = "" Then
                Me.Label19.Text = "* Requerido"
                huboError = "si"
            End If
            '
            If huboError = "si" Then
                Exit Sub
            End If
        End If
        '
        GrabarUsuarioPunto()
        cargarUsuariosSucursales()
        mostrarVentana()
        NuevoUsuarioPunto()
    End Sub

    Sub GrabarUsuarioPunto()
        'Dim claveEncriptada As String
        Dim a As String
        With usuarios
            If Me.TextBox17.Text = "" Then
                .idUsuario = 0
                a = 1
            Else
                .idUsuario = Val(Me.TextBox17.Text)
                a = 2
            End If
            .nombreUsuario = Me.TextBox22.Text
            'claveEncriptada = .encriptarClave(Me.TextBox15.Text)
            .claveUsuario = Me.TextBox23.Text 'claveEncriptada
            .nombreCompletoUsuario = Me.TextBox18.Text.ToUpper
            .emailUsuario = Me.TextBox21.Text.ToLower
            .direccionUsuario = Me.TextBox19.Text.ToUpper
            .telefonoUsuario = Me.TextBox20.Text
            .idPais = Me.DropDownList5.SelectedValue
            .idSucursal = Me.DropDownList7.SelectedValue
            .clave = Me.TextBox23.Text
            .tipoUsuario = 3
            .estadoUsuario = Me.DropDownList6.SelectedValue
            .grabarUsuario(a)
        End With
    End Sub

    Sub NuevoUsuarioPunto()
        Me.TextBox17.Text = ""
        Me.TextBox18.Text = ""
        Me.TextBox19.Text = ""
        Me.TextBox20.Text = ""
        Me.TextBox21.Text = ""
        Me.TextBox22.Text = ""
        Me.TextBox23.Text = ""
        Me.TextBox24.Text = ""
        Me.TextBox17.Text = ""
        '
        Me.Label15.Text = ""
        Me.Label16.Text = ""
        Me.Label17.Text = ""
        Me.Label18.Text = ""
        Me.Label19.Text = ""
        Me.Label20.Text = ""
        Me.Label21.Text = ""
        '
        Me.DropDownList5.SelectedIndex = 0
        Me.TextBox18.Focus()
    End Sub

    Protected Sub ImageButton11_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton11.Click
        NuevoUsuarioPunto()
    End Sub

    Protected Sub GridView3_RowDataBound(sender As Object, e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView3.RowDataBound
        Dim fila As GridViewRow
        Dim tabla As New DataTable
        fila = e.Row
        If e.Row.RowType = DataControlRowType.DataRow Then
            If e.Row.Cells(4).Text = "Eliminado" Then
                e.Row.ForeColor = Drawing.Color.Red
                'If fila.RowType = DataControlRowType.DataRow Then
                '    Dim eliminar As CheckBox = CType(e.Row.FindControl("CheckBox1"), CheckBox)
                '    eliminar.Visible = False
                'End If
            End If
        End If
    End Sub

    Protected Sub GridView3_SelectedIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView3.SelectedIndexChanging
        Me.Label15.Text = ""
        Me.Label16.Text = ""
        Me.Label17.Text = ""
        Me.Label18.Text = ""
        Me.Label19.Text = ""
        Me.Label20.Text = ""
        Me.Label21.Text = ""
        '
        Me.TextBox17.Text = Me.GridView3.Rows(e.NewSelectedIndex).Cells(1).Text
        mostrarDatosUsuarioPunto(Me.GridView3.Rows(e.NewSelectedIndex).Cells(1).Text)
        Me.TextBox18.Focus()
    End Sub

    Sub mostrarDatosUsuarioPunto(ByVal idusuario As Integer)
        Dim tabla As New DataTable
        With usuarios
            .idUsuario = idusuario
            tabla = .obtenerusuariosPorIdUsuario
            If tabla.Rows.Count <> 0 Then
                Me.TextBox17.Text = tabla.Rows(0).Item("idUsuario")
                Me.TextBox18.Text = tabla.Rows(0).Item("nombrecompletoUsuario")
                Me.TextBox19.Text = tabla.Rows(0).Item("direccionusuario")
                Me.TextBox20.Text = tabla.Rows(0).Item("telefonoUsuario")
                Me.TextBox21.Text = tabla.Rows(0).Item("emailUsuario")
                Me.TextBox22.Text = tabla.Rows(0).Item("nombreUsuario")
                Me.DropDownList6.SelectedValue = tabla.Rows(0).Item("estadoUsuario")
                Me.DropDownList5.SelectedValue = tabla.Rows(0).Item("idPais")
                cargarSucursales()
                Me.DropDownList7.SelectedValue = tabla.Rows(0).Item("idSucursal")
            End If
        End With
    End Sub
End Class
