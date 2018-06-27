<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Plan_sponsoring
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Plan_sponsoring))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDPLANING = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_evenement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.planing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cb_evenement = New System.Windows.Forms.ComboBox()
        Me.bt_Annuler = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bt_enregistrer = New System.Windows.Forms.Button()
        Me.bt_chercher = New System.Windows.Forms.Button()
        Me.bt_modifier = New System.Windows.Forms.Button()
        Me.bt_supprimer = New System.Windows.Forms.Button()
        Me.bt_Ajouter = New System.Windows.Forms.Button()
        Me.ID_PLANING = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_ID_PLANING = New System.Windows.Forms.TextBox()
        Me.tb_nom_planing = New System.Windows.Forms.TextBox()
        Me.tb_NCIN_responsable = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_plan_generale = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_retour = New System.Windows.Forms.Button()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightYellow
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDPLANING, Me.id_evenement, Me.planing})
        Me.DataGridView1.Location = New System.Drawing.Point(452, 148)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(343, 250)
        Me.DataGridView1.TabIndex = 86
        '
        'IDPLANING
        '
        Me.IDPLANING.HeaderText = "ID_PLANING"
        Me.IDPLANING.Name = "IDPLANING"
        Me.IDPLANING.ReadOnly = True
        '
        'id_evenement
        '
        Me.id_evenement.HeaderText = "ID_Evenement"
        Me.id_evenement.Name = "id_evenement"
        Me.id_evenement.ReadOnly = True
        '
        'planing
        '
        Me.planing.HeaderText = "PLANING"
        Me.planing.Name = "planing"
        Me.planing.ReadOnly = True
        '
        'cb_evenement
        '
        Me.cb_evenement.FormattingEnabled = True
        Me.cb_evenement.Location = New System.Drawing.Point(212, 30)
        Me.cb_evenement.Name = "cb_evenement"
        Me.cb_evenement.Size = New System.Drawing.Size(178, 21)
        Me.cb_evenement.TabIndex = 85
        '
        'bt_Annuler
        '
        Me.bt_Annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Annuler.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Annuler.ForeColor = System.Drawing.Color.White
        Me.bt_Annuler.Location = New System.Drawing.Point(422, 404)
        Me.bt_Annuler.Name = "bt_Annuler"
        Me.bt_Annuler.Size = New System.Drawing.Size(88, 26)
        Me.bt_Annuler.TabIndex = 84
        Me.bt_Annuler.Text = "Annuler"
        Me.bt_Annuler.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(32, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "NOM EVENEMENT"
        '
        'bt_enregistrer
        '
        Me.bt_enregistrer.BackColor = System.Drawing.Color.Green
        Me.bt_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_enregistrer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_enregistrer.ForeColor = System.Drawing.Color.White
        Me.bt_enregistrer.Location = New System.Drawing.Point(422, 96)
        Me.bt_enregistrer.Name = "bt_enregistrer"
        Me.bt_enregistrer.Size = New System.Drawing.Size(110, 32)
        Me.bt_enregistrer.TabIndex = 82
        Me.bt_enregistrer.Text = "Enregistrer"
        Me.bt_enregistrer.UseVisualStyleBackColor = False
        '
        'bt_chercher
        '
        Me.bt_chercher.BackColor = System.Drawing.Color.Green
        Me.bt_chercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_chercher.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_chercher.ForeColor = System.Drawing.Color.White
        Me.bt_chercher.Location = New System.Drawing.Point(572, 68)
        Me.bt_chercher.Name = "bt_chercher"
        Me.bt_chercher.Size = New System.Drawing.Size(100, 32)
        Me.bt_chercher.TabIndex = 81
        Me.bt_chercher.Text = "Chercher"
        Me.bt_chercher.UseVisualStyleBackColor = False
        '
        'bt_modifier
        '
        Me.bt_modifier.BackColor = System.Drawing.Color.Green
        Me.bt_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_modifier.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_modifier.ForeColor = System.Drawing.Color.White
        Me.bt_modifier.Location = New System.Drawing.Point(712, 30)
        Me.bt_modifier.Name = "bt_modifier"
        Me.bt_modifier.Size = New System.Drawing.Size(100, 32)
        Me.bt_modifier.TabIndex = 80
        Me.bt_modifier.Text = "Modifier"
        Me.bt_modifier.UseVisualStyleBackColor = False
        '
        'bt_supprimer
        '
        Me.bt_supprimer.BackColor = System.Drawing.Color.Green
        Me.bt_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_supprimer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_supprimer.ForeColor = System.Drawing.Color.White
        Me.bt_supprimer.Location = New System.Drawing.Point(712, 96)
        Me.bt_supprimer.Name = "bt_supprimer"
        Me.bt_supprimer.Size = New System.Drawing.Size(100, 32)
        Me.bt_supprimer.TabIndex = 79
        Me.bt_supprimer.Text = "Supprimer"
        Me.bt_supprimer.UseVisualStyleBackColor = False
        '
        'bt_Ajouter
        '
        Me.bt_Ajouter.BackColor = System.Drawing.Color.Green
        Me.bt_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Ajouter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Ajouter.ForeColor = System.Drawing.Color.White
        Me.bt_Ajouter.Location = New System.Drawing.Point(422, 27)
        Me.bt_Ajouter.Name = "bt_Ajouter"
        Me.bt_Ajouter.Size = New System.Drawing.Size(110, 32)
        Me.bt_Ajouter.TabIndex = 78
        Me.bt_Ajouter.Text = "Ajouter"
        Me.bt_Ajouter.UseVisualStyleBackColor = False
        '
        'ID_PLANING
        '
        Me.ID_PLANING.AutoSize = True
        Me.ID_PLANING.BackColor = System.Drawing.Color.Yellow
        Me.ID_PLANING.Location = New System.Drawing.Point(34, 88)
        Me.ID_PLANING.Name = "ID_PLANING"
        Me.ID_PLANING.Size = New System.Drawing.Size(68, 13)
        Me.ID_PLANING.TabIndex = 77
        Me.ID_PLANING.Text = "ID PLANING"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(34, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "NOM PLANING"
        '
        'tb_ID_PLANING
        '
        Me.tb_ID_PLANING.Location = New System.Drawing.Point(212, 81)
        Me.tb_ID_PLANING.Name = "tb_ID_PLANING"
        Me.tb_ID_PLANING.Size = New System.Drawing.Size(178, 20)
        Me.tb_ID_PLANING.TabIndex = 74
        '
        'tb_nom_planing
        '
        Me.tb_nom_planing.Enabled = False
        Me.tb_nom_planing.Location = New System.Drawing.Point(212, 183)
        Me.tb_nom_planing.Name = "tb_nom_planing"
        Me.tb_nom_planing.Size = New System.Drawing.Size(178, 20)
        Me.tb_nom_planing.TabIndex = 73
        '
        'tb_NCIN_responsable
        '
        Me.tb_NCIN_responsable.Location = New System.Drawing.Point(212, 135)
        Me.tb_NCIN_responsable.Name = "tb_NCIN_responsable"
        Me.tb_NCIN_responsable.Size = New System.Drawing.Size(178, 20)
        Me.tb_NCIN_responsable.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(32, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "NCIN RESPONSABLE"
        '
        'tb_plan_generale
        '
        Me.tb_plan_generale.Location = New System.Drawing.Point(12, 246)
        Me.tb_plan_generale.Multiline = True
        Me.tb_plan_generale.Name = "tb_plan_generale"
        Me.tb_plan_generale.Size = New System.Drawing.Size(378, 174)
        Me.tb_plan_generale.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(140, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "PLAN GENERALE"
        '
        'bt_retour
        '
        Me.bt_retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_retour.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_retour.ForeColor = System.Drawing.Color.White
        Me.bt_retour.Location = New System.Drawing.Point(724, 404)
        Me.bt_retour.Name = "bt_retour"
        Me.bt_retour.Size = New System.Drawing.Size(88, 26)
        Me.bt_retour.TabIndex = 67
        Me.bt_retour.Text = "Retour"
        Me.bt_retour.UseVisualStyleBackColor = False
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(581, 407)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 87
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'Plan_sponsoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(842, 503)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cb_evenement)
        Me.Controls.Add(Me.bt_Annuler)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.bt_enregistrer)
        Me.Controls.Add(Me.bt_chercher)
        Me.Controls.Add(Me.bt_modifier)
        Me.Controls.Add(Me.bt_supprimer)
        Me.Controls.Add(Me.bt_Ajouter)
        Me.Controls.Add(Me.ID_PLANING)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_ID_PLANING)
        Me.Controls.Add(Me.tb_nom_planing)
        Me.Controls.Add(Me.tb_NCIN_responsable)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_plan_generale)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_retour)
        Me.Name = "Plan_sponsoring"
        Me.Text = "Plan_sponsoring"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cb_evenement As ComboBox
    Friend WithEvents bt_Annuler As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents bt_enregistrer As Button
    Friend WithEvents bt_chercher As Button
    Friend WithEvents bt_modifier As Button
    Friend WithEvents bt_supprimer As Button
    Friend WithEvents bt_Ajouter As Button
    Friend WithEvents ID_PLANING As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_ID_PLANING As TextBox
    Friend WithEvents tb_nom_planing As TextBox
    Friend WithEvents tb_NCIN_responsable As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_plan_generale As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bt_retour As Button
    Friend WithEvents IDPLANING As DataGridViewTextBoxColumn
    Friend WithEvents id_evenement As DataGridViewTextBoxColumn
    Friend WithEvents planing As DataGridViewTextBoxColumn
    Friend WithEvents bt_Quitter As Button
End Class
