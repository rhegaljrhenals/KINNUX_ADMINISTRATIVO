Imports System.Data

Partial Class Facturacion_wfImpresionFactura
    Inherits System.Web.UI.Page

    Dim operaciones As New clsOperacione

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            mostrarDatos()
        End If
    End Sub

    Sub mostrarDatos()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TTComisionKit.idComisionKit, " & _
        "TTComisionKit.valorComisionKit, " & _
        "TTComisionKit.fechaPagoComisionKit, " & _
        "TTComisionKit.pagoComisionKit, " & _
        "dbo.Afiliaciones.codigoAfiliado," & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido quiencobro, " & _
        "'(' + Afiliaciones_1.codigoAfiliado + ') ' + Afiliaciones_1.Pnombre + ' ' + Afiliaciones_1.Snombre + ' ' + Afiliaciones_1.Papellido + ' ' + Afiliaciones_1.Sapellido AS quiencompro, " & _
        "TTEncFacturaPro.idEncFacturaPro," & _
        "TTEncFacturaPro.fechaEncFacturaPro," & _
        "TTEncFacturaPro.puntosEncfacturaPro," & _
        "dbo.Afiliaciones.direccion," & _
        "dbo.Afiliaciones.telefono," & _
        "dbo.Afiliaciones.identificacion," & _
        "dbo.Afiliaciones.telefono, dbo.Afiliaciones.identificacion, dbo.TBSucursal.nombreSucursal," & _
        "TBUsuario.nombreCompletoUsuario" & _
        " FROM         TTComisionKit INNER JOIN" & _
        " dbo.Afiliaciones ON TTComisionKit.codigoAfiliado = dbo.Afiliaciones.codigoAfiliado INNER JOIN" & _
        " TTDetComisionKit ON TTComisionKit.idComisionKit = TTDetComisionKit.idComisionKit INNER JOIN" & _
        " dbo.Afiliaciones AS Afiliaciones_1 ON TTDetComisionKit.codigoAfiliadoCom = Afiliaciones_1.codigoAfiliado INNER JOIN" & _
        " TTEncFacturaPro ON TTDetComisionKit.idEncFacturaPro = TTEncFacturaPro.idEncFacturaPro INNER JOIN" & _
        " dbo.TBSucursal ON TTEncFacturaPro.idEmpresa = dbo.TBSucursal.idEmpresa AND " & _
        " TTEncFacturaPro.idSucursal = dbo.TBSucursal.idSucursal INNER JOIN" & _
        " TBUsuario ON TTComisionKit.usuarioPagoComisionKit = TBUsuario.idUsuario" & _
        " where TTComisionKit.idComisionKit=" & Request.QueryString("ie")
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.Label46.Text = Microsoft.VisualBasic.Left(tabla.Rows(0).Item("nombreCompletoUsuario"), 33)
                Me.Label42.Text = tabla.Rows(0).Item("valorComisionKit")
                Me.Label41.Text = tabla.Rows(0).Item("valorComisionKit")
                Me.Label25.Text = CDate(tabla.Rows(0).Item("fechaPagoComisionKit")).ToString("yyyy/MM/dd")
                Me.Label26.Text = tabla.Rows(0).Item("idComisionKit")
                '
                Me.Label27.Text = "(" & tabla.Rows(0).Item("codigoAfiliado") & ") " & tabla.Rows(0).Item("quiencobro")
                Me.Label28.Text = tabla.Rows(0).Item("direccion")
                Me.Label30.Text = tabla.Rows(0).Item("telefono")
                '
                Me.GridView6.DataSource = tabla
                Me.GridView6.DataBind()
                '
            End If
        End With
    End Sub
End Class
