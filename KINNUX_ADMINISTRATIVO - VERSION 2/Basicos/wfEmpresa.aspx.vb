Imports System.Data
Imports System.IO


Partial Class Basicos_wfEmpresa
    Inherits System.Web.UI.Page

    Dim objOperacione As New clsOperacione
    Dim paise As New clsPaise
    Dim empresa As New clsEmpresa


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            CargarEmpresa()
            CargarPais()
            Nuevo()
            mostrarNumeroDeRegistro()
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    Sub mostrarNumeroDeRegistro()
        Me.Label7.Text = "Numero De Registros: " & Me.GridView1.Rows.Count
    End Sub

    Sub CargarPais()
        Dim tablaPaise As New DataTable
        With paise
            tablaPaise = .MostrarPaise
            Me.DropDownList2.DataSource = tablaPaise
            Me.DropDownList2.DataTextField = "nombrePais"
            Me.DropDownList2.DataValueField = "codigoPais"
            Me.DropDownList2.DataBind()
            Me.DropDownList2.Items.Insert(0, "Seleccione Pais")
        End With
    End Sub

    Sub CargarEmpresa()
        Dim tablaEmpresa As New DataTable
        With empresa
            tablaEmpresa = .MostrarEmpresaGeneral
            Me.GridView1.DataSource = tablaEmpresa
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
        Me.Label6.Text = ""
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
        If Me.DropDownList2.SelectedIndex = 0 Then
            Me.Label6.Text = "* Selecione el pais"
            huboError = "si"
        End If
        '
        If huboError = "si" Then
            Exit Sub
        End If
        '
        Grabar()
        CargarEmpresa()
        mostrarVentana()
        Nuevo()
        Me.Label1.Text = "Registro Actualizado En El Sistema...!"
        mostrarNumeroDeRegistro()
    End Sub

    Sub mostrarVentana()
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('Empresa Registrada En El Sistema...!');", True)
    End Sub


    Sub Grabar()
        With empresa
            If Session("accion") = 1 Then
                .IdEmpresa = 0
            Else
                .IdEmpresa = Me.TextBox1.Text
            End If
            .NombreEmpresa = Me.TextBox2.Text.ToUpper
            .DireccionEmpresa = Me.TextBox3.Text.ToUpper
            .TelefonoEmpresa = Me.TextBox4.Text.ToUpper
            .RepresentanteEmpresa = Me.TextBox5.Text.ToUpper
            .IdPais = Me.DropDownList2.SelectedValue
            .EstadoEmpresa = Me.DropDownList1.SelectedValue
            .GrabarEmpresa(Session("accion"))
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
        '
        Me.Label1.Text = ""
        Me.Label2.Text = ""
        Me.Label3.Text = ""
        Me.Label4.Text = ""
        Me.Label5.Text = ""
        Me.Label6.Text = ""
        '
        Me.DropDownList2.SelectedIndex = 0
        Me.TextBox2.Focus()
        Session("accion") = 1
    End Sub

    Protected Sub GridView1_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView1.SelectedIndexChanging
        Me.Label1.Text = ""
        Me.Label2.Text = ""
        Me.Label3.Text = ""
        Me.Label4.Text = ""
        Me.Label5.Text = ""
        Me.Label6.Text = ""
        '
        Me.TextBox1.Text = Me.GridView1.Rows(e.NewSelectedIndex).Cells(1).Text
        MostrarEmpresaPorId()
        Session("accion") = 2
    End Sub

    Sub MostrarEmpresaPorId()
        Dim tablaEmpresa As New DataTable
        With empresa
            .IdEmpresa = Me.TextBox1.Text
            tablaEmpresa = .MostrarEmpresaPorId
            Me.TextBox2.Text = tablaEmpresa.Rows(0).Item("nombreEmpresa")
            Me.TextBox3.Text = tablaEmpresa.Rows(0).Item("direccionEmpresa")
            Me.TextBox4.Text = tablaEmpresa.Rows(0).Item("telefonoEmpresa")
            Me.TextBox5.Text = tablaEmpresa.Rows(0).Item("representanteEmpresa")
            '
            Me.DropDownList1.SelectedValue = tablaEmpresa.Rows(0).Item("estadoEmpresa")
            Me.DropDownList2.SelectedValue = tablaEmpresa.Rows(0).Item("idpais")
        End With
    End Sub

    Protected Sub ImageButton6_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton6.Click
        muestraempresaPorPais()
        mostrarNumeroDeRegistro()
    End Sub

    Sub muestraempresaPorPais()
        Dim tabla As New DataTable
        With empresa
            If Me.DropDownList2.SelectedIndex = 0 Then
                .IdPais = 0
            Else
                .IdPais = Me.DropDownList2.SelectedValue
            End If
            tabla = .MostrarEmpresaPorPais()
            Me.GridView1.DataSource = tabla
            Me.GridView1.DataBind()
        End With
    End Sub

End Class
