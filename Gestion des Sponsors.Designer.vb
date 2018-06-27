<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion_des_Sponsors
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gestion_des_Sponsors))
        Me.Data_sponsor = New System.Windows.Forms.DataGridView()
        Me.ID_sponsor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom_Sponsor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_adresse_sponsor = New System.Windows.Forms.TextBox()
        Me.lb_Adresse_Sponsor = New System.Windows.Forms.Label()
        Me.tb_mail_sponsor = New System.Windows.Forms.TextBox()
        Me.tb_tel_sponsor = New System.Windows.Forms.TextBox()
        Me.tb_nom_sponsor = New System.Windows.Forms.TextBox()
        Me.tb_id_sponsor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bt_enregistrer = New System.Windows.Forms.Button()
        Me.bt_chercher = New System.Windows.Forms.Button()
        Me.bt_modifier = New System.Windows.Forms.Button()
        Me.bt_supprimer = New System.Windows.Forms.Button()
        Me.bt_ajouter = New System.Windows.Forms.Button()
        Me.bt_annuler = New System.Windows.Forms.Button()
        Me.bt_retour = New System.Windows.Forms.Button()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        CType(Me.Data_sponsor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Data_sponsor
        '
        Me.Data_sponsor.BackgroundColor = System.Drawing.Color.White
        Me.Data_sponsor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data_sponsor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_sponsor, Me.Nom_Sponsor})
        Me.Data_sponsor.Location = New System.Drawing.Point(642, 25)
        Me.Data_sponsor.Name = "Data_sponsor"
        Me.Data_sponsor.Size = New System.Drawing.Size(244, 342)
        Me.Data_sponsor.TabIndex = 77
        '
        'ID_sponsor
        '
        Me.ID_sponsor.HeaderText = "ID Sponsor"
        Me.ID_sponsor.Name = "ID_sponsor"
        Me.ID_sponsor.ReadOnly = True
        '
        'Nom_Sponsor
        '
        Me.Nom_Sponsor.HeaderText = "Nom Sponsor"
        Me.Nom_Sponsor.Name = "Nom_Sponsor"
        Me.Nom_Sponsor.ReadOnly = True
        '
        'tb_adresse_sponsor
        '
        Me.tb_adresse_sponsor.Location = New System.Drawing.Point(163, 248)
        Me.tb_adresse_sponsor.Name = "tb_adresse_sponsor"
        Me.tb_adresse_sponsor.Size = New System.Drawing.Size(147, 20)
        Me.tb_adresse_sponsor.TabIndex = 76
        '
        'lb_Adresse_Sponsor
        '
        Me.lb_Adresse_Sponsor.AutoSize = True
        Me.lb_Adresse_Sponsor.BackColor = System.Drawing.Color.Yellow
        Me.lb_Adresse_Sponsor.Location = New System.Drawing.Point(36, 251)
        Me.lb_Adresse_Sponsor.Name = "lb_Adresse_Sponsor"
        Me.lb_Adresse_Sponsor.Size = New System.Drawing.Size(87, 13)
        Me.lb_Adresse_Sponsor.TabIndex = 75
        Me.lb_Adresse_Sponsor.Text = "Adresse Sponsor"
        '
        'tb_mail_sponsor
        '
        Me.tb_mail_sponsor.Location = New System.Drawing.Point(163, 296)
        Me.tb_mail_sponsor.Name = "tb_mail_sponsor"
        Me.tb_mail_sponsor.Size = New System.Drawing.Size(147, 20)
        Me.tb_mail_sponsor.TabIndex = 67
        '
        'tb_tel_sponsor
        '
        Me.tb_tel_sponsor.Location = New System.Drawing.Point(163, 200)
        Me.tb_tel_sponsor.Name = "tb_tel_sponsor"
        Me.tb_tel_sponsor.Size = New System.Drawing.Size(147, 20)
        Me.tb_tel_sponsor.TabIndex = 66
        '
        'tb_nom_sponsor
        '
        Me.tb_nom_sponsor.Location = New System.Drawing.Point(163, 142)
        Me.tb_nom_sponsor.Name = "tb_nom_sponsor"
        Me.tb_nom_sponsor.Size = New System.Drawing.Size(147, 20)
        Me.tb_nom_sponsor.TabIndex = 65
        '
        'tb_id_sponsor
        '
        Me.tb_id_sponsor.Location = New System.Drawing.Point(163, 81)
        Me.tb_id_sponsor.Name = "tb_id_sponsor"
        Me.tb_id_sponsor.Size = New System.Drawing.Size(147, 20)
        Me.tb_id_sponsor.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(33, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Nom Sponsor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(36, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Mail Sponsor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(33, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Téléphone Sponsor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(33, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "ID Sponsor"
        '
        'bt_enregistrer
        '
        Me.bt_enregistrer.BackColor = System.Drawing.Color.Green
        Me.bt_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_enregistrer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_enregistrer.ForeColor = System.Drawing.Color.White
        Me.bt_enregistrer.Location = New System.Drawing.Point(370, 217)
        Me.bt_enregistrer.Name = "bt_enregistrer"
        Me.bt_enregistrer.Size = New System.Drawing.Size(160, 27)
        Me.bt_enregistrer.TabIndex = 95
        Me.bt_enregistrer.Text = "Enregistrer"
        Me.bt_enregistrer.UseVisualStyleBackColor = False
        '
        'bt_chercher
        '
        Me.bt_chercher.BackColor = System.Drawing.Color.Green
        Me.bt_chercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_chercher.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_chercher.ForeColor = System.Drawing.Color.White
        Me.bt_chercher.Location = New System.Drawing.Point(370, 261)
        Me.bt_chercher.Name = "bt_chercher"
        Me.bt_chercher.Size = New System.Drawing.Size(160, 27)
        Me.bt_chercher.TabIndex = 94
        Me.bt_chercher.Text = "Chercher"
        Me.bt_chercher.UseVisualStyleBackColor = False
        '
        'bt_modifier
        '
        Me.bt_modifier.BackColor = System.Drawing.Color.Green
        Me.bt_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_modifier.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_modifier.ForeColor = System.Drawing.Color.White
        Me.bt_modifier.Location = New System.Drawing.Point(370, 127)
        Me.bt_modifier.Name = "bt_modifier"
        Me.bt_modifier.Size = New System.Drawing.Size(160, 27)
        Me.bt_modifier.TabIndex = 93
        Me.bt_modifier.Text = "Modifier"
        Me.bt_modifier.UseVisualStyleBackColor = False
        '
        'bt_supprimer
        '
        Me.bt_supprimer.BackColor = System.Drawing.Color.Green
        Me.bt_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_supprimer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_supprimer.ForeColor = System.Drawing.Color.White
        Me.bt_supprimer.Location = New System.Drawing.Point(370, 176)
        Me.bt_supprimer.Name = "bt_supprimer"
        Me.bt_supprimer.Size = New System.Drawing.Size(160, 27)
        Me.bt_supprimer.TabIndex = 92
        Me.bt_supprimer.Text = "Supprimer"
        Me.bt_supprimer.UseVisualStyleBackColor = False
        '
        'bt_ajouter
        '
        Me.bt_ajouter.BackColor = System.Drawing.Color.Green
        Me.bt_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_ajouter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ajouter.ForeColor = System.Drawing.Color.White
        Me.bt_ajouter.Location = New System.Drawing.Point(370, 85)
        Me.bt_ajouter.Name = "bt_ajouter"
        Me.bt_ajouter.Size = New System.Drawing.Size(160, 27)
        Me.bt_ajouter.TabIndex = 91
        Me.bt_ajouter.Text = "Ajouter"
        Me.bt_ajouter.UseVisualStyleBackColor = False
        '
        'bt_annuler
        '
        Me.bt_annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_annuler.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_annuler.ForeColor = System.Drawing.Color.White
        Me.bt_annuler.Location = New System.Drawing.Point(263, 353)
        Me.bt_annuler.Name = "bt_annuler"
        Me.bt_annuler.Size = New System.Drawing.Size(88, 29)
        Me.bt_annuler.TabIndex = 104
        Me.bt_annuler.Text = "Annuler"
        Me.bt_annuler.UseVisualStyleBackColor = False
        '
        'bt_retour
        '
        Me.bt_retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_retour.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_retour.ForeColor = System.Drawing.Color.White
        Me.bt_retour.Location = New System.Drawing.Point(70, 353)
        Me.bt_retour.Name = "bt_retour"
        Me.bt_retour.Size = New System.Drawing.Size(88, 29)
        Me.bt_retour.TabIndex = 103
        Me.bt_retour.Text = "Retour"
        Me.bt_retour.UseVisualStyleBackColor = False
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(455, 353)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 105
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'Gestion_des_Sponsors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(951, 441)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.bt_annuler)
        Me.Controls.Add(Me.bt_retour)
        Me.Controls.Add(Me.bt_enregistrer)
        Me.Controls.Add(Me.bt_chercher)
        Me.Controls.Add(Me.bt_modifier)
        Me.Controls.Add(Me.bt_supprimer)
        Me.Controls.Add(Me.bt_ajouter)
        Me.Controls.Add(Me.Data_sponsor)
        Me.Controls.Add(Me.tb_adresse_sponsor)
        Me.Controls.Add(Me.lb_Adresse_Sponsor)
        Me.Controls.Add(Me.tb_mail_sponsor)
        Me.Controls.Add(Me.tb_tel_sponsor)
        Me.Controls.Add(Me.tb_nom_sponsor)
        Me.Controls.Add(Me.tb_id_sponsor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Gestion_des_Sponsors"
        Me.Text = "Gestion_des_Sponsors"
        CType(Me.Data_sponsor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Data_sponsor As System.Windows.Forms.DataGridView
    Friend WithEvents ID_sponsor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nom_Sponsor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tb_adresse_sponsor As System.Windows.Forms.TextBox
    Friend WithEvents lb_Adresse_Sponsor As System.Windows.Forms.Label
    Friend WithEvents tb_mail_sponsor As System.Windows.Forms.TextBox
    Friend WithEvents tb_tel_sponsor As System.Windows.Forms.TextBox
    Friend WithEvents tb_nom_sponsor As System.Windows.Forms.TextBox
    Friend WithEvents tb_id_sponsor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bt_enregistrer As System.Windows.Forms.Button
    Friend WithEvents bt_chercher As System.Windows.Forms.Button
    Friend WithEvents bt_modifier As System.Windows.Forms.Button
    Friend WithEvents bt_supprimer As System.Windows.Forms.Button
    Friend WithEvents bt_ajouter As System.Windows.Forms.Button
    Friend WithEvents bt_annuler As System.Windows.Forms.Button
    Friend WithEvents bt_retour As System.Windows.Forms.Button
    Friend WithEvents bt_Quitter As Button
End Class
