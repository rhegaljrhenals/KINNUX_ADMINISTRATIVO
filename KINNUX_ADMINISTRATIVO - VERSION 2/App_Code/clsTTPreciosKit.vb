Imports Microsoft.VisualBasic

Public Class clsTTPreciosKit

    Private _precioPais As Double
    Private _precioLocal As Double
    Private _idPais As Integer
    Dim objOperacione As New clsOperacione

    Public Property precioPais As Double
        Get
            Return _precioPais
        End Get
        Set(ByVal value As Double)
            _precioPais = value
        End Set
    End Property

    Public Property precioLocal As Double
        Get
            Return _precioLocal
        End Get
        Set(ByVal value As Double)
            _precioLocal = value
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

    Sub grabarTTPreciosKit(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaTTPreciosKit " & _
        "@precioPais='" & Me.precioPais & "'," & _
        "@precioLocal='" & Me.precioLocal & "'," & _
        "@idPais='" & Me.idPais & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub


End Class
