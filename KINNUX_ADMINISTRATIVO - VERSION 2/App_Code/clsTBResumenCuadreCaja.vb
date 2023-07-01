Imports Microsoft.VisualBasic
Imports System.Data

Public Class clsTBResumenCuadreCaja

    Public _nombreItem As String
    Dim objOperacione As New clsOperacione

    Public Property nombreItem As String
        Get
            Return _nombreItem
        End Get
        Set(value As String)
            _nombreItem = value
        End Set
    End Property

    Function obtenerItems() As Datatable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select nombreitem,'0' as total from TBResumenCuadreCaja"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerResumenFormasPago() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select nombreconcepto,'0' as total from TBConceptosFormasPago"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
