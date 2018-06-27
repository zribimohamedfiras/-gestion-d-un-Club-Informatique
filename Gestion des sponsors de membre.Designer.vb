<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion_des_sponsors_de_membre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gestion_des_sponsors_de_membre))
        Me.lb_Adresse_Sponsor = New System.Windows.Forms.Label()
        Me.RE = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb_adresse_sponsor = New System.Windows.Forms.TextBox()
        Me.Data_sponsor = New System.Windows.Forms.DataGridView()
        Me.ID_sponsor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom_Sponsor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_mail_sponsor = New System.Windows.Forms.TextBox()
        Me.tb_tel_sponsor = New System.Windows.Forms.TextBox()
        Me.tb_nom_sponsor = New System.Windows.Forms.TextBox()
        Me.tb_id_sponsor = New System.Windows.Forms.TextBox()
        Me.bt_annuler = New System.Windows.Forms.Button()
        Me.retour = New System.Windows.Forms.Button()
        Me.bt_enregistrer = New System.Windows.Forms.Button()
        Me.bt_chercher = New System.Windows.Forms.Button()
        Me.bt_ajouter = New System.Windows.Forms.Button()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        CType(Me.Data_sponsor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_Adresse_Sponsor
        '
        Me.lb_Adresse_Sponsor.AutoSize = True
        Me.lb_Adresse_Sponsor.Location = New System.Drawing.Point(-186, 178)
        Me.lb_Adresse_Sponsor.Name = "lb_Adresse_Sponsor"
        Me.lb_Adresse_Sponsor.Size = New System.Drawing.Size(87, 13)
        Me.lb_Adresse_Sponsor.TabIndex = 61
        Me.lb_Adresse_Sponsor.Text = "Adresse Sponsor"
        '
        'RE
        '
        Me.RE.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.RE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RE.Location = New System.Drawing.Point(-177, 271)
        Me.RE.Name = "RE"
        Me.RE.Size = New System.Drawing.Size(88, 23)
        Me.RE.TabIndex = 59
        Me.RE.Text = "Retour"
        Me.RE.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-189, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Nom Sponsor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-186, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Mail Sponsor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-189, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Téléphone Sponsor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-189, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "ID Sponsor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(15, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Adresse Sponsor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(15, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Nom Sponsor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(18, 289)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Mail Sponsor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(9, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Téléphone Sponsor"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(15, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "ID Sponsor"
        '
        'tb_adresse_sponsor
        '
        Me.tb_adresse_sponsor.Location = New System.Drawing.Point(115, 236)
        Me.tb_adresse_sponsor.Name = "tb_adresse_sponsor"
        Me.tb_adresse_sponsor.Size = New System.Drawing.Size(147, 20)
        Me.tb_adresse_sponsor.TabIndex = 78
        '
        'Data_sponsor
        '
        Me.Data_sponsor.BackgroundColor = System.Drawing.Color.White
        Me.Data_sponsor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data_sponsor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_sponsor, Me.Nom_Sponsor})
        Me.Data_sponsor.Location = New System.Drawing.Point(471, 35)
        Me.Data_sponsor.Name = "Data_sponsor"
        Me.Data_sponsor.Size = New System.Drawing.Size(248, 227)
        Me.Data_sponsor.TabIndex = 76
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
        'tb_mail_sponsor
        '
        Me.tb_mail_sponsor.Location = New System.Drawing.Point(115, 289)
        Me.tb_mail_sponsor.Name = "tb_mail_sponsor"
        Me.tb_mail_sponsor.Size = New System.Drawing.Size(147, 20)
        Me.tb_mail_sponsor.TabIndex = 72
        '
        'tb_tel_sponsor
        '
        Me.tb_tel_sponsor.Location = New System.Drawing.Point(115, 172)
        Me.tb_tel_sponsor.Name = "tb_tel_sponsor"
        Me.tb_tel_sponsor.Size = New System.Drawing.Size(147, 20)
        Me.tb_tel_sponsor.TabIndex = 71
        '
        'tb_nom_sponsor
        '
        Me.tb_nom_sponsor.Location = New System.Drawing.Point(115, 118)
        Me.tb_nom_sponsor.Name = "tb_nom_sponsor"
        Me.tb_nom_sponsor.Size = New System.Drawing.Size(147, 20)
        Me.tb_nom_sponsor.TabIndex = 70
        '
        'tb_id_sponsor
        '
        Me.tb_id_sponsor.Location = New System.Drawing.Point(115, 51)
        Me.tb_id_sponsor.Name = "tb_id_sponsor"
        Me.tb_id_sponsor.Size = New System.Drawing.Size(147, 20)
        Me.tb_id_sponsor.TabIndex = 69
        '
        'bt_annuler
        '
        Me.bt_annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_annuler.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_annuler.ForeColor = System.Drawing.Color.White
        Me.bt_annuler.Location = New System.Drawing.Point(174, 335)
        Me.bt_annuler.Name = "bt_annuler"
        Me.bt_annuler.Size = New System.Drawing.Size(88, 23)
        Me.bt_annuler.TabIndex = 133
        Me.bt_annuler.Text = "Annuler"
        Me.bt_annuler.UseVisualStyleBackColor = False
        '
        'retour
        '
        Me.retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.retour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.retour.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.retour.ForeColor = System.Drawing.Color.White
        Me.retour.Location = New System.Drawing.Point(14, 335)
        Me.retour.Name = "retour"
        Me.retour.Size = New System.Drawing.Size(88, 23)
        Me.retour.TabIndex = 132
        Me.retour.Text = "Retour"
        Me.retour.UseVisualStyleBackColor = False
        '
        'bt_enregistrer
        '
        Me.bt_enregistrer.BackColor = System.Drawing.Color.Green
        Me.bt_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_enregistrer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_enregistrer.ForeColor = System.Drawing.Color.White
        Me.bt_enregistrer.Location = New System.Drawing.Point(304, 151)
        Me.bt_enregistrer.Name = "bt_enregistrer"
        Me.bt_enregistrer.Size = New System.Drawing.Size(116, 26)
        Me.bt_enregistrer.TabIndex = 131
        Me.bt_enregistrer.Text = "Enregistrer"
        Me.bt_enregistrer.UseVisualStyleBackColor = False
        '
        'bt_chercher
        '
        Me.bt_chercher.BackColor = System.Drawing.Color.Green
        Me.bt_chercher.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_chercher.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_chercher.ForeColor = System.Drawing.Color.White
        Me.bt_chercher.Location = New System.Drawing.Point(304, 231)
        Me.bt_chercher.Name = "bt_chercher"
        Me.bt_chercher.Size = New System.Drawing.Size(116, 31)
        Me.bt_chercher.TabIndex = 130
        Me.bt_chercher.Text = "Chercher"
        Me.bt_chercher.UseVisualStyleBackColor = False
        '
        'bt_ajouter
        '
        Me.bt_ajouter.BackColor = System.Drawing.Color.Green
        Me.bt_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_ajouter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ajouter.ForeColor = System.Drawing.Color.White
        Me.bt_ajouter.Location = New System.Drawing.Point(304, 75)
        Me.bt_ajouter.Name = "bt_ajouter"
        Me.bt_ajouter.Size = New System.Drawing.Size(116, 27)
        Me.bt_ajouter.TabIndex = 127
        Me.bt_ajouter.Text = "Ajouter"
        Me.bt_ajouter.UseVisualStyleBackColor = False
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(644, 335)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 134
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'Gestion_des_sponsors_de_membre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(728, 430)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.bt_annuler)
        Me.Controls.Add(Me.retour)
        Me.Controls.Add(Me.bt_enregistrer)
        Me.Controls.Add(Me.bt_chercher)
        Me.Controls.Add(Me.bt_ajouter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tb_adresse_sponsor)
        Me.Controls.Add(Me.Data_sponsor)
        Me.Controls.Add(Me.tb_mail_sponsor)
        Me.Controls.Add(Me.tb_tel_sponsor)
        Me.Controls.Add(Me.tb_nom_sponsor)
        Me.Controls.Add(Me.tb_id_sponsor)
        Me.Controls.Add(Me.lb_Adresse_Sponsor)
        Me.Controls.Add(Me.RE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Gestion_des_sponsors_de_membre"
        Me.Text = "Gestion_des_sponsors_de_membre"
        CType(Me.Data_sponsor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_Adresse_Sponsor As System.Windows.Forms.Label
    Friend WithEvents RE As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tb_adresse_sponsor As System.Windows.Forms.TextBox
    Friend WithEvents Data_sponsor As System.Windows.Forms.DataGridView
    Friend WithEvents ID_sponsor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nom_Sponsor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tb_mail_sponsor As System.Windows.Forms.TextBox
    Friend WithEvents tb_tel_sponsor As System.Windows.Forms.TextBox
    Friend WithEvents tb_nom_sponsor As System.Windows.Forms.TextBox
    Friend WithEvents tb_id_sponsor As System.Windows.Forms.TextBox
    Friend WithEvents bt_annuler As System.Windows.Forms.Button
    Friend WithEvents retour As System.Windows.Forms.Button
    Friend WithEvents bt_enregistrer As System.Windows.Forms.Button
    Friend WithEvents bt_chercher As System.Windows.Forms.Button
    Friend WithEvents bt_ajouter As System.Windows.Forms.Button
    Friend WithEvents bt_Quitter As Button
End Class
