<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion_des_Materiel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gestion_des_Materiel))
        Me.tb_type = New System.Windows.Forms.TextBox()
        Me.tb_nom_materiel = New System.Windows.Forms.TextBox()
        Me.tb_id_matériel = New System.Windows.Forms.TextBox()
        Me.lb_type = New System.Windows.Forms.Label()
        Me.lb_nom_materiel = New System.Windows.Forms.Label()
        Me.lb_id_matériel = New System.Windows.Forms.Label()
        Me.bt_retour = New System.Windows.Forms.Button()
        Me.bt_enregistrer = New System.Windows.Forms.Button()
        Me.bt_chercher = New System.Windows.Forms.Button()
        Me.bt_modifier = New System.Windows.Forms.Button()
        Me.bt_supprimer = New System.Windows.Forms.Button()
        Me.bt_ajouter = New System.Windows.Forms.Button()
        Me.bt_annuler = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID_Materiel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_Description = New System.Windows.Forms.TextBox()
        Me.lb_Description = New System.Windows.Forms.Label()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_type
        '
        Me.tb_type.Location = New System.Drawing.Point(156, 181)
        Me.tb_type.Name = "tb_type"
        Me.tb_type.Size = New System.Drawing.Size(156, 20)
        Me.tb_type.TabIndex = 65
        '
        'tb_nom_materiel
        '
        Me.tb_nom_materiel.Location = New System.Drawing.Point(156, 130)
        Me.tb_nom_materiel.Name = "tb_nom_materiel"
        Me.tb_nom_materiel.Size = New System.Drawing.Size(156, 20)
        Me.tb_nom_materiel.TabIndex = 64
        '
        'tb_id_matériel
        '
        Me.tb_id_matériel.Location = New System.Drawing.Point(156, 79)
        Me.tb_id_matériel.Name = "tb_id_matériel"
        Me.tb_id_matériel.Size = New System.Drawing.Size(156, 20)
        Me.tb_id_matériel.TabIndex = 63
        '
        'lb_type
        '
        Me.lb_type.AutoSize = True
        Me.lb_type.BackColor = System.Drawing.Color.Yellow
        Me.lb_type.Location = New System.Drawing.Point(47, 184)
        Me.lb_type.Name = "lb_type"
        Me.lb_type.Size = New System.Drawing.Size(31, 13)
        Me.lb_type.TabIndex = 61
        Me.lb_type.Text = "Type"
        '
        'lb_nom_materiel
        '
        Me.lb_nom_materiel.AutoSize = True
        Me.lb_nom_materiel.BackColor = System.Drawing.Color.Yellow
        Me.lb_nom_materiel.Location = New System.Drawing.Point(47, 133)
        Me.lb_nom_materiel.Name = "lb_nom_materiel"
        Me.lb_nom_materiel.Size = New System.Drawing.Size(84, 13)
        Me.lb_nom_materiel.TabIndex = 60
        Me.lb_nom_materiel.Text = "Nom de Materiel"
        '
        'lb_id_matériel
        '
        Me.lb_id_matériel.AutoSize = True
        Me.lb_id_matériel.BackColor = System.Drawing.Color.Yellow
        Me.lb_id_matériel.Location = New System.Drawing.Point(47, 82)
        Me.lb_id_matériel.Name = "lb_id_matériel"
        Me.lb_id_matériel.Size = New System.Drawing.Size(54, 13)
        Me.lb_id_matériel.TabIndex = 59
        Me.lb_id_matériel.Text = "id matériel"
        '
        'bt_retour
        '
        Me.bt_retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_retour.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_retour.ForeColor = System.Drawing.Color.White
        Me.bt_retour.Location = New System.Drawing.Point(50, 322)
        Me.bt_retour.Name = "bt_retour"
        Me.bt_retour.Size = New System.Drawing.Size(88, 29)
        Me.bt_retour.TabIndex = 57
        Me.bt_retour.Text = "Retour"
        Me.bt_retour.UseVisualStyleBackColor = False
        '
        'bt_enregistrer
        '
        Me.bt_enregistrer.BackColor = System.Drawing.Color.Green
        Me.bt_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_enregistrer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_enregistrer.ForeColor = System.Drawing.Color.White
        Me.bt_enregistrer.Location = New System.Drawing.Point(336, 204)
        Me.bt_enregistrer.Name = "bt_enregistrer"
        Me.bt_enregistrer.Size = New System.Drawing.Size(160, 27)
        Me.bt_enregistrer.TabIndex = 56
        Me.bt_enregistrer.Text = "Enregistrer"
        Me.bt_enregistrer.UseVisualStyleBackColor = False
        '
        'bt_chercher
        '
        Me.bt_chercher.BackColor = System.Drawing.Color.Green
        Me.bt_chercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_chercher.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_chercher.ForeColor = System.Drawing.Color.White
        Me.bt_chercher.Location = New System.Drawing.Point(336, 248)
        Me.bt_chercher.Name = "bt_chercher"
        Me.bt_chercher.Size = New System.Drawing.Size(160, 27)
        Me.bt_chercher.TabIndex = 55
        Me.bt_chercher.Text = "Chercher"
        Me.bt_chercher.UseVisualStyleBackColor = False
        '
        'bt_modifier
        '
        Me.bt_modifier.BackColor = System.Drawing.Color.Green
        Me.bt_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_modifier.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_modifier.ForeColor = System.Drawing.Color.White
        Me.bt_modifier.Location = New System.Drawing.Point(336, 114)
        Me.bt_modifier.Name = "bt_modifier"
        Me.bt_modifier.Size = New System.Drawing.Size(160, 27)
        Me.bt_modifier.TabIndex = 54
        Me.bt_modifier.Text = "Modifier"
        Me.bt_modifier.UseVisualStyleBackColor = False
        '
        'bt_supprimer
        '
        Me.bt_supprimer.BackColor = System.Drawing.Color.Green
        Me.bt_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_supprimer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_supprimer.ForeColor = System.Drawing.Color.White
        Me.bt_supprimer.Location = New System.Drawing.Point(336, 163)
        Me.bt_supprimer.Name = "bt_supprimer"
        Me.bt_supprimer.Size = New System.Drawing.Size(160, 27)
        Me.bt_supprimer.TabIndex = 53
        Me.bt_supprimer.Text = "Supprimer"
        Me.bt_supprimer.UseVisualStyleBackColor = False
        '
        'bt_ajouter
        '
        Me.bt_ajouter.BackColor = System.Drawing.Color.Green
        Me.bt_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_ajouter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ajouter.ForeColor = System.Drawing.Color.White
        Me.bt_ajouter.Location = New System.Drawing.Point(336, 72)
        Me.bt_ajouter.Name = "bt_ajouter"
        Me.bt_ajouter.Size = New System.Drawing.Size(160, 27)
        Me.bt_ajouter.TabIndex = 52
        Me.bt_ajouter.Text = "Ajouter"
        Me.bt_ajouter.UseVisualStyleBackColor = False
        '
        'bt_annuler
        '
        Me.bt_annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_annuler.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_annuler.ForeColor = System.Drawing.Color.White
        Me.bt_annuler.Location = New System.Drawing.Point(224, 322)
        Me.bt_annuler.Name = "bt_annuler"
        Me.bt_annuler.Size = New System.Drawing.Size(88, 29)
        Me.bt_annuler.TabIndex = 79
        Me.bt_annuler.Text = "Annuler"
        Me.bt_annuler.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Materiel, Me.Nom, Me.type})
        Me.DataGridView1.Location = New System.Drawing.Point(503, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(340, 304)
        Me.DataGridView1.TabIndex = 82
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
        'tb_Description
        '
        Me.tb_Description.Location = New System.Drawing.Point(156, 235)
        Me.tb_Description.Name = "tb_Description"
        Me.tb_Description.Size = New System.Drawing.Size(156, 20)
        Me.tb_Description.TabIndex = 85
        '
        'lb_Description
        '
        Me.lb_Description.AutoSize = True
        Me.lb_Description.BackColor = System.Drawing.Color.Yellow
        Me.lb_Description.Location = New System.Drawing.Point(47, 238)
        Me.lb_Description.Name = "lb_Description"
        Me.lb_Description.Size = New System.Drawing.Size(60, 13)
        Me.lb_Description.TabIndex = 84
        Me.lb_Description.Text = "Description"
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(768, 356)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 86
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'Gestion_des_Materiel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(842, 503)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.tb_Description)
        Me.Controls.Add(Me.lb_Description)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.bt_annuler)
        Me.Controls.Add(Me.tb_type)
        Me.Controls.Add(Me.tb_nom_materiel)
        Me.Controls.Add(Me.tb_id_matériel)
        Me.Controls.Add(Me.lb_type)
        Me.Controls.Add(Me.lb_nom_materiel)
        Me.Controls.Add(Me.lb_id_matériel)
        Me.Controls.Add(Me.bt_retour)
        Me.Controls.Add(Me.bt_enregistrer)
        Me.Controls.Add(Me.bt_chercher)
        Me.Controls.Add(Me.bt_modifier)
        Me.Controls.Add(Me.bt_supprimer)
        Me.Controls.Add(Me.bt_ajouter)
        Me.Name = "Gestion_des_Materiel"
        Me.Text = "Gestion des Materiel"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_type As System.Windows.Forms.TextBox
    Friend WithEvents tb_nom_materiel As System.Windows.Forms.TextBox
    Friend WithEvents tb_id_matériel As System.Windows.Forms.TextBox
    Friend WithEvents lb_type As System.Windows.Forms.Label
    Friend WithEvents lb_nom_materiel As System.Windows.Forms.Label
    Friend WithEvents lb_id_matériel As System.Windows.Forms.Label
    Friend WithEvents bt_retour As System.Windows.Forms.Button
    Friend WithEvents bt_enregistrer As System.Windows.Forms.Button
    Friend WithEvents bt_chercher As System.Windows.Forms.Button
    Friend WithEvents bt_modifier As System.Windows.Forms.Button
    Friend WithEvents bt_supprimer As System.Windows.Forms.Button
    Friend WithEvents bt_ajouter As System.Windows.Forms.Button
    Friend WithEvents bt_annuler As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ID_Materiel As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents type As DataGridViewTextBoxColumn
    Friend WithEvents tb_Description As TextBox
    Friend WithEvents lb_Description As Label
    Friend WithEvents bt_Quitter As Button
End Class
