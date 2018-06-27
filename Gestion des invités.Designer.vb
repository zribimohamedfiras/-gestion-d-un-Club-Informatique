<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gestion_des_invités
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gestion_des_invités))
        Me.bt_enregistrer = New System.Windows.Forms.Button()
        Me.bt_chercher = New System.Windows.Forms.Button()
        Me.bt_modifier = New System.Windows.Forms.Button()
        Me.bt_supprimer = New System.Windows.Forms.Button()
        Me.bt_ajouter = New System.Windows.Forms.Button()
        Me.RE = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_ID_invité = New System.Windows.Forms.TextBox()
        Me.tb_Nom_invité = New System.Windows.Forms.TextBox()
        Me.tb_prenom_invite = New System.Windows.Forms.TextBox()
        Me.tb_type = New System.Windows.Forms.TextBox()
        Me.tb_mail = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID_invité = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom_invité = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prenom_invité = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_Annuler = New System.Windows.Forms.Button()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_enregistrer
        '
        Me.bt_enregistrer.BackColor = System.Drawing.Color.Green
        Me.bt_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_enregistrer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_enregistrer.ForeColor = System.Drawing.Color.White
        Me.bt_enregistrer.Location = New System.Drawing.Point(333, 217)
        Me.bt_enregistrer.Name = "bt_enregistrer"
        Me.bt_enregistrer.Size = New System.Drawing.Size(104, 26)
        Me.bt_enregistrer.TabIndex = 14
        Me.bt_enregistrer.Text = "Enregistrer"
        Me.bt_enregistrer.UseVisualStyleBackColor = False
        '
        'bt_chercher
        '
        Me.bt_chercher.BackColor = System.Drawing.Color.Green
        Me.bt_chercher.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_chercher.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_chercher.ForeColor = System.Drawing.Color.White
        Me.bt_chercher.Location = New System.Drawing.Point(333, 265)
        Me.bt_chercher.Name = "bt_chercher"
        Me.bt_chercher.Size = New System.Drawing.Size(104, 23)
        Me.bt_chercher.TabIndex = 13
        Me.bt_chercher.Text = "Chercher"
        Me.bt_chercher.UseVisualStyleBackColor = False
        '
        'bt_modifier
        '
        Me.bt_modifier.BackColor = System.Drawing.Color.Green
        Me.bt_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_modifier.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_modifier.ForeColor = System.Drawing.Color.White
        Me.bt_modifier.Location = New System.Drawing.Point(333, 118)
        Me.bt_modifier.Name = "bt_modifier"
        Me.bt_modifier.Size = New System.Drawing.Size(104, 23)
        Me.bt_modifier.TabIndex = 12
        Me.bt_modifier.Text = "Modifier"
        Me.bt_modifier.UseVisualStyleBackColor = False
        '
        'bt_supprimer
        '
        Me.bt_supprimer.BackColor = System.Drawing.Color.Green
        Me.bt_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_supprimer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_supprimer.ForeColor = System.Drawing.Color.White
        Me.bt_supprimer.Location = New System.Drawing.Point(333, 164)
        Me.bt_supprimer.Name = "bt_supprimer"
        Me.bt_supprimer.Size = New System.Drawing.Size(104, 26)
        Me.bt_supprimer.TabIndex = 11
        Me.bt_supprimer.Text = "Supprimer"
        Me.bt_supprimer.UseVisualStyleBackColor = False
        '
        'bt_ajouter
        '
        Me.bt_ajouter.BackColor = System.Drawing.Color.Green
        Me.bt_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_ajouter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ajouter.ForeColor = System.Drawing.Color.White
        Me.bt_ajouter.Location = New System.Drawing.Point(333, 69)
        Me.bt_ajouter.Name = "bt_ajouter"
        Me.bt_ajouter.Size = New System.Drawing.Size(104, 26)
        Me.bt_ajouter.TabIndex = 10
        Me.bt_ajouter.Text = "Ajouter"
        Me.bt_ajouter.UseVisualStyleBackColor = False
        '
        'RE
        '
        Me.RE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RE.ForeColor = System.Drawing.Color.White
        Me.RE.Location = New System.Drawing.Point(44, 355)
        Me.RE.Name = "RE"
        Me.RE.Size = New System.Drawing.Size(88, 23)
        Me.RE.TabIndex = 15
        Me.RE.Text = "Retour"
        Me.RE.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(46, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "ID invité"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(46, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nom invité"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(41, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Prénom invité"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(41, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(46, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Mail"
        '
        'tb_ID_invité
        '
        Me.tb_ID_invité.Location = New System.Drawing.Point(146, 82)
        Me.tb_ID_invité.Name = "tb_ID_invité"
        Me.tb_ID_invité.Size = New System.Drawing.Size(127, 20)
        Me.tb_ID_invité.TabIndex = 21
        '
        'tb_Nom_invité
        '
        Me.tb_Nom_invité.Location = New System.Drawing.Point(146, 121)
        Me.tb_Nom_invité.Name = "tb_Nom_invité"
        Me.tb_Nom_invité.Size = New System.Drawing.Size(127, 20)
        Me.tb_Nom_invité.TabIndex = 22
        '
        'tb_prenom_invite
        '
        Me.tb_prenom_invite.Location = New System.Drawing.Point(146, 171)
        Me.tb_prenom_invite.Name = "tb_prenom_invite"
        Me.tb_prenom_invite.Size = New System.Drawing.Size(127, 20)
        Me.tb_prenom_invite.TabIndex = 23
        '
        'tb_type
        '
        Me.tb_type.Location = New System.Drawing.Point(146, 224)
        Me.tb_type.Name = "tb_type"
        Me.tb_type.Size = New System.Drawing.Size(127, 20)
        Me.tb_type.TabIndex = 24
        '
        'tb_mail
        '
        Me.tb_mail.Location = New System.Drawing.Point(146, 268)
        Me.tb_mail.Name = "tb_mail"
        Me.tb_mail.Size = New System.Drawing.Size(127, 20)
        Me.tb_mail.TabIndex = 25
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightYellow
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_invité, Me.Nom_invité, Me.Prenom_invité})
        Me.DataGridView1.Location = New System.Drawing.Point(478, 17)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(344, 293)
        Me.DataGridView1.TabIndex = 26
        '
        'ID_invité
        '
        Me.ID_invité.HeaderText = "ID Invité"
        Me.ID_invité.Name = "ID_invité"
        Me.ID_invité.ReadOnly = True
        '
        'Nom_invité
        '
        Me.Nom_invité.HeaderText = "Nom Invité"
        Me.Nom_invité.Name = "Nom_invité"
        Me.Nom_invité.ReadOnly = True
        '
        'Prenom_invité
        '
        Me.Prenom_invité.HeaderText = "Prénom Invité"
        Me.Prenom_invité.Name = "Prenom_invité"
        Me.Prenom_invité.ReadOnly = True
        '
        'tb_Annuler
        '
        Me.tb_Annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tb_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tb_Annuler.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_Annuler.ForeColor = System.Drawing.Color.White
        Me.tb_Annuler.Location = New System.Drawing.Point(156, 355)
        Me.tb_Annuler.Name = "tb_Annuler"
        Me.tb_Annuler.Size = New System.Drawing.Size(88, 23)
        Me.tb_Annuler.TabIndex = 27
        Me.tb_Annuler.Text = "Annuler"
        Me.tb_Annuler.UseVisualStyleBackColor = False
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(362, 356)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 28
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'Gestion_des_invités
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(842, 503)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.tb_Annuler)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tb_mail)
        Me.Controls.Add(Me.tb_type)
        Me.Controls.Add(Me.tb_prenom_invite)
        Me.Controls.Add(Me.tb_Nom_invité)
        Me.Controls.Add(Me.tb_ID_invité)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RE)
        Me.Controls.Add(Me.bt_enregistrer)
        Me.Controls.Add(Me.bt_chercher)
        Me.Controls.Add(Me.bt_modifier)
        Me.Controls.Add(Me.bt_supprimer)
        Me.Controls.Add(Me.bt_ajouter)
        Me.Name = "Gestion_des_invités"
        Me.Text = "Gestion des Invités"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_enregistrer As System.Windows.Forms.Button
    Friend WithEvents bt_chercher As System.Windows.Forms.Button
    Friend WithEvents bt_modifier As System.Windows.Forms.Button
    Friend WithEvents bt_supprimer As System.Windows.Forms.Button
    Friend WithEvents bt_ajouter As System.Windows.Forms.Button
    Friend WithEvents RE As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_ID_invité As System.Windows.Forms.TextBox
    Friend WithEvents tb_Nom_invité As System.Windows.Forms.TextBox
    Friend WithEvents tb_prenom_invite As System.Windows.Forms.TextBox
    Friend WithEvents tb_type As System.Windows.Forms.TextBox
    Friend WithEvents tb_mail As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tb_Annuler As System.Windows.Forms.Button
    Friend WithEvents ID_invité As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nom_invité As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prenom_invité As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bt_Quitter As Button
End Class
