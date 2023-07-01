Imports System.Data
Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports Microsoft.VisualBasic
Imports System.Net.Mime

Partial Class Reportes_Varios_wfCalificacionBAHAMASenvioCorreos
    Inherits System.Web.UI.Page

    Dim calificacionCartagena As New clsTtCalifCartagena
    Dim paises As New clsPaise
    Dim operaciones As New clsOperacione
    Dim servidorCorreo As New clsServidorCorreo
    Dim mail As New MailMessage
    Dim servidorSMTP As New SmtpClient


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarempresas()
            Me.ImageButton2.Visible = False
            Me.Panel1.Visible = False
            Me.Panel2.Visible = False
            Me.Button5.Visible = False
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    Sub cargarempresas()
        Dim tabla As New DataTable
        With operaciones
            .cargarCombos(Me.DropDownList1, "select * from tbempresa", "idpais", "nombreempresa", "Todas las Empresas")
        End With
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Label4.Text = ""
        Me.Button5.Visible = False
        Me.GridView2.DataSource = Nothing
        Me.GridView2.DataBind()
        Dim encontroDatos As String = mostrarDatos()
    End Sub

    Function mostrarDatos() As String
        Me.Panel1.Visible = False
        Me.Panel2.Visible = False
        Me.Button5.Visible = False
        '
        Dim encontroDatos As String = "no"
        Me.ImageButton2.Visible = False
        Dim tabla As New DataTable
        Dim codigoPais As Integer
        If Me.DropDownList1.SelectedIndex = 0 Then
            codigoPais = 0
        Else
            codigoPais = Me.DropDownList1.SelectedValue
        End If
        With calificacionCartagena
            .codigoPais = codigoPais
            tabla = .obtenerDatosCalificacionBahamas
            If tabla.Rows.Count <> 0 Then
                Me.Panel1.Visible = True
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
                '
                Me.GridView2.Caption = "Calificacion Bahamas<br>" & Me.DropDownList1.SelectedItem.Text
                Me.ImageButton2.Visible = True

                'Me.Button5.Visible = True
                encontroDatos = "si"
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
                encontroDatos = "no"
            End If
        End With
        Return encontroDatos
    End Function

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        'panelDatos.Visible = False
        If Me.GridView2.Rows.Count <> 0 Then
            ExportToExcel("bahamas2017.xls", Me.GridView2)
        Else

        End If

    End Sub

    Private Sub ExportToExcel(ByVal nameReport As String, ByVal wControl As GridView)
        Me.GridView2.Columns(0).Visible = False
        Dim responsePage As HttpResponse = Response
        Dim sw As New StringWriter()
        Dim htw As New HtmlTextWriter(sw)
        Dim pageToRender As New Page()
        Dim form As New HtmlForm()
        form.Controls.Add(wControl)
        pageToRender.Controls.Add(form)
        responsePage.Clear()
        responsePage.Buffer = True
        responsePage.ContentType = "application/vnd.ms-excel"
        responsePage.AddHeader("Content-Disposition", "attachment;filename=" & nameReport)
        responsePage.Charset = "UTF-8"
        responsePage.ContentEncoding = Encoding.Default
        pageToRender.RenderControl(htw)
        responsePage.Write(sw.ToString())
        responsePage.End()
    End Sub

    Protected Sub GridView2_SelectedIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        Me.Label15.Text = ""
        Me.Label10.Text = "Volumen Personal: " & Me.GridView2.Rows(e.NewSelectedIndex).Cells(6).Text
        Me.Label11.Text = "Acumulado Nivel 1: " & Me.GridView2.Rows(e.NewSelectedIndex).Cells(7).Text
        'Me.Label12.Text = "Volumen Grupal Nivel 3: " & Me.GridView2.Rows(e.NewSelectedIndex).Cells(7).Text
        Me.Label13.Text = "Calificado: " & Me.GridView2.Rows(e.NewSelectedIndex).Cells(9).Text
        mostrarDetalle(Me.GridView2.Rows(e.NewSelectedIndex).Cells(1).Text)
    End Sub

    Sub mostrarDetalle(ByVal codigoAfiliado As String)
        Dim sql As String
        Me.Button5.Visible = False
        Me.Label7.Text = ""
        Me.Panel2.Visible = True
        Dim tabla As New DataTable
        ' correo del afiliado
        sql = "select * from afiliaciones where codigoafiliado='" & codigoAfiliado & "'"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.Label8.Text = tabla.Rows(0).Item("pnombre") & " " & tabla.Rows(0).Item("snombre") & " " & tabla.Rows(0).Item("papellido") & " " & tabla.Rows(0).Item("sapellido")
                Me.Label9.Text = tabla.Rows(0).Item("email1")
                Me.Label14.Text = tabla.Rows(0).Item("codigoafiliado")

            End If
        End With
        '
        With calificacionCartagena
            .codigoAfiliado = codigoAfiliado
            tabla = .obtenerDetalleAfiliadoBAHAMAS
            If tabla.Rows.Count <> 0 Then
                Me.Panel2.Visible = True
                Me.GridView3.DataSource = tabla
                Me.GridView3.DataBind()
                Me.Button5.Visible = True
            Else
                Me.Label7.Text = "No existen detalle...!"
                Me.GridView3.DataSource = Nothing
                Me.GridView3.DataBind()
            End If
            Me.TextBox1.Focus()
        End With
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim comilla As Char = Chr(34)
        Dim y As Integer
        Dim mensaje As String = ""
        Dim mail As MailMessage = New MailMessage()
        mensaje = "<h2>" & "Codigo: " & Me.Label14.Text & "<br>"
        mensaje = mensaje & "Nombres: " & Me.Label8.Text & "<br><br>"
        mensaje = mensaje & Me.Label10.Text & "<br>"
        mensaje = mensaje & Me.Label11.Text & "<br>"
        mensaje = mensaje & Me.Label13.Text & "<br><br>"
        mensaje = mensaje & " FRONTALES " & "</h2><br>"
        '
        mensaje = mensaje & "<table border=1 font-family: " & comilla & "Lucida Sans Unicode" & comilla & ", " & comilla & "Lucida Grande" & comilla & ", Sans-Serif>"
        mensaje = mensaje & "<tr>"
        mensaje = mensaje & "<td bgcolor=#CCCCCC>Nombres</td>"
        mensaje = mensaje & "<td bgcolor=#CCCCCC>Puntos Personales</td>"
        mensaje = mensaje & "<td bgcolor=#CCCCCC>Volumen Grupal Nivel 3</td>"
        mensaje = mensaje & "<td bgcolor=#CCCCCC align=center >Nuevo</td>"
        mensaje = mensaje & "<td bgcolor=#CCCCCC align=center>Calificado</td>"
        mensaje = mensaje & "</tr>"
        For y = 0 To Me.GridView3.Rows.Count - 1
            mensaje = mensaje & "<tr>"
            mensaje = mensaje & "<td>" & Me.GridView3.Rows(y).Cells(0).Text & "</td>"
            mensaje = mensaje & "<td align=right>" & Me.GridView3.Rows(y).Cells(1).Text & "</td>"
            mensaje = mensaje & "<td align=right>" & Me.GridView3.Rows(y).Cells(2).Text & "</td>"
            mensaje = mensaje & "<td align=center>" & Me.GridView3.Rows(y).Cells(3).Text & "</td>"
            mensaje = mensaje & "<td align=center>" & Me.GridView3.Rows(y).Cells(4).Text & "</td>"
            mensaje = mensaje & "</tr>"
        Next
        mensaje = mensaje & "</table>"

        Dim html As String = mensaje
        '
        Try
            With mail
                .To.Clear()
                '.To.Add("jose_luis_rhenals@hotmail.es")
                .To.Add(Me.Label9.Text)
                .From = New MailAddress("sistemaskinnux@gmail.com")
                .Subject = "Calificacion Bahamas...!"
                mail.Body = html
                mail.IsBodyHtml = True
                mail.Priority = MailPriority.Normal
                ' configuracion del servidor
                servidorSMTP.Host = "smtp.gmail.com"
                servidorSMTP.Port = "587"
                servidorSMTP.Credentials = New NetworkCredential("sistemaskinnux@gmail.com", "72208398")
                servidorSMTP.EnableSsl = True
                servidorSMTP.Send(mail)
                'envioCorrecto = "si"
                Me.Label15.Text = "Correo Enviado Correctamente a: " & Me.Label9.Text
            End With
        Catch ex As Exception
            'envioCorrecto = Err.Description & "-" & Err.Source
            'MsgBox(Err.Description & "-" & Err.Source & "-" & Err.LastDllError)
            Me.Label15.Text = "ERROR: " & Err.Description & "-" & Err.Source & "-" & Err.LastDllError

        End Try
    End Sub
End Class
