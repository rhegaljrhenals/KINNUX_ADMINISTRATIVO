Imports Microsoft.VisualBasic
Imports System.Data

Public Class clsTTDetGrupalBinario

    Private _fechaInicial As Date
    Private _fechaFinal As Date
    Private _codigoAfiliado As String
    Dim objOperacione As New clsOperacione

    Public Property codigoAfiliado As String
        Get
            Return _codigoAfiliado
        End Get
        Set(ByVal value As String)
            _codigoAfiliado = value
        End Set
    End Property

    Public Property fechaInicial As Date
        Get
            Return _fechaInicial
        End Get
        Set(ByVal value As Date)
            _fechaInicial = value
        End Set
    End Property

    Public Property fechaFinal As Date
        Get
            Return _fechaFinal
        End Get
        Set(ByVal value As Date)
            _fechaFinal = value
        End Set
    End Property

    ' funcion para obtener el detalle de las comisiones del binario
    Function obtenerDetalleBinario() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "dbo.Afiliaciones.codigoAfiliado, " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres, " & _
        "TTDetgrupalbinario.puntosdetgrupalbinario," & _
        "TTDetgrupalbinario.ladodetgrupalbinario," & _
        "TTDetgrupalbinario.fechaidetgrupalbinario," & _
        "TTDetgrupalbinario.fechafdetgrupalbinario" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " TTDetgrupalbinario ON dbo.Afiliaciones.codigoAfiliado = TTDetgrupalbinario.codigoafiliadocom" & _
        " where TTDetgrupalbinario.codigoAfiliado='" & Me.codigoAfiliado & "' and" & _
        " TTDetgrupalbinario.fechaidetgrupalbinario='" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and" & _
        " TTDetgrupalbinario.fechafdetgrupalbinario='" & Me.fechaFinal.ToString("yyyy/MM/dd") & "' order by TTDetgrupalbinario.ladodetgrupalbinario"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para sumar el lado izquierdo
    Function sumarLadoIzquierdoDetalleBinario() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "isnull(sum(TTDetgrupalbinario.puntosdetgrupalbinario),0) as suma" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " TTDetgrupalbinario ON dbo.Afiliaciones.codigoAfiliado = TTDetgrupalbinario.codigoafiliadocom" & _
        " where TTDetgrupalbinario.codigoAfiliado='" & Me.codigoAfiliado & "' and" & _
        " TTDetgrupalbinario.fechaidetgrupalbinario='" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and" & _
        " TTDetgrupalbinario.fechafdetgrupalbinario='" & Me.fechaFinal.ToString("yyyy/MM/dd") & "' and" & _
        " TTDetgrupalbinario.ladodetgrupalbinario='L'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para sumar el lado derecho
    Function sumarLadoDerechoDetalleBinario() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "isnull(sum(TTDetgrupalbinario.puntosdetgrupalbinario),0) as suma" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " TTDetgrupalbinario ON dbo.Afiliaciones.codigoAfiliado = TTDetgrupalbinario.codigoafiliadocom" & _
        " where TTDetgrupalbinario.codigoAfiliado='" & Me.codigoAfiliado & "' and" & _
        " TTDetgrupalbinario.fechaidetgrupalbinario='" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and" & _
        " TTDetgrupalbinario.fechafdetgrupalbinario='" & Me.fechaFinal.ToString("yyyy/MM/dd") & "' and" & _
        " TTDetgrupalbinario.ladodetgrupalbinario='R'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function


End Class
