<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rebrique_Trésorier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rebrique_Trésorier))
        Me.bt_Consuler_journal = New System.Windows.Forms.Button()
        Me.bt_gestion_entré_sortie = New System.Windows.Forms.Button()
        Me.RE = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.bt_Controle_Besoin = New System.Windows.Forms.Button()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bt_Consuler_journal
        '
        Me.bt_Consuler_journal.BackColor = System.Drawing.Color.Green
        Me.bt_Consuler_journal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Consuler_journal.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Consuler_journal.ForeColor = System.Drawing.Color.White
        Me.bt_Consuler_journal.Location = New System.Drawing.Point(211, 95)
        Me.bt_Consuler_journal.Name = "bt_Consuler_journal"
        Me.bt_Consuler_journal.Size = New System.Drawing.Size(375, 60)
        Me.bt_Consuler_journal.TabIndex = 31
        Me.bt_Consuler_journal.Text = "Consuler journal"
        Me.bt_Consuler_journal.UseVisualStyleBackColor = False
        '
        'bt_gestion_entré_sortie
        '
        Me.bt_gestion_entré_sortie.BackColor = System.Drawing.Color.Green
        Me.bt_gestion_entré_sortie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_gestion_entré_sortie.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.bt_gestion_entré_sortie.ForeColor = System.Drawing.Color.White
        Me.bt_gestion_entré_sortie.Location = New System.Drawing.Point(211, 190)
        Me.bt_gestion_entré_sortie.Name = "bt_gestion_entré_sortie"
        Me.bt_gestion_entré_sortie.Size = New System.Drawing.Size(375, 60)
        Me.bt_gestion_entré_sortie.TabIndex = 32
        Me.bt_gestion_entré_sortie.Text = "Gestion des Entrés/Sorties"
        Me.bt_gestion_entré_sortie.UseVisualStyleBackColor = False
        '
        'RE
        '
        Me.RE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RE.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RE.ForeColor = System.Drawing.Color.White
        Me.RE.Location = New System.Drawing.Point(498, 367)
        Me.RE.Name = "RE"
        Me.RE.Size = New System.Drawing.Size(88, 29)
        Me.RE.TabIndex = 33
        Me.RE.Text = "Retour"
        Me.RE.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(296, 58)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(228, 21)
        Me.ComboBox1.TabIndex = 34
        '
        'bt_Controle_Besoin
        '
        Me.bt_Controle_Besoin.BackColor = System.Drawing.Color.Green
        Me.bt_Controle_Besoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Controle_Besoin.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.bt_Controle_Besoin.ForeColor = System.Drawing.Color.White
        Me.bt_Controle_Besoin.Location = New System.Drawing.Point(211, 280)
        Me.bt_Controle_Besoin.Name = "bt_Controle_Besoin"
        Me.bt_Controle_Besoin.Size = New System.Drawing.Size(375, 60)
        Me.bt_Controle_Besoin.TabIndex = 35
        Me.bt_Controle_Besoin.Text = "Controle de Besoin"
        Me.bt_Controle_Besoin.UseVisualStyleBackColor = False
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(211, 373)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 36
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'Rebrique_Trésorier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(842, 503)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.bt_Controle_Besoin)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RE)
        Me.Controls.Add(Me.bt_gestion_entré_sortie)
        Me.Controls.Add(Me.bt_Consuler_journal)
        Me.Name = "Rebrique_Trésorier"
        Me.Text = "Rebrique_Trésorier"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bt_Consuler_journal As System.Windows.Forms.Button
    Friend WithEvents bt_gestion_entré_sortie As System.Windows.Forms.Button
    Friend WithEvents RE As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents bt_Controle_Besoin As Button
    Friend WithEvents bt_Quitter As Button
End Class
