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
        "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres, " & _
        "TTDetComisionBSTS.numtsdetcomisionbsts," & _
        "TTDetComisionBSTS.pagoxtsdetcomisionbsts," & _
        "TTDetComisionBSTS.valordetcomisionbsts" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " TTDetComisionBSTS ON dbo.Afiliaciones.codigoAfiliado = TTDetComisionBSTS.codigoafiliadocom" & _
        " where TTDetComisionBSTS.codigoafiliado = '" & Request.QueryString("id") & "' and" & _
        " TTDetComisionBSTS.mesdetcomisionbsts=" & Request.QueryString("mes") & " and" & _
        " TTDetComisionBSTS.anodetcomisionbsts=" & Request.QueryString("ano")
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
