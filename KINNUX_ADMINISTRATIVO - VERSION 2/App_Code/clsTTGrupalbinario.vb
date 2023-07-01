Imports Microsoft.VisualBasic
Imports System.Data

Public Class clsTTGrupalbinario

    Private _codigoAfiliado As String
    Private _fechaInicial As Date
    Private _fechaFinal As Date
    Private _mesSeleccionado As Integer
    Private _anoSeleccionado As Integer
    Dim objOperacione As New clsOperacione

    Public Property mesSeleccionado As String
        Get
            Return _mesSeleccionado
        End Get
        Set(ByVal value As String)
            _mesSeleccionado = value
        End Set
    End Property

    Public Property anoSeleccionado As String
        Get
            Return _anoSeleccionado
        End Get
        Set(ByVal value As String)
            _anoSeleccionado = value
        End Set
    End Property

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

    'funcion para obtener el detalle de las comisiones por afiliado
    Function obtenerDetalleComisionesPorAfiliados() As datatable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TTGrupalbinario" & _
            " where codigoafiliado='" & Me.codigoAfiliado & "'" & _
            " and fechaigrupalbinario='" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and fechafgrupalbinario='" & Me.fechaFinal.ToString("yyyy/MM/dd") & "'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener totales por semanas
    Function obtenerTotalesPorSemanas() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select " & _
        "sum(izqGrupalBinario) izq," & _
        "sum(derGrupalBinario) der," & _
        "fechaiGrupalBinario," & _
        "fechafGrupalBinario" & _
        " from TTGrupalbinario" & _
        " where" & _
        " Month(fechaiGrupalBinario) = " & Me.mesSeleccionado & " And" & _
        " Year(fechaiGrupalBinario) = " & Me.anoSeleccionado & _
        " group by fechaiGrupalBinario,fechafGrupalBinario" & _
        " order by fechaiGrupalBinario"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener los afiliados por semanas
    Function obtenerDatosPorSemanas() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "dbo.Afiliaciones.codigoAfiliado, " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres, " & _
        "TTGrupalbinario.izqgrupalbinario," & _
        "TTGrupalbinario.dergrupalbinario," & _
        "TTGrupalbinario.fechaigrupalbinario," & _
        "TTGrupalbinario.fechafgrupalbinario" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " TTGrupalbinario ON dbo.Afiliaciones.codigoAfiliado = TTGrupalbinario.codigoafiliado" & _
        " where TTGrupalbinario.fechaigrupalbinario='" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and TTGrupalbinario.fechafgrupalbinario='" & Me.fechaFinal.ToString("yyyy/MM/dd") & "'" & _
        " order by dbo.Afiliaciones.codigoAfiliado"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
