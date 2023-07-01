Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsPaquetePremioObs

    Private _idPaqPremioObs As Integer
    Private _idPremio As Integer
    Private _idObsequio As Integer
    Private _cantPaqPremioObs As Integer
    Private _accionDetallePremioObs As Integer
    Private _idPais As Integer
    Dim objOperacione As New clsOperacione

    Public Property idPaqPremioObs As Integer
        Get
            Return _idPaqPremioObs
        End Get
        Set(ByVal value As Integer)
            _idPaqPremioObs = value
        End Set
    End Property

    Public Property idPais As Integer
        Get
            Return _idPais
        End Get
        Set(ByVal value As Integer)
            _idPais = value
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

    Public Property idObsequio As Integer
        Get
            Return _idObsequio
        End Get
        Set(ByVal value As Integer)
            _idObsequio = value
        End Set
    End Property

    Public Property cantPaqPremioObs As Integer
        Get
            Return _cantPaqPremioObs
        End Get
        Set(ByVal value As Integer)
            _cantPaqPremioObs = value
        End Set
    End Property

    Public Property accionDetallePremioObs As Integer
        Get
            Return _accionDetallePremioObs
        End Get
        Set(ByVal value As Integer)
            _accionDetallePremioObs = value
        End Set
    End Property

    Sub grabarPaquetePremioObs(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaPaquetePremioObs " & _
        "@idPaqPremioObs='" & Me.idPaqPremioObs & "'," & _
        "@idPremio='" & Me.idPremio & "'," & _
        "@cantPaqPremioObs='" & Me.cantPaqPremioObs & "'," & _
        "@idObsequio='" & Me.idObsequio & "'," & _
        "@accion='" & accion & "'," & _
        "@accionDetallePremioObs='" & Me.accionDetallePremioObs & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerPremioPorIdObs() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TBPaqPremioObs where idObsequio=" & Me.idObsequio & " order by idPremio"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
