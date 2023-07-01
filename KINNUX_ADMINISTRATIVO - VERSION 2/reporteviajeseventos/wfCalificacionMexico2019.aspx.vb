﻿Imports System.Data
Imports System.IO

Partial Class Reportes_Varios_wfCalificacionMexico2019
    Inherits System.Web.UI.Page

    Dim calificacionCartagena As New clsTtCalifCartagena
    Dim paises As New clsPaise
    Dim operaciones As New clsOperacione

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarempresas()
            Me.ImageButton2.Visible = False
            Me.Panel1.Visible = False
            Me.Panel2.Visible = False
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    Sub cargarempresas()
        Dim tabla As New DataTable
        With operaciones
            .cargarCombos(Me.DropDownList1, "select * from tbempresa", "idpais", "nombreempresa", "Todas las Empresas")
        End With
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Label4.Text = ""
        Me.GridView2.DataSource = Nothing
        Me.GridView2.DataBind()
        Dim encontroDatos As String = mostrarDatos()

    End Sub

    Function mostrarDatos() As String
        Me.Panel1.Visible = False
        Me.Panel2.Visible = False
        '
        Dim encontroDatos As String = "no"
        Me.ImageButton2.Visible = False
        Dim tabla As New DataTable
        Dim codigoPais As Integer
        If Me.DropDownList1.SelectedIndex = 0 Then
            codigoPais = 0
        Else
            codigoPais = Me.DropDownList1.SelectedValue
        End If
        With calificacionCartagena
            .codigoPais = codigoPais
            tabla = .obtenerDatosCalificacionMexico2019
            If tabla.Rows.Count <> 0 Then
                Me.Panel1.Visible = True
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
                '
                Me.GridView2.Caption = "Calificacion Mexico<br>" & Me.DropDownList1.SelectedItem.Text
                Me.ImageButton2.Visible = True
                encontroDatos = "si"
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
                encontroDatos = "no"
            End If
        End With
        Return encontroDatos
    End Function

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        'panelDatos.Visible = False
        If Me.GridView2.Rows.Count <> 0 Then
            ExportToExcel("mexico2019.xls", Me.GridView2)
        Else

        End If

    End Sub

    Private Sub ExportToExcel(ByVal nameReport As String, ByVal wControl As GridView)
        Me.GridView2.Columns(0).Visible = False
        Dim responsePage As HttpResponse = Response
        Dim sw As New StringWriter()
        Dim htw As New HtmlTextWriter(sw)
        Dim pageToRender As New Page()
        Dim form As New HtmlForm()
        form.Controls.Add(wControl)
        pageToRender.Controls.Add(form)
        responsePage.Clear()
        responsePage.Buffer = True
        responsePage.ContentType = "application/vnd.ms-excel"
        responsePage.AddHeader("Content-Disposition", "attachment;filename=" & nameReport)
        responsePage.Charset = "UTF-8"
        responsePage.ContentEncoding = Encoding.Default
        pageToRender.RenderControl(htw)
        responsePage.Write(sw.ToString())
        responsePage.End()
    End Sub

    Protected Sub GridView2_SelectedIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        mostrarDetalle(Me.GridView2.Rows(e.NewSelectedIndex).Cells(1).Text)
    End Sub

    Sub mostrarDetalle(ByVal codigoAfiliado As String)
        Me.Label7.Text = ""
        Me.Panel2.Visible = True
        Dim tabla As New DataTable
        With calificacionCartagena
            .codigoAfiliado = codigoAfiliado
            tabla = .obtenerDetalleAfiliadomexico
            If tabla.Rows.Count <> 0 Then
                Me.Panel2.Visible = True
                Me.GridView3.DataSource = tabla
                Me.GridView3.DataBind()

            Else
                Me.Label7.Text = "No existen detalle...!"
                Me.GridView3.DataSource = Nothing
                Me.GridView3.DataBind()
            End If
            Me.TextBox1.Focus()
        End With
    End Sub

    Protected Sub GridView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView2.SelectedIndexChanged

    End Sub
End Class
