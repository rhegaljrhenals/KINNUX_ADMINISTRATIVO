Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsRango

    Private _idRango As Integer
    Private _nombreRango As String
    Private _ruta As String
    Dim objOperacione As New clsOperacione

    Public Property idRango As Integer
        Get
            Return _idRango
        End Get
        Set(ByVal value As Integer)
            _idRango = value
        End Set
    End Property

    Public Property nombreRango As String
        Get
            Return _nombreRango
        End Get
        Set(ByVal value As String)
            _nombreRango = value
        End Set
    End Property

    Public Property ruta As String
        Get
            Return _ruta
        End Get
        Set(ByVal value As String)
            _ruta = value
        End Set
    End Property

    Function obtenerRangoPorId() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from tbRango where idRango=" & Me.idRango
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
