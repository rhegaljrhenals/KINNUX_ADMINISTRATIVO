Imports System.Data

Partial Class Reportes_Varios_wfReportegrupal
    Inherits System.Web.UI.Page

    Dim grupales As New clsTTgrupal

    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarAno()
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub cargarAno()
        Dim y As Integer
        For y = 2012 To Now.Year
            Me.DropDownList12.Items.Add(y)
        Next
    End Sub

    Protected Sub ImageButton9_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
        Dim tabla As New DataTable
        With grupales
            .mesSeleccionado = Me.DropDownList13.SelectedValue
            .anoSeleccionado = Me.DropDownList12.SelectedItem.Text
            tabla = .obtenerdatosGrupales
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End With
    End Sub
End Class
