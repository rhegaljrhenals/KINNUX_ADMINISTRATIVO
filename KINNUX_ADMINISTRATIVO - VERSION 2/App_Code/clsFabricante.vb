Imports Microsoft.VisualBasic
Imports System.Data

Public Class clsFabricante

    Private _idFabricante As Integer
    Private _codigoFabricante As String
    Private _nombreFabricante As String
    Private _direccionFabricante As String
    Private _telefonoFabricante As String
    Private _emailFabricante As String
    Private _dptoFabricante As String
    Private _ciudadFabricante As String
    Private _estadoFabricante As Integer
    Private _permisoFabricante As String
    Private _fichaFabricante As String
    Dim objOperacione As New clsOperacione

    Public Property idFabricante As Integer
        Get
            Return _idFabricante
        End Get
        Set(ByVal value As Integer)
            _idFabricante = value
        End Set
    End Property

    Public Property codigoFabricante As String
        Get
            Return _codigoFabricante
        End Get
        Set(ByVal value As String)
            _codigoFabricante = value
        End Set
    End Property

    Public Property nombreFabricante As String
        Get
            Return _nombreFabricante
        End Get
        Set(ByVal value As String)
            _nombreFabricante = value
        End Set
    End Property

    Public Property direccionFabricante As String
        Get
            Return _direccionFabricante
        End Get
        Set(ByVal value As String)
            _direccionFabricante = value
        End Set
    End Property

    Public Property telefonoFabricante As String
        Get
            Return _telefonoFabricante
        End Get
        Set(ByVal value As String)
            _telefonoFabricante = value
        End Set
    End Property

    Public Property emailFabricante As String
        Get
            Return _emailFabricante
        End Get
        Set(ByVal value As String)
            _emailFabricante = value
        End Set
    End Property

    Public Property dptoFabricante As String
        Get
            Return _dptoFabricante
        End Get
        Set(ByVal value As String)
            _dptoFabricante = value
        End Set
    End Property

    Public Property ciudadFabricante As String
        Get
            Return _ciudadFabricante
        End Get
        Set(ByVal value As String)
            _ciudadFabricante = value
        End Set
    End Property

    Public Property estadoFabricante As Integer
        Get
            Return _estadoFabricante
        End Get
        Set(ByVal value As Integer)
            _estadoFabricante = value
        End Set
    End Property

    Public Property permisoFabricante As String
        Get
            Return _permisoFabricante
        End Get
        Set(ByVal value As String)
            _permisoFabricante = value
        End Set
    End Property

    Public Property fichaFabricante As String
        Get
            Return _fichaFabricante
        End Get
        Set(ByVal value As String)
            _fichaFabricante = value
        End Set
    End Property

    Sub actualizarFabricante(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_ActualizaFabricante " & _
        "@idFabricante='" & Me.idFabricante & "'," & _
        "@codigoFabricante='" & Me.codigoFabricante & "'," & _
        "@nombreFabricante='" & Me.nombreFabricante & "'," & _
        "@direccionFabricante='" & Me.direccionFabricante & "'," & _
        "@telefonoFabricante='" & Me.telefonoFabricante & "'," & _
        "@emailFabricante='" & Me.emailFabricante & "'," & _
        "@dptoFabricante='" & Me.dptoFabricante & "'," & _
        "@ciudadFabricante='" & Me.ciudadFabricante & "'," & _
        "@estadoFabricante='" & Me.estadoFabricante & "'," & _
        "@accion='" & accion & "'," & _
        "@permisoFabricante='" & Me.permisoFabricante & "'," & _
        "@fichaFabricante='" & Me.fichaFabricante & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtieneFabricantesTodos() As DataTable
        Dim tabla As New DataTable
        With objOperacione
            tabla = .DevuelveDato("select * from TBFabricante order by idFabricante")
        End With
        Return tabla
    End Function

    Function obtieneFabricantesPorId() As DataTable
        Dim tabla As New DataTable
        With objOperacione
            tabla = .DevuelveDato("select * from TBFabricante where idFabricante=" & Me.idFabricante)
        End With
        Return tabla
    End Function

End Class
