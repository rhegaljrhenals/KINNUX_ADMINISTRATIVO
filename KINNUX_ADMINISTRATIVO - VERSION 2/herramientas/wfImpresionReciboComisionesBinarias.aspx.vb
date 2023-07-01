Imports System.Data

Partial Class Facturacion_wfImpresionFactura
    Inherits System.Web.UI.Page

    Dim afiliado As New ClsAfiliado
    Dim usuarios As New clsTBUsuarios
    Dim monedaLocal As New clsTbMonedaLocal
    Dim comisionesBinarias As New clsTTBbinario

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            'cargarDatosBasicosAfiliado()
            'obtenerNombreDeUsuario()
            'mostrarDetalleComision()
        End If
        'If (Session.Item("idPais") Is Nothing Or Session.Item("idPais") = 0) Or (Session.Item("idSucursal") Is Nothing Or Session.Item("idSucursal") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    'Sub mostrarDetalleComision()
    '    Dim mes As String = ""
    '    Dim tabla As New DataTable
    '    With comisionesBinarias
    '        .idPais = Request.QueryString("ie")
    '        .idComision = Request.QueryString("id")
    '        tabla = .obtenerComisionesPorId
    '        If tabla.Rows.Count <> 0 Then
    '            Me.TextBox103.Text = Request.QueryString("id")
    '            Me.TextBox104.Text = tabla.Rows(0).Item("fechaPagobbinario")
    '            Me.Label48.Text = "Mes De: " & tabla.Rows(0).Item("mes") & " - Año: " & tabla.Rows(0).Item("ano")
    '            Me.TextBox106.Text = FormatNumber(tabla.Rows(0).Item("valorbbinario"), 2)
    '            '
    '            Me.GridView1.DataSource = tabla
    '            Me.GridView1.DataBind()
    '        End If
    '    End With
    'End Sub

    'Sub obtenerNombreDeUsuario()
    '    Dim tabla As New DataTable
    '    With usuarios
    '        .idUsuario = Request.QueryString("iu")
    '        tabla = .obtenerUsuarioPorIdUsuario
    '        If tabla.Rows.Count <> 0 Then
    '            Me.TextBox105.Text = Microsoft.VisualBasic.Left(tabla.Rows(0).Item("nombrecompletoUsuario"), 33)
    '        Else
    '            Me.TextBox105.Text = ""
    '        End If
    '    End With
    'End Sub

    'Sub cargarDatosBasicosAfiliado()
    '    Dim codigoAfiliado As String = ""
    '    Dim tabla As New DataTable
    '    '--------------------------------------------------------------------------------
    '    ' datos del afiliado
    '    With afiliado
    '        .codigoAfiliado = Request.QueryString("ia") 'codigoAfiliado
    '        tabla = .obtenerAfiliadosPorCodigoAfiliado(.codigoAfiliado)
    '        If tabla.Rows.Count <> 0 Then
    '            Me.TextBox101.Text = tabla.Rows(0).Item("identificacion")
    '            Me.TextBox102.Text = "(" & tabla.Rows(0).Item("codigoAfiliado") & ") " & tabla.Rows(0).Item("pnombre") & " " & tabla.Rows(0).Item("snombre") & " " & tabla.Rows(0).Item("papellido") & " " & tabla.Rows(0).Item("sapellido")
    '        Else
    '            Me.TextBox101.Text = ""
    '            Me.TextBox102.Text = ""
    '        End If
    '    End With
    'End Sub
End Class
