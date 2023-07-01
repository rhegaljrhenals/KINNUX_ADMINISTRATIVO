Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Public Class ClsConexion

    Public conexion As New SqlConnection
    ' local
    'Dim cadena1 As String = "data source=DESKTOP-MIL4CL5\SQLSERVER2012;integrated security=sspi;initial catalog=kinnuxteam_dbentidad"
    '-------------------------------------------------------
    'Dim cadena1 As String = "data source=50.22.153.228,779;persist security info=false;user id=kinnuxteam_castillosrhenals;password=zaqwsxcde72*;initial catalog=kinnuxteam_kinnux"
    '-------------------------------------------------------

    'Dim cadena1 As String = "data source=50.22.153.228,779;persist security info=false;user id=kinnuxteam_gxz02castle;password=aros**54c400;initial catalog=kinnuxteam_knxkinnux"
    '-------------------------------------------------------
    'Dim cadena1 As String = "data source=asus\SQLEXPRESS;integrated security=sspi;initial catalog=kinnuxteam_kinnux"
    'Dim cadena1 As String = "data source=asus\SQLEXPRESS;integrated security=sspi;initial catalog=kinnuxteam_dbentidad"
    Dim cadena1 As String = "data source=69.167.148.96,782;persist security info=false;user id=kinnuxteam_Zdpsucas678;password=Hj87itew*vfjs;initial catalog=kinnuxteam_dbentidad"

    Sub conectar()
        Try
            conexion.ConnectionString = cadena1
            conexion.Open()
        Catch ex As Exception
            'MsgBox(Err.Description)
        End Try
    End Sub

    Sub desconectar()
        If Me.conexion.State = Data.ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub
End Class
