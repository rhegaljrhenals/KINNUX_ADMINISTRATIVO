Imports System.Data

Partial Class Reportes_Varios_wfConsultaCumpleano
    Inherits System.Web.UI.Page

    Dim objOperacione As New clsOperacione
    Dim correoCumpleano As New clsCorreoCumpleano


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            mostrarCumpleano()
            Me.Label5.Visible = False
            Me.Button2.Visible = False
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub mostrarCumpleano()
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select " & _
        "codigoafiliado," & _
        "papellido + ' ' + sapellido as apellidos," & _
        "pnombre + ' ' + snombre as nombres," & _
        "email1,fechaNacido" & _
        " from afiliaciones" & _
        " where" & _
        " month(fechaNacido)=month(getdate()) and" & _
        " Day(fechaNacido) = Day(getdate()) order by day(fechanacido) asc"
        With objOperacione
            tabla = .DevuelveDato(sql)
            Me.GridView1.DataSource = tabla
            Me.GridView1.DataBind()
        End With
        If Me.GridView1.Rows.Count = 0 Then
            Me.Label3.Text = "No hay registros de cumpleaños para hoy"
            'Me.Button2.Visible = False
        Else
            Me.Label3.Text = "Registros encontrados: " & Me.GridView1.Rows.Count
            'Me.Button2.Visible = True
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.DropDownList1.SelectedIndex <> 0 Then
            buscarRegistroPorMes(Me.DropDownList1.SelectedValue)
        End If
    End Sub

    Sub buscarRegistroPorMes(ByVal mes As String)
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select " & _
        "codigoafiliado," & _
        "papellido + ' ' + sapellido as apellidos," & _
        "pnombre + ' ' + snombre as nombres," & _
        "email1,fechaNacido" & _
        " from afiliaciones" & _
        " where" & _
        " month(fechaNacido)=" & mes & " order by day(fechanacido) asc"
        With objOperacione
            tabla = .DevuelveDato(sql)
            Me.GridView1.DataSource = tabla
            Me.GridView1.DataBind()
        End With
        If Me.GridView1.Rows.Count = 0 Then
            Me.Label3.Text = "No hay registros de cumpleaños para hoy"
        Else
            Me.Label3.Text = "Registros encontrados: " & Me.GridView1.Rows.Count
        End If
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim y As Integer
        If Me.GridView1.Rows.Count <> 0 Then
            Me.Label5.Visible = True
            For y = 0 To Me.GridView1.Rows.Count - 1
                With correoCumpleano
                    .correoDestino = Me.GridView1.Rows(y).Cells(3).Text
                    .asunto = "¡FELICIDADES EN TU CUMPLEAÑOS!"
                    .EnviarCorreo()
                End With
            Next
            Me.Label5.Visible = False
        End If
    End Sub
End Class
