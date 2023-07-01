Imports System.Data
Imports System.IO


Partial Class Seguridad_wfGrupoUsuario
    Inherits System.Web.UI.Page

    Dim SublineaArticulo As New clsSublinea
    Dim objOperacione As New clsOperacione


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            CargarSubLinea()
            CargarLinea()
            mostrarNumeroDeRegistro()
            nuevo()
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub CargarLinea()
        Dim tablaLinea As New DataTable
        With objOperacione
            tablaLinea = .DevuelveDato("select * from TBlinea order by idLinea")
            Me.DropDownList2.DataSource = tablaLinea
            Me.DropDownList2.DataTextField = "nombreLinea"
            Me.DropDownList2.DataValueField = "idLinea"
            Me.DropDownList2.DataBind()
            Me.DropDownList2.Items.Insert(0, "Seleccione Linea")
        End With
    End Sub

    Sub CargarSubLinea()
        Dim tablaSubLinea As New DataTable
        With SublineaArticulo
            tablaSubLinea = .ConsultaSubLinea
            Me.GridView1.DataSource = tablaSubLinea
            Me.GridView1.DataBind()
        End With
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim huboError As String = "no"
        Me.Label1.Text = ""
        Me.Label2.Text = ""
        Me.Label3.Text = ""
        '
        If Me.TextBox2.Text = "" Then
            Me.Label2.Text = "* Requerido"
            huboError = "si"
        End If
        '
        If Me.DropDownList2.SelectedIndex = 0 Then
            Me.Label3.Text = "* Requerido"
            huboError = "si"
        End If
        '
        If huboError = "si" Then
            Exit Sub
        End If
        '
        Grabar()
        CargarSubLinea()
        Nuevo()
        Me.Label1.Text = "Registro Actualizado En El Sistema...!"
    End Sub

    Sub Grabar()
        With SublineaArticulo
            If Session("accion") = 1 Then
                .idSubLinea = 0
            Else
                .idSubLinea = Me.TextBox1.Text
            End If
            .NombreSubLinea = Me.TextBox2.Text
            .Estado = Me.DropDownList1.SelectedValue
            .Linea = Me.DropDownList2.SelectedValue
            .GrabarSubLinea(Session("accion"))
        End With
    End Sub

    Protected Sub ImageButton5_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton5.Click
        nuevo()
    End Sub

    Sub Nuevo()
        Me.Label1.Text = ""
        Me.Label2.Text = ""
        Me.Label3.Text = ""
        '
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.DropDownList2.SelectedIndex = 0
        Me.TextBox2.Focus()
        Session("accion") = 1
    End Sub

    Protected Sub GridView1_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView1.SelectedIndexChanging
        Me.Label1.Text = ""
        Me.Label2.Text = ""
        Me.Label3.Text = ""
        '
        Me.TextBox1.Text = Me.GridView1.Rows(e.NewSelectedIndex).Cells(1).Text
        Me.TextBox2.Text = Me.GridView1.Rows(e.NewSelectedIndex).Cells(2).Text
        Me.DropDownList1.SelectedValue = Me.GridView1.Rows(e.NewSelectedIndex).Cells(3).Text
        Me.DropDownList2.SelectedValue = Me.GridView1.Rows(e.NewSelectedIndex).Cells(4).Text
        Session("accion") = 2
    End Sub

    Protected Sub ImageButton6_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton6.Click
        mostrarSublineasPorLinea()
        mostrarNumeroDeRegistro()
    End Sub

    Sub mostrarNumeroDeRegistro()
        Me.Label4.Text = "Numero De Registros: " & Me.GridView1.Rows.Count
    End Sub

    Sub mostrarSublineasPorLinea()
        Dim tabla As New DataTable
        Dim codigoLinea As Integer
        If Me.DropDownList2.SelectedIndex = 0 Then
            codigoLinea = 0
        Else
            codigoLinea = Me.DropDownList2.SelectedValue
        End If
        '
        With SublineaArticulo
            .Linea = codigoLinea
            tabla = .obtenerSublineasPorLinea
            Me.GridView1.DataSource = tabla
            Me.GridView1.DataBind()
        End With
    End Sub
End Class
