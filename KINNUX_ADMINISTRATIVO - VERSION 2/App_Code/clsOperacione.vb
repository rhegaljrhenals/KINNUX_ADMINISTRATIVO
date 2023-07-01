Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsOperacione

    Dim objConexion As New ClsConexion
    Dim da As New SqlDataAdapter
    Dim comando As New SqlCommand

    Function DevuelveDato(ByVal sentencia As String) As DataTable
        Dim tabla As New DataTable
        With objConexion
            Try
                '.conectar()
                'da = New SqlDataAdapter(sentencia, .conexion)
                'da.Fill(tabla)

                .conectar()
                comando.Connection = .conexion
                comando.CommandText = sentencia
                comando.CommandTimeout = 500 ' 100
                da.SelectCommand = comando
                da.Fill(tabla)
            Catch ex As Exception
                MsgBox(Err.Description)
            Finally
                .desconectar()
            End Try
        End With
        Return tabla
    End Function

    Sub Accion(ByVal sentencia As String)
        With objConexion
            Try
                .conectar()
                comando = New SqlCommand(sentencia, .conexion)
                comando.ExecuteNonQuery()
            Catch ex As Exception
                ' error
                MsgBox(Err.Description)
            Finally
                .desconectar()
            End Try
        End With
    End Sub

    Sub cargarCombos(ByVal combo As DropDownList, ByVal sentencia As String, ByVal campoClave As String, ByVal campoaMostrar As String, ByVal mensajePorDefecto As String)
        Dim tabla As New DataTable
        With objConexion
            Try
                .conectar()
                comando.Connection = .conexion
                comando.CommandText = sentencia
                comando.CommandTimeout = 500 ' 100
                da.SelectCommand = comando
                da.Fill(tabla)
                combo.DataSource = tabla
                combo.DataTextField = campoaMostrar
                combo.DataValueField = campoClave
                combo.DataBind()
                '
                combo.Items.Insert(0, mensajePorDefecto)
            Catch ex As Exception
                MsgBox(Err.Description)
            Finally
                .desconectar()
            End Try
        End With
    End Sub

    Function obtenerRutaDondeGrabar(ByVal descripcion As String) As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        Dim ruta As String = ""
        sql = "select * from tbConfiguracion where descripcion='" & descripcion & "'"
        With objConexion
            Try
                .conectar()
                comando.Connection = .conexion
                comando.CommandText = sql
                comando.CommandTimeout = 100
                da.SelectCommand = comando
                da.Fill(tabla)
                'ruta = tabla.Rows(0).Item("valor")
            Catch ex As Exception
                MsgBox(Err.Description)
            Finally
                .desconectar()
            End Try
        End With
        Return tabla
    End Function
End Class
