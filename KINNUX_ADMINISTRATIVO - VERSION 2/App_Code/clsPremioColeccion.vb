Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsPremioColeccion

    Private _idPremioColeccion As Integer
    Private _idPremio As Integer
    Private _idColeccion As Integer
    Private _prontoPago As Integer
    Private _idPais As Integer
    Private _numeroCuota As Integer
    Dim objOperacione As New clsOperacione

    Public Property idPremioColeccion As Integer
        Get
            Return _idPremioColeccion
        End Get
        Set(ByVal value As Integer)
            _idPremioColeccion = value
        End Set
    End Property

    Public Property idPremio As Integer
        Get
            Return _idPremio
        End Get
        Set(ByVal value As Integer)
            _idPremio = value
        End Set
    End Property

    Public Property idColeccion As Integer
        Get
            Return _idColeccion
        End Get
        Set(ByVal value As Integer)
            _idColeccion = value
        End Set
    End Property

    Public Property prontoPago As Integer
        Get
            Return _prontoPago
        End Get
        Set(ByVal value As Integer)
            _prontoPago = value
        End Set
    End Property

    Public Property idpais As Integer
        Get
            Return _idPais
        End Get
        Set(ByVal value As Integer)
            _idPais = value
        End Set
    End Property

    Public Property numeroCuota As Integer
        Get
            Return _numeroCuota
        End Get
        Set(ByVal value As Integer)
            _numeroCuota = value
        End Set
    End Property

    Sub grabarPremioColeccion(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaPremioColeccion " & _
        "@idPremioColeccion='" & Me.idPremioColeccion & "'," & _
        "@idPremio='" & Me.idPremio & "'," & _
        "@idColeccion='" & Me.idColeccion & "'," & _
        "@prontoPago='" & Me.prontoPago & "'," & _
        "@idPais='" & Me.idpais & "'," & _
        "@numeroCuota='" & Me.numeroCuota & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerPremiosPorId() As DataTable
        Dim sql As String
        sql = "SELECT * " & _
          "from TBPremioColeccion where idColeccion=" & Me.idColeccion & " and numeroCuota=" & Me.numeroCuota
        Dim tablaPremio As New DataTable
        With objOperacione
            tablaPremio = .DevuelveDato(sql)
        End With
        Return tablaPremio

    End Function


End Class
