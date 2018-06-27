<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Presence_Invité
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Presence_Invité))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID_invite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRENOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bt_Supprimer = New System.Windows.Forms.Button()
        Me.bt_Enregistrer = New System.Windows.Forms.Button()
        Me.bt_Chercher = New System.Windows.Forms.Button()
        Me.bt_modifier = New System.Windows.Forms.Button()
        Me.cb__Nom_Evenement = New System.Windows.Forms.ComboBox()
        Me.lb_Nom_Evenement = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.l_oui = New System.Windows.Forms.Label()
        Me.r_oui = New System.Windows.Forms.RadioButton()
        Me.r_non = New System.Windows.Forms.RadioButton()
        Me.bt_annuler = New System.Windows.Forms.Button()
        Me.tb__Afficher_Nombre_Présence = New System.Windows.Forms.TextBox()
        Me.bt_Afficher_Nombre_Présence = New System.Windows.Forms.Button()
        Me.bt_retour = New System.Windows.Forms.Button()
        Me.bt_ajouter = New System.Windows.Forms.Button()
        Me.lb_Presence = New System.Windows.Forms.Label()
        Me.tb_id_invite = New System.Windows.Forms.TextBox()
        Me.lb_id_invite = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.D_evenement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_invite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Presence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightYellow
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_invite, Me.NOM, Me.PRENOM})
        Me.DataGridView1.Location = New System.Drawing.Point(497, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(343, 177)
        Me.DataGridView1.TabIndex = 73
        '
        'ID_invite
        '
        Me.ID_invite.HeaderText = "ID Invité"
        Me.ID_invite.Name = "ID_invite"
        Me.ID_invite.ReadOnly = True
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
        'bt_Supprimer
        '
        Me.bt_Supprimer.BackColor = System.Drawing.Color.Green
        Me.bt_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Supprimer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Supprimer.ForeColor = System.Drawing.Color.White
        Me.bt_Supprimer.Location = New System.Drawing.Point(370, 215)
        Me.bt_Supprimer.Name = "bt_Supprimer"
        Me.bt_Supprimer.Size = New System.Drawing.Size(107, 33)
        Me.bt_Supprimer.TabIndex = 112
        Me.bt_Supprimer.Text = "Supprimer"
        Me.bt_Supprimer.UseVisualStyleBackColor = False
        '
        'bt_Enregistrer
        '
        Me.bt_Enregistrer.BackColor = System.Drawing.Color.Green
        Me.bt_Enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Enregistrer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Enregistrer.ForeColor = System.Drawing.Color.White
        Me.bt_Enregistrer.Location = New System.Drawing.Point(370, 276)
        Me.bt_Enregistrer.Name = "bt_Enregistrer"
        Me.bt_Enregistrer.Size = New System.Drawing.Size(107, 33)
        Me.bt_Enregistrer.TabIndex = 111
        Me.bt_Enregistrer.Text = "Enregistrer"
        Me.bt_Enregistrer.UseVisualStyleBackColor = False
        '
        'bt_Chercher
        '
        Me.bt_Chercher.BackColor = System.Drawing.Color.Green
        Me.bt_Chercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Chercher.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Chercher.ForeColor = System.Drawing.Color.White
        Me.bt_Chercher.Location = New System.Drawing.Point(370, 26)
        Me.bt_Chercher.Name = "bt_Chercher"
        Me.bt_Chercher.Size = New System.Drawing.Size(107, 33)
        Me.bt_Chercher.TabIndex = 110
        Me.bt_Chercher.Text = "Chercher"
        Me.bt_Chercher.UseVisualStyleBackColor = False
        '
        'bt_modifier
        '
        Me.bt_modifier.BackColor = System.Drawing.Color.Green
        Me.bt_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_modifier.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_modifier.ForeColor = System.Drawing.Color.White
        Me.bt_modifier.Location = New System.Drawing.Point(370, 88)
        Me.bt_modifier.Name = "bt_modifier"
        Me.bt_modifier.Size = New System.Drawing.Size(107, 33)
        Me.bt_modifier.TabIndex = 109
        Me.bt_modifier.Text = "Modifier"
        Me.bt_modifier.UseVisualStyleBackColor = False
        '
        'cb__Nom_Evenement
        '
        Me.cb__Nom_Evenement.FormattingEnabled = True
        Me.cb__Nom_Evenement.Location = New System.Drawing.Point(173, 48)
        Me.cb__Nom_Evenement.Name = "cb__Nom_Evenement"
        Me.cb__Nom_Evenement.Size = New System.Drawing.Size(156, 21)
        Me.cb__Nom_Evenement.TabIndex = 108
        '
        'lb_Nom_Evenement
        '
        Me.lb_Nom_Evenement.AutoSize = True
        Me.lb_Nom_Evenement.BackColor = System.Drawing.Color.Yellow
        Me.lb_Nom_Evenement.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lb_Nom_Evenement.ForeColor = System.Drawing.Color.Black
        Me.lb_Nom_Evenement.Location = New System.Drawing.Point(32, 50)
        Me.lb_Nom_Evenement.Name = "lb_Nom_Evenement"
        Me.lb_Nom_Evenement.Size = New System.Drawing.Size(86, 13)
        Me.lb_Nom_Evenement.TabIndex = 107
        Me.lb_Nom_Evenement.Text = "Nom Evenement"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(217, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Non"
        '
        'l_oui
        '
        Me.l_oui.AutoSize = True
        Me.l_oui.BackColor = System.Drawing.Color.Yellow
        Me.l_oui.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.l_oui.ForeColor = System.Drawing.Color.Black
        Me.l_oui.Location = New System.Drawing.Point(103, 250)
        Me.l_oui.Name = "l_oui"
        Me.l_oui.Size = New System.Drawing.Size(23, 13)
        Me.l_oui.TabIndex = 105
        Me.l_oui.Text = "Oui"
        '
        'r_oui
        '
        Me.r_oui.AutoSize = True
        Me.r_oui.Location = New System.Drawing.Point(83, 250)
        Me.r_oui.Name = "r_oui"
        Me.r_oui.Size = New System.Drawing.Size(14, 13)
        Me.r_oui.TabIndex = 104
        Me.r_oui.TabStop = True
        Me.r_oui.UseVisualStyleBackColor = True
        '
        'r_non
        '
        Me.r_non.AutoSize = True
        Me.r_non.Location = New System.Drawing.Point(197, 250)
        Me.r_non.Name = "r_non"
        Me.r_non.Size = New System.Drawing.Size(14, 13)
        Me.r_non.TabIndex = 103
        Me.r_non.TabStop = True
        Me.r_non.UseVisualStyleBackColor = True
        '
        'bt_annuler
        '
        Me.bt_annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_annuler.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_annuler.ForeColor = System.Drawing.Color.White
        Me.bt_annuler.Location = New System.Drawing.Point(370, 326)
        Me.bt_annuler.Name = "bt_annuler"
        Me.bt_annuler.Size = New System.Drawing.Size(107, 33)
        Me.bt_annuler.TabIndex = 102
        Me.bt_annuler.Text = "Annuler"
        Me.bt_annuler.UseVisualStyleBackColor = False
        '
        'tb__Afficher_Nombre_Présence
        '
        Me.tb__Afficher_Nombre_Présence.Location = New System.Drawing.Point(134, 384)
        Me.tb__Afficher_Nombre_Présence.Name = "tb__Afficher_Nombre_Présence"
        Me.tb__Afficher_Nombre_Présence.Size = New System.Drawing.Size(156, 20)
        Me.tb__Afficher_Nombre_Présence.TabIndex = 101
        '
        'bt_Afficher_Nombre_Présence
        '
        Me.bt_Afficher_Nombre_Présence.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Afficher_Nombre_Présence.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Afficher_Nombre_Présence.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_Afficher_Nombre_Présence.ForeColor = System.Drawing.Color.White
        Me.bt_Afficher_Nombre_Présence.Location = New System.Drawing.Point(103, 326)
        Me.bt_Afficher_Nombre_Présence.Name = "bt_Afficher_Nombre_Présence"
        Me.bt_Afficher_Nombre_Présence.Size = New System.Drawing.Size(261, 34)
        Me.bt_Afficher_Nombre_Présence.TabIndex = 100
        Me.bt_Afficher_Nombre_Présence.Text = "Afficher Nombre de Présence"
        Me.bt_Afficher_Nombre_Présence.UseVisualStyleBackColor = False
        '
        'bt_retour
        '
        Me.bt_retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_retour.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_retour.ForeColor = System.Drawing.Color.White
        Me.bt_retour.Location = New System.Drawing.Point(8, 326)
        Me.bt_retour.Name = "bt_retour"
        Me.bt_retour.Size = New System.Drawing.Size(88, 33)
        Me.bt_retour.TabIndex = 99
        Me.bt_retour.Text = "Retour"
        Me.bt_retour.UseVisualStyleBackColor = False
        '
        'bt_ajouter
        '
        Me.bt_ajouter.BackColor = System.Drawing.Color.Green
        Me.bt_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_ajouter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ajouter.ForeColor = System.Drawing.Color.White
        Me.bt_ajouter.Location = New System.Drawing.Point(370, 148)
        Me.bt_ajouter.Name = "bt_ajouter"
        Me.bt_ajouter.Size = New System.Drawing.Size(107, 33)
        Me.bt_ajouter.TabIndex = 98
        Me.bt_ajouter.Text = "Ajouter"
        Me.bt_ajouter.UseVisualStyleBackColor = False
        '
        'lb_Presence
        '
        Me.lb_Presence.AutoSize = True
        Me.lb_Presence.BackColor = System.Drawing.Color.Yellow
        Me.lb_Presence.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Presence.ForeColor = System.Drawing.Color.Black
        Me.lb_Presence.Location = New System.Drawing.Point(113, 182)
        Me.lb_Presence.Name = "lb_Presence"
        Me.lb_Presence.Size = New System.Drawing.Size(132, 29)
        Me.lb_Presence.TabIndex = 97
        Me.lb_Presence.Text = "Presence :"
        '
        'tb_id_invite
        '
        Me.tb_id_invite.Location = New System.Drawing.Point(173, 101)
        Me.tb_id_invite.Name = "tb_id_invite"
        Me.tb_id_invite.Size = New System.Drawing.Size(156, 20)
        Me.tb_id_invite.TabIndex = 96
        '
        'lb_id_invite
        '
        Me.lb_id_invite.AutoSize = True
        Me.lb_id_invite.BackColor = System.Drawing.Color.Yellow
        Me.lb_id_invite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lb_id_invite.ForeColor = System.Drawing.Color.Black
        Me.lb_id_invite.Location = New System.Drawing.Point(32, 102)
        Me.lb_id_invite.Name = "lb_id_invite"
        Me.lb_id_invite.Size = New System.Drawing.Size(47, 13)
        Me.lb_id_invite.TabIndex = 95
        Me.lb_id_invite.Text = "ID Invité"
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.LightYellow
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.D_evenement, Me.D_invite, Me.Presence})
        Me.DataGridView2.Location = New System.Drawing.Point(497, 205)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(343, 177)
        Me.DataGridView2.TabIndex = 113
        '
        'D_evenement
        '
        Me.D_evenement.HeaderText = "ID Evenement"
        Me.D_evenement.Name = "D_evenement"
        Me.D_evenement.ReadOnly = True
        '
        'D_invite
        '
        Me.D_invite.HeaderText = "ID Invité"
        Me.D_invite.Name = "D_invite"
        Me.D_invite.ReadOnly = True
        '
        'Presence
        '
        Me.Presence.HeaderText = "Presence"
        Me.Presence.Name = "Presence"
        Me.Presence.ReadOnly = True
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(765, 388)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 114
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'Presence_Invité
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(842, 503)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.bt_Supprimer)
        Me.Controls.Add(Me.bt_Enregistrer)
        Me.Controls.Add(Me.bt_Chercher)
        Me.Controls.Add(Me.bt_modifier)
        Me.Controls.Add(Me.cb__Nom_Evenement)
        Me.Controls.Add(Me.lb_Nom_Evenement)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.l_oui)
        Me.Controls.Add(Me.r_oui)
        Me.Controls.Add(Me.r_non)
        Me.Controls.Add(Me.bt_annuler)
        Me.Controls.Add(Me.tb__Afficher_Nombre_Présence)
        Me.Controls.Add(Me.bt_Afficher_Nombre_Présence)
        Me.Controls.Add(Me.bt_retour)
        Me.Controls.Add(Me.bt_ajouter)
        Me.Controls.Add(Me.lb_Presence)
        Me.Controls.Add(Me.tb_id_invite)
        Me.Controls.Add(Me.lb_id_invite)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Presence_Invité"
        Me.Text = "Presence_Invité"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ID_invite As DataGridViewTextBoxColumn
    Friend WithEvents NOM As DataGridViewTextBoxColumn
    Friend WithEvents PRENOM As DataGridViewTextBoxColumn
    Friend WithEvents bt_Supprimer As Button
    Friend WithEvents bt_Enregistrer As Button
    Friend WithEvents bt_Chercher As Button
    Friend WithEvents bt_modifier As Button
    Friend WithEvents cb__Nom_Evenement As ComboBox
    Friend WithEvents lb_Nom_Evenement As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents l_oui As Label
    Friend WithEvents r_oui As RadioButton
    Friend WithEvents r_non As RadioButton
    Friend WithEvents bt_annuler As Button
    Friend WithEvents tb__Afficher_Nombre_Présence As TextBox
    Friend WithEvents bt_Afficher_Nombre_Présence As Button
    Friend WithEvents bt_retour As Button
    Friend WithEvents bt_ajouter As Button
    Friend WithEvents lb_Presence As Label
    Friend WithEvents tb_id_invite As TextBox
    Friend WithEvents lb_id_invite As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents D_evenement As DataGridViewTextBoxColumn
    Friend WithEvents D_invite As DataGridViewTextBoxColumn
    Friend WithEvents Presence As DataGridViewTextBoxColumn
    Friend WithEvents bt_Quitter As Button
End Class
