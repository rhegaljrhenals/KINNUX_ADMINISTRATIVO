Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsUsuario

    Private _idUsuario As Integer
    Private _nombreUsuario As String
    Private _claveUsuario As String
    Private _codigoGrupo As Integer
    Private _nombreCompletousuario As String
    Private _emailUsuario As String
    Private _estado As Integer
    Private _idAfiliado As Integer
    Private _idPais As Integer
    Private _idSucursal As Integer
    Dim objOperacione As New clsOperacione

    Public Property idSucursal As Integer
        Get
            Return _idSucursal
        End Get
        Set(ByVal value As Integer)
            _idSucursal = value
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

    Public Property idUsuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(ByVal value As Integer)
            _idUsuario = value
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

    Public Property clave As String
        Get
            Return _claveUsuario
        End Get
        Set(ByVal value As String)
            _claveUsuario = value
        End Set
    End Property

    Public Property grupoUsuario As Integer
        Get
            Return _codigoGrupo
        End Get
        Set(ByVal value As Integer)
            _codigoGrupo = value
        End Set
    End Property

    Public Property nombreCompletoUsuario As String
        Get
            Return _nombreCompletousuario
        End Get
        Set(ByVal value As String)
            _nombreCompletousuario = value
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

    Public Property estadoUsuario As Integer
        Get
            Return _estado
        End Get
        Set(ByVal value As Integer)
            _estado = value
        End Set
    End Property

    Public Property idAfiliado As Integer
        Get
            Return _idAfiliado
        End Get
        Set(ByVal value As Integer)
            _idAfiliado = value
        End Set
    End Property


    Sub actualizaUsuario(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizarUsuario " & _
        "@idUsuario='" & Me.idUsuario & "'," & _
        "@nombreUsuario='" & Me.nombreUsuario & "'," & _
        "@clave='" & Me.clave & "'," & _
        "@codigoGrupo='" & Me.grupoUsuario & "'," & _
        "@accion='" & accion & "'," & _
        "@nombreCompleto='" & Me.nombreCompletoUsuario & "'," & _
        "@emailUsuario='" & Me.emailUsuario & "'," & _
        "@estado='" & Me.estadoUsuario & "'," & _
        "@idAfiliado='" & Me.idAfiliado & "'"
        With objOperacione
            .accion(sql)
        End With
    End Sub

    Function validaUsuario() As DataTable
        Dim tabla As New DataTable
        'Dim da As New SqlDataAdapter
        Dim sql As String
        sql = "select * from usuario" & _
            " where nombreUsuario='" & Me.nombreUsuario & "' and" & _
            " clave='" & Me.clave & "' and estado=1 and codigoGrupo<>1"
        With objOperacione
            tabla = .devuelveDato(sql)
        End With
        Return tabla
    End Function

    Sub cambiarContrasena()
        Dim sql As String
        sql = "exec sp_actualizaContrasena " & _
        "@idusuario='" & Me.idUsuario & "'," & _
        "@nombreUsuario='" & Me.nombreUsuario & "'," & _
        "@clave='" & Me.clave & "'"
        With objOperacione
            .accion(sql)
        End With
    End Sub

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

    Function validaUsuarioyCorreoElectronico() As DataTable
        Dim tablaUsuario As New DataTable
        Dim sql As String
        sql = "select * " & _
            "from usuario " & _
            "where nombreusuario='" & Me.nombreUsuario & "' and " & _
            "emailUsuario='" & Me.emailUsuario & "' and estado=1"
        With objOperacione
            tablaUsuario = .DevuelveDato(sql)
        End With
        Return tablaUsuario
    End Function

    Function buscarUsuarioPoridAfiliado() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from usuario where idAfiliado=" & Me.idAfiliado
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerUsuarioPorIdUsuario() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT " & _
        "usuario.nombrecompletoUsuario," & _
        "usuario.idAfiliado," & _
        "usuario.nombreUsuario," & _
        "usuario.clave," & _
        "usuario.fotousuario," & _
        "grupoUsuario.codigoGrupo," & _
        "grupoUsuario.nombreGrupo" & _
        " FROM" & _
        " usuario INNER JOIN" & _
        " grupoUsuario ON usuario.codigoGrupo = grupoUsuario.codigoGrupo" & _
        " where usuario.idUsuario=" & Me.idUsuario
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Sub actualizaFotoUsuario(ByVal rutaFoto As String)
        Dim sql As String
        sql = "exec sp_actualizaFotoUsuario " & _
        "@idUsuario='" & Me.idUsuario & "'," & _
        "@rutaFoto='" & rutaFoto & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerUsuariosPorSucursales() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select idUsuario from tbusuario" & _
        " where" & _
        " tipousuario = 3 And" & _
        " idpais = " & Me.idPais & " And idsucursal = " & Me.idSucursal
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para cargar los usuarios de solamente bogota
    Function obtenerUsuariosBogota() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from tbusuario where idPais = 15 And idSucursal = 21 And tipoUsuario = 3"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function


End Class
