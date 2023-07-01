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
        Dim sql As String
        Dim id, accion As Integer
        Me.Label7.Text = ""
        If Me.TextBox2.Text = "" Then
            Me.Label7.Text = "Ingrese el nombre del tipo de pregunta...!"
            Me.TextBox2.Focus()
            Exit Sub
        End If
        '
        If Me.TextBox1.Text = "" Then
            id = 0
            accion = 1
        Else
            id = Me.TextBox1.Text
            accion = 2
        End If
        sql = "exec sp_TBTipoPregunta " & _
        "@idTipoPregunta='" & id & "'," & _
        "@nombreTipoPregunta='" & Me.TextBox2.Text & "'," & _
        "@estadoTipoPregunta='" & Me.DropDownList2.SelectedValue & "'," & _
        "@accion='" & accion & "'"
        With operaciones
            .Accion(sql)
        End With
        nuevo()
        mostrarVentana("Tipo De Pregunta Grabado En El Sistema")
    End Sub

    Sub mostrarVentana(ByVal mensaje As String)
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('" & mensaje & "');", True)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            nuevo()
            'cargarCursos()
        End If
    End Sub

    Sub mostrarDatos()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT * from TBTipoPregunta"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End With
    End Sub

    Sub nuevo()
        mostrarDatos()
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox2.Focus()
    End Sub

    Protected Sub GridView2_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        Me.TextBox1.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(1).Text
        Me.TextBox2.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(2).Text
    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        nuevo()
    End Sub
End Class
