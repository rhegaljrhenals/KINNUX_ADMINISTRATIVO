Imports System.IO
Imports System.Data

Partial Class Reportes_Bodega_Principal_wfRepentradasDeProductos
    Inherits System.Web.UI.Page

    'Dim entradaProducto As New clsTTEncEntProductoBod
    Dim despachos As New clsTTEncDesProductoPais
    Dim empresas As New clsEmpresa

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarEmpresas()
            Me.TextBox1.Text = Now.Date.ToString("yyyy/MM/dd")
            Me.TextBox2.Text = Now.Date.ToString("yyyy/MM/dd")
            Me.Panel3.Visible = False
            Me.Panel4.Visible = False
            '
            Me.RadioButton2.Checked = True
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub cargarEmpresas()
        Dim tabla As New DataTable
        With empresas
            tabla = .MostrarEmpresaGeneral
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList1.DataSource = tabla
                Me.DropDownList1.DataTextField = "nombreEmpresa"
                Me.DropDownList1.DataValueField = "idEmpresa"
                Me.DropDownList1.DataBind()
            Else
                Me.DropDownList1.DataSource = Nothing
                Me.DropDownList1.DataBind()
            End If
        End With
    End Sub

    Protected Sub GridView2_SelectedIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        Me.Panel4.Visible = False
        Dim tabla As New DataTable
        With despachos
            .idEncDesProductoPais = Me.GridView2.Rows(e.NewSelectedIndex).Cells(1).Text
            tabla = .detalleDespacho
            If tabla.Rows.Count <> 0 Then
                Me.Panel4.Visible = True
                Me.GridView3.DataSource = tabla
                Me.GridView3.DataBind()
            Else
                Me.GridView3.DataSource = Nothing
                Me.GridView3.DataBind()
            End If
        End With
    End Sub

    Protected Sub ImageButton7_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
        Dim tipo As Integer
        Dim tabla As New DataTable
        '
        Me.Panel3.Visible = False
        Me.Panel4.Visible = False

        'Me.GridView2.DataSource = Nothing
        'Me.GridView2.DataBind()
        ''
        'Me.GridView3.DataSource = Nothing
        'Me.GridView3.DataBind()
        ''
        If Me.RadioButton2.Checked = True Then
            tipo = 1
        Else
            If Me.RadioButton3.Checked = True Then
                tipo = 2
            Else
                If Me.RadioButton4.Checked = True Then
                    tipo = 3
                Else
                    If Me.RadioButton5.Checked = True Then
                        tipo = 4
                    End If
                End If
            End If
        End If
        With despachos
            .fechaInicial = Me.TextBox1.Text
            .fechaFinal = Me.TextBox2.Text
            .IdEmpresa = Me.DropDownList1.SelectedValue
            tabla = .obtenerDespachos(tipo)
            If tabla.Rows.Count <> 0 Then
                Me.Panel3.Visible = True
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End With
    End Sub
End Class
