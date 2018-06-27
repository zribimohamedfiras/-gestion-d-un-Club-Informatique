<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Responsable_Sponsoring
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Responsable_Sponsoring))
        Me.bt_Gestion_Membres = New System.Windows.Forms.Button()
        Me.bt_Gestion_Sponsors = New System.Windows.Forms.Button()
        Me.RE = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bt_Gestion_Membres
        '
        Me.bt_Gestion_Membres.BackColor = System.Drawing.Color.Green
        Me.bt_Gestion_Membres.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Gestion_Membres.ForeColor = System.Drawing.Color.White
        Me.bt_Gestion_Membres.Location = New System.Drawing.Point(169, 95)
        Me.bt_Gestion_Membres.Name = "bt_Gestion_Membres"
        Me.bt_Gestion_Membres.Size = New System.Drawing.Size(321, 55)
        Me.bt_Gestion_Membres.TabIndex = 40
        Me.bt_Gestion_Membres.Text = "Gestion Membres"
        Me.bt_Gestion_Membres.UseVisualStyleBackColor = False
        '
        'bt_Gestion_Sponsors
        '
        Me.bt_Gestion_Sponsors.BackColor = System.Drawing.Color.Green
        Me.bt_Gestion_Sponsors.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.bt_Gestion_Sponsors.ForeColor = System.Drawing.Color.White
        Me.bt_Gestion_Sponsors.Location = New System.Drawing.Point(169, 185)
        Me.bt_Gestion_Sponsors.Name = "bt_Gestion_Sponsors"
        Me.bt_Gestion_Sponsors.Size = New System.Drawing.Size(321, 55)
        Me.bt_Gestion_Sponsors.TabIndex = 41
        Me.bt_Gestion_Sponsors.Text = "Gestion Sponsors"
        Me.bt_Gestion_Sponsors.UseVisualStyleBackColor = False
        '
        'RE
        '
        Me.RE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RE.ForeColor = System.Drawing.Color.White
        Me.RE.Location = New System.Drawing.Point(402, 272)
        Me.RE.Name = "RE"
        Me.RE.Size = New System.Drawing.Size(88, 30)
        Me.RE.TabIndex = 42
        Me.RE.Text = "Retour"
        Me.RE.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(201, 12)
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
        Me.bt_Quitter.Location = New System.Drawing.Point(169, 279)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 74
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'Responsable_Sponsoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(733, 401)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RE)
        Me.Controls.Add(Me.bt_Gestion_Sponsors)
        Me.Controls.Add(Me.bt_Gestion_Membres)
        Me.Name = "Responsable_Sponsoring"
        Me.Text = "Responsable_Sponsoring"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bt_Gestion_Membres As System.Windows.Forms.Button
    Friend WithEvents bt_Gestion_Sponsors As System.Windows.Forms.Button
    Friend WithEvents RE As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents bt_Quitter As Button
End Class
