Imports System.Data
Imports System.Net
Imports System.Net.Mail
Imports Microsoft.VisualBasic
Imports System.Net.Mime
Imports System.IO

Partial Class herramientas_wfCodigoCampana
    Inherits System.Web.UI.Page

    Dim resumenFacturacion As New clsResumenFacturacionPaquetes
    Dim operaciones As New clsOperacione
    Dim mail As New MailMessage
    Dim servidorSMTP As New SmtpClient


    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim sql As String
        Dim id, accion As Integer
        Me.Label7.Text = ""
        If Me.TextBox5.Text = "" Then
            Me.Label7.Text = "Ingrese el codigo...!"
            Me.TextBox5.Focus()
            Exit Sub
        End If
        '
        If Me.TextBox3.Text = "" Or Me.TextBox4.Text = "" Then
            Me.Label7.Text = "Ingrese la fecha y la fecha de vencimiento...!"
            Me.TextBox4.Focus()
            Exit Sub
        End If
        '
        If Me.TextBox2.Text = "" Then
            Me.Label7.Text = "Ingrese el premio a ganar en este codigo...!"
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
        sql = "exec sp_codigoCampana " & _
        "@idCodigo='" & id & "'," & _
        "@codigo='" & Me.TextBox5.Text.ToUpper & "'," & _
        "@codigoAfiliado='" & "0" & "'," & _
        "@fecha='" & Me.TextBox3.Text & "'," & _
        "@fechaVence='" & Me.TextBox4.Text & "'," & _
        "@premio='" & Me.TextBox2.Text.ToUpper & "'," & _
        "@estado='" & "1" & "'," & _
        "@accion='" & accion & "'"
        With operaciones
            .Accion(sql)
        End With
        nuevo()
        mostrarVentana("Codigo Grabado En El Sistema")
    End Sub

    Sub mostrarVentana(ByVal mensaje As String)
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('" & mensaje & "');", True)
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            nuevo()
        End If
    End Sub

    Sub mostrarDatos()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from vw_listadoCodigoCampana"
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
        generarCodigo()
        mostrarDatos()
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = Now.Date.ToString("yyyy/MM/dd")
        Me.TextBox4.Text = Now.Date.ToString("yyyy/MM/dd")
        Me.TextBox5.Focus()
    End Sub

    Sub generarCodigo()
        Dim codigo As String
        Dim sql As String
        Dim tabla As New DataTable
        sql = "exec sp_codigoCampana_aleatorios '1'"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                codigo = tabla.Rows(0).Item("codigo")
                Me.Label8.Text = codigo.ToUpper
                Me.TextBox5.Text = codigo.ToUpper
            Else
                Me.Label8.Text = ""
                Me.TextBox5.Text = ""
            End If
        End With
    End Sub

    Protected Sub GridView2_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        Me.TextBox1.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(1).Text
        Me.TextBox2.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(2).Text
        cargarDatosCodigo(Me.TextBox1.Text)
    End Sub

    Sub cargarDatosCodigo(ByVal id As Integer)
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from vw_listadoCodigoCampana where idcodigo=" & id
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.TextBox1.Text = tabla.Rows(0).Item("idcodigo")
                Me.TextBox5.Text = tabla.Rows(0).Item("codigo")
                Me.Label8.Text = tabla.Rows(0).Item("codigo")

                Me.TextBox3.Text = tabla.Rows(0).Item("fecha")
                Me.TextBox4.Text = tabla.Rows(0).Item("fechavence")
                Me.TextBox2.Text = tabla.Rows(0).Item("premio")
            End If
        End With
    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        nuevo()
    End Sub

    Protected Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class
