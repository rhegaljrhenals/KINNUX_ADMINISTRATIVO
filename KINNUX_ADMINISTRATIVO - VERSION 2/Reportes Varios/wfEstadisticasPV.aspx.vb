Imports System.Data
Imports System.IO

Partial Class Reportes_Varios_wfReporteProductosFacturados
    Inherits System.Web.UI.Page

    Dim empresas As New clsEmpresa
    Dim encabezadofactura As New clsTTEncFacturaPro
    Dim sucursales As New clsSucursale

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarAno()
            Me.Panel11.Visible = False
            Me.Panel12.Visible = False
            Me.Panel13.Visible = False
        End If
    End Sub

    Sub cargarAno()
        Dim y As Integer
        For y = Now.Year To 2012 Step -1
            Me.DropDownList3.Items.Add(y)
        Next
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Label5.Text = ""
        '
        Me.Panel11.Visible = True
        Me.Panel12.Visible = True
        Me.Panel13.Visible = True
        '
        mostrarPuntosAnualesPorMes()
        mostrarPuntosPorEmpresas()
        mostrarPuntosPorSucursales()

        Me.MultiView1.ActiveViewIndex = 0
    End Sub

    Sub mostrarPuntosAnualesPorMes()
        Dim tabla As New DataTable
        With encabezadofactura
            tabla = .sumaPuntosAnualesPorMes(Me.DropDownList3.SelectedItem.Text)
            If tabla.Rows.Count <> 0 Then
                Me.GridView36.DataSource = tabla
                Me.GridView36.DataBind()
                '
                Me.Chart17.DataSource = tabla
                Me.Chart17.Series(0).XValueMember = "mes"
                Me.Chart17.Series(0).YValueMembers = "cantidad"
                Me.Chart17.DataBind()

            Else
                Me.GridView36.DataSource = Nothing
                Me.GridView36.DataBind()
            End If
        End With
    End Sub

    Sub mostrarPuntosPorEmpresas()
        Dim y As Integer
        Dim tabla As New DataTable
        For y = 1 To 12
            Select Case y
                Case 1
                    With encabezadofactura
                        tabla = .obtenerPuntosAnualesPorEmpresas(y, Me.DropDownList3.SelectedItem.Text)
                        If tabla.Rows.Count <> 0 Then
                            Me.GridView12.DataSource = tabla
                            Me.GridView12.DataBind()
                        Else
                            Me.GridView12.DataSource = Nothing
                            Me.GridView12.DataBind()
                        End If
                    End With
                    '
                Case 2
                    With encabezadofactura
                        tabla = .obtenerPuntosAnualesPorEmpresas(y, Me.DropDownList3.SelectedItem.Text)
                        If tabla.Rows.Count <> 0 Then
                            Me.GridView13.DataSource = tabla
                            Me.GridView13.DataBind()
                        Else
                            Me.GridView13.DataSource = Nothing
                            Me.GridView13.DataBind()
                        End If
                    End With
                    '
                Case 3
                    With encabezadofactura
                        tabla = .obtenerPuntosAnualesPorEmpresas(y, Me.DropDownList3.SelectedItem.Text)
                        If tabla.Rows.Count <> 0 Then
                            Me.GridView14.DataSource = tabla
                            Me.GridView14.DataBind()
                        Else
                            Me.GridView14.DataSource = Nothing
                            Me.GridView14.DataBind()
                        End If
                    End With
                    '
                Case 4
                    With encabezadofactura
                        tabla = .obtenerPuntosAnualesPorEmpresas(y, Me.DropDownList3.SelectedItem.Text)
                        If tabla.Rows.Count <> 0 Then
                            Me.GridView15.DataSource = tabla
                            Me.GridView15.DataBind()
                        Else
                            Me.GridView15.DataSource = Nothing
                            Me.GridView15.DataBind()
                        End If
                    End With
                    '
                Case 5
                    With encabezadofactura
                        tabla = .obtenerPuntosAnualesPorEmpresas(y, Me.DropDownList3.SelectedItem.Text)
                        If tabla.Rows.Count <> 0 Then
                            Me.GridView16.DataSource = tabla
                            Me.GridView16.DataBind()
                        Else
                            Me.GridView16.DataSource = Nothing
                            Me.GridView16.DataBind()
                        End If
                    End With
                    '
                Case 6
                    With encabezadofactura
                        tabla = .obtenerPuntosAnualesPorEmpresas(y, Me.DropDownList3.SelectedItem.Text)
                        If tabla.Rows.Count <> 0 Then
                            Me.GridView17.DataSource = tabla
                            Me.GridView17.DataBind()
                        Else
                            Me.GridView17.DataSource = Nothing
                            Me.GridView17.DataBind()
                        End If
                    End With
                    '
                Case 7
                    With encabezadofactura
                        tabla = .obtenerPuntosAnualesPorEmpresas(y, Me.DropDownList3.SelectedItem.Text)
                        If tabla.Rows.Count <> 0 Then
                            Me.GridView18.DataSource = tabla
                            Me.GridView18.DataBind()
                        Else
                            Me.GridView18.DataSource = Nothing
                            Me.GridView18.DataBind()
                        End If
                    End With
                    '
                Case 8
                    With encabezadofactura
                        tabla = .obtenerPuntosAnualesPorEmpresas(y, Me.DropDownList3.SelectedItem.Text)
                        If tabla.Rows.Count <> 0 Then
                            Me.GridView19.DataSource = tabla
                            Me.GridView19.DataBind()
                        Else
                            Me.GridView19.DataSource = Nothing
                            Me.GridView19.DataBind()
                        End If
                    End With
                    '
                Case 9
                    With encabezadofactura
                        tabla = .obtenerPuntosAnualesPorEmpresas(y, Me.DropDownList3.SelectedItem.Text)
                        If tabla.Rows.Count <> 0 Then
                            Me.GridView20.DataSource = tabla
                            Me.GridView20.DataBind()
                        Else
                            Me.GridView20.DataSource = Nothing
                            Me.GridView20.DataBind()
                        End If
                    End With
                    '
                Case 10
                    With encabezadofactura
                        tabla = .obtenerPuntosAnualesPorEmpresas(y, Me.DropDownList3.SelectedItem.Text)
                        If tabla.Rows.Count <> 0 Then
                            Me.GridView21.DataSource = tabla
                            Me.GridView21.DataBind()
                        Else
                            Me.GridView21.DataSource = Nothing
                            Me.GridView21.DataBind()
                        End If
                    End With
                    '
                Case 11
                    With encabezadofactura
                        tabla = .obtenerPuntosAnualesPorEmpresas(y, Me.DropDownList3.SelectedItem.Text)
                        If tabla.Rows.Count <> 0 Then
                            Me.GridView22.DataSource = tabla
                            Me.GridView22.DataBind()
                        Else
                            Me.GridView22.DataSource = Nothing
                            Me.GridView22.DataBind()
                        End If
                    End With
                    '
                Case 12
                    With encabezadofactura
                        tabla = .obtenerPuntosAnualesPorEmpresas(y, Me.DropDownList3.SelectedItem.Text)
                        If tabla.Rows.Count <> 0 Then
                            Me.GridView23.DataSource = tabla
                            Me.GridView23.DataBind()
                        Else
                            Me.GridView23.DataSource = Nothing
                            Me.GridView23.DataBind()
                        End If
                    End With
            End Select
        Next
    End Sub

    Private Sub ExportToExcel(ByVal nameReport As String, ByVal wControl As GridView)
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

    Sub mostrarPuntosPorSucursales()
        Dim tabla As New DataTable
        With encabezadofactura
            tabla = .obtenerPuntosMensualesPorSucursales(1, Me.DropDownList3.SelectedItem.Text)
            If tabla.Rows.Count <> 0 Then
                Me.GridView24.DataSource = tabla
                Me.GridView24.DataBind()
                '
                Me.Chart5.DataSource = tabla
                Me.Chart5.Series(0).XValueMember = "nombresucursal"
                Me.Chart5.Series(0).YValueMembers = "puntos"
                Me.Chart5.DataBind()
            Else
                Me.GridView24.DataSource = Nothing
                Me.GridView24.DataBind()
            End If
        End With
        '
        Me.TextBox1.Focus()
    End Sub

    
    Protected Sub Button3_Click(sender As Object, e As System.EventArgs) Handles Button3.Click
        Dim tabla As New DataTable
        Me.MultiView1.ActiveViewIndex = 1
        With encabezadofactura
            tabla = .obtenerPuntosMensualesPorSucursales(2, Me.DropDownList3.SelectedItem.Text)
            If tabla.Rows.Count <> 0 Then
                Me.GridView25.DataSource = tabla
                Me.GridView25.DataBind()
                '
                Me.Chart6.DataSource = tabla
                Me.Chart6.Series(0).XValueMember = "nombresucursal"
                Me.Chart6.Series(0).YValueMembers = "puntos"
                Me.Chart6.DataBind()
            Else
                Me.GridView25.DataSource = Nothing
                Me.GridView25.DataBind()
            End If
        End With
        Me.TextBox1.Focus()
    End Sub

    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        Dim tabla As New DataTable
        Me.MultiView1.ActiveViewIndex = 0
        With encabezadofactura
            tabla = .obtenerPuntosMensualesPorSucursales(1, Me.DropDownList3.SelectedItem.Text)
            If tabla.Rows.Count <> 0 Then
                Me.GridView24.DataSource = tabla
                Me.GridView24.DataBind()
                '
                Me.Chart5.DataSource = tabla
                Me.Chart5.Series(0).XValueMember = "nombresucursal"
                Me.Chart5.Series(0).YValueMembers = "puntos"
                Me.Chart5.DataBind()
            Else
                Me.GridView24.DataSource = Nothing
                Me.GridView24.DataBind()
            End If
        End With
        Me.TextBox1.Focus()
    End Sub

    Protected Sub Button4_Click(sender As Object, e As System.EventArgs) Handles Button4.Click
        Dim tabla As New DataTable
        Me.MultiView1.ActiveViewIndex = 2
        With encabezadofactura
            tabla = .obtenerPuntosMensualesPorSucursales(3, Me.DropDownList3.SelectedItem.Text)
            If tabla.Rows.Count <> 0 Then
                Me.GridView26.DataSource = tabla
                Me.GridView26.DataBind()
                '
                Me.Chart7.DataSource = tabla
                Me.Chart7.Series(0).XValueMember = "nombresucursal"
                Me.Chart7.Series(0).YValueMembers = "puntos"
                Me.Chart7.DataBind()
            Else
                Me.GridView26.DataSource = Nothing
                Me.GridView26.DataBind()
            End If
        End With
        Me.TextBox1.Focus()
    End Sub

    Protected Sub Button5_Click(sender As Object, e As System.EventArgs) Handles Button5.Click
        Dim tabla As New DataTable
        Me.MultiView1.ActiveViewIndex = 3
        With encabezadofactura
            tabla = .obtenerPuntosMensualesPorSucursales(4, Me.DropDownList3.SelectedItem.Text)
            If tabla.Rows.Count <> 0 Then
                Me.GridView27.DataSource = tabla
                Me.GridView27.DataBind()
                '
                Me.Chart8.DataSource = tabla
                Me.Chart8.Series(0).XValueMember = "nombresucursal"
                Me.Chart8.Series(0).YValueMembers = "puntos"
                Me.Chart8.DataBind()
            Else
                Me.GridView27.DataSource = Nothing
                Me.GridView27.DataBind()
            End If
        End With
        Me.TextBox1.Focus()
    End Sub

    Protected Sub Button6_Click(sender As Object, e As System.EventArgs) Handles Button6.Click
        Dim tabla As New DataTable
        Me.MultiView1.ActiveViewIndex = 4
        With encabezadofactura
            tabla = .obtenerPuntosMensualesPorSucursales(5, Me.DropDownList3.SelectedItem.Text)
            If tabla.Rows.Count <> 0 Then
                Me.GridView28.DataSource = tabla
                Me.GridView28.DataBind()
                '
                Me.Chart9.DataSource = tabla
                Me.Chart9.Series(0).XValueMember = "nombresucursal"
                Me.Chart9.Series(0).YValueMembers = "puntos"
                Me.Chart9.DataBind()
            Else
                Me.GridView28.DataSource = Nothing
                Me.GridView28.DataBind()
            End If
        End With
        Me.TextBox1.Focus()
    End Sub

    Protected Sub Button7_Click(sender As Object, e As System.EventArgs) Handles Button7.Click
        Dim tabla As New DataTable
        Me.MultiView1.ActiveViewIndex = 5
        With encabezadofactura
            tabla = .obtenerPuntosMensualesPorSucursales(6, Me.DropDownList3.SelectedItem.Text)
            If tabla.Rows.Count <> 0 Then
                Me.GridView29.DataSource = tabla
                Me.GridView29.DataBind()
                '
                Me.Chart10.DataSource = tabla
                Me.Chart10.Series(0).XValueMember = "nombresucursal"
                Me.Chart10.Series(0).YValueMembers = "puntos"
                Me.Chart10.DataBind()
            Else
                Me.GridView29.DataSource = Nothing
                Me.GridView29.DataBind()
            End If
        End With
        Me.TextBox1.Focus()
    End Sub

    Protected Sub Button8_Click(sender As Object, e As System.EventArgs) Handles Button8.Click
        Dim tabla As New DataTable
        Me.MultiView1.ActiveViewIndex = 6
        With encabezadofactura
            tabla = .obtenerPuntosMensualesPorSucursales(7, Me.DropDownList3.SelectedItem.Text)
            If tabla.Rows.Count <> 0 Then
                Me.GridView30.DataSource = tabla
                Me.GridView30.DataBind()
                '
                Me.Chart11.DataSource = tabla
                Me.Chart11.Series(0).XValueMember = "nombresucursal"
                Me.Chart11.Series(0).YValueMembers = "puntos"
                Me.Chart11.DataBind()
            Else
                Me.GridView30.DataSource = Nothing
                Me.GridView30.DataBind()
            End If
        End With
        Me.TextBox1.Focus()
    End Sub

    Protected Sub Button9_Click(sender As Object, e As System.EventArgs) Handles Button9.Click
        Dim tabla As New DataTable
        Me.MultiView1.ActiveViewIndex = 7
        With encabezadofactura
            tabla = .obtenerPuntosMensualesPorSucursales(8, Me.DropDownList3.SelectedItem.Text)
            If tabla.Rows.Count <> 0 Then
                Me.GridView31.DataSource = tabla
                Me.GridView31.DataBind()
                '
                Me.Chart12.DataSource = tabla
                Me.Chart12.Series(0).XValueMember = "nombresucursal"
                Me.Chart12.Series(0).YValueMembers = "puntos"
                Me.Chart12.DataBind()
            Else
                Me.GridView31.DataSource = Nothing
                Me.GridView31.DataBind()
            End If
        End With
        Me.TextBox1.Focus()
    End Sub

    Protected Sub Button10_Click(sender As Object, e As System.EventArgs) Handles Button10.Click
        Dim tabla As New DataTable
        Me.MultiView1.ActiveViewIndex = 8
        With encabezadofactura
            tabla = .obtenerPuntosMensualesPorSucursales(9, Me.DropDownList3.SelectedItem.Text)
            If tabla.Rows.Count <> 0 Then
                Me.GridView32.DataSource = tabla
                Me.GridView32.DataBind()
                '
                Me.Chart13.DataSource = tabla
                Me.Chart13.Series(0).XValueMember = "nombresucursal"
                Me.Chart13.Series(0).YValueMembers = "puntos"
                Me.Chart13.DataBind()
            Else
                Me.GridView32.DataSource = Nothing
                Me.GridView32.DataBind()
            End If
        End With
        Me.TextBox1.Focus()
    End Sub

    Protected Sub Button11_Click(sender As Object, e As System.EventArgs) Handles Button11.Click
        Dim tabla As New DataTable
        Me.MultiView1.ActiveViewIndex = 9
        With encabezadofactura
            tabla = .obtenerPuntosMensualesPorSucursales(10, Me.DropDownList3.SelectedItem.Text)
            If tabla.Rows.Count <> 0 Then
                Me.GridView33.DataSource = tabla
                Me.GridView33.DataBind()
                '
                Me.Chart14.DataSource = tabla
                Me.Chart14.Series(0).XValueMember = "nombresucursal"
                Me.Chart14.Series(0).YValueMembers = "puntos"
                Me.Chart14.DataBind()
            Else
                Me.GridView33.DataSource = Nothing
                Me.GridView33.DataBind()
            End If
        End With
        Me.TextBox1.Focus()
    End Sub

    Protected Sub Button12_Click(sender As Object, e As System.EventArgs) Handles Button12.Click
        Dim tabla As New DataTable
        Me.MultiView1.ActiveViewIndex = 10
        With encabezadofactura
            tabla = .obtenerPuntosMensualesPorSucursales(11, Me.DropDownList3.SelectedItem.Text)
            If tabla.Rows.Count <> 0 Then
                Me.GridView34.DataSource = tabla
                Me.GridView34.DataBind()
                '
                Me.Chart15.DataSource = tabla
                Me.Chart15.Series(0).XValueMember = "nombresucursal"
                Me.Chart15.Series(0).YValueMembers = "puntos"
                Me.Chart15.DataBind()
            Else
                Me.GridView34.DataSource = Nothing
                Me.GridView34.DataBind()
            End If
        End With
        Me.TextBox1.Focus()
    End Sub

    Protected Sub Button13_Click(sender As Object, e As System.EventArgs) Handles Button13.Click
        Dim tabla As New DataTable
        Me.MultiView1.ActiveViewIndex = 11
        With encabezadofactura
            tabla = .obtenerPuntosMensualesPorSucursales(12, Me.DropDownList3.SelectedItem.Text)
            If tabla.Rows.Count <> 0 Then
                Me.GridView35.DataSource = tabla
                Me.GridView35.DataBind()
                '
                Me.Chart16.DataSource = tabla
                Me.Chart16.Series(0).XValueMember = "nombresucursal"
                Me.Chart16.Series(0).YValueMembers = "puntos"
                Me.Chart16.DataBind()
            Else
                Me.GridView35.DataSource = Nothing
                Me.GridView35.DataBind()
            End If
        End With
        Me.TextBox1.Focus()
    End Sub

    
End Class
