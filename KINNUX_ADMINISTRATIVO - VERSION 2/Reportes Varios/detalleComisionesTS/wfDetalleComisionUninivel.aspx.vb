Imports System.Data

Partial Class wfReporteDetalleComisionIR
    Inherits System.Web.UI.Page

    Dim operaciones As New clsOperacione

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            mostrarDetalleComisionMesIR()
        End If
    End Sub

    Sub mostrarDetalleComisionMesIR()
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "'(' + dbo.Afiliaciones.codigoAfiliado +') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres, " & _
        "TTdetcomisionUNTS.niveldetcomisionunts," & _
        "TTdetcomisionUNTS.valordetcomisionunts," & _
        "TTdetcomisionUNTS.mescomisionunts," & _
        "TTdetcomisionUNTS.anocomisionunts" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " TTdetcomisionUNTS ON dbo.Afiliaciones.codigoAfiliado = TTdetcomisionUNTS.codigoafiliadocom" & _
        " where TTdetcomisionUNTS.codigoafiliado = '" & Request.QueryString("id") & "' and" & _
        " TTdetcomisionUNTS.mescomisionunts=" & Request.QueryString("mes") & " and" & _
        " TTdetcomisionUNTS.anocomisionunts=" & Request.QueryString("ano") & " order by TTdetcomisionUNTS.niveldetcomisionunts"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.GridView8.DataSource = tabla
                Me.GridView8.DataBind()
            Else
                Me.GridView8.DataSource = Nothing
                Me.GridView8.DataBind()
            End If

        End With
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Response.Write("<script>self.close();</script>")
    End Sub
End Class
