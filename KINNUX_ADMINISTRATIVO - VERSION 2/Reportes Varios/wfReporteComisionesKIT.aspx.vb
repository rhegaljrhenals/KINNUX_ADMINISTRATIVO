Imports System.Data
Imports System.IO

Partial Class Reportes_Varios_wfReporteComisionesIR
    Inherits System.Web.UI.Page

    Dim paises As New clsPaise
    Dim comisionesKIT As New clsTTComisionKit
    Dim empresas As New clsEmpresa
    Dim sucursales As New clsSucursale

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarEmpresas()
            'cargarPaises()
            Me.TextBox1.Text = CDate(Now.Date).ToString("yyyy/MM/dd")
            Me.TextBox2.Text = CDate(Now.Date).ToString("yyyy/MM/dd")
            Me.RadioButton1.Checked = True
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    Sub cargarEmpresas()
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
        End With
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim tipo As Integer
        Dim tabla As New DataTable
        Dim textoTipo As String = ""
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
                    If Me.RadioButton4.Checked = True Then
                        tipo = 4
                        textoTipo = "Todas"
                    End If
                End If
            End If
        End If
        '
        Select Case tipo
            Case Is = 1
                Me.GridView2.Columns(6).Visible = True
            Case 2, 3, 4
                Me.GridView2.Columns(6).Visible = False
        End Select
        With comisionesKIT
            .fechaInicial = Me.TextBox1.Text
            .fechaFinal = Me.TextBox2.Text
            .idEmpresa = Me.DropDownList1.SelectedValue
            .idSucursal = Me.DropDownList2.SelectedValue
            tabla = .obtenerComisionesPagadasKIT(tipo)
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
                Me.Label4.Text = "Comisiones Bonos De Inscripción " & Me.DropDownList1.SelectedItem.Text & " (" & Me.TextBox1.Text & "-" & Me.TextBox2.Text & ") *** " & textoTipo & " ***"
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
                Me.Label4.Text = ""
            End If
        End With
        '
        If Me.GridView2.Rows.Count <> 0 Then
            calcularTotales()
        End If
    End Sub

    Sub calcularTotales()
        Dim y As Integer
        Dim suma As Double = 0
        For y = 0 To Me.GridView2.Rows.Count - 1
            suma += Me.GridView2.Rows(y).Cells(2).Text
        Next
        Me.GridView2.FooterRow.Cells(2).Text = FormatNumber(suma, 2)
        Me.GridView2.FooterRow.Cells(0).Text = "Total:"
    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        If Me.GridView2.Rows.Count <> 0 Then
            ExportToExcel("BonoInscripcion-" & Me.DropDownList1.SelectedItem.Text & "-" & Me.TextBox1.Text & "-" & Me.TextBox2.Text & ".xls", Me.GridView2)
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

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
        If Me.DropDownList1.SelectedIndex > 0 Then
            cargarSucursales()
        End If
    End Sub

    Sub cargarSucursales()
        Dim tabla As New DataTable
        With sucursales
            .idEmpresa = Me.DropDownList1.SelectedValue
            tabla = .obtenerSucursalePorEmpresa
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList2.DataSource = tabla
                Me.DropDownList2.DataTextField = "nombresucursal"
                Me.DropDownList2.DataValueField = "idsucursal"
                Me.DropDownList2.DataBind()
            Else
                Me.DropDownList2.DataSource = Nothing
                Me.DropDownList2.DataBind()
            End If
            Me.DropDownList2.Items.Insert(0, "Seleccione Sucursal")
        End With
    End Sub
End Class
