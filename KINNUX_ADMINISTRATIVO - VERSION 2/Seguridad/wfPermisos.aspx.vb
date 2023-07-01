Imports System.Data

Partial Class Seguridad_wfPermisos
    Inherits System.Web.UI.Page

    Dim usuarios As New clsTBUsuarios
    Dim permisos As New clsTBPermiso

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarusuarios()
            cargarusuariosEmpresas()
            cargarUsuariosSucursales()
            cargarOpcionesPais()
            cargarOpcionesMundiales()
            cargarOpcionesSucursales()
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    Sub cargarOpcionesSucursales()
        Dim tabla As New DataTable
        With permisos
            tabla = .opcionesSucursales
            If tabla.Rows.Count <> 0 Then
                Me.GridView5.DataSource = tabla
                Me.GridView5.DataBind()
            Else
                Me.GridView5.DataSource = Nothing
                Me.GridView5.DataBind()
            End If
        End With
    End Sub

    Sub cargarUsuariosSucursales()
        Dim tabla As New DataTable
        With usuarios
            tabla = .obtenerUsuariosSucursales
            If tabla.Rows.Count <> 0 Then
                Me.GridView6.DataSource = tabla
                Me.GridView6.DataBind()
            Else
                Me.GridView6.DataSource = Nothing
                Me.GridView6.DataBind()
            End If
        End With
    End Sub

    Sub cargarOpcionesMundiales()
        Dim tabla As New DataTable
        With permisos
            tabla = .opcionesMundial
            If tabla.Rows.Count <> 0 Then
                Me.GridView4.DataSource = tabla
                Me.GridView4.DataBind()
            Else
                Me.GridView4.DataSource = Nothing
                Me.GridView4.DataBind()
            End If
        End With

    End Sub

    Sub cargarOpcionesPais()
        Dim tabla As New DataTable
        With permisos
            tabla = .opcionesPais
            If tabla.Rows.Count <> 0 Then
                Me.GridView3.DataSource = tabla
                Me.GridView3.DataBind()
            Else
                Me.GridView3.DataSource = Nothing
                Me.GridView3.DataBind()
            End If
        End With
    End Sub

    Sub cargarusuariosEmpresas()
        Dim tabla As New DataTable
        With usuarios
            tabla = .obtenerUsuariosEmpresas
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList3.DataSource = tabla
                Me.DropDownList3.DataTextField = "muestra"
                Me.DropDownList3.DataValueField = "idusuario"
                Me.DropDownList3.DataBind()
                Me.DropDownList3.Items.Insert(0, "Seleccione Usuario")
            Else
                Me.DropDownList3.DataSource = Nothing
                Me.DropDownList3.DataBind()
            End If
        End With
    End Sub

    Sub cargarusuarios()
        Dim tabla As New DataTable
        With usuarios
            tabla = .obtenerUsuarios
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList1.DataSource = tabla
                Me.DropDownList1.DataTextField = "nombrecompletousuario"
                Me.DropDownList1.DataValueField = "idusuario"
                Me.DropDownList1.DataBind()
                Me.DropDownList1.Items.Insert(0, "Seleccione Usuario")
            Else
                Me.DropDownList1.DataSource = Nothing
                Me.DropDownList1.DataBind()
            End If
        End With
    End Sub

    Protected Sub ImageButton8_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton8.Click
        grabarPermisosUsuariosMundiales()
        ClientScript.RegisterStartupScript(Me.GetType(), "myalert", "alert('" + "Permisos grabados en el sistema...!" + "');", True)
        nuevo()
    End Sub

    Sub grabarPermisosUsuariosMundiales()
        Dim seleccionado As String
        Dim y As Integer
        Dim fila As GridViewRow
        For y = 0 To Me.GridView4.Rows.Count - 1
            fila = Me.GridView4.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView4.Rows(y).FindControl("CheckBox2"), CheckBox)
                With permisos
                    .idMenu = Me.GridView4.Rows(y).Cells(0).Text
                    .idSubmenu = Me.GridView4.Rows(y).Cells(2).Text
                    .idusuario = Me.DropDownList1.SelectedValue
                    If c1.Checked = True Then
                        seleccionado = "Si"
                    Else
                        seleccionado = "No"
                    End If
                    .acceso = seleccionado
                    .actualizaPermisosPais()
                End With
            End If
        Next

    End Sub

    Sub nuevo()
        Me.DropDownList1.SelectedIndex = 0
    End Sub

    Protected Sub ImageButton7_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
        nuevo()
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim k As Integer
        Dim fila As GridViewRow
        Dim tabla As New DataTable
        If Me.DropDownList3.SelectedIndex > 0 Then
            With permisos
                For k = 0 To Me.GridView3.Rows.Count - 1
                    fila = Me.GridView3.Rows(k)
                    If fila.RowType = DataControlRowType.DataRow Then
                        Dim c1 As CheckBox = CType(Me.GridView3.Rows(k).FindControl("CheckBox1"), CheckBox)
                        .idusuario = Me.DropDownList3.SelectedValue
                        .idMenu = Me.GridView3.Rows(k).Cells(0).Text
                        .idSubmenu = Me.GridView3.Rows(k).Cells(2).Text
                        tabla = .obtenerAcceso
                        If tabla.Rows.Count <> 0 Then ' si la opcion es encontrada
                            If tabla.Rows(0).Item("acceso") = "Si" Then
                                c1.Checked = True
                            Else
                                c1.Checked = False
                            End If
                        Else
                            c1.Checked = False
                        End If
                    End If
                Next
            End With
        End If
    End Sub

    Protected Sub ImageButton10_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton10.Click
        grabarPermisosUsuariosEmpresas()
        ClientScript.RegisterStartupScript(Me.GetType(), "myalert", "alert('" + "Permisos grabados en el sistema...!" + "');", True)
        nuevoUsuarioEmpresa()
    End Sub

    Sub grabarPermisosUsuariosEmpresas()
        Dim seleccionado As String
        Dim y As Integer
        Dim fila As GridViewRow
        For y = 0 To Me.GridView3.Rows.Count - 1
            fila = Me.GridView3.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                With permisos
                    .idMenu = Me.GridView3.Rows(y).Cells(0).Text
                    .idSubmenu = Me.GridView3.Rows(y).Cells(2).Text
                    .idusuario = Me.DropDownList3.SelectedValue
                    If c1.Checked = True Then
                        seleccionado = "Si"
                    Else
                        seleccionado = "No"
                    End If
                    .acceso = seleccionado
                    .actualizaPermisosPais()
                End With
            End If
        Next
    End Sub

    Sub nuevoUsuarioEmpresa()
        'Me.GridView3.DataSource = Nothing
        'Me.GridView3.DataBind()
        '
        cargarOpcionesPais()
        Me.DropDownList3.SelectedIndex = 0
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim k As Integer
        Dim fila As GridViewRow
        Dim tabla As New DataTable
        If Me.DropDownList1.SelectedIndex > 0 Then
            With permisos
                For k = 0 To Me.GridView4.Rows.Count - 1
                    fila = Me.GridView4.Rows(k)
                    If fila.RowType = DataControlRowType.DataRow Then
                        Dim c1 As CheckBox = CType(Me.GridView4.Rows(k).FindControl("CheckBox2"), CheckBox)
                        .idusuario = Me.DropDownList1.SelectedValue
                        .idMenu = Me.GridView4.Rows(k).Cells(0).Text
                        .idSubmenu = Me.GridView4.Rows(k).Cells(2).Text
                        tabla = .obtenerAcceso
                        If tabla.Rows.Count <> 0 Then ' si la opcion es encontrada
                            If tabla.Rows(0).Item("acceso") = "Si" Then
                                c1.Checked = True
                            Else
                                c1.Checked = False
                            End If
                        Else
                            c1.Checked = False
                        End If
                    End If
                Next
            End With
        End If

    End Sub

    Protected Sub ImageButton12_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton12.Click
        If Me.TextBox1.Text <> "" Then
            grabarPermisosUsuariosSucursales()
            actualizaDatosAdicionales()
            ClientScript.RegisterStartupScript(Me.GetType(), "myalert", "alert('" + "Permisos grabados en el sistema...!" + "');", True)
            nuevoUsuarioSucursales()
        End If
    End Sub

    Sub actualizaDatosAdicionales()
        Dim subeConsignacion As String
        Dim subeTarjeta As String
        Dim abreFechas As String
        '
        If Me.CheckBox4.Checked = True Then
            subeConsignacion = "si"
        Else
            subeConsignacion = "no"
        End If
        '
        If Me.CheckBox5.Checked = True Then
            subeTarjeta = "si"
        Else
            subeTarjeta = "no"
        End If
        '
        If Me.CheckBox6.Checked = True Then
            abreFechas = "si"
        Else
            abreFechas = "no"
        End If
        With usuarios
            .idUsuario = Me.TextBox1.Text
            .actualizaInformacionAdicionalUsuario(subeConsignacion, subeTarjeta, abreFechas)
        End With
    End Sub

    Sub nuevoUsuarioSucursales()
        cargarOpcionesSucursales()
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        '
        Me.CheckBox4.Checked = False
        Me.CheckBox5.Checked = False
        Me.CheckBox6.Checked = False
    End Sub

    Sub grabarPermisosUsuariosSucursales()
        Dim seleccionado As String
        Dim y As Integer
        Dim fila As GridViewRow
        For y = 0 To Me.GridView5.Rows.Count - 1
            fila = Me.GridView5.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView5.Rows(y).FindControl("CheckBox3"), CheckBox)
                With permisos
                    .idMenu = Me.GridView5.Rows(y).Cells(0).Text
                    .idSubmenu = Me.GridView5.Rows(y).Cells(2).Text
                    .idusuario = Me.TextBox1.Text 'Me.DropDownList4.SelectedValue
                    If c1.Checked = True Then
                        seleccionado = "Si"
                    Else
                        seleccionado = "No"
                    End If
                    .acceso = seleccionado
                    '.actualizaPermisosPais()
                    .actualizaPermisosSucursales()
                End With
            End If
        Next
    End Sub

    Protected Sub GridView6_SelectedIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView6.SelectedIndexChanging
        Dim idUsuario As Integer
        Dim k As Integer
        Dim fila As GridViewRow
        Dim tabla As New DataTable
        idUsuario = Me.GridView6.Rows(e.NewSelectedIndex).Cells(1).Text
        Me.TextBox1.Text = idUsuario
        Me.TextBox2.Text = Me.GridView6.Rows(e.NewSelectedIndex).Cells(2).Text
        '
        With usuarios
            .idUsuario = idUsuario
            tabla = .obtenerusuariosPorIdUsuario
            If tabla.Rows.Count <> 0 Then
                If tabla.Rows(0).Item("subeconsignacion") = "si" Then
                    Me.CheckBox4.Checked = True
                Else
                    Me.CheckBox4.Checked = False
                End If
                '
                If tabla.Rows(0).Item("subetarjeta") = "si" Then
                    Me.CheckBox5.Checked = True
                Else
                    Me.CheckBox5.Checked = False
                End If
                '
                If tabla.Rows(0).Item("abrirfecha") = "si" Then
                    Me.CheckBox6.Checked = True
                Else
                    Me.CheckBox6.Checked = False
                End If
            End If
        End With
        With permisos
            For k = 0 To Me.GridView5.Rows.Count - 1
                fila = Me.GridView5.Rows(k)
                If fila.RowType = DataControlRowType.DataRow Then
                    Dim c1 As CheckBox = CType(Me.GridView5.Rows(k).FindControl("CheckBox3"), CheckBox)
                    .idusuario = idUsuario 'Me.DropDownList4.SelectedValue
                    .idMenu = Me.GridView5.Rows(k).Cells(0).Text
                    .idSubmenu = Me.GridView5.Rows(k).Cells(2).Text
                    tabla = .obtenerAcceso
                    If tabla.Rows.Count <> 0 Then ' si la opcion es encontrada
                        If tabla.Rows(0).Item("acceso") = "Si" Then
                            c1.Checked = True
                        Else
                            c1.Checked = False
                        End If
                    Else
                        c1.Checked = False
                    End If
                End If
            Next
        End With
    End Sub
End Class
