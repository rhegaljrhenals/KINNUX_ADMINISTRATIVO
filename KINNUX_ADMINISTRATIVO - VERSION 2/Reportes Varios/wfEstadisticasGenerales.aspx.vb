Imports System.Data
Imports System.IO

Partial Class Reportes_Varios_wfReporteProductosFacturados
    Inherits System.Web.UI.Page

    Dim empresas As New clsEmpresa
    Dim encabezadofactura As New clsTTEncFacturaPro
    Dim sucursales As New clsSucursale

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarPaises()
            Me.TextBox1.Text = CDate(Now.Date).ToString("yyyy/MM/dd")
            Me.TextBox2.Text = CDate(Now.Date).ToString("yyyy/MM/dd")
            Me.CheckBox1.Checked = False
            Me.Panel2.Visible = False
            Me.Label6.Visible = False
            '
            Me.Panel3.Visible = False
            Me.Panel4.Visible = False
            Me.Panel5.Visible = False
            '
        End If
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
        Me.Label5.Text = ""
        If Me.TextBox1.Text = "" Or Me.TextBox2.Text = "" Then
            Me.Label5.Text = "Seleccione la fecha...!"
            Exit Sub
        End If
        '
        If Me.DropDownList1.SelectedIndex = 0 Then
            Me.Label5.Text = "Seleccione la empresa...!"
            Exit Sub
        End If
        '
        If Me.CheckBox1.Checked = True And Me.DropDownList2.SelectedIndex = 0 Then
            Me.Label5.Text = "Seleccione la sucursal...!"
            Exit Sub
        End If
        '
        mostrarProductosfacturados()
        mostrarTipoFacturacion()
        mostrarPaquetesFacturados()
    End Sub

    Sub mostrarPaquetesFacturados()
        Me.Panel5.Visible = False
        Me.GridView6.DataSource = Nothing
        Me.GridView6.DataBind()
        '
        Dim tabla As New DataTable
        Dim idSucursal As Integer
        If Me.CheckBox1.Checked = True Then
            idSucursal = Me.DropDownList2.SelectedValue
        Else
            idSucursal = 0
        End If
        With encabezadofactura
            .idEmpresa = Me.DropDownList1.SelectedValue
            .idSucursal = idSucursal
            .fechaInicial = Me.TextBox1.Text
            .fechaFinal = Me.TextBox2.Text
            tabla = .obtenerPaquetesFacturadosEstadisticas
            If tabla.Rows.Count <> 0 Then
                Me.Panel5.Visible = True
                Me.GridView6.DataSource = tabla
                Me.GridView6.DataBind()
                ' grafico
                Me.Chart3.DataSource = tabla
                Me.Chart3.Series(0).XValueMember = "nombrePaquete"
                Me.Chart3.Series(0).YValueMembers = "cantidad"
                Me.Chart3.DataBind()
            Else
                Me.GridView6.DataSource = Nothing
                Me.GridView6.DataBind()
            End If
        End With
    End Sub

    Sub mostrarTipoFacturacion()
        Me.Panel4.Visible = False
        Me.GridView5.DataSource = Nothing
        Me.GridView5.DataBind()
        '
        Dim tabla As New DataTable
        Dim idSucursal As Integer
        If Me.CheckBox1.Checked = True Then
            idSucursal = Me.DropDownList2.SelectedValue
        Else
            idSucursal = 0
        End If
        With encabezadofactura
            .idEmpresa = Me.DropDownList1.SelectedValue
            .idSucursal = idSucursal
            .fechaInicial = Me.TextBox1.Text
            .fechaFinal = Me.TextBox2.Text
            tabla = .obtenerTiposDeFacturacionEstadisticas
            If tabla.Rows.Count <> 0 Then
                Me.Panel4.Visible = True
                Me.GridView5.DataSource = tabla
                Me.GridView5.DataBind()
                ' grafico
                Me.Chart2.DataSource = tabla
                Me.Chart2.Series(0).XValueMember = "tipoEncfacturapro"
                Me.Chart2.Series(0).YValueMembers = "cantidad"
                Me.Chart2.DataBind()
            Else
                Me.GridView5.DataSource = Nothing
                Me.GridView5.DataBind()
            End If
        End With
    End Sub

    Sub mostrarProductosfacturados()
        Me.Panel3.Visible = False
        Me.GridView4.DataSource = Nothing
        Me.GridView4.DataBind()
        '
        Dim tabla As New DataTable
        Dim idSucursal As Integer
        If Me.CheckBox1.Checked = True Then
            idSucursal = Me.DropDownList2.SelectedValue
        Else
            idSucursal = 0
        End If
        With encabezadofactura
            .idEmpresa = Me.DropDownList1.SelectedValue
            .idSucursal = idSucursal
            .fechaInicial = Me.TextBox1.Text
            .fechaFinal = Me.TextBox2.Text
            tabla = .obtenerProductosFacturadosEstadisticas
            If tabla.Rows.Count <> 0 Then
                Me.Panel3.Visible = True
                Me.GridView4.DataSource = tabla
                Me.GridView4.DataBind()
                ' grafico
                Me.Chart1.DataSource = tabla
                Me.Chart1.Series(0).XValueMember = "nombreProducto"
                Me.Chart1.Series(0).YValueMembers = "cantidad"

                Me.Chart1.DataBind()
            Else
                Me.GridView4.DataSource = Nothing
                Me.GridView4.DataBind()
            End If
        End With
    End Sub

    Private Sub ExportToExcel(ByVal nameReport As String, ByVal wControl As GridView)
        Me.GridView4.Columns(0).Visible = False
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

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        If Me.GridView4.Rows.Count > 0 Then
            ExportToExcel("ProductosFacturados-" & Me.DropDownList1.SelectedItem.Text & "-" & Me.DropDownList2.SelectedItem.Text & "-" & Me.TextBox1.Text & "-" & Me.TextBox2.Text & ".xls", Me.GridView4)
        End If
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
        If Me.DropDownList1.SelectedIndex <> -1 Then
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
                Me.DropDownList2.DataTextField = "nombreSucursal"
                Me.DropDownList2.DataValueField = "idSucursal"
                Me.DropDownList2.DataBind()
            Else
                Me.DropDownList2.DataSource = Nothing
                Me.DropDownList2.DataBind()
            End If
            Me.DropDownList2.Items.Insert(0, "Seleccione Sucursal")
        End With
    End Sub

    Private Sub ExportToExcelDetalle(ByVal nameReport As String, ByVal wControl As GridView)
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
            Me.Label6.Visible = True
        Else
            Me.Panel2.Visible = False
            Me.Label6.Visible = False
        End If
    End Sub
End Class
