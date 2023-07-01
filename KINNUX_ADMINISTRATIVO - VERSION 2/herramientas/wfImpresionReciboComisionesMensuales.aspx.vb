Imports System.Data

Partial Class Facturacion_wfImpresionFactura
    Inherits System.Web.UI.Page

    Dim operaciones As New clsOperacione

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            mostrardatos()
        End If
    End Sub

    Sub mostrarDatos()
        Dim mes As String = ""
        Dim sql As String
        Dim tabla As DataTable
        sql = "SELECT     " & _
        "TTComision.compracomision, " & _
        "TTComision.iniciorcomision, " & _
        "TTComision.uninivelcomision, " & _
        "TTComision.avancelcomision, " & _
        "TTComision.genbinariocomision, " & _
        "TTComision.generacionalcomision," & _
        "TTComision.estructuracomision, " & _
        "TTComision.elitecomision, " & _
        "TTComision.bono1comision, " & _
        "TTComision.bono2comision, " & _
        "TTComision.bonocarrocomision, " & _
        "TTComision.mescomision, " & _
        "TTComision.anocomision, " & _
        "TTComision.fechapagocomision, " & _
        "TBUsuario.nombreCompletoUsuario," & _
        "dbo.Afiliaciones.identificacion, " & _
        "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as quiencobro" & _
        " FROM" & _
        " TTComision INNER JOIN" & _
        " TBUsuario ON TTComision.usuariopagocomision = TBUsuario.idUsuario INNER JOIN" & _
        " dbo.Afiliaciones ON TTComision.codigoafiliado = dbo.Afiliaciones.codigoAfiliado" & _
        " where TTComision.idcomision=" & Request.QueryString("ie")
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.TextBox90.Text = FormatNumber(tabla.Rows(0).Item("iniciorcomision"), 2)
                Me.TextBox91.Text = FormatNumber(tabla.Rows(0).Item("uninivelcomision"), 2)
                Me.TextBox92.Text = FormatNumber(tabla.Rows(0).Item("avancelcomision"), 2)
                Me.TextBox93.Text = FormatNumber(tabla.Rows(0).Item("genbinariocomision"), 2)
                Me.TextBox94.Text = FormatNumber(tabla.Rows(0).Item("generacionalcomision"), 2)
                Me.TextBox95.Text = FormatNumber(tabla.Rows(0).Item("estructuracomision"), 2)
                Me.TextBox96.Text = FormatNumber(tabla.Rows(0).Item("elitecomision"), 2)
                Me.TextBox97.Text = FormatNumber(tabla.Rows(0).Item("bono1comision"), 2)
                Me.TextBox98.Text = FormatNumber(tabla.Rows(0).Item("bono2comision"), 2)
                Me.TextBox99.Text = FormatNumber(tabla.Rows(0).Item("bonocarrocomision"), 2)
                Me.TextBox100.Text = FormatNumber((CDbl(Me.TextBox90.Text) + CDbl(Me.TextBox91.Text) + CDbl(Me.TextBox92.Text) + CDbl(Me.TextBox93.Text) + CDbl(Me.TextBox94.Text) + CDbl(Me.TextBox95.Text) + CDbl(Me.TextBox96.Text) + CDbl(Me.TextBox97.Text) + CDbl(Me.TextBox98.Text) + CDbl(Me.TextBox99.Text)), 2)
                Me.TextBox104.Text = CDate(tabla.Rows(0).Item("fechaPagoComision")).ToString("yyyy/MM/dd")
                Me.TextBox105.Text = Microsoft.VisualBasic.Left(tabla.Rows(0).Item("nombrecompletoUsuario"), 33)
                Select Case tabla.Rows(0).Item("mesComision")
                    Case Is = 1
                        mes = "Enero"
                    Case Is = 2
                        mes = "Febrero"
                    Case Is = 3
                        mes = "Marzo"
                    Case Is = 4
                        mes = "Abril"
                    Case Is = 5
                        mes = "Mayo"
                    Case Is = 6
                        mes = "Junio"
                    Case Is = 7
                        mes = "Julio"
                    Case Is = 8
                        mes = "Agosto"
                    Case Is = 9
                        mes = "Septiembre"
                    Case Is = 10
                        mes = "Octubre"
                    Case Is = 11
                        mes = "Noviembre"
                    Case Is = 12
                        mes = "Diciembre"
                End Select
                Me.Label48.Text = "Mes De: " & mes & " - Año: " & tabla.Rows(0).Item("anoComision")
                Me.TextBox101.Text = tabla.Rows(0).Item("identificacion")
                Me.TextBox102.Text = tabla.Rows(0).Item("quiencobro")
                Me.TextBox103.Text = Request.QueryString("ie")
            Else

            End If
        End With

    End Sub

    End Class
