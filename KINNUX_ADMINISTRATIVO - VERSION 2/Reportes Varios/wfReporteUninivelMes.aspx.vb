Imports System.Data

Partial Class Reportes_Varios_wfReporteIRMes
    Inherits System.Web.UI.Page

    Dim comisionMesUn As New clsTTcomisionUn
    Dim paises As New clsPaise
    Dim empresas As New clsEmpresa

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
            'cargarPaises()
            cargarEmpresas()
        End If
    End Sub

    Sub cargarEmpresas()
        Dim tabla As New DataTable
        With empresas
            tabla = .MostrarEmpresaGeneral
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList11.DataSource = tabla
                Me.DropDownList11.DataTextField = "nombreEmpresa"
                Me.DropDownList11.DataValueField = "codigopais"
                Me.DropDownList11.DataBind()
            End If
        End With
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
        Dim sumaNivel1 As Double = 0
        Dim sumaNivel2 As Double = 0
        Dim sumaNivel3 As Double = 0
        Dim sumaNivel4 As Double = 0
        Dim sumaNivel5 As Double = 0
        Dim sumaNivel6 As Double = 0
        Dim sumaTotal As Double = 0
        Dim y As Integer
        For y = 0 To Me.GridView2.Rows.Count - 1
            sumaNivel1 += CDbl(Me.GridView2.Rows(y).Cells(3).Text)
            sumaNivel2 += CDbl(Me.GridView2.Rows(y).Cells(4).Text)
            sumaNivel3 += CDbl(Me.GridView2.Rows(y).Cells(5).Text)
            sumaNivel4 += CDbl(Me.GridView2.Rows(y).Cells(6).Text)
            sumaNivel5 += CDbl(Me.GridView2.Rows(y).Cells(7).Text)
            sumaNivel6 += CDbl(Me.GridView2.Rows(y).Cells(8).Text)
            sumaTotal += CDbl(Me.GridView2.Rows(y).Cells(9).Text)
        Next
        Me.GridView2.FooterRow.Cells(1).Text = "Totales:"
        Me.GridView2.FooterRow.Cells(3).Text = sumaNivel1
        Me.GridView2.FooterRow.Cells(4).Text = sumaNivel2
        Me.GridView2.FooterRow.Cells(5).Text = sumaNivel3
        Me.GridView2.FooterRow.Cells(6).Text = sumaNivel4
        Me.GridView2.FooterRow.Cells(7).Text = sumaNivel5
        Me.GridView2.FooterRow.Cells(8).Text = sumaNivel6
        Me.GridView2.FooterRow.Cells(9).Text = sumaTotal
    End Sub

    Sub mostrarDatos()
        Dim tabla As New DataTable
        With comisionMesUn
            .mesComisionmesUn = Me.DropDownList10.SelectedValue
            .anocomisionmesUn = Me.DropDownList9.SelectedItem.Text
            tabla = .obtenerComisionesUn
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
