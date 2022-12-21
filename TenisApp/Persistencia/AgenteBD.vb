Public Class AgenteBD

    Private Shared _instancia As AgenteBD
    Private Shared conexion As MySql.Data.MySqlClient.MySqlConnection
    Private Const cadenaConexion As String = "server=localhost;database=tenis;uid=root;pwd=Zapatilla15." ' password --> cambiar contraseña 
    ' es la contreña que creas cuando te instalas los paquetes de mySQL para Visual 2019 --> diapositivas 2022 Practica 2 

    Private Sub New()
        AgenteBD.conexion = New MySql.Data.MySqlClient.MySqlConnection(AgenteBD.cadenaConexion)
    End Sub

    Public Shared Function ObtenerAgente() As AgenteBD
        If AgenteBD._instancia Is Nothing Then
            AgenteBD._instancia = New AgenteBD
        End If
        Return AgenteBD._instancia
    End Function

    Public Function Leer(sql As String) As Collection
        Dim result As New Collection
        Dim fila As Collection
        Dim i As Integer
        Dim reader As MySql.Data.MySqlClient.MySqlDataReader
        Dim com As New MySql.Data.MySqlClient.MySqlCommand(sql, AgenteBD.conexion)
        Conectar()
        reader = com.ExecuteReader
        While reader.Read
            fila = New Collection
            For i = 0 To reader.FieldCount - 1
                fila.Add(reader(i).ToString)
            Next
            result.Add(fila)
        End While
        Desconectar()
        Return result
    End Function

    Public Function Modificar(sql As String) As Integer
        Dim com As New MySql.Data.MySqlClient.MySqlCommand(sql, AgenteBD.conexion)
        Dim result As Integer
        Conectar()
        result = com.ExecuteNonQuery
        Desconectar()
        Return result
    End Function

    Private Sub Conectar()
        If AgenteBD.conexion.State = ConnectionState.Closed Then
            AgenteBD.conexion.Open()
        End If
    End Sub

    Private Sub Desconectar()
        If AgenteBD.conexion.State = ConnectionState.Open Then
            AgenteBD.conexion.Close()
        End If
    End Sub

End Class
