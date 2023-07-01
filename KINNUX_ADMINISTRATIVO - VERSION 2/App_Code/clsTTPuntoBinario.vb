Imports Microsoft.VisualBasic
Imports System.Data

Public Class clsTTPuntoBinario

    Dim objOperacione As New clsOperacione

    ' funcion para obtener los puntos acumulados binario
    Function obtenerPuntosAcumulados() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "dbo.Afiliaciones.codigoAfiliado, " & _
        "dbo.Afiliaciones.Pnombre+ ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres, " & _
        "TTPuntoBinario.acumipuntobinario," & _
        "TTPuntoBinario.acumdpuntobinario" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " TTPuntoBinario ON dbo.Afiliaciones.codigoAfiliado = TTPuntoBinario.codigoafiliado" & _
        " order by dbo.Afiliaciones.codigoAfiliado"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
