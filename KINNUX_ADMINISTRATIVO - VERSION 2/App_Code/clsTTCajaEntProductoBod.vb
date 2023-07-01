Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTTCajaEntProductoBod

    Private _idCajaEntProductoBod As Integer
    Private _conseCajaEntProductoBod As Integer
    Private _idEncEntProductoBod As Integer
    Private _idProducto As Integer
    Private _cantCajaEntProductoBod As Integer
    Private _cantRecCajaEntProductoBod As Integer
    Private _cantFalCajaEntProductoBod As Integer
    Private _cantMalCajaEntProductoBod As Integer
    Private _altaCajaEntProductoBod As String
    Private _fecRCajaEntProductoBod As Date
    Dim objOperacione As New clsOperacione

    Public Property idCajaEntProductoBod As Integer
        Get
            Return _idCajaEntProductoBod
        End Get
        Set(ByVal value As Integer)
            _idCajaEntProductoBod = value
        End Set
    End Property

    Public Property conseCajaEntProductoBod As Integer
        Get
            Return _conseCajaEntProductoBod
        End Get
        Set(ByVal value As Integer)
            _conseCajaEntProductoBod = value
        End Set
    End Property

    Public Property idEncEntProductoBod As Integer
        Get
            Return _idEncEntProductoBod
        End Get
        Set(ByVal value As Integer)
            _idEncEntProductoBod = value
        End Set
    End Property

    Public Property idProducto As Integer
        Get
            Return _idProducto
        End Get
        Set(ByVal value As Integer)
            _idProducto = value
        End Set
    End Property

    Public Property cantCajaEntProductoBod As Integer
        Get
            Return _cantCajaEntProductoBod
        End Get
        Set(ByVal value As Integer)
            _cantCajaEntProductoBod = value
        End Set
    End Property


    Public Property cantRecCajaEntProductoBod As Integer
        Get
            Return _cantRecCajaEntProductoBod
        End Get
        Set(ByVal value As Integer)
            _cantRecCajaEntProductoBod = value
        End Set
    End Property

    Public Property cantFalCajaEntProductoBod As Integer
        Get
            Return _cantFalCajaEntProductoBod
        End Get
        Set(ByVal value As Integer)
            _cantFalCajaEntProductoBod = value
        End Set
    End Property

    Public Property cantMalCajaEntProductoBod As Integer
        Get
            Return _cantMalCajaEntProductoBod
        End Get
        Set(ByVal value As Integer)
            _cantMalCajaEntProductoBod = value
        End Set
    End Property

    Public Property altaCajaEntProductoBod As String
        Get
            Return _altaCajaEntProductoBod
        End Get
        Set(ByVal value As String)
            _altaCajaEntProductoBod = value
        End Set
    End Property

    Public Property fecRCajaEntProductoBod As Date
        Get
            Return _fecRCajaEntProductoBod
        End Get
        Set(ByVal value As Date)
            _fecRCajaEntProductoBod = value
        End Set
    End Property

    Sub grabarTTCajaEntProductoBod()
        Dim sql As String
        sql = "exec sp_actualizaTTCajaEntProductoBod " & _
        "@idCajaEntProductoBod='" & Me.idCajaEntProductoBod & "'," & _
        "@conseCajaEntProductoBod='" & Me.conseCajaEntProductoBod & "'," & _
        "@idEncEntProductoBod='" & Me.idEncEntProductoBod & "'," & _
        "@idProducto='" & Me.idProducto & "'," & _
        "@cantCajaEntProductoBod='" & Me.cantCajaEntProductoBod & "'," & _
        "@cantRecCajaEntProductoBod='" & Me.cantRecCajaEntProductoBod & "'," & _
        "@cantFalCajaEntProductoBod='" & Me.cantFalCajaEntProductoBod & "'," & _
        "@cantMalCajaEntProductoBod='" & Me.cantMalCajaEntProductoBod & "'," & _
        "@altaCajaEntProductoBod='" & Me.altaCajaEntProductoBod & "'," & _
        "@fecRCajaEntProductoBod='" & Me.fecRCajaEntProductoBod.ToString("yyyyMMdd") & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerDetalleCajaEntProductoBod() As datatable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT " & _
        "TTCajaEntProductoBod.idCajaEntProductoBod," & _
        "TBProducto.idProducto, " & _
        "TBProducto.nombreProducto," & _
        "TTCajaEntProductoBod.conseCajaEntProductoBod," & _
        "TTCajaEntProductoBod.cantCajaEntProductoBod," & _
        "TTCajaEntProductoBod.cantRecCajaEntProductoBod," & _
        "TTCajaEntProductoBod.cantFalCajaEntProductoBod," & _
        "TTCajaEntProductoBod.cantMalCajaEntProductoBod," & _
        "TTCajaEntProductoBod.altaCajaEntProductoBod," & _
        "TTCajaEntProductoBod.fecRCajaEntProductoBod" & _
        " FROM" & _
        " TTCajaEntProductoBod INNER JOIN" & _
        " TBProducto ON TTCajaEntProductoBod.idProducto = TBProducto.idProducto" & _
        " where TTCajaEntProductoBod.idEncEntProductoBod=" & Me.idEncEntProductoBod & " and TTCajaEntProductoBod.altaCajaEntProductoBod='No' order by TBProducto.idProducto,TTCajaEntProductoBod.conseCajaEntProductoBod"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerdetalleCajaPorIdCaja() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT * from TTCajaEntProductoBod where idCajaEntProductoBod=" & Me.idCajaEntProductoBod
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Sub confirmaEntrada()
        Dim sql As String
        sql = "exec sp_ConfirmaEntradaTTCajaEntProductoBod " & _
        "@idCajaEntProductoBod='" & Me.idCajaEntProductoBod & "'," & _
        "@recibidas='" & Me.cantRecCajaEntProductoBod & "'," & _
        "@faltantes='" & Me.cantFalCajaEntProductoBod & "'," & _
        "@malEstado='" & Me.cantMalCajaEntProductoBod & "'," & _
        "@alta='" & Me.altaCajaEntProductoBod & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerdetalleCajaPorIdEncabezado() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TTCajaEntProductoBod where idEncEntProductoBod=" & Me.idEncEntProductoBod
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
