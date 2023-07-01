Imports System.Data

Partial Class Reportes_Varios_wfDetalleComisionesTS
    Inherits System.Web.UI.Page

    Dim comisiones As New clsTTComisionKit
    Dim comisionesIR As New clsTTComisionIr
    Dim grupalBinario As New clsTTGrupalbinario
    Dim detalleGrupalBinario As New clsTTDetGrupalBinario
    Dim acumuladoPuntoBinario As New clsTTPuntoBinario
    Dim comisionesMes As New clsTTComision
    Dim detalleComisionMesIr As New clsTTDetComisionMesIR
    Dim comisionBinario As New clsTTBBinario
    Dim operaciones As New clsOperacione

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarDatos()
            cargarAno()
            Me.ImageButton13.Visible = False
            Me.ImageButton14.Visible = False
            Me.ImageButton15.Visible = False
            Me.ImageButton16.Visible = False
            Me.ImageButton17.Visible = False
        End If
    End Sub

    Sub cargarDatos()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from afiliaciones where codigoAfiliado=" & Request.QueryString("id")
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.TextBox17.Text = tabla.Rows(0).Item("codigoafiliado")
                Me.TextBox18.Text = tabla.Rows(0).Item("pnombre") & " " & tabla.Rows(0).Item("snombre") & " " & tabla.Rows(0).Item("papellido") & " " & tabla.Rows(0).Item("sapellido")
            End If
        End With
    End Sub

    'Function desencriptarCadena() As String
    '    Dim encriptacion As New clsEncriptacion
    '    Dim codigo As String
    '    codigo = encriptacion.Desencriptar(HttpUtility.UrlDecode(Request.QueryString("iu")))
    '    Return codigo
    'End Function

    Sub cargarAno()
        Dim y As Integer
        For y = 2012 To Now.Year
            Me.DropDownList6.Items.Add(y)
        Next
        Me.DropDownList6.Items.Insert(0, "Año")
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim tabla As New DataTable
        Dim tieneComision As String
        Dim sql As String
        Dim codigoAfiliado As String = ""
        Me.ImageButton13.Visible = False
        Me.ImageButton14.Visible = False
        Me.ImageButton15.Visible = False
        Me.ImageButton16.Visible = False
        Me.ImageButton17.Visible = False
        Me.Label8.Text = ""
        If Me.DropDownList5.SelectedIndex = 0 Or Me.DropDownList6.SelectedIndex = 0 Then
            Me.Label8.Text = "Seleccione el periodo correctamente...!"
            Exit Sub
        End If
        '
        sql = "select * from ttcomisionts" & _
        " where codigoAfiliado = '" & Request.QueryString("id") & "' and" & _
        " mesComisionts=" & Me.DropDownList5.SelectedValue & " and" & _
        " anoComisionts=" & Me.DropDownList6.SelectedValue
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.TextBox3.Text = FormatNumber(tabla.Rows(0).Item("spcomisionts"), 2)
                Me.TextBox16.Text = FormatNumber(tabla.Rows(0).Item("bonoafilcomisionts"), 2)
                Me.TextBox5.Text = FormatNumber(tabla.Rows(0).Item("bonostscomisionts"), 2)
                Me.TextBox7.Text = FormatNumber(tabla.Rows(0).Item("bmundialcomisionts"), 2)
                Me.TextBox9.Text = FormatNumber(tabla.Rows(0).Item("uninivelcomisionts"), 2)
                Me.TextBox15.Text = FormatNumber(tabla.Rows(0).Item("bonomovcomisionts"), 2)
                Me.TextBox13.Text = FormatNumber(tabla.Rows(0).Item("bonorangocomisionts"), 2)
                Me.TextBox14.Text = FormatNumber(tabla.Rows(0).Item("bigualrcomisionts"), 2)
                Me.TextBox19.Text = FormatNumber(tabla.Rows(0).Item("avancercomisionts"), 2)
                Me.TextBox20.Text = FormatNumber(tabla.Rows(0).Item("bpatrimoniocomisionts"), 2)
                Me.TextBox21.Text = FormatNumber(tabla.Rows(0).Item("bono1comisionts"), 2)
                tieneComision = "si"
            Else
                Me.TextBox3.Text = "0,00"
                Me.TextBox5.Text = "0,00"
                Me.TextBox7.Text = "0,00"
                Me.TextBox9.Text = "0,00"
                Me.TextBox13.Text = "0,00"
                Me.TextBox15.Text = "0,00"
                Me.TextBox16.Text = "0,00"
                Me.TextBox14.Text = "0,00"
                Me.TextBox19.Text = "0,00"
                Me.TextBox20.Text = "0,00"
                Me.TextBox21.Text = "0,00"
                tieneComision = "no"
            End If
        End With
        '
        If Me.TextBox3.Text <> "0,00" Then
            Me.ImageButton13.Visible = True
            Me.ImageButton13.Attributes.Add("onclick", "window.open('detalleComisionesTS/wfDetalleComisionStarPoint.aspx?id=" & Request.QueryString("id") & "&mes=" & Me.DropDownList5.SelectedValue & "&ano=" & Me.DropDownList6.SelectedItem.Text & "',null,'height=450, width=800,status= no, resizable= no, scrollbars=si, toolbar=no,location=no,menubar=no ');")
        End If
        '
        If Me.TextBox16.Text <> "0,00" Then
            Me.ImageButton14.Visible = True
            Me.ImageButton14.Attributes.Add("onclick", "window.open('detalleComisionesTS/wfDetalleBonoAfiliacion.aspx?id=" & Request.QueryString("id") & "&mes=" & Me.DropDownList5.SelectedValue & "&ano=" & Me.DropDownList6.SelectedItem.Text & "',null,'height=450, width=800,status= no, resizable= no, scrollbars=si, toolbar=no,location=no,menubar=no ');")
        End If
        '
        If Me.TextBox5.Text <> "0,00" Then
            Me.ImageButton15.Visible = True
            Me.ImageButton15.Attributes.Add("onclick", "window.open('detalleComisionesTS/wfDetalleComisionBSTS.aspx?id=" & Request.QueryString("id") & "&mes=" & Me.DropDownList5.SelectedValue & "&ano=" & Me.DropDownList6.SelectedItem.Text & "',null,'height=450, width=800,status= no, resizable= no, scrollbars=si, toolbar=no,location=no,menubar=no ');")
        End If
        '
        If Me.TextBox7.Text <> "0,00" Then
            Me.ImageButton16.Visible = True
        End If
        '
        If Me.TextBox9.Text <> "0,00" Then
            Me.ImageButton17.Visible = True
            Me.ImageButton17.Attributes.Add("onclick", "window.open('detalleComisionesTS/wfDetalleComisionUninivel.aspx?id=" & Request.QueryString("id") & "&mes=" & Me.DropDownList5.SelectedValue & "&ano=" & Me.DropDownList6.SelectedItem.Text & "',null,'height=450, width=800,status= no, resizable= no, scrollbars=si, toolbar=no,location=no,menubar=no ');")

        End If
        If tieneComision = "si" Then
            Dim total As Double = 0
            total = CDbl(Me.TextBox3.Text) + CDbl(Me.TextBox16.Text) + CDbl(Me.TextBox5.Text) + CDbl(Me.TextBox7.Text) + CDbl(Me.TextBox9.Text) + CDbl(Me.TextBox15.Text) + CDbl(Me.TextBox13.Text) + CDbl(Me.TextBox14.Text) + CDbl(Me.TextBox19.Text) + CDbl(Me.TextBox20.Text) + CDbl(Me.TextBox21.Text)
            Me.Label6.Text = "USD " & FormatNumber(total, 2)
        Else
            Me.Label6.Text = "USD 0"
        End If
    End Sub

End Class
