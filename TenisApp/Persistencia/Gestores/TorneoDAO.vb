Public Class TorneoDAO

    Public ReadOnly Property Torneos As Collection
    Public ReadOnly Property Ediciones As Collection



    Public Sub New()
        Me.Torneos = New Collection
        Me.Ediciones = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim t As Torneo
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Torneos ORDER BY idTorneo")
        For Each aux In col
            t = New Torneo(Convert.ToInt32(aux(1).ToString))
            t.NombreTorneo = aux(2).ToString
            t.CiudadTorneo = aux(3).ToString
            t.PaisTorneo.idPais = aux(4).ToString
            Me.Torneos.Add(t)
        Next
    End Sub

    Public Sub LeerTodasEdiciones()
        Dim e As Edicion
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Ediciones ORDER BY anualidad")
        For Each aux In col
            e = New Edicion()
            e.anualidad = Convert.ToInt32(aux(1).ToString)
            e.torneo.idTorneo = Convert.ToInt32(aux(2).ToString)
            e.ganadora.idJugadora = Convert.ToInt32(aux(3).ToString)
            Me.Ediciones.Add(e)
        Next
    End Sub

    Public Sub Leer(ByRef t As Torneo)
        'leer un torneo 
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Torneos WHERE idTorneo=" & t.idTorneo & ";")
        For Each aux In col
            t.NombreTorneo = aux(2).ToString
            t.CiudadTorneo = aux(3).ToString
            t.PaisTorneo.idPais = aux(4).ToString
        Next
    End Sub

    Public Sub LeerAnualidades(ByRef t As Torneo)
        'leer todos los años de un torneo
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT distinct anualidad FROM Ediciones WHERE torneo=" & t.idTorneo & ";")
        For Each aux In col

            Me.Ediciones.Add(Convert.ToInt32(aux(1).ToString))
        Next
    End Sub

    Public Sub LeerNombre(ByRef t As Torneo)
        'para identificar los identificadores primarios del torneo
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Torneos WHERE nombreTorneo='" & t.NombreTorneo & "';")
        For Each aux In col
            t.idTorneo = aux(1).ToString
            t.CiudadTorneo = aux(3).ToString
            t.PaisTorneo.idPais = aux(4).ToString
        Next
    End Sub

    Public Sub LeerEdicion(ByRef e As Edicion)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Ediciones WHERE anualidad=" & e.anualidad & " and torneo=" & e.torneo.idTorneo & ";")
        For Each aux In col
            e.anualidad = Convert.ToInt32(aux(1).ToString)
            e.torneo.idTorneo = Convert.ToInt32(aux(2).ToString)
            e.ganadora.idJugadora = Convert.ToInt32(aux(3).ToString)
        Next
    End Sub

    Public Function existeEdicion(ByVal anio As Integer, ByRef t As Torneo) As Boolean
        'verifica si existe la edición de un torneo
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Ediciones WHERE anualidad=" & anio & " and torneo=" & t.idTorneo & ";")
        Dim existe As Boolean = False
        For Each aux In col
            existe = True
        Next
        Return existe
    End Function


    Public Sub MaxId(ByRef t As Torneo)
        'buscamos el id del torneo
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT max(idTorneo) FROM Torneos;")
        For Each aux In col
            t.idTorneo = Convert.ToInt32(aux(1).ToString)
        Next
    End Sub



    Public Function Insertar(ByVal t As Torneo) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Torneos (NombreTorneo,CiudadTorneo,PaisTorneo) VALUES ('" & t.NombreTorneo & "', '" & t.CiudadTorneo & "', '" & t.PaisTorneo.idPais & "');")
    End Function

    Public Function InsertarEdicion(ByVal anio As Integer, ByVal t As Torneo, ByRef j As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Ediciones (anualidad,torneo,ganadora) VALUES (" & anio & ", " & t.idTorneo & "," & j.idJugadora & ");")
    End Function

    Public Function ModificarEdicion(ByVal anio As Integer, ByVal t As Torneo, ByVal j As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Ediciones SET ganadora=" & j.idJugadora & " WHERE anualidad=" & anio & " and torneo=" & t.idTorneo & ";")
    End Function

    Public Function Actualizar(ByVal t As Torneo) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Torneos SET NombreTorneo='" & t.NombreTorneo & "',CiudadTorneo='" & t.CiudadTorneo & "',PaisTorneo='" & t.PaisTorneo.idPais & "' WHERE idTorneo=" & t.idTorneo & ";")
    End Function

    Public Function Borrar(ByVal t As Torneo) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Torneos WHERE idTorneo=" & t.idTorneo & ";")
    End Function

    Public Function InfoEdicion(ByVal t As Torneo, ByVal anualidad As Integer) As DataTable
        'metodo usado para cargar los datos de partidos de una edicion completa de un torneo 
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("select idPartido,ronda,NombreJugadora,set1,set2,set3 
from partidos,juegos,jugadoras where partidos.idpartido=juegos.partido 
and jugadoras.idJugadora=juegos.Jugadora and torneo=" & t.idTorneo & " and anualidad=" & anualidad & " order by idPartido,ronda;")
        Dim dt As New DataTable
        dt.Columns.Add("idpar")
        dt.Columns.Add("ronda")
        dt.Columns.Add("N_jugadora")
        dt.Columns.Add("set1")
        dt.Columns.Add("set2")
        dt.Columns.Add("set3")
        Dim row As DataRow
        For Each aux In col
            row = dt.NewRow()
            row(0) = aux(1).ToString
            row(1) = aux(2).ToString
            row(2) = aux(3).ToString
            row(3) = aux(4).ToString
            row(4) = aux(5).ToString
            row(5) = aux(6).ToString
            dt.Rows.Add(row)
        Next
        Return dt
    End Function

    Public Function InfoEdicionGanadora(ByVal t As Torneo) As DataTable
        'carga las jugadoras ganadoras de todas las ediciones de un torneo 
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("select anualidad,NombreJugadora,puntosJugadora, paisjugadora
from ediciones,jugadoras where jugadoras.idJugadora=ediciones.Ganadora
and torneo=" & t.idTorneo & " order by Anualidad;")
        Dim dt As New DataTable
        dt.Columns.Add("Anio")
        dt.Columns.Add("N_Jug")
        dt.Columns.Add("Puntos")
        dt.Columns.Add("Pais")

        Dim row As DataRow
        For Each aux In col
            row = dt.NewRow()
            row(0) = aux(1).ToString
            row(1) = aux(2).ToString
            row(2) = aux(3).ToString
            row(3) = aux(4).ToString
            dt.Rows.Add(row)
        Next
        Return dt
    End Function
End Class
