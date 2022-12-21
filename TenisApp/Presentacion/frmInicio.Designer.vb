<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.tabTenis = New System.Windows.Forms.TabControl()
        Me.tbpJugadoras = New System.Windows.Forms.TabPage()
        Me.cboPaisJ = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPuntos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreJ = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidJ = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEliminarJ = New System.Windows.Forms.Button()
        Me.btnGuardarJ = New System.Windows.Forms.Button()
        Me.btnNuevoJ = New System.Windows.Forms.Button()
        Me.lstJugadoras = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbpPaises = New System.Windows.Forms.TabPage()
        Me.txtNombrePais = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtIDPais = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.lstPaises = New System.Windows.Forms.ListView()
        Me.IdPais = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NombrePais = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbpTorneos = New System.Windows.Forms.TabPage()
        Me.cboPaisT = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCiudadTor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombreTor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtidTor = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnEliminarT = New System.Windows.Forms.Button()
        Me.btnGuardarT = New System.Windows.Forms.Button()
        Me.btnNuevoT = New System.Windows.Forms.Button()
        Me.lstTorneos = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbpEdiciones = New System.Windows.Forms.TabPage()
        Me.datagridInfo = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnSimulacion = New System.Windows.Forms.Button()
        Me.cboTorneo = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lstEdiciones = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dtpEdicion = New System.Windows.Forms.DateTimePicker()
        Me.tbpInformeTorneo = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dgvInfo2 = New System.Windows.Forms.DataGridView()
        Me.cboEdicionInfo = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dgvInfo1 = New System.Windows.Forms.DataGridView()
        Me.cboTorneoInfo = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbpInformeJugadora = New System.Windows.Forms.TabPage()
        Me.dgvJugadoraSeleccionada = New System.Windows.Forms.DataGridView()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cboInfoJugadora = New System.Windows.Forms.ComboBox()
        Me.cboInfoTJugadora = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbpRankingJugadoras = New System.Windows.Forms.TabPage()
        Me.btnDatos = New System.Windows.Forms.Button()
        Me.dgvTodasJugadoras = New System.Windows.Forms.DataGridView()
        Me.btnTerminar = New System.Windows.Forms.Button()
        Me.tabTenis.SuspendLayout()
        Me.tbpJugadoras.SuspendLayout()
        Me.tbpPaises.SuspendLayout()
        Me.tbpTorneos.SuspendLayout()
        Me.tbpEdiciones.SuspendLayout()
        CType(Me.datagridInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpInformeTorneo.SuspendLayout()
        CType(Me.dgvInfo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpInformeJugadora.SuspendLayout()
        CType(Me.dgvJugadoraSeleccionada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpRankingJugadoras.SuspendLayout()
        CType(Me.dgvTodasJugadoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(16, 422)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(96, 40)
        Me.btnConectar.TabIndex = 0
        Me.btnConectar.Text = "CONECTAR BD"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'tabTenis
        '
        Me.tabTenis.Controls.Add(Me.tbpJugadoras)
        Me.tabTenis.Controls.Add(Me.tbpPaises)
        Me.tabTenis.Controls.Add(Me.tbpTorneos)
        Me.tabTenis.Controls.Add(Me.tbpEdiciones)
        Me.tabTenis.Controls.Add(Me.tbpInformeTorneo)
        Me.tabTenis.Controls.Add(Me.tbpInformeJugadora)
        Me.tabTenis.Controls.Add(Me.tbpRankingJugadoras)
        Me.tabTenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabTenis.ItemSize = New System.Drawing.Size(200, 30)
        Me.tabTenis.Location = New System.Drawing.Point(38, 12)
        Me.tabTenis.Name = "tabTenis"
        Me.tabTenis.SelectedIndex = 0
        Me.tabTenis.Size = New System.Drawing.Size(851, 404)
        Me.tabTenis.TabIndex = 1
        '
        'tbpJugadoras
        '
        Me.tbpJugadoras.Controls.Add(Me.cboPaisJ)
        Me.tbpJugadoras.Controls.Add(Me.Label5)
        Me.tbpJugadoras.Controls.Add(Me.txtPuntos)
        Me.tbpJugadoras.Controls.Add(Me.Label4)
        Me.tbpJugadoras.Controls.Add(Me.dtpFecha)
        Me.tbpJugadoras.Controls.Add(Me.Label3)
        Me.tbpJugadoras.Controls.Add(Me.txtNombreJ)
        Me.tbpJugadoras.Controls.Add(Me.Label1)
        Me.tbpJugadoras.Controls.Add(Me.txtidJ)
        Me.tbpJugadoras.Controls.Add(Me.Label2)
        Me.tbpJugadoras.Controls.Add(Me.btnEliminarJ)
        Me.tbpJugadoras.Controls.Add(Me.btnGuardarJ)
        Me.tbpJugadoras.Controls.Add(Me.btnNuevoJ)
        Me.tbpJugadoras.Controls.Add(Me.lstJugadoras)
        Me.tbpJugadoras.Location = New System.Drawing.Point(4, 34)
        Me.tbpJugadoras.Name = "tbpJugadoras"
        Me.tbpJugadoras.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpJugadoras.Size = New System.Drawing.Size(843, 366)
        Me.tbpJugadoras.TabIndex = 0
        Me.tbpJugadoras.Text = "JUGADORAS"
        Me.tbpJugadoras.UseVisualStyleBackColor = True
        '
        'cboPaisJ
        '
        Me.cboPaisJ.FormattingEnabled = True
        Me.cboPaisJ.Location = New System.Drawing.Point(542, 208)
        Me.cboPaisJ.Name = "cboPaisJ"
        Me.cboPaisJ.Size = New System.Drawing.Size(103, 24)
        Me.cboPaisJ.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(494, 212)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Pais:"
        '
        'txtPuntos
        '
        Me.txtPuntos.Location = New System.Drawing.Point(543, 171)
        Me.txtPuntos.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPuntos.Name = "txtPuntos"
        Me.txtPuntos.Size = New System.Drawing.Size(75, 22)
        Me.txtPuntos.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(480, 171)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Puntos:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(543, 132)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(284, 22)
        Me.dtpFecha.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(402, 132)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Fecha Nacimiento:"
        '
        'txtNombreJ
        '
        Me.txtNombreJ.Location = New System.Drawing.Point(543, 92)
        Me.txtNombreJ.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreJ.Name = "txtNombreJ"
        Me.txtNombreJ.Size = New System.Drawing.Size(163, 22)
        Me.txtNombreJ.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(472, 95)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Nombre:"
        '
        'txtidJ
        '
        Me.txtidJ.Enabled = False
        Me.txtidJ.Location = New System.Drawing.Point(543, 51)
        Me.txtidJ.Margin = New System.Windows.Forms.Padding(2)
        Me.txtidJ.Name = "txtidJ"
        Me.txtidJ.Size = New System.Drawing.Size(42, 22)
        Me.txtidJ.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(444, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Id Jugadora:"
        '
        'btnEliminarJ
        '
        Me.btnEliminarJ.Location = New System.Drawing.Point(609, 276)
        Me.btnEliminarJ.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminarJ.Name = "btnEliminarJ"
        Me.btnEliminarJ.Size = New System.Drawing.Size(74, 39)
        Me.btnEliminarJ.TabIndex = 19
        Me.btnEliminarJ.Text = "Eliminar"
        Me.btnEliminarJ.UseVisualStyleBackColor = True
        '
        'btnGuardarJ
        '
        Me.btnGuardarJ.Location = New System.Drawing.Point(510, 276)
        Me.btnGuardarJ.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardarJ.Name = "btnGuardarJ"
        Me.btnGuardarJ.Size = New System.Drawing.Size(80, 39)
        Me.btnGuardarJ.TabIndex = 18
        Me.btnGuardarJ.Text = "Guardar"
        Me.btnGuardarJ.UseVisualStyleBackColor = True
        '
        'btnNuevoJ
        '
        Me.btnNuevoJ.Location = New System.Drawing.Point(414, 276)
        Me.btnNuevoJ.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNuevoJ.Name = "btnNuevoJ"
        Me.btnNuevoJ.Size = New System.Drawing.Size(74, 39)
        Me.btnNuevoJ.TabIndex = 17
        Me.btnNuevoJ.Text = "Nuevo"
        Me.btnNuevoJ.UseVisualStyleBackColor = True
        '
        'lstJugadoras
        '
        Me.lstJugadoras.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lstJugadoras.FullRowSelect = True
        Me.lstJugadoras.HideSelection = False
        Me.lstJugadoras.Location = New System.Drawing.Point(27, 48)
        Me.lstJugadoras.MultiSelect = False
        Me.lstJugadoras.Name = "lstJugadoras"
        Me.lstJugadoras.Size = New System.Drawing.Size(356, 264)
        Me.lstJugadoras.TabIndex = 1
        Me.lstJugadoras.UseCompatibleStateImageBehavior = False
        Me.lstJugadoras.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "F_Nac"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Puntos"
        Me.ColumnHeader4.Width = 70
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Pais"
        Me.ColumnHeader5.Width = 50
        '
        'tbpPaises
        '
        Me.tbpPaises.Controls.Add(Me.txtNombrePais)
        Me.tbpPaises.Controls.Add(Me.lblNombre)
        Me.tbpPaises.Controls.Add(Me.txtIDPais)
        Me.tbpPaises.Controls.Add(Me.lblID)
        Me.tbpPaises.Controls.Add(Me.btnEliminar)
        Me.tbpPaises.Controls.Add(Me.btnGuardar)
        Me.tbpPaises.Controls.Add(Me.btnNuevo)
        Me.tbpPaises.Controls.Add(Me.lstPaises)
        Me.tbpPaises.Location = New System.Drawing.Point(4, 34)
        Me.tbpPaises.Name = "tbpPaises"
        Me.tbpPaises.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpPaises.Size = New System.Drawing.Size(843, 366)
        Me.tbpPaises.TabIndex = 1
        Me.tbpPaises.Text = "PAISES"
        Me.tbpPaises.UseVisualStyleBackColor = True
        '
        'txtNombrePais
        '
        Me.txtNombrePais.Location = New System.Drawing.Point(325, 184)
        Me.txtNombrePais.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombrePais.Name = "txtNombrePais"
        Me.txtNombrePais.Size = New System.Drawing.Size(185, 22)
        Me.txtNombrePais.TabIndex = 16
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(324, 158)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(101, 16)
        Me.lblNombre.TabIndex = 15
        Me.lblNombre.Text = "Nombre Pais:"
        '
        'txtIDPais
        '
        Me.txtIDPais.Location = New System.Drawing.Point(325, 119)
        Me.txtIDPais.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIDPais.Name = "txtIDPais"
        Me.txtIDPais.Size = New System.Drawing.Size(101, 22)
        Me.txtIDPais.TabIndex = 14
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(323, 94)
        Me.lblID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(132, 16)
        Me.lblID.TabIndex = 13
        Me.lblID.Text = "ID PAIS (3 CHAR):"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(502, 276)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(74, 39)
        Me.btnEliminar.TabIndex = 12
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(403, 276)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(80, 39)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(307, 276)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(74, 39)
        Me.btnNuevo.TabIndex = 10
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'lstPaises
        '
        Me.lstPaises.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IdPais, Me.NombrePais})
        Me.lstPaises.FullRowSelect = True
        Me.lstPaises.HideSelection = False
        Me.lstPaises.Location = New System.Drawing.Point(30, 51)
        Me.lstPaises.MultiSelect = False
        Me.lstPaises.Name = "lstPaises"
        Me.lstPaises.Size = New System.Drawing.Size(224, 264)
        Me.lstPaises.TabIndex = 0
        Me.lstPaises.UseCompatibleStateImageBehavior = False
        Me.lstPaises.View = System.Windows.Forms.View.Details
        '
        'IdPais
        '
        Me.IdPais.Text = "IdPais"
        Me.IdPais.Width = 70
        '
        'NombrePais
        '
        Me.NombrePais.Text = "NombrePais"
        Me.NombrePais.Width = 140
        '
        'tbpTorneos
        '
        Me.tbpTorneos.Controls.Add(Me.cboPaisT)
        Me.tbpTorneos.Controls.Add(Me.Label6)
        Me.tbpTorneos.Controls.Add(Me.txtCiudadTor)
        Me.tbpTorneos.Controls.Add(Me.Label7)
        Me.tbpTorneos.Controls.Add(Me.txtNombreTor)
        Me.tbpTorneos.Controls.Add(Me.Label9)
        Me.tbpTorneos.Controls.Add(Me.txtidTor)
        Me.tbpTorneos.Controls.Add(Me.Label10)
        Me.tbpTorneos.Controls.Add(Me.btnEliminarT)
        Me.tbpTorneos.Controls.Add(Me.btnGuardarT)
        Me.tbpTorneos.Controls.Add(Me.btnNuevoT)
        Me.tbpTorneos.Controls.Add(Me.lstTorneos)
        Me.tbpTorneos.Location = New System.Drawing.Point(4, 34)
        Me.tbpTorneos.Name = "tbpTorneos"
        Me.tbpTorneos.Size = New System.Drawing.Size(843, 366)
        Me.tbpTorneos.TabIndex = 2
        Me.tbpTorneos.Text = "TORNEOS"
        Me.tbpTorneos.UseVisualStyleBackColor = True
        '
        'cboPaisT
        '
        Me.cboPaisT.FormattingEnabled = True
        Me.cboPaisT.Location = New System.Drawing.Point(536, 172)
        Me.cboPaisT.Name = "cboPaisT"
        Me.cboPaisT.Size = New System.Drawing.Size(104, 24)
        Me.cboPaisT.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(488, 176)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Pais:"
        '
        'txtCiudadTor
        '
        Me.txtCiudadTor.Location = New System.Drawing.Point(537, 135)
        Me.txtCiudadTor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCiudadTor.Name = "txtCiudadTor"
        Me.txtCiudadTor.Size = New System.Drawing.Size(210, 22)
        Me.txtCiudadTor.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(474, 135)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 16)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Ciudad:"
        '
        'txtNombreTor
        '
        Me.txtNombreTor.Location = New System.Drawing.Point(537, 94)
        Me.txtNombreTor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreTor.Name = "txtNombreTor"
        Me.txtNombreTor.Size = New System.Drawing.Size(210, 22)
        Me.txtNombreTor.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(404, 97)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 16)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Nombre_Torneo:"
        '
        'txtidTor
        '
        Me.txtidTor.Enabled = False
        Me.txtidTor.Location = New System.Drawing.Point(537, 53)
        Me.txtidTor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtidTor.Name = "txtidTor"
        Me.txtidTor.Size = New System.Drawing.Size(42, 22)
        Me.txtidTor.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(450, 53)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 16)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Id Torneo:"
        '
        'btnEliminarT
        '
        Me.btnEliminarT.Location = New System.Drawing.Point(603, 278)
        Me.btnEliminarT.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminarT.Name = "btnEliminarT"
        Me.btnEliminarT.Size = New System.Drawing.Size(74, 39)
        Me.btnEliminarT.TabIndex = 34
        Me.btnEliminarT.Text = "Eliminar"
        Me.btnEliminarT.UseVisualStyleBackColor = True
        '
        'btnGuardarT
        '
        Me.btnGuardarT.Location = New System.Drawing.Point(504, 278)
        Me.btnGuardarT.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardarT.Name = "btnGuardarT"
        Me.btnGuardarT.Size = New System.Drawing.Size(80, 39)
        Me.btnGuardarT.TabIndex = 33
        Me.btnGuardarT.Text = "Guardar"
        Me.btnGuardarT.UseVisualStyleBackColor = True
        '
        'btnNuevoT
        '
        Me.btnNuevoT.Location = New System.Drawing.Point(408, 278)
        Me.btnNuevoT.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNuevoT.Name = "btnNuevoT"
        Me.btnNuevoT.Size = New System.Drawing.Size(74, 39)
        Me.btnNuevoT.TabIndex = 32
        Me.btnNuevoT.Text = "Nuevo"
        Me.btnNuevoT.UseVisualStyleBackColor = True
        '
        'lstTorneos
        '
        Me.lstTorneos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lstTorneos.FullRowSelect = True
        Me.lstTorneos.HideSelection = False
        Me.lstTorneos.Location = New System.Drawing.Point(21, 50)
        Me.lstTorneos.MultiSelect = False
        Me.lstTorneos.Name = "lstTorneos"
        Me.lstTorneos.Size = New System.Drawing.Size(356, 264)
        Me.lstTorneos.TabIndex = 31
        Me.lstTorneos.UseCompatibleStateImageBehavior = False
        Me.lstTorneos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Id"
        Me.ColumnHeader6.Width = 0
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Nombre_Tor"
        Me.ColumnHeader7.Width = 130
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Ciudad"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Pais"
        Me.ColumnHeader10.Width = 50
        '
        'tbpEdiciones
        '
        Me.tbpEdiciones.Controls.Add(Me.datagridInfo)
        Me.tbpEdiciones.Controls.Add(Me.Label12)
        Me.tbpEdiciones.Controls.Add(Me.btnSimulacion)
        Me.tbpEdiciones.Controls.Add(Me.cboTorneo)
        Me.tbpEdiciones.Controls.Add(Me.Label11)
        Me.tbpEdiciones.Controls.Add(Me.Label8)
        Me.tbpEdiciones.Controls.Add(Me.lstEdiciones)
        Me.tbpEdiciones.Controls.Add(Me.dtpEdicion)
        Me.tbpEdiciones.Location = New System.Drawing.Point(4, 34)
        Me.tbpEdiciones.Name = "tbpEdiciones"
        Me.tbpEdiciones.Size = New System.Drawing.Size(843, 366)
        Me.tbpEdiciones.TabIndex = 3
        Me.tbpEdiciones.Text = "EDICIONES"
        Me.tbpEdiciones.UseVisualStyleBackColor = True
        '
        'datagridInfo
        '
        Me.datagridInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.datagridInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridInfo.Location = New System.Drawing.Point(370, 32)
        Me.datagridInfo.Name = "datagridInfo"
        Me.datagridInfo.RowHeadersVisible = False
        Me.datagridInfo.Size = New System.Drawing.Size(457, 313)
        Me.datagridInfo.TabIndex = 50
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(390, 13)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 16)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "InfoEdicion:"
        '
        'btnSimulacion
        '
        Me.btnSimulacion.Location = New System.Drawing.Point(252, 308)
        Me.btnSimulacion.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSimulacion.Name = "btnSimulacion"
        Me.btnSimulacion.Size = New System.Drawing.Size(93, 39)
        Me.btnSimulacion.TabIndex = 47
        Me.btnSimulacion.Text = "Simulacion"
        Me.btnSimulacion.UseVisualStyleBackColor = True
        '
        'cboTorneo
        '
        Me.cboTorneo.FormattingEnabled = True
        Me.cboTorneo.Location = New System.Drawing.Point(89, 295)
        Me.cboTorneo.Name = "cboTorneo"
        Me.cboTorneo.Size = New System.Drawing.Size(155, 24)
        Me.cboTorneo.TabIndex = 46
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 299)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 16)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Torneo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 330)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 16)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Edicion:"
        '
        'lstEdiciones
        '
        Me.lstEdiciones.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader8, Me.ColumnHeader12, Me.ColumnHeader14, Me.ColumnHeader13})
        Me.lstEdiciones.FullRowSelect = True
        Me.lstEdiciones.HideSelection = False
        Me.lstEdiciones.Location = New System.Drawing.Point(16, 13)
        Me.lstEdiciones.MultiSelect = False
        Me.lstEdiciones.Name = "lstEdiciones"
        Me.lstEdiciones.Size = New System.Drawing.Size(328, 264)
        Me.lstEdiciones.TabIndex = 32
        Me.lstEdiciones.UseCompatibleStateImageBehavior = False
        Me.lstEdiciones.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Año_Edicion"
        Me.ColumnHeader11.Width = 110
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.DisplayIndex = 3
        Me.ColumnHeader8.Width = 0
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.DisplayIndex = 1
        Me.ColumnHeader12.Text = "Nombre_Torneo"
        Me.ColumnHeader12.Width = 130
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.DisplayIndex = 4
        Me.ColumnHeader14.Width = 0
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.DisplayIndex = 2
        Me.ColumnHeader13.Text = "Ganadora"
        Me.ColumnHeader13.Width = 100
        '
        'dtpEdicion
        '
        Me.dtpEdicion.CustomFormat = "yyyy"
        Me.dtpEdicion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEdicion.Location = New System.Drawing.Point(89, 325)
        Me.dtpEdicion.Name = "dtpEdicion"
        Me.dtpEdicion.Size = New System.Drawing.Size(115, 22)
        Me.dtpEdicion.TabIndex = 0
        '
        'tbpInformeTorneo
        '
        Me.tbpInformeTorneo.Controls.Add(Me.Label16)
        Me.tbpInformeTorneo.Controls.Add(Me.dgvInfo2)
        Me.tbpInformeTorneo.Controls.Add(Me.cboEdicionInfo)
        Me.tbpInformeTorneo.Controls.Add(Me.Label15)
        Me.tbpInformeTorneo.Controls.Add(Me.Label14)
        Me.tbpInformeTorneo.Controls.Add(Me.dgvInfo1)
        Me.tbpInformeTorneo.Controls.Add(Me.cboTorneoInfo)
        Me.tbpInformeTorneo.Controls.Add(Me.Label13)
        Me.tbpInformeTorneo.Location = New System.Drawing.Point(4, 34)
        Me.tbpInformeTorneo.Name = "tbpInformeTorneo"
        Me.tbpInformeTorneo.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpInformeTorneo.Size = New System.Drawing.Size(843, 366)
        Me.tbpInformeTorneo.TabIndex = 4
        Me.tbpInformeTorneo.Text = "Informe Torneo"
        Me.tbpInformeTorneo.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(375, 53)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 16)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Partidos-Ronda..."
        '
        'dgvInfo2
        '
        Me.dgvInfo2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvInfo2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInfo2.Location = New System.Drawing.Point(378, 84)
        Me.dgvInfo2.Name = "dgvInfo2"
        Me.dgvInfo2.RowHeadersVisible = False
        Me.dgvInfo2.Size = New System.Drawing.Size(459, 261)
        Me.dgvInfo2.TabIndex = 56
        '
        'cboEdicionInfo
        '
        Me.cboEdicionInfo.FormattingEnabled = True
        Me.cboEdicionInfo.Location = New System.Drawing.Point(446, 19)
        Me.cboEdicionInfo.Name = "cboEdicionInfo"
        Me.cboEdicionInfo.Size = New System.Drawing.Size(155, 24)
        Me.cboEdicionInfo.TabIndex = 55
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(377, 24)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 16)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Edicion:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(21, 53)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(149, 16)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Ediciones Ganadora"
        '
        'dgvInfo1
        '
        Me.dgvInfo1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvInfo1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInfo1.Location = New System.Drawing.Point(24, 84)
        Me.dgvInfo1.Name = "dgvInfo1"
        Me.dgvInfo1.RowHeadersVisible = False
        Me.dgvInfo1.Size = New System.Drawing.Size(301, 261)
        Me.dgvInfo1.TabIndex = 51
        '
        'cboTorneoInfo
        '
        Me.cboTorneoInfo.FormattingEnabled = True
        Me.cboTorneoInfo.Location = New System.Drawing.Point(170, 19)
        Me.cboTorneoInfo.Name = "cboTorneoInfo"
        Me.cboTorneoInfo.Size = New System.Drawing.Size(155, 24)
        Me.cboTorneoInfo.TabIndex = 48
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 22)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(143, 16)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Selecciona Torneo:"
        '
        'tbpInformeJugadora
        '
        Me.tbpInformeJugadora.Controls.Add(Me.dgvJugadoraSeleccionada)
        Me.tbpInformeJugadora.Controls.Add(Me.Label18)
        Me.tbpInformeJugadora.Controls.Add(Me.cboInfoJugadora)
        Me.tbpInformeJugadora.Controls.Add(Me.cboInfoTJugadora)
        Me.tbpInformeJugadora.Controls.Add(Me.Label17)
        Me.tbpInformeJugadora.Location = New System.Drawing.Point(4, 34)
        Me.tbpInformeJugadora.Name = "tbpInformeJugadora"
        Me.tbpInformeJugadora.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpInformeJugadora.Size = New System.Drawing.Size(843, 366)
        Me.tbpInformeJugadora.TabIndex = 5
        Me.tbpInformeJugadora.Text = "Informe Jugadora"
        Me.tbpInformeJugadora.UseVisualStyleBackColor = True
        '
        'dgvJugadoraSeleccionada
        '
        Me.dgvJugadoraSeleccionada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvJugadoraSeleccionada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJugadoraSeleccionada.Location = New System.Drawing.Point(51, 73)
        Me.dgvJugadoraSeleccionada.Name = "dgvJugadoraSeleccionada"
        Me.dgvJugadoraSeleccionada.RowHeadersVisible = False
        Me.dgvJugadoraSeleccionada.Size = New System.Drawing.Size(727, 272)
        Me.dgvJugadoraSeleccionada.TabIndex = 57
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(412, 19)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(222, 35)
        Me.Label18.TabIndex = 52
        Me.Label18.Text = "Selecciona Jugadora participa en torneo seleccionado:"
        '
        'cboInfoJugadora
        '
        Me.cboInfoJugadora.FormattingEnabled = True
        Me.cboInfoJugadora.Location = New System.Drawing.Point(639, 30)
        Me.cboInfoJugadora.Name = "cboInfoJugadora"
        Me.cboInfoJugadora.Size = New System.Drawing.Size(155, 24)
        Me.cboInfoJugadora.TabIndex = 51
        '
        'cboInfoTJugadora
        '
        Me.cboInfoTJugadora.FormattingEnabled = True
        Me.cboInfoTJugadora.Location = New System.Drawing.Point(165, 30)
        Me.cboInfoTJugadora.Name = "cboInfoTJugadora"
        Me.cboInfoTJugadora.Size = New System.Drawing.Size(155, 24)
        Me.cboInfoTJugadora.TabIndex = 50
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(16, 30)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(143, 16)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "Selecciona Torneo:"
        '
        'tbpRankingJugadoras
        '
        Me.tbpRankingJugadoras.Controls.Add(Me.btnDatos)
        Me.tbpRankingJugadoras.Controls.Add(Me.dgvTodasJugadoras)
        Me.tbpRankingJugadoras.Location = New System.Drawing.Point(4, 34)
        Me.tbpRankingJugadoras.Name = "tbpRankingJugadoras"
        Me.tbpRankingJugadoras.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpRankingJugadoras.Size = New System.Drawing.Size(843, 366)
        Me.tbpRankingJugadoras.TabIndex = 6
        Me.tbpRankingJugadoras.Text = "Datos Todas Jugadoras"
        Me.tbpRankingJugadoras.UseVisualStyleBackColor = True
        '
        'btnDatos
        '
        Me.btnDatos.Location = New System.Drawing.Point(34, 6)
        Me.btnDatos.Name = "btnDatos"
        Me.btnDatos.Size = New System.Drawing.Size(155, 36)
        Me.btnDatos.TabIndex = 59
        Me.btnDatos.Text = "VER DATOS"
        Me.btnDatos.UseVisualStyleBackColor = True
        '
        'dgvTodasJugadoras
        '
        Me.dgvTodasJugadoras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvTodasJugadoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTodasJugadoras.Location = New System.Drawing.Point(34, 48)
        Me.dgvTodasJugadoras.Name = "dgvTodasJugadoras"
        Me.dgvTodasJugadoras.RowHeadersVisible = False
        Me.dgvTodasJugadoras.Size = New System.Drawing.Size(783, 294)
        Me.dgvTodasJugadoras.TabIndex = 58
        '
        'btnTerminar
        '
        Me.btnTerminar.Location = New System.Drawing.Point(118, 422)
        Me.btnTerminar.Name = "btnTerminar"
        Me.btnTerminar.Size = New System.Drawing.Size(96, 40)
        Me.btnTerminar.TabIndex = 2
        Me.btnTerminar.Text = "TERMINAR"
        Me.btnTerminar.UseVisualStyleBackColor = True
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 474)
        Me.Controls.Add(Me.btnTerminar)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.tabTenis)
        Me.Name = "frmInicio"
        Me.Text = "Inicio"
        Me.tabTenis.ResumeLayout(False)
        Me.tbpJugadoras.ResumeLayout(False)
        Me.tbpJugadoras.PerformLayout()
        Me.tbpPaises.ResumeLayout(False)
        Me.tbpPaises.PerformLayout()
        Me.tbpTorneos.ResumeLayout(False)
        Me.tbpTorneos.PerformLayout()
        Me.tbpEdiciones.ResumeLayout(False)
        Me.tbpEdiciones.PerformLayout()
        CType(Me.datagridInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpInformeTorneo.ResumeLayout(False)
        Me.tbpInformeTorneo.PerformLayout()
        CType(Me.dgvInfo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpInformeJugadora.ResumeLayout(False)
        Me.tbpInformeJugadora.PerformLayout()
        CType(Me.dgvJugadoraSeleccionada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpRankingJugadoras.ResumeLayout(False)
        CType(Me.dgvTodasJugadoras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnConectar As Button
    Friend WithEvents tabTenis As TabControl
    Friend WithEvents tbpJugadoras As TabPage
    Friend WithEvents tbpPaises As TabPage
    Friend WithEvents tbpTorneos As TabPage
    Friend WithEvents lstPaises As ListView
    Friend WithEvents txtNombrePais As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtIDPais As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents IdPais As ColumnHeader
    Friend WithEvents NombrePais As ColumnHeader
    Friend WithEvents btnTerminar As Button
    Friend WithEvents cboPaisJ As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPuntos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombreJ As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidJ As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEliminarJ As Button
    Friend WithEvents btnGuardarJ As Button
    Friend WithEvents btnNuevoJ As Button
    Friend WithEvents lstJugadoras As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents cboPaisT As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCiudadTor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNombreTor As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtidTor As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnEliminarT As Button
    Friend WithEvents btnGuardarT As Button
    Friend WithEvents btnNuevoT As Button
    Friend WithEvents lstTorneos As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents tbpEdiciones As TabPage
    Friend WithEvents dtpEdicion As DateTimePicker
    Friend WithEvents btnSimulacion As Button
    Friend WithEvents cboTorneo As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lstEdiciones As ListView
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents Label12 As Label
    Friend WithEvents datagridInfo As DataGridView
    Friend WithEvents tbpInformeTorneo As TabPage
    Friend WithEvents Label16 As Label
    Friend WithEvents dgvInfo2 As DataGridView
    Friend WithEvents cboEdicionInfo As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents dgvInfo1 As DataGridView
    Friend WithEvents cboTorneoInfo As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents tbpInformeJugadora As TabPage
    Friend WithEvents Label18 As Label
    Friend WithEvents cboInfoJugadora As ComboBox
    Friend WithEvents cboInfoTJugadora As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents dgvJugadoraSeleccionada As DataGridView
    Friend WithEvents tbpRankingJugadoras As TabPage
    Friend WithEvents btnDatos As Button
    Friend WithEvents dgvTodasJugadoras As DataGridView
End Class
