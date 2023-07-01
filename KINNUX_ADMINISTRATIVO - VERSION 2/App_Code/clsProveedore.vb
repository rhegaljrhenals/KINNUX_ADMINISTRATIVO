Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsProveedore

    Private _idProveedor As Integer
    Private _codigoProveedor As String
    Private _nombreProveedor As String
    Private _direccionProveedor As String
    Private _telefonoProveedor As String
    Private _emailProveedor As String
    Private _dptoProveedor As String
    Private _ciudadProveedor As String
    Private _estadoProveedor As Integer
    Dim objOperacione As New clsOperacione

    Public Property idProveedor As Integer
        Get
            Return _idProveedor
        End Get
        Set(ByVal value As Integer)
            _idProveedor = value
        End Set
    End Property

    Public Property codigoProveedor As String
        Get
            Return _codigoProveedor
        End Get
        Set(ByVal value As String)
            _codigoProveedor = value
        End Set
    End Property

    Public Property nombreProveedor As String
        Get
            Return _nombreProveedor
        End Get
        Set(ByVal value As String)
            _nombreProveedor = value
        End Set
    End Property

    Public Property direccionProveedor As String
        Get
            Return _direccionProveedor
        End Get
        Set(ByVal value As String)
            _direccionProveedor = value
        End Set
    End Property

    Public Property telefonoProveedor As String
        Get
            Return _telefonoProveedor
        End Get
        Set(ByVal value As String)
            _telefonoProveedor = value
        End Set
    End Property

    Public Property emailProveedor As String
        Get
            Return _emailProveedor
        End Get
        Set(ByVal value As String)
            _emailProveedor = value
        End Set
    End Property

    Public Property dptoProveedor As String
        Get
            Return _dptoProveedor
        End Get
        Set(ByVal value As String)
            _dptoProveedor = value
        End Set
    End Property

    Public Property ciudadProveedor As String
        Get
            Return _ciudadProveedor
        End Get
        Set(ByVal value As String)
            _ciudadProveedor = value
        End Set
    End Property

    Public Property estadoProveedor As Integer
        Get
            Return _estadoProveedor
        End Get
        Set(ByVal value As Integer)
            _estadoProveedor = value
        End Set
    End Property

    Sub actualizarProveedor(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_ActualizaProveedore " & _
        "@idProveedor='" & Me.idProveedor & "'," & _
        "@codigoProveedor='" & Me.codigoProveedor & "'," & _
        "@nombreProveedor='" & Me.nombreProveedor & "'," & _
        "@direccionProveedor='" & Me.direccionProveedor & "'," & _
        "@telefonoProveedor='" & Me.telefonoProveedor & "'," & _
        "@emailProveedor='" & Me.emailProveedor & "'," & _
        "@dptoProveedor='" & Me.dptoProveedor & "'," & _
        "@ciudadProveedor='" & Me.ciudadProveedor & "'," & _
        "@estadoProveedor='" & Me.estadoProveedor & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtieneProveedoreTodos() As datatable
        Dim tabla As New DataTable
        With objOperacione
            tabla = .DevuelveDato("select * from TBProveedor order by idProveedor")
        End With
        Return tabla
    End Function

    Function obtieneProveedorePorId() As DataTable
        Dim tabla As New DataTable
        With objOperacione
            tabla = .DevuelveDato("select * from TBProveedor where idProveedor=" & Me.idProveedor)
        End With
        Return tabla
    End Function
End Class
