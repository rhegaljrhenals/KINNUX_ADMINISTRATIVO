﻿Imports System.Data

Partial Class Reportes_Varios_wfMuestraDetalleFacturaO
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

        'obsequios
        With detalleFactura
            .idEncFacturaPro = Me.TextBox2.Text
            tabla = .obtenerObsequios
            If tabla.Rows.Count <> 0 Then
                Me.GridView3.DataSource = tabla
                Me.GridView3.DataBind()
            Else
                Me.GridView3.DataSource = Nothing
                Me.GridView3.DataBind()
            End If
        End With
        '
        'promociones
        With detalleFactura
            .idEncFacturaPro = Me.TextBox2.Text
            tabla = .obtenerPromociones
            If tabla.Rows.Count <> 0 Then
                Me.GridView4.DataSource = tabla
                Me.GridView4.DataBind()
            Else
                Me.GridView4.DataSource = Nothing
                Me.GridView4.DataBind()
            End If
        End With
    End Sub

    Function mostrarEncabezadoRemision() As String
        Dim encontrada As String = "no"
        Dim tabla As New DataTable
        With encabezadoRemision
            .idEncFacturaPro = Request.QueryString("nr")
            tabla = .obtenerDatosEncabezadoRemision
            If tabla.Rows.Count <> 0 Then
                Me.TextBox2.Text = tabla.Rows(0).Item("idencfacturapro")
                Me.TextBox3.Text = tabla.Rows(0).Item("fechaencfacturapro")
                Me.TextBox4.Text = tabla.Rows(0).Item("codigoafiliado")
                Me.TextBox5.Text = tabla.Rows(0).Item("nombres")
                Me.TextBox6.Text = tabla.Rows(0).Item("nombreempresa")
                Me.TextBox7.Text = tabla.Rows(0).Item("nombresucursal")
                Me.TextBox8.Text = tabla.Rows(0).Item("tipoEncFacturaPro")
                Me.TextBox9.Text = tabla.Rows(0).Item("puntosencfacturapro")
                Me.TextBox31.Text = tabla.Rows(0).Item("idempresa")
                Me.TextBox32.Text = tabla.Rows(0).Item("idsucursal")
                Me.TextBox30.Text = tabla.Rows(0).Item("nombreCompletoUsuario")
                Me.TextBox10.Text = FormatNumber(tabla.Rows(0).Item("valorCoencfacturapro"), 0)
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
                '
                encontrada = "si"
            Else
                Me.TextBox2.Text = ""
                Me.TextBox3.Text = ""
                Me.TextBox4.Text = ""
                Me.TextBox5.Text = ""
                Me.TextBox6.Text = ""
                Me.TextBox7.Text = ""
                Me.TextBox8.Text = ""
                Me.TextBox9.Text = ""
                Me.TextBox10.Text = ""
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
                Me.GridView3.DataSource = Nothing
                Me.GridView4.DataSource = Nothing
                Me.GridView5.DataSource = Nothing
                '
                Me.GridView2.DataBind()
                Me.GridView3.DataBind()
                Me.GridView4.DataBind()
                Me.GridView5.DataBind()
                '
                '
                Me.Label2.Text = ""
                Me.Label3.Text = ""
                Me.Label4.Text = ""
                Me.Label5.Text = ""
                Me.Label6.Text = ""
                '
                '
                encontrada = "no"
            End If
        End With
        Return encontrada
    End Function

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            nuevo()
            mostrarEncabezadoRemision()
            Dim encontrada As String = mostrarEncabezadoRemision()
            If encontrada = "si" Then
                mostrarDetalleFactura()
                mostrarApartados()
                mostrarDatosConsignaciones()
            End If
        End If
    End Sub

    Sub nuevo()
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox4.Text = ""
        Me.TextBox5.Text = ""
        Me.TextBox6.Text = ""
        Me.TextBox7.Text = ""
        Me.TextBox8.Text = ""
        Me.TextBox9.Text = ""
        Me.TextBox10.Text = ""
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
        Me.GridView3.DataSource = Nothing
        Me.GridView4.DataSource = Nothing
        Me.GridView5.DataSource = Nothing
        '
        Me.GridView2.DataBind()
        Me.GridView3.DataBind()
        Me.GridView4.DataBind()
        Me.GridView5.DataBind()
        '
        '
        Me.Label2.Text = ""
        Me.Label3.Text = ""
        Me.Label4.Text = ""
        Me.Label5.Text = ""
        Me.Label6.Text = ""
        '
    End Sub

End Class
