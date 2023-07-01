Imports Microsoft.VisualBasic
Imports System.Data

Public Class clsTTBox

    Private _idBox As Integer
    Private _fechaIBox As Date
    Private _fechaFBox As Date
    Private _idPais As Integer
    Private _idSucursal As Integer
    Private _idEvento As Integer
    Private _nombreBox As String
    Private _valorMlBox As Double
    Private _valorUsdBox As Double
    Private _baseBox As Integer
    Private _tokenBox As Integer
    Private _promoBox As Integer
    Private _obsBox As Integer
    Private _puntosBox As Double
    Private _numCiclosBox As Integer
    Private _tipoBox As String
    Private _inicioBox As String
    Private _referenciaBox As String
    Private _upgradeBox As String
    Private _inicioExpBox As String
    Private _paqueteBox As String
    Private _estadoBox As Integer
    Private _activamillasbox As String
    Private _periodoacivosbox As Integer
    Private _recompraBox As String
    Private _acumulaMillasBox As String
    Private _paqueteControlado As String
    Private _inicioPaqBox As String
    Dim operaciones As New clsOperacione

    Public Property tokenBox As Integer
        Get
            Return _tokenBox
        End Get
        Set(value As Integer)
            _tokenBox = value
        End Set
    End Property

    Public Property inicioPaqBox As String
        Get
            Return _inicioPaqBox
        End Get
        Set(value As String)
            _inicioPaqBox = value
        End Set
    End Property



    Public Property paqueteControlado As String
        Get
            Return _paqueteControlado
        End Get
        Set(value As String)
            _paqueteControlado = value
        End Set
    End Property

    Public Property acumulaMillasBox As String
        Get
            Return _acumulaMillasBox
        End Get
        Set(value As String)
            _acumulaMillasBox = value
        End Set
    End Property

    Public Property recompraBox As String
        Get
            Return _recompraBox
        End Get
        Set(value As String)
            _recompraBox = value
        End Set
    End Property

    Public Property activamillasbox As String
        Get
            Return _activamillasbox
        End Get
        Set(value As String)
            _activamillasbox = value
        End Set
    End Property

    Public Property periodoacivosbox As Integer
        Get
            Return _periodoacivosbox
        End Get
        Set(value As Integer)
            _periodoacivosbox = value
        End Set
    End Property

    Public Property fechaIBox As Date
        Get
            Return _fechaIBox
        End Get
        Set(value As Date)
            _fechaIBox = value
        End Set
    End Property

    Public Property fechaFBox As Date
        Get
            Return _fechaFBox
        End Get
        Set(value As Date)
            _fechaFBox = value
        End Set
    End Property

    Public Property idPais As Integer
        Get
            Return _idPais
        End Get
        Set(value As Integer)
            _idPais = value
        End Set
    End Property

    Public Property idSucursal As Integer
        Get
            Return _idSucursal
        End Get
        Set(value As Integer)
            _idSucursal = value
        End Set
    End Property

    Public Property idEvento As Integer
        Get
            Return _idEvento
        End Get
        Set(value As Integer)
            _idEvento = value
        End Set
    End Property

    Public Property nombreBox As String
        Get
            Return _nombreBox
        End Get
        Set(value As String)
            _nombreBox = value
        End Set
    End Property

    Public Property valorMlBox As Double
        Get
            Return _valorMlBox
        End Get
        Set(value As Double)
            _valorMlBox = value
        End Set
    End Property

    Public Property valorUsdBox As Double
        Get
            Return _valorUsdBox
        End Get
        Set(value As Double)
            _valorUsdBox = value
        End Set
    End Property

    Public Property baseBox As Integer
        Get
            Return _baseBox
        End Get
        Set(value As Integer)
            _baseBox = value
        End Set
    End Property

    Public Property promoBox As Integer
        Get
            Return _promoBox
        End Get
        Set(value As Integer)
            _promoBox = value
        End Set
    End Property

    Public Property obsBox As Integer
        Get
            Return _obsBox
        End Get
        Set(value As Integer)
            _obsBox = value
        End Set
    End Property

    Public Property puntosBox As Double
        Get
            Return _puntosBox
        End Get
        Set(value As Double)
            _puntosBox = value
        End Set
    End Property

    Public Property numCiclosBox As Integer
        Get
            Return _numCiclosBox
        End Get
        Set(value As Integer)
            _numCiclosBox = value
        End Set
    End Property

    Public Property tipoBox As String
        Get
            Return _tipoBox
        End Get
        Set(value As String)
            _tipoBox = value
        End Set
    End Property

    Public Property inicioBox As String
        Get
            Return _inicioBox
        End Get
        Set(value As String)
            _inicioBox = value
        End Set
    End Property

    Public Property referenciaBox As String
        Get
            Return _referenciaBox
        End Get
        Set(value As String)
            _referenciaBox = value
        End Set
    End Property

    Public Property upgradeBox As String
        Get
            Return _upgradeBox
        End Get
        Set(value As String)
            _upgradeBox = value
        End Set
    End Property

    Public Property inicioExpBox As String
        Get
            Return _inicioExpBox
        End Get
        Set(value As String)
            _inicioExpBox = value
        End Set
    End Property


    Public Property paqueteBox As String
        Get
            Return _paqueteBox
        End Get
        Set(value As String)
            _paqueteBox = value
        End Set
    End Property

    Public Property estadoBox As Integer
        Get
            Return _estadoBox
        End Get
        Set(value As Integer)
            _estadoBox = value
        End Set
    End Property

    Public Property idBox As Integer
        Get
            Return _idBox
        End Get
        Set(value As Integer)
            _idBox = value
        End Set
    End Property

    Function grabar(ByVal accion As Integer) As Integer
        Dim idBox As Integer = 0
        Dim tabla As New DataTable
        Dim sql As String
        sql = "exec sp_TTbox " & _
        "@idBox='" & Me.idBox & "'," & _
        "@fechaibox='" & Me.fechaIBox.ToString("yyyyMMdd") & "'," & _
        "@fechafbox='" & Me.fechaFBox.ToString("yyyyMMdd") & "'," & _
        "@idpais='" & Me.idPais & "'," & _
        "@idsucursal='" & Me.idSucursal & "'," & _
        "@idevento='" & Me.idEvento & "'," & _
        "@nombrebox='" & Me.nombreBox & "'," & _
        "@valormlbox='" & Me.valorMlBox & "'," & _
        "@valorusdbox='" & Me.valorUsdBox & "'," & _
        "@basebox='" & Me.baseBox & "'," & _
        "@promobox='" & Me.promoBox & "'," & _
        "@obsqbox='" & Me.obsBox & "'," & _
        "@puntosbox='" & Me.puntosBox & "'," & _
        "@numciclosbox='" & Me.numCiclosBox & "'," & _
        "@tipobox='" & Me.tipoBox & "'," & _
        "@iniciobox='" & Me.inicioBox & "'," & _
        "@referenciabox='" & Me.referenciaBox & "'," & _
        "@upgdradebox='" & Me.upgradeBox & "'," & _
        "@inicioexpbox='" & Me.inicioExpBox & "'," & _
        "@paquetebox='" & Me.paqueteBox & "'," & _
        "@estadobox='" & Me.estadoBox & "'," & _
        "@activamillasbox='" & Me.activamillasbox & "'," & _
        "@periodoacivosbox='" & Me.periodoacivosbox & "'," & _
        "@recompraBox='" & Me.recompraBox & "'," & _
        "@acumulaMillasBox='" & Me.acumulaMillasBox & "'," & _
        "@paqueteControlado='" & Me.paqueteControlado & "'," & _
        "@inicioPaqBox='" & Me.inicioPaqBox & "'," & _
        "@tokenBox='" & Me.tokenBox & "'," & _
        "@accion='" & accion & "'"
        With operaciones
            tabla = .DevuelveDato(sql)
            idBox = tabla.Rows(0).Item("ultimo")
        End With
        Return idBox
    End Function

    Function obtenerBox() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from vw_ttBox"
        
        With operaciones
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerBoxPorId(ByVal idempresa As Integer, ByVal opcion As Integer) As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from vw_ttBox where estadobox=1"
        If idempresa = 0 Then
            sql = sql
        Else
            sql = sql & " and idempresa=" & idempresa
        End If
        '
        Select Case opcion
            Case Is = 1
                sql = sql & " and paquetebox='pa'"
            Case Is = 2
                sql = sql & " and paquetebox='pr'"
            Case Is = 3
                sql = sql
        End Select
        '
        With operaciones
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerProductosDeLaPromocion() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TBproductobox where idbox=" & Me.idBox
        With operaciones
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function






End Class
