Imports System.Data

Partial Class Reportes_wfPedidos
    Inherits System.Web.UI.Page

    Dim encabezadoDespacho As New clsTTEncDesProductoPaisPais
    Dim detalleDespacho As New clsTTDetDesproductoPais
    Dim empresas As New clsEmpresa
    Dim sucursales As New clsSucursale

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            Me.TextBox1.Text = Now.Date.ToString("yyyy/MM/dd")
            Me.TextBox2.Text = Now.Date.ToString("yyyy/MM/dd")
            Me.ImageButton8.Visible = False
            Me.RadioButton1.Checked = True
            cargarEmpresas()
            Me.Panel5.Visible = False
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
                Me.DropDownList1.DataTextField = "nombreempresa"
                Me.DropDownList1.DataValueField = "idempresa"
                Me.DropDownList1.DataBind()
                '
                Me.DropDownList2.DataSource = tabla
                Me.DropDownList2.DataTextField = "nombreempresa"
                Me.DropDownList2.DataValueField = "idempresa"
                Me.DropDownList2.DataBind()

            Else
                Me.DropDownList1.DataSource = Nothing
                Me.DropDownList1.DataBind()
                '
                Me.DropDownList2.DataSource = Nothing
                Me.DropDownList2.DataBind()

            End If
            Me.DropDownList1.Items.Insert(0, "Seleccione Empresa Que Envia")
            Me.DropDownList2.Items.Insert(0, "Seleccione Empresa Que Recibe")

        End With
    End Sub

    Protected Sub ImageButton7_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
        Dim tipo As Integer
        Me.GridView6.DataSource = Nothing
        Me.GridView6.DataBind()
        Me.Panel5.Visible = False
        '
        With encabezadoDespacho
            .idEmpresaEnv = Me.DropDownList1.SelectedValue
            .idEmpresaRec = Me.DropDownList2.SelectedValue
            .fechaInicial = Me.TextBox1.Text
            .fechaFinal = Me.TextBox2.Text
            If Me.RadioButton1.Checked = True Then
                tipo = 1
            Else
                If Me.RadioButton2.Checked = True Then
                    tipo = 2
                Else
                    If Me.RadioButton3.Checked = True Then
                        tipo = 3
                    Else
                        If Me.RadioButton4.Checked = True Then
                            tipo = 4
                        Else
                            If Me.RadioButton7.Checked = True Then
                                tipo = 5
                            End If
                        End If
                    End If
                End If
            End If
            '
            Dim tabla As New DataTable
            Me.Panel5.Visible = True
            tabla = .obtenerDespachosPorEmpresas(tipo)
            If tabla.Rows.Count <> 0 Then
            Me.GridView5.DataSource = tabla
            Me.GridView5.DataBind()
            Me.ImageButton8.Visible = True
        Else
            Me.GridView5.DataSource = Nothing
            Me.GridView5.DataBind()
            Me.ImageButton8.Visible = False
        End If
        End With
    End Sub

    Protected Sub GridView5_SelectedIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView5.SelectedIndexChanging
        mostrarDetalleDespacho(Me.GridView5.Rows(e.NewSelectedIndex).Cells(1).Text)
    End Sub

    Sub mostrarDetalleDespacho(ByVal idPedido As Integer)
        Me.GridView6.DataSource = Nothing
        Me.GridView6.DataBind()
        '
        Dim tabla As New DataTable
        With detalleDespacho
            .idEncDesProductoPais = idPedido
            tabla = .detalleDespacho
            If tabla.Rows.Count <> 0 Then
                Me.GridView6.DataSource = tabla
                Me.GridView6.DataBind()
            Else
                Me.GridView6.DataSource = Nothing
                Me.GridView6.DataBind()
            End If
        End With
    End Sub

    

End Class
