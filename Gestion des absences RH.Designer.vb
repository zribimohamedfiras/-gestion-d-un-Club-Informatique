<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion_des_absences_RH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gestion_des_absences_RH))
        Me.data_membre = New System.Windows.Forms.DataGridView()
        Me.NCIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRENOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPARTEMENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_Afficher = New System.Windows.Forms.TextBox()
        Me.r_oui = New System.Windows.Forms.RadioButton()
        Me.r_non = New System.Windows.Forms.RadioButton()
        Me.lb_Presence = New System.Windows.Forms.Label()
        Me.bt_Afficher = New System.Windows.Forms.Button()
        Me.cb_Nom_évenement = New System.Windows.Forms.ComboBox()
        Me.Annuler = New System.Windows.Forms.Button()
        Me.tb_nom_membre = New System.Windows.Forms.TextBox()
        Me.TB_NCIN_MEMBRE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nom_membre = New System.Windows.Forms.Label()
        Me.ncin_membre = New System.Windows.Forms.Label()
        Me.RE = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        CType(Me.data_membre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data_membre
        '
        Me.data_membre.BackgroundColor = System.Drawing.Color.White
        Me.data_membre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_membre.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NCIN, Me.NOM, Me.PRENOM, Me.DEPARTEMENT})
        Me.data_membre.GridColor = System.Drawing.Color.WhiteSmoke
        Me.data_membre.Location = New System.Drawing.Point(444, 3)
        Me.data_membre.Name = "data_membre"
        Me.data_membre.Size = New System.Drawing.Size(443, 226)
        Me.data_membre.TabIndex = 113
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
        'tb_Afficher
        '
        Me.tb_Afficher.Enabled = False
        Me.tb_Afficher.Location = New System.Drawing.Point(577, 330)
        Me.tb_Afficher.Name = "tb_Afficher"
        Me.tb_Afficher.Size = New System.Drawing.Size(229, 20)
        Me.tb_Afficher.TabIndex = 111
        '
        'r_oui
        '
        Me.r_oui.AutoSize = True
        Me.r_oui.Location = New System.Drawing.Point(35, 244)
        Me.r_oui.Name = "r_oui"
        Me.r_oui.Size = New System.Drawing.Size(41, 17)
        Me.r_oui.TabIndex = 110
        Me.r_oui.TabStop = True
        Me.r_oui.Text = "Oui"
        Me.r_oui.UseVisualStyleBackColor = True
        '
        'r_non
        '
        Me.r_non.AutoSize = True
        Me.r_non.Location = New System.Drawing.Point(203, 244)
        Me.r_non.Name = "r_non"
        Me.r_non.Size = New System.Drawing.Size(45, 17)
        Me.r_non.TabIndex = 109
        Me.r_non.TabStop = True
        Me.r_non.Text = "Non"
        Me.r_non.UseVisualStyleBackColor = True
        '
        'lb_Presence
        '
        Me.lb_Presence.AutoSize = True
        Me.lb_Presence.BackColor = System.Drawing.Color.Yellow
        Me.lb_Presence.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Presence.Location = New System.Drawing.Point(103, 181)
        Me.lb_Presence.Name = "lb_Presence"
        Me.lb_Presence.Size = New System.Drawing.Size(116, 29)
        Me.lb_Presence.TabIndex = 108
        Me.lb_Presence.Text = "Presence"
        '
        'bt_Afficher
        '
        Me.bt_Afficher.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Afficher.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_Afficher.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.bt_Afficher.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bt_Afficher.Location = New System.Drawing.Point(511, 244)
        Me.bt_Afficher.Name = "bt_Afficher"
        Me.bt_Afficher.Size = New System.Drawing.Size(317, 62)
        Me.bt_Afficher.TabIndex = 107
        Me.bt_Afficher.Text = "Afficher nombres d'absence totale"
        Me.bt_Afficher.UseVisualStyleBackColor = False
        '
        'cb_Nom_évenement
        '
        Me.cb_Nom_évenement.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cb_Nom_évenement.FormattingEnabled = True
        Me.cb_Nom_évenement.Items.AddRange(New Object() {"e1", "e2", "e3", " "})
        Me.cb_Nom_évenement.Location = New System.Drawing.Point(144, 103)
        Me.cb_Nom_évenement.Name = "cb_Nom_évenement"
        Me.cb_Nom_évenement.Size = New System.Drawing.Size(229, 21)
        Me.cb_Nom_évenement.TabIndex = 106
        Me.cb_Nom_évenement.Text = "   taper le nom de l'evenement"
        '
        'Annuler
        '
        Me.Annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Annuler.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Annuler.ForeColor = System.Drawing.Color.White
        Me.Annuler.Location = New System.Drawing.Point(167, 312)
        Me.Annuler.Name = "Annuler"
        Me.Annuler.Size = New System.Drawing.Size(81, 23)
        Me.Annuler.TabIndex = 105
        Me.Annuler.Text = "Annuler"
        Me.Annuler.UseVisualStyleBackColor = False
        '
        'tb_nom_membre
        '
        Me.tb_nom_membre.Location = New System.Drawing.Point(144, 148)
        Me.tb_nom_membre.Name = "tb_nom_membre"
        Me.tb_nom_membre.Size = New System.Drawing.Size(229, 20)
        Me.tb_nom_membre.TabIndex = 104
        '
        'TB_NCIN_MEMBRE
        '
        Me.TB_NCIN_MEMBRE.Location = New System.Drawing.Point(144, 49)
        Me.TB_NCIN_MEMBRE.Name = "TB_NCIN_MEMBRE"
        Me.TB_NCIN_MEMBRE.Size = New System.Drawing.Size(229, 20)
        Me.TB_NCIN_MEMBRE.TabIndex = 103
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(13, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Id de l'évenement"
        '
        'nom_membre
        '
        Me.nom_membre.AutoSize = True
        Me.nom_membre.BackColor = System.Drawing.Color.Yellow
        Me.nom_membre.Location = New System.Drawing.Point(13, 148)
        Me.nom_membre.Name = "nom_membre"
        Me.nom_membre.Size = New System.Drawing.Size(70, 13)
        Me.nom_membre.TabIndex = 101
        Me.nom_membre.Text = "Nom Membre"
        '
        'ncin_membre
        '
        Me.ncin_membre.AutoSize = True
        Me.ncin_membre.BackColor = System.Drawing.Color.Yellow
        Me.ncin_membre.Location = New System.Drawing.Point(13, 56)
        Me.ncin_membre.Name = "ncin_membre"
        Me.ncin_membre.Size = New System.Drawing.Size(70, 13)
        Me.ncin_membre.TabIndex = 100
        Me.ncin_membre.Text = "Ncin Membre"
        '
        'RE
        '
        Me.RE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RE.ForeColor = System.Drawing.Color.White
        Me.RE.Location = New System.Drawing.Point(26, 312)
        Me.RE.Name = "RE"
        Me.RE.Size = New System.Drawing.Size(88, 23)
        Me.RE.TabIndex = 99
        Me.RE.Text = "Retour"
        Me.RE.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(308, 238)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 26)
        Me.Button1.TabIndex = 114
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(337, 312)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 115
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'Gestion_des_absences_RH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(899, 419)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.data_membre)
        Me.Controls.Add(Me.tb_Afficher)
        Me.Controls.Add(Me.r_oui)
        Me.Controls.Add(Me.r_non)
        Me.Controls.Add(Me.lb_Presence)
        Me.Controls.Add(Me.bt_Afficher)
        Me.Controls.Add(Me.cb_Nom_évenement)
        Me.Controls.Add(Me.Annuler)
        Me.Controls.Add(Me.tb_nom_membre)
        Me.Controls.Add(Me.TB_NCIN_MEMBRE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nom_membre)
        Me.Controls.Add(Me.ncin_membre)
        Me.Controls.Add(Me.RE)
        Me.Name = "Gestion_des_absences_RH"
        Me.Text = "Gestion des absences RH"
        CType(Me.data_membre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents data_membre As System.Windows.Forms.DataGridView
    Friend WithEvents NCIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRENOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEPARTEMENT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tb_Afficher As System.Windows.Forms.TextBox
    Friend WithEvents r_oui As System.Windows.Forms.RadioButton
    Friend WithEvents r_non As System.Windows.Forms.RadioButton
    Friend WithEvents lb_Presence As System.Windows.Forms.Label
    Friend WithEvents bt_Afficher As System.Windows.Forms.Button
    Friend WithEvents cb_Nom_évenement As System.Windows.Forms.ComboBox
    Friend WithEvents Annuler As System.Windows.Forms.Button
    Friend WithEvents tb_nom_membre As System.Windows.Forms.TextBox
    Friend WithEvents TB_NCIN_MEMBRE As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nom_membre As System.Windows.Forms.Label
    Friend WithEvents ncin_membre As System.Windows.Forms.Label
    Friend WithEvents RE As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents bt_Quitter As Button
End Class
