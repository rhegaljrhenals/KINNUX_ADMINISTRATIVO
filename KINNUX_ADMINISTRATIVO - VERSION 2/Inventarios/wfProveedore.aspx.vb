Imports System.Data
Imports System.IO


Partial Class Basicos_wfProveedore
    Inherits System.Web.UI.Page

    Dim objOperacione As New clsOperacione
    Dim proveedore As New clsProveedore

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            CargarProveedore()
            Nuevo()
            mostrarNumeroDeRegistro()
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub mostrarNumeroDeRegistro()
        Me.Label10.Text = "Numero De Registros: " & Me.GridView1.Rows.Count
    End Sub

    Sub CargarProveedore()
        Dim tabla As New DataTable
        With proveedore
            tabla = .obtieneProveedoreTodos
            Me.GridView1.DataSource = tabla
            Me.GridView1.DataBind()
        End With
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim huboError As String = "no"
        Me.Label1.Text = ""
        Me.Label2.Text = ""
        Me.Label3.Text = ""
        Me.Label4.Text = ""
        Me.Label5.Text = ""
        Me.Label9.Text = ""
        Me.Label7.Text = ""
        Me.Label8.Text = ""
        '
        If Me.TextBox8.Text = "" Then
            Me.Label9.Text = "* requerido"
            huboError = "si"
        End If
        '
        If Me.TextBox2.Text = "" Then
            Me.Label2.Text = "* requerido"
            huboError = "si"
        End If
        '
        If Me.TextBox3.Text = "" Then
            Me.Label3.Text = "* requerido"
            huboError = "si"
        End If
        '
        If Me.TextBox4.Text = "" Then
            Me.Label4.Text = "* requerido"
            huboError = "si"
        End If
        '
        If Me.TextBox5.Text = "" Then
            Me.Label5.Text = "* requerido"
            huboError = "si"
        End If
        '
        If huboError = "si" Then
            Exit Sub
        End If
        '
        Grabar()
        CargarProveedore()
        Nuevo()
        Me.Label1.Text = "Registro Actualizado En El Sistema...!"
        mostrarNumeroDeRegistro()
    End Sub

    Sub Grabar()
        With proveedore
            If Session("accion") = 1 Then
                .idProveedor = 0
            Else
                .idProveedor = Me.TextBox1.Text
            End If
            .codigoProveedor = Me.TextBox8.Text
            .nombreProveedor = Me.TextBox2.Text
            .direccionProveedor = Me.TextBox3.Text
            .telefonoProveedor = Me.TextBox4.Text
            .emailProveedor = Me.TextBox5.Text
            .dptoProveedor = Me.TextBox6.Text
            .ciudadProveedor = Me.TextBox7.Text
            .estadoProveedor = Me.DropDownList1.SelectedValue
            .actualizarProveedor(Session("accion"))
        End With
    End Sub

    Protected Sub ImageButton5_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton5.Click
        Nuevo()
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
        Me.Label1.Text = ""
        Me.Label2.Text = ""
        Me.Label3.Text = ""
        Me.Label4.Text = ""
        Me.Label5.Text = ""
        Me.Label9.Text = ""
        '
        Me.TextBox8.Focus()
        Session("accion") = 1
    End Sub

    Protected Sub GridView1_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView1.SelectedIndexChanging
        Me.Label1.Text = ""
        Me.Label2.Text = ""
        Me.Label3.Text = ""
        Me.Label4.Text = ""
        Me.Label5.Text = ""
        Me.Label9.Text = ""
        '
        Me.TextBox1.Text = Me.GridView1.Rows(e.NewSelectedIndex).Cells(1).Text
        MostrarProveedorPorId()
        Session("accion") = 2
    End Sub

    Sub MostrarProveedorPorId()
        Dim tablaEmpresa As New DataTable
        With proveedore
            .idProveedor = Me.TextBox1.Text
            tablaEmpresa = .obtieneProveedorePorId
            Me.TextBox2.Text = tablaEmpresa.Rows(0).Item("nombreProveedor")
            Me.TextBox3.Text = tablaEmpresa.Rows(0).Item("direccionProveedor")
            Me.TextBox4.Text = tablaEmpresa.Rows(0).Item("telefonoProveedor")
            Me.TextBox5.Text = tablaEmpresa.Rows(0).Item("emailProveedor")
            Me.TextBox6.Text = tablaEmpresa.Rows(0).Item("dptoProveedor")
            Me.TextBox7.Text = tablaEmpresa.Rows(0).Item("ciudadProveedor")
            Me.TextBox8.Text = tablaEmpresa.Rows(0).Item("codigoProveedor")
            Me.DropDownList1.SelectedValue = tablaEmpresa.Rows(0).Item("estadoProveedor")
            '
        End With
    End Sub
End Class
