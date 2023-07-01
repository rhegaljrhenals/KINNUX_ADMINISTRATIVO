Imports System.Data

Partial Class Reportes_Varios_wfReporteTTBBinario
    Inherits System.Web.UI.Page

    Dim objTTBbinario As New clsTTBBinario
    Dim grupalBinario As New clsTTGrupalbinario
    Dim detalleGrupalBinario As New clsTTDetGrupalBinario

    Protected Sub ImageButton9_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
        Dim tabla As New DataTable
        With grupalBinario
            .mesSeleccionado = Me.DropDownList10.SelectedValue
            .anoSeleccionado = Me.DropDownList9.SelectedItem.Text
            tabla = .obtenerTotalesPorSemanas
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End With
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            Me.panelDatos.Visible = False
            cargarAno()
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub cargarAno()
        Dim y As Integer
        For y = 2012 To Now.Year
            Me.DropDownList9.Items.Add(y)
        Next
    End Sub

    Protected Sub GridView2_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        Dim tabla As New DataTable
        Me.panelDatos.Visible = False
        With grupalBinario
            .fechaInicial = Me.GridView2.Rows(e.NewSelectedIndex).Cells(3).Text
            .fechaFinal = Me.GridView2.Rows(e.NewSelectedIndex).Cells(4).Text
            tabla = .obtenerDatosPorSemanas
            If tabla.Rows.Count <> 0 Then
                Me.GridView4.DataSource = tabla
                Me.GridView4.DataBind()
            Else
                Me.GridView4.DataSource = Nothing
                Me.GridView4.DataBind()
            End If
        End With
    End Sub

    Protected Sub GridView4_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView4.SelectedIndexChanging
        Dim codigoPatrocinador As String = ""
        Dim tabla As New DataTable
        '
        Me.Label4.Text = "(" & Me.GridView4.Rows(e.NewSelectedIndex).Cells(1).Text & ") " & Me.GridView4.Rows(e.NewSelectedIndex).Cells(2).Text
        Me.Label5.Text = Me.GridView4.Rows(e.NewSelectedIndex).Cells(5).Text & " - " & Me.GridView4.Rows(e.NewSelectedIndex).Cells(6).Text
        '
        '------------------------------------------------------------------------------------
        With detalleGrupalBinario
            .codigoAfiliado = Me.GridView4.Rows(e.NewSelectedIndex).Cells(1).Text
            .fechaInicial = Me.GridView4.Rows(e.NewSelectedIndex).Cells(5).Text
            .fechaFinal = Me.GridView4.Rows(e.NewSelectedIndex).Cells(6).Text
            tabla = .obtenerDetalleBinario
            If tabla.Rows.Count <> 0 Then
                Me.GridView3.DataSource = tabla
                Me.GridView3.DataBind()
            Else
                Me.GridView3.DataSource = Nothing
                Me.GridView3.DataBind()
            End If
        End With
        '------------------------------------------------------------------------------------
        ' suma el lado izquierdo
        With detalleGrupalBinario
            .codigoAfiliado = Me.GridView4.Rows(e.NewSelectedIndex).Cells(1).Text
            .fechaInicial = Me.GridView4.Rows(e.NewSelectedIndex).Cells(5).Text
            .fechaFinal = Me.GridView4.Rows(e.NewSelectedIndex).Cells(6).Text
            tabla = .sumarLadoIzquierdoDetalleBinario
            If tabla.Rows.Count <> 0 Then
                Me.TextBox3.Text = tabla.Rows(0).Item("suma")
            End If
        End With
        '------------------------------------------------------------------------------------
        '------------------------------------------------------------------------------------
        ' suma el lado derecho
        With detalleGrupalBinario
            .codigoAfiliado = Me.GridView4.Rows(e.NewSelectedIndex).Cells(1).Text
            .fechaInicial = Me.GridView4.Rows(e.NewSelectedIndex).Cells(5).Text
            .fechaFinal = Me.GridView4.Rows(e.NewSelectedIndex).Cells(6).Text
            tabla = .sumarLadoDerechoDetalleBinario
            If tabla.Rows.Count <> 0 Then
                Me.TextBox4.Text = tabla.Rows(0).Item("suma")
            End If
        End With
        '------------------------------------------------------------------------------------
        Dim ventana As AjaxControlToolkit.ModalPopupExtender = New AjaxControlToolkit.ModalPopupExtender
        ventana.ID = "popUp11"
        Me.panelDatos.Visible = True
        ventana.PopupControlID = "panelDatos"
        ventana.TargetControlID = "HiddenField1"
        ventana.DropShadow = True
        ventana.BackgroundCssClass = "ModalPopupBG"
        ventana.CancelControlID = "Button1"
        Me.panelDatos.Controls.Add(ventana)
        ventana.Show()
    End Sub
End Class
