<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gestion_des_Notes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gestion_des_Notes))
        Me.data_membre = New System.Windows.Forms.DataGridView()
        Me.NCIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRENOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPARTEMENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cb_id_évenement = New System.Windows.Forms.ComboBox()
        Me.cb_note = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_nom_membre = New System.Windows.Forms.TextBox()
        Me.TB_NCIN_MEMBRE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nom_membre = New System.Windows.Forms.Label()
        Me.ncin_membre = New System.Windows.Forms.Label()
        Me.bt_annuler = New System.Windows.Forms.Button()
        Me.bt_retour = New System.Windows.Forms.Button()
        Me.bt_enregistrer = New System.Windows.Forms.Button()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        Me.bt_Affiche = New System.Windows.Forms.Button()
        Me.tb_Afficher = New System.Windows.Forms.TextBox()
        CType(Me.data_membre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data_membre
        '
        Me.data_membre.BackgroundColor = System.Drawing.Color.White
        Me.data_membre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_membre.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NCIN, Me.NOM, Me.PRENOM, Me.DEPARTEMENT})
        Me.data_membre.Location = New System.Drawing.Point(566, 12)
        Me.data_membre.Name = "data_membre"
        Me.data_membre.Size = New System.Drawing.Size(443, 226)
        Me.data_membre.TabIndex = 122
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
        'cb_id_évenement
        '
        Me.cb_id_évenement.FormattingEnabled = True
        Me.cb_id_évenement.Location = New System.Drawing.Point(204, 76)
        Me.cb_id_évenement.Name = "cb_id_évenement"
        Me.cb_id_évenement.Size = New System.Drawing.Size(229, 21)
        Me.cb_id_évenement.TabIndex = 120
        '
        'cb_note
        '
        Me.cb_note.BackColor = System.Drawing.SystemColors.Menu
        Me.cb_note.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_note.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_note.FormattingEnabled = True
        Me.cb_note.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cb_note.Location = New System.Drawing.Point(204, 197)
        Me.cb_note.Name = "cb_note"
        Me.cb_note.Size = New System.Drawing.Size(217, 21)
        Me.cb_note.TabIndex = 118
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(60, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Note "
        '
        'tb_nom_membre
        '
        Me.tb_nom_membre.Location = New System.Drawing.Point(204, 123)
        Me.tb_nom_membre.Name = "tb_nom_membre"
        Me.tb_nom_membre.Size = New System.Drawing.Size(229, 20)
        Me.tb_nom_membre.TabIndex = 116
        '
        'TB_NCIN_MEMBRE
        '
        Me.TB_NCIN_MEMBRE.Location = New System.Drawing.Point(204, 30)
        Me.TB_NCIN_MEMBRE.Name = "TB_NCIN_MEMBRE"
        Me.TB_NCIN_MEMBRE.Size = New System.Drawing.Size(229, 20)
        Me.TB_NCIN_MEMBRE.TabIndex = 115
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(60, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Id  de l'évenement"
        '
        'nom_membre
        '
        Me.nom_membre.AutoSize = True
        Me.nom_membre.BackColor = System.Drawing.Color.Yellow
        Me.nom_membre.Location = New System.Drawing.Point(60, 126)
        Me.nom_membre.Name = "nom_membre"
        Me.nom_membre.Size = New System.Drawing.Size(70, 13)
        Me.nom_membre.TabIndex = 113
        Me.nom_membre.Text = "nom_membre"
        '
        'ncin_membre
        '
        Me.ncin_membre.AutoSize = True
        Me.ncin_membre.BackColor = System.Drawing.Color.Yellow
        Me.ncin_membre.Location = New System.Drawing.Point(60, 30)
        Me.ncin_membre.Name = "ncin_membre"
        Me.ncin_membre.Size = New System.Drawing.Size(70, 13)
        Me.ncin_membre.TabIndex = 112
        Me.ncin_membre.Text = "ncin_membre"
        '
        'bt_annuler
        '
        Me.bt_annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_annuler.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_annuler.ForeColor = System.Drawing.Color.White
        Me.bt_annuler.Location = New System.Drawing.Point(345, 297)
        Me.bt_annuler.Name = "bt_annuler"
        Me.bt_annuler.Size = New System.Drawing.Size(88, 29)
        Me.bt_annuler.TabIndex = 124
        Me.bt_annuler.Text = "Annuler"
        Me.bt_annuler.UseVisualStyleBackColor = False
        '
        'bt_retour
        '
        Me.bt_retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_retour.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_retour.ForeColor = System.Drawing.Color.White
        Me.bt_retour.Location = New System.Drawing.Point(66, 297)
        Me.bt_retour.Name = "bt_retour"
        Me.bt_retour.Size = New System.Drawing.Size(88, 29)
        Me.bt_retour.TabIndex = 123
        Me.bt_retour.Text = "Retour"
        Me.bt_retour.UseVisualStyleBackColor = False
        '
        'bt_enregistrer
        '
        Me.bt_enregistrer.BackColor = System.Drawing.Color.Green
        Me.bt_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_enregistrer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_enregistrer.ForeColor = System.Drawing.Color.White
        Me.bt_enregistrer.Location = New System.Drawing.Point(175, 297)
        Me.bt_enregistrer.Name = "bt_enregistrer"
        Me.bt_enregistrer.Size = New System.Drawing.Size(160, 27)
        Me.bt_enregistrer.TabIndex = 125
        Me.bt_enregistrer.Text = "Enregistrer"
        Me.bt_enregistrer.UseVisualStyleBackColor = False
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(882, 350)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 126
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'bt_Affiche
        '
        Me.bt_Affiche.BackColor = System.Drawing.Color.Green
        Me.bt_Affiche.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Affiche.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Affiche.ForeColor = System.Drawing.Color.White
        Me.bt_Affiche.Location = New System.Drawing.Point(624, 244)
        Me.bt_Affiche.Name = "bt_Affiche"
        Me.bt_Affiche.Size = New System.Drawing.Size(293, 34)
        Me.bt_Affiche.TabIndex = 127
        Me.bt_Affiche.Text = "Afficher son note dans l'évenement"
        Me.bt_Affiche.UseVisualStyleBackColor = False
        '
        'tb_Afficher
        '
        Me.tb_Afficher.Enabled = False
        Me.tb_Afficher.Location = New System.Drawing.Point(664, 297)
        Me.tb_Afficher.Name = "tb_Afficher"
        Me.tb_Afficher.Size = New System.Drawing.Size(229, 20)
        Me.tb_Afficher.TabIndex = 128
        '
        'Gestion_des_Notes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1021, 400)
        Me.Controls.Add(Me.tb_Afficher)
        Me.Controls.Add(Me.bt_Affiche)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.bt_enregistrer)
        Me.Controls.Add(Me.bt_annuler)
        Me.Controls.Add(Me.bt_retour)
        Me.Controls.Add(Me.data_membre)
        Me.Controls.Add(Me.cb_id_évenement)
        Me.Controls.Add(Me.cb_note)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_nom_membre)
        Me.Controls.Add(Me.TB_NCIN_MEMBRE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nom_membre)
        Me.Controls.Add(Me.ncin_membre)
        Me.Name = "Gestion_des_Notes"
        Me.Text = "Gestion des Notes RH"
        CType(Me.data_membre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents data_membre As System.Windows.Forms.DataGridView
    Friend WithEvents NCIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRENOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEPARTEMENT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cb_id_évenement As System.Windows.Forms.ComboBox
    Friend WithEvents cb_note As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_nom_membre As System.Windows.Forms.TextBox
    Friend WithEvents TB_NCIN_MEMBRE As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nom_membre As System.Windows.Forms.Label
    Friend WithEvents ncin_membre As System.Windows.Forms.Label
    Friend WithEvents bt_annuler As System.Windows.Forms.Button
    Friend WithEvents bt_retour As System.Windows.Forms.Button
    Friend WithEvents bt_enregistrer As System.Windows.Forms.Button
    Friend WithEvents bt_Quitter As Button
    Friend WithEvents bt_Affiche As Button
    Friend WithEvents tb_Afficher As TextBox
End Class
