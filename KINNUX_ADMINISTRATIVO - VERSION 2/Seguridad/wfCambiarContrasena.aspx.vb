Imports System.Data

Partial Class Seguridad_wfCambiarContraseña
    Inherits System.Web.UI.Page

    Dim usuario As New clsTBUsuarios

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Me.TextBox1.Text = Session("nombreusuario")
            Me.TextBox3.Text = Session("nombreusuario")
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim encontrado As String = verificausuario()
        If encontrado = "no" Then
            Me.Label3.Text = "Clave Actual Invalida...!"
            Exit Sub
        Else
            If Me.TextBox4.Text <> Me.TextBox5.Text Then
                Me.Label3.Text = "La nueva Clave y su confirmacion no coinciden...!"
                Exit Sub
            Else
                actualizaContrasena()
                Me.Label3.Text = "Contraseña actualizada satisfactoriamente...!"
            End If
        End If
    End Sub

    Sub actualizaContrasena()
        'Dim claveEncriptada As String
        With usuario
            .idUsuario = Session("idUsuario")
            .nombreUsuario = Me.TextBox3.Text
            'claveEncriptada = .encriptarClave(Me.TextBox4.Text)
            .claveUsuario = Me.TextBox4.Text 'claveEncriptada
            .cambiarContrasena()
        End With
    End Sub

    Function verificausuario() As String
        'Dim claveEncriptada As String
        Dim encontrado As String
        Dim tablaUsuario As New DataTable
        With usuario
            .nombreUsuario = Me.TextBox1.Text
            'claveEncriptada = .encriptarClave(Me.TextBox2.Text)
            .claveUsuario = Me.TextBox2.Text 'claveEncriptada
            tablaUsuario = .validaUsuario()
            If tablaUsuario.Rows.Count <> 0 Then
                encontrado = "si"
            Else
                encontrado = "no"
            End If
        End With
        Return encontrado
    End Function

    Protected Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
