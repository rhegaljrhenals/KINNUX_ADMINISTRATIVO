Imports System.Data

Partial Class herramientas_wfAnularRemisiones
    Inherits System.Web.UI.Page

    Dim encabezadoRemision As New clsTTEncFacturaPro
    Dim detalleFactura As New clsTTDetFacturaPro
    Dim reciboFactura As New clsTTReciboFactura
    Dim consignaciones As New clsTTConsignacion
    Dim afiliados As New ClsAfiliado
    Dim bodegaSucursal As New clsTTBodPuntoProducto
    Dim apartados As New clsTTRecibo
    Dim comisionKit As New clsTTComisionKit
    Dim detalleComisionKit As New clsTTDetComisionKit
    Dim facturaConsig As New clsTTFacturaConsig
    Dim comisionesIr As New clsTTComisionIr
    Dim paquete As New clsPaquetePais
    Dim facturasTarjetas As New clsfacturaTarjeta
    Dim fechasCierre As New clsTBFechaCierre
    Dim logAnular As New clsTTLogAnulacionesRemisiones
    Dim operaciones As New clsOperacione

    Protected Sub ImageButton10_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton10.Click
        Me.Label7.Text = ""
        If Me.TextBox1.Text <> "" Then
            Dim encontrada As String = mostrarEncabezadoRemision()
            If encontrada = "si" Then
                mostrarDetalleFactura()
                Me.MultiView1.ActiveViewIndex = 0
                mostrarApartados()
                mostrarDatosConsignaciones()
                mostrarDatostarjetas()
            End If
        End If
    End Sub

    Sub mostrarDatostarjetas()
        Dim tabla As New DataTable
        With facturasTarjetas
            .idEncFacturapro = Me.TextBox2.Text
            tabla = .obtenerTarjetasPorRemision
            If tabla.Rows.Count <> 0 Then
                Me.GridView8.DataSource = tabla
                Me.GridView8.DataBind()
            Else
                Me.GridView8.DataSource = Nothing
                Me.GridView8.DataBind()
            End If
        End With
    End Sub

    Sub mostrarDatosConsignaciones()
        Dim tabla As New DataTable
        With consignaciones
            .idEncFacturaPro = Me.TextBox2.Text
            tabla = .obtenerConsigancionesPorIdremision
            If tabla.Rows.Count <> 0 Then
                Me.GridView5.DataSource = tabla
                Me.GridView5.DataBind()
            Else
                Me.GridView5.DataSource = Nothing
                Me.GridView5.DataBind()
            End If
        End With
    End Sub

    Sub limpiar()
        Me.TextBox21.Text = ""
        Me.TextBox22.Text = ""
        Me.TextBox23.Text = ""
        '
        Me.TextBox22.Text = ""
        Me.TextBox25.Text = ""
        Me.TextBox28.Text = ""
        '
        Me.TextBox23.Text = ""
        Me.TextBox26.Text = ""
        Me.TextBox29.Text = ""
        '
    End Sub

    Sub mostrarApartados()
        Dim y As Integer
        Dim tabla As New DataTable
        With reciboFactura
            .idEncFacturaPro = Me.TextBox2.Text
            tabla = .obtenerAbonosPorNumeroRemisionProcesoAnular
            If tabla.Rows.Count <> 0 Then
                For y = 0 To tabla.Rows.Count - 1
                    Select Case y
                        Case Is = 0
                            Me.TextBox21.Text = tabla.Rows(y).Item("idrecibo")
                            Me.TextBox24.Text = tabla.Rows(y).Item("numerorecibo")
                            Me.TextBox27.Text = tabla.Rows(y).Item("valorrecibo")
                        Case Is = 1
                            Me.TextBox22.Text = tabla.Rows(y).Item("idrecibo")
                            Me.TextBox25.Text = tabla.Rows(y).Item("numerorecibo")
                            Me.TextBox28.Text = tabla.Rows(y).Item("valorrecibo")
                        Case Is = 2
                            Me.TextBox23.Text = tabla.Rows(y).Item("idrecibo")
                            Me.TextBox26.Text = tabla.Rows(y).Item("numerorecibo")
                            Me.TextBox29.Text = tabla.Rows(y).Item("valorrecibo")
                    End Select
                Next
            Else
                Me.TextBox21.Text = ""
                Me.TextBox22.Text = ""
                Me.TextBox23.Text = ""
                '
                Me.TextBox22.Text = ""
                Me.TextBox25.Text = ""
                Me.TextBox28.Text = ""
                '
                Me.TextBox23.Text = ""
                Me.TextBox26.Text = ""
                Me.TextBox29.Text = ""
                
            End If
        End With
    End Sub

    Sub mostrarDetalleFactura()
        Dim tabla As New DataTable
        If Me.TextBox8.Text = "Kit De Afiliación" Then
            With detalleFactura
                .idEncFacturaPro = Me.TextBox2.Text
                tabla = .obtenerDetalleFacturaPorIdEncabezadoKit
                If tabla.Rows.Count <> 0 Then
                    Me.GridView2.DataSource = tabla
                    Me.GridView2.DataBind()
                Else
                    Me.GridView2.DataSource = Nothing
                    Me.GridView2.DataBind()
                End If
            End With
        Else
            With detalleFactura
                .idEncFacturaPro = Me.TextBox2.Text
                tabla = .obtenerDetalleFacturaPorIdEncabezadoFacturaPersonalizada
                If tabla.Rows.Count <> 0 Then
                    Me.GridView2.DataSource = tabla
                    Me.GridView2.DataBind()
                Else
                    Me.GridView2.DataSource = Nothing
                    Me.GridView2.DataBind()
                End If
            End With
        End If
    End Sub

    Function mostrarEncabezadoRemision() As String
        Dim encontrada As String = "no"
        Dim tabla As New DataTable
        With encabezadoRemision
            .idEncFacturaPro = Me.TextBox1.Text
            tabla = .obtenerDatosEncabezadoRemision
            If tabla.Rows.Count <> 0 Then
                Me.TextBox2.Text = tabla.Rows(0).Item("idencfacturapro")
                Me.TextBox3.Text = CDate(tabla.Rows(0).Item("fechaencfacturapro")).ToString("yyyy/MM/dd")
                Me.TextBox4.Text = tabla.Rows(0).Item("codigoafiliado")
                Me.TextBox5.Text = tabla.Rows(0).Item("nombres")
                Me.TextBox6.Text = tabla.Rows(0).Item("nombreempresa")
                Me.TextBox7.Text = tabla.Rows(0).Item("nombresucursal")
                Me.TextBox8.Text = tabla.Rows(0).Item("tipoEncFacturaPro")
                Me.TextBox9.Text = tabla.Rows(0).Item("puntosencfacturapro")
                Me.TextBox31.Text = tabla.Rows(0).Item("idempresa")
                Me.TextBox32.Text = tabla.Rows(0).Item("idsucursal")
                Me.TextBox30.Text = tabla.Rows(0).Item("nombreCompletoUsuario")
                'Me.TextBox10.Text = FormatNumber(tabla.Rows(0).Item("valorCoencfacturapro"), 0)
                ' forma de pago efectivo
                If tabla.Rows(0).Item("fpEfectivoencfacturapro") = "S" Then
                    Me.Label2.Text = "[X]"
                    Me.TextBox11.Text = FormatNumber(tabla.Rows(0).Item("valorEfectivoencfacturapro"), 0)
                Else
                    Me.Label2.Text = ""
                    Me.TextBox11.Text = "0"
                End If
                '
                ' cruce
                If tabla.Rows(0).Item("fpcruceencfacturapro") = "S" Then
                    Me.Label3.Text = "[X]"
                    Me.TextBox12.Text = FormatNumber(tabla.Rows(0).Item("valorCruceencfacturapro"), 0)

                Else
                    Me.Label3.Text = ""
                    Me.TextBox12.Text = "0"
                End If
                '
                ' abono hotel
                If tabla.Rows(0).Item("fphotelencfacturapro") = "S" Then
                    Me.Label4.Text = "[X]"
                    Me.TextBox13.Text = FormatNumber(tabla.Rows(0).Item("valorHotelencfacturapro"), 0)

                Else
                    Me.Label4.Text = ""
                    Me.TextBox13.Text = "0"

                End If
                '
                ' consignacion
                If tabla.Rows(0).Item("fpconsigencfacturapro") = "S" Then
                    Me.Label5.Text = "[X]"
                    Me.TextBox14.Text = FormatNumber(tabla.Rows(0).Item("valorConsigencfacturapro"), 0)
                Else
                    Me.Label5.Text = ""
                    Me.TextBox14.Text = "0"

                End If
                '
                ' tarjeta
                If tabla.Rows(0).Item("fpTarjetaEncFaturaPro") = "S" Then
                    Me.Label6.Text = "[X]"
                    Me.TextBox15.Text = FormatNumber(tabla.Rows(0).Item("valorusencfacturapro"), 0)

                Else
                    Me.Label6.Text = ""
                    Me.TextBox15.Text = "0"

                End If
                '
                'estado
                If tabla.Rows(0).Item("estadoEncFacturaPro") = 1 Then
                    Me.TextBox33.Text = "Activa"
                Else
                    Me.TextBox33.Text = "Eliminada"
                End If
                ' paquete
                Me.TextBox34.Text = tabla.Rows(0).Item("paqueteEncFacturaPro")
                Me.ImageButton9.Visible = True
                encontrada = "si"
            Else
                Me.Panel7.Visible = False
                Me.TextBox2.Text = ""
                Me.TextBox3.Text = ""
                Me.TextBox4.Text = ""
                Me.TextBox5.Text = ""
                Me.TextBox6.Text = ""
                Me.TextBox7.Text = ""
                Me.TextBox8.Text = ""
                Me.TextBox9.Text = ""
                Me.TextBox11.Text = ""
                Me.TextBox12.Text = ""
                Me.TextBox13.Text = ""
                Me.TextBox14.Text = ""
                Me.TextBox15.Text = ""
                Me.TextBox31.Text = ""
                Me.TextBox32.Text = ""
                Me.TextBox21.Text = ""
                Me.TextBox22.Text = ""
                Me.TextBox23.Text = ""
                Me.TextBox24.Text = ""
                Me.TextBox25.Text = ""
                Me.TextBox26.Text = ""
                Me.TextBox27.Text = ""
                Me.TextBox28.Text = ""
                Me.TextBox29.Text = ""
                Me.TextBox30.Text = ""
                Me.TextBox33.Text = ""
                '
                Me.GridView2.DataSource = Nothing
                Me.GridView5.DataSource = Nothing
                '
                Me.GridView2.DataBind()
                Me.GridView5.DataBind()
                '
                Me.ImageButton9.Visible = False
                '
                Me.Label2.Text = ""
                Me.Label3.Text = ""
                Me.Label4.Text = ""
                Me.Label5.Text = ""
                Me.Label6.Text = ""
                Me.Label7.Text = ""
                '
                Me.TextBox1.Focus()
                '
                Me.Label7.Text = "Remision no existe en el sistema...!"
                encontrada = "no"
            End If
        End With
        Return encontrada
    End Function

    Protected Sub ImageButton9_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
        Me.Label7.Text = ""
        Dim fechaCorrecta As String
        fechaCorrecta = validaFechaCierre()
        If fechaCorrecta = "no" Then
            Me.Label7.Text = "Esta remisión no se puede anular...!"
            Exit Sub
        End If
        '
        If Me.TextBox33.Text = "Eliminada" Then
            Me.Label7.Text = "esta remisión ya está eliminada...!"
            Exit Sub
        End If
        ' valida si la remision tiene consignaciones y no estan cargadas
        Dim encontrada As String = validaConsignacion(Me.TextBox1.Text)
        If encontrada = "no" Then
            Me.Label7.Text = "La relacion de la consignacion y la remision no está cargada correctamente...!"
            Exit Sub
        End If
        Me.Panel7.Visible = True
        Me.ImageButton9.Visible = False
    End Sub

    Function validaConsignacion(ByVal numeroRemision As Integer) As String
        Dim encontrada As String = ""
        Dim formaPago As String = ""
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select fpconsigEncfacturapro from ttEncFacturapro where idEncFacturaPro=" & numeroRemision
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                formaPago = tabla.Rows(0).Item("fpconsigEncfacturapro")
            End If
        End With
        'busca si la consignacion esta cargada
        If formaPago = "S" Then
            sql = "select * from ttfacturaconsig where idencfacturapro=" & numeroRemision
            With operaciones
                tabla = .DevuelveDato(sql)
                If tabla.Rows.Count <> 0 Then
                    encontrada = "si"
                Else
                    encontrada = "no"
                End If
            End With
        End If
        Return encontrada
    End Function

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            nuevo()
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim y As Integer
        Dim sql As String
        Dim tabla As New DataTable
        sql = "exec sp_anularRemisiones '" & Me.TextBox1.Text & "'"
        With operaciones
            .Accion(sql)
        End With
        '' grabar el log de las anulaciones saber quien anuló
        'sql = "INSERT INTO [TTLogAnulacionesRemisiones]" & _
        '   "([idEncfacturaPro]" & _
        '   ",[idUsuario]" & _
        '   ",[fecha])" & _
        '   " VALUES ('" & _
        '   Me.TextBox2.Text & "','" & _
        '   Session("idUsuario") & "','" & _
        '   Now.Date.ToString("yyyy/MM/dd") & _
        '   "')"
        'With operaciones
        '    .Accion(sql)
        'End With
        '' anular encabezado remision
        'sql = "update ttencfacturapro set estadoEncFacturaPro=0 where idEncFacturaPro=" & Me.TextBox2.Text
        'With operaciones
        '    .Accion(sql)
        'End With
        '' Reversar las existencias
        'sql = "select * from TTDetFacturaPro where idEncfacturaPro=" & Me.TextBox2.Text
        'With operaciones
        '    tabla = .DevuelveDato(sql)
        '    If tabla.Rows.Count <> 0 Then
        '        For y = 0 To tabla.Rows.Count - 1
        '            sql = "exec sp_actualizaTTBodPuntoProductoAumentaExistencias " & _
        '            "@idProducto='" & tabla.Rows(y).Item("idProducto") & "'," & _
        '            "@idSucursal='" & Me.TextBox32.Text & "'," & _
        '            "@idEmpresa='" & Me.TextBox31.Text & "'," & _
        '            "@cantBodPuntoProducto='" & tabla.Rows(y).Item("cantidadDetFacturaPro") & "'"
        '            With operaciones
        '                .Accion(sql)
        '            End With
        '        Next
        '    End If
        'End With
        '' devuelve el proceso en linea
        'procesoEnLinea(Me.TextBox4.Text)
        '' reversar apartados
        'reversarApartados()
        'reversarpagoConsignacion()
        'reversapagoIR()
        'reversarPaqueteAfiliado()
        'reversarPagoTarjetas()
        '' actualiza si la remision que esta anulando es paquete base
        'actualizaPaqueteBase()
        nuevo()
        mostrarVentana()
    End Sub

    Sub procesoEnLinea(ByVal codigoAfiliado As String)
        'Obtener los parametros
        Dim facini As New clsNuevoPlan
        Dim afil As New clsNuevoPlan
        Dim rectabla As New DataTable
        Dim rectablafac As New DataTable
        Dim rectablaafi As New DataTable
        Dim reccompra As New DataTable
        Dim nivel As Integer
        Dim codigo As String
        Dim sts As String = ""
        Dim puntos As Double
        Dim patro As String = ""
        Dim sql As String
        Dim tabla As New DataTable
        ' obtener el patrocinador del afiliado
        sql = "select codigoPatrocinador from afiliaciones where codigoAfiliado='" & codigoAfiliado & "'"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                codigo = codigoAfiliado 'tabla.Rows(0).Item("codigoafiliado")
                patro = tabla.Rows(0).Item("codigopatrocinador")
            End If
        End With
        'Traer la facturacion
        sql = "exec sp_ttEncFacturaProTraeFacturacionNuevoPlan '" & codigoAfiliado & "'"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                puntos = tabla.Rows(0).Item("numtsEncfacturapro")
                sts = tabla.Rows(0).Item("stsEncfacturaPro")
            End If
        End With
        nivel = 1
        'Actualizar la compra en los grupales
        Dim recgrupalc As New clsNuevoPlan ' ClsGrupalts
        recgrupalc.codigoafiliado = codigoAfiliado
        recgrupalc.compragrupal = puntos
        'recgrupalc.mesgrupal = Me.DropDownList22.SelectedValue ' Month(DTPFechaf.Text)
        'recgrupalc.anogrupal = Me.DropDownList21.SelectedItem.Text 'Year(DTPFechaf.Text)
        Dim tablagrupalc As New DataTable
        tablagrupalc = recgrupalc.obtenergrupal
        If sts = "no" Then
            If tablagrupalc.Rows(0).Item("grupal") = 0 Then
                'insert
                recgrupalc.insertacomprag()
            Else
                'update
                recgrupalc.actualizarcomprag()
            End If
        Else
            If tablagrupalc.Rows(0).Item("grupal") = 0 Then
                'insert
                recgrupalc.insertasupercomprag()
            Else
                'update
                recgrupalc.actualizarsupercomprag()
            End If
        End If
        'ciclo
        While patro <> "0" And nivel <= 20
            'buscar compra del patrocinador 
            facini.vcodigoafiliado = patro
            Dim recgrupal As New clsNuevoPlan ' ClsGrupalts
            recgrupal.codigoafiliado = patro
            recgrupal.compragrupal = puntos
            recgrupal.puntogrupal = puntos
            'recgrupal.mesgrupal = Me.DropDownList22.SelectedValue
            'recgrupal.anogrupal = Me.DropDownList21.SelectedItem.Text
            recgrupal.nivel = nivel
            Dim tablagrupal As New DataTable
            tablagrupal = recgrupal.obtenergrupal
            If tablagrupal.Rows(0).Item("grupal") = 0 Then
                'insert
                recgrupal.insertargrupal()
            Else
                'update
                recgrupal.actualizargrupal()
            End If
            'Subir el nivel
            nivel = nivel + 1
            'buscar patrocinador
            afil.vcodigoafiliado = patro
            rectablaafi = afil.obtenerpatrocinador
            patro = rectablaafi.Rows(0).Item("codigopatrocinador")
        End While
    End Sub

    Sub actualizaPaqueteBase()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from tbpaquete where idpaquete=" & Me.TextBox34.Text
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                If tabla.Rows(0).Item("paqueteBase") = "si" Then
                    sql = "update afiliaciones set fechainicioir = Null,fechafinircorto = Null, fechafinirlargo = Null, paquete = 'no'  where codigoafiliado = '" & Me.TextBox4.Text & "'"
                    With operaciones
                        .Accion(sql)
                    End With
                End If
            End If
        End With
    End Sub

    Function validaFechaCierre() As String
        Dim fechaCorrecta As String = "si"
        Dim tabla As New DataTable
        With fechasCierre
            tabla = .mostrarFechas
            If tabla.Rows.Count <> 0 Then
                If Me.TextBox3.Text < CDate(tabla.Rows(0).Item("fechaInicio")).ToString("yyyy/MM/dd") Then
                    fechaCorrecta = "no"
                Else
                    fechaCorrecta = "si"
                End If
            End If
        End With
        Return fechaCorrecta
    End Function

    Sub nuevo()
        Me.Panel7.Visible = False
        Me.TextBox34.Text = ""
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox4.Text = ""
        Me.TextBox5.Text = ""
        Me.TextBox6.Text = ""
        Me.TextBox7.Text = ""
        Me.TextBox8.Text = ""
        Me.TextBox9.Text = ""
        Me.TextBox11.Text = ""
        Me.TextBox12.Text = ""
        Me.TextBox13.Text = ""
        Me.TextBox14.Text = ""
        Me.TextBox15.Text = ""
        Me.TextBox31.Text = ""
        Me.TextBox32.Text = ""
        Me.TextBox21.Text = ""
        Me.TextBox22.Text = ""
        Me.TextBox23.Text = ""
        Me.TextBox24.Text = ""
        Me.TextBox25.Text = ""
        Me.TextBox26.Text = ""
        Me.TextBox27.Text = ""
        Me.TextBox28.Text = ""
        Me.TextBox29.Text = ""
        Me.TextBox30.Text = ""
        Me.TextBox33.Text = ""
        '
        Me.GridView2.DataSource = Nothing
        Me.GridView5.DataSource = Nothing
        '
        Me.GridView2.DataBind()
        Me.GridView5.DataBind()
        '
        Me.ImageButton9.Visible = False
        '
        Me.Label2.Text = ""
        Me.Label3.Text = ""
        Me.Label4.Text = ""
        Me.Label5.Text = ""
        Me.Label6.Text = ""
        Me.Label7.Text = ""
        '
        Me.TextBox1.Focus()
    End Sub

    Sub mostrarVentana()
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('Remisión Anulada Satisfactoriamente...!');", True)
    End Sub

    Sub reversapagoIR()
        With comisionesIr
            .idEncfacturaPro = Me.TextBox2.Text
            .reversarPagoComisionIR()
        End With
    End Sub

    Sub anulaEncabezadoRemision()
        '---------------------------------------------------------------------
        ' anula la remision en el encabezado factura
        With encabezadoRemision
            .idEncFacturaPro = Me.TextBox2.Text
            .AnularFacturas()
        End With
        '---------------------------------------------------------------------
    End Sub

    Sub reversarExistenciasProductos()
        Dim y As Integer
        ' reversar las existencias productos
        If Me.GridView2.Rows.Count <> 0 Then
            For y = 0 To Me.GridView2.Rows.Count - 1
                With bodegaSucursal
                    .idProducto = Me.GridView2.Rows(y).Cells(0).Text
                    .idSucursal = Me.TextBox32.Text
                    .idEmpresa = Me.TextBox31.Text
                    .cantBodPuntoProducto = Me.GridView2.Rows(y).Cells(2).Text
                    .aumentaExistenciasBodegaPunto()
                End With
            Next
        End If
        '---------------------------------------------------------------------
        
    End Sub

    Sub reversarApartados()
        '---------------------------------------------------------------------
        ' reversar los numeros de los apartados
        If Me.TextBox21.Text <> "" Or Me.TextBox22.Text <> "" Or Me.TextBox23.Text <> "" Then
            ' recibo 1
            If Me.TextBox21.Text <> "" Then
                With apartados
                    .idRecibo = Me.TextBox21.Text
                    .actualizaReciboFacturadoNo()
                End With
            End If
            ' recibo 2
            If Me.TextBox22.Text <> "" Then
                With apartados
                    .idRecibo = Me.TextBox22.Text
                    .actualizaReciboFacturadoNo()
                End With
            End If
            ' recibo 3
            If Me.TextBox23.Text <> "" Then
                With apartados
                    .idRecibo = Me.TextBox23.Text
                    .actualizaReciboFacturadoNo()
                End With
            End If
            '---------------------------------------------------------------------
            '---------------------------------------------------------------------
            ' elimina la relacion recibo factura (ttrecibofactura)
            With reciboFactura
                .idEncFacturaPro = Me.TextBox2.Text
                .eliminaRecibofactura()
            End With
            '---------------------------------------------------------------------
        End If
    End Sub

    Sub reversarpagoConsignacion()
        '---------------------------------------------------------------------
        ' reversa el pago con consignaciones
        If Me.GridView5.Rows.Count <> 0 Then
            For y = 0 To Me.GridView5.Rows.Count - 1
                ' reversar el pago del valor utilizado
                With consignaciones
                    .idConsignacion = Me.GridView5.Rows(y).Cells(1).Text
                    .reversarValorUtilizado(Me.GridView5.Rows(y).Cells(4).Text)
                End With
                ' elimina el registro
                With facturaConsig
                    .idFacturaConsig = Me.GridView5.Rows(y).Cells(0).Text
                    .eliminaRegistroFacturaConsig()
                End With
                '
            Next
        End If
        '---------------------------------------------------------------------
    End Sub

    Sub anularKitDeAfiliacion()
        Dim tabla As New DataTable
        anulaEncabezadoRemision()
        '---------------------------------------------------------------------
        ' reversar el campo de kit en la tabla de afiliaciones
        With afiliados
            .codigoAfiliado = Me.TextBox4.Text
            .actualizaCampoKitAfiliaciones()
        End With
        '---------------------------------------------------------------------
        reversarExistenciasProductos()
        reversarApartados()
        '---------------------------------------------------------------------
        ' reversar el pago de la comision
        Dim encontrada As String
        Dim idComisionKit As Integer
        Dim valorComisionKit As Double
        With detalleComisionKit
            .idEncFacturaPro = Me.TextBox2.Text
            tabla = .obtenerDetalleComisionPorIdRemision
            If tabla.Rows.Count <> 0 Then
                idComisionKit = tabla.Rows(0).Item("idComisionKit")
                valorComisionKit = tabla.Rows(0).Item("valordetComidionkit")
                encontrada = "si"
            Else
                encontrada = "no"
            End If
        End With
        ' descuenta el pago
        If encontrada = "si" Then
            With comisionKit
                .idComisionKit = idComisionKit
                .descuentaValorComision(valorComisionKit)
            End With
        End If
        '---------------------------------------------------------------------
        ' elimina el registro el detalle de la comision
        With detalleComisionKit
            .idComisionKit = idComisionKit
            .eliminaRegistroDetalleComision()
        End With
        '---------------------------------------------------------------------
        reversarpagoConsignacion()
        reversarPagoTarjetas()
    End Sub

    Sub reversarPagoTarjetas()
        Dim y As Integer
        If Me.GridView8.Rows.Count <> 0 Then
            For y = 0 To Me.GridView8.Rows.Count - 1
                With facturasTarjetas
                    .idEncFacturapro = Me.TextBox2.Text
                    .idTarjeta = Me.GridView8.Rows(y).Cells(0).Text
                    .reversarPagoTarjetas()
                End With
            Next
        End If
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        nuevo()
    End Sub

    Sub reversarPaqueteAfiliado()
        Dim tabla As New DataTable
        '------------------------------------------------------------------------------------
        ' reversar el paquete del afiliado
        Dim codigoPaquete As Integer
        ' busca el paquete
        With encabezadoRemision
            .idEncFacturaPro = Me.TextBox2.Text
            tabla = .obtenerDatosEncabezadoFacturaPorIdEncabezado
            If tabla.Rows.Count <> 0 Then
                codigoPaquete = tabla.Rows(0).Item("paqueteEncfacturaPro")
            Else
                codigoPaquete = 0
            End If
        End With
        '--------------------------------------------
        Dim paqueteInicial As Integer
        'obtener el paquete inicial
        If codigoPaquete <> 0 Then
            With paquete
                .idPaquete = codigoPaquete
                tabla = .obtienePaqueteFinal
                If tabla.Rows.Count <> 0 Then
                    If tabla.Rows(0).Item("paqInicial") = tabla.Rows(0).Item("paqFinal") Then
                        paqueteInicial = 0
                    Else
                        paqueteInicial = tabla.Rows(0).Item("paqInicial")
                    End If
                Else
                    paqueteInicial = 0
                End If
            End With
        End If
        '------------------------------------------------------------------------------------
        '------------------------------------------------------------------------------------
        ' actuliza el paquete del afiiado
        With afiliados
            .codigoAfiliado = Me.TextBox4.Text
            .idPaquete = paqueteInicial
            .actualizarIdPaquete()
        End With
        '------------------------------------------------------------------------------------
    End Sub

    Protected Sub Button3_Click(sender As Object, e As System.EventArgs) Handles Button3.Click
        Me.MultiView1.ActiveViewIndex = 0
    End Sub

    Protected Sub Button4_Click(sender As Object, e As System.EventArgs) Handles Button4.Click
        Me.MultiView1.ActiveViewIndex = 1
    End Sub
End Class
