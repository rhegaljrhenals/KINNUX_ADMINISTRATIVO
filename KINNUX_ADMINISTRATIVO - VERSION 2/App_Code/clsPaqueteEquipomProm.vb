Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsPaqueteEquipomProm

    Private _idPaqEquipomProm As Integer
    Private _idEquipom As Integer
    Private _idPromocion As Integer
    Private _cantPaqEquipomProm As Integer
    Private _accionDetalleEquipomProm As Integer
    Private _idPais As Integer
    Dim objOperacione As New clsOperacione

    Public Property idPaqEquipomProm As Integer
        Get
            Return _idPaqEquipomProm
        End Get
        Set(ByVal value As Integer)
            _idPaqEquipomProm = value
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

    Public Property idPromocion As Integer
        Get
            Return _idPromocion
        End Get
        Set(ByVal value As Integer)
            _idPromocion = value
        End Set
    End Property

    Public Property cantPaqEquipomProm As Integer
        Get
            Return _cantPaqEquipomProm
        End Get
        Set(ByVal value As Integer)
            _cantPaqEquipomProm = value
        End Set
    End Property

    Public Property accionDetalleEquipomProm As Integer
        Get
            Return _accionDetalleEquipomProm
        End Get
        Set(ByVal value As Integer)
            _accionDetalleEquipomProm = value
        End Set
    End Property

    Sub grabarPaqueteEquipomProm(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaPaqueteEquipoMPromocion " & _
        "@idPaqEquipomProm='" & Me.idPaqEquipomProm & "'," & _
        "@idEquipom='" & Me.idEquipom & "'," & _
        "@cantPaqEquipomProm='" & Me.cantPaqEquipomProm & "'," & _
        "@idPromocion='" & Me.idPromocion & "'," & _
        "@accion='" & accion & "'," & _
        "@accionDetalleEquipomProm='" & Me.accionDetalleEquipomProm & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerEquipomPorIdPromocion() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TBPaqEquipomProm where idPromocion=" & Me.idPromocion & " order by idEquipoM"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
