Imports System.Data
Imports System.Net
Imports System.Net.Dns

Partial Class MasterPage
    Inherits System.Web.UI.MasterPage

    Dim objOperacione As New clsOperacione
    Dim afiliado As New ClsAfiliado
    Dim tablaMenu As New DataTable
    Dim tablaSubMenu As New DataTable
    Dim seleccion As Integer = 0

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Me.Label1.Text = "Derechos Reservados KINNUX S.A.S - " & Now.Year
            mostrarDatoUsuario()
            'configuraManejoTestimonios()
            'verificaSiAsignaPQR()
            'verificaSiTienePQRAsignados()
            Me.Accordion1.SelectedIndex = Request.QueryString("indice")
            '
            Me.Accordion1.Visible = True
            Me.Label3.Visible = True
        End If
        CargarDatoMenuVertical()
    End Sub

    Sub mostrarDatoUsuario()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from tbusuario where idusuario=" & Request.QueryString("iu")
        With objOperacione
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.Label3.Text = "Usuario: " & tabla.Rows(0).Item("nombrecompletousuario")
            Else

            End If
        End With
    End Sub

    'Sub verificaSiTienePQRAsignados()
    '    Dim solucionaPqr As String = "no"
    '    Dim sql As String
    '    Dim tabla As New DataTable
    '    sql = "select * from tbusuario where idusuario=" & Request.QueryString("iu") & " and solucionaPQR='si'"
    '    With objOperacione
    '        tabla = .DevuelveDato(sql)
    '        If tabla.Rows.Count <> 0 Then
    '            solucionaPqr = "si"
    '        End If
    '    End With
    '    '
    '    'If solucionaPqr = "si" Then
    '    '    sql = "select * from ttencabezadopqr where (estadoPqr='pr' or estadoPqr='as') and idusuario=" & Request.QueryString("iu")
    '    '    With objOperacione
    '    '        tabla = .DevuelveDato(sql)
    '    '        If tabla.Rows.Count <> 0 Then
    '    '            Me.Button2.Enabled = True
    '    '            Me.Button2.Style.Add("border", "#005daa 1px solid")
    '    '            Me.Button2.Style.Add("color", "#005daa")
    '    '            Me.Button2.Style.Add("cursor", "Pointer")
    '    '            Me.Button2.Text = "(" & tabla.Rows.Count & ") " & "PQR Asignados"
    '    '        Else
    '    '            Me.Button2.Enabled = False
    '    '            Me.Button2.ForeColor = Drawing.Color.Gray
    '    '            Me.Button2.BorderColor = Drawing.Color.Gray
    '    '            Me.Button2.Style.Add("cursor", "Default")
    '    '            Me.Button2.Text = "PQR Asignados"
    '    '        End If
    '    '    End With
    '    'Else
    '    '    Me.Button2.Enabled = False
    '    '    Me.Button2.ForeColor = Drawing.Color.Gray
    '    '    Me.Button2.BorderColor = Drawing.Color.Gray
    '    '    Me.Button2.Style.Add("cursor", "Default")
    '    '    Me.Button2.Text = "PQR Asignados"
    '    'End If
    'End Sub

    'Sub verificaSiAsignaPQR()
    '    Dim asignapqr As String = "no"
    '    Dim sql As String
    '    Dim tabla As New DataTable
    '    sql = "select * from tbusuario where idusuario=" & Request.QueryString("iu") & " and asignaPQR='si'"
    '    With objOperacione
    '        tabla = .DevuelveDato(sql)
    '        If tabla.Rows.Count <> 0 Then
    '            asignapqr = "si"
    '        End If
    '    End With
    '    '
    '    If asignapqr = "si" Then
    '        sql = "select * from ttencabezadopqr where estadoPqr='pe'"
    '        With objOperacione
    '            tabla = .DevuelveDato(sql)
    '            If tabla.Rows.Count <> 0 Then
    '                Me.Button3.Enabled = True
    '                Me.Button3.Style.Add("border", "#005daa 1px solid")
    '                Me.Button3.Style.Add("color", "#005daa")
    '                Me.Button3.Style.Add("cursor", "Pointer")
    '                Me.Button3.Text = "(" & tabla.Rows.Count & ") " & "PQR Sin Asignar"
    '            Else
    '                Me.Button3.Enabled = False
    '                Me.Button3.ForeColor = Drawing.Color.Gray
    '                Me.Button3.BorderColor = Drawing.Color.Gray
    '                Me.Button3.Style.Add("cursor", "Default")
    '                Me.Button3.Text = "PQR Sin Asignar"
    '            End If
    '        End With
    '    Else
    '        Me.Button3.Enabled = False
    '        Me.Button3.ForeColor = Drawing.Color.Gray
    '        Me.Button3.BorderColor = Drawing.Color.Gray
    '        Me.Button3.Style.Add("cursor", "Default")
    '        Me.Button3.Text = "PQR Sin Asignar"
    '    End If
    'End Sub

    'Sub configuraManejoTestimonios()
    '    Dim cuantos As Integer = 0
    '    Dim hayTestimonios As String = "no"
    '    Dim sql As String
    '    Dim tabla As New DataTable
    '    ' comprobamos si hay testimonios activos
    '    sql = "select * from tttestimonio where estadoTestimonio='p'"
    '    With objOperacione
    '        tabla = .DevuelveDato(sql)
    '        If tabla.Rows.Count <> 0 Then
    '            hayTestimonios = "si"
    '            cuantos = tabla.Rows.Count
    '        Else
    '            hayTestimonios = "no"
    '        End If
    '    End With
    '    ' comprobamos si este usuario maneja los testimonios
    '    If hayTestimonios = "si" Then
    '        sql = "select * from tbusuario where idusuario=" & Request.QueryString("iu") & " and manejaTestimonios='si'"
    '        With objOperacione
    '            tabla = .DevuelveDato(sql)
    '            If tabla.Rows.Count <> 0 Then
    '                Me.Button1.Enabled = True
    '                Me.Button1.Style.Add("border", "#005daa 1px solid")
    '                Me.Button1.Style.Add("color", "#005daa")
    '                Me.Button1.Style.Add("cursor", "Pointer")
    '                Me.Button1.Text = "(" & cuantos & ") " & "Testimonios Pendientes"
    '            Else
    '                Me.Button1.Enabled = False
    '                Me.Button1.ForeColor = Drawing.Color.Gray
    '                Me.Button1.BorderColor = Drawing.Color.Gray
    '                Me.Button1.Style.Add("cursor", "Default")
    '                Me.Button1.Text = "Testimonios Pendientes"
    '            End If
    '        End With
    '    Else
    '        Me.Button1.Enabled = False
    '        Me.Button1.ForeColor = Drawing.Color.Gray
    '        Me.Button1.BorderColor = Drawing.Color.Gray
    '        Me.Button1.Style.Add("cursor", "Default")
    '        Me.Button1.Text = "Testimonios Pendientes"
    '    End If
    'End Sub

    Function ips() As String
        'Dim sIP As String = Request.ServerVariables("REMOTE_ADDR").ToString()
        'Dim HostName As String = System.Net.Dns.GetHostByAddress(Request.UserHostAddress).HostName
        Dim strClientIP As String
        strClientIP = Request.UserHostAddress()
        Return strClientIP
    End Function


    Sub CargarDatoMenuVertical()
        'Dim fila As GridViewRow
        Dim sql As String
        Dim tabla As New DataTable
        Dim y As Integer
        'Dim k As Integer
        With objOperacione
            tablaMenu = .DevuelveDato("select * from tbMenu where tipoOpcion=1 order by idMenu")
        End With
        '
        For y = 0 To tablaMenu.Rows.Count - 1
            sql = "SELECT " & _
            "TBSubmenu.nombreSubmenu ns," & _
            "TBSubmenu.ruta ruta," & _
            "TBPermiso.acceso acceso" & _
            " FROM" & _
            " TBSubmenu INNER JOIN" & _
            " TBPermiso ON TBSubmenu.idmenu = TBPermiso.idMenu AND " & _
            " TBSubmenu.idSubmenu = TBPermiso.idSubmenu INNER JOIN" & _
            " TBMenu ON TBSubmenu.idmenu = TBMenu.idMenu" & _
            " where" & _
            " TBPermiso.idUsuario=" & Request.QueryString("iu") & " and" & _
            " TBSubmenu.idMenu=" & tablaMenu.Rows(y).Item("idMenu") & " And " & _
            " TBPermiso.acceso='Si' and TBMenu.tipoOpcion=1 and TBSubmenu.tipoSubmenu=1 and TBSubmenu.estado=1 " & _
            " order by" & _
            " TBSubmenu.orden"
            '
            Select Case tablaMenu.Rows(y).Item("idMenu")
                Case Is = 1 ' seguridad
                    With objOperacione
                        Dim n As Integer
                        Dim columna As Integer
                        tabla = .DevuelveDato(sql)
                        For n = 0 To tabla.Rows.Count - 1
                            Dim tRow As New TableRow()
                            For columna = 1 To 1
                                Dim tCell As New TableCell()
                                Dim s As New HyperLink
                                s.Text = n + 1 & " - " & tabla.Rows(n).Item("ns")
                                s.NavigateUrl = tabla.Rows(n).Item("ruta") & "&iu=" & Request.QueryString("iu")
                                '
                                tCell.Controls.Add(s)
                                tRow.Cells.Add(tCell)
                            Next
                            Table2.Rows.Add(tRow)
                        Next
                    End With
                Case Is = 2 ' inventario
                    With objOperacione
                        Dim n As Integer
                        Dim columna As Integer
                        tabla = .DevuelveDato(sql)
                        For n = 0 To tabla.Rows.Count - 1
                            Dim tRow As New TableRow()
                            For columna = 1 To 1
                                Dim tCell As New TableCell()
                                Dim s As New HyperLink
                                s.Text = n + 1 & " - " & tabla.Rows(n).Item("ns")
                                s.NavigateUrl = tabla.Rows(n).Item("ruta") & "&iu=" & Request.QueryString("iu")
                                '
                                tCell.Controls.Add(s)
                                tRow.Cells.Add(tCell)
                            Next
                            Table3.Rows.Add(tRow)
                        Next
                    End With
                Case Is = 3 ' facturacion
                    With objOperacione
                        Dim n As Integer
                        Dim columna As Integer
                        tabla = .DevuelveDato(sql)
                        For n = 0 To tabla.Rows.Count - 1
                            Dim tRow As New TableRow()
                            For columna = 1 To 1
                                Dim tCell As New TableCell()
                                Dim s As New HyperLink
                                s.Text = n + 1 & " - " & tabla.Rows(n).Item("ns")
                                s.NavigateUrl = tabla.Rows(n).Item("ruta") & "&iu=" & Request.QueryString("iu")
                                '
                                tCell.Controls.Add(s)
                                tRow.Cells.Add(tCell)
                            Next
                            Table1.Rows.Add(tRow)
                        Next

                    End With
                Case Is = 4 ' reportes
                    With objOperacione
                        Dim n As Integer
                        Dim columna As Integer
                        tabla = .DevuelveDato(sql)
                        For n = 0 To tabla.Rows.Count - 1
                            Dim tRow As New TableRow()
                            For columna = 1 To 1
                                Dim tCell As New TableCell()
                                Dim s As New HyperLink
                                s.Text = n + 1 & " - " & tabla.Rows(n).Item("ns")
                                s.NavigateUrl = tabla.Rows(n).Item("ruta") & "&iu=" & Request.QueryString("iu")
                                '
                                tCell.Controls.Add(s)
                                tRow.Cells.Add(tCell)
                            Next
                            Table4.Rows.Add(tRow)
                        Next

                    End With
                Case Is = 5 ' herramientas
                    With objOperacione
                        Dim n As Integer
                        Dim columna As Integer
                        tabla = .DevuelveDato(sql)
                        For n = 0 To tabla.Rows.Count - 1
                            Dim tRow As New TableRow()
                            For columna = 1 To 1
                                Dim tCell As New TableCell()
                                Dim s As New HyperLink
                                s.Text = n + 1 & " - " & tabla.Rows(n).Item("ns")
                                s.NavigateUrl = tabla.Rows(n).Item("ruta") & "&iu=" & Request.QueryString("iu")
                                '
                                tCell.Controls.Add(s)
                                tRow.Cells.Add(tCell)
                            Next
                            Table5.Rows.Add(tRow)
                        Next

                    End With
                Case Is = 6 ' inventario papelerias
                    With objOperacione
                        Dim n As Integer
                        Dim columna As Integer
                        tabla = .DevuelveDato(sql)
                        For n = 0 To tabla.Rows.Count - 1
                            Dim tRow As New TableRow()
                            For columna = 1 To 1
                                Dim tCell As New TableCell()
                                Dim s As New HyperLink
                                s.Text = n + 1 & " - " & tabla.Rows(n).Item("ns")
                                s.NavigateUrl = tabla.Rows(n).Item("ruta") & "&iu=" & Request.QueryString("iu")
                                '
                                tCell.Controls.Add(s)
                                tRow.Cells.Add(tCell)
                            Next
                            Table6.Rows.Add(tRow)
                        Next

                    End With
                Case Is = 7 ' herramientas
                    With objOperacione
                        Dim n As Integer
                        Dim columna As Integer
                        tabla = .DevuelveDato(sql)
                        For n = 0 To tabla.Rows.Count - 1
                            Dim tRow As New TableRow()
                            For columna = 1 To 1
                                Dim tCell As New TableCell()
                                Dim s As New HyperLink
                                s.Text = n + 1 & " - " & tabla.Rows(n).Item("ns")
                                s.NavigateUrl = tabla.Rows(n).Item("ruta") & "&iu=" & Request.QueryString("iu")
                                '
                                tCell.Controls.Add(s)
                                tRow.Cells.Add(tCell)
                            Next
                            Table7.Rows.Add(tRow)
                        Next
                    End With
                Case Is = 8 ' reporte de comisiones
                    With objOperacione
                        Dim n As Integer
                        Dim columna As Integer
                        tabla = .DevuelveDato(sql)
                        For n = 0 To tabla.Rows.Count - 1
                            Dim tRow As New TableRow()
                            For columna = 1 To 1
                                Dim tCell As New TableCell()
                                Dim s As New HyperLink
                                s.Text = n + 1 & " - " & tabla.Rows(n).Item("ns")
                                s.NavigateUrl = tabla.Rows(n).Item("ruta") & "&iu=" & Request.QueryString("iu")
                                '
                                tCell.Controls.Add(s)
                                tRow.Cells.Add(tCell)
                            Next
                            Table8.Rows.Add(tRow)
                        Next
                    End With
                Case Is = 9 ' viajes y eventos
                    With objOperacione
                        Dim n As Integer
                        Dim columna As Integer
                        tabla = .DevuelveDato(sql)
                        For n = 0 To tabla.Rows.Count - 1
                            Dim tRow As New TableRow()
                            For columna = 1 To 1
                                Dim tCell As New TableCell()
                                Dim s As New HyperLink
                                s.Text = n + 1 & " - " & tabla.Rows(n).Item("ns")
                                s.NavigateUrl = tabla.Rows(n).Item("ruta") & "&iu=" & Request.QueryString("iu")
                                '
                                tCell.Controls.Add(s)
                                tRow.Cells.Add(tCell)
                            Next
                            Table9.Rows.Add(tRow)
                        Next
                    End With
            End Select
        Next y
    End Sub


    'Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
    '    Session("entradaValida") = "no"
    '    Session("nombreUsuario") = ""
    '    Response.Redirect("~/Default.aspx")

    'End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
        Response.Redirect("~/Reportes Varios/wfConsultaDistribuidor.aspx?indice=4&iu=" & Request.QueryString("iu"))

    End Sub

    Protected Sub ImageButton2_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton2.Click
        Session("entradaValida") = "no"
        Session("nombreUsuario") = ""
        Response.Redirect("~/Default.aspx")
    End Sub
End Class

