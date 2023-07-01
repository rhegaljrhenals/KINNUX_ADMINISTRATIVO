Imports Microsoft.VisualBasic
Imports System.Data

Public Class clsTTDetDesProductoPunto

    Private _idEncDesProductoPunto As Integer
    Dim objOperaciones As New clsOperacione

    Public Property idEncDesProductoPunto As Integer
        Get
            Return _idEncDesProductoPunto
        End Get
        Set(value As Integer)
            _idEncDesProductoPunto = value
        End Set
    End Property

    Function obtenerDetalledespachoPorEmpresa() As datatable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TTDetDesProductoPunto.idEncDesProductoPunto," & _
        "TTDetDesProductoPunto.cantEnvDetDesProductoPunto," & _
        "TTDetDesProductoPunto.cantRecDetDesProductoPunto," & _
        "TTDetDesProductoPunto.cantPenDetDesProductoPunto," & _
        "TTDetDesProductoPunto.valorDetDesProductoPunto," & _
        "TTDetDesProductoPunto.subtotalDetDesProductoPunto," & _
        "TBProducto.idProducto," & _
        "TBProducto.nombreProducto" & _
        " FROM" & _
        " TTEncDesProductoPunto INNER JOIN" & _
        " TTDetDesProductoPunto ON " & _
        " TTEncDesProductoPunto.idEncDesProductoPunto = TTDetDesProductoPunto.idEncDesProductoPunto INNER JOIN" & _
        " TBProducto ON TTDetDesProductoPunto.idProducto = TBProducto.idProducto" & _
        " where TTDetDesProductoPunto.idEncDesProductoPunto=" & Me.idEncDesProductoPunto
        With objOperaciones
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
