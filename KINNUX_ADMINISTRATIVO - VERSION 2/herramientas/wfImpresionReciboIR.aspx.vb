Imports System.Data

Partial Class Facturacion_wfImpresionFactura
    Inherits System.Web.UI.Page

    'Dim afiliado As New ClsAfiliado
    'Dim encabezadoFactura As New clsTTEncFacturaPro
    'Dim detalleFactura As New clsTTDetFacturaPro
    ''
    'Dim usuarios As New clsTBUsuarios
    'Dim comisionIR As New clsTTComisionIr
    'Dim detalleComisionIR As New clsTTDetComisionIr
    'Dim monedaLocal As New clsTbMonedaLocal
    Dim operaciones As New clsOperacione

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            mostrarDatos()
            'cargarDatosBasicosAfiliado()
            'obtenerNombreDeUsuario()
            ''mostrarDetallefactura()
        End If
        'If (Session.Item("idPais") Is Nothing Or Session.Item("idPais") = 0) Or (Session.Item("idSucursal") Is Nothing Or Session.Item("idSucursal") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    Sub mostrarDatos()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TTDetComisionIr.puntoscomisionir," & _
        "TTComisionIr.idComisionIr, " & _
        "TTComisionIr.valorComisionIr, " & _
        "TTComisionIr.fechaPagoComisionIr, " & _
        "dbo.Afiliaciones.identificacion," & _
        "dbo.Afiliaciones.direccion," & _
        "dbo.Afiliaciones.telefono," & _
        "dbo.Afiliaciones.codigoAfiliado,dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido quiencobro, " & _
        "TBUsuario.nombreCompletoUsuario, " & _
        "'(' + Afiliaciones_1.codigoAfiliado + ') ' + Afiliaciones_1.Pnombre + ' ' + Afiliaciones_1.Snombre + ' ' + Afiliaciones_1.Papellido + ' ' + Afiliaciones_1.Sapellido AS quienCompro, " & _
        "TTEncFacturaPro.idEncFacturaPro," & _
        "TTEncFacturaPro.fechaEncFacturaPro" & _
        " FROM" & _
        " TTComisionIr INNER JOIN" & _
        " dbo.Afiliaciones ON TTComisionIr.codigoAfiliado = dbo.Afiliaciones.codigoAfiliado INNER JOIN" & _
        " TBUsuario ON TTComisionIr.usuarioPagoComisioIr = TBUsuario.idUsuario INNER JOIN" & _
        " TTDetComisionIr ON TTComisionIr.idComisionIr = TTDetComisionIr.idComisonIr INNER JOIN" & _
        " dbo.Afiliaciones AS Afiliaciones_1 ON TTDetComisionIr.codigoAfiliadoCom = Afiliaciones_1.codigoAfiliado INNER JOIN" & _
        " TTEncFacturaPro ON TTDetComisionIr.idEncFacturaPro = TTEncFacturaPro.idEncFacturaPro" & _
        " where TTComisionIr.idcomisionir=" & Request.QueryString("ie")
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.Label46.Text = Microsoft.VisualBasic.Left(tabla.Rows(0).Item("nombreCompletoUsuario"), 33)
                Me.Label42.Text = FormatNumber(tabla.Rows(0).Item("valorComisionIr"), 2)
                Me.Label41.Text = FormatNumber(tabla.Rows(0).Item("valorComisionIr"), 2)
                Me.Label25.Text = CDate(tabla.Rows(0).Item("fechaPagoComisionIr")).ToString("yyyy/MM/dd")
                Me.Label26.Text = tabla.Rows(0).Item("idComisionIr")
                '
                Me.Label47.Text = tabla.Rows(0).Item("identificacion") & " - (" & tabla.Rows(0).Item("codigoAfiliado") & ") " & tabla.Rows(0).Item("quiencobro")
                Me.Label28.Text = Microsoft.VisualBasic.Left(tabla.Rows(0).Item("direccion"), 28)
                Me.Label30.Text = tabla.Rows(0).Item("telefono")
                '
                Me.GridView6.DataSource = tabla
                Me.GridView6.DataBind()
            End If
        End With


    End Sub

    'Sub obtenerNombreDeUsuario()
    '    Dim tabla As New DataTable
    '    With usuarios
    '        .idUsuario = Session("idusuario")
    '        tabla = .obtenerUsuarioPorIdUsuario
    '        If tabla.Rows.Count <> 0 Then
    '            Me.Label46.Text = Microsoft.VisualBasic.Left(tabla.Rows(0).Item("nombreCompletoUsuario"), 33)
    '        Else
    '            Me.Label46.Text = ""
    '        End If
    '    End With
    'End Sub

    'Sub cargarDatosBasicosAfiliado()
    '    Dim codigoAfiliado As String = ""
    '    Dim tabla As New DataTable
    '    With comisionIR
    '        .idComisionIr = Session("id")
    '        tabla = .obtenerComisionIRporIdComision
    '        If tabla.Rows.Count <> 0 Then
    '            codigoAfiliado = tabla.Rows(0).Item("codigoAfiliado")
    '            Me.Label42.Text = FormatNumber(tabla.Rows(0).Item("valorComisionIr"), 2)
    '            Me.Label41.Text = FormatNumber(tabla.Rows(0).Item("valorComisionIr"), 2)
    '            Me.Label25.Text = tabla.Rows(0).Item("fechaPagoComisionIr")
    '            Me.Label26.Text = tabla.Rows(0).Item("idComisionIr")
    '        Else
    '            Me.Label42.Text = ""
    '            Me.Label25.Text = ""
    '            Me.Label26.Text = ""
    '        End If
    '    End With
    '    '-------------------------------------------------------------------------------
    '    Dim valorMoneda As Double
    '    With monedaLocal
    '        .idEmpresa = Request.QueryString("ie")
    '        tabla = .obtenerValorMonedaLocalPorEmpresa
    '        If tabla.Rows.Count <> 0 Then
    '            valorMoneda = tabla.Rows(0).Item("valorMonedaLocal")
    '        Else
    '            valorMoneda = 1
    '        End If
    '    End With
    '    Me.Label48.Text = (CDbl(Me.Label41.Text) * valorMoneda)
    '    '--------------------------------------------------------------------------------
    '    ' datos del afiliado
    '    With afiliado
    '        .codigoAfiliado = codigoAfiliado
    '        tabla = .obtenerAfiliadosPorCodigoAfiliado(.codigoAfiliado)
    '        If tabla.Rows.Count <> 0 Then
    '            Me.Label47.Text = tabla.Rows(0).Item("identificacion") & " - (" & tabla.Rows(0).Item("codigoAfiliado") & ") " & tabla.Rows(0).Item("pnombre") & " " & tabla.Rows(0).Item("snombre") & " " & tabla.Rows(0).Item("papellido") & " " & tabla.Rows(0).Item("sapellido")
    '            Me.Label28.Text = Microsoft.VisualBasic.Left(tabla.Rows(0).Item("direccion"), 28)
    '            Me.Label30.Text = tabla.Rows(0).Item("telefono")
    '        Else
    '            Me.Label47.Text = ""
    '            Me.Label28.Text = ""
    '            Me.Label30.Text = ""
    '        End If
    '    End With
    '    ' detalle de la comision
    '    With detalleComisionIR
    '        .idComisonIr = Val(Me.Label26.Text)
    '        tabla = .obtenerDetalleComisionIR
    '        If tabla.Rows.Count <> 0 Then
    '            Me.GridView6.DataSource = tabla
    '            Me.GridView6.DataBind()
    '        End If
    '    End With
    'End Sub
End Class
