Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTTDetComisionMesIR

    Private _codigoAfiliado As String
    Private _codigoAfiliadoCompra As String
    Private _nivelDetComisionMesIr As Integer
    Private _porcDetComisionMesIr As Integer
    Private _puntosDetComisionMesIr As Integer
    Private _valorDetComisionMesIr As Double
    Private _mesDetComisionMesIr As Double
    Private _anoDetComisionMesIr As Double
    Dim objOperacione As New clsOperacione

    Public Property codigoAfiliado As String
        Get
            Return _codigoAfiliado
        End Get
        Set(ByVal value As String)
            _codigoAfiliado = value
        End Set
    End Property

    Public Property codigoAfiliadoCompra As String
        Get
            Return _codigoAfiliadoCompra
        End Get
        Set(ByVal value As String)
            _codigoAfiliadoCompra = value
        End Set
    End Property

    Public Property nivelDetComisionMesIr As Integer
        Get
            Return _nivelDetComisionMesIr
        End Get
        Set(ByVal value As Integer)
            _nivelDetComisionMesIr = value
        End Set
    End Property

    Public Property porcDetComisionMesIr As Integer
        Get
            Return _porcDetComisionMesIr
        End Get
        Set(ByVal value As Integer)
            _porcDetComisionMesIr = value
        End Set
    End Property

    Public Property puntosDetComisionMesIr As Integer
        Get
            Return _puntosDetComisionMesIr
        End Get
        Set(ByVal value As Integer)
            _puntosDetComisionMesIr = value
        End Set
    End Property

    Public Property valorDetComisionMesIr As Double
        Get
            Return _valorDetComisionMesIr
        End Get
        Set(ByVal value As Double)
            _valorDetComisionMesIr = value
        End Set
    End Property

    Public Property mesDetComisionMesIr As Double
        Get
            Return _mesDetComisionMesIr
        End Get
        Set(ByVal value As Double)
            _mesDetComisionMesIr = value
        End Set
    End Property

    Public Property anoDetComisionMesIr As Double
        Get
            Return _anoDetComisionMesIr
        End Get
        Set(ByVal value As Double)
            _anoDetComisionMesIr = value
        End Set
    End Property

    ' funcion para obtener el detalle de las comisiones ir por codigoafiliado
    Function obtenerDetalleComisionesIRporAfiliado() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TTdet_comisionmesir.codigoafiliado, " & _
        "TTdet_comisionmesir.codigoafiliadocom, " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres," & _
        "TTdet_comisionmesir.niveldetcomisionmesir," & _
        "TTdet_comisionmesir.porcdetcomisionmesir," & _
        "TTdet_comisionmesir.puntosdetcomisionmesir," & _
        "TTdet_comisionmesir.valordetcomisionmesir" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " TTdet_comisionmesir ON dbo.Afiliaciones.codigoAfiliado = TTdet_comisionmesir.codigoafiliadocom" & _
        " where TTdet_comisionmesir.codigoafiliado='" & Me.codigoAfiliado & "'" & _
        " order by TTdet_comisionmesir.niveldetcomisionmesir"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
