Imports System.Data
Imports System.IO

Partial Class Reportes_Varios_wfReporteProductosFacturados
    Inherits System.Web.UI.Page

    Dim empresas As New clsEmpresa
    Dim encabezadofactura As New clsTTEncFacturaPro
    Dim sucursales As New clsSucursale
    Dim operaciones As New clsOperacione

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarPaises()
            Me.TextBox1.Text = CDate(Now.Date).ToString("yyyy/MM/dd")
            Me.TextBox2.Text = CDate(Now.Date).ToString("yyyy/MM/dd")

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
        'Dim y As Integer
        Dim tabla2 As New DataTable
        Dim sql As String
        Dim tabla As New DataTable
        Me.Label5.Text = ""
        If Me.TextBox1.Text = "" Or Me.TextBox2.Text = "" Then
            Me.Label5.Text = "Seleccione la fecha...!"
            Exit Sub
        End If
        '
        If Me.DropDownList1.SelectedIndex = 0 Or Me.DropDownList2.SelectedIndex = 0 Then
            Me.Label5.Text = "Seleccione la empresa y la sucursal...!"
            Exit Sub
        End If
        '

        '
        Me.GridView4.DataSource = Nothing
        Me.GridView4.DataBind()
        '
        Me.GridView5.DataSource = Nothing
        Me.GridView5.DataBind()
        '
        'cargar los productos
        sql = "select" & _
        " idproducto," & _
        " nombreproducto," & _
        " (select isnull(sum(cantidaddetfacturapro),0)" & _
        " from vw_productosFacturadosAdmin t " & _
        " where" & _
        " t.idproducto = p.idproducto" & _
        " and t.fechaencfacturapro between '" & Me.TextBox1.Text & "' and '" & Me.TextBox2.Text & "'" & _
        " and t.estadoencfacturapro=1 and t.idempresa=" & Me.DropDownList1.SelectedValue & " and t.idsucursal=" & Me.DropDownList2.SelectedValue & _
        " and t.promodetfacturapro='N'" & _
        " ) as base," & _
        " (select isnull(sum(cantidaddetfacturapro),0)" & _
        " from vw_productosFacturadosAdmin t " & _
        " where" & _
        " t.idproducto = p.idproducto" & _
        " and t.fechaencfacturapro between  '" & Me.TextBox1.Text & "' and '" & Me.TextBox2.Text & "' " & _
        " and t.estadoencfacturapro=1 and t.idempresa=" & Me.DropDownList1.SelectedValue & " and t.idsucursal=" & Me.DropDownList2.SelectedValue & _
        " and t.promodetfacturapro='P'" & _
        " ) as promocion,'0' basepro," & _
        " (select isnull(sum(cantidaddetfacturapro),0)" & _
        " from vw_productosFacturadosAdmin t " & _
        " where" & _
        " t.idproducto = p.idproducto" & _
        " and t.fechaencfacturapro between  '" & Me.TextBox1.Text & "' and '" & Me.TextBox2.Text & "' " & _
        " and t.estadoencfacturapro=1 and t.idempresa=" & Me.DropDownList1.SelectedValue & " and t.idsucursal=" & Me.DropDownList2.SelectedValue & _
        " and t.promodetfacturapro='O'" & _
        " ) as obsequuio," & _
        " (select isnull(sum(cantidaddetfacturapro),0)" & _
        " from vw_productosFacturadosAdmin t " & _
        " where" & _
        " t.idproducto = p.idproducto" & _
        " and t.fechaencfacturapro between  '" & Me.TextBox1.Text & "' and '" & Me.TextBox2.Text & "' " & _
        " and t.estadoencfacturapro=1 and t.idempresa=" & Me.DropDownList1.SelectedValue & " and t.idsucursal=" & Me.DropDownList2.SelectedValue & _
        " and t.promodetfacturapro in('N','P','O')" & _
        " ) as total" & _
        " from tbproducto p where p.estadoproducto=1" & _
        " order by nombreProducto"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Dim miView As DataView = New DataView(tabla)
                miView.RowFilter = "total<>0"
                Me.GridView4.DataSource = miView
                Me.GridView4.DataBind()
                tituloGrilla()
                actualizarGrilla()
            Else
                Me.GridView4.DataSource = Nothing
                Me.GridView4.DataBind()
            End If
        End With
    End Sub

    Sub tituloGrilla()
        Me.GridView4.Caption = "Productos Facturados " & Me.DropDownList1.SelectedItem.Text & " - " & Me.DropDownList2.SelectedItem.Text & vbNewLine & "Desde " & Me.TextBox1.Text & " Hasta " & Me.TextBox2.Text
    End Sub

    Sub actualizarGrilla()
        Dim y As Integer
        For y = 0 To Me.GridView4.Rows.Count - 1
            If Me.GridView4.Rows(y).Cells(7).Text = "0" Then
                Me.GridView4.Rows(y).Cells(3).Text = ""
                Me.GridView4.Rows(y).Cells(4).Text = ""
                Me.GridView4.Rows(y).Cells(5).Text = ""
                Me.GridView4.Rows(y).Cells(6).Text = ""
                Me.GridView4.Rows(y).Cells(7).Text = ""
            Else
                Me.GridView4.Rows(y).Cells(5).Text = CDbl(Me.GridView4.Rows(y).Cells(3).Text) + CDbl(Me.GridView4.Rows(y).Cells(4).Text)

            End If
            
        Next
    End Sub

 
    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        If Me.GridView4.Rows.Count > 0 Then
            ExportToExcel("ProductosFacturados-" & Me.DropDownList1.SelectedItem.Text & "-" & Me.DropDownList2.SelectedItem.Text & "-" & Me.TextBox1.Text & "-" & Me.TextBox2.Text & ".xls", Me.GridView4)
        End If
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

    Protected Sub GridView4_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView4.SelectedIndexChanging

        Dim idProducto As Integer
        Dim tabla As New DataTable
        idProducto = Val(Me.GridView4.Rows(e.NewSelectedIndex).Cells(1).Text)
        With encabezadofactura
            .idEmpresa = Me.DropDownList1.SelectedValue
            .idSucursal = Me.DropDownList2.SelectedValue
            .fechaInicial = Me.TextBox1.Text
            .fechaFinal = Me.TextBox2.Text
            tabla = .obtenerDetalleProductosFacturados(idProducto)
            If tabla.Rows.Count <> 0 Then
                Me.GridView5.DataSource = tabla
                Me.GridView5.DataBind()
                'Me.Label4.Text = "Detalle Facturado: " & Me.GridView4.Rows(e.NewSelectedIndex).Cells(2).Text
            Else
                Me.GridView5.DataSource = Nothing
                Me.GridView5.DataBind()
                'Me.Label4.Text = ""
            End If
        End With
        '
        If Me.GridView5.Rows.Count <> 0 Then
            calcularTotales()
        End If
    End Sub

    Sub calcularTotales()
        Dim y As Integer
        Dim suma As Double = 0
        For y = 0 To Me.GridView5.Rows.Count - 1
            suma += Me.GridView5.Rows(y).Cells(2).Text
        Next
        Me.GridView5.FooterRow.Cells(0).Text = "Total:"
        Me.GridView5.FooterRow.Cells(2).Text = FormatNumber(suma, 0)
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

    Protected Sub ImageButton6_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton6.Click
        If Me.GridView5.Rows.Count > 0 Then
            ExportToExcelDetalle("Detalle-" & Me.DropDownList1.SelectedItem.Text & "-" & Me.DropDownList2.SelectedItem.Text & "-" & Me.TextBox1.Text & "-" & Me.TextBox2.Text & ".xls", Me.GridView5)
        End If
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
End Class
