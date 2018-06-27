<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Plan_communication
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Plan_communication))
        Me.bt_retour = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_plan_generale = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_NCIN_responsable = New System.Windows.Forms.TextBox()
        Me.tb_nom_planing = New System.Windows.Forms.TextBox()
        Me.tb_ID_PLANING = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ID_PLANING = New System.Windows.Forms.Label()
        Me.bt_enregistrer = New System.Windows.Forms.Button()
        Me.bt_chercher = New System.Windows.Forms.Button()
        Me.bt_modifier = New System.Windows.Forms.Button()
        Me.bt_supprimer = New System.Windows.Forms.Button()
        Me.bt_Ajouter = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bt_Annuler = New System.Windows.Forms.Button()
        Me.cb_evenement = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDPLANING = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_evenement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.palning = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_retour
        '
        Me.bt_retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_retour.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_retour.ForeColor = System.Drawing.Color.White
        Me.bt_retour.Location = New System.Drawing.Point(704, 392)
        Me.bt_retour.Name = "bt_retour"
        Me.bt_retour.Size = New System.Drawing.Size(88, 26)
        Me.bt_retour.TabIndex = 28
        Me.bt_retour.Text = "Retour"
        Me.bt_retour.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(123, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "PLAN GENERALE"
        '
        'tb_plan_generale
        '
        Me.tb_plan_generale.Location = New System.Drawing.Point(4, 252)
        Me.tb_plan_generale.Multiline = True
        Me.tb_plan_generale.Name = "tb_plan_generale"
        Me.tb_plan_generale.Size = New System.Drawing.Size(378, 154)
        Me.tb_plan_generale.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(24, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "NCIN RESPONSABLE"
        '
        'tb_NCIN_responsable
        '
        Me.tb_NCIN_responsable.Location = New System.Drawing.Point(204, 36)
        Me.tb_NCIN_responsable.Name = "tb_NCIN_responsable"
        Me.tb_NCIN_responsable.Size = New System.Drawing.Size(178, 20)
        Me.tb_NCIN_responsable.TabIndex = 32
        '
        'tb_nom_planing
        '
        Me.tb_nom_planing.Location = New System.Drawing.Point(204, 192)
        Me.tb_nom_planing.Name = "tb_nom_planing"
        Me.tb_nom_planing.Size = New System.Drawing.Size(178, 20)
        Me.tb_nom_planing.TabIndex = 34
        '
        'tb_ID_PLANING
        '
        Me.tb_ID_PLANING.Location = New System.Drawing.Point(204, 139)
        Me.tb_ID_PLANING.Name = "tb_ID_PLANING"
        Me.tb_ID_PLANING.Size = New System.Drawing.Size(178, 20)
        Me.tb_ID_PLANING.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(26, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "NOM PLANING"
        '
        'ID_PLANING
        '
        Me.ID_PLANING.AutoSize = True
        Me.ID_PLANING.BackColor = System.Drawing.Color.Yellow
        Me.ID_PLANING.Location = New System.Drawing.Point(26, 146)
        Me.ID_PLANING.Name = "ID_PLANING"
        Me.ID_PLANING.Size = New System.Drawing.Size(68, 13)
        Me.ID_PLANING.TabIndex = 38
        Me.ID_PLANING.Text = "ID PLANING"
        '
        'bt_enregistrer
        '
        Me.bt_enregistrer.BackColor = System.Drawing.Color.Green
        Me.bt_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_enregistrer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_enregistrer.ForeColor = System.Drawing.Color.White
        Me.bt_enregistrer.Location = New System.Drawing.Point(716, 98)
        Me.bt_enregistrer.Name = "bt_enregistrer"
        Me.bt_enregistrer.Size = New System.Drawing.Size(100, 32)
        Me.bt_enregistrer.TabIndex = 43
        Me.bt_enregistrer.Text = "Enregistrer"
        Me.bt_enregistrer.UseVisualStyleBackColor = False
        '
        'bt_chercher
        '
        Me.bt_chercher.BackColor = System.Drawing.Color.Green
        Me.bt_chercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_chercher.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_chercher.ForeColor = System.Drawing.Color.White
        Me.bt_chercher.Location = New System.Drawing.Point(573, 72)
        Me.bt_chercher.Name = "bt_chercher"
        Me.bt_chercher.Size = New System.Drawing.Size(100, 32)
        Me.bt_chercher.TabIndex = 42
        Me.bt_chercher.Text = "Chercher"
        Me.bt_chercher.UseVisualStyleBackColor = False
        '
        'bt_modifier
        '
        Me.bt_modifier.BackColor = System.Drawing.Color.Green
        Me.bt_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_modifier.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_modifier.ForeColor = System.Drawing.Color.White
        Me.bt_modifier.Location = New System.Drawing.Point(414, 98)
        Me.bt_modifier.Name = "bt_modifier"
        Me.bt_modifier.Size = New System.Drawing.Size(100, 32)
        Me.bt_modifier.TabIndex = 41
        Me.bt_modifier.Text = "Modifier"
        Me.bt_modifier.UseVisualStyleBackColor = False
        '
        'bt_supprimer
        '
        Me.bt_supprimer.BackColor = System.Drawing.Color.Green
        Me.bt_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_supprimer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_supprimer.ForeColor = System.Drawing.Color.White
        Me.bt_supprimer.Location = New System.Drawing.Point(716, 39)
        Me.bt_supprimer.Name = "bt_supprimer"
        Me.bt_supprimer.Size = New System.Drawing.Size(100, 32)
        Me.bt_supprimer.TabIndex = 40
        Me.bt_supprimer.Text = "Supprimer"
        Me.bt_supprimer.UseVisualStyleBackColor = False
        '
        'bt_Ajouter
        '
        Me.bt_Ajouter.BackColor = System.Drawing.Color.Green
        Me.bt_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Ajouter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Ajouter.ForeColor = System.Drawing.Color.White
        Me.bt_Ajouter.Location = New System.Drawing.Point(414, 36)
        Me.bt_Ajouter.Name = "bt_Ajouter"
        Me.bt_Ajouter.Size = New System.Drawing.Size(100, 32)
        Me.bt_Ajouter.TabIndex = 39
        Me.bt_Ajouter.Text = "Ajouter"
        Me.bt_Ajouter.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(24, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "NOM EVENEMENT"
        '
        'bt_Annuler
        '
        Me.bt_Annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Annuler.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Annuler.ForeColor = System.Drawing.Color.White
        Me.bt_Annuler.Location = New System.Drawing.Point(449, 392)
        Me.bt_Annuler.Name = "bt_Annuler"
        Me.bt_Annuler.Size = New System.Drawing.Size(88, 26)
        Me.bt_Annuler.TabIndex = 46
        Me.bt_Annuler.Text = "Annuler"
        Me.bt_Annuler.UseVisualStyleBackColor = False
        '
        'cb_evenement
        '
        Me.cb_evenement.FormattingEnabled = True
        Me.cb_evenement.Location = New System.Drawing.Point(204, 88)
        Me.cb_evenement.Name = "cb_evenement"
        Me.cb_evenement.Size = New System.Drawing.Size(178, 21)
        Me.cb_evenement.TabIndex = 65
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightYellow
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDPLANING, Me.id_evenement, Me.palning})
        Me.DataGridView1.Location = New System.Drawing.Point(449, 146)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(343, 222)
        Me.DataGridView1.TabIndex = 66
        '
        'IDPLANING
        '
        Me.IDPLANING.HeaderText = "IDPLANING"
        Me.IDPLANING.Name = "IDPLANING"
        Me.IDPLANING.ReadOnly = True
        '
        'id_evenement
        '
        Me.id_evenement.HeaderText = "ID_evenment"
        Me.id_evenement.Name = "id_evenement"
        Me.id_evenement.ReadOnly = True
        '
        'palning
        '
        Me.palning.HeaderText = "Planing"
        Me.palning.Name = "palning"
        Me.palning.ReadOnly = True
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(573, 395)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 67
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'Plan_communication
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
        Me.Name = "Plan_communication"
        Me.Text = "Plan_communication"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_retour As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_plan_generale As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_NCIN_responsable As System.Windows.Forms.TextBox
    Friend WithEvents tb_nom_planing As System.Windows.Forms.TextBox
    Friend WithEvents tb_ID_PLANING As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ID_PLANING As System.Windows.Forms.Label
    Friend WithEvents bt_enregistrer As System.Windows.Forms.Button
    Friend WithEvents bt_chercher As System.Windows.Forms.Button
    Friend WithEvents bt_modifier As System.Windows.Forms.Button
    Friend WithEvents bt_supprimer As System.Windows.Forms.Button
    Friend WithEvents bt_Ajouter As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents bt_Annuler As System.Windows.Forms.Button
    Friend WithEvents cb_evenement As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IDPLANING As DataGridViewTextBoxColumn
    Friend WithEvents id_evenement As DataGridViewTextBoxColumn
    Friend WithEvents palning As DataGridViewTextBoxColumn
    Friend WithEvents bt_Quitter As Button
End Class
