Imports System.Data
Imports System.IO


Partial Class Seguridad_wfGrupoUsuario
    Inherits System.Web.UI.Page

    Dim lineaArticulo As New clsLineaArticulo
    Dim objOperacione As New clsOperacione


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            CargarLinea()
            mostrarNumeroDeRegistro()
            nuevo()
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub mostrarNumeroDeRegistro()
        Me.Label9.Text = "Numero De Registros: " & Me.GridView1.Rows.Count
    End Sub


    Sub CargarLinea()
        Dim tablaLinea As New DataTable
        With objOperacione
            tablaLinea = .DevuelveDato("select * from TBlinea order by idLinea")
            Me.GridView1.DataSource = tablaLinea
            Me.GridView1.DataBind()
        End With
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Label1.Text = ""
        Me.Label2.Text = ""
        If Me.TextBox2.Text = "" Then
            Me.Label2.Text = "* Ingrese el nombre de la linea...!"
            Exit Sub
        End If
        '
        grabar()
        cargarLinea()
        nuevo()
        Me.Label1.Text = "Registro Actualizado En El Sistema...!"
        mostrarNumeroDeRegistro()
    End Sub

    Sub Grabar()
        With lineaArticulo
            If Session("accion") = 1 Then
                .idLinea = 0
            Else
                .idLinea = Me.TextBox1.Text
            End If
            .nombreLinea = Me.TextBox2.Text
            .estado = Me.DropDownList1.SelectedValue
            .grabarLinea(Session("accion"))
        End With
    End Sub

    Protected Sub ImageButton5_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton5.Click
        nuevo()
    End Sub

    Sub Nuevo()
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.Label2.Text = ""
        Me.TextBox2.Focus()
        Session("accion") = 1
    End Sub

    Protected Sub GridView1_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView1.SelectedIndexChanging
        Me.Label1.Text = ""
        Me.Label2.Text = ""
        '
        Me.TextBox1.Text = Me.GridView1.Rows(e.NewSelectedIndex).Cells(1).Text
        Me.TextBox2.Text = Me.GridView1.Rows(e.NewSelectedIndex).Cells(2).Text
        Me.DropDownList1.SelectedValue = Me.GridView1.Rows(e.NewSelectedIndex).Cells(3).Text
        Session("accion") = 2
    End Sub

End Class
