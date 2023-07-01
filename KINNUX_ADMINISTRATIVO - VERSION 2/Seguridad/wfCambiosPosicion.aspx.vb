Imports System.Data

Partial Class Seguridad_wfCambiosPosicion
    Inherits System.Web.UI.Page

    Dim afiliados As New ClsAfiliado

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim tabla As New DataTable
        Dim encontrado As String = "no"
        Dim codigoPatrocinador As Integer
        With afiliados
            .codigoAfiliado = Me.TextBox1.Text
            tabla = .obtenerAfiliadoPorCodigoAfiliado
            If tabla.Rows.Count <> 0 Then
                Me.TextBox5.Text = tabla.Rows(0).Item("codigopatrocinador")
                Me.TextBox7.Text = tabla.Rows(0).Item("pnombre") & " " & tabla.Rows(0).Item("snombre") & " " & tabla.Rows(0).Item("papellido") & " " & tabla.Rows(0).Item("sapellido")
                codigoPatrocinador = tabla.Rows(0).Item("codigopatrocinador")
                encontrado = "si"
            Else
                Me.TextBox5.Text = ""
                encontrado = "no"
            End If
        End With
        '
        If encontrado = "si" Then
            With afiliados
                .codigoAfiliado = tabla.Rows(0).Item("codigopatrocinador")
                tabla = .obtenerAfiliadoPorCodigoAfiliado
                If tabla.Rows.Count <> 0 Then
                    Me.TextBox3.Text = tabla.Rows(0).Item("pnombre") & " " & tabla.Rows(0).Item("snombre") & " " & tabla.Rows(0).Item("papellido") & " " & tabla.Rows(0).Item("sapellido")
                Else
                    Me.TextBox3.Text = ""
                End If
            End With

        End If
    End Sub

    Protected Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.MultiView1.ActiveViewIndex = 0
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim tabla As New DataTable
        Dim encontrado As String = "no"
        With afiliados
            .codigoAfiliado = Me.TextBox2.Text
            tabla = .obtenerAfiliadoPorCodigoAfiliado
            If tabla.Rows.Count <> 0 Then
                Me.TextBox6.Text = tabla.Rows(0).Item("codigoafiliado")
                Me.TextBox4.Text = tabla.Rows(0).Item("pnombre") & " " & tabla.Rows(0).Item("snombre") & " " & tabla.Rows(0).Item("papellido") & " " & tabla.Rows(0).Item("sapellido")
            Else
                Me.TextBox6.Text = ""
                Me.TextBox4.Text = ""
            End If
        End With
        '
    End Sub
End Class
