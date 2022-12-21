Public Class frmInicio
    Function numAleatorioEntre(ByVal minimo As Integer, ByVal maximo As Integer) As Integer
        Randomize()
        Return CLng((minimo - maximo) * Rnd() + maximo)
    End Function
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        'Conectar con la base de datos, mirar contraseña

        Dim item As ListViewItem
        Dim p As New Pais
        Dim j As New Jugadora
        Dim t As New Torneo
        Dim ed As New Edicion

        Try 'Leer dato de base de datos
            p.LeerTodosPaises()
            j.LeerTodasJugadoras()
            t.LeerTodosTorneos()
            ed.LeerTodasEdiciones()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        For Each pp As Pais In p.paDAO.Paises
            item = New ListViewItem(pp.idPais)
            item.SubItems.Add(pp.NombrePais)
            lstPaises.Items.Add(item) 'añado los items a la listview
            cboPaisJ.Items.Add(pp.idPais)
            cboPaisT.Items.Add(pp.idPais)

        Next
        btnNuevo.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo_Click("", Nothing) 'Limpia los campos 

        For Each jj As Jugadora In j.jugaDAO.Jugadoras
            item = New ListViewItem(jj.idJugadora)
            item.SubItems.Add(jj.NombreJugadora)
            item.SubItems.Add(jj.FechaNacimientoJugadora)
            item.SubItems.Add(jj.PuntosJugadora)
            item.SubItems.Add(jj.PaisJugadora.idPais)
            lstJugadoras.Items.Add(item) 'añado los items a la listview
        Next
        btnNuevoJ.Enabled = True
        btnEliminarJ.Enabled = True
        btnNuevoJ_Click("", Nothing)

        For Each tt As Torneo In t.toDAO.Torneos
            item = New ListViewItem(tt.idTorneo)
            item.SubItems.Add(tt.NombreTorneo)
            item.SubItems.Add(tt.CiudadTorneo)
            item.SubItems.Add(tt.PaisTorneo.idPais)
            lstTorneos.Items.Add(item) 'añado los items a la listview
            cboTorneo.Items.Add(tt.NombreTorneo)
            cboTorneoInfo.Items.Add(tt.NombreTorneo)
            cboInfoTJugadora.Items.Add(tt.NombreTorneo)
        Next
        btnNuevoT.Enabled = True
        btnEliminarT.Enabled = True
        btnNuevoT_Click("", Nothing)

        For Each edi As Edicion In ed.toDAO.Ediciones
            item = New ListViewItem(edi.anualidad)
            item.SubItems.Add(edi.torneo.idTorneo)
            edi.ganadora.LeerJugadora()
            edi.torneo.LeerTorneo()
            item.SubItems.Add(edi.torneo.NombreTorneo)
            item.SubItems.Add(edi.ganadora.idJugadora)
            edi.ganadora.LeerJugadora()
            item.SubItems.Add(edi.ganadora.NombreJugadora)
            lstEdiciones.Items.Add(item) 'añado los items a la listview
        Next


        btnConectar.Enabled = False
        tabTenis.Enabled = True
    End Sub

    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'No se puede utilzar la aplicación hasta que estes conectado en la base de datos
        tabTenis.Enabled = False
        btnConectar.Enabled = True


    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'Limpia los campos
        btnGuardar.Enabled = True
        btnEliminar.Enabled = False
        btnNuevo.Enabled = False
        Me.txtIDPais.Enabled = False
        txtIDPais.Text = String.Empty
        txtNombrePais.Text = String.Empty
    End Sub

    Private Sub btnTerminar_Click(sender As Object, e As EventArgs) Handles btnTerminar.Click
        End
    End Sub

    Private Sub lstPaises_Click(sender As Object, e As EventArgs) Handles lstPaises.Click
        Me.btnNuevo.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.btnGuardar.Enabled = True
        Me.txtIDPais.Enabled = False

        If Not Me.lstPaises.SelectedItems(0) Is Nothing Then
            Dim i As Integer = lstPaises.FocusedItem.Index ' coger la fila seleccionada
            Try
                txtIDPais.Text = lstPaises.Items(i).SubItems(0).Text 'para coger el id del Pais
                txtNombrePais.Text = lstPaises.Items(i).SubItems(1).Text 'para coger el nombre del Pais
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Guardar o actualizar un país
        Dim p As Pais
        If Me.txtNombrePais.Text <> String.Empty Then
            p = New Pais(Mid(txtNombrePais.Text, 1, 3).ToUpper)
            p.NombrePais = txtNombrePais.Text
            Try
                If btnNuevo.Enabled Then
                    If p.ActualizarPais <> 1 Then
                        MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    lstPaises.SelectedItems(0).SubItems(1).Text = p.NombrePais
                    MessageBox.Show(p.NombrePais.ToString & " Actualizado correctamente")

                Else
                    If p.InsertarPais <> 1 Then
                        MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    Dim item As New ListViewItem(p.idPais)
                    item.SubItems.Add(p.NombrePais)
                    lstPaises.Items.Add(item) 'añado los items a la list view
                    cboPaisJ.Items.Add(p.idPais)
                    cboPaisT.Items.Add(p.idPais)
                    MessageBox.Show(p.NombrePais & " Insertado correctamente")
                    btnNuevo_Click("", Nothing)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        Else
            MessageBox.Show("No puede haber ningun campo vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'Eliminar pais
        Dim p As New Pais
        If Not Me.lstPaises.SelectedItems(0) Is Nothing Then
            If MessageBox.Show("Estas seguro de que quieres eliminar " & lstPaises.SelectedItems(0).SubItems(1).Text, "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then 'para confirmar que queremos eliminar

                p = New Pais(txtIDPais.Text)
                p.NombrePais = txtNombrePais.Text
                Try
                    If p.BorrarPais <> 1 Then
                        MessageBox.Show("Error al Borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    lstPaises.Items.Remove(lstPaises.SelectedItems(0)) 'eliminamos el pais
                    cboPaisJ.Items.Remove(p.NombrePais)
                    cboPaisT.Items.Remove(p.NombrePais)
                    btnNuevo_Click("", Nothing)
                    MessageBox.Show(p.NombrePais.ToString & " Borrado correctamente")
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try

            End If
        End If
    End Sub

    Private Sub btnNuevoJ_Click(sender As Object, e As EventArgs) Handles btnNuevoJ.Click
        'Limpia los campos de jugadoras
        btnGuardarJ.Enabled = True
        btnEliminarJ.Enabled = False
        btnNuevoJ.Enabled = False
        Me.txtNombreJ.Enabled = True

        Me.txtPuntos.Enabled = False
        cboPaisJ.Enabled = True

        txtidJ.Text = String.Empty
        txtNombreJ.Text = String.Empty
        dtpFecha.Value = Now
        txtPuntos.Text = 0
        cboPaisJ.SelectedIndex = -1
    End Sub

    Private Sub lstJugadoras_Click(sender As Object, e As EventArgs) Handles lstJugadoras.Click
        'Listado de jugadoras
        Me.btnNuevoJ.Enabled = True
        Me.btnEliminarJ.Enabled = True
        Me.btnGuardarJ.Enabled = True


        If Not Me.lstJugadoras.SelectedItems(0) Is Nothing Then
            Dim i As Integer = lstJugadoras.FocusedItem.Index ' coger la fila seleccionada
            Try
                txtidJ.Text = lstJugadoras.Items(i).SubItems(0).Text 'para coger el id de la jugadora
                txtNombreJ.Text = lstJugadoras.Items(i).SubItems(1).Text 'para coger el nombre de la Jugadora
                dtpFecha.Value = lstJugadoras.Items(i).SubItems(2).Text
                txtPuntos.Text = lstJugadoras.Items(i).SubItems(3).Text
                cboPaisJ.Text = lstJugadoras.Items(i).SubItems(4).Text
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub btnGuardarJ_Click(sender As Object, e As EventArgs) Handles btnGuardarJ.Click
        'guardar o actualizar jugadora
        Dim j As Jugadora
        If Me.txtNombreJ.Text <> String.Empty And Me.txtPuntos.Text <> String.Empty And cboPaisJ.Text <> String.Empty Then
            j = New Jugadora()
            j.NombreJugadora = txtNombreJ.Text
            j.FechaNacimientoJugadora = dtpFecha.Value
            j.PuntosJugadora = Convert.ToInt32(txtPuntos.Text)
            j.PaisJugadora.idPais = cboPaisJ.Text
            Try
                If btnNuevoJ.Enabled Then

                    j.idJugadora = Convert.ToInt32(txtidJ.Text)
                    If j.ActualizarJugadora <> 1 Then
                        MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    lstJugadoras.SelectedItems(0).SubItems(1).Text = j.NombreJugadora
                    lstJugadoras.SelectedItems(0).SubItems(2).Text = j.FechaNacimientoJugadora
                    lstJugadoras.SelectedItems(0).SubItems(3).Text = j.PuntosJugadora
                    lstJugadoras.SelectedItems(0).SubItems(4).Text = j.PaisJugadora.idPais
                    MessageBox.Show(j.NombreJugadora.ToString & " Actualizado correctamente")

                Else
                    If j.InsertarJugadora <> 1 Then
                        MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    j.MaxIDJugadora()
                    Dim item As New ListViewItem(j.idJugadora)
                    item.SubItems.Add(j.NombreJugadora)
                    item.SubItems.Add(j.FechaNacimientoJugadora)
                    item.SubItems.Add(j.PuntosJugadora)
                    item.SubItems.Add(j.PaisJugadora.idPais)
                    lstJugadoras.Items.Add(item) 'añado los items a la list view

                    MessageBox.Show(j.NombreJugadora & " Insertado correctamente")
                    btnNuevoJ_Click("", Nothing)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        Else
            MessageBox.Show("No puede haber ningun campo vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEliminarJ_Click(sender As Object, e As EventArgs) Handles btnEliminarJ.Click
        'Eliminar jugadora
        Dim j As New Jugadora
        If Not Me.lstJugadoras.SelectedItems(0) Is Nothing Then
            If MessageBox.Show("Estas seguro de que quieres eliminar " & lstJugadoras.SelectedItems(0).SubItems(1).Text, "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then 'para confirmar que queremos eliminar

                j = New Jugadora(txtidJ.Text)
                j.NombreJugadora = txtNombreJ.Text
                Try
                    If j.BorrarJugadora <> 1 Then
                        MessageBox.Show("Error al Borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    lstJugadoras.Items.Remove(lstJugadoras.SelectedItems(0)) 'eliminamos la jugadora
                    btnNuevoJ_Click("", Nothing)
                    MessageBox.Show(j.NombreJugadora.ToString & " Borrado correctamente")
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try

            End If
        End If
    End Sub

    Private Sub btnNuevoT_Click(sender As Object, e As EventArgs) Handles btnNuevoT.Click
        'Limpia campos torneo
        btnGuardarT.Enabled = True
        btnEliminarT.Enabled = False
        btnNuevoT.Enabled = False
        Me.txtNombreTor.Enabled = True

        Me.txtCiudadTor.Enabled = True
        cboPaisT.Enabled = True

        txtidTor.Text = String.Empty
        txtNombreTor.Text = String.Empty
        txtCiudadTor.Text = String.Empty
        cboPaisT.SelectedIndex = -1
    End Sub

    Private Sub lstTorneos_Click(sender As Object, e As EventArgs) Handles lstTorneos.Click
        'listado de torneo
        Me.btnNuevoT.Enabled = True
        Me.btnEliminarT.Enabled = True
        Me.btnGuardarT.Enabled = True


        If Not Me.lstTorneos.SelectedItems(0) Is Nothing Then
            Dim i As Integer = lstTorneos.FocusedItem.Index ' coger la fila seleccionada
            Try
                txtidTor.Text = lstTorneos.Items(i).SubItems(0).Text 'para coger el id del torneo
                txtNombreTor.Text = lstTorneos.Items(i).SubItems(1).Text 'para coger el nombre del torneo
                txtCiudadTor.Text = lstTorneos.Items(i).SubItems(2).Text
                cboPaisT.Text = lstTorneos.Items(i).SubItems(3).Text
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub btnGuardarT_Click(sender As Object, e As EventArgs) Handles btnGuardarT.Click
        'guardar o actualizar torneo 
        Dim t As Torneo
        If Me.txtNombreTor.Text <> String.Empty And Me.txtCiudadTor.Text <> String.Empty And cboPaisT.Text <> String.Empty Then
            t = New Torneo()
            t.NombreTorneo = txtNombreTor.Text
            t.CiudadTorneo = txtCiudadTor.Text
            t.PaisTorneo.idPais = cboPaisT.Text
            Try
                If btnNuevoT.Enabled Then
                    t.idTorneo = Convert.ToInt32(txtidTor.Text)
                    If t.ActualizarTorneo <> 1 Then
                        MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    lstTorneos.SelectedItems(0).SubItems(1).Text = t.NombreTorneo
                    lstTorneos.SelectedItems(0).SubItems(2).Text = t.CiudadTorneo
                    lstTorneos.SelectedItems(0).SubItems(3).Text = t.PaisTorneo.idPais
                    MessageBox.Show(t.NombreTorneo.ToString & " Actualizado correctamente")

                Else
                    If t.InsertarTorneo <> 1 Then
                        MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    t.MaxIDTorneo()
                    Dim item As New ListViewItem(t.idTorneo)
                    item.SubItems.Add(t.NombreTorneo)
                    item.SubItems.Add(t.CiudadTorneo)
                    item.SubItems.Add(t.PaisTorneo.idPais)
                    lstTorneos.Items.Add(item) 'añado los items a la list view
                    cboTorneo.Items.Add(t.NombreTorneo)
                    cboTorneoInfo.Items.Add(t.NombreTorneo)
                    cboInfoTJugadora.Items.Add(t.NombreTorneo)

                    MessageBox.Show(t.NombreTorneo & " Insertado correctamente")
                    btnNuevoT_Click("", Nothing)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        Else
            MessageBox.Show("No puede haber ningun campo vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEliminarT_Click(sender As Object, e As EventArgs) Handles btnEliminarT.Click
        'Eliminar Torneo
        Dim t As New Torneo
        If Not Me.lstTorneos.SelectedItems(0) Is Nothing Then
            If MessageBox.Show("Estas seguro de que quieres eliminar " & lstTorneos.SelectedItems(0).SubItems(1).Text, "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then 'para confirmar que queremos eliminar

                t = New Torneo(txtidTor.Text)
                t.NombreTorneo = txtNombreTor.Text
                Try
                    If t.BorrarTorneo <> 1 Then
                        MessageBox.Show("Error al Borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    lstTorneos.Items.Remove(lstTorneos.SelectedItems(0)) 'eliminamos el torneo
                    cboTorneo.Items.Remove(t.NombreTorneo)
                    cboTorneoInfo.Items.Remove(t.NombreTorneo)
                    cboInfoTJugadora.Items.Remove(t.NombreTorneo)
                    btnNuevoT_Click("", Nothing)
                    MessageBox.Show(t.NombreTorneo.ToString & " Borrado correctamente")
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try

            End If
        End If
    End Sub

    Private Sub btnSimulacion_Click(sender As Object, e As EventArgs) Handles btnSimulacion.Click
        'Simulación del torneo
        Dim t As New Torneo()
        Dim j As New Jugadora
        Dim anio As Integer
        If cboTorneo.Text <> String.Empty Then
            t.NombreTorneo = cboTorneo.SelectedItem.ToString
            anio = Year(dtpEdicion.Value)
            t.LeerTorneoNombre()

            If Not t.existeEdicionTorneo(anio) Then

                j.Leer8JugadorasAleatorias()

                Dim lista = New List(Of Jugadora)
                For Each jj As Jugadora In j.jugaDAO.Jugadoras
                    jj.PuntosJugadora += 10
                    jj.ActualizarPuntosJugadora()
                    lista.Add(jj)
                Next
                Dim sortedList = From item In lista Order By item.PuntosJugadora Descending

                'Partidos de cuartos, ganadoras pasan a semifinales
                t.InsertarEdicionTorneo(anio, sortedList.ElementAt(0))
                Dim semifinales(3) As Jugadora
                semifinales(0) = jugarPartido(sortedList.ElementAt(0), sortedList.ElementAt(7), t, anio, "1") '1 y 8
                semifinales(1) = jugarPartido(sortedList.ElementAt(3), sortedList.ElementAt(4), t, anio, "1") ' 4 y 5
                semifinales(2) = jugarPartido(sortedList.ElementAt(1), sortedList.ElementAt(6), t, anio, "1") ' 2 y 7
                semifinales(3) = jugarPartido(sortedList.ElementAt(2), sortedList.ElementAt(5), t, anio, "1") ' 3 y 6
                For i = 0 To UBound(semifinales)
                    semifinales(i).PuntosJugadora += 25 'actualización de puntos
                    semifinales(i).ActualizarPuntosJugadora()
                Next
                Dim finalistas(1) As Jugadora
                'Partidos de semifinales, ganadoras pasn a la final
                finalistas(0) = jugarPartido(semifinales(0), semifinales(1), t, anio, "2") '1 y 2
                finalistas(1) = jugarPartido(semifinales(2), semifinales(3), t, anio, "2") ' 3 y 4
                For i = 0 To UBound(finalistas)
                    finalistas(i).PuntosJugadora += 50 'actualización de puntos
                    finalistas(i).ActualizarPuntosJugadora()
                Next

                Dim ganadorafinal As Jugadora
                ganadorafinal = jugarPartido(finalistas(0), finalistas(1), t, anio, "3") '1 y 2
                ganadorafinal.PuntosJugadora += 100 'actualización de puntos
                ganadorafinal.ActualizarPuntosJugadora()
                t.ActualizarEdicionTorneo(anio, ganadorafinal)
                Dim it As New ListViewItem(anio)
                it.SubItems.Add(t.idTorneo)
                it.SubItems.Add(t.NombreTorneo)
                it.SubItems.Add(ganadorafinal.idJugadora)
                it.SubItems.Add(ganadorafinal.NombreJugadora)
                lstEdiciones.Items.Add(it) 'añado los items a la listview

                Dim dt As New DataTable
                dt = t.InfoEdicionTorneo(anio)
                datagridInfo.DataSource = dt

            Else
                MessageBox.Show("Año de edicion ya realizada", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Hay que seleccionar un Torneo", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Function jugarPartido(ByRef j1 As Jugadora, ByRef j2 As Jugadora, ByRef t As Torneo, ByVal anualidad As Integer, ByVal ronda As Integer) As Jugadora
        'genera el resultado del partido 
        Dim aleatorio As Integer
        Dim gana1(2) As Integer
        Dim gana2(2) As Integer
        Dim ganados1 As Integer = 0

        Dim p As New Partido()
        p.anualidad = anualidad
        p.torneo = t
        p.ronda = ronda
        For i = 0 To 2
            'en caso de que una jugadora haya ganado 2 set
            If i = 2 And ((gana1(0) = 6 And gana1(1) = 6) Or (gana2(0) = 6 And gana2(1) = 6)) Then
                gana1(i) = 0
                gana2(i) = 0
            Else

                aleatorio = numAleatorioEntre(1, 2) 'elige la ganadora del set
                If aleatorio = 1 Then
                    gana1(i) = 6
                    gana2(i) = numAleatorioEntre(0, 4)
                    ganados1 += 1
                Else
                    gana2(i) = 6
                    gana1(i) = numAleatorioEntre(0, 4)
                End If
            End If
        Next
        'se decide la ganadora en función de los set ganados
        If ganados1 = 2 Then
            p.ganadora = j1
        Else
            p.ganadora = j2
        End If

        p.InsertarPartido()
        p.MaxIDPartido()

        p.InsertarJuegoPartido(j1, gana1(0), gana1(1), gana1(2))
        p.InsertarJuegoPartido(j2, gana2(0), gana2(1), gana2(2))

        Return p.ganadora

    End Function

    Private Sub lstEdiciones_Click(sender As Object, e As EventArgs) Handles lstEdiciones.Click
        'listado de ediciones
        Dim dt As New DataTable
        Dim i As Integer = lstEdiciones.FocusedItem.Index
        Dim t As New Torneo(Convert.ToInt32(lstEdiciones.Items(i).SubItems(1).Text))
        dt = t.InfoEdicionTorneo(Convert.ToInt32(lstEdiciones.Items(i).SubItems(0).Text))

        datagridInfo.DataSource = dt
    End Sub

    Private Sub cboTorneoInfo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTorneoInfo.SelectedIndexChanged
        dgvInfo2.DataSource = Nothing
        cboEdicionInfo.Text = ""
        Dim dt As New DataTable
        Dim t As New Torneo()
        cboEdicionInfo.Items.Clear()
        t.NombreTorneo = cboTorneoInfo.Text
        t.LeerTorneoNombre()
        t.LeerAnualidadesTorneo()

        For Each a As Integer In t.toDAO.Ediciones
            cboEdicionInfo.Items.Add(a)
        Next
        dt = t.InfoEdicionGanadora()

        dgvInfo1.DataSource = dt

    End Sub

    Private Sub cboEdicionInfo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEdicionInfo.SelectedIndexChanged
        Dim dt As New DataTable
        Dim t As New Torneo()

        t.NombreTorneo = cboTorneoInfo.Text
        t.LeerTorneoNombre()

        dt = t.InfoEdicionTorneo(cboEdicionInfo.Text)

        dgvInfo2.DataSource = dt

    End Sub

    Private Sub cboInfoTJugadora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInfoTJugadora.SelectedIndexChanged
        dgvJugadoraSeleccionada.DataSource = Nothing
        Dim t As New Torneo()
        Dim j As New Jugadora
        cboInfoJugadora.Items.Clear()
        t.NombreTorneo = cboInfoTJugadora.Text
        t.LeerTorneoNombre()
        j.LeerJugadorasTorneoInfo(t)

        For Each jj As Jugadora In j.jugaDAO.Jugadoras
            cboInfoJugadora.Items.Add(jj.NombreJugadora)
        Next
    End Sub

    Private Sub cboInfoJugadora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInfoJugadora.SelectedIndexChanged
        Dim dt As New DataTable
        Dim t As New Torneo()
        Dim j As New Jugadora

        t.NombreTorneo = cboInfoTJugadora.Text
        t.LeerTorneoNombre()
        j.NombreJugadora = cboInfoJugadora.Text

        dt = j.InfoTorneoJugadoraEdiciones(t)

        dgvJugadoraSeleccionada.DataSource = dt

    End Sub

    Private Sub btnDatos_Click(sender As Object, e As EventArgs) Handles btnDatos.Click
        Dim j As New Jugadora
        Dim dt As New DataTable
        dt = j.DatosJugadorasCompleto()
        dgvTodasJugadoras.DataSource = dt
    End Sub
End Class
