<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Membre_Sponsoring
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Membre_Sponsoring))
        Me.bt_Gestion_Sponsors = New System.Windows.Forms.Button()
        Me.bt_Consulter_tache = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.bt_retour = New System.Windows.Forms.Button()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bt_Gestion_Sponsors
        '
        Me.bt_Gestion_Sponsors.BackColor = System.Drawing.Color.Green
        Me.bt_Gestion_Sponsors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_Gestion_Sponsors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Gestion_Sponsors.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Gestion_Sponsors.ForeColor = System.Drawing.Color.White
        Me.bt_Gestion_Sponsors.Location = New System.Drawing.Point(228, 202)
        Me.bt_Gestion_Sponsors.Name = "bt_Gestion_Sponsors"
        Me.bt_Gestion_Sponsors.Size = New System.Drawing.Size(315, 75)
        Me.bt_Gestion_Sponsors.TabIndex = 41
        Me.bt_Gestion_Sponsors.Text = "Gestion des Sponsors"
        Me.bt_Gestion_Sponsors.UseVisualStyleBackColor = False
        '
        'bt_Consulter_tache
        '
        Me.bt_Consulter_tache.BackColor = System.Drawing.Color.Green
        Me.bt_Consulter_tache.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_Consulter_tache.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Consulter_tache.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Consulter_tache.ForeColor = System.Drawing.Color.White
        Me.bt_Consulter_tache.Location = New System.Drawing.Point(228, 103)
        Me.bt_Consulter_tache.Name = "bt_Consulter_tache"
        Me.bt_Consulter_tache.Size = New System.Drawing.Size(315, 75)
        Me.bt_Consulter_tache.TabIndex = 40
        Me.bt_Consulter_tache.Text = "Consulter Tache"
        Me.bt_Consulter_tache.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(259, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(266, 21)
        Me.ComboBox1.TabIndex = 73
        '
        'bt_retour
        '
        Me.bt_retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_retour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_retour.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_retour.ForeColor = System.Drawing.Color.White
        Me.bt_retour.Location = New System.Drawing.Point(511, 302)
        Me.bt_retour.Name = "bt_retour"
        Me.bt_retour.Size = New System.Drawing.Size(88, 26)
        Me.bt_retour.TabIndex = 74
        Me.bt_retour.Text = "Retour"
        Me.bt_retour.UseVisualStyleBackColor = False
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(156, 305)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 75
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'Membre_Sponsoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(777, 391)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.bt_retour)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.bt_Gestion_Sponsors)
        Me.Controls.Add(Me.bt_Consulter_tache)
        Me.Name = "Membre_Sponsoring"
        Me.Text = "Membre_Sponsoring"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bt_Gestion_Sponsors As System.Windows.Forms.Button
    Friend WithEvents bt_Consulter_tache As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents bt_retour As System.Windows.Forms.Button
    Friend WithEvents bt_Quitter As Button
End Class
