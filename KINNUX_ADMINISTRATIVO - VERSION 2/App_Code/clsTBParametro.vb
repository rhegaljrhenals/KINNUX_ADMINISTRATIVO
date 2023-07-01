Imports Microsoft.VisualBasic

Public Class clsTBParametro

    Private _pagoKitParametro As Integer
    Private _pagoEliteParametro As Double
    Private _irNivel1 As Integer
    Private _irNivel2 As Integer
    Private _irNivel3 As Integer
    Private _irNivel4 As Integer
    Private _irNivel5 As Integer
    Private _irNivel6 As Integer

    Public Property pagoKitParametro As Integer
        Get
            Return _pagoKitParametro
        End Get
        Set(ByVal value As Integer)
            _pagoKitParametro = value
        End Set
    End Property

    
    Public Property pagoEliteParametro As Double
        Get
            Return _pagoEliteParametro
        End Get
        Set(ByVal value As Double)
            _pagoEliteParametro = value
        End Set
    End Property

    Public Property irNivel1 As Integer
        Get
            Return _irNivel1
        End Get
        Set(ByVal value As Integer)
            _irNivel1 = value
        End Set
    End Property

    Public Property irNivel2 As Integer
        Get
            Return _irNivel2
        End Get
        Set(ByVal value As Integer)
            _irNivel2 = value
        End Set
    End Property

    Public Property irNivel3 As Integer
        Get
            Return _irNivel3
        End Get
        Set(ByVal value As Integer)
            _irNivel3 = value
        End Set
    End Property

    Public Property irNivel4 As Integer
        Get
            Return _irNivel4
        End Get
        Set(ByVal value As Integer)
            _irNivel4 = value
        End Set
    End Property

    Public Property irNivel5 As Integer
        Get
            Return _irNivel5
        End Get
        Set(ByVal value As Integer)
            _irNivel5 = value
        End Set
    End Property

    Public Property irNivel6 As Integer
        Get
            Return _irNivel6
        End Get
        Set(ByVal value As Integer)
            _irNivel6 = value
        End Set
    End Property
End Class
