Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsMunicipio

    Private _idMunicipio As Integer
    Private _idPais As Integer
    Private _idDpto As String
    Private _codigoMunicipio As String
    Private _nombreMunicipio As String
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

    Public Property codigoMunicipio As String
        Get
            Return _codigoMunicipio
        End Get
        Set(ByVal value As String)
            _codigoMunicipio = value
        End Set
    End Property

    Public Property nombreMunicipio As String
        Get
            Return _nombreMunicipio
        End Get
        Set(ByVal value As String)
            _nombreMunicipio = value
        End Set
    End Property

    Function obtenerMunicipioPorPaisyDpto() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from TBMunicipio where idPais=" & Me.idPais & " and" & _
            " idDpto=" & Me.idDpto
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
