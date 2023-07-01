Imports Microsoft.VisualBasic
Imports System.Data

Public Class clsfacturaTarjeta

    Private _idFacturaTarjeta As Integer
    Private _codigoAfiliado As String
    Private _idTarjeta As Integer
    Private _idEncFacturapro As Integer
    Dim objOperacione As New clsOperacione

    Public Property idEncFacturapro As Integer
        Get
            Return _idEncFacturapro
        End Get
        Set(ByVal value As Integer)
            _idEncFacturapro = value
        End Set
    End Property

    Public Property idFacturaTarjeta As Integer
        Get
            Return _idFacturaTarjeta
        End Get
        Set(ByVal value As Integer)
            _idFacturaTarjeta = value
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

    Public Property idTarjeta As Integer
        Get
            Return _idTarjeta
        End Get
        Set(ByVal value As Integer)
            _idTarjeta = value
        End Set
    End Property

    Sub grabarfacturaTarjeta()
        Dim sql As String
        sql = "exec sp_actualizaTTFacturaTarjeta " & _
        "@idFacturaTarjeta='" & Me.idFacturaTarjeta & "'," & _
        "@codigoAfiliado='" & Me.codigoAfiliado & "'," & _
        "@idTarjeta='" & Me.idTarjeta & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    ' funcion para obtener las tarjetas de credito por id remision
    Function obtenerTarjetasPorRemision() As datatable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TTFacturaTarjeta.idTarjeta," & _
        "TTTarjetaCre.aprobacionTarjetaCre," & _
        "TTTarjetaCre.valorUsdTarjetaCre," & _
        "TTTarjetaCre.valorDolarTarjetaCre," & _
        "TTTarjetaCre.titularTarjetaCre," & _
        "TTFacturaTarjeta.idEncFacturaPro" & _
        " FROM" & _
        " TTFacturaTarjeta INNER JOIN" & _
        " TTTarjetaCre ON TTFacturaTarjeta.idTarjeta = TTTarjetaCre.idTarjetaCre" & _
        " where TTFacturaTarjeta.idEncFacturaPro=" & Me.idEncFacturapro
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' procedimiento para reversar el pago de las tarjetas
    Sub reversarPagoTarjetas()
        Dim sql As String
        sql = "exec sp_reversarPagoTarjetasDeCredito " & _
        "@idEncfacturaPro='" & Me.idEncFacturapro & "'," & _
        "@idTarjetaCre='" & Me.idTarjeta & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub
End Class
