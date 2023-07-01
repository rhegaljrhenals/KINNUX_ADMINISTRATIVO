Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsDpto

    Private _idPais As Integer
    Private _idDpto As String
    Private _codigoDpto As String
    Private _nombreDpto As String
    Dim objOperacione As New clsOperacione

    Public Property idPais As Integer
        Get
            Return _idPais
        End Get
        Set(ByVal value As Integer)
            _idPais = value
        End Set
    End Property

    Public Property idDpto As String
        Get
            Return _idDpto
        End Get
        Set(ByVal value As String)
            _idDpto = value
        End Set
    End Property

    Public Property codigoDpto As String
        Get
            Return _codigoDpto
        End Get
        Set(ByVal value As String)
            _codigoDpto = value
        End Set
    End Property

    Public Property nombreDpto As String
        Get
            Return _nombreDpto
        End Get
        Set(ByVal value As String)
            _nombreDpto = value
        End Set
    End Property

    Function obtenerDptoPorPais() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from TBDpto where idPais=" & Me.idPais
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
