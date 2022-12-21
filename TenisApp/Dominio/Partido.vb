Public Class Partido

    Public Property idPartido As Integer
    Public Property anualidad As Integer
    Public Property torneo As Torneo
    Public Property ganadora As Jugadora
    Public Property ronda As String
    Public ReadOnly Property paDAO As PartidoDAO

    Public Sub New()
        Me.paDAO = New PartidoDAO
        Me.torneo = New Torneo
        Me.ganadora = New Jugadora
    End Sub

    Public Sub New(id As Integer)
        Me.paDAO = New PartidoDAO
        Me.idPartido = id
        Me.torneo = New Torneo
        Me.ganadora = New Jugadora
    End Sub

    Public Sub LeerTodosPartidos()
        Me.paDAO.LeerTodas()
    End Sub

    Public Sub LeerPartido()
        Me.paDAO.Leer(Me)
    End Sub
    Public Sub MaxIDPartido()
        Me.paDAO.MaxId(Me)
    End Sub
    Public Function InsertarPartido() As Integer
        Return Me.paDAO.Insertar(Me)
    End Function
    Public Function InsertarJuegoPartido(ByRef j As Jugadora, ByVal set1 As Integer, ByVal set2 As Integer, ByVal set3 As Integer) As Integer
        Return Me.paDAO.InsertarJuego(j, Me, set1, set2, set3)
    End Function

End Class
