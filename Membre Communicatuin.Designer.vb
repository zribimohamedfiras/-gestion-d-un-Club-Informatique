<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Membre_Communicatuin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Membre_Communicatuin))
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
        Me.bt_annuler = New System.Windows.Forms.Button()
        Me.bt_retour = New System.Windows.Forms.Button()
        Me.bt_chercher = New System.Windows.Forms.Button()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tb_tache
        '
        Me.tb_tache.Enabled = False
        Me.tb_tache.Location = New System.Drawing.Point(213, 249)
        Me.tb_tache.Name = "tb_tache"
        Me.tb_tache.Size = New System.Drawing.Size(231, 20)
        Me.tb_tache.TabIndex = 85
        '
        'tb_nom_evenement
        '
        Me.tb_nom_evenement.Enabled = False
        Me.tb_nom_evenement.Location = New System.Drawing.Point(213, 168)
        Me.tb_nom_evenement.Name = "tb_nom_evenement"
        Me.tb_nom_evenement.Size = New System.Drawing.Size(229, 20)
        Me.tb_nom_evenement.TabIndex = 84
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(95, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Nom de l'évenement"
        '
        'tb_date_evenement
        '
        Me.tb_date_evenement.Location = New System.Drawing.Point(213, 199)
        Me.tb_date_evenement.Name = "tb_date_evenement"
        Me.tb_date_evenement.Size = New System.Drawing.Size(231, 20)
        Me.tb_date_evenement.TabIndex = 82
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(94, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Date  de l'évenement"
        '
        'cb_id_evenement
        '
        Me.cb_id_evenement.FormattingEnabled = True
        Me.cb_id_evenement.Items.AddRange(New Object() {"e1", "e2", "e3"})
        Me.cb_id_evenement.Location = New System.Drawing.Point(211, 63)
        Me.cb_id_evenement.Name = "cb_id_evenement"
        Me.cb_id_evenement.Size = New System.Drawing.Size(229, 21)
        Me.cb_id_evenement.TabIndex = 80
        '
        'tb_nom_membre
        '
        Me.tb_nom_membre.Location = New System.Drawing.Point(211, 137)
        Me.tb_nom_membre.Name = "tb_nom_membre"
        Me.tb_nom_membre.Size = New System.Drawing.Size(229, 20)
        Me.tb_nom_membre.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(94, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = " Nom de membre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(94, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Tache accordeé"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(95, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "ID  de l'évenement"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(95, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Ncin de la membre"
        '
        'TB_NCIN_MEMBRE
        '
        Me.TB_NCIN_MEMBRE.Location = New System.Drawing.Point(211, 21)
        Me.TB_NCIN_MEMBRE.Name = "TB_NCIN_MEMBRE"
        Me.TB_NCIN_MEMBRE.Size = New System.Drawing.Size(229, 20)
        Me.TB_NCIN_MEMBRE.TabIndex = 74
        '
        'bt_annuler
        '
        Me.bt_annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_annuler.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_annuler.ForeColor = System.Drawing.Color.White
        Me.bt_annuler.Location = New System.Drawing.Point(379, 315)
        Me.bt_annuler.Name = "bt_annuler"
        Me.bt_annuler.Size = New System.Drawing.Size(88, 29)
        Me.bt_annuler.TabIndex = 107
        Me.bt_annuler.Text = "Annuler"
        Me.bt_annuler.UseVisualStyleBackColor = False
        '
        'bt_retour
        '
        Me.bt_retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_retour.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_retour.ForeColor = System.Drawing.Color.White
        Me.bt_retour.Location = New System.Drawing.Point(74, 317)
        Me.bt_retour.Name = "bt_retour"
        Me.bt_retour.Size = New System.Drawing.Size(88, 29)
        Me.bt_retour.TabIndex = 106
        Me.bt_retour.Text = "Retour"
        Me.bt_retour.UseVisualStyleBackColor = False
        '
        'bt_chercher
        '
        Me.bt_chercher.BackColor = System.Drawing.Color.Green
        Me.bt_chercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_chercher.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_chercher.ForeColor = System.Drawing.Color.White
        Me.bt_chercher.Location = New System.Drawing.Point(196, 316)
        Me.bt_chercher.Name = "bt_chercher"
        Me.bt_chercher.Size = New System.Drawing.Size(160, 27)
        Me.bt_chercher.TabIndex = 105
        Me.bt_chercher.Text = "Chercher"
        Me.bt_chercher.UseVisualStyleBackColor = False
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(636, 320)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 108
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'Membre_Communicatuin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(745, 401)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.bt_annuler)
        Me.Controls.Add(Me.bt_retour)
        Me.Controls.Add(Me.bt_chercher)
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
        Me.Name = "Membre_Communicatuin"
        Me.Text = "Membre_Communicatuin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents bt_annuler As System.Windows.Forms.Button
    Friend WithEvents bt_retour As System.Windows.Forms.Button
    Friend WithEvents bt_chercher As System.Windows.Forms.Button
    Friend WithEvents bt_Quitter As Button
End Class
