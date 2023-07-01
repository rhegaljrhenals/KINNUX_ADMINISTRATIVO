Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsItemDetalle

    Private _numero As Integer
    Dim objOperacione As New clsOperacione

    Public Property numero As Integer
        Get
            Return _numero
        End Get
        Set(ByVal value As Integer)
            _numero = value
        End Set
    End Property

    Function obtenerItems() As datatable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select " & _
        "numero," & _
        "'' as idProducto," & _
        "'' as nombreProducto," & _
        "'' as cajas," & _
        "'' as unidades," & _
        "'' as tc," & _
        "'' as precio," & _
        "'' as subtotal" & _
        " from TBNumeroItem order by numero"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
