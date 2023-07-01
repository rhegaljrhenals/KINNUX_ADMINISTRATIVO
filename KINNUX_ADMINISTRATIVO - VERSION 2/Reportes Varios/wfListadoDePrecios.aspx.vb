Imports System.Data
Imports System.IO

Partial Class Basicos_wfActualizacionPrecios
    Inherits System.Web.UI.Page

    Dim empresas As New clsEmpresa
    Dim productos As New clsProducto
    Dim paquetes As New clsTBPaquete
    Dim paquetePais As New clsPaquete

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarEmpresas()
            Me.ImageButton2.Visible = False
            Me.ImageButton3.Visible = False
        End If
    End Sub

    Sub cargarEmpresas()
        Dim tabla As New DataTable
        With empresas
            tabla = .MostrarEmpresaGeneral
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList1.DataSource = tabla
                Me.DropDownList1.DataTextField = "nombreempresa"
                Me.DropDownList1.DataValueField = "idpais"
                Me.DropDownList1.DataBind()
            Else
                Me.DropDownList1.DataSource = Nothing
                Me.DropDownList1.DataBind()
            End If
            Me.DropDownList1.Items.Insert(0, "Seleccione Empresa")
        End With
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.ImageButton2.Visible = False
        Me.ImageButton3.Visible = False
        '
        If Me.DropDownList1.SelectedIndex > 0 Then
            listadoPreciosPaquetes()
            listadoPreciosProductos()
            Me.ImageButton2.Visible = True
            Me.ImageButton3.Visible = True
        End If
    End Sub

    Sub listadoPreciosProductos()
        Dim tabla As New DataTable
        With productos
            .idPais = Me.DropDownList1.SelectedValue 'Session("idpais")
            tabla = .listadoPreciosProductosPorPais
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End With
    End Sub

    Sub listadoPreciosPaquetes()
        Dim tabla As New DataTable
        With paquetePais
            .idPais = Me.DropDownList1.SelectedValue 'Session("idpais")
            tabla = .listadoPreciosPaquetesPorPais
            If tabla.Rows.Count <> 0 Then
                Me.GridView3.DataSource = tabla
                Me.GridView3.DataBind()
            Else
                Me.GridView3.DataSource = Nothing
                Me.GridView3.DataBind()
            End If
        End With
    End Sub

    

    Sub mostrarVentana()
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('Precios Productos Actualizados En El Sistema...!');", True)
    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        If Me.GridView2.Rows.Count <> 0 Then
            ExportToExcelProductos("PreciosProductos-" & Me.DropDownList1.SelectedItem.Text & ".xls", Me.GridView2)
        End If

    End Sub

    Private Sub ExportToExcelProductos(ByVal nameReport As String, ByVal wControl As GridView)
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

    Sub mostrarVentanaPaquete()
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('Precios Paquetes Actualizados En El Sistema...!');", True)
    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        If Me.GridView3.Rows.Count <> 0 Then
            ExportToExcel("PreciosPaquetes-" & Me.DropDownList1.SelectedItem.Text & ".xls", Me.GridView3)
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
End Class
