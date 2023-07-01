Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTBUsuarios

    Private _idUsuario As Integer
    Private _nombreUsuario As String
    Private _claveUsuario As String
    Private _direccionUsuario As String
    Private _telefonoUsuario As String
    Private _idSucursal As Integer
    Private _nombreCompletoUsuario As String
    Private _emailUsuario As String
    Private _tipoUsuario As String
    Private _idPais As String
    Private _clave As String
    Private _accion As Integer
    Private _estadoUsuario As Integer
    Dim objOperacione As New clsOperacione

    Public Property clave As String
        Get
            Return _clave
        End Get
        Set(ByVal value As String)
            _clave = value
        End Set
    End Property

    Public Property idUsuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(ByVal value As Integer)
            _idUsuario = value
        End Set
    End Property

    Public Property estadoUsuario As Integer
        Get
            Return _estadoUsuario
        End Get
        Set(ByVal value As Integer)
            _estadoUsuario = value
        End Set
    End Property

    Public Property idSucursal As Integer
        Get
            Return _idSucursal
        End Get
        Set(ByVal value As Integer)
            _idSucursal = value
        End Set
    End Property


    Public Property nombreUsuario As String
        Get
            Return _nombreUsuario
        End Get
        Set(ByVal value As String)
            _nombreUsuario = value
        End Set
    End Property

    Public Property direccionUsuario As String
        Get
            Return _direccionUsuario
        End Get
        Set(ByVal value As String)
            _direccionUsuario = value
        End Set
    End Property

    Public Property telefonoUsuario As String
        Get
            Return _telefonoUsuario
        End Get
        Set(ByVal value As String)
            _telefonoUsuario = value
        End Set
    End Property


    Public Property claveUsuario As String
        Get
            Return _claveUsuario
        End Get
        Set(ByVal value As String)
            _claveUsuario = value
        End Set
    End Property

    Public Property nombreCompletoUsuario As String
        Get
            Return _nombreCompletoUsuario
        End Get
        Set(ByVal value As String)
            _nombreCompletoUsuario = value
        End Set
    End Property

    Public Property emailUsuario As String
        Get
            Return _emailUsuario
        End Get
        Set(ByVal value As String)
            _emailUsuario = value
        End Set
    End Property

    Public Property tipoUsuario As String
        Get
            Return _tipoUsuario
        End Get
        Set(ByVal value As String)
            _tipoUsuario = value
        End Set
    End Property

    Public Property idPais As String
        Get
            Return _idPais
        End Get
        Set(ByVal value As String)
            _idPais = value
        End Set
    End Property

    Function encriptarClave(ByVal clave As String) As String
        Dim UE As New UnicodeEncoding
        Dim bHash As Byte()
        Dim bCadena() As Byte = UE.GetBytes(clave & "MNBVCXZasdfghjklñ123#$%&(")
        Dim s1Service As New SHA1CryptoServiceProvider
        bHash = s1Service.ComputeHash(bCadena)
        Dim Key_Hash_Var As String
        Key_Hash_Var = Convert.ToBase64String(bHash)
        Return Key_Hash_Var
    End Function

    Sub grabarUsuario(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaTBUsuario " & _
        "@idUsuario='" & Me.idUsuario & "'," & _
        "@nombreUsuario='" & Me.nombreUsuario & "'," & _
        "@claveUsuario='" & Me.claveUsuario & "'," & _
        "@nombreCompletoUsuario='" & Me.nombreCompletoUsuario & "'," & _
        "@emailUsuario='" & Me.emailUsuario & "'," & _
        "@tipoUsuario='" & Me.tipoUsuario & "'," & _
        "@idPais='" & Me.idPais & "'," & _
        "@estadousuario='" & Me.estadoUsuario & "'," & _
        "@direccion='" & Me.direccionUsuario & "'," & _
        "@telefono='" & Me.telefonoUsuario & "'," & _
        "@idSucursal='" & Me.idSucursal & "'," & _
        "@clave='" & Me.clave & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerUsuarios() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT " & _
        "idUsuario, " & _
        "nombreUsuario, " & _
        "clave, " & _
        "nombreCompletoUsuario, " & _
        "direccionUsuario," & _
        "telefonousuario," & _
        "emailUsuario," & _
        " case estadoUsuario" & _
        " when 0 then 'Eliminado'" & _
        " when 1 then 'Activo'" & _
        " end estadoUsuario" & _
        " FROM" & _
        " TBUsuario" & _
        " where TBUsuario.tipoUsuario=1 and TBUsuario.estadoUsuario=1"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerUsuariosEmpresas() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT " & _
        "TBUsuario.idUsuario," & _
        "TBUsuario.nombreUsuario," & _
        "TBUsuario.clave," & _
        "TBUsuario.nombreCompletoUsuario," & _
        "TBUsuario.direccionUsuario," & _
        "TBUsuario.telefonoUsuario," & _
        "TBUsuario.emailUsuario," & _
        "TBUsuario.estadoUsuario," & _
        "dbo.TBEmpresa.idempresa," & _
        "dbo.TBEmpresa.nombreEmpresa," & _
        "TBUsuario.nombreCompletoUsuario + ' (' + dbo.TBEmpresa.nombreEmpresa + ')' as muestra" & _
        " FROM" & _
        " TBUsuario INNER JOIN" & _
        " dbo.TBEmpresa ON TBUsuario.idPais = dbo.TBEmpresa.idEmpresa" & _
        " where TBUsuario.tipoUsuario=2  and TBUsuario.estadoUsuario=1 order by dbo.TBEmpresa.nombreEmpresa"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerUsuariosSucursales() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "TBUsuario.idUsuario," & _
        "TBUsuario.nombreUsuario," & _
        "TBUsuario.clave," & _
        "TBUsuario.nombreCompletoUsuario," & _
        "TBUsuario.direccionUsuario," & _
        "TBUsuario.telefonoUsuario," & _
        "TBUsuario.emailUsuario," & _
        "TBUsuario.estadoUsuario," & _
        "dbo.TBEmpresa.idEmpresa," & _
        "dbo.TBEmpresa.nombreEmpresa," & _
        "dbo.TBSucursal.idSucursal," & _
        "dbo.TBSucursal.nombreSucursal," & _
        "TBUsuario.nombreCompletoUsuario + ' (' + dbo.TBEmpresa.nombreEmpresa + ') - ' + dbo.TBSucursal.nombreSucursal as muestra" & _
        " FROM" & _
        " TBUsuario INNER JOIN" & _
        " dbo.TBEmpresa ON TBUsuario.idPais = dbo.TBEmpresa.idEmpresa INNER JOIN" & _
        " dbo.TBSucursal ON TBUsuario.idPais = dbo.TBSucursal.idEmpresa AND TBUsuario.idSucursal = dbo.TBSucursal.idSucursal" & _
        " where TBUsuario.tipoUsuario=3 and TBUsuario.estadoUsuario=1 order by dbo.TBEmpresa.nombreEmpresa,dbo.TBSucursal.nombreSucursal"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function validaUsuario() As DataTable
        Dim tabla As New DataTable
        'Dim da As New SqlDataAdapter
        Dim sql As String
        sql = "select * from TBusuario" & _
            " where nombreUsuario='" & Me.nombreUsuario & "' and" & _
            " clave='" & Me.claveUsuario & "' and estadoUsuario=1 and tipoUsuario=1"
        With objOperacione
            tabla = .devuelveDato(sql)
        End With
        Return tabla
    End Function

    Sub cambiarContrasena()
        Dim sql As String
        'sql = "exec sp_actualizaContrasenaTBUsuario " & _
        '"@idusuario='" & Me.idUsuario & "'," & _
        '"@nombreUsuario='" & Me.nombreUsuario & "'," & _
        '"@claveUsuario='" & Me.claveUsuario & "'"
        sql = "	update TBusuario set nombreUsuario='" & Me.nombreUsuario & "'," & _
         "clave='" & Me.claveUsuario & "'" & _
         " where idUsuario=" & Me.idUsuario
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerusuariosPorIdUsuario() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from tbUsuario where idusuario=" & Me.idUsuario
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Sub actualizaInformacionAdicionalUsuario(ByVal subeConsignacion As String, ByVal subeTarjeta As String, ByVal manejaFechas As String)
        Dim sql As String
        sql = "update tbUsuario set subeconsignacion='" & subeConsignacion & "'," & _
            " subeTarjeta='" & subeTarjeta & "'," & _
            " abrirFecha='" & manejaFechas & "' where idUsuario=" & Me.idUsuario
        With objOperacione
            .Accion(sql)
        End With
    End Sub
End Class
