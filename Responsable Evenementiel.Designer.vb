<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Responsable_Evenementiel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Responsable_Evenementiel))
        Me.data_membre = New System.Windows.Forms.DataGridView()
        Me.NCIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRENOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPARTEMENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cb_id_evenement = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_nom_evenement = New System.Windows.Forms.TextBox()
        Me.tb__Nombres_inscrits = New System.Windows.Forms.TextBox()
        Me.lb_Nombres_inscrits = New System.Windows.Forms.Label()
        Me.Annuler = New System.Windows.Forms.Button()
        Me.tb_date_evenement = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_tache = New System.Windows.Forms.TextBox()
        Me.tb_nom_membre = New System.Windows.Forms.TextBox()
        Me.TB_NCIN_MEMBRE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nom_membre = New System.Windows.Forms.Label()
        Me.ncin_membre = New System.Windows.Forms.Label()
        Me.bt_enregistrer = New System.Windows.Forms.Button()
        Me.bt_chercher = New System.Windows.Forms.Button()
        Me.bt_modifier = New System.Windows.Forms.Button()
        Me.bt_supprimer = New System.Windows.Forms.Button()
        Me.bt_ajouter = New System.Windows.Forms.Button()
        Me.RE = New System.Windows.Forms.Button()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        CType(Me.data_membre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data_membre
        '
        Me.data_membre.BackgroundColor = System.Drawing.Color.White
        Me.data_membre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_membre.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NCIN, Me.NOM, Me.PRENOM, Me.DEPARTEMENT})
        Me.data_membre.Location = New System.Drawing.Point(536, 60)
        Me.data_membre.Name = "data_membre"
        Me.data_membre.Size = New System.Drawing.Size(443, 226)
        Me.data_membre.TabIndex = 119
        '
        'NCIN
        '
        Me.NCIN.HeaderText = "NCIN"
        Me.NCIN.Name = "NCIN"
        Me.NCIN.ReadOnly = True
        '
        'NOM
        '
        Me.NOM.HeaderText = "NOM"
        Me.NOM.Name = "NOM"
        Me.NOM.ReadOnly = True
        '
        'PRENOM
        '
        Me.PRENOM.HeaderText = "PRENOM"
        Me.PRENOM.Name = "PRENOM"
        Me.PRENOM.ReadOnly = True
        '
        'DEPARTEMENT
        '
        Me.DEPARTEMENT.HeaderText = "DEPARTEMENT"
        Me.DEPARTEMENT.Name = "DEPARTEMENT"
        Me.DEPARTEMENT.ReadOnly = True
        '
        'cb_id_evenement
        '
        Me.cb_id_evenement.FormattingEnabled = True
        Me.cb_id_evenement.Items.AddRange(New Object() {"e1", "e2", "e3"})
        Me.cb_id_evenement.Location = New System.Drawing.Point(151, 103)
        Me.cb_id_evenement.Name = "cb_id_evenement"
        Me.cb_id_evenement.Size = New System.Drawing.Size(229, 21)
        Me.cb_id_evenement.TabIndex = 118
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(37, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "Nom de l'évenement"
        '
        'tb_nom_evenement
        '
        Me.tb_nom_evenement.Enabled = False
        Me.tb_nom_evenement.Location = New System.Drawing.Point(149, 224)
        Me.tb_nom_evenement.Name = "tb_nom_evenement"
        Me.tb_nom_evenement.Size = New System.Drawing.Size(229, 20)
        Me.tb_nom_evenement.TabIndex = 116
        '
        'tb__Nombres_inscrits
        '
        Me.tb__Nombres_inscrits.Enabled = False
        Me.tb__Nombres_inscrits.Location = New System.Drawing.Point(536, 364)
        Me.tb__Nombres_inscrits.Name = "tb__Nombres_inscrits"
        Me.tb__Nombres_inscrits.Size = New System.Drawing.Size(231, 20)
        Me.tb__Nombres_inscrits.TabIndex = 115
        '
        'lb_Nombres_inscrits
        '
        Me.lb_Nombres_inscrits.AutoSize = True
        Me.lb_Nombres_inscrits.BackColor = System.Drawing.Color.Yellow
        Me.lb_Nombres_inscrits.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Nombres_inscrits.Location = New System.Drawing.Point(597, 316)
        Me.lb_Nombres_inscrits.Name = "lb_Nombres_inscrits"
        Me.lb_Nombres_inscrits.Size = New System.Drawing.Size(134, 16)
        Me.lb_Nombres_inscrits.TabIndex = 114
        Me.lb_Nombres_inscrits.Text = "Nombres des Inscrits"
        '
        'Annuler
        '
        Me.Annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Annuler.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Annuler.ForeColor = System.Drawing.Color.White
        Me.Annuler.Location = New System.Drawing.Point(303, 364)
        Me.Annuler.Name = "Annuler"
        Me.Annuler.Size = New System.Drawing.Size(88, 23)
        Me.Annuler.TabIndex = 113
        Me.Annuler.Text = "Annuler"
        Me.Annuler.UseVisualStyleBackColor = False
        '
        'tb_date_evenement
        '
        Me.tb_date_evenement.Location = New System.Drawing.Point(151, 261)
        Me.tb_date_evenement.Name = "tb_date_evenement"
        Me.tb_date_evenement.Size = New System.Drawing.Size(231, 20)
        Me.tb_date_evenement.TabIndex = 112
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(18, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "Date  de l'évenement"
        '
        'tb_tache
        '
        Me.tb_tache.Location = New System.Drawing.Point(151, 312)
        Me.tb_tache.Name = "tb_tache"
        Me.tb_tache.Size = New System.Drawing.Size(229, 20)
        Me.tb_tache.TabIndex = 110
        '
        'tb_nom_membre
        '
        Me.tb_nom_membre.Location = New System.Drawing.Point(151, 198)
        Me.tb_nom_membre.Name = "tb_nom_membre"
        Me.tb_nom_membre.Size = New System.Drawing.Size(229, 20)
        Me.tb_nom_membre.TabIndex = 109
        '
        'TB_NCIN_MEMBRE
        '
        Me.TB_NCIN_MEMBRE.Location = New System.Drawing.Point(149, 60)
        Me.TB_NCIN_MEMBRE.Name = "TB_NCIN_MEMBRE"
        Me.TB_NCIN_MEMBRE.Size = New System.Drawing.Size(229, 20)
        Me.TB_NCIN_MEMBRE.TabIndex = 108
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(30, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "ID  de l'évenement"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(30, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Tache accordeé"
        '
        'nom_membre
        '
        Me.nom_membre.AutoSize = True
        Me.nom_membre.BackColor = System.Drawing.Color.Yellow
        Me.nom_membre.Location = New System.Drawing.Point(37, 201)
        Me.nom_membre.Name = "nom_membre"
        Me.nom_membre.Size = New System.Drawing.Size(70, 13)
        Me.nom_membre.TabIndex = 105
        Me.nom_membre.Text = "nom_membre"
        '
        'ncin_membre
        '
        Me.ncin_membre.AutoSize = True
        Me.ncin_membre.BackColor = System.Drawing.Color.Yellow
        Me.ncin_membre.Location = New System.Drawing.Point(37, 63)
        Me.ncin_membre.Name = "ncin_membre"
        Me.ncin_membre.Size = New System.Drawing.Size(70, 13)
        Me.ncin_membre.TabIndex = 104
        Me.ncin_membre.Text = "ncin_membre"
        '
        'bt_enregistrer
        '
        Me.bt_enregistrer.BackColor = System.Drawing.Color.Green
        Me.bt_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_enregistrer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_enregistrer.ForeColor = System.Drawing.Color.White
        Me.bt_enregistrer.Location = New System.Drawing.Point(409, 198)
        Me.bt_enregistrer.Name = "bt_enregistrer"
        Me.bt_enregistrer.Size = New System.Drawing.Size(101, 27)
        Me.bt_enregistrer.TabIndex = 103
        Me.bt_enregistrer.Text = "Enregistrer"
        Me.bt_enregistrer.UseVisualStyleBackColor = False
        '
        'bt_chercher
        '
        Me.bt_chercher.BackColor = System.Drawing.Color.Green
        Me.bt_chercher.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_chercher.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_chercher.ForeColor = System.Drawing.Color.White
        Me.bt_chercher.Location = New System.Drawing.Point(409, 242)
        Me.bt_chercher.Name = "bt_chercher"
        Me.bt_chercher.Size = New System.Drawing.Size(101, 27)
        Me.bt_chercher.TabIndex = 102
        Me.bt_chercher.Text = "Chercher"
        Me.bt_chercher.UseVisualStyleBackColor = False
        '
        'bt_modifier
        '
        Me.bt_modifier.BackColor = System.Drawing.Color.Green
        Me.bt_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_modifier.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_modifier.ForeColor = System.Drawing.Color.White
        Me.bt_modifier.Location = New System.Drawing.Point(409, 108)
        Me.bt_modifier.Name = "bt_modifier"
        Me.bt_modifier.Size = New System.Drawing.Size(101, 27)
        Me.bt_modifier.TabIndex = 101
        Me.bt_modifier.Text = "Modifier"
        Me.bt_modifier.UseVisualStyleBackColor = False
        '
        'bt_supprimer
        '
        Me.bt_supprimer.BackColor = System.Drawing.Color.Green
        Me.bt_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_supprimer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_supprimer.ForeColor = System.Drawing.Color.White
        Me.bt_supprimer.Location = New System.Drawing.Point(409, 157)
        Me.bt_supprimer.Name = "bt_supprimer"
        Me.bt_supprimer.Size = New System.Drawing.Size(101, 27)
        Me.bt_supprimer.TabIndex = 100
        Me.bt_supprimer.Text = "Supprimer"
        Me.bt_supprimer.UseVisualStyleBackColor = False
        '
        'bt_ajouter
        '
        Me.bt_ajouter.BackColor = System.Drawing.Color.Green
        Me.bt_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_ajouter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_ajouter.ForeColor = System.Drawing.Color.White
        Me.bt_ajouter.Location = New System.Drawing.Point(409, 66)
        Me.bt_ajouter.Name = "bt_ajouter"
        Me.bt_ajouter.Size = New System.Drawing.Size(101, 27)
        Me.bt_ajouter.TabIndex = 99
        Me.bt_ajouter.Text = "Ajouter"
        Me.bt_ajouter.UseVisualStyleBackColor = False
        '
        'RE
        '
        Me.RE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RE.ForeColor = System.Drawing.Color.White
        Me.RE.Location = New System.Drawing.Point(151, 364)
        Me.RE.Name = "RE"
        Me.RE.Size = New System.Drawing.Size(88, 23)
        Me.RE.TabIndex = 98
        Me.RE.Text = "Retour"
        Me.RE.UseVisualStyleBackColor = False
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(877, 361)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 120
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'Responsable_Evenementiel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(997, 449)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.data_membre)
        Me.Controls.Add(Me.cb_id_evenement)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tb_nom_evenement)
        Me.Controls.Add(Me.tb__Nombres_inscrits)
        Me.Controls.Add(Me.lb_Nombres_inscrits)
        Me.Controls.Add(Me.Annuler)
        Me.Controls.Add(Me.tb_date_evenement)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_tache)
        Me.Controls.Add(Me.tb_nom_membre)
        Me.Controls.Add(Me.TB_NCIN_MEMBRE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nom_membre)
        Me.Controls.Add(Me.ncin_membre)
        Me.Controls.Add(Me.bt_enregistrer)
        Me.Controls.Add(Me.bt_chercher)
        Me.Controls.Add(Me.bt_modifier)
        Me.Controls.Add(Me.bt_supprimer)
        Me.Controls.Add(Me.bt_ajouter)
        Me.Controls.Add(Me.RE)
        Me.Name = "Responsable_Evenementiel"
        Me.Text = "Responsable_Evenementiel"
        CType(Me.data_membre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents data_membre As System.Windows.Forms.DataGridView
    Friend WithEvents NCIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRENOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEPARTEMENT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cb_id_evenement As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tb_nom_evenement As System.Windows.Forms.TextBox
    Friend WithEvents tb__Nombres_inscrits As System.Windows.Forms.TextBox
    Friend WithEvents lb_Nombres_inscrits As System.Windows.Forms.Label
    Friend WithEvents Annuler As System.Windows.Forms.Button
    Friend WithEvents tb_date_evenement As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_tache As System.Windows.Forms.TextBox
    Friend WithEvents tb_nom_membre As System.Windows.Forms.TextBox
    Friend WithEvents TB_NCIN_MEMBRE As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nom_membre As System.Windows.Forms.Label
    Friend WithEvents ncin_membre As System.Windows.Forms.Label
    Friend WithEvents bt_enregistrer As System.Windows.Forms.Button
    Friend WithEvents bt_chercher As System.Windows.Forms.Button
    Friend WithEvents bt_modifier As System.Windows.Forms.Button
    Friend WithEvents bt_supprimer As System.Windows.Forms.Button
    Friend WithEvents bt_ajouter As System.Windows.Forms.Button
    Friend WithEvents RE As System.Windows.Forms.Button
    Friend WithEvents bt_Quitter As Button
End Class
