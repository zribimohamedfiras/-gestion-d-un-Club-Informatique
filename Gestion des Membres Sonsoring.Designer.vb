<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion_des_Membres_Sonsoring
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gestion_des_Membres_Sonsoring))
        Me.data_membre = New System.Windows.Forms.DataGridView()
        Me.NCIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRENOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPARTEMENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_tache = New System.Windows.Forms.TextBox()
        Me.tb_nom_evenement = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_date_evenement = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_id_evenement = New System.Windows.Forms.ComboBox()
        Me.tb_nom_membre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_NCIN_MEMBRE = New System.Windows.Forms.TextBox()
        Me.bt_Annuler = New System.Windows.Forms.Button()
        Me.RE = New System.Windows.Forms.Button()
        Me.bt_Ajouter = New System.Windows.Forms.Button()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        CType(Me.data_membre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data_membre
        '
        Me.data_membre.BackgroundColor = System.Drawing.Color.White
        Me.data_membre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_membre.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NCIN, Me.NOM, Me.PRENOM, Me.DEPARTEMENT})
        Me.data_membre.Location = New System.Drawing.Point(542, 23)
        Me.data_membre.Name = "data_membre"
        Me.data_membre.Size = New System.Drawing.Size(443, 226)
        Me.data_membre.TabIndex = 112
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
        'tb_tache
        '
        Me.tb_tache.Location = New System.Drawing.Point(150, 261)
        Me.tb_tache.Name = "tb_tache"
        Me.tb_tache.Size = New System.Drawing.Size(231, 20)
        Me.tb_tache.TabIndex = 111
        '
        'tb_nom_evenement
        '
        Me.tb_nom_evenement.Enabled = False
        Me.tb_nom_evenement.Location = New System.Drawing.Point(150, 180)
        Me.tb_nom_evenement.Name = "tb_nom_evenement"
        Me.tb_nom_evenement.Size = New System.Drawing.Size(229, 20)
        Me.tb_nom_evenement.TabIndex = 110
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(32, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Nom de l'évenement"
        '
        'tb_date_evenement
        '
        Me.tb_date_evenement.Location = New System.Drawing.Point(150, 211)
        Me.tb_date_evenement.Name = "tb_date_evenement"
        Me.tb_date_evenement.Size = New System.Drawing.Size(231, 20)
        Me.tb_date_evenement.TabIndex = 108
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(31, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Date  de l'évenement"
        '
        'cb_id_evenement
        '
        Me.cb_id_evenement.FormattingEnabled = True
        Me.cb_id_evenement.Items.AddRange(New Object() {"e1", "e2", "e3"})
        Me.cb_id_evenement.Location = New System.Drawing.Point(148, 75)
        Me.cb_id_evenement.Name = "cb_id_evenement"
        Me.cb_id_evenement.Size = New System.Drawing.Size(229, 21)
        Me.cb_id_evenement.TabIndex = 106
        '
        'tb_nom_membre
        '
        Me.tb_nom_membre.Location = New System.Drawing.Point(148, 149)
        Me.tb_nom_membre.Name = "tb_nom_membre"
        Me.tb_nom_membre.Size = New System.Drawing.Size(229, 20)
        Me.tb_nom_membre.TabIndex = 103
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(31, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = " Nom de membre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(31, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Tache accordeé"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(31, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "ID  de l'évenement"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(32, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Ncin de la membre"
        '
        'TB_NCIN_MEMBRE
        '
        Me.TB_NCIN_MEMBRE.Location = New System.Drawing.Point(148, 33)
        Me.TB_NCIN_MEMBRE.Name = "TB_NCIN_MEMBRE"
        Me.TB_NCIN_MEMBRE.Size = New System.Drawing.Size(229, 20)
        Me.TB_NCIN_MEMBRE.TabIndex = 97
        '
        'bt_Annuler
        '
        Me.bt_Annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Annuler.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Annuler.ForeColor = System.Drawing.Color.White
        Me.bt_Annuler.Location = New System.Drawing.Point(240, 311)
        Me.bt_Annuler.Name = "bt_Annuler"
        Me.bt_Annuler.Size = New System.Drawing.Size(88, 30)
        Me.bt_Annuler.TabIndex = 114
        Me.bt_Annuler.Text = "Annuler"
        Me.bt_Annuler.UseVisualStyleBackColor = False
        '
        'RE
        '
        Me.RE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RE.ForeColor = System.Drawing.Color.White
        Me.RE.Location = New System.Drawing.Point(51, 311)
        Me.RE.Name = "RE"
        Me.RE.Size = New System.Drawing.Size(88, 30)
        Me.RE.TabIndex = 113
        Me.RE.Text = "Retour"
        Me.RE.UseVisualStyleBackColor = False
        '
        'bt_Ajouter
        '
        Me.bt_Ajouter.BackColor = System.Drawing.Color.Green
        Me.bt_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Ajouter.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Ajouter.ForeColor = System.Drawing.Color.White
        Me.bt_Ajouter.Location = New System.Drawing.Point(403, 103)
        Me.bt_Ajouter.Name = "bt_Ajouter"
        Me.bt_Ajouter.Size = New System.Drawing.Size(133, 36)
        Me.bt_Ajouter.TabIndex = 115
        Me.bt_Ajouter.Text = "Ajouter"
        Me.bt_Ajouter.UseVisualStyleBackColor = False
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(910, 302)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 116
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'Gestion_des_Membres_Sonsoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1022, 407)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.bt_Ajouter)
        Me.Controls.Add(Me.bt_Annuler)
        Me.Controls.Add(Me.RE)
        Me.Controls.Add(Me.data_membre)
        Me.Controls.Add(Me.tb_tache)
        Me.Controls.Add(Me.tb_nom_evenement)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tb_date_evenement)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cb_id_evenement)
        Me.Controls.Add(Me.tb_nom_membre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TB_NCIN_MEMBRE)
        Me.Name = "Gestion_des_Membres_Sonsoring"
        Me.Text = "Gestion_des_Membres_Sonsoring"
        CType(Me.data_membre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents data_membre As System.Windows.Forms.DataGridView
    Friend WithEvents NCIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRENOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEPARTEMENT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tb_tache As System.Windows.Forms.TextBox
    Friend WithEvents tb_nom_evenement As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tb_date_evenement As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cb_id_evenement As System.Windows.Forms.ComboBox
    Friend WithEvents tb_nom_membre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TB_NCIN_MEMBRE As System.Windows.Forms.TextBox
    Friend WithEvents bt_Annuler As System.Windows.Forms.Button
    Friend WithEvents RE As System.Windows.Forms.Button
    Friend WithEvents bt_Ajouter As System.Windows.Forms.Button
    Friend WithEvents bt_Quitter As Button
End Class
