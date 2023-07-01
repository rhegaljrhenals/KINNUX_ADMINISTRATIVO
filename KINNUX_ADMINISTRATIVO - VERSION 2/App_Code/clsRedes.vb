Imports System.Data
Imports Microsoft.VisualBasic


Public Class clsRedes
    Dim registro As DataRow
    Private _codigoPatrocinador As Integer
    Private _directo As Integer
    Private _indirecto As Integer
    Private _left As Decimal
    Private _right As Decimal
    Private _codigoAfiliado As Integer
    Private _identificacion As String
    Private _apellido As String
    Private _nombre As String
    Private _nodo As Integer
    Private _posicion As String
    Private _rango As String
    Private _email As String
    Private _nombreRango As String
    Private _nivel As Integer
    Private _puntos As Integer
    Private _fecha As Date
    Private _ts As Double
    Private _sts As Double
    Private _gn1 As Double
    Private _gn2 As Double
    Private _gn3 As Double
    Private _gn4 As Double
    Private _gn5 As Double
    Private _gn6 As Double
    Private _gn7 As Double
    Private _gn8 As Double
    Private _gn15 As Double
    Private _gn20 As Double
    Public tablaTemporal As New DataTable
    Public tablaTemporalBinaria As New DataTable
    Public tablaRedAbierta As New DataTable
    Public tablaTemporalOTS As New DataTable

    Public Property gn20 As Double
        Get
            Return _gn20
        End Get
        Set(ByVal value As Double)
            _gn20 = value
        End Set
    End Property

    Public Property gn15 As Double
        Get
            Return _gn15
        End Get
        Set(ByVal value As Double)
            _gn15 = value
        End Set
    End Property

    Public Property gn8 As Double
        Get
            Return _gn8
        End Get
        Set(ByVal value As Double)
            _gn8 = value
        End Set
    End Property

    Public Property gn7 As Double
        Get
            Return _gn7
        End Get
        Set(ByVal value As Double)
            _gn7 = value
        End Set
    End Property

    Public Property gn6 As Double
        Get
            Return _gn6
        End Get
        Set(ByVal value As Double)
            _gn6 = value
        End Set
    End Property


    Public Property gn5 As Double
        Get
            Return _gn5
        End Get
        Set(ByVal value As Double)
            _gn5 = value
        End Set
    End Property


    Public Property gn4 As Double
        Get
            Return _gn4
        End Get
        Set(ByVal value As Double)
            _gn4 = value
        End Set
    End Property

    Public Property gn3 As Double
        Get
            Return _gn3
        End Get
        Set(ByVal value As Double)
            _gn3 = value
        End Set
    End Property

    Public Property gn2 As Double
        Get
            Return _gn2
        End Get
        Set(ByVal value As Double)
            _gn2 = value
        End Set
    End Property

    Public Property gn1 As Double
        Get
            Return _gn1
        End Get
        Set(ByVal value As Double)
            _gn1 = value
        End Set
    End Property


    Public Property sts As Double
        Get
            Return _sts
        End Get
        Set(ByVal value As Double)
            _sts = value
        End Set
    End Property

    Public Property ts As Double
        Get
            Return _ts
        End Get
        Set(ByVal value As Double)
            _ts = value
        End Set
    End Property

    Public Property fecha As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
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

    Public Property nivel As Integer
        Get
            Return _nivel
        End Get
        Set(ByVal value As Integer)
            _nivel = value
        End Set
    End Property

    Public Property puntos As Integer
        Get
            Return _puntos
        End Get
        Set(ByVal value As Integer)
            _puntos = value
        End Set
    End Property

    Public Property directo As Integer
        Get
            Return _directo
        End Get
        Set(ByVal value As Integer)
            _directo = value
        End Set
    End Property

    Public Property indirecto As Integer
        Get
            Return _indirecto
        End Get
        Set(ByVal value As Integer)
            _indirecto = value
        End Set
    End Property

    Public Property codigoAfiliado As Integer
        Get
            Return _codigoAfiliado
        End Get
        Set(ByVal value As Integer)
            _codigoAfiliado = value
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

    Public Property apellidos As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property

    Public Property nombres As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property nodo As Integer
        Get
            Return _nodo
        End Get
        Set(ByVal value As Integer)
            _nodo = value
        End Set
    End Property

    Public Property posicion As String
        Get
            Return _posicion
        End Get
        Set(ByVal value As String)
            _posicion = value
        End Set
    End Property

    Public Property rango As String
        Get
            Return _rango
        End Get
        Set(ByVal value As String)
            _rango = value
        End Set
    End Property

    Public Property left As Decimal
        Get
            Return _left
        End Get
        Set(ByVal value As Decimal)
            _left = value
        End Set
    End Property

    Public Property right As Decimal
        Get
            Return _right
        End Get
        Set(ByVal value As Decimal)
            _right = value
        End Set
    End Property

    Public Property email As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Public Property nombreRango As String
        Get
            Return _nombreRango
        End Get
        Set(ByVal value As String)
            _nombreRango = value
        End Set
    End Property

    Public Sub vaciarTablaRedAbierta()
        tablaRedAbierta.Rows.Clear()
        tablaRedAbierta.AcceptChanges()
        '
    End Sub

    Public Sub vaciarTablaOrganizacionTS()
        tablaTemporalOTS.Rows.Clear()
        tablaTemporalOTS.AcceptChanges()
    End Sub

    Public Sub vaciarTabla()
        tablaTemporal.Rows.Clear()
        tablaTemporal.AcceptChanges()
        '
    End Sub

    Public Function grabarRegistroRedPatrocinioOTS() As DataTable
        registro = tablaTemporalOTS.NewRow
        registro.Item("codigoPatrocinador") = Me.codigoPatrocinador
        registro.Item("directo") = Me.directo
        registro.Item("indirecto") = Me.indirecto
        registro.Item("codigoAfiliado") = Me.codigoAfiliado
        registro.Item("apellidosyNombre") = Me.nombres & " " & Me.apellidos
        registro.Item("nivel") = Me.nivel
        registro.Item("ts") = Me.ts
        registro.Item("sts") = Me.sts
        registro.Item("gn1") = Me.gn1
        registro.Item("gn2") = Me.gn2
        registro.Item("gn3") = Me.gn3
        registro.Item("gn4") = Me.gn4
        registro.Item("gn5") = Me.gn5
        registro.Item("gn6") = Me.gn6
        registro.Item("gn7") = Me.gn7
        registro.Item("gn8") = Me.gn8
        registro.Item("gn15") = Me.gn15
        registro.Item("gn20") = Me.gn20
        tablaTemporalOTS.Rows.Add(registro)
        tablaTemporalOTS.AcceptChanges()
        Return tablaTemporalOTS
    End Function

    Public Sub crearTablaTemporalOTS()
        tablaTemporalOTS.TableName = "tablaMuestraOTS"
        Dim cCodigoPatrocinador As New DataColumn
        cCodigoPatrocinador.ColumnName = "codigoPatrocinador"
        cCodigoPatrocinador.DataType = System.Type.GetType("System.Decimal")
        'cCodigoPatrocinador.AllowDBNull = False
        tablaTemporalOTS.Columns.Add(cCodigoPatrocinador)
        '
        Dim cDirecto As New DataColumn
        cDirecto.ColumnName = "directo"
        cDirecto.DataType = System.Type.GetType("System.Decimal")        'cDirecto.AllowDBNull = False
        tablaTemporalOTS.Columns.Add(cDirecto)
        '
        Dim cIndirecto As New DataColumn
        cIndirecto.ColumnName = "indirecto"
        cIndirecto.DataType = System.Type.GetType("System.Decimal")
        tablaTemporalOTS.Columns.Add(cIndirecto)
        '
        Dim cCodigoAfiliado As New DataColumn
        cCodigoAfiliado.ColumnName = "codigoafiliado"
        cCodigoAfiliado.DataType = System.Type.GetType("System.Decimal")
        tablaTemporalOTS.Columns.Add(cCodigoAfiliado)
        '
        Dim cIdentificacion As New DataColumn
        cIdentificacion.ColumnName = "identificacion"
        cIdentificacion.DataType = System.Type.GetType("System.String")
        tablaTemporalOTS.Columns.Add(cIdentificacion)
        '
        Dim cApellido As New DataColumn
        cApellido.ColumnName = "apellidosyNombre"
        cApellido.DataType = System.Type.GetType("System.String")
        tablaTemporalOTS.Columns.Add(cApellido)
        '
        Dim cNivel As New DataColumn
        cNivel.ColumnName = "nivel"
        cNivel.DataType = System.Type.GetType("System.Decimal")
        tablaTemporalOTS.Columns.Add(cNivel)
        '
        Dim cTS As New DataColumn
        cTS.ColumnName = "ts"
        cTS.DataType = System.Type.GetType("System.Double")
        tablaTemporalOTS.Columns.Add(cTS)
        '
        Dim csTS As New DataColumn
        csTS.ColumnName = "sts"
        csTS.DataType = System.Type.GetType("System.Double")
        tablaTemporalOTS.Columns.Add(csTS)
        '
        Dim cgn1 As New DataColumn
        cgn1.ColumnName = "gn1"
        cgn1.DataType = System.Type.GetType("System.Double")
        tablaTemporalOTS.Columns.Add(cgn1)
        '
        Dim cgn2 As New DataColumn
        cgn2.ColumnName = "gn2"
        cgn2.DataType = System.Type.GetType("System.Double")
        tablaTemporalOTS.Columns.Add(cgn2)
        '
        Dim cgn3 As New DataColumn
        cgn3.ColumnName = "gn3"
        cgn3.DataType = System.Type.GetType("System.Double")
        tablaTemporalOTS.Columns.Add(cgn3)
        '
        Dim cgn4 As New DataColumn
        cgn4.ColumnName = "gn4"
        cgn4.DataType = System.Type.GetType("System.Double")
        tablaTemporalOTS.Columns.Add(cgn4)
        '
        Dim cgn5 As New DataColumn
        cgn5.ColumnName = "gn5"
        cgn5.DataType = System.Type.GetType("System.Double")
        tablaTemporalOTS.Columns.Add(cgn5)
        '
        Dim cgn6 As New DataColumn
        cgn6.ColumnName = "gn6"
        cgn6.DataType = System.Type.GetType("System.Double")
        tablaTemporalOTS.Columns.Add(cgn6)
        '
        Dim cgn7 As New DataColumn
        cgn7.ColumnName = "gn7"
        cgn7.DataType = System.Type.GetType("System.Double")
        tablaTemporalOTS.Columns.Add(cgn7)
        '
        Dim cgn8 As New DataColumn
        cgn8.ColumnName = "gn8"
        cgn8.DataType = System.Type.GetType("System.Double")
        tablaTemporalOTS.Columns.Add(cgn8)
        '
        Dim cgn15 As New DataColumn
        cgn15.ColumnName = "gn15"
        cgn15.DataType = System.Type.GetType("System.Double")
        tablaTemporalOTS.Columns.Add(cgn15)
        '
        Dim cgn20 As New DataColumn
        cgn20.ColumnName = "gn20"
        cgn20.DataType = System.Type.GetType("System.Double")
        tablaTemporalOTS.Columns.Add(cgn20)

    End Sub

    Public Sub crearTablaTemporal()
        tablaTemporal.TableName = "tablaMuestra"
        Dim cCodigoPatrocinador As New DataColumn
        cCodigoPatrocinador.ColumnName = "codigoPatrocinador"
        cCodigoPatrocinador.DataType = System.Type.GetType("System.Decimal")
        'cCodigoPatrocinador.AllowDBNull = False
        tablaTemporal.Columns.Add(cCodigoPatrocinador)
        '
        Dim cDirecto As New DataColumn
        cDirecto.ColumnName = "directo"
        cDirecto.DataType = System.Type.GetType("System.Decimal")        'cDirecto.AllowDBNull = False
        tablaTemporal.Columns.Add(cDirecto)
        '
        Dim cIndirecto As New DataColumn
        cIndirecto.ColumnName = "indirecto"
        cIndirecto.DataType = System.Type.GetType("System.Decimal")
        tablaTemporal.Columns.Add(cIndirecto)
        '
        Dim cCodigoAfiliado As New DataColumn
        cCodigoAfiliado.ColumnName = "codigoafiliado"
        cCodigoAfiliado.DataType = System.Type.GetType("System.Decimal")
        tablaTemporal.Columns.Add(cCodigoAfiliado)
        '
        Dim cIdentificacion As New DataColumn
        cIdentificacion.ColumnName = "identificacion"
        cIdentificacion.DataType = System.Type.GetType("System.String")
        tablaTemporal.Columns.Add(cIdentificacion)
        '
        Dim cApellido As New DataColumn
        cApellido.ColumnName = "apellidosyNombre"
        cApellido.DataType = System.Type.GetType("System.String")
        tablaTemporal.Columns.Add(cApellido)
        '
        'Dim cNombre As New DataColumn
        'cNombre.ColumnName = "nombre"
        'cNombre.DataType = System.Type.GetType("System.String")
        'cNombre.AllowDBNull = False
        'tablaTemporal.Columns.Add(cNombre)
        '
        Dim cNodo As New DataColumn
        cNodo.ColumnName = "nodo"
        cNodo.DataType = System.Type.GetType("System.Decimal")
        tablaTemporal.Columns.Add(cNodo)
        '
        Dim cPosicion As New DataColumn
        cPosicion.ColumnName = "posicion"
        cPosicion.DataType = System.Type.GetType("System.String")
        tablaTemporal.Columns.Add(cPosicion)
        '
        Dim cRango As New DataColumn
        cRango.ColumnName = "rango"
        cRango.DataType = System.Type.GetType("System.String")
        tablaTemporal.Columns.Add(cRango)
        '
        Dim cleft As New DataColumn
        cleft.ColumnName = "left"
        cleft.DataType = System.Type.GetType("System.Decimal")
        tablaTemporal.Columns.Add(cleft)
        '
        Dim cRight As New DataColumn
        cRight.ColumnName = "right"
        cRight.DataType = System.Type.GetType("System.Decimal")
        tablaTemporal.Columns.Add(cRight)
        '
        Dim cEmail As New DataColumn
        cEmail.ColumnName = "email"
        cEmail.DataType = System.Type.GetType("System.String")
        tablaTemporal.Columns.Add(cEmail)
        '
        Dim cnombreRango As New DataColumn
        cnombreRango.ColumnName = "nombreRango"
        cnombreRango.DataType = System.Type.GetType("System.String")
        tablaTemporal.Columns.Add(cnombreRango)
        '
        Dim cNivel As New DataColumn
        cNivel.ColumnName = "nivel"
        cNivel.DataType = System.Type.GetType("System.Decimal")
        tablaTemporal.Columns.Add(cNivel)
        '
        Dim cPuntos As New DataColumn
        cPuntos.ColumnName = "puntos"
        cPuntos.DataType = System.Type.GetType("System.Decimal")
        tablaTemporal.Columns.Add(cPuntos)

    End Sub

    Public Function grabarRegistro() As DataTable
        registro = tablaTemporal.NewRow
        registro.Item("codigoPatrocinador") = Me.codigoPatrocinador
        registro.Item("directo") = Me.directo
        registro.Item("indirecto") = Me.indirecto
        registro.Item("codigoAfiliado") = Me.codigoAfiliado
        registro.Item("identificacion") = Me.identificacion
        registro.Item("apellidosyNombre") = Me.apellidos & " " & Me.nombres
        'registro.Item("nombre") = Me.nombres
        registro.Item("nodo") = Me.nodo
        registro.Item("posicion") = Me.posicion
        registro.Item("rango") = Me.rango
        registro.Item("left") = Me.left
        registro.Item("right") = Me.right
        registro.Item("email") = Me.email
        registro.Item("nombreRango") = Me.email
        registro.Item("nivel") = Me.nivel
        registro.Item("puntos") = Me.puntos
        tablaTemporal.Rows.Add(registro)
        tablaTemporal.AcceptChanges()
        Return tablaTemporal
    End Function

    Public Function grabarRegistroTablaRedAbierta(ByVal nivel As Integer) As DataTable
        registro = tablaRedAbierta.NewRow
        registro.Item("codigoPatrocinador") = Me.codigoPatrocinador
        registro.Item("directo") = Me.directo
        registro.Item("indirecto") = Me.indirecto
        registro.Item("codigoAfiliado") = Me.codigoAfiliado
        registro.Item("identificacion") = Me.identificacion
        registro.Item("apellidosyNombre") = Me.apellidos & " " & Me.nombres
        'registro.Item("Nivel") = nivel
        tablaRedAbierta.Rows.Add(registro)
        tablaRedAbierta.AcceptChanges()
        Return tablaRedAbierta
    End Function
End Class
