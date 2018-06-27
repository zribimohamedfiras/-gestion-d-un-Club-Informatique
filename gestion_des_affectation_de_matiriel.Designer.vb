<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestion_des_affectation_de_matiriel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gestion_des_affectation_de_matiriel))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID_Materiel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cb__Nom_Evenement = New System.Windows.Forms.ComboBox()
        Me.lb_Nom_Evenement = New System.Windows.Forms.Label()
        Me.bt_annuler = New System.Windows.Forms.Button()
        Me.tb_afficher_prix = New System.Windows.Forms.TextBox()
        Me.bt_Afficher_Prix_total_materiel = New System.Windows.Forms.Button()
        Me.tb_prix = New System.Windows.Forms.TextBox()
        Me.tb_id_matériel = New System.Windows.Forms.TextBox()
        Me.lb_prix = New System.Windows.Forms.Label()
        Me.lb_id_matériel = New System.Windows.Forms.Label()
        Me.bt_retour = New System.Windows.Forms.Button()
        Me.bt_enregistrer = New System.Windows.Forms.Button()
        Me.bt_chercher = New System.Windows.Forms.Button()
        Me.bt_modifier = New System.Windows.Forms.Button()
        Me.bt_supprimer = New System.Windows.Forms.Button()
        Me.bt_ajouter = New System.Windows.Forms.Button()
        Me.tb_Quantite = New System.Windows.Forms.TextBox()
        Me.lb_Quantite = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.I_evenemenet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.I_materiel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightYellow
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Materiel, Me.Nom, Me.type})
        Me.DataGridView1.Location = New System.Drawing.Point(480, 35)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(340, 173)
        Me.DataGridView1.TabIndex = 105
        '
        'ID_Materiel
        '
        Me.ID_Materiel.HeaderText = "ID_Materiel"
        Me.ID_Materiel.Name = "ID_Materiel"
        Me.ID_Materiel.ReadOnly = True
        '
        'Nom
        '
        Me.Nom.HeaderText = "NOM"
        Me.Nom.Name = "Nom"
        Me.Nom.ReadOnly = True
        '
        'type
        '
        Me.type.HeaderText = "TYPE"
        Me.type.Name = "type"
        Me.type.ReadOnly = True
        '
        'cb__Nom_Evenement
        '
        Me.cb__Nom_Evenement.FormattingEnabled = True
        Me.cb__Nom_Evenement.Location = New System.Drawing.Point(134, 55)
        Me.cb__Nom_Evenement.Name = "cb__Nom_Evenement"
        Me.cb__Nom_Evenement.Size = New System.Drawing.Size(156, 21)
        Me.cb__Nom_Evenement.TabIndex = 104
        '
        'lb_Nom_Evenement
        '
        Me.lb_Nom_Evenement.AutoSize = True
        Me.lb_Nom_Evenement.BackColor = System.Drawing.Color.Yellow
        Me.lb_Nom_Evenement.Location = New System.Drawing.Point(25, 58)
        Me.lb_Nom_Evenement.Name = "lb_Nom_Evenement"
        Me.lb_Nom_Evenement.Size = New System.Drawing.Size(86, 13)
        Me.lb_Nom_Evenement.TabIndex = 103
        Me.lb_Nom_Evenement.Text = "Nom Evenement"
        '
        'bt_annuler
        '
        Me.bt_annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_annuler.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_annuler.ForeColor = System.Drawing.Color.White
        Me.bt_annuler.Location = New System.Drawing.Point(202, 387)
        Me.bt_annuler.Name = "bt_annuler"
        Me.bt_annuler.Size = New System.Drawing.Size(88, 29)
        Me.bt_annuler.TabIndex = 102
        Me.bt_annuler.Text = "Annuler"
        Me.bt_annuler.UseVisualStyleBackColor = False
        '
        'tb_afficher_prix
        '
        Me.tb_afficher_prix.Location = New System.Drawing.Point(144, 332)
        Me.tb_afficher_prix.Name = "tb_afficher_prix"
        Me.tb_afficher_prix.Size = New System.Drawing.Size(135, 20)
        Me.tb_afficher_prix.TabIndex = 101
        '
        'bt_Afficher_Prix_total_materiel
        '
        Me.bt_Afficher_Prix_total_materiel.BackColor = System.Drawing.Color.Green
        Me.bt_Afficher_Prix_total_materiel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Afficher_Prix_total_materiel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Afficher_Prix_total_materiel.ForeColor = System.Drawing.Color.White
        Me.bt_Afficher_Prix_total_materiel.Location = New System.Drawing.Point(130, 275)
        Me.bt_Afficher_Prix_total_materiel.Name = "bt_Afficher_Prix_total_materiel"
        Me.bt_Afficher_Prix_total_materiel.Size = New System.Drawing.Size(160, 31)
        Me.bt_Afficher_Prix_total_materiel.TabIndex = 100
        Me.bt_Afficher_Prix_total_materiel.Text = "Afficher Prix Total Materiel"
        Me.bt_Afficher_Prix_total_materiel.UseVisualStyleBackColor = False
        '
        'tb_prix
        '
        Me.tb_prix.Location = New System.Drawing.Point(134, 156)
        Me.tb_prix.Name = "tb_prix"
        Me.tb_prix.Size = New System.Drawing.Size(156, 20)
        Me.tb_prix.TabIndex = 99
        '
        'tb_id_matériel
        '
        Me.tb_id_matériel.Location = New System.Drawing.Point(134, 107)
        Me.tb_id_matériel.Name = "tb_id_matériel"
        Me.tb_id_matériel.Size = New System.Drawing.Size(156, 20)
        Me.tb_id_matériel.TabIndex = 96
        '
        'lb_prix
        '
        Me.lb_prix.AutoSize = True
        Me.lb_prix.BackColor = System.Drawing.Color.Yellow
        Me.lb_prix.Location = New System.Drawing.Point(25, 159)
        Me.lb_prix.Name = "lb_prix"
        Me.lb_prix.Size = New System.Drawing.Size(24, 13)
        Me.lb_prix.TabIndex = 95
        Me.lb_prix.Text = "Prix"
        '
        'lb_id_matériel
        '
        Me.lb_id_matériel.AutoSize = True
        Me.lb_id_matériel.BackColor = System.Drawing.Color.Yellow
        Me.lb_id_matériel.Location = New System.Drawing.Point(25, 110)
        Me.lb_id_matériel.Name = "lb_id_matériel"
        Me.lb_id_matériel.Size = New System.Drawing.Size(54, 13)
        Me.lb_id_matériel.TabIndex = 92
        Me.lb_id_matériel.Text = "id matériel"
        '
        'bt_retour
        '
        Me.bt_retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_retour.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_retour.ForeColor = System.Drawing.Color.White
        Me.bt_retour.Location = New System.Drawing.Point(28, 387)
        Me.bt_retour.Name = "bt_retour"
        Me.bt_retour.Size = New System.Drawing.Size(88, 29)
        Me.bt_retour.TabIndex = 91
        Me.bt_retour.Text = "Retour"
        Me.bt_retour.UseVisualStyleBackColor = False
        '
        'bt_enregistrer
        '
        Me.bt_enregistrer.BackColor = System.Drawing.Color.Green
        Me.bt_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_enregistrer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_enregistrer.ForeColor = System.Drawing.Color.White
        Me.bt_enregistrer.Location = New System.Drawing.Point(314, 181)
        Me.bt_enregistrer.Name = "bt_enregistrer"
        Me.bt_enregistrer.Size = New System.Drawing.Size(160, 27)
        Me.bt_enregistrer.TabIndex = 90
        Me.bt_enregistrer.Text = "Enregistrer"
        Me.bt_enregistrer.UseVisualStyleBackColor = False
        '
        'bt_chercher
        '
        Me.bt_chercher.BackColor = System.Drawing.Color.Green
        Me.bt_chercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_chercher.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_chercher.ForeColor = System.Drawing.Color.White
        Me.bt_chercher.Location = New System.Drawing.Point(314, 225)
        Me.bt_chercher.Name = "bt_chercher"
        Me.bt_chercher.Size = New System.Drawing.Size(160, 27)
        Me.bt_chercher.TabIndex = 89
        Me.bt_chercher.Text = "Chercher"
        Me.bt_chercher.UseVisualStyleBackColor = False
        '
        'bt_modifier
        '
        Me.bt_modifier.BackColor = System.Drawing.Color.Green
        Me.bt_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_modifier.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_modifier.ForeColor = System.Drawing.Color.White
        Me.bt_modifier.Location = New System.Drawing.Point(314, 91)
        Me.bt_modifier.Name = "bt_modifier"
        Me.bt_modifier.Size = New System.Drawing.Size(160, 27)
        Me.bt_modifier.TabIndex = 88
        Me.bt_modifier.Text = "Modifier"
        Me.bt_modifier.UseVisualStyleBackColor = False
        '
        'bt_supprimer
        '
        Me.bt_supprimer.BackColor = System.Drawing.Color.Green
        Me.bt_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_supprimer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_supprimer.ForeColor = System.Drawing.Color.White
        Me.bt_supprimer.Location = New System.Drawing.Point(314, 140)
        Me.bt_supprimer.Name = "bt_supprimer"
        Me.bt_supprimer.Size = New System.Drawing.Size(160, 27)
        Me.bt_supprimer.TabIndex = 87
        Me.bt_supprimer.Text = "Supprimer"
        Me.bt_supprimer.UseVisualStyleBackColor = False
        '
        'bt_ajouter
        '
        Me.bt_ajouter.BackColor = System.Drawing.Color.Green
        Me.bt_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_ajouter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ajouter.ForeColor = System.Drawing.Color.White
        Me.bt_ajouter.Location = New System.Drawing.Point(314, 49)
        Me.bt_ajouter.Name = "bt_ajouter"
        Me.bt_ajouter.Size = New System.Drawing.Size(160, 27)
        Me.bt_ajouter.TabIndex = 86
        Me.bt_ajouter.Text = "Ajouter"
        Me.bt_ajouter.UseVisualStyleBackColor = False
        '
        'tb_Quantite
        '
        Me.tb_Quantite.Location = New System.Drawing.Point(134, 209)
        Me.tb_Quantite.Name = "tb_Quantite"
        Me.tb_Quantite.Size = New System.Drawing.Size(156, 20)
        Me.tb_Quantite.TabIndex = 107
        '
        'lb_Quantite
        '
        Me.lb_Quantite.AutoSize = True
        Me.lb_Quantite.BackColor = System.Drawing.Color.Yellow
        Me.lb_Quantite.Location = New System.Drawing.Point(25, 212)
        Me.lb_Quantite.Name = "lb_Quantite"
        Me.lb_Quantite.Size = New System.Drawing.Size(47, 13)
        Me.lb_Quantite.TabIndex = 106
        Me.lb_Quantite.Text = "Quantité"
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.LightYellow
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.I_evenemenet, Me.I_materiel, Me.Quantite})
        Me.DataGridView2.Location = New System.Drawing.Point(480, 225)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(340, 173)
        Me.DataGridView2.TabIndex = 109
        '
        'I_evenemenet
        '
        Me.I_evenemenet.HeaderText = "ID_evenemenet"
        Me.I_evenemenet.Name = "I_evenemenet"
        Me.I_evenemenet.ReadOnly = True
        '
        'I_materiel
        '
        Me.I_materiel.HeaderText = "ID_materiel"
        Me.I_materiel.Name = "I_materiel"
        Me.I_materiel.ReadOnly = True
        '
        'Quantite
        '
        Me.Quantite.HeaderText = "Quantite"
        Me.Quantite.Name = "Quantite"
        Me.Quantite.ReadOnly = True
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(399, 393)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 110
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'gestion_des_affectation_de_matiriel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(842, 503)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.tb_Quantite)
        Me.Controls.Add(Me.lb_Quantite)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cb__Nom_Evenement)
        Me.Controls.Add(Me.lb_Nom_Evenement)
        Me.Controls.Add(Me.bt_annuler)
        Me.Controls.Add(Me.tb_afficher_prix)
        Me.Controls.Add(Me.bt_Afficher_Prix_total_materiel)
        Me.Controls.Add(Me.tb_prix)
        Me.Controls.Add(Me.tb_id_matériel)
        Me.Controls.Add(Me.lb_prix)
        Me.Controls.Add(Me.lb_id_matériel)
        Me.Controls.Add(Me.bt_retour)
        Me.Controls.Add(Me.bt_enregistrer)
        Me.Controls.Add(Me.bt_chercher)
        Me.Controls.Add(Me.bt_modifier)
        Me.Controls.Add(Me.bt_supprimer)
        Me.Controls.Add(Me.bt_ajouter)
        Me.Name = "gestion_des_affectation_de_matiriel"
        Me.Text = "gestion_des_affectation_de_matiriel"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ID_Materiel As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents type As DataGridViewTextBoxColumn
    Friend WithEvents cb__Nom_Evenement As ComboBox
    Friend WithEvents lb_Nom_Evenement As Label
    Friend WithEvents bt_annuler As Button
    Friend WithEvents tb_afficher_prix As TextBox
    Friend WithEvents bt_Afficher_Prix_total_materiel As Button
    Friend WithEvents tb_prix As TextBox
    Friend WithEvents tb_id_matériel As TextBox
    Friend WithEvents lb_prix As Label
    Friend WithEvents lb_id_matériel As Label
    Friend WithEvents bt_retour As Button
    Friend WithEvents bt_enregistrer As Button
    Friend WithEvents bt_chercher As Button
    Friend WithEvents bt_modifier As Button
    Friend WithEvents bt_supprimer As Button
    Friend WithEvents bt_ajouter As Button
    Friend WithEvents tb_Quantite As TextBox
    Friend WithEvents lb_Quantite As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents I_evenemenet As DataGridViewTextBoxColumn
    Friend WithEvents I_materiel As DataGridViewTextBoxColumn
    Friend WithEvents Quantite As DataGridViewTextBoxColumn
    Friend WithEvents bt_Quitter As Button
End Class
