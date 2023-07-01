Imports Microsoft.VisualBasic

Public Class clsTTCajaDesProductoPais

    Private _idCajaDesProductoPais As Integer
    Private _conseCajaDesProductoPais As Integer
    Private _idEncDesProductoPais As Integer
    Private _idProducto As Integer
    Private _cantCajaDesProductoPais As Integer
    Private _cantRecCajaDesProductoPais As Integer
    Private _cantFalCajaDesProductoPais As Integer
    Private _cantMalCajaDesProductoPais As Integer
    Private _altaCajaDesProductoPais As String
    Private _fecrCajaDesProductoPais As Date
    Dim objOperacione As New clsOperacione

    Public Property idCajaDesProductoPais As Integer
        Get
            Return _idCajaDesProductoPais
        End Get
        Set(ByVal value As Integer)
            _idCajaDesProductoPais = value
        End Set
    End Property

    Public Property conseCajaDesProductoPais As Integer
        Get
            Return _conseCajaDesProductoPais
        End Get
        Set(ByVal value As Integer)
            _conseCajaDesProductoPais = value
        End Set
    End Property

    Public Property idEncDesProductoPais As Integer
        Get
            Return _idEncDesProductoPais
        End Get
        Set(ByVal value As Integer)
            _idEncDesProductoPais = value
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

    Public Property cantCajaDesProductoPais As Integer
        Get
            Return _cantCajaDesProductoPais
        End Get
        Set(ByVal value As Integer)
            _cantCajaDesProductoPais = value
        End Set
    End Property

    Public Property cantRecCajaDesProductoPais As Integer
        Get
            Return _cantRecCajaDesProductoPais
        End Get
        Set(ByVal value As Integer)
            _cantRecCajaDesProductoPais = value
        End Set
    End Property

    Public Property cantFalCajaDesProductoPais As Integer
        Get
            Return _cantFalCajaDesProductoPais
        End Get
        Set(ByVal value As Integer)
            _cantFalCajaDesProductoPais = value
        End Set
    End Property

    Public Property cantMalCajaDesProductoPais As Integer
        Get
            Return _cantMalCajaDesProductoPais
        End Get
        Set(ByVal value As Integer)
            _cantMalCajaDesProductoPais = value
        End Set
    End Property

    Public Property altaCajaDesProductoPais As String
        Get
            Return _altaCajaDesProductoPais
        End Get
        Set(ByVal value As String)
            _altaCajaDesProductoPais = value
        End Set
    End Property

    Public Property fecrCajaDesProductoPais As Date
        Get
            Return _fecrCajaDesProductoPais
        End Get
        Set(ByVal value As Date)
            _fecrCajaDesProductoPais = value
        End Set
    End Property

    Sub grabarTTCajaDesProductoPais()
        Dim sql As String
        sql = "exec sp_actualizaTTCajaDesProductoPais " & _
        "@idCajaDesProductoPais='" & Me.idCajaDesProductoPais & "'," & _
        "@conseCajaDesProductoPais='" & Me.conseCajaDesProductoPais & "'," & _
        "@idEncDesProductoPais='" & Me.idEncDesProductoPais & "'," & _
        "@idProducto='" & Me.idProducto & "'," & _
        "@cantCajaDesProductoPais='" & Me.cantCajaDesProductoPais & "'," & _
        "@cantRecCajaDesProductoPais='" & Me.cantRecCajaDesProductoPais & "'," & _
        "@cantFalCajaDesProductoPais='" & Me.cantFalCajaDesProductoPais & "'," & _
        "@cantMalCajaDesProductoPais='" & Me.cantMalCajaDesProductoPais & "'," & _
        "@altaCajaDesProductoPais='" & Me.altaCajaDesProductoPais & "'," & _
        "@fecrCajaDesProductoPais='" & Me.fecrCajaDesProductoPais.ToString("yyyyMMdd") & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub
End Class
