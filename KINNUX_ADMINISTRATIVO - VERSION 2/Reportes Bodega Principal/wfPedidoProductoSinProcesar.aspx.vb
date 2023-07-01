Imports System.Data

Partial Class Reportes_Bodega_Principal_wfPedidoProductoSinProcesar
    Inherits System.Web.UI.Page

    Dim encabezadoPedido As New clsEncabezadoPedido

    Protected Sub ImageButton6_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton6.Click
        mostrarReporte()
    End Sub

    Sub mostrarReporte()
        Dim tabla As New DataTable
        Dim estado As Integer
        If Me.RadioButton1.Checked = True Then
            estado = 1
        Else
            If Me.RadioButton2.Checked = True Then
                estado = 2
            Else
                If Me.RadioButton3.Checked = True Then
                    estado = 3
                Else
                    If RadioButton4.Checked = True Then
                        estado = 4
                    End If
                End If
            End If
        End If
        '
        'With encabezadoPedido
        '    tabla = .obtenerPedidos(estado)
        '    Me.GridView11.DataSource = tabla
        '    Me.GridView11.DataBind()
        'End With
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then

        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub
End Class
