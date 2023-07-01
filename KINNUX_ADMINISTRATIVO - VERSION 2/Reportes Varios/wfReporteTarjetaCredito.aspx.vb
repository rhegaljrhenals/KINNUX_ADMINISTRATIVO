Imports System.Data
Imports System.IO

Partial Class Reportes_Varios_wfReporteConsignacion
    Inherits System.Web.UI.Page


    Dim consignaciones As New clsTTConsignacion
    Dim afiliadosConsignaciones As New clsTTCodConsig
    Dim remisionesConsignaciones As New clsTTFacturaConsig
    Dim operaciones As New clsOperacione
    Dim empresas As New clsEmpresa
    Dim encabezadoFacturas As New clsTTEncFacturaPro
    Dim sucursales As New clsSucursale



    Function buscarConsignacion(ByVal numero As String) As String
        Dim tabla As New DataTable
        Dim encontrado As String = "no"
        With consignaciones
            .numeroConsignacion = numero
            tabla = .datosConsignacionesPorNumero
            If tabla.Rows.Count <> 0 Then
                Me.TextBox2.Text = tabla.Rows(0).Item("idconsignacion")
                Me.TextBox3.Text = tabla.Rows(0).Item("numeroconsignacion")
                Me.TextBox4.Text = tabla.Rows(0).Item("fechaConsignacion")
                Me.TextBox5.Text = tabla.Rows(0).Item("valorConsignacion")
                Me.TextBox6.Text = tabla.Rows(0).Item("valorUtilizadoConsignacion")
                'Me.Image2.ImageUrl = "C:\ClientSites\kinnux.net\httpdocs\Punto\Consignaciones\191125307.jpg"
                encontrado = "si"
            Else
                encontrado = "no"
                Me.TextBox2.Text = ""
                Me.TextBox3.Text = ""
                Me.TextBox4.Text = ""
                Me.TextBox5.Text = ""
                Me.TextBox6.Text = ""
            End If
        End With
        Return encontrado
    End Function

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.MultiView1.ActiveViewIndex = 1
        Me.ImageButton6.Visible = False
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            Me.MultiView1.ActiveViewIndex = 1
            Me.ImageButton6.Visible = False
            Me.TextBox10.Text = CDate(Now.Date).ToString("yyyy/MM/dd")
            Me.TextBox11.Text = CDate(Now.Date).ToString("yyyy/MM/dd")
            cargarEmpresas()
            Me.Label6.Visible = False
            Me.DropDownList2.Visible = False
            Me.RadioButton1.Checked = True
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    Sub cargarEmpresas()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from tbempresa order by idempresa"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList1.DataSource = tabla
                Me.DropDownList1.DataTextField = "nombreempresa"
                Me.DropDownList1.DataValueField = "idEmpresa"
                Me.DropDownList1.DataBind()
            Else
                Me.DropDownList1.DataSource = Nothing
                Me.DropDownList1.DataBind()
            End If
        End With
        Me.DropDownList1.Items.Insert(0, "Seleccione Empresa")
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

    Protected Sub GridView4_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView4.SelectedIndexChanging
        Dim idTC As Integer = Me.GridView4.Rows(e.NewSelectedIndex).Cells(1).Text
        buscar(idTC)
        Me.MultiView1.ActiveViewIndex = 0
        Me.ImageButton6.Visible = False
    End Sub

    Sub buscar(ByVal idTarjeta As Integer)
        Dim sql As String
        Dim tabla As New DataTable
        Me.TextBox2.Text = ""
        ' datos de la TC
        sql = "select * from tttarjetacre where idtarjetacre=" & idTarjeta
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.TextBox2.Text = tabla.Rows(0).Item("idtarjetacre")
                Me.TextBox3.Text = tabla.Rows(0).Item("aprobaciontarjetacre")
                Me.TextBox4.Text = tabla.Rows(0).Item("fechaaprobaciontarjetacre")
                Me.TextBox5.Text = tabla.Rows(0).Item("valordolartarjetacre")
                Me.TextBox6.Text = tabla.Rows(0).Item("valorusdtarjetacre")
                Me.TextBox13.Text = tabla.Rows(0).Item("valorlocaltarjetacre")
                Me.TextBox14.Text = tabla.Rows(0).Item("valorutilizado")
                Me.TextBox15.Text = tabla.Rows(0).Item("titulartarjetacre")
                Me.TextBox16.Text = tabla.Rows(0).Item("obsevaciontarjetacre")
                Me.TextBox17.Text = tabla.Rows(0).Item("idempresa")
                Me.TextBox19.Text = tabla.Rows(0).Item("idsucursal")
            End If
        End With
        ' buscar la empresa
        If Me.TextBox17.Text <> "0" Then
            sql = "select * from tbempresa where idempresa=" & Me.TextBox17.Text
            With operaciones
                tabla = .DevuelveDato(sql)
                If tabla.Rows.Count <> 0 Then
                    Me.TextBox18.Text = tabla.Rows(0).Item("nombreempresa")
                Else
                    Me.TextBox18.Text = ""
                End If
            End With
        Else
            Me.TextBox18.Text = ""
        End If
        ' sucursal
        If Me.TextBox19.Text <> "0" Then
            sql = "select * from tbsucursal where idsucursal=" & Me.TextBox19.Text
            With operaciones
                tabla = .DevuelveDato(sql)
                If tabla.Rows.Count <> 0 Then
                    Me.TextBox20.Text = tabla.Rows(0).Item("nombresucursal")
                Else
                    Me.TextBox20.Text = ""
                End If
            End With
        Else
            Me.TextBox20.Text = ""
        End If
        ' afiliados cargados
        sql = "SELECT     " & _
        "dbo.Afiliaciones.codigoafiliado," & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " TTCodigoTarjetaCre ON dbo.Afiliaciones.codigoAfiliado = TTCodigoTarjetaCre.codigoAfiliado" & _
        " where TTCodigoTarjetaCre.idTarjetacre=" & Me.TextBox2.Text
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.GridView5.DataSource = tabla
                Me.GridView5.DataBind()
            Else
                Me.GridView5.DataSource = Nothing
                Me.GridView5.DataBind()
            End If
        End With
        ' remisiones cargadas
        sql = "SELECT     " & _
        "TTEncFacturaPro.idEncFacturaPro, " & _
        "TTEncFacturaPro.fechaEncFacturaPro, " & _
        "dbo.Afiliaciones.codigoAfiliado," & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres, " & _
        "TTEncFacturaPro.valorCoEncFacturaPro," & _
        "TTEncFacturaPro.valorMlEncFacturaPro," & _
        "TTEncFacturaPro.fpEfectivoEncFacturaPro," & _
        "TTEncFacturaPro.fpConsigEncFacturaPro," & _
        "TTEncFacturaPro.fpTarjetaEncFaturaPro," & _
        "TTEncFacturaPro.fpCruceEncfacturaPro," & _
        "TTEncFacturaPro.fpHotelEncFacturaPro," & _
        "TTEncFacturaPro.estadoEncfacturaPro," & _
        "TTEncFacturaPro.valorEfectivoEncFacturaPro," & _
        "TTEncFacturaPro.valorconsigEncFacturaPro," & _
        "TTEncFacturaPro.valorusEncFacturaPro," & _
        "TTEncFacturaPro.valorcruceEncFacturaPro," & _
        "TTEncFacturaPro.valorhotelEncFacturaPro" & _
        " FROM" & _
        " TTFacturaTarjeta INNER JOIN" & _
        " TTEncFacturaPro ON TTFacturaTarjeta.idEncFacturaPro = TTEncFacturaPro.idEncFacturaPro INNER JOIN" & _
        " dbo.Afiliaciones ON TTEncFacturaPro.codigoAfiliado = dbo.Afiliaciones.codigoAfiliado" & _
        " where TTFacturaTarjeta.idTarjeta=" & Me.TextBox2.Text
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.GridView6.DataSource = tabla
                Me.GridView6.DataBind()
            Else
                Me.GridView6.DataSource = Nothing
                Me.GridView6.DataBind()
            End If
        End With
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String
        Dim tabla As New DataTable
        Me.Label5.Text = ""
        If Me.RadioButton1.Checked = True Then
            If Me.TextBox12.Text = "" Then
                Me.Label5.Text = "Ingrese el numero de aprobación...!"
                Exit Sub
            End If
        Else
            If Me.TextBox10.Text = "" Or Me.TextBox11.Text = "" Then
                Me.Label5.Text = "Debe seleccionar la fecha inicial y final correctamente...!"
                Exit Sub
            End If
            '
        End If
        sql = "SELECT     " & _
        "TTTarjetaCre.idTarjetaCre," & _
        "TTTarjetaCre.aprobacionTarjetaCre," & _
        "TTTarjetaCre.valorUsdTarjetaCre," & _
        "TTTarjetaCre.valorDolarTarjetaCre," & _
        "TTTarjetaCre.fechaAprobacionTarjetaCre," & _
        "TTTarjetaCre.titularTarjetaCre," & _
        "TTTarjetaCre.valorUtilizado," & _
        "TTTarjetaCre.valorLocalTarjetaCre" & _
        " FROM" & _
        " TTTarjetaCre"
        If Me.RadioButton1.Checked = True Then
            sql = sql & " where TTTarjetaCre.aprobacionTarjetaCre='" & Me.TextBox12.Text & "'"
        Else
            If Me.RadioButton2.Checked = True Then
                sql = sql & " where TTTarjetaCre.fechaAprobacionTarjetaCre between '" & Me.TextBox10.Text & "' and '" & Me.TextBox11.Text & "'"
                sql = sql & " order by TTTarjetaCre.fechaAprobacionTarjetaCre desc,TTTarjetaCre.titularTarjetaCre"
            Else
                If Me.RadioButton3.Checked = True Then
                    sql = sql & " where TTTarjetaCre.idEmpresa=" & Me.DropDownList1.SelectedValue
                    If Me.CheckBox1.Checked = True Then
                        sql = sql & " and TTTarjetaCre.idsucursal=" & Me.DropDownList2.SelectedValue
                    End If
                    sql = sql & " order by TTTarjetaCre.fechaAprobacionTarjetaCre desc,TTTarjetaCre.titularTarjetaCre"
                End If
            End If
        End If
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.GridView4.DataSource = tabla
                Me.GridView4.DataBind()
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

    Protected Sub ImageButton6_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton6.Click
        ExportToExcel("Consignaciones-" & Me.TextBox10.Text & "-" & Me.TextBox11.Text & ".xls", Me.GridView4)
    End Sub

    
    Protected Sub CheckBox1_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            Me.Label6.Visible = True
            Me.DropDownList2.Visible = True
        Else
            Me.Label6.Visible = False
            Me.DropDownList2.Visible = False
        End If
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
        If Me.DropDownList1.SelectedIndex > 0 Then
            cargarSucursales()
            Me.DropDownList2.Focus()
        End If
    End Sub
End Class
