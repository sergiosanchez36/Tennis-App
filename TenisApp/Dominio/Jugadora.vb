Public Class Jugadora

    Public Property idJugadora As Integer
    Public Property NombreJugadora As String
    Public Property FechaNacimientoJugadora As Date
    Public Property PuntosJugadora As Integer
    Public Property PaisJugadora As Pais

    Public ReadOnly Property jugaDAO As JugadoraDAO

    Public Sub New()
        Me.jugaDAO = New JugadoraDAO
        Me.PaisJugadora = New Pais
    End Sub

    Public Sub New(id As Integer)
        Me.jugaDAO = New JugadoraDAO
        Me.idJugadora = id
        Me.PaisJugadora = New Pais
    End Sub

    Public Sub Leer8JugadorasAleatorias()
        Me.jugaDAO.Leer8aleatorias()
    End Sub

    Public Sub LeerTodasJugadoras()
        Me.jugaDAO.LeerTodas()
    End Sub

    Public Sub LeerJugadora()
        Me.jugaDAO.Leer(Me)
    End Sub

    Public Sub LeerJugadorasTorneoInfo(ByRef t As Torneo)
        Me.jugaDAO.LeerJugadorasTorneo(t)
    End Sub

    Public Sub MaxIDJugadora()
        Me.jugaDAO.MaxId(Me)
    End Sub

    Public Function cantidadJugadoras() As Integer
        Return Me.jugaDAO.Cantidad()
    End Function

    Public Function InsertarJugadora() As Integer
        Return Me.jugaDAO.Insertar(Me)
    End Function

    Public Function ActualizarJugadora() As Integer
        Return Me.jugaDAO.Actualizar(Me)
    End Function
    Public Function ActualizarPuntosJugadora() As Integer
        Return Me.jugaDAO.ActualizarPuntos(Me)
    End Function

    Public Function BorrarJugadora() As Integer
        Return Me.jugaDAO.Borrar(Me)
    End Function


    Public Function InfoTorneoJugadoraEdiciones(ByRef torneo As Torneo) As DataTable
        Return Me.jugaDAO.InfoTorneoJugadora(torneo, Me)
    End Function

    Public Function DatosJugadorasCompleto() As DataTable
        Return Me.jugaDAO.datosJugadoras()
    End Function
End Class
