Imports Microsoft.VisualBasic

Public Class clsExistenciaEmpresa

    Private _idExistenciaEmpresa As Integer
    Private _idEmpresa As Integer
    Private _idproducto As Integer
    Private _cantidadExistenciaEmpresa As Long
    Private _tipoProducto As String
    Dim objOperacione As New clsOperacione

    Public Property idExistenciaEmpresa As Integer
        Get
            Return _idExistenciaEmpresa
        End Get
        Set(ByVal value As Integer)
            _idExistenciaEmpresa = value
        End Set
    End Property

    Public Property idEmpresa As Integer
        Get
            Return _idEmpresa
        End Get
        Set(ByVal value As Integer)
            _idEmpresa = value
        End Set
    End Property

    Public Property idproducto As Integer
        Get
            Return _idproducto
        End Get
        Set(ByVal value As Integer)
            _idproducto = value
        End Set
    End Property

    Public Property cantidadExistenciaEmpresa As Long
        Get
            Return _cantidadExistenciaEmpresa
        End Get
        Set(ByVal value As Long)
            _cantidadExistenciaEmpresa = value
        End Set
    End Property

    Public Property tipoProducto As String
        Get
            Return _tipoProducto
        End Get
        Set(ByVal value As String)
            _tipoProducto = value
        End Set
    End Property

    Sub actualizaExistenciaEmpresa(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaExistenciaEmpresa " & _
        "@idExistenciaEmpresa='" & Me.idExistenciaEmpresa & "'," & _
        "@idEmpresa='" & Me.idEmpresa & "'," & _
        "@idproducto='" & Me.idproducto & "'," & _
        "@cantidadExistenciaEmpresa='" & Me.cantidadExistenciaEmpresa & "'," & _
        "@tipoProducto='" & Me.tipoProducto & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

End Class
