<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rebrique_Ressources_humaines
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rebrique_Ressources_humaines))
        Me.Retour = New System.Windows.Forms.Button()
        Me.bt_responsable = New System.Windows.Forms.Button()
        Me.bt_membre = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Retour
        '
        Me.Retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Retour.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Retour.ForeColor = System.Drawing.Color.White
        Me.Retour.Location = New System.Drawing.Point(482, 345)
        Me.Retour.Name = "Retour"
        Me.Retour.Size = New System.Drawing.Size(88, 26)
        Me.Retour.TabIndex = 35
        Me.Retour.Text = "Retour"
        Me.Retour.UseVisualStyleBackColor = False
        '
        'bt_responsable
        '
        Me.bt_responsable.BackColor = System.Drawing.Color.Green
        Me.bt_responsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_responsable.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.bt_responsable.ForeColor = System.Drawing.Color.White
        Me.bt_responsable.Location = New System.Drawing.Point(249, 162)
        Me.bt_responsable.Name = "bt_responsable"
        Me.bt_responsable.Size = New System.Drawing.Size(321, 55)
        Me.bt_responsable.TabIndex = 34
        Me.bt_responsable.Text = "Responsable"
        Me.bt_responsable.UseVisualStyleBackColor = False
        '
        'bt_membre
        '
        Me.bt_membre.BackColor = System.Drawing.Color.Green
        Me.bt_membre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_membre.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.bt_membre.ForeColor = System.Drawing.Color.White
        Me.bt_membre.Location = New System.Drawing.Point(249, 248)
        Me.bt_membre.Name = "bt_membre"
        Me.bt_membre.Size = New System.Drawing.Size(321, 53)
        Me.bt_membre.TabIndex = 33
        Me.bt_membre.Text = "Membre Adjoint"
        Me.bt_membre.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(265, 22)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(266, 21)
        Me.ComboBox1.TabIndex = 73
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(249, 348)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 74
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'Rebrique_Ressources_humaines
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(842, 503)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Retour)
        Me.Controls.Add(Me.bt_responsable)
        Me.Controls.Add(Me.bt_membre)
        Me.Name = "Rebrique_Ressources_humaines"
        Me.Text = "Rebrique Ressources humaines"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Retour As System.Windows.Forms.Button
    Friend WithEvents bt_responsable As System.Windows.Forms.Button
    Friend WithEvents bt_membre As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents bt_Quitter As Button
End Class
