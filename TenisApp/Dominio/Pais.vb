Public Class Pais
    Public Property idPais As String
    Public Property NombrePais As String

    Public ReadOnly Property paDAO As PaisDAO

    Public Sub New()
        Me.paDAO = New PaisDAO
    End Sub

    Public Sub New(id As String)
        Me.paDAO = New PaisDAO
        Me.idPais = id
    End Sub

    Public Sub LeerTodosPaises()
        Me.paDAO.LeerTodas()
    End Sub

    Public Sub LeerPais()
        Me.paDAO.Leer(Me)
    End Sub

    Public Function InsertarPais() As Integer
        Return Me.paDAO.Insertar(Me)
    End Function

    Public Function ActualizarPais() As Integer
        Return Me.paDAO.Actualizar(Me)
    End Function

    Public Function BorrarPais() As Integer
        Return Me.paDAO.Borrar(Me)
    End Function
End Class
