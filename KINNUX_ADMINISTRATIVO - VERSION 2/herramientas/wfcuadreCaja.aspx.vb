Imports System.Data
Imports System.IO

Partial Class Herramientas_wfcuadreCaja
    Inherits System.Web.UI.Page

    Dim encabezadofacturas As New clsTTEncFacturaPro
    Dim comisionesIR As New clsTTComisionIr
    Dim comisionesKIT As New clsTTComisionKit
    Dim resumenCuadre As New clsTBResumenCuadreCaja
    Dim monedaLocal As New clsTbMonedaLocal
    Dim encabezadofactura As New clsTTEncFacturaPro
    Dim empresas As New clsEmpresa
    Dim sucursales As New clsSucursale
    Dim usuarios As New clsUsuario
    Dim comisionesMensuales As New clsTTComision
    Dim comisionesBinaria As New clsTTBBinario

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            Me.Panel1.Visible = False
            Me.Panel2.Visible = False
            Me.Panel3.Visible = False
            cargarEmpresas()
            cargarAno()
            Me.MultiView1.ActiveViewIndex = 0
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    Sub cargarEmpresas()
        Dim tabla As New DataTable
        With empresas
            tabla = .MostrarEmpresaGeneral
            Me.DropDownList18.DataSource = tabla
            Me.DropDownList18.DataTextField = "nombreempresa"
            Me.DropDownList18.DataValueField = "idEmpresa"
            Me.DropDownList18.DataBind()
        End With
        '
        Me.DropDownList18.Items.Insert(0, "Seleccione empresa")
    End Sub

    Sub cargarResumenCuadreCaja()
        Dim tabla As New DataTable
        With resumenCuadre
            tabla = .obtenerItems
            If tabla.Rows.Count <> 0 Then
                Me.GridView7.DataSource = tabla
                Me.GridView7.DataBind()
            Else
                Me.GridView7.DataSource = Nothing
                Me.GridView7.DataBind()
            End If
            '
            tabla = .obtenerResumenFormasPago
            If tabla.Rows.Count <> 0 Then
                Me.GridView9.DataSource = tabla
                Me.GridView9.DataBind()
            Else
                Me.GridView9.DataSource = Nothing
                Me.GridView9.DataBind()
            End If
        End With
        '

    End Sub

    Sub cargarAno()
        Dim y As Integer
        For y = 2011 To Now.Year
            Me.DropDownList12.Items.Add(y)
            Me.DropDownList15.Items.Add(y)
            '
            Me.DropDownList12.DataValueField = y
            Me.DropDownList15.DataValueField = y
        Next
        '
        Me.DropDownList12.Items.Insert(0, "Año")
        Me.DropDownList15.Items.Insert(0, "Año")
    End Sub

    Sub cargarProductosFacturados()
        '
        Me.GridView4.DataSource = Nothing
        Me.GridView4.DataBind()
        '
        Me.GridView8.DataSource = Nothing
        Me.GridView8.DataBind()
        '
        Dim tabla As New DataTable
        With encabezadofactura
            .idEmpresa = Me.DropDownList18.SelectedValue 'Request.QueryString("ie")
            .idSucursal = Me.DropDownList2.SelectedValue 'Request.QueryString("is")
            .fechaInicial = Me.DropDownList12.SelectedItem.Text & "/" & Me.DropDownList13.SelectedValue & "/" & Me.DropDownList14.SelectedValue
            .fechaFinal = Me.DropDownList15.SelectedItem.Text & "/" & Me.DropDownList16.SelectedValue & "/" & Me.DropDownList17.SelectedValue
            .idUsuario = Request.QueryString("iu") 'Session("idusuario")
            tabla = .obtenerProductosFacturadosPorusuarios
            If tabla.Rows.Count <> 0 Then
                Me.GridView4.DataSource = tabla
                Me.GridView4.DataBind()
            Else
                Me.GridView4.DataSource = Nothing
                Me.GridView4.DataBind()
            End If
        End With
        ' kit de afiliacion
        With encabezadofactura
            .idEmpresa = Me.DropDownList18.SelectedValue 'Request.QueryString("ie")
            .idSucursal = Me.DropDownList2.SelectedValue 'Request.QueryString("is")
            .fechaInicial = Me.DropDownList12.SelectedItem.Text & "/" & Me.DropDownList13.SelectedValue & "/" & Me.DropDownList14.SelectedValue
            .fechaFinal = Me.DropDownList15.SelectedItem.Text & "/" & Me.DropDownList16.SelectedValue & "/" & Me.DropDownList17.SelectedValue
            '.idUsuario = Request.QueryString("iu") 'Session("idusuario")
            tabla = .obtenerProductosFacturadosRemisionesKIT
            If tabla.Rows.Count <> 0 Then
                Me.GridView8.DataSource = tabla
                Me.GridView8.DataBind()
            Else
                Me.GridView8.DataSource = Nothing
                Me.GridView8.DataBind()
            End If
        End With

    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Panel1.Visible = False
        Me.Panel2.Visible = False
        Me.Panel3.Visible = False
        Me.Label4.Text = ""
        Me.Label5.Text = ""
        Me.Label6.Text = ""
        Me.Label7.Text = ""
        Me.Label8.Text = "0,00"
        '
        If Me.DropDownList12.SelectedIndex = 0 Or Me.DropDownList13.SelectedIndex = 0 Or Me.DropDownList14.SelectedIndex = 0 Then
            Me.Label4.Text = "Seleccione la fecha inicial correctamente...!"
            Exit Sub
        End If
        '
        If Me.DropDownList15.SelectedIndex = 0 Or Me.DropDownList16.SelectedIndex = 0 Or Me.DropDownList17.SelectedIndex = 0 Then
            Me.Label5.Text = "Seleccione la fecha final correctamente...!"
            Exit Sub
        End If
        '
        If Me.DropDownList18.SelectedIndex = 0 Or Me.DropDownList18.SelectedIndex = -1 Then
            Me.Label6.Text = "Seleccione la empresa o pais...!"
            Exit Sub
        End If
        '
        If Me.DropDownList2.SelectedIndex = 0 Or Me.DropDownList2.SelectedIndex = -1 Then
            Me.Label7.Text = "Seleccione la sucursal...!"
            Exit Sub
        End If
        cargarResumenCuadreCaja()
        mostrarRemisiones()
        mostrarComisionesIR()
        mostrarComisionesKIT()
        mostrarComisionesMensuales()
        mostrarComisionesBinaria()
        cargarProductosFacturados()
        '
        If Me.GridView5.Rows.Count <> 0 Then
            Me.Panel1.Visible = True
            mostrarTotalesRemisiones()
        End If
        '
        If Me.GridView2.Rows.Count <> 0 Then
            Me.Panel2.Visible = True
            mostrarTotalesIR()
        End If
        '
        If Me.GridView6.Rows.Count <> 0 Then
            Me.Panel3.Visible = True
            mostrarTotalesKIT()
        End If
        '
        If Me.GridView10.Rows.Count <> 0 Then
            mostrarTotalesComisionesMensuales()
        End If
        '
        If Me.GridView11.Rows.Count <> 0 Then
            mostrarTotalesComisionesBinaria()
        End If
        '------------------------------------------------------------------
        ' total a entregar
        Dim totalEgresos As Double
        Dim totalIngresos As Double
        Dim totalaEntregar As Double
        totalIngresos = (CDbl(Me.GridView7.Rows(0).Cells(1).Text))
        totalEgresos = (CDbl(Me.GridView7.Rows(1).Cells(1).Text) + CDbl(Me.GridView7.Rows(2).Cells(1).Text) + CDbl(Me.GridView7.Rows(3).Cells(1).Text) + CDbl(Me.GridView7.Rows(4).Cells(1).Text))
        totalaEntregar = (totalIngresos - totalEgresos)
        Me.GridView7.FooterRow.Cells(1).Text = FormatNumber(totalaEntregar, 2)
        '------------------------------------------------------------------
    End Sub

    Sub mostrarTotalesComisionesBinaria()
        Dim y As Integer
        Dim suma1 As Double = 0
        '
        For y = 0 To Me.GridView11.Rows.Count - 1
            suma1 += CDbl(Me.GridView11.Rows(y).Cells(2).Text)
        Next
        '
        Me.GridView11.FooterRow.Cells(0).Text = "Total:"
        Me.GridView11.FooterRow.Cells(2).Text = FormatNumber(suma1, 2)
        '
        Me.GridView7.Rows(4).Cells(1).Text = FormatNumber(suma1, 2)
    End Sub

    Sub mostrarComisionesBinaria()
        Dim tabla As New DataTable
        With comisionesBinaria
            .idPais = Me.DropDownList18.SelectedValue
            .idSucursal = Me.DropDownList2.SelectedValue
            .idEmpresa = Me.DropDownList18.SelectedValue 'Request.QueryString("ie")
            .fechaInicial = Me.DropDownList12.SelectedItem.Text & "/" & Me.DropDownList13.SelectedValue & "/" & Me.DropDownList14.SelectedValue
            .fechaFinal = Me.DropDownList15.SelectedItem.Text & "/" & Me.DropDownList16.SelectedValue & "/" & Me.DropDownList17.SelectedValue
            tabla = .obtenerComisionesPagadasPorUsuario
            If tabla.Rows.Count <> 0 Then
                Me.GridView11.DataSource = tabla
                Me.GridView11.DataBind()
            Else
                Me.GridView11.DataSource = Nothing
                Me.GridView11.DataBind()
            End If
        End With
    End Sub

    Sub mostrarTotalesComisionesMensuales()
        Dim y As Integer
        Dim suma1 As Double = 0
        '
        For y = 0 To Me.GridView10.Rows.Count - 1
            suma1 += CDbl(Me.GridView10.Rows(y).Cells(2).Text)
        Next
        '
        Me.GridView10.FooterRow.Cells(0).Text = "Total:"
        Me.GridView10.FooterRow.Cells(2).Text = FormatNumber(suma1, 2)
        '
        Me.GridView7.Rows(3).Cells(1).Text = FormatNumber(suma1, 2)
    End Sub

    Sub mostrarComisionesMensuales()
        Dim tabla As New DataTable
        With comisionesMensuales
            .idPais = Me.DropDownList18.SelectedValue
            .idSucursal = Me.DropDownList2.SelectedValue
            .idEmpresa = Me.DropDownList18.SelectedValue 'Request.QueryString("ie")
            .fechaInicial = Me.DropDownList12.SelectedItem.Text & "/" & Me.DropDownList13.SelectedValue & "/" & Me.DropDownList14.SelectedValue
            .fechaFinal = Me.DropDownList15.SelectedItem.Text & "/" & Me.DropDownList16.SelectedValue & "/" & Me.DropDownList17.SelectedValue
            tabla = .obtenerComisionesMensualesCuadreCaja
            If tabla.Rows.Count <> 0 Then
                Me.GridView10.DataSource = tabla
                Me.GridView10.DataBind()
            Else
                Me.GridView10.DataSource = Nothing
                Me.GridView10.DataBind()
            End If
        End With
    End Sub

    Sub mostrarTotalesKIT()
        Dim tabla As New DataTable
        Dim y As Integer
        Dim suma1 As Double = 0
        '
        For y = 0 To Me.GridView6.Rows.Count - 1
            suma1 += CDbl(Me.GridView6.Rows(y).Cells(2).Text)
        Next
        '
        Me.GridView6.FooterRow.Cells(0).Text = "Total:"
        Me.GridView6.FooterRow.Cells(2).Text = FormatNumber(suma1, 2)
        '
        Me.GridView7.Rows(2).Cells(1).Text = FormatNumber(suma1, 2)
    End Sub

    Sub mostrarComisionesKIT()
        Dim tabla As New DataTable
        With comisionesKIT
            .idPais = Me.DropDownList18.SelectedValue
            .idSucursal = Me.DropDownList2.SelectedValue
            .idEmpresa = Me.DropDownList18.SelectedValue 'Request.QueryString("ie")
            .fechaInicial = Me.DropDownList12.SelectedItem.Text & "/" & Me.DropDownList13.SelectedValue & "/" & Me.DropDownList14.SelectedValue
            .fechaFinal = Me.DropDownList15.SelectedItem.Text & "/" & Me.DropDownList16.SelectedValue & "/" & Me.DropDownList17.SelectedValue
            .usuarioPagoComisionKit = Session("idusuario")
            tabla = .comisionesKITCuadreCaja()
            If tabla.Rows.Count <> 0 Then
                Me.GridView6.DataSource = tabla
                Me.GridView6.DataBind()
            Else
                Me.GridView6.DataSource = Nothing
                Me.GridView6.DataBind()
            End If

        End With
    End Sub

    Sub mostrarTotalesIR()
        Dim tabla As New DataTable
        Dim y As Integer
        Dim suma1 As Double = 0
        '
        For y = 0 To Me.GridView2.Rows.Count - 1
            suma1 += CDbl(Me.GridView2.Rows(y).Cells(2).Text)
        Next
        '
        Me.GridView2.FooterRow.Cells(0).Text = "Total:"
        Me.GridView2.FooterRow.Cells(2).Text = FormatNumber(suma1, 2)
        Me.GridView7.Rows(1).Cells(1).Text = FormatNumber(suma1, 2)
    End Sub

    Sub mostrarComisionesIR()
        Dim tabla As New DataTable
        '
        With comisionesIR
            .idPais = Me.DropDownList18.SelectedValue
            .idSucursal = Me.DropDownList2.SelectedValue
            .idEmpresa = Me.DropDownList18.SelectedValue 'Request.QueryString("ie")
            .fechaInicial = Me.DropDownList12.SelectedItem.Text & "/" & Me.DropDownList13.SelectedValue & "/" & Me.DropDownList14.SelectedValue
            .fechaFinal = Me.DropDownList15.SelectedItem.Text & "/" & Me.DropDownList16.SelectedValue & "/" & Me.DropDownList17.SelectedValue
            tabla = .comisionesIRCuadreCaja()
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If

        End With
    End Sub

    Sub mostrarTotalesRemisiones()
        Dim y As Integer
        Dim sumaNeto As Double = 0
        Dim sumaPuntos As Double = 0
        Dim suma1 As Double = 0
        Dim suma2 As Double = 0
        Dim suma3 As Double = 0
        Dim suma4 As Double = 0
        Dim suma5 As Double = 0
        Dim suma6 As Double = 0
        '
        If Me.GridView5.Rows.Count <> 0 Then
            For y = 0 To Me.GridView5.Rows.Count - 1
                sumaNeto += CDbl(Me.GridView5.Rows(y).Cells(3).Text)
                sumaPuntos += CDbl(Me.GridView5.Rows(y).Cells(4).Text)
                suma1 += CDbl(Me.GridView5.Rows(y).Cells(6).Text)
                suma2 += CDbl(Me.GridView5.Rows(y).Cells(7).Text)
                suma3 += CDbl(Me.GridView5.Rows(y).Cells(8).Text)
                suma4 += CDbl(Me.GridView5.Rows(y).Cells(9).Text)
                suma5 += CDbl(Me.GridView5.Rows(y).Cells(10).Text)
                suma6 += CDbl(Me.GridView5.Rows(y).Cells(11).Text)
            Next
            Me.GridView5.FooterRow.Cells(0).Text = "Total:"
            Me.GridView5.FooterRow.Cells(3).Text = FormatNumber(sumaNeto, 2)
            Me.GridView5.FooterRow.Cells(4).Text = FormatNumber(sumaPuntos, 2)
            Me.GridView5.FooterRow.Cells(6).Text = FormatNumber(suma1, 2)
            Me.GridView5.FooterRow.Cells(7).Text = FormatNumber(suma2, 2)
            Me.GridView5.FooterRow.Cells(8).Text = FormatNumber(suma3, 2)
            Me.GridView5.FooterRow.Cells(9).Text = FormatNumber(suma4, 2)
            Me.GridView5.FooterRow.Cells(10).Text = FormatNumber(suma5, 2)
            Me.GridView5.FooterRow.Cells(11).Text = FormatNumber(suma6, 2)
            '
            Me.GridView7.Rows(0).Cells(1).Text = FormatNumber(suma1, 2)
            '
            '---------------------------------------------------------------------
            ' resumen formas de pago
            Me.GridView9.Rows(0).Cells(1).Text = FormatNumber(suma1, 2)
            Me.GridView9.Rows(1).Cells(1).Text = FormatNumber(suma4, 2)
            Me.GridView9.Rows(2).Cells(1).Text = FormatNumber(suma5, 2)
            Me.GridView9.Rows(3).Cells(1).Text = FormatNumber(suma2, 2)
            Me.GridView9.Rows(4).Cells(1).Text = FormatNumber(suma3, 2)
            Me.GridView9.Rows(5).Cells(1).Text = FormatNumber(suma6, 2)
            Me.GridView9.FooterRow.Cells(0).Text = "Total:"
            Me.GridView9.FooterRow.Cells(1).Text = FormatNumber(sumaNeto, 2)
            Me.Label8.Text = FormatNumber(sumaPuntos, 2)
        Else
            Me.Label8.Text = "0,00"
        End If
        '---------------------------------------------------------------------
    End Sub

    Sub mostrarRemisiones()
        Dim idSucursal As Integer = 0
        Dim tabla As New DataTable
        With encabezadofacturas
            .idEmpresa = Me.DropDownList18.SelectedValue 'Request.QueryString("ie")
            .idSucursal = Me.DropDownList2.SelectedValue 'Request.QueryString("is")
            .fechaInicial = Me.DropDownList12.SelectedItem.Text & "/" & Me.DropDownList13.SelectedValue & "/" & Me.DropDownList14.SelectedValue
            .fechaFinal = Me.DropDownList15.SelectedItem.Text & "/" & Me.DropDownList16.SelectedValue & "/" & Me.DropDownList17.SelectedValue
            .idUsuario = Request.QueryString("iu") 'Session("idusuario")
            '
            tabla = .RemisionesCuadreDeCaja
            If tabla.Rows.Count <> 0 Then
                Me.GridView5.DataSource = tabla
                Me.GridView5.DataBind()
            Else
                Me.GridView5.DataSource = Nothing
                Me.GridView5.DataBind()
            End If
        End With
    End Sub

    Protected Sub ImageButton8_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton8.Click
        If Me.GridView5.Rows.Count <> 0 Then
            ExportToExcel("Remisiones.xls", GridView5)
        End If
    End Sub

    Private Sub ExportToExcel(ByVal nameReport As String, ByVal wControl As GridView)
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

    Protected Sub ImageButton9_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
        If Me.GridView2.Rows.Count <> 0 Then
            ExportToExcel("ComisionesIR.xls", GridView2)
        End If
    End Sub


    Protected Sub ImageButton10_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton10.Click
        If Me.GridView6.Rows.Count <> 0 Then
            ExportToExcel("ComisionesKIT-.xls", GridView6)
        End If
    End Sub

    Protected Sub Menu1_MenuItemClick(sender As Object, e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu1.MenuItemClick
        Select Case e.Item.Text
            Case Is = "Facturacion"
                Me.MultiView1.ActiveViewIndex = 0
            Case Is = "Comisiones Inicio Rapido"
                Me.MultiView1.ActiveViewIndex = 1
            Case Is = "Comisiones De Inscripcion"
                Me.MultiView1.ActiveViewIndex = 2
            Case Is = "Resumen"
                Me.MultiView1.ActiveViewIndex = 3
            Case Is = "Productos Facturados"
                Me.MultiView1.ActiveViewIndex = 4
            Case Is = "Comisiones Mensuales"
                Me.MultiView1.ActiveViewIndex = 5
            Case Is = "Comisiones Binarias"
                Me.MultiView1.ActiveViewIndex = 6
        End Select
    End Sub

    Protected Sub ImageButton11_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton11.Click
        If Me.GridView7.Rows.Count <> 0 Then
            ExportToExcel("Resumen.xls", GridView7)
        End If
    End Sub

    Protected Sub ImageButton12_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton12.Click
        If Me.GridView4.Rows.Count <> 0 Then
            ExportToExcel("ProductosFacturados.xls", GridView4)
        End If
    End Sub

    Protected Sub DropDownList18_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles DropDownList18.SelectedIndexChanged
        If Me.DropDownList18.SelectedIndex > 0 Then
            cargarSucursales()
        End If
    End Sub

    Sub cargarSucursales()
        Dim tabla As New DataTable
        With sucursales
            .idEmpresa = Me.DropDownList18.SelectedValue
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

    Protected Sub ImageButton13_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton13.Click
        If Me.GridView10.Rows.Count <> 0 Then
            ExportToExcel("comisionesMensuales-" & Me.DropDownList18.SelectedItem.Text & " - " & Me.DropDownList2.SelectedItem.Text & ".xls", GridView10)
        End If
    End Sub

    Protected Sub ImageButton14_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton14.Click
        If Me.GridView11.Rows.Count <> 0 Then
            ExportToExcel("comisionesBinarias-" & Me.DropDownList18.SelectedItem.Text & " - " & Me.DropDownList2.SelectedItem.Text & ".xls", GridView11)
        End If
    End Sub
End Class
