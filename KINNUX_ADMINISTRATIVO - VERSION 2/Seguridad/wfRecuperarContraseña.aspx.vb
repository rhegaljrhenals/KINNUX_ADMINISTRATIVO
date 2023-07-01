Imports System.Data

Partial Class Seguridad_wfRecuperarContraseña
    Inherits System.Web.UI.Page

    Dim usuario As New clsUsuario
    Dim correo As New clsServidorCorreo

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            Me.Label2.Text = "Ingrese el nombre de usuario y el correo electrónico registrado." & "<br>" & _
                "un mensaje de confirmación será enviado a su e-mail para terminar la operación"
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        verificaUsuario()
    End Sub

    Sub verificaUsuario()
        Dim claveEncriptada As String
        Dim tablaUsuario As New DataTable
        With usuario
            .nombreUsuario = Me.TextBox1.Text
            .emailUsuario = Me.TextBox2.Text
            tablaUsuario = .validaUsuarioyCorreoElectronico()
            If tablaUsuario.Rows.Count = 0 Then
                Me.Label4.Text = "Nombre de usuario no existe o se encuentra eliminado...!" & "<br>" & _
                    "o su email no coincide con su nombre de usuario"
                Exit Sub
            End If
            Dim clave As String = obtenerNuevaClave()
            .idUsuario = tablaUsuario.Rows(0).Item("idUsuario")
            claveEncriptada = .encriptarClave(clave)
            .nombreUsuario = tablaUsuario.Rows(0).Item("nombreUsuario")
            .clave = claveEncriptada
            Session("usuario") = tablaUsuario.Rows(0).Item("nombreUsuario")
            Session("clave") = clave
            .cambiarContrasena()
            enviarCorreo()
        End With
    End Sub

    Function obtenerNuevaClave() As String
        Dim cadena As String
        Dim n1, n2, n3, n4 As Integer
        Dim letra(27) As String
        Dim numero(10) As String
        Dim letra1, letra2, letra3, letra4 As String
        Dim numero1, numero2, numero3, numero4 As String
        letra(0) = "A"
        letra(1) = "B"
        letra(2) = "C"
        letra(3) = "D"
        letra(4) = "E"
        letra(5) = "F"
        letra(6) = "G"
        letra(7) = "H"
        letra(8) = "I"
        letra(9) = "J"
        letra(10) = "K"
        letra(11) = "L"
        letra(12) = "M"
        letra(13) = "N"
        letra(14) = "O"
        letra(16) = "P"
        letra(17) = "Q"
        letra(18) = "R"
        letra(19) = "S"
        letra(20) = "T"
        letra(21) = "U"
        letra(22) = "V"
        letra(23) = "W"
        letra(24) = "X"
        letra(25) = "Y"
        letra(26) = "Z"
        '
        numero(0) = 0
        numero(1) = 1
        numero(2) = 2
        numero(3) = 3
        numero(4) = 4
        numero(5) = 5
        numero(6) = 6
        numero(7) = 7
        numero(8) = 8
        numero(9) = 9
        '
        '------------------------------------------------------
        ' letras
        Randomize()
        n1 = Int((26 - 0 + 1) * Rnd() + 0)
        n2 = Int((26 - 0 + 1) * Rnd() + 0)
        n3 = Int((26 - 0 + 1) * Rnd() + 0)
        n4 = Int((26 - 0 + 1) * Rnd() + 0)
        letra1 = letra(n1)
        letra2 = letra(n2)
        letra3 = letra(n3)
        letra4 = letra(n4)
        '------------------------------------------------------
        '------------------------------------------------------
        ' numeros
        Randomize()
        n1 = Int((9 - 0 + 1) * Rnd() + 0)
        n2 = Int((9 - 0 + 1) * Rnd() + 0)
        n3 = Int((9 - 0 + 1) * Rnd() + 0)
        n4 = Int((9 - 0 + 1) * Rnd() + 0)
        numero1 = numero(n1)
        numero2 = numero(n2)
        numero3 = numero(n3)
        numero4 = numero(n4)
        '------------------------------------------------------
        cadena = letra1 & letra2 & numero1 & numero2 & letra3 & letra4 & numero3 & numero4
        Return cadena
    End Function

    Sub enviarCorreo()
        Dim cuerpo As String
        cuerpo = "<b>Bienvenido(a) A Nuestro Sistema De Información</b>," & "<br><br>" & _
        "Su solicitud de cuenta ha sido tramitada exitosamente; a continuación le informamos el  usuario y contraseña que puede utilizar para acceder a su KINNUX ADMINISTRATIVO" & "<BR>" & _
        "¡Recuerde, esta información es privada e intransferible! " & "<br><br><br>" & _
        "<b>Usuario:     " & Session("usuario") & "</b><br>" & _
        "<b>Contraseña:  " & Session("clave") & "</b><br><br><br>" & _
        "Por favor realize el cambio de esta contraseña" & "<br><br>" & _
        "Al ingresar al sistema;  Encontrará una opción que le facilitará esta labor." & "<br>"
        'cuerpo = "Correo para restablecer la contraseña de prueba" & "<br>" & _
        '    "<a href=www.google.com.co>pagina google</a>"
        Dim envioCorrecto As String = ""
        With correo
            .asunto = "Restablecer Contraseña - Nueva Clave De Ingreso"
            .correoDestino = Me.TextBox2.Text
            .cuerpoCorreo = cuerpo
            envioCorrecto = .EnviarCorreo()
            If envioCorrecto = "si" Then
                Me.Label4.ForeColor = Drawing.Color.Blue
                Me.Label4.Text = "La contraseña ha sido actualizada satisfactoriamente...!" & "<br>" & "Revise su correo electrónico, ahi encontrará la información de su Nombre De Usuario y su Nueva Clave"
            Else
                Me.Label4.ForeColor = Drawing.Color.Red
                Me.Label4.Text = "Hubo un error en el envio del correo electrónico...!"
            End If
        End With
    End Sub
End Class
