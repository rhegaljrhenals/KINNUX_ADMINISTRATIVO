Imports System.Data

Partial Class Seguridad_wfFechasCierre
    Inherits System.Web.UI.Page

    Dim fechasCierre As New clsTBFechaCierre

    Protected Sub ImageButton10_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton10.Click
        Me.Label4.Text = ""
        If Me.TextBox1.Text <> "" And Me.TextBox2.Text <> "" And Me.TextBox3.Text <> "" Then
            With fechasCierre
                .idFechaCierre = Me.TextBox1.Text
                .fechaInicio = Me.TextBox2.Text
                .fechaFinal = Me.TextBox3.Text
                .actualizaFechas()
            End With
            mostrarVentana()
        Else
            Me.Label4.Text = "Datos Incorrectos para realizar la actualización de los datos...!"
        End If
    End Sub

    Sub mostrarVentana()
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('Fechas Actualizadas Correctamente...!');", True)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            mostrarFechas()
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    Sub mostrarFechas()
        Dim tabla As New DataTable
        With fechasCierre
            tabla = .mostrarFechas
            If tabla.Rows.Count <> 0 Then
                Me.TextBox1.Text = tabla.Rows(0).Item("idFechaCierre")
                Me.TextBox2.Text = CDate(tabla.Rows(0).Item("fechaInicio")).ToString("yyyy/MM/dd")
                Me.TextBox3.Text = CDate(tabla.Rows(0).Item("fechaFinal")).ToString("yyyy/MM/dd")
            End If
        End With
    End Sub
End Class
