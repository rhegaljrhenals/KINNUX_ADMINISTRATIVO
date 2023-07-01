Imports System.Data

Partial Class Basicos_wfPreciosPaginasPersonales
    Inherits System.Web.UI.Page

    Dim pais As New clsPaise
    Dim linea As New clsLineaArticulo
    Dim objOperacione As New clsOperacione
    Dim producto As New clsProducto

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            'cargarPais()
            'cargarLineas()
            nuevo()
            'cargarProductos()
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub cargarProductos()
        Dim tabla As New DataTable
        With producto
            tabla = .obtenerProductosPaginasPersonales
            If tabla.Rows.Count <> 0 Then
                Me.GridView1.DataSource = tabla
                Me.GridView1.DataBind()
            Else
                Me.GridView1.DataSource = Nothing
                Me.GridView1.DataBind()
            End If
        End With
    End Sub


    Protected Sub ImageButton8_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton8.Click
        Dim mensajeError As String = Nothing
        Dim huboError As String = "no"
        Me.Label17.Visible = False
        'Me.Label20.Text = ""
        'Me.Label21.Text = ""
        'Me.Label22.Text = ""
        '
        If Me.TextBox1.Text = "" Then
            huboError = "si"
            Me.Label17.Visible = True
        End If
        '
        
        If huboError = "si" Then
            Exit Sub
        End If
        '
        grabarProducto()
        'grabarProductoPais()
        mostrarVentana()
        nuevo()
    End Sub

    
    Sub mostrarVentana()
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('Producto Registrado En El Sistema...!');", True)
    End Sub

    Sub nuevo()
        Me.MultiView1.ActiveViewIndex = 0
        Me.ImageButton8.Visible = True
        '
        Me.TextBox1.Text = Nothing
        Me.TextBox7.Text = Nothing
        Me.TextBox8.Text = Nothing
        Me.TextBox9.Text = Nothing
        'Session("accion") = 1
        '
        Me.TextBox1.Focus()
        '
        Me.Label17.Visible = False
        'Me.Label20.Text = ""
        'Me.Label21.Text = ""
        'Me.Label22.Text = ""
        'cargarPais()
        cargarProductos()
    End Sub

    Sub grabarProducto()
        Dim sql As String
        Dim accion As Integer
        Dim idProducto As Integer
        With objOperacione
            If Me.TextBox7.Text = "" Then
                idProducto = 0
                accion = 1
            Else
                idProducto = Val(Me.TextBox7.Text)
                accion = 2
            End If
            sql = "exec sp_preciosProductosPaginaPersonal " & _
            "@idProducto='" & idProducto & "'," & _
            "@nombre='" & Me.TextBox1.Text & "'," & _
            "@precioCop='" & Me.TextBox8.Text & "'," & _
            "@precioUsd='" & Me.TextBox9.Text & "'," & _
            "@accion='" & accion & "'"
            With objOperacione
                .Accion(sql)
            End With
        End With
    End Sub

    
    Protected Sub ImageButton7_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
        nuevo()
    End Sub

    
    'Protected Sub ImageButton11_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton11.Click
    '    Me.MultiView1.ActiveViewIndex = 1
    '    Me.ImageButton8.Visible = False
    '    '
    '    cargarProductos()
    'End Sub

    
    Protected Sub GridView1_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs) Handles GridView1.SelectedIndexChanging
        Me.TextBox7.Text = Me.GridView1.Rows(e.NewSelectedIndex).Cells(1).Text
        Me.TextBox1.Text = Me.GridView1.Rows(e.NewSelectedIndex).Cells(2).Text
        If IsNothing(Me.GridView1.Rows(e.NewSelectedIndex).Cells(3).Text) Then
            Me.TextBox8.Text = "0"
        Else
            Me.TextBox8.Text = CDbl(Me.GridView1.Rows(e.NewSelectedIndex).Cells(3).Text)
        End If
        '
        If IsNothing(Me.GridView1.Rows(e.NewSelectedIndex).Cells(4).Text) Then
            Me.TextBox9.Text = "0"
        Else
            Me.TextBox9.Text = CDbl(Me.GridView1.Rows(e.NewSelectedIndex).Cells(4).Text)
        End If
    End Sub
End Class
