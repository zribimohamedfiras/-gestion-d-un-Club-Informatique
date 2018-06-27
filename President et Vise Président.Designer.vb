<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class President_et_Vise_Président
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(President_et_Vise_Président))
        Me.bt_invite = New System.Windows.Forms.Button()
        Me.bt_évenements = New System.Windows.Forms.Button()
        Me.RE = New System.Windows.Forms.Button()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bt_invite
        '
        Me.bt_invite.BackColor = System.Drawing.Color.Green
        Me.bt_invite.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.bt_invite.ForeColor = System.Drawing.Color.White
        Me.bt_invite.Location = New System.Drawing.Point(249, 191)
        Me.bt_invite.Name = "bt_invite"
        Me.bt_invite.Size = New System.Drawing.Size(321, 59)
        Me.bt_invite.TabIndex = 27
        Me.bt_invite.Text = "Gestion des invites"
        Me.bt_invite.UseVisualStyleBackColor = False
        '
        'bt_évenements
        '
        Me.bt_évenements.BackColor = System.Drawing.Color.Green
        Me.bt_évenements.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_évenements.ForeColor = System.Drawing.Color.White
        Me.bt_évenements.Location = New System.Drawing.Point(249, 97)
        Me.bt_évenements.Name = "bt_évenements"
        Me.bt_évenements.Size = New System.Drawing.Size(321, 59)
        Me.bt_évenements.TabIndex = 28
        Me.bt_évenements.Text = "Gestion des évenements"
        Me.bt_évenements.UseVisualStyleBackColor = False
        '
        'RE
        '
        Me.RE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RE.ForeColor = System.Drawing.Color.White
        Me.RE.Location = New System.Drawing.Point(482, 302)
        Me.RE.Name = "RE"
        Me.RE.Size = New System.Drawing.Size(88, 26)
        Me.RE.TabIndex = 29
        Me.RE.Text = "Retour"
        Me.RE.UseVisualStyleBackColor = False
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(249, 302)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 30
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'President_et_Vise_Président
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(842, 503)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.RE)
        Me.Controls.Add(Me.bt_évenements)
        Me.Controls.Add(Me.bt_invite)
        Me.Name = "President_et_Vise_Président"
        Me.Text = "President_et_Vise_Président"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bt_invite As System.Windows.Forms.Button
    Friend WithEvents bt_évenements As System.Windows.Forms.Button
    Friend WithEvents RE As System.Windows.Forms.Button
    Friend WithEvents bt_Quitter As Button
End Class
