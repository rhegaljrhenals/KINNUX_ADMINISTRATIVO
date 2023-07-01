Imports Microsoft.VisualBasic
Imports System.Data

Public Class clsOpciones

    Private _idMenu As Integer
    Private _idTbSubMenu As Integer
    Private _idSubMenu As Integer
    Private _nombreMenu As String
    Private _tipoOpcion As Integer
    Private _idAplicacion As Integer
    Private _idOpcionPrincipal As Integer
    '
    Private _nombreSubMenu As String
    Private _ruta As String
    Private _tipoSubmenu As Integer

    Dim operaciones As New clsOperacione

    Public Property idTbSubMenu As Integer
        Get
            Return _idTbSubMenu
        End Get
        Set(value As Integer)
            _idTbSubMenu = value
        End Set
    End Property



    Public Property ruta As String
        Get
            Return _ruta
        End Get
        Set(value As String)
            _ruta = value
        End Set
    End Property

    Public Property nombreSubMenu As String
        Get
            Return _nombreSubMenu
        End Get
        Set(value As String)
            _nombreSubMenu = value
        End Set
    End Property

    Public Property tipoSubmenu As Integer
        Get
            Return _tipoSubmenu
        End Get
        Set(value As Integer)
            _tipoSubmenu = value
        End Set
    End Property



    Public Property idSubMenu As Integer
        Get
            Return _idSubMenu
        End Get
        Set(value As Integer)
            _idSubMenu = value
        End Set
    End Property

    Public Property idOpcionPrincipal As Integer
        Get
            Return _idOpcionPrincipal
        End Get
        Set(value As Integer)
            _idOpcionPrincipal = value
        End Set
    End Property

    Public Property idAplicacion As Integer
        Get
            Return _idAplicacion
        End Get
        Set(value As Integer)
            _idAplicacion = value
        End Set
    End Property

    Public Property tipoOpcion As Integer
        Get
            Return _tipoOpcion
        End Get
        Set(value As Integer)
            _tipoOpcion = value
        End Set
    End Property

    Public Property nombreMenu As String
        Get
            Return _nombreMenu
        End Get
        Set(value As String)
            _nombreMenu = value
        End Set
    End Property

    Public Property idMenu As Integer
        Get
            Return _idMenu
        End Get
        Set(value As Integer)
            _idMenu = value
        End Set
    End Property

    ' carga las opciones principales
    Function obtenerOpcionesPrincipales() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from tbmenu where tipoOpcion=" & Me.tipoOpcion
        With operaciones
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' mostrar opciones del submenu
    Function obtenerOpcionesSubmenu() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "dbo.TBSubmenu.idtbSubmenu,dbo.TBSubmenu.idSubmenu," & _
        "dbo.TBSubmenu.nombreSubmenu," & _
        "dbo.TBSubmenu.ruta," & _
        "dbo.TBSubmenu.tipoSubmenu," & _
        " case dbo.TBSubmenu.estado" & _
        " when 1 then 'Activo'" & _
        " when 0 then 'Eliminado'" & _
        " end estadoOpcion" & _
        " FROM" & _
        " dbo.TBMenu INNER JOIN" & _
        " dbo.TBSubmenu ON dbo.TBMenu.idMenu = dbo.TBSubmenu.idmenu" & _
        " where" & _
        " tbmenu.tipoopcion=" & Me.idAplicacion & " and" & _
        " dbo.tbmenu.idmenu=" & Me.idOpcionPrincipal & " and" & _
        " dbo.TBSubmenu.tipoSubmenu = " & Me.idAplicacion & _
        " order by dbo.TBSubmenu.idSubmenu"
        With operaciones
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Sub actualizaestadosOpciones(ByVal estado As Integer)
        Dim sql As String
        sql = "update tbsubmenu set estado=" & estado & _
            " where tiposubmenu=" & Me.idAplicacion & " and" & _
            " idmenu=" & Me.idMenu & " and" & _
            " idSubmenu=" & Me.idSubMenu
        With operaciones
            .Accion(sql)
        End With
    End Sub

    Sub actualizaestadosOpcionesPorIdtbSubmenu(ByVal estado As Integer)
        Dim sql As String
        sql = "update tbsubmenu set estado=" & estado & _
            " where idtbSubmenu=" & Me.idTbSubMenu
        With operaciones
            .Accion(sql)
        End With
    End Sub

    Sub grabarOpcionSubmenu(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_tbSubmenu " & _
        "@idmenu='" & Me.idMenu & "'," & _
        "@idSubmenu='" & Me.idSubMenu & "'," & _
        "@nombreSubmenu='" & Me.nombreSubMenu & "'," & _
        "@ruta='" & Me.ruta & "'," & _
        "@tipoSubmenu='" & Me.tipoSubmenu & "'," & _
        "@orden='" & "0" & "'," & _
        "@estado='" & "1" & "'," & _
        "@accion='" & accion & "'"
        With operaciones
            .Accion(sql)
        End With

    End Sub

End Class
