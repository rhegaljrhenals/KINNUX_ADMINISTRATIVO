Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsPaise

    Private _idPais As Integer
    Private _codigoPais As String
    Private _nombrePais As String
    Private _sufijoPais As String
    Private _numeroPais As Long
    Private _estadoPais As Integer
    Dim objOperacione As New clsOperacione

    Public Property IdPais As Integer
        Get
            Return _idPais
        End Get
        Set(ByVal value As Integer)
            _idPais = value
        End Set
    End Property

    Public Property CodigoPais As String
        Get
            Return _codigoPais
        End Get
        Set(ByVal value As String)
            _codigoPais = value
        End Set
    End Property

    Public Property NombrePais As String
        Get
            Return _nombrePais
        End Get
        Set(ByVal value As String)
            _nombrePais = value
        End Set
    End Property

    Public Property SufijoPais As String
        Get
            Return _sufijoPais
        End Get
        Set(ByVal value As String)
            _sufijoPais = value
        End Set
    End Property

    Public Property NumeroPais As Long
        Get
            Return _numeroPais
        End Get
        Set(ByVal value As Long)
            _numeroPais = value
        End Set
    End Property

    Public Property EstadoPais As Integer
        Get
            Return _estadoPais
        End Get
        Set(ByVal value As Integer)
            _estadoPais = value
        End Set
    End Property

    Sub GrabarPais(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaPais " & _
        "@idPais='" & Me.IdPais & "'," & _
        "@codigoPais='" & Me.CodigoPais & "'," & _
        "@nombrePais='" & Me.NombrePais & "'," & _
        "@sufijoPais='" & Me.SufijoPais & "'," & _
        "@numeroPais='" & Me.NumeroPais & "'," & _
        "@estadoPais='" & Me.EstadoPais & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function MostrarPaise() As DataTable
        Dim tabla As New DataTable
        With objOperacione
            tabla = .DevuelveDato("Select * from TBPais order by idpais")
        End With
        Return tabla
    End Function

    

End Class
