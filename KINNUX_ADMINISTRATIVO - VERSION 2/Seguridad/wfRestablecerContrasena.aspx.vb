Imports System.Data

Partial Class Seguridad_wfRestablecerContrasena
    Inherits System.Web.UI.Page

    Dim usuario As New clsTBUsuarios
    Dim afiliados As New ClsAfiliado
    Dim operaciones As New clsOperacione

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            'Me.TextBox1.Text = Session("nombreusuario")
            'Me.TextBox3.Text = Session("nombreusuario")
            Me.TextBox1.Focus()
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim encontrado As String = verificausuario()
        If encontrado = "no" Then
            Me.Label3.Text = "Clave Actual Inválida...!"
            Exit Sub
        Else

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

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim tabla As New DataTable
        Dim sql As String
        If Me.TextBox1.Text <> "" Then
            sql = "SELECT   * from vw_datosafiliados " & _
            " where codigoafiliado='" & Me.TextBox1.Text & "'"
            With operaciones
                tabla = .DevuelveDato(sql)
                If tabla.Rows.Count <> 0 Then
                    Me.TextBox2.Text = tabla.Rows(0).Item("nombres")
                    Me.TextBox6.Text = tabla.Rows(0).Item("email1")
                Else
                    Me.TextBox2.Text = ""
                    Me.TextBox6.Text = ""
                End If
            End With
        End If
    End Sub

    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        Dim claveEncriptada As String
        With usuario
            .idUsuario = Me.Label4.Text
            .nombreUsuario = Me.TextBox4.Text
            claveEncriptada = .encriptarClave(Me.TextBox4.Text)
            .clave = claveEncriptada
            .cambiarContrasena()
        End With
    End Sub
End Class
