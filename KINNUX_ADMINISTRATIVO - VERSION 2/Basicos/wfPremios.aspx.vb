Imports System.Data

Partial Class Basicos_wfPremios
    Inherits System.Web.UI.Page

    Dim pais As New clsPaise
    Dim linea As New clsLineaArticulo
    Dim objOperacione As New clsOperacione
    Dim premios As New clsPremio

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarPais()
            cargarPremios()
            nuevo()
            Me.panelError.Visible = False
            Me.Panel4.Visible = False
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub cargarPremios()
        Dim tabla As New DataTable
        With premios
            tabla = .obtenerPremios
            Me.GridView2.DataSource = tabla
            Me.GridView2.DataBind()
        End With
    End Sub

    Sub cargarPais()
        Dim tabla As New DataTable
        With pais
            tabla = .MostrarPaise
            Me.DropDownList23.DataSource = tabla
            Me.DropDownList23.DataTextField = "nombrePais"
            Me.DropDownList23.DataValueField = "codigoPais"
            Me.DropDownList23.DataBind()
        End With
        Me.DropDownList23.Items.Insert(0, "Seleccione Pais")
    End Sub

    Protected Sub ImageButton8_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton8.Click
        Dim mensajeError As String = Nothing
        Dim huboError As String = "no"
        Me.panelError.Visible = False
        Me.Label15.Text = ""
        '
        If Me.DropDownList23.SelectedIndex = 0 Or Me.DropDownList23.SelectedIndex = -1 Then
            huboError = "si"
            mensajeError = "- Seleccione el pais"
        End If
        ''
        If Me.TextBox1.Text = "" Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "- Ingrese el nombre del premio"
        End If
        '
        If Me.TextBox3.Text Is Nothing Or Val(Me.TextBox3.Text) <= 0 Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "- ingrese el precio del premio correctamente"
        End If
        ''
        If huboError = "si" Then
            Me.panelError.Visible = True
            Me.Label15.Text = mensajeError
            Exit Sub
        End If
        '
        grabarPremios()
        grabarPremiosPais()
        cargarPremios()
        'ventanaConfirmacion()
        nuevo()
    End Sub

    Sub ventanaConfirmacion()
        Me.Panel4.Visible = False
        Dim ventana As AjaxControlToolkit.ModalPopupExtender = New AjaxControlToolkit.ModalPopupExtender
        ventana.ID = "popUp8"
        Me.Panel4.Visible = True
        ventana.PopupControlID = "Panel4"
        ventana.TargetControlID = "ImageButton8"
        ventana.DropShadow = True
        ventana.BackgroundCssClass = "ModalPopupBG"
        ventana.CancelControlID = "ImageButton9"
        ventana.OkControlID = "Button1"
        Me.Panel4.Controls.Add(ventana)
        ventana.Show()
    End Sub

    Sub nuevo()
        Me.DropDownList23.SelectedIndex = 0
        Me.TextBox1.Text = Nothing
        Me.TextBox3.Text = Nothing
        Me.TextBox7.Text = Nothing
        Me.TextBox8.Text = Nothing
        Me.DropDownList25.SelectedIndex = 0
        Me.panelError.Visible = False
        Session("accion") = 1
        '
        Me.TextBox1.Focus()
    End Sub

    Sub grabarPremios()
        With premios
            If Session("accion") = 1 Then
                .idPremio = 0
            Else
                .idPremio = Val(Me.TextBox7.Text)
            End If
            .nombrePremio = Me.TextBox1.Text.ToUpper
            .precioPremioPais = Me.TextBox3.Text
            .grabarPremio(Session("accion"))
        End With
    End Sub

    Sub grabarPremiosPais()
        With premios
            If Session("accion") = 1 Then
                .idPremioPais = 0
            Else
                .idPremioPais = Val(Me.TextBox8.Text)
            End If
            .precioPremioPais = Me.TextBox3.Text
            .estadoPremioPais = Me.DropDownList25.SelectedValue
            .idPais = Me.DropDownList23.SelectedValue
            .grabarPremioPais(Session("accion"))
        End With
    End Sub

    Protected Sub ImageButton7_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
        nuevo()
    End Sub

    Protected Sub GridView2_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        Me.TextBox7.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(1).Text
        Me.TextBox8.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(3).Text
        '
        Me.DropDownList23.SelectedValue = Me.GridView2.Rows(e.NewSelectedIndex).Cells(6).Text
        Me.TextBox1.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(2).Text
        Me.TextBox3.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(4).Text
        '
        Session("accion") = 2
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Panel4.Visible = False
    End Sub
End Class
