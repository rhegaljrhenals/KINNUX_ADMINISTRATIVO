Imports System.Data
Imports System.IO

Partial Class Reportes_Varios_wfReporteComisionesIR
    Inherits System.Web.UI.Page

    Dim paises As New clsPaise
    Dim comisionesIR As New clsTTComisionIr
    Dim empresas As New clsEmpresa

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarPaises()
            Me.TextBox1.Text = CDate(Now.Date).ToString("yyyy/MM/dd")
            Me.TextBox2.Text = CDate(Now.Date).ToString("yyyy/MM/dd")
            Me.RadioButton1.Checked = True
            Me.Panel2.Visible = False
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    Sub cargarPaises()
        Dim tabla As New DataTable
        With empresas
            tabla = .MostrarEmpresaGeneral
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList1.DataSource = tabla
                Me.DropDownList1.DataTextField = "nombreempresa"
                Me.DropDownList1.DataValueField = "idempresa"
                Me.DropDownList1.DataBind()
            Else
                Me.DropDownList1.DataSource = Nothing
                Me.DropDownList1.DataBind()
            End If
            Me.DropDownList1.Items.Insert(0, "Seleccione Empresa")
        End With
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Label4.Text = ""
        Dim tipo As Integer
        Dim textoTipo As String = ""
        Dim tabla As New DataTable
        If Me.RadioButton1.Checked = True Then
            tipo = 1
            textoTipo = "Pagadas"
        Else
            If Me.RadioButton2.Checked = True Then
                tipo = 2
                textoTipo = "Pendientes"
            Else
                If Me.RadioButton3.Checked = True Then
                    tipo = 3
                    textoTipo = "Sin Cobrar"
                Else
                    tipo = 4
                    textoTipo = "Todas"
                End If
            End If
        End If
        '
        Dim codigo As String = ""
        If Me.CheckBox1.Checked = True Then
            codigo = Me.TextBox3.Text
        End If
        With comisionesIR
            .idEmpresa = Me.DropDownList1.SelectedValue
            .codigoAfiliado = codigo
            .fechaInicial = Me.TextBox1.Text
            .fechaFinal = Me.TextBox2.Text
            tabla = .obtenerComisionesPagadasIR(Me.DropDownList1.SelectedValue, tipo, codigo)
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
                Me.Label4.Text = "Comisiones Inicio Rápido " & Me.DropDownList1.SelectedItem.Text & " (" & Me.TextBox1.Text & "-" & Me.TextBox2.Text & ") *** " & textoTipo & " ***"
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
                Me.Label4.Text = " "
            End If
        End With
        '
        If Me.GridView2.Rows.Count <> 0 Then
            calcularTotales()
            actualizarGrilla()
        End If
    End Sub

    Sub actualizarGrilla()
        Dim y As Integer
        For y = 0 To Me.GridView2.Rows.Count - 1
            If Me.GridView2.Rows(y).Cells(8).Text = "No Cobrada" Or Me.GridView2.Rows(y).Cells(8).Text = "Pendiente" Or Me.GridView2.Rows(y).Cells(8).Text = "Comprimida" Then
                Me.GridView2.Rows(y).Cells(7).Text = ""
            End If
        Next
    End Sub

    Sub calcularTotales()
        Dim y As Integer
        Dim suma As Double = 0
        For y = 0 To Me.GridView2.Rows.Count - 1
            suma += Me.GridView2.Rows(y).Cells(3).Text
        Next
        Me.GridView2.FooterRow.Cells(3).Text = FormatNumber(suma, 2)
        Me.GridView2.FooterRow.Cells(0).Text = "Total:"
    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        If Me.GridView2.Rows.Count <> 0 Then
            ExportToExcel("ComisionesIR-" & Me.DropDownList1.SelectedItem.Text & "-" & Me.TextBox1.Text & "-" & Me.TextBox2.Text & ".xls", Me.GridView2)
        End If
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

    Protected Sub CheckBox1_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            Me.Panel2.Visible = True
            Me.TextBox3.Focus()
        Else
            Me.Panel2.Visible = False
        End If
    End Sub
End Class
