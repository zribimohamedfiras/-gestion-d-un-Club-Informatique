<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Plan_générale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Plan_générale))
        Me.bt_communication = New System.Windows.Forms.Button()
        Me.bt_Sponsoring = New System.Windows.Forms.Button()
        Me.bt_evenementiel = New System.Windows.Forms.Button()
        Me.bt_retour = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bt_communication
        '
        Me.bt_communication.BackColor = System.Drawing.Color.Green
        Me.bt_communication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_communication.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_communication.ForeColor = System.Drawing.Color.White
        Me.bt_communication.Location = New System.Drawing.Point(212, 94)
        Me.bt_communication.Name = "bt_communication"
        Me.bt_communication.Size = New System.Drawing.Size(372, 57)
        Me.bt_communication.TabIndex = 28
        Me.bt_communication.Text = "Communication"
        Me.bt_communication.UseVisualStyleBackColor = False
        '
        'bt_Sponsoring
        '
        Me.bt_Sponsoring.BackColor = System.Drawing.Color.Green
        Me.bt_Sponsoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Sponsoring.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.bt_Sponsoring.ForeColor = System.Drawing.Color.White
        Me.bt_Sponsoring.Location = New System.Drawing.Point(212, 207)
        Me.bt_Sponsoring.Name = "bt_Sponsoring"
        Me.bt_Sponsoring.Size = New System.Drawing.Size(372, 57)
        Me.bt_Sponsoring.TabIndex = 29
        Me.bt_Sponsoring.Text = "Sponsoring"
        Me.bt_Sponsoring.UseVisualStyleBackColor = False
        '
        'bt_evenementiel
        '
        Me.bt_evenementiel.BackColor = System.Drawing.Color.Green
        Me.bt_evenementiel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_evenementiel.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.bt_evenementiel.ForeColor = System.Drawing.Color.White
        Me.bt_evenementiel.Location = New System.Drawing.Point(212, 319)
        Me.bt_evenementiel.Name = "bt_evenementiel"
        Me.bt_evenementiel.Size = New System.Drawing.Size(372, 57)
        Me.bt_evenementiel.TabIndex = 30
        Me.bt_evenementiel.Text = "Evénementiel"
        Me.bt_evenementiel.UseVisualStyleBackColor = False
        '
        'bt_retour
        '
        Me.bt_retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_retour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_retour.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_retour.ForeColor = System.Drawing.Color.White
        Me.bt_retour.Location = New System.Drawing.Point(496, 394)
        Me.bt_retour.Name = "bt_retour"
        Me.bt_retour.Size = New System.Drawing.Size(88, 26)
        Me.bt_retour.TabIndex = 32
        Me.bt_retour.Text = "Retour"
        Me.bt_retour.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(306, 49)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(191, 21)
        Me.ComboBox1.TabIndex = 33
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(212, 397)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 34
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'Plan_générale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(842, 503)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.bt_retour)
        Me.Controls.Add(Me.bt_evenementiel)
        Me.Controls.Add(Me.bt_Sponsoring)
        Me.Controls.Add(Me.bt_communication)
        Me.Name = "Plan_générale"
        Me.Text = "Plan_générale"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bt_communication As System.Windows.Forms.Button
    Friend WithEvents bt_Sponsoring As System.Windows.Forms.Button
    Friend WithEvents bt_evenementiel As System.Windows.Forms.Button
    Friend WithEvents bt_retour As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents bt_Quitter As Button
End Class
