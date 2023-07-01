Imports System.Net
Imports System.Net.Mail
Imports Microsoft.VisualBasic

Public Class clsServidorCorreo
    Private _correoDestino As String
    Private _asuntoCorreo As String
    Private _cuerpoCorreo As String
    '
    Dim correo As New MailMessage
    Dim servidorSMTP As New SmtpClient

    Public Property correoDestino As String
        Get
            Return _correoDestino
        End Get
        Set(ByVal value As String)
            _correoDestino = value
        End Set

    End Property

    Public Property asunto As String
        Get
            Return _cuerpoCorreo
        End Get
        Set(ByVal value As String)
            _cuerpoCorreo = value
        End Set
    End Property

    Public Property cuerpoCorreo As String
        Get
            Return _asuntoCorreo
        End Get
        Set(ByVal value As String)
            _asuntoCorreo = value
        End Set
    End Property

    Function EnviarCorreo() As String
        Dim envioCorrecto As String = ""
        '
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
            Try
                servidorSMTP.Send(correo)
                envioCorrecto = "si"
            Catch ex As Exception
                envioCorrecto = "no"
                MsgBox(Err.Description)
            End Try
        End With
        Return envioCorrecto
    End Function

    Function EnviarCorreoGmail() As String
        Dim envioCorrecto As String = ""
        Try
            With correo
                ' gmail
                .To.Clear()
                .To.Add(Me.correoDestino)
                .From = New MailAddress("knxteamsas@gmail.com")
                .Subject = Me.asunto
                correo.Body = Me.cuerpoCorreo
                correo.IsBodyHtml = True
                correo.Priority = MailPriority.Normal
                ' configuracion del servidor
                servidorSMTP.UseDefaultCredentials = True
                'servidorSMTP.DeliveryMethod = SmtpDeliveryMethod.Network
                servidorSMTP.EnableSsl = True
                servidorSMTP.Host = "smtp.gmail.com"
                servidorSMTP.Port = "587"
                servidorSMTP.Credentials = New NetworkCredential("knxteamsas@gmail.com", "Aigdyjlrg72*")
                servidorSMTP.Send(correo)
                envioCorrecto = "si"
            End With
        Catch ex As Exception
            envioCorrecto = Err.Description & "-" & Err.Source
        End Try
        Return envioCorrecto
    End Function
End Class
