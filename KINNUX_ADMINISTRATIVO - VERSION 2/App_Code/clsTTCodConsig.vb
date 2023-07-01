Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTTCodConsig

    Private _idCodConsig As Integer
    Private _idConsignacion As Integer
    Private _idCodigo As Integer
    Dim objOperacione As New clsOperacione

    Public Property idCodConsig As Integer
        Get
            Return _idCodConsig
        End Get
        Set(ByVal value As Integer)
            _idCodConsig = value
        End Set
    End Property

    Public Property idConsignacion As Integer
        Get
            Return _idConsignacion
        End Get
        Set(ByVal value As Integer)
            _idConsignacion = value
        End Set
    End Property

    Public Property idCodigo As Integer
        Get
            Return _idCodigo
        End Get
        Set(ByVal value As Integer)
            _idCodigo = value
        End Set
    End Property

    Sub grabarTTCodConsig()
        Dim sql As String
        sql = "exec sp_actualizaTTCodConsig " & _
        "@idCodConsig='" & Me.idCodConsig & "'," & _
        "@idConsignacion='" & Me.idConsignacion & "'," & _
        "@idCodigo='" & Me.idCodigo & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function validaConsignacionPorCodigoAfiliado() As datatable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TTCodConsig where idCodigo=" & Me.idCodigo & " and idConsignacion=" & Me.idConsignacion
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' procediemiento para eliminar la relacion de la consignacion con el codigo del afiliado
    Sub eliminaRelacionConsigancionCodigoAfiliado()
        Dim sql As String
        sql = "delete from TTCodConsig" & _
            " where idConsignacion=" & Me.idConsignacion
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    ' funcion para obtener los afiliados de una consignacion
    Function obtenerAfiliadosPorConsiganacion() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT " & _
        "TTCodConsig.idCodigo, " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " TTCodConsig ON dbo.Afiliaciones.codigoAfiliado = TTCodConsig.idCodigo" & _
        " where TTCodConsig.idConsignacion=" & Me.idConsignacion
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
