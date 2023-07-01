Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsSucursale

    Private _idSucursal As Integer
    Private _idEmpresa As Integer
    Private _idAfiliado As Integer
    Private _nombreSucursal As String
    Private _direccionSucursal As String
    Private _telefonoSucursal As String
    Private _ciudadSucursal As String
    Private _dptoSucursal As String
    Private _estadoSucursal As Integer
    Dim objOperacione As New clsOperacione

    Public Property idSucursal As Integer
        Get
            Return _idSucursal
        End Get
        Set(ByVal value As Integer)
            _idSucursal = value
        End Set
    End Property

    Public Property idEmpresa As Integer
        Get
            Return _idEmpresa
        End Get
        Set(ByVal value As Integer)
            _idEmpresa = value
        End Set
    End Property

    Public Property idAfiliado As Integer
        Get
            Return _idAfiliado
        End Get
        Set(ByVal value As Integer)
            _idAfiliado = value
        End Set
    End Property

    Public Property nombreSucursal As String
        Get
            Return _nombreSucursal
        End Get
        Set(ByVal value As String)
            _nombreSucursal = value
        End Set
    End Property

    Public Property direccionSucursal As String
        Get
            Return _direccionSucursal
        End Get
        Set(ByVal value As String)
            _direccionSucursal = value
        End Set
    End Property

    Public Property telefonoSucursal As String
        Get
            Return _telefonoSucursal
        End Get
        Set(ByVal value As String)
            _telefonoSucursal = value
        End Set
    End Property

    Public Property ciudadSucursal As String
        Get
            Return _ciudadSucursal
        End Get
        Set(ByVal value As String)
            _ciudadSucursal = value
        End Set
    End Property

    Public Property dptoSucursal As String
        Get
            Return _dptoSucursal
        End Get
        Set(ByVal value As String)
            _dptoSucursal = value
        End Set
    End Property

    Public Property estadoSucursal As Integer
        Get
            Return _estadoSucursal
        End Get
        Set(ByVal value As Integer)
            _estadoSucursal = value
        End Set
    End Property

    Sub grabarSucursal(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaSucursale " & _
        "@idSucursal='" & Me.idSucursal & "'," & _
        "@idEmpresa='" & Me.idEmpresa & "'," & _
        "@idAfiliado='" & Me.idAfiliado & "'," & _
        "@nombreSucursal='" & Me.nombreSucursal & "'," & _
        "@direccionSucursal='" & Me.direccionSucursal & "'," & _
        "@telefonoSucursal='" & Me.telefonoSucursal & "'," & _
        "@ciudadSucursal='" & Me.ciudadSucursal & "'," & _
        "@dptoSucursal='" & Me.dptoSucursal & "'," & _
        "@estadoSucursal='" & Me.estadoSucursal & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function muestraSucursale() As DataTable
        Dim tabla As New DataTable
        With objOperacione
            tabla = .DevuelveDato("exec sp_muestraSucursale")
        End With
        Return tabla
    End Function

    Function obtenerSucursalePorEmpresa() As DataTable
        Dim sql As String
        sql = "SELECT " & _
        "TBSucursal.idSucursal, " & _
        "TBSucursal.nombreSucursal, " & _
        "TBSucursal.direccionSucursal, " & _
        "TBSucursal.telefonoSucursal, " & _
        "TBSucursal.ciudadSucursal, " & _
        "TBSucursal.dptoSucursal, " & _
        "TBEmpresa.idEmpresa, " & _
        "TBEmpresa.nombreEmpresa, " & _
        "TBSucursal.estadoSucursal," & _
        "case TBSucursal.estadoSucursal" & _
        " when '1' then 'Activo'" & _
        " when '2' then 'Eliminado'" & _
        " end nombreEstado" & _
        " FROM" & _
        " TBEmpresa INNER JOIN" & _
        " TBSucursal ON TBEmpresa.idEmpresa = TBSucursal.idEmpresa"
        If Me.idEmpresa <> 0 Then
            sql = sql & " where TBSucursal.idEmpresa=" & Me.idEmpresa
        End If
        Dim tabla As New DataTable
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para mostrar la sucursal por ir
    Function obtenerSucursalPorId() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from tbsucursal where idSucursal=" & Me.idSucursal
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
