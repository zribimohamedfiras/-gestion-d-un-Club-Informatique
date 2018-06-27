<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajout_inscrit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ajout_inscrit))
        Me.tb_mail = New System.Windows.Forms.TextBox()
        Me.tb_prenom = New System.Windows.Forms.TextBox()
        Me.tb_nom = New System.Windows.Forms.TextBox()
        Me.tb_ncin = New System.Windows.Forms.TextBox()
        Me.lb_mail = New System.Windows.Forms.Label()
        Me.lb_Prenom = New System.Windows.Forms.Label()
        Me.lb_nom = New System.Windows.Forms.Label()
        Me.lb_ncin = New System.Windows.Forms.Label()
        Me.bt_retour = New System.Windows.Forms.Button()
        Me.bt_enregistrer = New System.Windows.Forms.Button()
        Me.bt_chercher = New System.Windows.Forms.Button()
        Me.bt_modifier = New System.Windows.Forms.Button()
        Me.bt_supprimer = New System.Windows.Forms.Button()
        Me.bt_ajouter = New System.Windows.Forms.Button()
        Me.bt_annuler = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NCIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRENOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_mail
        '
        Me.tb_mail.Location = New System.Drawing.Point(157, 232)
        Me.tb_mail.Name = "tb_mail"
        Me.tb_mail.Size = New System.Drawing.Size(156, 20)
        Me.tb_mail.TabIndex = 51
        '
        'tb_prenom
        '
        Me.tb_prenom.Location = New System.Drawing.Point(157, 176)
        Me.tb_prenom.Name = "tb_prenom"
        Me.tb_prenom.Size = New System.Drawing.Size(156, 20)
        Me.tb_prenom.TabIndex = 50
        '
        'tb_nom
        '
        Me.tb_nom.Location = New System.Drawing.Point(157, 119)
        Me.tb_nom.Name = "tb_nom"
        Me.tb_nom.Size = New System.Drawing.Size(156, 20)
        Me.tb_nom.TabIndex = 49
        '
        'tb_ncin
        '
        Me.tb_ncin.BackColor = System.Drawing.Color.White
        Me.tb_ncin.Location = New System.Drawing.Point(157, 61)
        Me.tb_ncin.Name = "tb_ncin"
        Me.tb_ncin.Size = New System.Drawing.Size(156, 20)
        Me.tb_ncin.TabIndex = 48
        '
        'lb_mail
        '
        Me.lb_mail.AutoSize = True
        Me.lb_mail.BackColor = System.Drawing.Color.Yellow
        Me.lb_mail.Location = New System.Drawing.Point(48, 235)
        Me.lb_mail.Name = "lb_mail"
        Me.lb_mail.Size = New System.Drawing.Size(26, 13)
        Me.lb_mail.TabIndex = 47
        Me.lb_mail.Text = "Mail"
        '
        'lb_Prenom
        '
        Me.lb_Prenom.AutoSize = True
        Me.lb_Prenom.BackColor = System.Drawing.Color.Yellow
        Me.lb_Prenom.Location = New System.Drawing.Point(48, 179)
        Me.lb_Prenom.Name = "lb_Prenom"
        Me.lb_Prenom.Size = New System.Drawing.Size(43, 13)
        Me.lb_Prenom.TabIndex = 46
        Me.lb_Prenom.Text = "Prenom"
        '
        'lb_nom
        '
        Me.lb_nom.AutoSize = True
        Me.lb_nom.BackColor = System.Drawing.Color.Yellow
        Me.lb_nom.Location = New System.Drawing.Point(48, 122)
        Me.lb_nom.Name = "lb_nom"
        Me.lb_nom.Size = New System.Drawing.Size(29, 13)
        Me.lb_nom.TabIndex = 45
        Me.lb_nom.Text = "Nom"
        '
        'lb_ncin
        '
        Me.lb_ncin.AutoSize = True
        Me.lb_ncin.BackColor = System.Drawing.Color.Yellow
        Me.lb_ncin.Location = New System.Drawing.Point(48, 64)
        Me.lb_ncin.Name = "lb_ncin"
        Me.lb_ncin.Size = New System.Drawing.Size(33, 13)
        Me.lb_ncin.TabIndex = 44
        Me.lb_ncin.Text = "NCIN"
        '
        'bt_retour
        '
        Me.bt_retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_retour.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_retour.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_retour.Location = New System.Drawing.Point(51, 327)
        Me.bt_retour.Name = "bt_retour"
        Me.bt_retour.Size = New System.Drawing.Size(88, 27)
        Me.bt_retour.TabIndex = 42
        Me.bt_retour.Text = "Retour"
        Me.bt_retour.UseVisualStyleBackColor = False
        '
        'bt_enregistrer
        '
        Me.bt_enregistrer.BackColor = System.Drawing.Color.Green
        Me.bt_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_enregistrer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_enregistrer.ForeColor = System.Drawing.Color.White
        Me.bt_enregistrer.Location = New System.Drawing.Point(347, 197)
        Me.bt_enregistrer.Name = "bt_enregistrer"
        Me.bt_enregistrer.Size = New System.Drawing.Size(104, 29)
        Me.bt_enregistrer.TabIndex = 41
        Me.bt_enregistrer.Text = "Enregistrer"
        Me.bt_enregistrer.UseVisualStyleBackColor = False
        '
        'bt_chercher
        '
        Me.bt_chercher.BackColor = System.Drawing.Color.Green
        Me.bt_chercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_chercher.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_chercher.ForeColor = System.Drawing.Color.White
        Me.bt_chercher.Location = New System.Drawing.Point(347, 251)
        Me.bt_chercher.Name = "bt_chercher"
        Me.bt_chercher.Size = New System.Drawing.Size(104, 29)
        Me.bt_chercher.TabIndex = 40
        Me.bt_chercher.Text = "Chercher"
        Me.bt_chercher.UseVisualStyleBackColor = False
        '
        'bt_modifier
        '
        Me.bt_modifier.BackColor = System.Drawing.Color.Green
        Me.bt_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_modifier.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_modifier.ForeColor = System.Drawing.Color.White
        Me.bt_modifier.Location = New System.Drawing.Point(347, 101)
        Me.bt_modifier.Name = "bt_modifier"
        Me.bt_modifier.Size = New System.Drawing.Size(104, 29)
        Me.bt_modifier.TabIndex = 39
        Me.bt_modifier.Text = "Modifier"
        Me.bt_modifier.UseVisualStyleBackColor = False
        '
        'bt_supprimer
        '
        Me.bt_supprimer.BackColor = System.Drawing.Color.Green
        Me.bt_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_supprimer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_supprimer.ForeColor = System.Drawing.Color.White
        Me.bt_supprimer.Location = New System.Drawing.Point(347, 149)
        Me.bt_supprimer.Name = "bt_supprimer"
        Me.bt_supprimer.Size = New System.Drawing.Size(104, 29)
        Me.bt_supprimer.TabIndex = 38
        Me.bt_supprimer.Text = "Supprimer"
        Me.bt_supprimer.UseVisualStyleBackColor = False
        '
        'bt_ajouter
        '
        Me.bt_ajouter.BackColor = System.Drawing.Color.Green
        Me.bt_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_ajouter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ajouter.ForeColor = System.Drawing.Color.White
        Me.bt_ajouter.Location = New System.Drawing.Point(347, 54)
        Me.bt_ajouter.Name = "bt_ajouter"
        Me.bt_ajouter.Size = New System.Drawing.Size(104, 29)
        Me.bt_ajouter.TabIndex = 37
        Me.bt_ajouter.Text = "Ajouter"
        Me.bt_ajouter.UseVisualStyleBackColor = False
        '
        'bt_annuler
        '
        Me.bt_annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_annuler.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_annuler.ForeColor = System.Drawing.Color.White
        Me.bt_annuler.Location = New System.Drawing.Point(257, 327)
        Me.bt_annuler.Name = "bt_annuler"
        Me.bt_annuler.Size = New System.Drawing.Size(88, 27)
        Me.bt_annuler.TabIndex = 52
        Me.bt_annuler.Text = "Annuler"
        Me.bt_annuler.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightYellow
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NCIN, Me.NOM, Me.PRENOM})
        Me.DataGridView1.Location = New System.Drawing.Point(471, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(344, 317)
        Me.DataGridView1.TabIndex = 55
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
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(740, 360)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 56
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'Ajout_inscrit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(842, 503)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.bt_annuler)
        Me.Controls.Add(Me.tb_mail)
        Me.Controls.Add(Me.tb_prenom)
        Me.Controls.Add(Me.tb_nom)
        Me.Controls.Add(Me.tb_ncin)
        Me.Controls.Add(Me.lb_mail)
        Me.Controls.Add(Me.lb_Prenom)
        Me.Controls.Add(Me.lb_nom)
        Me.Controls.Add(Me.lb_ncin)
        Me.Controls.Add(Me.bt_retour)
        Me.Controls.Add(Me.bt_enregistrer)
        Me.Controls.Add(Me.bt_chercher)
        Me.Controls.Add(Me.bt_modifier)
        Me.Controls.Add(Me.bt_supprimer)
        Me.Controls.Add(Me.bt_ajouter)
        Me.Name = "Ajout_inscrit"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_mail As System.Windows.Forms.TextBox
    Friend WithEvents tb_prenom As System.Windows.Forms.TextBox
    Friend WithEvents tb_nom As System.Windows.Forms.TextBox
    Friend WithEvents tb_ncin As System.Windows.Forms.TextBox
    Friend WithEvents lb_mail As System.Windows.Forms.Label
    Friend WithEvents lb_Prenom As System.Windows.Forms.Label
    Friend WithEvents lb_nom As System.Windows.Forms.Label
    Friend WithEvents lb_ncin As System.Windows.Forms.Label
    Friend WithEvents bt_retour As System.Windows.Forms.Button
    Friend WithEvents bt_enregistrer As System.Windows.Forms.Button
    Friend WithEvents bt_chercher As System.Windows.Forms.Button
    Friend WithEvents bt_modifier As System.Windows.Forms.Button
    Friend WithEvents bt_supprimer As System.Windows.Forms.Button
    Friend WithEvents bt_ajouter As System.Windows.Forms.Button
    Friend WithEvents bt_annuler As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NCIN As DataGridViewTextBoxColumn
    Friend WithEvents NOM As DataGridViewTextBoxColumn
    Friend WithEvents PRENOM As DataGridViewTextBoxColumn
    Friend WithEvents bt_Quitter As Button
End Class
