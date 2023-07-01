Imports System.Data
Imports System.IO

Partial Class Reportes_Varios_wfReporteTTBBinario
    Inherits System.Web.UI.Page

    Dim objTTBbinario As New clsTTBBinario
    Dim grupalBinario As New clsTTGrupalbinario
    Dim paises As New clsPaise

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarAno()
            cargarPaises()
            Me.ImageButton2.Visible = False
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub cargarPaises()
        Dim tabla As New DataTable
        With paises
            tabla = .MostrarPaise
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList1.DataSource = tabla
                Me.DropDownList1.DataTextField = "nombrepais"
                Me.DropDownList1.DataValueField = "codigopais"
                Me.DropDownList1.DataBind()
            Else
                Me.DropDownList1.DataSource = Nothing
                Me.DropDownList1.DataBind()
            End If
            Me.DropDownList1.Items.Insert(0, "Todos Los Paises")
        End With
    End Sub

    Sub cargarAno()
        Dim y As Integer
        For y = 2012 To Now.Year
            Me.DropDownList9.Items.Add(y)
            Me.DropDownList12.Items.Add(y)
        Next
    End Sub

    Protected Sub GridView2_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        Dim codigoPatrocinador As String = ""
        Dim tabla As New DataTable
        Dim codigoPais As Integer
        Me.ImageButton2.Visible = False
        '
        If Me.DropDownList1.SelectedIndex = 0 Then
            codigoPais = 0
        Else
            codigoPais = Me.DropDownList1.SelectedValue
        End If
        '
        With objTTBbinario
            .codigoPais = codigoPais
            .fechaInicial = Me.GridView2.Rows(e.NewSelectedIndex).Cells(3).Text
            .fechaFinal = Me.GridView2.Rows(e.NewSelectedIndex).Cells(4).Text
            tabla = .obtenerDetalleBonoPatrimonio
            If tabla.Rows.Count <> 0 Then
                Me.GridView4.DataSource = tabla
                Me.GridView4.DataBind()
                '
                Me.ImageButton2.Visible = True
            Else
                Me.GridView4.DataSource = Nothing
                Me.GridView4.DataBind()
                Me.ImageButton2.Visible = False
            End If
        End With
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim encontroDatos As String = "no"
        Dim codigoPais As Integer
        Dim tabla As New DataTable
        Me.GridView2.DataSource = Nothing
        Me.GridView2.DataBind()
        '
        Me.GridView4.DataSource = Nothing
        Me.GridView4.DataBind()
        '
        Me.ImageButton2.Visible = False
        '
        Me.GridView2.Caption = "Periodo: " & Me.DropDownList10.SelectedItem.Text & " De " & Me.DropDownList9.SelectedValue & " (" & Me.DropDownList1.SelectedItem.Text & ")"
        If Me.DropDownList1.SelectedIndex = 0 Then
            codigoPais = 0
        Else
            codigoPais = Me.DropDownList1.SelectedValue
        End If
        With objTTBbinario
            .codigoPais = codigoPais
            .fechaInicial = Me.DropDownList9.SelectedItem.Text & "/" & Me.DropDownList10.SelectedValue & "/" & Me.DropDownList11.SelectedValue
            .fechaFinal = Me.DropDownList12.SelectedItem.Text & "/" & Me.DropDownList13.SelectedValue & "/" & Me.DropDownList14.SelectedValue
            tabla = .obtenerDatosTrimestralBonoPatrimonio
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End With
    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        'panelDatos.Visible = False
        ExportToExcel("ReporteBinario-" & Me.DropDownList9.SelectedItem.Text & "-" & Me.DropDownList10.SelectedItem.Text & "-" & Me.DropDownList1.SelectedItem.Text & ".xls", Me.GridView4)
    End Sub

    Private Sub ExportToExcel(ByVal nameReport As String, ByVal wControl As GridView)
        'Me.GridView2.Columns(0).Visible = False
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
End Class
