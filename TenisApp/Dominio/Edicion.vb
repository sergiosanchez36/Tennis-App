Public Class Edicion
    Public Property anualidad As Integer
    Public Property torneo As Torneo
    Public Property ganadora As Jugadora

    Public ReadOnly Property toDAO As TorneoDAO

    Public Sub New()
        Me.toDAO = New TorneoDAO
        Me.torneo = New Torneo()
        Me.ganadora = New Jugadora
    End Sub

    Public Sub LeerTodasEdiciones()
        Me.toDAO.LeerTodasEdiciones()
    End Sub

    Public Sub LeerTorneo()
        Me.toDAO.LeerEdicion(Me)
    End Sub
End Class
