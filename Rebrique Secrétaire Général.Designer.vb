<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rebrique_Secrétaire_Général
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rebrique_Secrétaire_Général))
        Me.bt_retour = New System.Windows.Forms.Button()
        Me.bt_presence_invite = New System.Windows.Forms.Button()
        Me.bt_Presence_Inscrit = New System.Windows.Forms.Button()
        Me.tb_Saisie_Materiel = New System.Windows.Forms.Button()
        Me.bt_Saisie_Inscrit = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.bt_Affectation_Matériels = New System.Windows.Forms.Button()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bt_retour
        '
        Me.bt_retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_retour.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_retour.ForeColor = System.Drawing.Color.White
        Me.bt_retour.Location = New System.Drawing.Point(556, 380)
        Me.bt_retour.Name = "bt_retour"
        Me.bt_retour.Size = New System.Drawing.Size(88, 26)
        Me.bt_retour.TabIndex = 71
        Me.bt_retour.Text = "Retour"
        Me.bt_retour.UseVisualStyleBackColor = False
        '
        'bt_presence_invite
        '
        Me.bt_presence_invite.BackColor = System.Drawing.Color.Green
        Me.bt_presence_invite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_presence_invite.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_presence_invite.ForeColor = System.Drawing.Color.White
        Me.bt_presence_invite.Location = New System.Drawing.Point(237, 325)
        Me.bt_presence_invite.Name = "bt_presence_invite"
        Me.bt_presence_invite.Size = New System.Drawing.Size(321, 31)
        Me.bt_presence_invite.TabIndex = 70
        Me.bt_presence_invite.Text = "Presénce des Invitées"
        Me.bt_presence_invite.UseVisualStyleBackColor = False
        '
        'bt_Presence_Inscrit
        '
        Me.bt_Presence_Inscrit.BackColor = System.Drawing.Color.Green
        Me.bt_Presence_Inscrit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Presence_Inscrit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_Presence_Inscrit.ForeColor = System.Drawing.Color.White
        Me.bt_Presence_Inscrit.Location = New System.Drawing.Point(237, 270)
        Me.bt_Presence_Inscrit.Name = "bt_Presence_Inscrit"
        Me.bt_Presence_Inscrit.Size = New System.Drawing.Size(321, 31)
        Me.bt_Presence_Inscrit.TabIndex = 69
        Me.bt_Presence_Inscrit.Text = "Présence des  Inscrits"
        Me.bt_Presence_Inscrit.UseVisualStyleBackColor = False
        '
        'tb_Saisie_Materiel
        '
        Me.tb_Saisie_Materiel.BackColor = System.Drawing.Color.Green
        Me.tb_Saisie_Materiel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tb_Saisie_Materiel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_Saisie_Materiel.ForeColor = System.Drawing.Color.White
        Me.tb_Saisie_Materiel.Location = New System.Drawing.Point(237, 170)
        Me.tb_Saisie_Materiel.Name = "tb_Saisie_Materiel"
        Me.tb_Saisie_Materiel.Size = New System.Drawing.Size(321, 31)
        Me.tb_Saisie_Materiel.TabIndex = 67
        Me.tb_Saisie_Materiel.Text = "Saisie des Matériels"
        Me.tb_Saisie_Materiel.UseVisualStyleBackColor = False
        '
        'bt_Saisie_Inscrit
        '
        Me.bt_Saisie_Inscrit.BackColor = System.Drawing.Color.Green
        Me.bt_Saisie_Inscrit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Saisie_Inscrit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Saisie_Inscrit.ForeColor = System.Drawing.Color.White
        Me.bt_Saisie_Inscrit.Location = New System.Drawing.Point(237, 116)
        Me.bt_Saisie_Inscrit.Name = "bt_Saisie_Inscrit"
        Me.bt_Saisie_Inscrit.Size = New System.Drawing.Size(321, 31)
        Me.bt_Saisie_Inscrit.TabIndex = 66
        Me.bt_Saisie_Inscrit.Text = "Saisie des Inscrits"
        Me.bt_Saisie_Inscrit.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(261, 75)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(266, 21)
        Me.ComboBox1.TabIndex = 72
        '
        'bt_Affectation_Matériels
        '
        Me.bt_Affectation_Matériels.BackColor = System.Drawing.Color.Green
        Me.bt_Affectation_Matériels.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Affectation_Matériels.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_Affectation_Matériels.ForeColor = System.Drawing.Color.White
        Me.bt_Affectation_Matériels.Location = New System.Drawing.Point(237, 219)
        Me.bt_Affectation_Matériels.Name = "bt_Affectation_Matériels"
        Me.bt_Affectation_Matériels.Size = New System.Drawing.Size(321, 31)
        Me.bt_Affectation_Matériels.TabIndex = 73
        Me.bt_Affectation_Matériels.Text = "Affectation des Matériels"
        Me.bt_Affectation_Matériels.UseVisualStyleBackColor = False
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(162, 380)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 74
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'Rebrique_Secrétaire_Général
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(842, 503)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.bt_Affectation_Matériels)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.bt_retour)
        Me.Controls.Add(Me.bt_presence_invite)
        Me.Controls.Add(Me.bt_Presence_Inscrit)
        Me.Controls.Add(Me.tb_Saisie_Materiel)
        Me.Controls.Add(Me.bt_Saisie_Inscrit)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Name = "Rebrique_Secrétaire_Général"
        Me.Text = "Rebrique_Secrétaire_Général"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bt_retour As System.Windows.Forms.Button
    Friend WithEvents bt_presence_invite As System.Windows.Forms.Button
    Friend WithEvents bt_Presence_Inscrit As System.Windows.Forms.Button
    Friend WithEvents tb_Saisie_Materiel As System.Windows.Forms.Button
    Friend WithEvents bt_Saisie_Inscrit As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents bt_Affectation_Matériels As Button
    Friend WithEvents bt_Quitter As Button
End Class
