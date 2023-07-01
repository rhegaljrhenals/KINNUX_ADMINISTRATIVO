Imports System.Data

Partial Class herramientas_wfCopiasComisiones
    Inherits System.Web.UI.Page

    Dim operaciones As New clsOperacione

    Protected Sub ImageButton5_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton5.Click
        If Me.TextBox1.Text <> "" Then
            Me.GridView2.DataSource = Nothing
            Me.GridView2.DataBind()
            '
            Me.GridView3.DataSource = Nothing
            Me.GridView3.DataBind()
            '
            Me.GridView4.DataSource = Nothing
            Me.GridView4.DataBind()
            '
            Me.ImageButton6.Visible = False
            Me.ImageButton7.Visible = False
            Me.ImageButton8.Visible = False
            '
            Dim encontrado As String = mostrarAfiliado()
            If encontrado = "si" Then
                comisionesIR()
                comisionesKit()
                comisionesmensuales()
            End If
        End If
    End Sub

    Function mostrarAfiliado() As String
        Dim encontrado As String = "no"
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from afiliaciones where codigoafiliado='" & Me.TextBox1.Text & "'"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.TextBox2.Text = tabla.Rows(0).Item("pnombre") & " " & tabla.Rows(0).Item("snombre") & " " & tabla.Rows(0).Item("papellido") & " " & tabla.Rows(0).Item("sapellido")
                encontrado = "si"
            Else
                Me.TextBox2.Text = "No existe...!"
            End If
        End With
        Return encontrado
    End Function

    Sub comisionesmensuales()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TTComision.idcomision," & _
        "TTComision.compracomision, " & _
        "TTComision.iniciorcomision , " & _
        "TTComision.uninivelcomision , " & _
        "TTComision.avancelcomision , " & _
        "TTComision.genbinariocomision , " & _
        "TTComision.generacionalcomision, " & _
        "TTComision.estructuracomision, " & _
        "TTComision.elitecomision, " & _
        "TTComision.bono1comision, " & _
        "TTComision.bono2comision, " & _
        "TTComision.bonocarrocomision, " & _
        "case TTComision.mescomision " & _
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
        " end mescomision," & _
        "TTComision.anocomision, " & _
        "TTComision.fechapagocomision, " & _
        "TTComision.usuariopagocomision, " & _
        "dbo.Afiliaciones.codigoAfiliado, " & _
        "dbo.Afiliaciones.identificacion, " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres," & _
        "dbo.TBpais.codigoPais, " & _
        "dbo.TBpais.nombrePais, " & _
        "dbo.TBDpto.codigoDpto, " & _
        "dbo.TBDpto.nombreDpto, " & _
        "dbo.TBMunicipio.codigoMunicipio, " & _
        "dbo.TBMunicipio.nombreMunicipio," & _
        "(TTComision.iniciorcomision + TTComision.uninivelcomision + TTComision.avancelcomision + TTComision.genbinariocomision + TTComision.generacionalcomision + TTComision.estructuracomision + TTComision.elitecomision + TTComision.bono1comision + TTComision.bono2comision + TTComision.bonocarrocomision)  as suma" & _
        " FROM" & _
        " TTComision INNER JOIN" & _
        " dbo.Afiliaciones ON TTComision.codigoafiliado = dbo.Afiliaciones.codigoAfiliado INNER JOIN" & _
        " dbo.TBpais ON dbo.Afiliaciones.codigoPais = dbo.TBpais.codigoPais INNER JOIN" & _
        " dbo.TBDpto ON dbo.TBpais.codigoPais = dbo.TBDpto.idPais AND dbo.Afiliaciones.codigoDpto = dbo.TBDpto.codigoDpto INNER JOIN" & _
        " dbo.TBMunicipio ON dbo.TBpais.codigoPais = dbo.TBMunicipio.idPais AND dbo.TBDpto.codigoDpto = dbo.TBMunicipio.idDpto AND " & _
        " dbo.Afiliaciones.codigoCiudad = dbo.TBMunicipio.codigoMunicipio" & _
        " where TTComision.codigoafiliado='" & Me.TextBox1.Text & "' and" & _
        " TTComision.usuarioPagoComision is not null" & _
        " order by TTComision.anocomision,TTComision.mescomision  "

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

    Sub comisionesKit()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido quiencobro, " & _
        "'(' + Afiliaciones_1.codigoAfiliado + ') ' + Afiliaciones_1.Pnombre + ' ' + Afiliaciones_1.Snombre + ' ' + Afiliaciones_1.Papellido + ' ' + Afiliaciones_1.Sapellido AS quiencompro, " & _
        "TTComisionKit.idComisionKit, " & _
        "TTComisionKit.valorComisionKit, " & _
        "TTComisionKit.fechaPagoComisionKit, " & _
        "TTComisionKit.usuarioPagoComisionKit, " & _
        "TTComisionKit.pagoComisionKit, " & _
        "TTEncFacturaPro.idEncFacturaPro, " & _
        "TTEncFacturaPro.fechaEncFacturaPro, " & _
        "dbo.TBEmpresa.idEmpresa AS Expr7, " & _
        "dbo.TBEmpresa.nombreEmpresa," & _
        "dbo.TBSucursal.idSucursal," & _
        "dbo.TBSucursal.nombreSucursal," & _
        "TBUsuario.nombreCompletoUsuario" & _
        " FROM" & _
        " TTDetComisionKit INNER JOIN" & _
        " dbo.Afiliaciones ON TTDetComisionKit.codigoAfiliado = dbo.Afiliaciones.codigoAfiliado INNER JOIN" & _
        " dbo.Afiliaciones AS Afiliaciones_1 ON TTDetComisionKit.codigoAfiliadoCom = Afiliaciones_1.codigoAfiliado INNER JOIN" & _
        " TTComisionKit ON TTDetComisionKit.idComisionKit = TTComisionKit.idComisionKit INNER JOIN" & _
        " TTEncFacturaPro ON TTDetComisionKit.idEncFacturaPro = TTEncFacturaPro.idEncFacturaPro INNER JOIN" & _
        " dbo.TBEmpresa ON TTEncFacturaPro.idEmpresa = dbo.TBEmpresa.idEmpresa INNER JOIN" & _
        " dbo.TBSucursal ON TTEncFacturaPro.idSucursal = dbo.TBSucursal.idSucursal AND " & _
        " TTEncFacturaPro.idEmpresa = dbo.TBSucursal.idEmpresa INNER JOIN" & _
        " TBUsuario ON TTComisionKit.usuarioPagoComisionKit = TBUsuario.idUsuario" & _
        " where TTComisionKit.codigoafiliado='" & Me.TextBox1.Text & "' and" & _
        " TTEncFacturaPro.estadoencfacturapro=1 and " & _
        " TTComisionKit.pagoComisionKit='si'" & _
        " order by TTEncFacturaPro.fechaencfacturapro"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.GridView3.DataSource = tabla
                Me.GridView3.DataBind()
            Else
                Me.GridView3.DataSource = Nothing
                Me.GridView3.DataBind()
            End If
        End With
    End Sub

    Sub comisionesIR()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TTComisionIr.idComisionIr," & _
        "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres, " & _
        "dbo.TBDpto.nombreDpto, " & _
        "dbo.TBMunicipio.nombreMunicipio, " & _
        "TTDetComisionIr.valorComisonIr, " & _
        "'(' + Afiliaciones_1.codigoAfiliado + ') ' + Afiliaciones_1.Pnombre + ' ' + Afiliaciones_1.Snombre + ' ' + Afiliaciones_1.Papellido + ' ' + Afiliaciones_1.Sapellido AS quiencompro, " & _
        "TTEncFacturaPro.idEncFacturaPro," & _
        "TTEncFacturaPro.fechaEncFacturaPro," & _
        " case TTComisionIr.pagoComisionIr" & _
        " when 'si' then 'Pagada'" & _
        " when 'no' then 'No Cobrada'" & _
        " when 'pe' then 'Pendiente'" & _
        " when 'co' then 'Comprimida'" & _
        " end pagoComisionIr," & _
        " TTComisionIr.fechaPagoComisionIr" & _
        " FROM" & _
        " TTDetComisionIr INNER JOIN" & _
        " TTEncFacturaPro ON TTDetComisionIr.idEncFacturaPro = TTEncFacturaPro.idEncFacturaPro INNER JOIN" & _
        " dbo.Afiliaciones AS Afiliaciones_1 ON TTDetComisionIr.codigoAfiliadoCom = Afiliaciones_1.codigoAfiliado INNER JOIN" & _
        " dbo.TBpais INNER JOIN" & _
        " dbo.Afiliaciones ON dbo.TBpais.codigoPais = dbo.Afiliaciones.codigoPais INNER JOIN" & _
        " dbo.TBDpto ON dbo.Afiliaciones.codigoPais = dbo.TBDpto.idPais AND dbo.Afiliaciones.codigoDpto = dbo.TBDpto.codigoDpto INNER JOIN" & _
        " dbo.TBMunicipio ON dbo.Afiliaciones.codigoPais = dbo.TBMunicipio.idPais AND dbo.Afiliaciones.codigoCiudad = dbo.TBMunicipio.codigoMunicipio ON" & _
        " TTDetComisionIr.codigoAfiliado = dbo.Afiliaciones.codigoAfiliado INNER JOIN" & _
        " TTComisionIr ON TTDetComisionIr.idComisonIr = TTComisionIr.idComisionIr" & _
        " where " & _
        " TTComisionIr.codigoAfiliado='" & Me.TextBox1.Text & "' and" & _
        " TTComisionIr.pagoComisionIr='si'" & _
        " order by TTEncFacturaPro.fechaEncFacturaPro"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End With
    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            Me.MultiView1.ActiveViewIndex = 0
            Me.ImageButton6.Visible = False
            Me.ImageButton7.Visible = False
            Me.ImageButton8.Visible = False
            Me.TextBox1.Focus()
        End If
    End Sub

    Protected Sub GridView2_SelectedIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        Me.ImageButton6.Visible = True
        Dim id As Integer
        id = Me.GridView2.Rows(e.NewSelectedIndex).Cells(1).Text
        ImageButton6.Attributes.Add("onclick", "window.open('wfImpresionReciboIR.aspx?ie=" & id & "',null,'height=600, width=900,status= no, resizable= no, scrollbars=si, toolbar=no,location=no,menubar=no ');")

    End Sub

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Me.MultiView1.ActiveViewIndex = 0

    End Sub

    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        Me.MultiView1.ActiveViewIndex = 1

    End Sub

    Protected Sub GridView3_SelectedIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView3.SelectedIndexChanging
        Me.ImageButton7.Visible = True
        Dim id As Integer
        id = Me.GridView3.Rows(e.NewSelectedIndex).Cells(1).Text
        ImageButton7.Attributes.Add("onclick", "window.open('wfImpresionReciboKit.aspx?ie=" & id & "',null,'height=600, width=900,status= no, resizable= no, scrollbars=si, toolbar=no,location=no,menubar=no ');")
    End Sub

    Protected Sub Button4_Click(sender As Object, e As System.EventArgs) Handles Button4.Click
        Me.MultiView1.ActiveViewIndex = 2
    End Sub

    Protected Sub GridView4_SelectedIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView4.SelectedIndexChanging
        Me.ImageButton8.Visible = True
        Dim id As Integer
        id = Me.GridView4.Rows(e.NewSelectedIndex).Cells(1).Text
        ImageButton8.Attributes.Add("onclick", "window.open('wfImpresionReciboComisionesMensuales.aspx?ie=" & id & "',null,'height=600, width=900,status= no, resizable= no, scrollbars=si, toolbar=no,location=no,menubar=no ');")
    End Sub
End Class
