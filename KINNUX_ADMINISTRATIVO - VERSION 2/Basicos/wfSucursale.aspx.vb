Imports System.Data
Imports System.IO


Partial Class Basicos_wfSucursale
    Inherits System.Web.UI.Page

    Dim objOperacione As New clsOperacione
    Dim paise As New clsPaise
    Dim empresa As New clsEmpresa
    Dim sucursale As New clsSucursale

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            CargarEmpresa()
            cargarSucursale()
            Nuevo()
            mostrarNumeroDeRegistro()
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub mostrarNumeroDeRegistro()
        Me.Label8.Text = "Numero De Registros: " & Me.GridView1.Rows.Count
    End Sub

    Sub cargarSucursale()
        Dim tabla As New DataTable
        With sucursale
            tabla = .muestraSucursale
            Me.GridView1.DataSource = tabla
            Me.GridView1.DataBind()

        End With
    End Sub

    Sub CargarEmpresa()
        Dim tablaEmpresa As New DataTable
        With empresa
            tablaEmpresa = .MostrarEmpresaGeneral
            Me.DropDownList2.DataSource = tablaEmpresa
            Me.DropDownList2.DataTextField = "nombreEmpresa"
            Me.DropDownList2.DataValueField = "idEmpresa"
            Me.DropDownList2.DataBind()
            '
            Me.DropDownList2.Items.Insert(0, "Seleccione Empresa")
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
        If Me.TextBox6.Text = "" Then
            Me.Label6.Text = "* requerido"
            huboError = "si"
        End If
        '
        If Me.DropDownList2.SelectedIndex = 0 Then
            Me.Label6.Text = "* seleccione la empresa"
            huboError = "si"
        End If
        '
        If huboError = "si" Then
            Exit Sub
        End If
        '
        Grabar()
        mostrarVentana()
        cargarSucursale()
        Nuevo()
        Me.Label1.Text = "Registro Actualizado En El Sistema...!"
    End Sub

    Sub mostrarVentana()
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('Sucursal Registrada En El Sistema...!');", True)
    End Sub


    Sub Grabar()
        With sucursale
            If Session("accion") = 1 Then
                .idSucursal = 0
            Else
                .idSucursal = Me.TextBox1.Text
            End If
            .nombreSucursal = Me.TextBox2.Text.ToUpper
            .idAfiliado = 0
            .direccionSucursal = Me.TextBox3.Text.ToUpper
            .telefonoSucursal = Me.TextBox4.Text
            .ciudadSucursal = Me.TextBox5.Text.ToUpper
            .dptoSucursal = Me.TextBox6.Text.ToUpper
            .idEmpresa = DropDownList2.SelectedValue
            .estadoSucursal = Me.DropDownList1.SelectedValue
            .grabarSucursal(Session("accion"))
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
        Me.TextBox2.Text = Me.GridView1.Rows(e.NewSelectedIndex).Cells(2).Text
        Me.TextBox3.Text = Me.GridView1.Rows(e.NewSelectedIndex).Cells(3).Text
        Me.TextBox4.Text = Me.GridView1.Rows(e.NewSelectedIndex).Cells(4).Text
        Me.TextBox5.Text = Me.GridView1.Rows(e.NewSelectedIndex).Cells(7).Text
        Me.TextBox6.Text = Me.GridView1.Rows(e.NewSelectedIndex).Cells(8).Text
        '
        Me.DropDownList2.SelectedValue = Me.GridView1.Rows(e.NewSelectedIndex).Cells(5).Text
        Session("accion") = 2
    End Sub

    Protected Sub ImageButton6_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton6.Click
        mostrarSucursalesPorEmpresa()
        mostrarNumeroDeRegistro()
    End Sub

    Sub mostrarSucursalesPorEmpresa()
        Dim tabla As New DataTable
        Dim codigoEmpresa As Integer
        If Me.DropDownList2.SelectedIndex = 0 Then
            codigoEmpresa = 0
        Else
            codigoEmpresa = Me.DropDownList2.SelectedValue
        End If
        With sucursale
            .idEmpresa = codigoEmpresa
            tabla = .obtenerSucursalePorEmpresa
            Me.GridView1.DataSource = tabla
            Me.GridView1.DataBind()
        End With
    End Sub
End Class
