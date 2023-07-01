Imports Microsoft.VisualBasic
Imports System.Data

Public Class clsTTEncDesProductoPaisPais

    Private _idEmpresa As Integer
    Private _fechaInicial As Date
    Private _fechaFinal As Date
    Private _idProducto As Integer
    Private _idEmpresaEnv As Integer
    Private _idEmpresaRec As Integer
    Dim objOperaciones As New clsOperacione

    Public Property idEmpresaRec As Integer
        Get
            Return _idEmpresaRec
        End Get
        Set(value As Integer)
            _idEmpresaRec = value
        End Set
    End Property

    Public Property idEmpresaEnv As Integer
        Get
            Return _idEmpresaEnv
        End Get
        Set(value As Integer)
            _idEmpresaEnv = value
        End Set
    End Property


    Public Property idProducto As Integer
        Get
            Return _idProducto
        End Get
        Set(value As Integer)
            _idProducto = value
        End Set
    End Property

    Public Property idEmpresa As Integer
        Get
            Return _idEmpresa
        End Get
        Set(value As Integer)
            _idEmpresa = value
        End Set
    End Property

    Public Property fechaInicial As Date
        Get
            Return _fechaInicial
        End Get
        Set(value As Date)
            _fechaInicial = value
        End Set
    End Property

    Public Property fechaFinal As Date
        Get
            Return _fechaFinal
        End Get
        Set(value As Date)
            _fechaFinal = value
        End Set
    End Property

    Function obtenerDespachosPaises() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TTEncDesProductoPaisPais.idEncDesProductoPaisPais, " & _
        "TTEncDesProductoPaisPais.fechaEncDesProductoPaisPais, " & _
        "TTEncDesProductoPaisPais.valorEncDesProductoPaisPais, " & _
        "TTEncDesProductoPaisPais.guiaEncDesProductoPaisPais, " & _
        "TTEncDesProductoPaisPais.observEncDesProductoPaisPais, " & _
        "TTEncDesProductoPaisPais.procesadoEncDesProductoPaisPais," & _
        "TTEncDesProductoPaisPais.confirEncDesProductoPaisPais, " & _
        "TTEncDesProductoPaisPais.estadoEncdesProductoPaisPais, " & _
        "dbo.TBEmpresa.idEmpresa, " & _
        "dbo.TBEmpresa.nombreEmpresa, " & _
        "TBEmpresa_1.idEmpresa AS idempresaRecibe, " & _
        "TBEmpresa_1.nombreEmpresa AS nombreempresaRecibe, " & _
        "ttDetDesProductoPaisPais.idDetDesProductoPaisPais," & _
        "ttDetDesProductoPaisPais.cantEnvDetDesProductoPaisPais," & _
        "ttDetDesProductoPaisPais.cantRecDetDesProductoPaisPais," & _
        "ttDetDesProductoPaisPais.cantPenDetDesProductoPaisPais," & _
        "ttDetDesProductoPaisPais.valorDetDesProductoPaisPais," & _
        "ttDetDesProductoPaisPais.subtotalDetDesProductoPaisPais," & _
        "TBProducto.idProducto," & _
        "TBProducto.nombreProducto" & _
        " FROM" & _
        " TTEncDesProductoPaisPais INNER JOIN" & _
        " ttDetDesProductoPaisPais ON " & _
        " TTEncDesProductoPaisPais.idEncDesProductoPaisPais = ttDetDesProductoPaisPais.idEncDesProductoPaisPais INNER JOIN" & _
        " dbo.TBEmpresa ON TTEncDesProductoPaisPais.idEmpresaEnv = dbo.TBEmpresa.idEmpresa INNER JOIN" & _
        " dbo.TBEmpresa AS TBEmpresa_1 ON TTEncDesProductoPaisPais.idEmpresaRec = TBEmpresa_1.idEmpresa INNER JOIN" & _
        " TBProducto ON ttDetDesProductoPaisPais.idProducto = TBProducto.idProducto" & _
        " where" & _
        " TBProducto.idProducto=" & Me.idProducto & " and" & _
        " TTEncDesProductoPaisPais.fechaEncDesProductoPaisPais between '" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and '" & Me.fechaFinal.ToString("yyyy/MM/dd") & "' and" & _
        " dbo.TBEmpresa.idEmpresa = " & Me.idEmpresa & " and" & _
        " TTEncDesProductoPaisPais.confirEncDesProductoPaisPais='si' and TTEncDesProductoPaisPais.estadoEncdesProductoPaisPais=1" & _
        " order by TTEncDesProductoPaisPais.fechaEncDesProductoPaisPais"
        With objOperaciones
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerDespachosPorEmpresas(ByVal tipoProceso As Integer) As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TTEncDesProductoPaisPais.idEmpresaEnv," & _
        "TTEncDesProductoPaisPais.idEmpresaRec, " & _
        "TTEncDesProductoPaisPais.idEncDesProductoPaisPais, " & _
        "TTEncDesProductoPaisPais.fechaEncDesProductoPaisPais, " & _
        "TTEncDesProductoPaisPais.valorEncDesProductoPaisPais, " & _
        "TTEncDesProductoPaisPais.guiaEncDesProductoPaisPais, " & _
        "TTEncDesProductoPaisPais.observEncDesProductoPaisPais, " & _
        "TTEncDesProductoPaisPais.procesadoEncDesProductoPaisPais," & _
        "TTEncDesProductoPaisPais.confirEncDesProductoPaisPais, " & _
        "TTEncDesProductoPaisPais.estadoEncdesProductoPaisPais, " & _
        "dbo.TBEmpresa.idEmpresa, " & _
        "dbo.TBEmpresa.nombreEmpresa, " & _
        "TBEmpresa_1.idEmpresa AS idRecibe, " & _
        "TBEmpresa_1.nombreEmpresa AS nombreRecibe" & _
        " FROM" & _
        " TTEncDesProductoPaisPais INNER JOIN" & _
        " dbo.TBEmpresa ON TTEncDesProductoPaisPais.idEmpresaEnv = dbo.TBEmpresa.idEmpresa INNER JOIN" & _
        " dbo.TBEmpresa AS TBEmpresa_1 ON TTEncDesProductoPaisPais.idEmpresaRec = TBEmpresa_1.idEmpresa" & _
        " where" & _
        " TTEncDesProductoPaisPais.idEmpresaEnv = " & Me.idEmpresaEnv & _
        " and TTEncDesProductoPaisPais.idEmpresaRec = " & Me.idEmpresaRec & " and" & _
        " TTEncDesProductoPaisPais.fechaEncDesProductoPaisPais between '" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and '" & Me.fechaFinal.ToString("yyyy/MM/dd") & "'"
        Select Case tipoProceso
            Case Is = 1
                sql = sql & " and TTEncDesProductoPaisPais.confirEncDesProductoPaisPais='Si'"
            Case Is = 2
                sql = sql & " and TTEncDesProductoPaisPais.confirEncDesProductoPaisPais='No'"
            Case Is = 3
                sql = sql & " and TTEncDesProductoPaisPais.confirEncDesProductoPaisPais='Pr'"
            Case Is = 4
                sql = sql & " and TTEncDesProductoPaisPais.estadoEncdesProductoPaisPais=0"
            Case Is = 5
                sql = sql & " and TTEncDesProductoPaisPais.estadoEncdesProductoPaisPais=1"
        End Select
        sql = sql & " Order by TTEncDesProductoPaisPais.fechaEncDesProductoPaisPais desc"
        With objOperaciones
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
