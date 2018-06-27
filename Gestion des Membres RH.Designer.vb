<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion_des_Membres_RH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gestion_des_Membres_RH))
        Me.data_membre = New System.Windows.Forms.DataGridView()
        Me.NCIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRENOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPARTEMENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_Annuler = New System.Windows.Forms.Button()
        Me.RE = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.prenom_membre = New System.Windows.Forms.Label()
        Me.nom_membre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ncin_membre = New System.Windows.Forms.Label()
        Me.Tb_id_departement = New System.Windows.Forms.TextBox()
        Me.Tb_mail_membre = New System.Windows.Forms.TextBox()
        Me.Tb_prenom_membre = New System.Windows.Forms.TextBox()
        Me.Tb_nom_membre = New System.Windows.Forms.TextBox()
        Me.Tb_fonction = New System.Windows.Forms.TextBox()
        Me.Tb_ncin_membre = New System.Windows.Forms.TextBox()
        Me.bt_enregistrer = New System.Windows.Forms.Button()
        Me.bt_chercher = New System.Windows.Forms.Button()
        Me.bt_modifier = New System.Windows.Forms.Button()
        Me.bt_supprimer = New System.Windows.Forms.Button()
        Me.bt_ajouter = New System.Windows.Forms.Button()
        Me.tb_image = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.browse = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        CType(Me.data_membre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data_membre
        '
        Me.data_membre.BackgroundColor = System.Drawing.Color.White
        Me.data_membre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_membre.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NCIN, Me.NOM, Me.PRENOM, Me.DEPARTEMENT})
        Me.data_membre.Location = New System.Drawing.Point(451, 50)
        Me.data_membre.Name = "data_membre"
        Me.data_membre.Size = New System.Drawing.Size(443, 226)
        Me.data_membre.TabIndex = 118
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
        'tb_Annuler
        '
        Me.tb_Annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tb_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tb_Annuler.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_Annuler.ForeColor = System.Drawing.Color.White
        Me.tb_Annuler.Location = New System.Drawing.Point(642, 339)
        Me.tb_Annuler.Name = "tb_Annuler"
        Me.tb_Annuler.Size = New System.Drawing.Size(88, 25)
        Me.tb_Annuler.TabIndex = 117
        Me.tb_Annuler.Text = "Annuler"
        Me.tb_Annuler.UseVisualStyleBackColor = False
        '
        'RE
        '
        Me.RE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RE.ForeColor = System.Drawing.Color.White
        Me.RE.Location = New System.Drawing.Point(451, 339)
        Me.RE.Name = "RE"
        Me.RE.Size = New System.Drawing.Size(88, 25)
        Me.RE.TabIndex = 116
        Me.RE.Text = "Retour"
        Me.RE.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(15, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "id_departement"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(15, 319)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "mail_membre"
        '
        'prenom_membre
        '
        Me.prenom_membre.AutoSize = True
        Me.prenom_membre.BackColor = System.Drawing.Color.Yellow
        Me.prenom_membre.Location = New System.Drawing.Point(15, 264)
        Me.prenom_membre.Name = "prenom_membre"
        Me.prenom_membre.Size = New System.Drawing.Size(85, 13)
        Me.prenom_membre.TabIndex = 113
        Me.prenom_membre.Text = "prenom_membre"
        '
        'nom_membre
        '
        Me.nom_membre.AutoSize = True
        Me.nom_membre.BackColor = System.Drawing.Color.Yellow
        Me.nom_membre.Location = New System.Drawing.Point(25, 218)
        Me.nom_membre.Name = "nom_membre"
        Me.nom_membre.Size = New System.Drawing.Size(70, 13)
        Me.nom_membre.TabIndex = 112
        Me.nom_membre.Text = "nom_membre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(25, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "fonction"
        '
        'ncin_membre
        '
        Me.ncin_membre.AutoSize = True
        Me.ncin_membre.BackColor = System.Drawing.Color.Yellow
        Me.ncin_membre.Location = New System.Drawing.Point(25, 129)
        Me.ncin_membre.Name = "ncin_membre"
        Me.ncin_membre.Size = New System.Drawing.Size(70, 13)
        Me.ncin_membre.TabIndex = 110
        Me.ncin_membre.Text = "ncin_membre"
        '
        'Tb_id_departement
        '
        Me.Tb_id_departement.Location = New System.Drawing.Point(101, 363)
        Me.Tb_id_departement.Name = "Tb_id_departement"
        Me.Tb_id_departement.Size = New System.Drawing.Size(139, 20)
        Me.Tb_id_departement.TabIndex = 109
        '
        'Tb_mail_membre
        '
        Me.Tb_mail_membre.Location = New System.Drawing.Point(101, 316)
        Me.Tb_mail_membre.Name = "Tb_mail_membre"
        Me.Tb_mail_membre.Size = New System.Drawing.Size(139, 20)
        Me.Tb_mail_membre.TabIndex = 108
        '
        'Tb_prenom_membre
        '
        Me.Tb_prenom_membre.Location = New System.Drawing.Point(101, 264)
        Me.Tb_prenom_membre.Name = "Tb_prenom_membre"
        Me.Tb_prenom_membre.Size = New System.Drawing.Size(139, 20)
        Me.Tb_prenom_membre.TabIndex = 107
        '
        'Tb_nom_membre
        '
        Me.Tb_nom_membre.Location = New System.Drawing.Point(101, 215)
        Me.Tb_nom_membre.Name = "Tb_nom_membre"
        Me.Tb_nom_membre.Size = New System.Drawing.Size(139, 20)
        Me.Tb_nom_membre.TabIndex = 106
        '
        'Tb_fonction
        '
        Me.Tb_fonction.Location = New System.Drawing.Point(101, 172)
        Me.Tb_fonction.Name = "Tb_fonction"
        Me.Tb_fonction.Size = New System.Drawing.Size(139, 20)
        Me.Tb_fonction.TabIndex = 105
        '
        'Tb_ncin_membre
        '
        Me.Tb_ncin_membre.Location = New System.Drawing.Point(101, 129)
        Me.Tb_ncin_membre.Name = "Tb_ncin_membre"
        Me.Tb_ncin_membre.Size = New System.Drawing.Size(139, 20)
        Me.Tb_ncin_membre.TabIndex = 104
        '
        'bt_enregistrer
        '
        Me.bt_enregistrer.BackColor = System.Drawing.Color.Green
        Me.bt_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_enregistrer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_enregistrer.ForeColor = System.Drawing.Color.White
        Me.bt_enregistrer.Location = New System.Drawing.Point(273, 219)
        Me.bt_enregistrer.Name = "bt_enregistrer"
        Me.bt_enregistrer.Size = New System.Drawing.Size(160, 27)
        Me.bt_enregistrer.TabIndex = 103
        Me.bt_enregistrer.Text = "Enregistrer"
        Me.bt_enregistrer.UseVisualStyleBackColor = False
        '
        'bt_chercher
        '
        Me.bt_chercher.BackColor = System.Drawing.Color.Green
        Me.bt_chercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_chercher.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_chercher.ForeColor = System.Drawing.Color.White
        Me.bt_chercher.Location = New System.Drawing.Point(273, 263)
        Me.bt_chercher.Name = "bt_chercher"
        Me.bt_chercher.Size = New System.Drawing.Size(160, 27)
        Me.bt_chercher.TabIndex = 102
        Me.bt_chercher.Text = "Chercher"
        Me.bt_chercher.UseVisualStyleBackColor = False
        '
        'bt_modifier
        '
        Me.bt_modifier.BackColor = System.Drawing.Color.Green
        Me.bt_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_modifier.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_modifier.ForeColor = System.Drawing.Color.White
        Me.bt_modifier.Location = New System.Drawing.Point(273, 129)
        Me.bt_modifier.Name = "bt_modifier"
        Me.bt_modifier.Size = New System.Drawing.Size(160, 27)
        Me.bt_modifier.TabIndex = 101
        Me.bt_modifier.Text = "Modifier"
        Me.bt_modifier.UseVisualStyleBackColor = False
        '
        'bt_supprimer
        '
        Me.bt_supprimer.BackColor = System.Drawing.Color.Green
        Me.bt_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_supprimer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_supprimer.ForeColor = System.Drawing.Color.White
        Me.bt_supprimer.Location = New System.Drawing.Point(273, 178)
        Me.bt_supprimer.Name = "bt_supprimer"
        Me.bt_supprimer.Size = New System.Drawing.Size(160, 27)
        Me.bt_supprimer.TabIndex = 100
        Me.bt_supprimer.Text = "Supprimer"
        Me.bt_supprimer.UseVisualStyleBackColor = False
        '
        'bt_ajouter
        '
        Me.bt_ajouter.BackColor = System.Drawing.Color.Green
        Me.bt_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_ajouter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_ajouter.ForeColor = System.Drawing.Color.White
        Me.bt_ajouter.Location = New System.Drawing.Point(273, 87)
        Me.bt_ajouter.Name = "bt_ajouter"
        Me.bt_ajouter.Size = New System.Drawing.Size(160, 27)
        Me.bt_ajouter.TabIndex = 99
        Me.bt_ajouter.Text = "Ajouter"
        Me.bt_ajouter.UseVisualStyleBackColor = False
        '
        'tb_image
        '
        Me.tb_image.Location = New System.Drawing.Point(630, 295)
        Me.tb_image.Name = "tb_image"
        Me.tb_image.Size = New System.Drawing.Size(100, 20)
        Me.tb_image.TabIndex = 119
        Me.tb_image.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(228, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 120
        Me.PictureBox1.TabStop = False
        '
        'browse
        '
        Me.browse.BackColor = System.Drawing.Color.Green
        Me.browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.browse.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.browse.ForeColor = System.Drawing.Color.White
        Me.browse.Location = New System.Drawing.Point(312, 12)
        Me.browse.Name = "browse"
        Me.browse.Size = New System.Drawing.Size(90, 27)
        Me.browse.TabIndex = 121
        Me.browse.Text = "browse.."
        Me.browse.UseVisualStyleBackColor = False
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(819, 341)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 122
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'Gestion_des_Membres_RH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(938, 453)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.browse)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tb_image)
        Me.Controls.Add(Me.data_membre)
        Me.Controls.Add(Me.tb_Annuler)
        Me.Controls.Add(Me.RE)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.prenom_membre)
        Me.Controls.Add(Me.nom_membre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ncin_membre)
        Me.Controls.Add(Me.Tb_id_departement)
        Me.Controls.Add(Me.Tb_mail_membre)
        Me.Controls.Add(Me.Tb_prenom_membre)
        Me.Controls.Add(Me.Tb_nom_membre)
        Me.Controls.Add(Me.Tb_fonction)
        Me.Controls.Add(Me.Tb_ncin_membre)
        Me.Controls.Add(Me.bt_enregistrer)
        Me.Controls.Add(Me.bt_chercher)
        Me.Controls.Add(Me.bt_modifier)
        Me.Controls.Add(Me.bt_supprimer)
        Me.Controls.Add(Me.bt_ajouter)
        Me.Name = "Gestion_des_Membres_RH"
        Me.Text = "Gestion des Membres RH"
        CType(Me.data_membre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents data_membre As System.Windows.Forms.DataGridView
    Friend WithEvents NCIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRENOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEPARTEMENT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tb_Annuler As System.Windows.Forms.Button
    Friend WithEvents RE As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents prenom_membre As System.Windows.Forms.Label
    Friend WithEvents nom_membre As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ncin_membre As System.Windows.Forms.Label
    Friend WithEvents Tb_id_departement As System.Windows.Forms.TextBox
    Friend WithEvents Tb_mail_membre As System.Windows.Forms.TextBox
    Friend WithEvents Tb_prenom_membre As System.Windows.Forms.TextBox
    Friend WithEvents Tb_nom_membre As System.Windows.Forms.TextBox
    Friend WithEvents Tb_fonction As System.Windows.Forms.TextBox
    Friend WithEvents Tb_ncin_membre As System.Windows.Forms.TextBox
    Friend WithEvents bt_enregistrer As System.Windows.Forms.Button
    Friend WithEvents bt_chercher As System.Windows.Forms.Button
    Friend WithEvents bt_modifier As System.Windows.Forms.Button
    Friend WithEvents bt_supprimer As System.Windows.Forms.Button
    Friend WithEvents bt_ajouter As System.Windows.Forms.Button
    Friend WithEvents tb_image As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents browse As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents bt_Quitter As Button
End Class
