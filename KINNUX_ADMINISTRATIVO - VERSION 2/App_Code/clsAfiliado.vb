Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.VisualBasic

Public Class ClsAfiliado
    '-----------------------------------------------------------
    ' propiedades
    Private _codigoPatrocinador As Integer
    Private _Directo As Integer
    Private _inDirecto As Integer
    Private _idAfiliado As Integer
    Private _identificacion As String
    Private _papellido As String
    Private _pnombre As String
    Private _sapellido As String
    Private _snombre As String
    Private _empresa As String
    Private _fechaNacido As DateTime
    Private _direccion As String
    Private _codigoPais As Integer
    Private _codigoCiudad As String
    Private _codigoDpto As String
    Private _telefono As String
    Private _celular As String
    Private _email1 As String
    Private _email2 As String
    Private _codigoPostal As String
    Private _codigoPlan As Integer
    Private _nombreEnvio As String
    Private _direccionEnvio As String
    Private _ciudadEnvio As String
    Private _dptoEnvio As String
    Private _telefonoEnvio As String
    Private _celularEnvio As String
    Private _emailEnvio As String
    Private _codigoPostalEnvio As String
    Private _nombreBeneficiario As String
    Private _identificacionBeneficiario As String
    Private _numeroCuenta As String
    Private _cedulaCuenta As String
    Private _titularCuenta As String
    Private _codigoBanco As Integer
    Private _tipoCuenta As Integer
    Private _nodo As Integer
    Private _posicion As String
    Private _estado As String
    Private _tieneCuenta As Integer
    Private _recibeComisiones As Integer
    Private _idPaquete As Integer
    Private _estadoAfiliado As Integer
    '-----------------------------------------------------------
    Dim objOperacione As New clsOperacione
    Dim objConexion As New ClsConexion

    Public Property estadoAfiliado As Integer
        Get
            Return _estadoAfiliado
        End Get
        Set(ByVal value As Integer)
            _estadoAfiliado = value
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
    Public Property codigoPatrocinador As Integer
        Get
            Return _codigoPatrocinador
        End Get
        Set(ByVal value As Integer)
            _codigoPatrocinador = value
        End Set
    End Property

    Public Property codigoAfiliado As Integer
        Get
            Return _idAfiliado
        End Get
        Set(ByVal value As Integer)
            _idAfiliado = value
        End Set
    End Property

    Public Property patrocinadorDirecto As Integer
        Get
            Return _Directo
        End Get
        Set(ByVal value As Integer)
            _Directo = value
        End Set
    End Property

    Public Property patrocinadorinDirecto As Integer
        Get
            Return _inDirecto
        End Get
        Set(ByVal value As Integer)
            _inDirecto = value
        End Set
    End Property

    Public Property identificacion As String
        Get
            Return _identificacion
        End Get
        Set(ByVal value As String)
            _identificacion = value
        End Set
    End Property

    Public Property papellidoAfiliado As String
        Get
            Return _papellido
        End Get
        Set(ByVal value As String)
            _papellido = value
        End Set
    End Property

    Public Property pnombreAfiliado As String
        Get
            Return _pnombre
        End Get
        Set(ByVal value As String)
            _pnombre = value
        End Set
    End Property

    Public Property sapellidoAfiliado As String
        Get
            Return _sapellido
        End Get
        Set(ByVal value As String)
            _sapellido = value
        End Set
    End Property

    Public Property snombreAfiliado As String
        Get
            Return _snombre
        End Get
        Set(ByVal value As String)
            _snombre = value
        End Set
    End Property



    Public Property empresa As String
        Get
            Return _empresa

        End Get
        Set(ByVal value As String)
            _empresa = value
        End Set
    End Property

    Public Property fechaNacido As DateTime
        Get
            Return _fechaNacido

        End Get
        Set(ByVal value As DateTime)
            _fechaNacido = value
        End Set
    End Property

    Public Property direccion As String
        Get
            Return _direccion

        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property

    Public Property pais As Integer
        Get
            Return _codigoPais

        End Get
        Set(ByVal value As Integer)
            _codigoPais = value
        End Set
    End Property

    Public Property ciudad As String
        Get
            Return _codigoCiudad
        End Get
        Set(ByVal value As String)
            _codigoCiudad = value
        End Set
    End Property

    Public Property departamento As String
        Get
            Return _codigoDpto
        End Get
        Set(ByVal value As String)
            _codigoDpto = value
        End Set
    End Property

    Public Property telefono As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

    Public Property celular As String
        Get
            Return _celular
        End Get
        Set(ByVal value As String)
            _celular = value
        End Set
    End Property

    Public Property email1 As String
        Get
            Return _email1
        End Get
        Set(ByVal value As String)
            _email1 = value
        End Set
    End Property

    Public Property email2 As String
        Get
            Return _email2
        End Get
        Set(ByVal value As String)
            _email2 = value
        End Set
    End Property

    Public Property codigoPosta As String
        Get
            Return _codigoPostal
        End Get
        Set(ByVal value As String)
            _codigoPostal = value
        End Set
    End Property

    Public Property codigoPlan As Integer
        Get
            Return _codigoPlan

        End Get
        Set(ByVal value As Integer)
            _codigoPlan = value
        End Set
    End Property

    Public Property nombreEnvio As String
        Get
            Return _nombreEnvio

        End Get
        Set(ByVal value As String)
            _nombreEnvio = value
        End Set
    End Property

    Public Property direccionEnvio As String
        Get
            Return _direccionEnvio
        End Get
        Set(ByVal value As String)
            _direccionEnvio = value
        End Set
    End Property

    Public Property ciudadEnvio As Integer
        Get
            Return _ciudadEnvio
        End Get
        Set(ByVal value As Integer)
            _ciudadEnvio = value
        End Set
    End Property

    Public Property dptoEnvio As Integer
        Get
            Return _dptoEnvio
        End Get
        Set(ByVal value As Integer)
            _dptoEnvio = value
        End Set
    End Property

    Public Property telefonoEnvio As String
        Get
            Return _telefonoEnvio
        End Get
        Set(ByVal value As String)
            _telefonoEnvio = value
        End Set
    End Property

    Public Property celularEnvio As String
        Get
            Return _celularEnvio
        End Get
        Set(ByVal value As String)
            _celularEnvio = value
        End Set
    End Property

    Public Property emailEnvio As String
        Get
            Return _emailEnvio
        End Get
        Set(ByVal value As String)
            _emailEnvio = value
        End Set
    End Property

    Public Property codigoPostalEnvio As String
        Get
            Return _codigoPostalEnvio
        End Get
        Set(ByVal value As String)
            _codigoPostalEnvio = value
        End Set
    End Property

    Public Property nombreBeneficiario As String
        Get
            Return _nombreBeneficiario
        End Get
        Set(ByVal value As String)
            _nombreBeneficiario = value
        End Set
    End Property

    Public Property identificacionBeneficiario As String
        Get
            Return _identificacionBeneficiario
        End Get
        Set(ByVal value As String)
            _identificacionBeneficiario = value
        End Set
    End Property

    Public Property numeroCuenta As String
        Get
            Return _numeroCuenta
        End Get
        Set(ByVal value As String)
            _numeroCuenta = value
        End Set
    End Property

    Public Property cedulaCuenta As String
        Get
            Return _cedulaCuenta
        End Get
        Set(ByVal value As String)
            _cedulaCuenta = value
        End Set
    End Property

    Public Property titularCuenta As String
        Get
            Return _titularCuenta
        End Get
        Set(ByVal value As String)
            _titularCuenta = value
        End Set
    End Property

    Public Property codigoBanco As Integer
        Get
            Return _codigoBanco
        End Get
        Set(ByVal value As Integer)
            _codigoBanco = value
        End Set
    End Property

    Public Property tipoCuenta As Integer
        Get
            Return _tipoCuenta
        End Get
        Set(ByVal value As Integer)
            _tipoCuenta = value
        End Set
    End Property

    Public Property nodoAfiliado As Integer
        Get
            Return _nodo
        End Get
        Set(ByVal value As Integer)
            _nodo = value
        End Set
    End Property

    Public Property posicionAfiliado As String
        Get
            Return _posicion
        End Get
        Set(ByVal value As String)
            _posicion = value
        End Set
    End Property

    Public Property estado As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property

    Public Property tieneCuenta As Integer
        Get
            Return _tieneCuenta
        End Get
        Set(ByVal value As Integer)
            _tieneCuenta = value
        End Set
    End Property

    Public Property recibeComisiones As Integer
        Get
            Return _recibeComisiones
        End Get
        Set(ByVal value As Integer)
            _recibeComisiones = value
        End Set
    End Property


    Sub ActualizaNodo(ByVal nuevoValor As Integer)
        Dim sql As String
        sql = "exec sp_actualizaNodo " & _
             "@idAfiliado='" & Me.codigoPatrocinador & "'," & _
             "@valor='" & nuevoValor & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    ' procedimiento para actualizar el nodo del patrocinador directo, por derrame
    Sub ActualizaNodoPatrocinadorDirecto(ByVal codigo As Integer, ByVal nuevoValor As Integer)
        Dim sql As String
        sql = "exec sp_actualizaNodoPatrocinadorDirecto " & _
             "@idAfiliado='" & codigo & "'," & _
             "@valor='" & nuevoValor & "'"
        With objOperacione
            .accion(sql)
        End With
    End Sub

    ' funcion que valida si el codigo del patrocinador existe en la base de datos o esta activo
    Function validaPatrocinador() As DataTable
        Dim tablaPatrocinador As New DataTable
        With objOperacione
            tablaPatrocinador = .DevuelveDato("select * from afiliaciones where codigoAfiliado=" & Me.codigoPatrocinador & " and estado=1")
        End With
        Return tablaPatrocinador
    End Function

    ' funcion que valida la identificacion del afiliado
    Function validaIdentificacion() As DataTable
        Dim tablaIdentificacion As New DataTable
        With objOperacione
            tablaIdentificacion = .DevuelveDato("select * from afiliaciones where identificacion='" & Me.identificacion & "'")
        End With
        Return tablaIdentificacion
    End Function

    ' funcion que mustar las afiliaciones entre dos fechas
    Function muestraAfiliacionesEntreDosFechas(ByVal fechaInicial As String, ByVal fechaFinal As String) As DataTable
        Dim sql As String
        sql = "exec sp_muestraAfiliacionesEntreDosFechas " & _
        "@fechainicial='" & fechaInicial & "'," & _
        "@fechaFinal='" & fechaFinal & "'"
        Dim tabla As New DataTable
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion que obtiene todos los registros de la tabla afiliaciones
    Function AfiiacionesTotales() As DataSet
        Dim da As New SqlDataAdapter
        Dim ds As DataSet = New DataSet
        With objConexion
            .conectar()
            da = New SqlDataAdapter("select * from afiliaciones order by codigoPatrocinador", .conexion)
            da.Fill(ds)
        End With
        Return ds
    End Function

    Function buscaAfiliado() As DataTable
        Dim tabla As New DataTable
        With objOperacione
            tabla = .DevuelveDato("select * from afiliaciones where codigoAfiliado=" & Me.codigoAfiliado & " and estado=1")
        End With
        Return tabla
    End Function

    Function obtenerPatrocinadores() As DataTable
        Dim tabla As New DataTable
        With objOperacione
            tabla = .DevuelveDato("select * from afiliaciones where codigoPatrocinador =" & Me.codigoAfiliado)
        End With
        Return tabla
    End Function

    Function obtenerAfiliadoPorCodigoAfiliado() As DataTable
        Dim tabla As New DataTable
        With objOperacione
            tabla = .DevuelveDato("select * from afiliaciones where codigoAfiliado=" & Me.codigoAfiliado)
        End With
        Return tabla
    End Function

    Function datosParaActualizar() As DataTable
        Dim sql As String
        sql = "select " & _
            "codigoAfiliado," & _
            "identificacion," & _
            "id," & _
            "pnombre," & _
            "snombre," & _
            "papellido," & _
            "sapellido," & _
            "direccion," & _
            "telefono," & _
            "celular," & _
            "codigopais," & _
            "codigodpto," & _
            "codigociudad," & _
            "email1," & _
            "day(fechaNacido) as dia," & _
            "month(fechanacido) as mes," & _
            "year(fechanacido) as ano," & _
            "estado" & _
            " from afiliaciones" & _
            " where codigoAfiliado='" & Me.codigoAfiliado & "'"
        Dim tabla As New DataTable
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function


    'Function obtenerMonedero() As DataTable
    '    Dim sql As String
    '    sql = "select count(*) from afiliaciones" & _
    '    " where codigoPatrocinador = " & Me.codigoAfiliado


    'End Function

    Function validaEmail() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from afiliaciones where email1='" & Me.email1 & "'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Sub actualizaPiernaIzquierda()
        Dim sql As String
        sql = "update afiliaciones set L=1" & _
            " where codigoAfiliado=" & Me.codigoAfiliado
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Sub actualizaPiernaDerecha()
        Dim sql As String
        sql = "update afiliaciones set R=1" & _
            " where codigoAfiliado=" & Me.codigoAfiliado
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    ' obtener recorrido lado izquierdo
    Function obtenerRecorridoLadoIzquierdo() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from afiliaciones" & _
            " where (codigopatrocinador=" & Me.codigoAfiliado & " or directo=" & Me.codigoAfiliado & " or indirecto=" & Me.codigoAfiliado & ") and" & _
            " posicion='L'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    '--------------------------------------------------------------------
    ' obtener recorrido lado derecho
    Function obtenerRecorridoLadoDerecho() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from afiliaciones" & _
            " where (codigopatrocinador=" & Me.codigoAfiliado & " or directo=" & Me.codigoAfiliado & " or indirecto=" & Me.codigoAfiliado & ") and" & _
            " posicion='R'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Sub actualizaDatosAfiliados()
        Dim sql As String
        sql = "exec sp_actualizaAfiliados " & _
        "@codigoAfiliado='" & Me.codigoAfiliado & "'," & _
        "@identificacion='" & Me.identificacion & "'," & _
        "@papellido='" & Me.papellidoAfiliado & "'," & _
        "@sapellido='" & Me.sapellidoAfiliado & "'," & _
        "@pnombre='" & Me.pnombreAfiliado & "'," & _
        "@snombre='" & Me.snombreAfiliado & "'," & _
        "@telefono='" & Me.telefono & "'," & _
        "@celular='" & Me.celular & "'," & _
        "@email='" & Me.email1.ToLower & "'," & _
        "@fechaNacido='" & Me.fechaNacido.ToString("yyyy/MM/dd") & "'," & _
        "@pais='" & Me.pais & "'," & _
        "@dpto='" & Me.departamento & "'," & _
        "@ciudad='" & Me.ciudad & "'," & _
        "@direccion='" & Me.direccion & "'," & _
        "@estado='" & Me.estadoAfiliado & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    ' procedimiento que actualiza el campo kit al anular la remision
    Sub actualizaCampoKitAfiliaciones()
        Dim sql As String
        sql = "exec sp_actualizaAfiliacionesKitNO " & _
        "@codigoAfiliado='" & Me.codigoAfiliado & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    ' procedimiento para actulizar el paquete en afiliaciones
    Sub actualizarIdPaquete()
        Dim sql As String
        sql = "exec sp_actualizaAfiliacionesIdPaquete " & _
        "@codigoAfiliado='" & Me.codigoAfiliado & "'," & _
        "@idPaquete='" & Me.idPaquete & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    ' funcion para obtener los datos completo de un afiliado
    Function obtenerDatosAfiliado() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select *" & _
        " from vw_datosAfiliados where codigoAfiliado='" & Me.codigoAfiliado & "'"
        'sql = "select * from vw_datosAfiliados where codigoAfiliado='" & Me.codigoAfiliado & "'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
