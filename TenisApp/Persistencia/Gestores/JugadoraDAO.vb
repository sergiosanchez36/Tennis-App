Public Class JugadoraDAO
    Public ReadOnly Property Jugadoras As Collection

    Public Sub New()
        Me.Jugadoras = New Collection
    End Sub

    Function numAleatorioEntre(ByVal minimo As Integer, ByVal maximo As Integer) As Integer
        Randomize()
        Return CLng((minimo - maximo) * Rnd() + maximo)
    End Function

    Public Sub Leer8aleatorias()
        'guarda en un array los numeros que serán los id de las jugadoras
        Dim max As Integer = Cantidad()
        Dim posiciones(7) As Integer 'selecciona 8 id de jugadoras de manera aleatoria

        Dim indice As Integer = 0
        Dim i As Integer = 0
        Dim valido As Boolean = False
        While indice <= 7
            valido = True
            posiciones(indice) = numAleatorioEntre(1, max)
            i = 0
            While (i < indice)
                If posiciones(i) = posiciones(indice) Then
                    valido = False
                End If
                i = i + 1
            End While
            If (valido) Then
                indice = indice + 1
            End If
        End While

        Array.Sort(posiciones) 'ordena los id de las jugadoras

        'selecciona todas las jugadoras de las posiciones aleatorias elegidas
        Dim j As Jugadora
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Jugadoras ORDER BY idJugadora")
        Dim value As Integer = 1
        Dim index As Integer = 0
        For Each aux In col
            If index <= 7 Then
                If value = posiciones(index) Then
                    j = New Jugadora(Convert.ToInt32(aux(1).ToString))
                    j.NombreJugadora = aux(2).ToString
                    j.FechaNacimientoJugadora = Convert.ToDateTime(aux(3).ToString)
                    j.PuntosJugadora = Convert.ToInt32(aux(4).ToString)
                    j.PaisJugadora.idPais = aux(5).ToString
                    Me.Jugadoras.Add(j)
                    index = index + 1
                End If
            End If
            value = value + 1
        Next

    End Sub
    Public Sub LeerTodas()
        'Lee todas las jugadoras
        Dim j As Jugadora
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Jugadoras ORDER BY idJugadora")
        For Each aux In col
            j = New Jugadora(Convert.ToInt32(aux(1).ToString))
            j.NombreJugadora = aux(2).ToString
            j.FechaNacimientoJugadora = Convert.ToDateTime(aux(3).ToString)
            j.PuntosJugadora = Convert.ToInt32(aux(4).ToString)
            j.PaisJugadora.idPais = aux(5).ToString
            Me.Jugadoras.Add(j)
        Next
    End Sub

    Public Sub Leer(ByRef j As Jugadora)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Jugadoras WHERE idJugadora=" & j.idJugadora & ";")
        For Each aux In col
            j.NombreJugadora = aux(2).ToString
            j.FechaNacimientoJugadora = Convert.ToDateTime(aux(3).ToString)
            j.PuntosJugadora = Convert.ToInt32(aux(4).ToString)
            j.PaisJugadora.idPais = aux(5).ToString
        Next
    End Sub
    Public Sub LeerJugadorasTorneo(ByRef t As Torneo)
        Dim j As Jugadora
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("select distinct jugadora,NombreJugadora
            from partidos,juegos,jugadoras where partidos.idpartido=juegos.partido 
            and jugadoras.idJugadora=juegos.Jugadora and partidos.Torneo=" & t.idTorneo & " order by NombreJugadora;")
        For Each aux In col
            j = New Jugadora(Convert.ToInt32(aux(1).ToString))
            j.NombreJugadora = aux(2).ToString
            Me.Jugadoras.Add(j)
        Next
    End Sub


    Public Sub MaxId(ByRef j As Jugadora) 'buscamos el id máximo de la jugadora
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT max(idJugadora) FROM Jugadoras;")
        For Each aux In col
            j.idJugadora = Convert.ToInt32(aux(1).ToString)
        Next
    End Sub

    Public Function Cantidad() As Integer
        'obtiene el número de jugadoras
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT count(idJugadora) FROM Jugadoras;")
        Dim total As Integer = 0
        For Each aux In col
            total = total + Convert.ToInt32(aux(1).ToString)
        Next
        Return total
    End Function

    Public Function Insertar(ByVal j As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Jugadoras (NombreJugadora,FechaNacimientoJugadora,PuntosJugadora,PaisJugadora) VALUES ('" & j.NombreJugadora & "', '" & Format(j.FechaNacimientoJugadora, "yyyy-MM-dd") & "', " & j.PuntosJugadora & ", '" & j.PaisJugadora.idPais & "');")
    End Function

    Public Function Actualizar(ByVal j As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Jugadoras SET NombreJugadora='" & j.NombreJugadora & "',FechaNacimientoJugadora='" & Format(j.FechaNacimientoJugadora, "yyyy-MM-dd") & "',PuntosJugadora=" & j.PuntosJugadora & ",PaisJugadora='" & j.PaisJugadora.idPais & "' WHERE idJugadora=" & j.idJugadora & ";")
    End Function

    Public Function ActualizarPuntos(ByVal j As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Jugadoras SET PuntosJugadora=" & j.PuntosJugadora & " WHERE idJugadora=" & j.idJugadora & ";")
    End Function
    Public Function Borrar(ByVal j As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Jugadoras WHERE idJugadora=" & j.idJugadora & ";")
    End Function

    Public Function InfoTorneoJugadora(ByVal t As Torneo, ByRef j As Jugadora) As DataTable
        'Información del torneo
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("select nombreJugadora, torneos.NombreTorneo,anualidad edicion, partido, ronda, set1, set2, Set3
        from juegos,partidos,jugadoras,torneos where juegos.Partido=partidos.idPartido and juegos.Jugadora=jugadoras.idJugadora 
        and partidos.Torneo=torneos.idTorneo and torneos.idTorneo=" & t.idTorneo & "  and nombreJugadora='" & j.NombreJugadora & "' order by  edicion;")
        Dim dt As New DataTable
        dt.Columns.Add("N_Jug")
        dt.Columns.Add("N_Torneo")
        dt.Columns.Add("Edicion")
        dt.Columns.Add("Partido")
        dt.Columns.Add("Ronda")
        dt.Columns.Add("Set1")
        dt.Columns.Add("Set2")
        dt.Columns.Add("Set3")


        Dim row As DataRow
        For Each aux In col
            row = dt.NewRow()
            row(0) = aux(1).ToString
            row(1) = aux(2).ToString
            row(2) = aux(3).ToString
            row(3) = aux(4).ToString
            row(4) = aux(5).ToString
            row(5) = aux(6).ToString
            row(6) = aux(7).ToString
            row(7) = aux(8).ToString
            dt.Rows.Add(row)
        Next
        Return dt
    End Function

    Public Function datosJugadoras() As DataTable

        'ultima pestaña del tab Control
        'ifnull convierte un null en 0
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("select gana.nombrejugadora,gana.puntosjugadora,finales.vecesFinales, gana.vecesGana
                FROM
                (select j.nombrejugadora,j.puntosjugadora,ifnull(g.vecesGana,0) vecesGana
                from jugadoras as j left join 
                (select nombrejugadora,count(*) vecesGana from jugadoras,ediciones 
                where jugadoras.idJugadora=ediciones.ganadora group by nombrejugadora) 
                as g on g.NombreJugadora=j.NombreJugadora) as gana, 
                (select j.nombrejugadora,ifnull(f.vecesFinales,0) vecesFinales from jugadoras as j
                left join 
                (select Jugadora, count(*) vecesFinales
                from partidos p ,juegos ju 
                where p.idPartido=ju.partido and ronda='3'
                group by jugadora) f on f.jugadora=j.idjugadora) as finales
                where gana.nombrejugadora=finales.nombrejugadora order by gana.nombrejugadora;")
        'primera parte todas las jugadoras con las ediciones que ha ganado
        'segunda parte todas las jugadoras con las finales que ha jugado
        Dim dt As New DataTable
        dt.Columns.Add("Nombre Jugadora")
        dt.Columns.Add("Puntos conseguidos")
        dt.Columns.Add("Finales Juega")
        dt.Columns.Add("Ediciones Gana")

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
