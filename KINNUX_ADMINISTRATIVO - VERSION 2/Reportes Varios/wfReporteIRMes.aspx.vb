Imports System.Data

Partial Class Reportes_Varios_wfReporteIRMes
    Inherits System.Web.UI.Page

    Dim comisionMesIR As New clsTTComisionMesIr
    Dim paises As New clsPaise

    Sub cargarAno()
        Dim y As Integer
        For y = 2012 To Now.Year
            Me.DropDownList9.Items.Add(y)
            Me.DropDownList9.DataValueField = y
        Next
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarAno()
            cargarPaises()
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub cargarPaises()
        Dim tabla As New DataTable
        With paises
            tabla = .MostrarPaise
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList11.DataSource = tabla
                Me.DropDownList11.DataTextField = "nombrepais"
                Me.DropDownList11.DataValueField = "codigopais"
                Me.DropDownList11.DataBind()
            Else
                Me.DropDownList11.DataSource = Nothing
                Me.DropDownList11.DataBind()
            End If
            Me.DropDownList11.Items.Insert(0, "Seleccione Pais")
        End With
    End Sub

    Protected Sub ImageButton9_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
        mostrarDatos()
        calcularTotales()
    End Sub

    Sub calcularTotales()
        Dim sumaNivel2 As Double = 0
        Dim sumaNivel3 As Double = 0
        Dim sumaNivel4 As Double = 0
        Dim sumaNivel5 As Double = 0
        Dim sumaNivel6 As Double = 0
        Dim sumaTotal As Double = 0
        Dim y As Integer
        For y = 0 To Me.GridView2.Rows.Count - 1
            sumaNivel2 += CDbl(Me.GridView2.Rows(y).Cells(3).Text)
            sumaNivel3 += CDbl(Me.GridView2.Rows(y).Cells(4).Text)
            sumaNivel4 += CDbl(Me.GridView2.Rows(y).Cells(5).Text)
            sumaNivel5 += CDbl(Me.GridView2.Rows(y).Cells(6).Text)
            sumaNivel6 += CDbl(Me.GridView2.Rows(y).Cells(7).Text)
            sumaTotal += CDbl(Me.GridView2.Rows(y).Cells(8).Text)
        Next
        Me.GridView2.FooterRow.Cells(1).Text = "Totales:"
        Me.GridView2.FooterRow.Cells(3).Text = sumaNivel2
        Me.GridView2.FooterRow.Cells(4).Text = sumaNivel3
        Me.GridView2.FooterRow.Cells(5).Text = sumaNivel4
        Me.GridView2.FooterRow.Cells(6).Text = sumaNivel5
        Me.GridView2.FooterRow.Cells(7).Text = sumaNivel6
        Me.GridView2.FooterRow.Cells(8).Text = sumaTotal
    End Sub

    Sub mostrarDatos()
        Dim tabla As New DataTable
        With comisionMesIR
            .mesComisionmesir = Me.DropDownList10.SelectedValue
            .anocomisionmesir = Me.DropDownList9.SelectedItem.Text
            tabla = .obtenerComisionesIR
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End With

    End Sub
End Class
