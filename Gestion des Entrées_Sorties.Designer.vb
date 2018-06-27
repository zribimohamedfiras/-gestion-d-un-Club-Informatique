<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion_des_Entrées_Sorties
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gestion_des_Entrées_Sorties))
        Me.lb_libele = New System.Windows.Forms.Label()
        Me.lb_Type = New System.Windows.Forms.Label()
        Me.lb_quantité = New System.Windows.Forms.Label()
        Me.lb_Date = New System.Windows.Forms.Label()
        Me.lb_Montant = New System.Windows.Forms.Label()
        Me.tb_Libelle = New System.Windows.Forms.TextBox()
        Me.tb_type = New System.Windows.Forms.TextBox()
        Me.tb_quantité = New System.Windows.Forms.TextBox()
        Me.tb_date = New System.Windows.Forms.TextBox()
        Me.tb_mantant = New System.Windows.Forms.TextBox()
        Me.tb_Annuler = New System.Windows.Forms.Button()
        Me.RE = New System.Windows.Forms.Button()
        Me.bt_Ajouter = New System.Windows.Forms.Button()
        Me.bt_enregistrer = New System.Windows.Forms.Button()
        Me.bt_chercher = New System.Windows.Forms.Button()
        Me.bt_modifier = New System.Windows.Forms.Button()
        Me.lb_Nom = New System.Windows.Forms.Label()
        Me.tb_nom = New System.Windows.Forms.TextBox()
        Me.lb_ID_Entrées_Sorties = New System.Windows.Forms.Label()
        Me.tb_ID_Entrées_Sorties = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID_Entrées_Sortie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bt_supprimer = New System.Windows.Forms.Button()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_libele
        '
        Me.lb_libele.AutoSize = True
        Me.lb_libele.BackColor = System.Drawing.Color.Yellow
        Me.lb_libele.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lb_libele.ForeColor = System.Drawing.Color.Black
        Me.lb_libele.Location = New System.Drawing.Point(24, 206)
        Me.lb_libele.Name = "lb_libele"
        Me.lb_libele.Size = New System.Drawing.Size(37, 13)
        Me.lb_libele.TabIndex = 0
        Me.lb_libele.Text = "Libellé"
        '
        'lb_Type
        '
        Me.lb_Type.AutoSize = True
        Me.lb_Type.BackColor = System.Drawing.Color.Yellow
        Me.lb_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lb_Type.ForeColor = System.Drawing.Color.Black
        Me.lb_Type.Location = New System.Drawing.Point(24, 162)
        Me.lb_Type.Name = "lb_Type"
        Me.lb_Type.Size = New System.Drawing.Size(31, 13)
        Me.lb_Type.TabIndex = 1
        Me.lb_Type.Text = "Type"
        '
        'lb_quantité
        '
        Me.lb_quantité.AutoSize = True
        Me.lb_quantité.BackColor = System.Drawing.Color.Yellow
        Me.lb_quantité.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lb_quantité.ForeColor = System.Drawing.Color.Black
        Me.lb_quantité.Location = New System.Drawing.Point(23, 249)
        Me.lb_quantité.Name = "lb_quantité"
        Me.lb_quantité.Size = New System.Drawing.Size(47, 13)
        Me.lb_quantité.TabIndex = 2
        Me.lb_quantité.Text = "Quantité"
        '
        'lb_Date
        '
        Me.lb_Date.AutoSize = True
        Me.lb_Date.BackColor = System.Drawing.Color.Yellow
        Me.lb_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lb_Date.ForeColor = System.Drawing.Color.Black
        Me.lb_Date.Location = New System.Drawing.Point(24, 85)
        Me.lb_Date.Name = "lb_Date"
        Me.lb_Date.Size = New System.Drawing.Size(30, 13)
        Me.lb_Date.TabIndex = 3
        Me.lb_Date.Text = "Date"
        '
        'lb_Montant
        '
        Me.lb_Montant.AutoSize = True
        Me.lb_Montant.BackColor = System.Drawing.Color.Yellow
        Me.lb_Montant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lb_Montant.ForeColor = System.Drawing.Color.Black
        Me.lb_Montant.Location = New System.Drawing.Point(23, 295)
        Me.lb_Montant.Name = "lb_Montant"
        Me.lb_Montant.Size = New System.Drawing.Size(46, 13)
        Me.lb_Montant.TabIndex = 4
        Me.lb_Montant.Text = "Montant"
        '
        'tb_Libelle
        '
        Me.tb_Libelle.Location = New System.Drawing.Point(175, 203)
        Me.tb_Libelle.Name = "tb_Libelle"
        Me.tb_Libelle.Size = New System.Drawing.Size(100, 20)
        Me.tb_Libelle.TabIndex = 5
        '
        'tb_type
        '
        Me.tb_type.Location = New System.Drawing.Point(175, 162)
        Me.tb_type.Name = "tb_type"
        Me.tb_type.Size = New System.Drawing.Size(100, 20)
        Me.tb_type.TabIndex = 7
        '
        'tb_quantité
        '
        Me.tb_quantité.Location = New System.Drawing.Point(175, 246)
        Me.tb_quantité.Name = "tb_quantité"
        Me.tb_quantité.Size = New System.Drawing.Size(100, 20)
        Me.tb_quantité.TabIndex = 8
        '
        'tb_date
        '
        Me.tb_date.Location = New System.Drawing.Point(175, 82)
        Me.tb_date.Name = "tb_date"
        Me.tb_date.Size = New System.Drawing.Size(100, 20)
        Me.tb_date.TabIndex = 9
        '
        'tb_mantant
        '
        Me.tb_mantant.Location = New System.Drawing.Point(175, 292)
        Me.tb_mantant.Name = "tb_mantant"
        Me.tb_mantant.Size = New System.Drawing.Size(100, 20)
        Me.tb_mantant.TabIndex = 10
        '
        'tb_Annuler
        '
        Me.tb_Annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tb_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tb_Annuler.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Annuler.ForeColor = System.Drawing.Color.White
        Me.tb_Annuler.Location = New System.Drawing.Point(273, 343)
        Me.tb_Annuler.Name = "tb_Annuler"
        Me.tb_Annuler.Size = New System.Drawing.Size(88, 30)
        Me.tb_Annuler.TabIndex = 29
        Me.tb_Annuler.Text = "Annuler"
        Me.tb_Annuler.UseVisualStyleBackColor = False
        '
        'RE
        '
        Me.RE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RE.ForeColor = System.Drawing.Color.White
        Me.RE.Location = New System.Drawing.Point(28, 343)
        Me.RE.Name = "RE"
        Me.RE.Size = New System.Drawing.Size(88, 30)
        Me.RE.TabIndex = 28
        Me.RE.Text = "Retour"
        Me.RE.UseVisualStyleBackColor = False
        '
        'bt_Ajouter
        '
        Me.bt_Ajouter.BackColor = System.Drawing.Color.Green
        Me.bt_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Ajouter.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Ajouter.ForeColor = System.Drawing.Color.White
        Me.bt_Ajouter.Location = New System.Drawing.Point(306, 100)
        Me.bt_Ajouter.Name = "bt_Ajouter"
        Me.bt_Ajouter.Size = New System.Drawing.Size(133, 36)
        Me.bt_Ajouter.TabIndex = 30
        Me.bt_Ajouter.Text = "Ajouter"
        Me.bt_Ajouter.UseVisualStyleBackColor = False
        '
        'bt_enregistrer
        '
        Me.bt_enregistrer.BackColor = System.Drawing.Color.Green
        Me.bt_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_enregistrer.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_enregistrer.ForeColor = System.Drawing.Color.White
        Me.bt_enregistrer.Location = New System.Drawing.Point(306, 265)
        Me.bt_enregistrer.Name = "bt_enregistrer"
        Me.bt_enregistrer.Size = New System.Drawing.Size(133, 36)
        Me.bt_enregistrer.TabIndex = 59
        Me.bt_enregistrer.Text = "Enregistrer"
        Me.bt_enregistrer.UseVisualStyleBackColor = False
        '
        'bt_chercher
        '
        Me.bt_chercher.BackColor = System.Drawing.Color.Green
        Me.bt_chercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_chercher.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_chercher.ForeColor = System.Drawing.Color.White
        Me.bt_chercher.Location = New System.Drawing.Point(306, 43)
        Me.bt_chercher.Name = "bt_chercher"
        Me.bt_chercher.Size = New System.Drawing.Size(133, 36)
        Me.bt_chercher.TabIndex = 58
        Me.bt_chercher.Text = "Chercher"
        Me.bt_chercher.UseVisualStyleBackColor = False
        '
        'bt_modifier
        '
        Me.bt_modifier.BackColor = System.Drawing.Color.Green
        Me.bt_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_modifier.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_modifier.ForeColor = System.Drawing.Color.White
        Me.bt_modifier.Location = New System.Drawing.Point(306, 157)
        Me.bt_modifier.Name = "bt_modifier"
        Me.bt_modifier.Size = New System.Drawing.Size(133, 36)
        Me.bt_modifier.TabIndex = 57
        Me.bt_modifier.Text = "Modifier"
        Me.bt_modifier.UseVisualStyleBackColor = False
        '
        'lb_Nom
        '
        Me.lb_Nom.AutoSize = True
        Me.lb_Nom.BackColor = System.Drawing.Color.Yellow
        Me.lb_Nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lb_Nom.ForeColor = System.Drawing.Color.Black
        Me.lb_Nom.Location = New System.Drawing.Point(25, 126)
        Me.lb_Nom.Name = "lb_Nom"
        Me.lb_Nom.Size = New System.Drawing.Size(29, 13)
        Me.lb_Nom.TabIndex = 60
        Me.lb_Nom.Text = "Nom"
        '
        'tb_nom
        '
        Me.tb_nom.Location = New System.Drawing.Point(175, 123)
        Me.tb_nom.Name = "tb_nom"
        Me.tb_nom.Size = New System.Drawing.Size(100, 20)
        Me.tb_nom.TabIndex = 61
        '
        'lb_ID_Entrées_Sorties
        '
        Me.lb_ID_Entrées_Sorties.AutoSize = True
        Me.lb_ID_Entrées_Sorties.BackColor = System.Drawing.Color.Yellow
        Me.lb_ID_Entrées_Sorties.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lb_ID_Entrées_Sorties.ForeColor = System.Drawing.Color.Black
        Me.lb_ID_Entrées_Sorties.Location = New System.Drawing.Point(23, 43)
        Me.lb_ID_Entrées_Sorties.Name = "lb_ID_Entrées_Sorties"
        Me.lb_ID_Entrées_Sorties.Size = New System.Drawing.Size(94, 13)
        Me.lb_ID_Entrées_Sorties.TabIndex = 62
        Me.lb_ID_Entrées_Sorties.Text = "ID Entrées/Sorties"
        '
        'tb_ID_Entrées_Sorties
        '
        Me.tb_ID_Entrées_Sorties.Location = New System.Drawing.Point(175, 40)
        Me.tb_ID_Entrées_Sorties.Name = "tb_ID_Entrées_Sorties"
        Me.tb_ID_Entrées_Sorties.Size = New System.Drawing.Size(100, 20)
        Me.tb_ID_Entrées_Sorties.TabIndex = 63
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightYellow
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Entrées_Sortie, Me.Nom, Me.Type})
        Me.DataGridView1.Location = New System.Drawing.Point(488, 43)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(342, 320)
        Me.DataGridView1.TabIndex = 64
        '
        'ID_Entrées_Sortie
        '
        Me.ID_Entrées_Sortie.HeaderText = "ID_Entrées_Sortie"
        Me.ID_Entrées_Sortie.Name = "ID_Entrées_Sortie"
        Me.ID_Entrées_Sortie.ReadOnly = True
        '
        'Nom
        '
        Me.Nom.HeaderText = "Nom"
        Me.Nom.Name = "Nom"
        Me.Nom.ReadOnly = True
        '
        'Type
        '
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        '
        'bt_supprimer
        '
        Me.bt_supprimer.BackColor = System.Drawing.Color.Green
        Me.bt_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_supprimer.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_supprimer.ForeColor = System.Drawing.Color.White
        Me.bt_supprimer.Location = New System.Drawing.Point(306, 212)
        Me.bt_supprimer.Name = "bt_supprimer"
        Me.bt_supprimer.Size = New System.Drawing.Size(133, 36)
        Me.bt_supprimer.TabIndex = 65
        Me.bt_supprimer.Text = "Supprimer"
        Me.bt_supprimer.UseVisualStyleBackColor = False
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(755, 369)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 66
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'Gestion_des_Entrées_Sorties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(842, 503)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.bt_supprimer)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tb_ID_Entrées_Sorties)
        Me.Controls.Add(Me.lb_ID_Entrées_Sorties)
        Me.Controls.Add(Me.tb_nom)
        Me.Controls.Add(Me.lb_Nom)
        Me.Controls.Add(Me.bt_enregistrer)
        Me.Controls.Add(Me.bt_chercher)
        Me.Controls.Add(Me.bt_modifier)
        Me.Controls.Add(Me.bt_Ajouter)
        Me.Controls.Add(Me.tb_Annuler)
        Me.Controls.Add(Me.RE)
        Me.Controls.Add(Me.tb_mantant)
        Me.Controls.Add(Me.tb_date)
        Me.Controls.Add(Me.tb_quantité)
        Me.Controls.Add(Me.tb_type)
        Me.Controls.Add(Me.tb_Libelle)
        Me.Controls.Add(Me.lb_Montant)
        Me.Controls.Add(Me.lb_Date)
        Me.Controls.Add(Me.lb_quantité)
        Me.Controls.Add(Me.lb_Type)
        Me.Controls.Add(Me.lb_libele)
        Me.Name = "Gestion_des_Entrées_Sorties"
        Me.Text = "Gestion_des_Entrées_Sorties"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_libele As System.Windows.Forms.Label
    Friend WithEvents lb_Type As System.Windows.Forms.Label
    Friend WithEvents lb_quantité As System.Windows.Forms.Label
    Friend WithEvents lb_Date As System.Windows.Forms.Label
    Friend WithEvents lb_Montant As System.Windows.Forms.Label
    Friend WithEvents tb_Libelle As System.Windows.Forms.TextBox
    Friend WithEvents tb_type As System.Windows.Forms.TextBox
    Friend WithEvents tb_quantité As System.Windows.Forms.TextBox
    Friend WithEvents tb_date As System.Windows.Forms.TextBox
    Friend WithEvents tb_mantant As System.Windows.Forms.TextBox
    Friend WithEvents tb_Annuler As System.Windows.Forms.Button
    Friend WithEvents RE As System.Windows.Forms.Button
    Friend WithEvents bt_Ajouter As System.Windows.Forms.Button
    Friend WithEvents bt_enregistrer As System.Windows.Forms.Button
    Friend WithEvents bt_chercher As System.Windows.Forms.Button
    Friend WithEvents bt_modifier As System.Windows.Forms.Button
    Friend WithEvents lb_Nom As Label
    Friend WithEvents tb_nom As TextBox
    Friend WithEvents lb_ID_Entrées_Sorties As Label
    Friend WithEvents tb_ID_Entrées_Sorties As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ID_Entrées_Sortie As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents bt_supprimer As Button
    Friend WithEvents bt_Quitter As Button
End Class
