Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mime

Public Class clsCorreoCumpleano

    Private _correoDestino As String
    Private _asuntoCorreo As String
    Private _cuerpoCorreo As String
    Private _nombre As String
    '
    Dim correo As New MailMessage
    Dim servidorSMTP As New SmtpClient

    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set

    End Property

    Public Property correoDestino() As String
        Get
            Return _correoDestino
        End Get
        Set(ByVal value As String)
            _correoDestino = value
        End Set

    End Property

    Public Property asunto() As String
        Get
            Return _cuerpoCorreo
        End Get
        Set(ByVal value As String)
            _cuerpoCorreo = value
        End Set
    End Property

    Public Property cuerpoCorreo() As String
        Get
            Return _asuntoCorreo
        End Get
        Set(ByVal value As String)
            _asuntoCorreo = value
        End Set
    End Property

    Function EnviarCorreo() As String
        Dim envioCorrecto As String = ""
        Dim Imagen As String = "~/Tarjeta cumpleano/tarjeta1.png" 'Ruta completa y nombre de la imagen.
        Dim text As String = "¡¡¡FELIZ CUMPLEAÑOS!!!, Te desea la familia KINNUX"

        Dim plainView As AlternateView = AlternateView.CreateAlternateViewFromString(text, System.Text.Encoding.UTF8, MediaTypeNames.Text.Plain)

        ' Ahora creamos la vista para clientes que
        ' pueden mostrar contenido HTML...

        Dim html As String = "<h2><b>" & Me.nombre & " ¡¡¡FELIZ CUMPLEAÑOS!!!</b> Te desea la familia KINNUX</h2>" & _
                            "<img src='cid:wbtestimagenbg' />"

        Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString(html, System.Text.Encoding.UTF8, MediaTypeNames.Text.Html)

        ' Creamos el recurso a incrustar. Observen
        ' que el ID que le asignamos (arbitrario) está
        ' referenciado desde el código HTML como origen
        ' de la imagen
        Dim img As LinkedResource = New LinkedResource(Imagen, MediaTypeNames.Image.Jpeg)
        img.ContentId = "wbtestimagenbg"

        ' Lo incrustamos en la vista HTML...
        htmlView.LinkedResources.Add(img)
        ' Por último, vinculamos ambas vistas al mensaje...
        correo.AlternateViews.Add(plainView)
        correo.AlternateViews.Add(htmlView)
        '-----------------------------------------------
        Try
            With correo
                .To.Clear()
                .To.Add(Me.correoDestino)
                .From = New MailAddress("info@kinnux.com")
                .Subject = Me.asunto
                correo.Body = Me.cuerpoCorreo
                correo.IsBodyHtml = True
                correo.Priority = MailPriority.Normal
                ' configuracion del servidor
                servidorSMTP.Host = "smtp.kinnux.com"
                servidorSMTP.Port = "2525"
                servidorSMTP.Credentials = New NetworkCredential("info@kinnux.com", "kinnux2012")
                'servidorSMTP.EnableSsl = True
                servidorSMTP.Send(correo)
                envioCorrecto = "si"
            End With
        Catch ex As Exception
            envioCorrecto = Err.Description & "-" & Err.Source
        End Try
        Return envioCorrecto
    End Function

End Class
