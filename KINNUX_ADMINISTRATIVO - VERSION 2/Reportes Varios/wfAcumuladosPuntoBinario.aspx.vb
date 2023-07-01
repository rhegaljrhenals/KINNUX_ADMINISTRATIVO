Imports System.Data

Partial Class Reportes_Varios_wfAcumuladosPuntoBinario
    Inherits System.Web.UI.Page

    Dim acumuladosPuntos As New clsTTPuntoBinario

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarPuntos()
        End If
    End Sub

    Sub cargarPuntos()
        Dim tabla As DataTable
        With acumuladosPuntos
            tabla = .obtenerPuntosAcumulados
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End With
    End Sub
End Class
