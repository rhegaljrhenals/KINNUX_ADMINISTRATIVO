Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTBPermiso

    Private _idusuario As Integer
    Private _idMenu As Integer
    Private _idSubmenu As Integer
    Private _acceso As String
    Dim objOperacione As New clsOperacione

    Public Property idusuario As Integer
        Get
            Return _idusuario
        End Get
        Set(ByVal value As Integer)
            _idusuario = value
        End Set
    End Property

    Public Property idMenu As Integer
        Get
            Return _idMenu
        End Get
        Set(ByVal value As Integer)
            _idMenu = value
        End Set
    End Property

    Public Property idSubmenu As Integer
        Get
            Return _idSubmenu
        End Get
        Set(ByVal value As Integer)
            _idSubmenu = value
        End Set
    End Property

    Public Property acceso As String
        Get
            Return _acceso
        End Get
        Set(ByVal value As String)
            _acceso = value
        End Set
    End Property

    Sub actualizaPermiso()
        Dim sql As String
        sql = "exec sp_actualizaTBPermiso " & _
        "@idusuario='" & Me.idusuario & "'," & _
        "@idMenu='" & Me.idMenu & "'," & _
        "@idSubmenu='" & Me.idSubmenu & "'," & _
        "@acceso='" & Me.acceso & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerPermisosPorIdUsuario(ByVal tipo As Integer) As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT " & _
        "TBMenu.idMenu," & _
        "TBMenu.nombreMenu," & _
        "TBSubmenu.idSubmenu," & _
        "TBSubmenu.nombreSubmenu," & _
        "TBPermiso.acceso" & _
        " FROM" & _
        " TBUsuario INNER JOIN" & _
        " TBPermiso ON TBUsuario.idUsuario = TBPermiso.idUsuario INNER JOIN" & _
        " TBMenu INNER JOIN" & _
        " TBSubmenu ON TBMenu.idMenu = TBSubmenu.idmenu ON " & _
        " TBPermiso.idMenu = TBMenu.idMenu And" & _
        " TBPermiso.idSubmenu = TBSubmenu.idSubmenu" & _
        " where TBUsuario.idUsuario=" & Me.idusuario & " and" & _
        " TBMenu.tipoOpcion = " & tipo & " And" & _
        " TBSubmenu.tipoSubmenu = " & tipo & _
        " order by TBMenu.idMenu,TBSubmenu.idSubmenu"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener las opciones de la aplicacion pais
    Function opcionesPais() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "TBMenu.idMenu," & _
        "TBMenu.nombreMenu," & _
        "TBSubmenu.idSubmenu," & _
        "TBSubmenu.nombreSubmenu" & _
        " FROM" & _
        " TBMenu INNER JOIN" & _
        " TBSubmenu ON TBMenu.idMenu = TBSubmenu.idmenu" & _
        " where TBMenu.tipoOpcion = 2 And TBSubmenu.tipoSubmenu = 2" & _
        " order by TBMenu.idMenu,TBSubmenu.idSubmenu"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener las opciones de la aplicacion punto(sucursales)
    Function opcionesSucursales() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "TBMenu.idMenu," & _
        "TBMenu.nombreMenu," & _
        "TBSubmenu.idSubmenu," & _
        "TBSubmenu.nombreSubmenu" & _
        " FROM" & _
        " TBMenu INNER JOIN" & _
        " TBSubmenu ON TBMenu.idMenu = TBSubmenu.idmenu" & _
        " where TBMenu.tipoOpcion = 3 And TBSubmenu.tipoSubmenu = 3" & _
        " order by TBMenu.idMenu,TBSubmenu.idSubmenu"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener las opciones de la aplicacion mundial
    Function opcionesMundial() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "TBMenu.idMenu," & _
        "TBMenu.nombreMenu," & _
        "TBSubmenu.idSubmenu," & _
        "TBSubmenu.nombreSubmenu" & _
        " FROM" & _
        " TBMenu INNER JOIN" & _
        " TBSubmenu ON TBMenu.idMenu = TBSubmenu.idmenu" & _
        " where TBMenu.tipoOpcion = 1 And TBSubmenu.tipoSubmenu = 1" & _
        " order by TBMenu.idMenu,TBSubmenu.idSubmenu"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener el acceso al menu
    Function obtenerAcceso() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from tbPermiso" & _
            " where idusuario=" & Me.idusuario & " and" & _
        " idMenu=" & Me.idMenu & " and" & _
        " idsubmenu=" & Me.idSubmenu
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Sub actualizaPermisosPais()
        Dim sql As String
        sql = "exec sp_actualizaPermisoAplicacionPais " & _
        "@idUsuario='" & Me.idusuario & "'," & _
        "@idMenu='" & Me.idMenu & "'," & _
        "@idSubmenu='" & Me.idSubmenu & "'," & _
        "@acceso='" & Me.acceso & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Sub actualizaPermisosSucursales()
        Dim sql As String
        sql = "exec sp_actualizaPermisoAplicacionPunto " & _
        "@idUsuario='" & Me.idusuario & "'," & _
        "@idMenu='" & Me.idMenu & "'," & _
        "@idSubmenu='" & Me.idSubmenu & "'," & _
        "@acceso='" & Me.acceso & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub
End Class
