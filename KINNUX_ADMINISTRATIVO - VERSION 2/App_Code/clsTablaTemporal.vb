Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTablaTemporal

    Dim registro As DataRow
    Private _id As Integer
    Private _nombreProducto As String
    Private _cajas As Integer
    Private _unidades As Integer
    Private _valor As Integer
    Private _subtotal As Integer
    Public tablaTemporal As New DataTable

    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property nombreProducto As String
        Get
            Return _nombreProducto
        End Get
        Set(ByVal value As String)
            _nombreProducto = value
        End Set
    End Property


    Public Property cajas As Integer
        Get
            Return _cajas
        End Get
        Set(ByVal value As Integer)
            _cajas = value
        End Set
    End Property

    Public Property unidades As Integer
        Get
            Return _unidades
        End Get
        Set(ByVal value As Integer)
            _unidades = value
        End Set
    End Property

    Public Property valor As Integer
        Get
            Return _valor
        End Get
        Set(ByVal value As Integer)
            _valor = value
        End Set
    End Property

    Public Property subtotal As Integer
        Get
            Return _subtotal
        End Get
        Set(ByVal value As Integer)
            _subtotal = value
        End Set
    End Property


    Public Sub vaciarTabla()
        tablaTemporal.Rows.Clear()
        tablaTemporal.AcceptChanges()
        '
    End Sub

    Public Sub crearTablaTemporal()
        tablaTemporal.TableName = "tablaMuestra"
        Dim cId As New DataColumn
        cId.ColumnName = "id"
        cId.DataType = System.Type.GetType("System.Decimal")
        'cCodigoPatrocinador.AllowDBNull = False
        tablaTemporal.Columns.Add(cId)
        '
        '
        Dim cnombreProducto As New DataColumn
        cnombreProducto.ColumnName = "nombreProducto"
        cnombreProducto.DataType = System.Type.GetType("System.String")
        tablaTemporal.Columns.Add(cnombreProducto)
        '
        Dim cCajas As New DataColumn
        cCajas.ColumnName = "cajas"
        cCajas.DataType = System.Type.GetType("System.Decimal")
        tablaTemporal.Columns.Add(cCajas)
        '
        Dim cUnidades As New DataColumn
        cUnidades.ColumnName = "unidades"
        cUnidades.DataType = System.Type.GetType("System.Decimal")
        tablaTemporal.Columns.Add(cUnidades)
        '
        Dim cValor As New DataColumn
        cValor.ColumnName = "valor"
        cValor.DataType = System.Type.GetType("System.Decimal")
        tablaTemporal.Columns.Add(cValor)
        '
        Dim cSubtotal As New DataColumn
        cSubtotal.ColumnName = "subtotal"
        cSubtotal.DataType = System.Type.GetType("System.Decimal")
        tablaTemporal.Columns.Add(cSubtotal)
    End Sub

    Public Function grabarRegistro() As DataTable
        registro = tablaTemporal.NewRow
        registro.Item("id") = Me.id
        registro.Item("nombreproducto") = Me.nombreProducto
        registro.Item("cajas") = Me.cajas
        registro.Item("unidades") = Me.unidades
        registro.Item("valor") = Me.valor
        registro.Item("subtotal") = Me.subtotal
        tablaTemporal.Rows.Add(registro)
        tablaTemporal.AcceptChanges()
        Return tablaTemporal
    End Function
End Class
