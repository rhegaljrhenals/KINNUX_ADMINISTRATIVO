Imports System.Data

Partial Class Reportes_Varios_wfComisiones2
    Inherits System.Web.UI.Page

    Dim afiliados As New ClsAfiliado
    Dim comisiones As New clsTTComisionIr
    Dim comisionesKit As New clsTTComisionKit

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            mostrarDatosAfiliados()
            mostrarDetalleComisiones()
            mostrarDetalleComisionesKit()
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    Sub mostrarDetalleComisionesKit()
        Dim tabla As New DataTable
        With comisionesKit
            .codigoAfiliado = Request.QueryString("id")
            tabla = .obtenerDetalleComisionesKirPorAfiliado
            If tabla.Rows.Count <> 0 Then
                Me.GridView3.DataSource = tabla
                Me.GridView3.DataBind()
                Me.Label7.Text = Me.GridView3.Rows.Count & " Registros encontrados...!"
            Else
                Me.GridView3.DataSource = Nothing
                Me.GridView3.DataBind()
                Me.Label7.Text = "No existen Registros de comisión...!"
            End If
        End With
    End Sub

    Sub mostrarDetalleComisiones()
        Dim tabla As New DataTable
        With comisiones
            .codigoAfiliado = Request.QueryString("id")
            tabla = .obtenerDetalleComisionesPorAfiliado
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
                Me.Label6.Text = Me.GridView2.Rows.Count & " Registros encontrados...!"
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
                Me.Label6.Text = "No existen Registros de comisión...!"
            End If
        End With
    End Sub

    Sub mostrarDatosAfiliados()
        Dim tabla As New DataTable
        With afiliados
            .codigoAfiliado = Request.QueryString("id")
            tabla = .obtenerAfiliadoPorCodigoAfiliado
            If tabla.Rows.Count <> 0 Then
                Me.Label4.Text = "(" & tabla.Rows(0).Item("codigoAfiliado") & ")" & tabla.Rows(0).Item("pnombre") & " " & tabla.Rows(0).Item("snombre") & " " & tabla.Rows(0).Item("papellido") & " " & tabla.Rows(0).Item("sapellido")
                If Not IsDBNull(tabla.Rows(0).Item("fechaInicioIr")) Then
                    Me.Label5.Text = "Fechas IR: " & CDate(tabla.Rows(0).Item("fechaInicioIr")).ToString("yyyy/MM/dd") & " - " & CDate(tabla.Rows(0).Item("fechaFinIrCorto")).ToString("yyyy/MM/dd")
                Else
                    Me.Label5.Text = "No tiene fechas de inicio rápido"
                End If
            Else
                Me.Label4.Text = ""
                Me.Label5.Text = ""
            End If
        End With
    End Sub
End Class
