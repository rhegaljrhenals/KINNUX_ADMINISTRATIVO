Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsObsequio

    Private _idObsequioPais As Integer
    Private _idObsequio As Integer
    Private _idPaquete As Integer
    Private _nombreObsequio As String
    Private _idPais As Integer
    Dim objOperacione As New clsOperacione

    Public Property nombreObsequio As String
        Get
            Return _nombreObsequio
        End Get
        Set(ByVal value As String)
            _nombreObsequio = value
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

    Public Property idObsequioPais As Integer
        Get
            Return _idObsequioPais
        End Get
        Set(ByVal value As Integer)
            _idObsequioPais = value
        End Set
    End Property

    Public Property idPaquete As Integer
        Get
            Return _idPaquete
        End Get
        Set(ByVal value As Integer)
            _idPaquete = value
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

    Sub grabarObsequio(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaObsequuio " & _
        "@idObsequio='" & Me.idObsequio & "'," & _
        "@idPaquete='" & Me.idPaquete & "'," & _
        "@nombreObsequio='" & Me.nombreObsequio & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Sub grabarObsequiopais(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaObsequioPais " & _
        "@idObsequioPais='" & Me.idObsequioPais & "'," & _
        "@idObsequio='" & Me.idObsequio & "'," & _
        "@idPais='" & Me.idPais & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerObsequio() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "TBObsequio.idObsequio," & _
        "TBObsequio.nombreObsequio," & _
        "TBPaquete.idPaquete," & _
        "TBPaquete.nombrePaquete," & _
        "dbo.TBpais.codigoPais," & _
        "dbo.TBpais.nombrePais" & _
        " FROM" & _
        " TBObsequio INNER JOIN" & _
        " TBPaquete ON TBObsequio.idPaquete = TBPaquete.idPaquete INNER JOIN" & _
        " TBObsequioPais ON TBObsequio.idObsequio = TBObsequioPais.idObsequio INNER JOIN" & _
        " dbo.TBpais ON TBObsequioPais.idPais = dbo.TBpais.codigoPais"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
