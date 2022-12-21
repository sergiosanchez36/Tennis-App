Public Class PartidoDAO
    Public ReadOnly Property Partidos As Collection

    Public Sub New()
        Me.Partidos = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As Partido
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Partidos ORDER BY idPartido")
        For Each aux In col
            p = New Partido(Convert.ToInt32(aux(1).ToString))
            p.anualidad = aux(2).ToString
            p.torneo.idTorneo = Convert.ToInt32(aux(3).ToString)
            p.ganadora.idJugadora = Convert.ToInt32(aux(4).ToString)
            Me.Partidos.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Partido)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Partidos WHERE idPartido=" & p.idPartido & ";")
        For Each aux In col
            p.anualidad = aux(2).ToString
            p.torneo.idTorneo = Convert.ToInt32(aux(3).ToString)
            p.ganadora.idJugadora = Convert.ToInt32(aux(4).ToString)
        Next
    End Sub
    Public Sub MaxId(ByRef p As Partido) 'buscamos el id máximo del torneo
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT max(idPartido) FROM Partidos;")
        For Each aux In col
            p.idPartido = Convert.ToInt32(aux(1).ToString)
        Next
    End Sub
    Public Function Insertar(ByRef p As Partido) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Partidos (anualidad,torneo,ganadora,ronda) VALUES (" & p.anualidad & ", " & p.torneo.idTorneo & ", " & p.ganadora.idJugadora & ", '" & p.ronda & "');")
    End Function
    Public Function InsertarJuego(ByRef j As Jugadora, ByRef p As Partido, ByVal set1 As Integer, ByVal set2 As Integer, ByVal set3 As Integer) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Juegos (jugadora,partido,set1,set2,set3) VALUES (" & j.idJugadora & ", " & p.idPartido & ", " & set1 & ", " & set2 & ", " & set3 & ");")
    End Function
End Class
