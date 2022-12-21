Public Class Torneo
    Public Property idTorneo As Integer
    Public Property NombreTorneo As String
    Public Property CiudadTorneo As String
    Public Property PaisTorneo As Pais
    Public ReadOnly Property toDAO As TorneoDAO

    Public Sub New()
        Me.toDAO = New TorneoDAO
        Me.PaisTorneo = New Pais
    End Sub

    Public Sub New(id As Integer)
        Me.toDAO = New TorneoDAO
        Me.idTorneo = id
        Me.PaisTorneo = New Pais
    End Sub

    Public Sub LeerTodosTorneos()
        Me.toDAO.LeerTodas()
    End Sub

    Public Sub LeerTorneo()
        Me.toDAO.Leer(Me)
    End Sub

    Public Sub LeerAnualidadesTorneo()
        Me.toDAO.LeerAnualidades(Me)
    End Sub

    Public Sub LeerTorneoNombre()
        Me.toDAO.LeerNombre(Me)
    End Sub

    Public Function existeEdicionTorneo(ByVal anio As Integer) As Boolean
        Return toDAO.existeEdicion(anio, Me)
    End Function
    Public Sub MaxIDTorneo()
        Me.toDAO.MaxId(Me)
    End Sub

    Public Function InsertarEdicionTorneo(ByVal anio As Integer, ByRef j As Jugadora) As Integer
        Return Me.toDAO.InsertarEdicion(anio, Me, j)
    End Function
    Public Function InsertarTorneo() As Integer
        Return Me.toDAO.Insertar(Me)
    End Function
    Public Function ActualizarEdicionTorneo(ByVal anio As Integer, ByRef j As Jugadora) As Integer
        Return Me.toDAO.ModificarEdicion(anio, Me, j)
    End Function

    Public Function ActualizarTorneo() As Integer
        Return Me.toDAO.Actualizar(Me)
    End Function

    Public Function BorrarTorneo() As Integer
        Return Me.toDAO.Borrar(Me)
    End Function

    Public Function InfoEdicionTorneo(ByVal anualidad As Integer) As DataTable
        Return Me.toDAO.InfoEdicion(Me, anualidad)
    End Function

    Public Function InfoEdicionGanadora() As DataTable
        Return Me.toDAO.InfoEdicionGanadora(Me)
    End Function
End Class
