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
            cargarEmpresas()
            cargarAno()
            Me.TextBox1.Visible = False
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    Sub cargarAno()
        Dim y As Integer
        For y = 2012 To Now.Year
            Me.DropDownList19.Items.Add(y)
        Next
        Me.DropDownList19.Items.Insert(0, "Año")
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

    Protected Sub ImageButton1_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Label4.Text = ""
        Me.Label6.Text = ""
        Me.Label7.Text = ""
        '
        If Me.CheckBox1.Checked = True Then ' si selecciono consulta por afiliado
            mostrarComisionesCanceladasPorAfiliado()
        Else
            If Me.DropDownList13.SelectedIndex = 0 Or Me.DropDownList19.SelectedIndex = 0 Then
                Me.Label4.Text = "Seleccione el periodo correctamente...!"
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
            mostrarComisionesMensuales()
        End If
        '
        If Me.GridView10.Rows.Count <> 0 Then
            mostrarTotalesComisionesMensuales()
        End If
    End Sub

    Sub mostrarComisionesCanceladasPorAfiliado()
        Me.GridView10.Columns(1).Visible = False
        Dim sumaValor As Double = 0
        Dim tabla As New DataTable
        Dim codigoPais As String = ""
        With empresas
            .IdEmpresa = Request.QueryString("ie")
            tabla = .MostrarEmpresaPorId
            If tabla.Rows.Count <> 0 Then
                codigoPais = tabla.Rows(0).Item("idPais")
            End If
        End With
        '
        With comisionesMensuales
            .codigoAfiliado = Me.TextBox1.Text
            .idEmpresa = Request.QueryString("ie")
            tabla = .obtenerComisonesCanceladas
            If tabla.Rows.Count <> 0 Then
                Me.GridView10.DataSource = tabla
                Me.GridView10.DataBind()
            Else
                Me.GridView10.DataSource = Nothing
                Me.GridView10.DataBind()
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
        'Me.GridView7.Rows(3).Cells(1).Text = FormatNumber(suma1, 2)
    End Sub

    Sub mostrarComisionesMensuales()
        Dim operaciones As New clsOperacione
        Dim tabla As New DataTable
        Dim codigoPais As String = ""
        Dim dptoSucursal As String = ""
        Dim cadena As String = Nothing
        Dim monedaLocal As New clsTbMonedaLocal
        Dim valorMoneda As Double
        Dim sql As String = ""
        With monedaLocal
            .idEmpresa = Me.DropDownList18.SelectedValue
            tabla = .obtenerValorMonedaLocalPorEmpresa
            If tabla.Rows.Count <> 0 Then
                valorMoneda = tabla.Rows(0).Item("valorMonedaLocal")
            Else
                valorMoneda = 1
            End If
        End With
        '
        With empresas
            .IdEmpresa = Me.DropDownList18.SelectedValue
            tabla = .MostrarEmpresaPorId
            If tabla.Rows.Count <> 0 Then
                codigoPais = tabla.Rows(0).Item("idPais")
            End If
        End With
        '
        With sucursales
            .idSucursal = Me.DropDownList2.SelectedValue
            tabla = .obtenerSucursalPorId
            If tabla.Rows.Count <> 0 Then
                dptoSucursal = tabla.Rows(0).Item("dptoSucursal")
            End If
        End With
        '
        sql = "SELECT     " & _
        "TTComision.idcomision, " & _
        "TTComision.compracomision, " & _
        "(TTComision.iniciorcomision + TTComision.uninivelcomision + TTComision.avancelcomision + TTComision.genbinariocomision + TTComision.generacionalcomision + TTComision.estructuracomision + TTComision.elitecomision + TTComision.bono1comision + TTComision.bono2comision + TTComision.bonocarrocomision) * " & valorMoneda & " as total, " & _
        "TTComision.mescomision, " & _
        "case TTComision.mescomision" & _
        " when 1 then 'Enero'" & _
        " when 2 then 'Febrero'" & _
        " when 3 then 'Marzo'" & _
        " when 4 then 'Abril'" & _
        " when 5 then 'Mayo'" & _
        " when 6 then 'Junio'" & _
        " when 7 then 'Julio'" & _
        " when 8 then 'Agosto'" & _
        " when 9 then 'Septiembre'" & _
        " when 10 then 'Octubre'" & _
        " when 11 then 'Noviembre'" & _
        " when 12 then 'Diciembre'" & _
        " end mes," & _
        " '' as usuario," & _
        "TTComision.anocomision, " & _
        "TTComision.fechapagocomision, " & _
        "TTComision.usuariopagocomision, " & _
        "TTComision.paisIComision, " & _
        "TTComision.paisFComision, " & _
        "TTComision.dptoIComision, " & _
        "TTComision.dptoFComision, " & _
        "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres" & _
        " FROM" & _
        " TTComision INNER JOIN" & _
        " dbo.Afiliaciones ON TTComision.codigoafiliado = dbo.Afiliaciones.codigoAfiliado" & _
        " where " & _
        " TTComision.paisFComision=" & codigoPais & " and" & _
        " TTComision.dptoFComision=" & dptoSucursal & " and" & _
        " TTComision.mescomision='" & Me.DropDownList13.SelectedValue & "' and TTComision.anocomision='" & Me.DropDownList19.SelectedValue & "' and" & _
        "(TTComision.iniciorcomision + TTComision.uninivelcomision + TTComision.avancelcomision + TTComision.genbinariocomision + TTComision.generacionalcomision + TTComision.estructuracomision + TTComision.elitecomision + TTComision.bono1comision + TTComision.bono2comision + TTComision.bonocarrocomision)<>0" & _
        " order by TTComision.mescomision,TTComision.anocomision"
        With Operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.GridView10.DataSource = tabla
                Me.GridView10.DataBind()
                actualizarGrilla()
            Else
                Me.GridView10.DataSource = Nothing
                Me.GridView10.DataBind()
            End If
        End With
    End Sub

    Sub actualizarGrilla()
        Dim operaciones As New clsOperacione
        Dim y As Integer
        Dim sql As String
        Dim tabla As New DataTable
        For y = 0 To Me.GridView10.Rows.Count - 1
            If Me.GridView10.Rows(y).Cells(5).Text <> "" Then
                sql = "SELECT     TBUsuario.nombreCompletoUsuario" & _
                " FROM         TTComision INNER JOIN" & _
                " TBUsuario ON TTComision.usuariopagocomision = TBUsuario.idUsuario" & _
                " where TTComision.idcomision=" & Me.GridView10.Rows(y).Cells(0).Text
                With operaciones
                    tabla = .DevuelveDato(sql)
                    If tabla.Rows.Count <> 0 Then
                        Me.GridView10.Rows(y).Cells(6).Text = tabla.Rows(0).Item("nombreCompletoUsuario")
                    Else
                        Me.GridView10.Rows(y).Cells(6).Text = ""
                    End If
                End With

            End If
        Next
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

    Protected Sub CheckBox1_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            Me.TextBox1.Visible = True
        Else
            Me.TextBox1.Visible = False
        End If
    End Sub
End Class
