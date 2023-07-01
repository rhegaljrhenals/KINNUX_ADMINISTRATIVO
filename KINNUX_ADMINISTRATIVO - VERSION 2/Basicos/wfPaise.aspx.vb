Imports System.Data
Imports System.IO


Partial Class Seguridad_wfGrupoUsuario
    Inherits System.Web.UI.Page

    Dim paise As New clsPaise
    Dim objOperacione As New clsOperacione


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            CargarPaise()
            Nuevo()
            mostrarNumeroDeRegistro()
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub mostrarNumeroDeRegistro()
        Me.Label5.Text = "Numero De Registros: " & Me.GridView1.Rows.Count
    End Sub

    Sub CargarPaise()
        Dim tablaLinea As New DataTable
        With objOperacione
            tablaLinea = .DevuelveDato("select * from TBPais order by idpais")
            Me.GridView1.DataSource = tablaLinea
            Me.GridView1.DataBind()
        End With
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim huboError As String = "no"
        Me.Label1.Text = ""
        Me.Label2.Text = ""
        Me.Label3.Text = ""
        Me.Label4.Text = ""
        '
        If Me.TextBox3.Text = "" Then
            Me.Label3.Text = "* Codigo Pais Requerido"
            huboError = "si"
        End If
        '
        If Me.TextBox2.Text = "" Then
            Me.Label2.Text = "* Nombre Pais Requerido...!"
            huboError = "si"
        End If
        '
        If Me.TextBox4.Text = "" Then
            Me.Label4.Text = "* Prefijo Pais Es Requerido"
            huboError = "si"
        End If
        '
        If huboError = "si" Then
            Exit Sub
        End If
        '
        Grabar()
        CargarPaise()
        Nuevo()
        Me.Label1.Text = "Registro Actualizado En El Sistema...!"
        mostrarNumeroDeRegistro()
    End Sub

    Sub Grabar()
        With paise
            If Session("accion") = 1 Then
                .IdPais = 0
            Else
                .IdPais = Me.TextBox1.Text
            End If
            .CodigoPais = Me.TextBox3.Text
            .NombrePais = Me.TextBox2.Text
            .SufijoPais = Me.TextBox4.Text
            .NumeroPais = 0
            .EstadoPais = Me.DropDownList1.SelectedValue
            .GrabarPais(Session("accion"))
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
        '
        Me.Label1.Text = ""
        Me.Label2.Text = ""
        Me.Label3.Text = ""
        Me.Label4.Text = ""
        '
        Me.DropDownList1.SelectedIndex = 0
        Me.TextBox3.Focus()
        Session("accion") = 1
    End Sub

    Protected Sub GridView1_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView1.SelectedIndexChanging
        Me.Label1.Text = ""
        Me.Label2.Text = ""
        Me.Label3.Text = ""
        Me.Label4.Text = ""
        '
        Me.TextBox1.Text = Me.GridView1.Rows(e.NewSelectedIndex).Cells(1).Text
        Me.TextBox3.Text = Me.GridView1.Rows(e.NewSelectedIndex).Cells(2).Text
        Me.TextBox2.Text = Me.GridView1.Rows(e.NewSelectedIndex).Cells(3).Text
        Me.TextBox4.Text = Me.GridView1.Rows(e.NewSelectedIndex).Cells(4).Text
        '
        Me.DropDownList1.SelectedValue = Me.GridView1.Rows(e.NewSelectedIndex).Cells(5).Text
        Session("accion") = 2
    End Sub
End Class
