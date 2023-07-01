Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsPaqueteEquipomObs
    Private _idPaqEquipomObs As Integer
    Private _idEquipom As Integer
    Private _idObsequio As Integer
    Private _cantPaqEquipomObs As Integer
    Private _accionDetalleEquipomObs As Integer
    Private _idPais As Integer
    Dim objOperacione As New clsOperacione

    Public Property idPaqEquipomObs As Integer
        Get
            Return _idPaqEquipomObs
        End Get
        Set(ByVal value As Integer)
            _idPaqEquipomObs = value
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

    Public Property idEquipom As Integer
        Get
            Return _idEquipom
        End Get
        Set(ByVal value As Integer)
            _idEquipom = value
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

    Public Property cantPaqEquipomObs As Integer
        Get
            Return _cantPaqEquipomObs
        End Get
        Set(ByVal value As Integer)
            _cantPaqEquipomObs = value
        End Set
    End Property

    Public Property accionDetalleEquipomObs As Integer
        Get
            Return _accionDetalleEquipomObs
        End Get
        Set(ByVal value As Integer)
            _accionDetalleEquipomObs = value
        End Set
    End Property

    Sub grabarPaqueteEquipomObs(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaPaqueteEquipomObs " & _
        "@idPaqEquipomObs='" & Me.idPaqEquipomObs & "'," & _
        "@idEquipom='" & Me.idEquipom & "'," & _
        "@cantPaqEquipomObs='" & Me.cantPaqEquipomObs & "'," & _
        "@idObsequio='" & Me.idObsequio & "'," & _
        "@accion='" & accion & "'," & _
        "@accionDetalleEquipomObs='" & Me.accionDetalleEquipomObs & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerEquipomPorIdObs() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TBPaqEquipomObs where idObsequio=" & Me.idObsequio & " order by idEquipom"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
