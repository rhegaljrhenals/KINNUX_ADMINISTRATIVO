Imports System.Data
Imports System.IO

Partial Class Reportes_Varios_wfComisionMensualCiclos
    Inherits System.Web.UI.Page

    Dim objTTComision As New clsTTComision
    Dim paises As New clsPaise
    Dim empresas As New clsEmpresa
    Dim sucursales As New clsSucursale

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            'cargarPaises()
            cargarEmpresas()
            cargarAno()
            Me.ImageButton2.Visible = False
            Me.Panel1.Visible = False
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
                Me.DropDownList14.DataSource = tabla
                Me.DropDownList14.DataTextField = "nombreEmpresa"
                Me.DropDownList14.DataValueField = "idEmpresa"
                Me.DropDownList14.DataBind()
            Else
                Me.DropDownList14.DataSource = Nothing
                Me.DropDownList14.DataBind()
            End If
            Me.DropDownList14.Items.Insert(0, "Todas Las Empresas")
        End With
    End Sub

    'Sub cargarEmpresas()
    '    Dim tabla As New DataTable
    '    With empresas
    '        tabla = .MostrarEmpresaGeneral
    '        If tabla.Rows.Count <> 0 Then
    '            Me.DropDownList1.DataSource = tabla
    '            Me.DropDownList1.DataTextField = "nombreEmpresa"
    '            Me.DropDownList1.DataValueField = "idEmpresa"
    '            Me.DropDownList1.DataBind()
    '        Else
    '            Me.DropDownList1.DataSource = Nothing
    '            Me.DropDownList1.DataBind()
    '        End If
    '        Me.DropDownList1.Items.Insert(0, "Seleccione Empresa")
    '    End With
    'End Sub

    Sub cargarAno()
        Dim y As Integer
        For y = 2019 To Now.Year
            Me.DropDownList12.Items.Add(y)
        Next
        Me.DropDownList12.Items.Insert(0, "Año")
    End Sub

    'Sub cargarPaises()
    '    Dim tabla As New DataTable
    '    With paises
    '        tabla = .MostrarPaise
    '        If tabla.Rows.Count <> 0 Then
    '            Me.DropDownList1.DataSource = tabla
    '            Me.DropDownList1.DataTextField = "nombrepais"
    '            Me.DropDownList1.DataValueField = "codigopais"
    '            Me.DropDownList1.DataBind()
    '        Else
    '            Me.DropDownList1.DataSource = Nothing
    '            Me.DropDownList1.DataBind()
    '        End If
    '        Me.DropDownList1.Items.Insert(0, "Todos Los Paises")
    '    End With
    'End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Label4.Text = ""
        Me.Panel1.Visible = False
        Me.Label6.Text = ""
        Dim idEmpresa As Integer
        If Me.DropDownList14.SelectedIndex = 0 Then
            idEmpresa = 0
        Else
            idEmpresa = Me.DropDownList14.SelectedValue
        End If
        '
        If Me.DropDownList13.SelectedIndex = 0 Or Me.DropDownList12.SelectedIndex = 0 Then
            Me.Label4.Text = "Seleccione el periodo correctamente...!"
        Else
            Me.GridView2.DataSource = Nothing
            Me.GridView2.DataBind()
            Me.Panel1.Visible = True
            Dim encontroDatos As String = mostrarDatos()
            If encontroDatos = "si" Then
                Me.Label6.Text = Me.GridView2.Rows.Count & " Registros encontrados...!"
                calcularTotales()
            Else
                Me.Label6.Text = "No se encontraron registros...!"
            End If
        End If
    End Sub

    Sub calcularTotales()
        Dim y As Integer
        Dim suma1 As Decimal = 0
        Dim suma2 As Decimal = 0
        Dim suma3 As Decimal = 0
        Dim suma4 As Decimal = 0
        Dim suma5 As Decimal = 0
        Dim suma6 As Decimal = 0
        Dim suma7 As Decimal = 0
        Dim suma8 As Decimal = 0
        Dim suma9 As Decimal = 0
        Dim suma10 As Decimal = 0
        Dim suma11 As Decimal = 0
        Dim sumaBono2 As Decimal = 0
        Dim suma12 As Decimal = 0
        Dim suma13 As Decimal = 0
        Dim suma14 As Decimal = 0
        '
        For y = 0 To Me.GridView2.Rows.Count - 1
            suma1 += CDbl(Me.GridView2.Rows(y).Cells(6).Text)
            suma2 += CDbl(Me.GridView2.Rows(y).Cells(7).Text)
            suma3 += CDbl(Me.GridView2.Rows(y).Cells(8).Text)
            suma4 += CDbl(Me.GridView2.Rows(y).Cells(9).Text)
            suma5 += CDbl(Me.GridView2.Rows(y).Cells(10).Text)
            suma6 += CDbl(Me.GridView2.Rows(y).Cells(11).Text)
            suma7 += CDbl(Me.GridView2.Rows(y).Cells(12).Text)
            'suma9 += CDbl(Me.GridView2.Rows(y).Cells(14).Text)
            'sumaBono2 += CDbl(Me.GridView2.Rows(y).Cells(15).Text)
            'suma11 += CDbl(Me.GridView2.Rows(y).Cells(16).Text)
            'suma12 += CDbl(Me.GridView2.Rows(y).Cells(17).Text)
            'suma13 += CDbl(Me.GridView2.Rows(y).Cells(18).Text)
            'suma14 += CDbl(Me.GridView2.Rows(y).Cells(19).Text)
        Next
        Me.GridView2.FooterRow.Cells(0).Text = "Totales:"
        Me.GridView2.FooterRow.Cells(6).Text = FormatNumber(suma1, 2)
        Me.GridView2.FooterRow.Cells(7).Text = FormatNumber(suma2, 2)
        Me.GridView2.FooterRow.Cells(8).Text = FormatNumber(suma3, 2)
        Me.GridView2.FooterRow.Cells(9).Text = FormatNumber(suma4, 2)
        Me.GridView2.FooterRow.Cells(10).Text = FormatNumber(suma5, 2)
        Me.GridView2.FooterRow.Cells(11).Text = FormatNumber(suma6, 2)
        Me.GridView2.FooterRow.Cells(12).Text = FormatNumber(suma7, 2)
        'Me.GridView2.FooterRow.Cells(14).Text = FormatNumber(suma9, 2)
        'Me.GridView2.FooterRow.Cells(15).Text = FormatNumber(sumaBono2, 2)
        'Me.GridView2.FooterRow.Cells(16).Text = FormatNumber(suma11, 2)
        'Me.GridView2.FooterRow.Cells(17).Text = FormatNumber(suma12, 2)
        'Me.GridView2.FooterRow.Cells(18).Text = FormatNumber(suma13, 2)
        'Me.GridView2.FooterRow.Cells(19).Text = FormatNumber(suma14, 2)
    End Sub

    Function mostrarDatos() As String
        Dim encontroDatos As String = "no"
        Me.ImageButton2.Visible = False
        Dim tabla As New DataTable
        Dim idEmpresa As Integer = 0
        Dim codigoPais As Integer
        Dim dptoSucursal As Integer
        '----------------------------------------------------------------------
        If Me.DropDownList14.SelectedIndex = 0 Then
            idEmpresa = 0
        Else
            idEmpresa = Me.DropDownList14.SelectedValue
        End If


        ' obtener el codigo del pais
        If idEmpresa > 0 Then
            With empresas
                .IdEmpresa = Me.DropDownList14.SelectedValue 'Request.QueryString("ie")
                tabla = .MostrarEmpresaPorId
                If tabla.Rows.Count <> 0 Then
                    codigoPais = tabla.Rows(0).Item("idPais")
                End If
            End With
        End If
        '----------------------------------------------------------------------
        '----------------------------------------------------------------------
        ' obtener el dpto de la sucursal
        'With sucursales
        '    .idSucursal = Request.QueryString("is")
        '    tabla = .obtenerSucursalPorId
        '    If tabla.Rows.Count <> 0 Then
        '        dptoSucursal = tabla.Rows(0).Item("dptoSucursal")
        '    End If
        'End With
        '----------------------------------------------------------------------
        With objTTComision
            If Me.DropDownList14.SelectedIndex = 0 Then
                idEmpresa = 0
            Else
                idEmpresa = Me.DropDownList14.SelectedValue
            End If
            .idEmpresa = idEmpresa
            .mes = Me.DropDownList13.SelectedValue
            .ano = Me.DropDownList12.SelectedItem.Text
            .fecha = .ano & "/" & .mes & "/01"
            .dptoFComision = dptoSucursal

            tabla = .obtenerDatosComisionesMensualesCiclos2019
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
                '
                Me.Label5.Text = "Periodo: " & Me.DropDownList13.SelectedItem.Text & " De " & Me.DropDownList12.SelectedItem.Text
                Me.ImageButton2.Visible = True
                encontroDatos = "si"
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
                Me.Label5.Text = ""
                encontroDatos = "no"
            End If
        End With
        Return encontroDatos
    End Function

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        'panelDatos.Visible = False
        ExportToExcel("ComisionMensualCiclos.xls", Me.GridView2)
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

    Protected Sub GridView2_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles GridView2.SelectedIndexChanged

    End Sub
End Class
