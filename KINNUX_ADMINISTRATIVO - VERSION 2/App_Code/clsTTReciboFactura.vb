Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTTReciboFactura

    Private _idRecibo As Integer
    Private _idEncFacturaPro As Integer
    Private _codigoAfiliado As String
    Dim objOperacione As New clsOperacione

    Public Property idRecibo As Integer
        Get
            Return _idRecibo
        End Get
        Set(ByVal value As Integer)
            _idRecibo = value
        End Set
    End Property

    Public Property idEncFacturaPro As Integer
        Get
            Return _idEncFacturaPro
        End Get
        Set(ByVal value As Integer)
            _idEncFacturaPro = value
        End Set
    End Property

    Public Property codigoAfiliado As String
        Get
            Return _codigoAfiliado
        End Get
        Set(ByVal value As String)
            _codigoAfiliado = value
        End Set
    End Property

    Sub grabarTTReciboFactura()
        Dim sql As String
        sql = "exec sp_actualizaTTReciboFactura " & _
        "@idRecibo='" & Me.idRecibo & "'," & _
        "@codigoAfiliado='" & Me.codigoAfiliado & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    ' funcion para obtener los abonos por el numero de la remision
    Function obtenerAbonosPorNumeroRemision() As datatable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from ttRecibofactura where idEncFacturaPro=" & Me.idEncFacturaPro
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener los abonos por el numero de la remision
    Function obtenerAbonosPorNumeroRemisionProcesoAnular() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TTRecibo.idRecibo," & _
        "TTRecibo.numeroRecibo," & _
        "TTRecibo.valorRecibo" & _
        " FROM" & _
        " TTReciboFactura INNER JOIN" & _
        " TTRecibo ON TTReciboFactura.idRecibo = TTRecibo.idRecibo" & _
        " where TTReciboFactura.idencfacturapro=" & Me.idEncFacturaPro
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Sub eliminaRecibofactura()
        Dim sql As String
        sql = "exec sp_actualizaTTreciboFacturaEliminaRecibo " & _
        "@idEncFacturaPro='" & Me.idEncFacturaPro & "'"
        With objOperacione
            .Accion(sql)
        End With

    End Sub
End Class
