Imports System.Data
Imports System.Net
Imports System.Net.Mail
Imports Microsoft.VisualBasic
Imports System.Net.Mime
Imports System.IO

Partial Class Reportes_Varios_wfEstadisticasFacturacion
    Inherits System.Web.UI.Page

    Dim resumenFacturacion As New clsResumenFacturacionPaquetes
    Dim operaciones As New clsOperacione
    Dim mail As New MailMessage
    Dim servidorSMTP As New SmtpClient


    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.GridView2.DataSource = Nothing
        Me.GridView2.DataBind()
    End Sub

    Sub calcularTotales()
        Dim y As Integer
        'Dim k As Integer
        Dim columna As Integer = 2
        Dim suma1 As Double = 0
        Dim suma2 As Double = 0
        Dim suma3 As Double = 0
        Dim suma4 As Double = 0
        Dim suma5 As Double = 0
        Dim suma6 As Double = 0
        Dim suma7 As Double = 0
        Dim suma8 As Double = 0
        Dim suma9 As Double = 0
        Dim suma10 As Double = 0
        '
        For y = 0 To Me.GridView2.Rows.Count - 1
            suma1 += Me.GridView2.Rows(y).Cells(2).Text
            suma2 += Me.GridView2.Rows(y).Cells(3).Text
            suma3 += Me.GridView2.Rows(y).Cells(4).Text
            suma4 += Me.GridView2.Rows(y).Cells(5).Text
            suma5 += Me.GridView2.Rows(y).Cells(6).Text
            suma6 += Me.GridView2.Rows(y).Cells(7).Text
            suma7 += Me.GridView2.Rows(y).Cells(8).Text
            suma8 += Me.GridView2.Rows(y).Cells(9).Text
            suma9 += Me.GridView2.Rows(y).Cells(10).Text
            suma10 += Me.GridView2.Rows(y).Cells(11).Text
        Next
        Me.GridView2.FooterRow.Cells(0).Text = "Totales:"
        Me.GridView2.FooterRow.Cells(2).Text = FormatNumber(suma1, 0)
        Me.GridView2.FooterRow.Cells(3).Text = FormatNumber(suma2, 0)
        Me.GridView2.FooterRow.Cells(4).Text = FormatNumber(suma3, 0)
        Me.GridView2.FooterRow.Cells(5).Text = FormatNumber(suma4, 0)
        Me.GridView2.FooterRow.Cells(6).Text = FormatNumber(suma5, 0)
        Me.GridView2.FooterRow.Cells(7).Text = FormatNumber(suma6, 0)
        Me.GridView2.FooterRow.Cells(8).Text = FormatNumber(suma7, 0)
        Me.GridView2.FooterRow.Cells(9).Text = FormatNumber(suma8, 0)
        Me.GridView2.FooterRow.Cells(10).Text = FormatNumber(suma9, 0)
        Me.GridView2.FooterRow.Cells(11).Text = FormatNumber(suma10, 0)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            mosrarPQrPendientes()
            cargarusuarios()
            Me.MultiView1.ActiveViewIndex = 0
            Me.Panel2.Visible = False
        End If
    End Sub

    Sub cargarusuarios()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from tbusuario where solucionaPQR='si' order by nombreCompletoUsuario"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList1.DataSource = tabla
                Me.DropDownList1.DataTextField = "nombrecompletousuario"
                Me.DropDownList1.DataValueField = "idusuario"
                Me.DropDownList1.DataBind()
            Else
                Me.DropDownList1.DataSource = Nothing
                Me.DropDownList1.DataBind()
            End If
            Me.DropDownList1.Items.Insert(0, "Seleccione Usuario")
        End With
    End Sub

    Sub mosrarPQrPendientes()
        Me.Label4.Text = ""
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT      " & _
        "dbo.TTEncabezadoPqr.idPqr, " & _
        "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres, " & _
        "case dbo.TTEncabezadoPqr.estadoPqr" & _
        " when 'pe' then 'Pendiente'" & _
        " when 'pr' then 'En Proceso'" & _
        " when 're' then 'Rechazado'" & _
        " when 'ce' then 'Cerrado'" & _
        " else ''" & _
        " end estadoPqr," & _
        " case dbo.TTEncabezadoPqr.tipoSolicitud" & _
        " when 'pe' then 'Peticion'" & _
        " when 'qu' then 'Queja'" & _
        " when 're' then 'Reclamo'" & _
        " else ''" & _
        " end tipoSolicitud," & _
        " case dbo.TTEncabezadoPqr.prioridadPqr" & _
        " when 'al' then 'Alta'" & _
        " when 'me' then 'Media'" & _
        " when 'ba' then 'Baja'" & _
        " else ''" & _
        " end prioridadPqr" & _
        " FROM" & _
        " dbo.TTEncabezadoPqr INNER JOIN" & _
        " dbo.Afiliaciones ON dbo.TTEncabezadoPqr.codigoAfiliado = dbo.Afiliaciones.codigoAfiliado" & _
        " where dbo.TTEncabezadoPqr.estadoPqr in('pe','pr')" & _
        " order by dbo.TTEncabezadoPqr.idPqr"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
                Me.Label4.Text = Me.GridView2.Rows.Count & " Tickets Pendientes...!"
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
                Me.Label4.Text = "No Hay Tickets Pendientes...!"
            End If
        End With
    End Sub

    'Private Sub ExportToExcel(ByVal nameReport As String, ByVal wControl As GridView)
    '    Dim responsePage As HttpResponse = Response
    '    Dim sw As New StringWriter()
    '    Dim htw As New HtmlTextWriter(sw)
    '    Dim pageToRender As New Page()
    '    Dim form As New HtmlForm()
    '    form.Controls.Add(wControl)
    '    pageToRender.Controls.Add(form)
    '    responsePage.Clear()
    '    responsePage.Buffer = True
    '    responsePage.ContentType = "application/vnd.ms-excel"
    '    responsePage.AddHeader("Content-Disposition", "attachment;filename=" & nameReport)
    '    responsePage.Charset = "UTF-8"
    '    responsePage.ContentEncoding = Encoding.Default
    '    pageToRender.RenderControl(htw)
    '    responsePage.Write(sw.ToString())
    '    responsePage.End()
    'End Sub

    Protected Sub GridView2_SelectedIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        Dim sql As String
        Dim tabla As New DataTable
        Me.Panel2.Visible = True
        Me.TextBox1.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(1).Text
        Me.TextBox2.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(2).Text
        'Me.TextBox3.Text = HttpUtility.HtmlDecode(Me.GridView2.Rows(e.NewSelectedIndex).Cells(3).Text)
        Me.TextBox4.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(3).Text
        Me.TextBox5.Text = HttpUtility.HtmlDecode(Me.GridView2.Rows(e.NewSelectedIndex).Cells(4).Text)
        Me.TextBox6.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(5).Text
        'Me.TextBox7.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(7).Text
        'Me.TextBox8.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(8).Text
        sql = "select * from TTDetallePqr where idPqr=" & Me.TextBox1.Text
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.GridView3.DataSource = tabla
                Me.GridView3.DataBind()
            Else
                Me.GridView3.DataSource = Nothing
                Me.GridView3.DataBind()
            End If
        End With
        Me.TextBox7.Focus()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        grabar()
        enviarEmailAfiliado()
        '
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox4.Text = ""
        Me.TextBox5.Text = ""
        Me.TextBox6.Text = ""
        Me.Panel2.Visible = False
        '
        mostrarVentana()
        mosrarPQrPendientes()
        Me.MultiView1.ActiveViewIndex = 0
    End Sub

    Sub mostrarVentana()
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('PQR Asignado Satisfactoriamente...!');", True)
    End Sub

    Sub enviarEmailAfiliado()
        Dim sql As String
        Dim nombre As String = ""
        Dim email As String = ""
        Dim codigo As String = ""
        Dim link As String = ""
        Dim tabla As New DataTable
        Dim mail As MailMessage = New MailMessage()
        'datos del pqr
        sql = "SELECT      " & _
        "dbo.TTEncabezadoPqr.idPqr, " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres, " & _
        "dbo.TTDetallePqr.descripcion, " & _
        "dbo.Afiliaciones.email1," & _
        "case dbo.TTEncabezadoPqr.estadoPqr" & _
        " when 'pe' then 'Pendiente'" & _
        " when 'as' then 'Asignado'" & _
        " when 'pr' then 'En Proceso'" & _
        " when 're' then 'Rechazado'" & _
        " when 'ce' then 'Cerrado'" & _
        " else ''" & _
        " end estadoPqr," & _
        " case dbo.TTEncabezadoPqr.tipoSolicitud" & _
        " when 'pe' then 'Peticion'" & _
        " when 'qu' then 'Queja'" & _
        " when 're' then 'Reclamo'" & _
        " else ''" & _
        " end tipoSolicitud," & _
        " case dbo.TTEncabezadoPqr.prioridadPqr" & _
        " when 'al' then 'Alta'" & _
        " when 'me' then 'Media'" & _
        " when 'ba' then 'Baja'" & _
        " else ''" & _
        " end prioridadPqr," & _
        " dbo.TTDetallePqr.fecha," & _
        " dbo.TTDetallePqr.hora" & _
        " FROM" & _
        " dbo.TTEncabezadoPqr INNER JOIN" & _
        " dbo.Afiliaciones ON dbo.TTEncabezadoPqr.codigoAfiliado = dbo.Afiliaciones.codigoAfiliado INNER JOIN" & _
        " dbo.TTDetallePqr ON dbo.TTEncabezadoPqr.idPqr = dbo.TTDetallePqr.idPqr" & _
        " where dbo.TTEncabezadoPqr.idPqr=" & Me.TextBox1.Text
        '
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                email = tabla.Rows(0).Item("email1")
                nombre = tabla.Rows(0).Item("nombres")
            End If
        End With
        ' cuerpo del texto
        Dim text As String
        text = "Estimado: <b>" & nombre & "</b><br><br>"
        text = text & "Reciba un cordial saludo por parte de KINNUX.<br><br>"
        text = text & "Su Ticket ya fue asignado a un empleado de nuestro Staff.<br>"
        text = text & "Incluímos los detalles de su ticket a continuación.<br><br>"
        text = text & "<b>id (ticket) :</b> " & Me.TextBox1.Text & "<br>"
        text = text & "<b>Tipo De Solicitud :</b> " & Me.TextBox5.Text & "<br>"
        text = text & "<b>Prioridad :</b> " & Me.TextBox6.Text & "<br>"
        text = text & "<b>Descripción PQR :</b> " & "" & "<br>"
        text = text & "<b>Estado :</b>" & " Asignado" & "<br>"
        text = text & "<b>Ticket Asignado a:</b> " & Me.DropDownList1.SelectedItem.Text & "<br><br>"
        text = text & "Puede revisar el estado o responder a este ticket desde su Backoffice en el Menu Herramientas opcion PQR, pulsando el boton Consultar PQR<br>"
        text = text & "Un saludo,<br><br>"
        text = text & "Departamento de sistemas KINNUX."
        '
        Try
            With mail
                .To.Clear()
                .To.Add(email)
                .From = New MailAddress("sistemaskinnux@gmail.com")
                .Subject = "ASIGNACION TICKET >> PQR Id: " & Me.TextBox1.Text & ", Tipo De Solicitud: " & Me.TextBox5.Text & ", Prioridad: " & Me.TextBox6.Text
                mail.Body = text
                mail.IsBodyHtml = True
                mail.Priority = MailPriority.Normal
                ' configuracion del servidor
                servidorSMTP.Host = "smtp.gmail.com"
                servidorSMTP.Port = "587"
                servidorSMTP.Credentials = New NetworkCredential("sistemaskinnux@gmail.com", "72208398")
                servidorSMTP.EnableSsl = True
                servidorSMTP.Send(mail)
                'envioCorrecto = "si"
            End With
        Catch ex As Exception
            'envioCorrecto = Err.Description & "-" & Err.Source
            'MessageBox.Show(Err.Description & "-" & Err.Source & "-" & Err.LastDllError)
        End Try
    End Sub

    Sub grabar()
        Dim sql As String
        sql = "update TTEncabezadoPqr set estadoPQR='as',idUsuario=" & Me.DropDownList1.SelectedValue & " where idPqr=" & Me.TextBox1.Text
        With operaciones
            .Accion(sql)
        End With
        'grabar el detalle
        ' actualiza el detalle
        sql = "exec sp_TTDetallePqr " & _
        "@idPqr='" & Me.TextBox1.Text & "'," & _
        "@descripcion='" & "Se le ha asignado este numero de ticket a : " & Me.DropDownList1.SelectedItem.Text & "'," & _
        "@fecha='" & Now.Date.ToString("yyyy/MM/dd") & "'," & _
        "@hora='" & String.Format("{0:hh:mm:ss tt}", DateTime.Now) & "'," & _
        "@tipo='" & "so" & "'"
        With operaciones
            .Accion(sql)
        End With
    End Sub
End Class
