Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsPlan

    Private _idPlan As Integer
    Private _nombrePlan As String
    Dim objOperacione As New clsOperacione

    Public Property idPlan As Integer
        Get
            Return _idPlan
        End Get
        Set(ByVal value As Integer)
            _idPlan = value
        End Set
    End Property


    Public Property nombrePlan As String
        Get
            Return _nombrePlan
        End Get
        Set(ByVal value As String)
            _nombrePlan = value
        End Set
    End Property

    Function obtenerPlanesTodos() As datatable
        Dim tabla As New DataTable
        With objOperacione
            tabla = .DevuelveDato("select * from plane order by idPlan")
        End With
        Return tabla
    End Function

End Class
