<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion_des_évenements
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gestion_des_évenements))
        Me.bt_ajouter = New System.Windows.Forms.Button()
        Me.bt_supprimer = New System.Windows.Forms.Button()
        Me.bt_modifier = New System.Windows.Forms.Button()
        Me.bt_chercher = New System.Windows.Forms.Button()
        Me.bt_enregistrer = New System.Windows.Forms.Button()
        Me.RE = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_ID_Evénement = New System.Windows.Forms.TextBox()
        Me.tb_Nom_Evénement = New System.Windows.Forms.TextBox()
        Me.tb_type = New System.Windows.Forms.TextBox()
        Me.tb_date = New System.Windows.Forms.TextBox()
        Me.tb_description = New System.Windows.Forms.TextBox()
        Me.bt_annuler = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID_evenement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_evenement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_ajouter
        '
        Me.bt_ajouter.BackColor = System.Drawing.Color.Green
        Me.bt_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_ajouter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ajouter.ForeColor = System.Drawing.Color.White
        Me.bt_ajouter.Location = New System.Drawing.Point(399, 50)
        Me.bt_ajouter.Name = "bt_ajouter"
        Me.bt_ajouter.Size = New System.Drawing.Size(101, 27)
        Me.bt_ajouter.TabIndex = 4
        Me.bt_ajouter.Text = "Ajouter"
        Me.bt_ajouter.UseVisualStyleBackColor = False
        '
        'bt_supprimer
        '
        Me.bt_supprimer.BackColor = System.Drawing.Color.Green
        Me.bt_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_supprimer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_supprimer.ForeColor = System.Drawing.Color.White
        Me.bt_supprimer.Location = New System.Drawing.Point(399, 149)
        Me.bt_supprimer.Name = "bt_supprimer"
        Me.bt_supprimer.Size = New System.Drawing.Size(101, 27)
        Me.bt_supprimer.TabIndex = 6
        Me.bt_supprimer.Text = "Supprimer"
        Me.bt_supprimer.UseVisualStyleBackColor = False
        '
        'bt_modifier
        '
        Me.bt_modifier.BackColor = System.Drawing.Color.Green
        Me.bt_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_modifier.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_modifier.ForeColor = System.Drawing.Color.White
        Me.bt_modifier.Location = New System.Drawing.Point(399, 102)
        Me.bt_modifier.Name = "bt_modifier"
        Me.bt_modifier.Size = New System.Drawing.Size(101, 27)
        Me.bt_modifier.TabIndex = 7
        Me.bt_modifier.Text = "Modifier"
        Me.bt_modifier.UseVisualStyleBackColor = False
        '
        'bt_chercher
        '
        Me.bt_chercher.BackColor = System.Drawing.Color.Green
        Me.bt_chercher.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_chercher.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_chercher.ForeColor = System.Drawing.Color.White
        Me.bt_chercher.Location = New System.Drawing.Point(399, 251)
        Me.bt_chercher.Name = "bt_chercher"
        Me.bt_chercher.Size = New System.Drawing.Size(101, 31)
        Me.bt_chercher.TabIndex = 8
        Me.bt_chercher.Text = "Chercher"
        Me.bt_chercher.UseVisualStyleBackColor = False
        '
        'bt_enregistrer
        '
        Me.bt_enregistrer.BackColor = System.Drawing.Color.Green
        Me.bt_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_enregistrer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_enregistrer.ForeColor = System.Drawing.Color.White
        Me.bt_enregistrer.Location = New System.Drawing.Point(399, 199)
        Me.bt_enregistrer.Name = "bt_enregistrer"
        Me.bt_enregistrer.Size = New System.Drawing.Size(101, 26)
        Me.bt_enregistrer.TabIndex = 9
        Me.bt_enregistrer.Text = "Enregistrer"
        Me.bt_enregistrer.UseVisualStyleBackColor = False
        '
        'RE
        '
        Me.RE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RE.ForeColor = System.Drawing.Color.White
        Me.RE.Location = New System.Drawing.Point(96, 316)
        Me.RE.Name = "RE"
        Me.RE.Size = New System.Drawing.Size(88, 23)
        Me.RE.TabIndex = 10
        Me.RE.Text = "Retour"
        Me.RE.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(64, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ID Evénement"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(64, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nom Evénement"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(64, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(64, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(64, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Description"
        '
        'tb_ID_Evénement
        '
        Me.tb_ID_Evénement.Location = New System.Drawing.Point(187, 38)
        Me.tb_ID_Evénement.Name = "tb_ID_Evénement"
        Me.tb_ID_Evénement.Size = New System.Drawing.Size(127, 20)
        Me.tb_ID_Evénement.TabIndex = 16
        '
        'tb_Nom_Evénement
        '
        Me.tb_Nom_Evénement.Location = New System.Drawing.Point(187, 80)
        Me.tb_Nom_Evénement.Name = "tb_Nom_Evénement"
        Me.tb_Nom_Evénement.Size = New System.Drawing.Size(127, 20)
        Me.tb_Nom_Evénement.TabIndex = 17
        '
        'tb_type
        '
        Me.tb_type.Location = New System.Drawing.Point(187, 129)
        Me.tb_type.Name = "tb_type"
        Me.tb_type.Size = New System.Drawing.Size(127, 20)
        Me.tb_type.TabIndex = 18
        '
        'tb_date
        '
        Me.tb_date.Location = New System.Drawing.Point(187, 176)
        Me.tb_date.Name = "tb_date"
        Me.tb_date.Size = New System.Drawing.Size(127, 20)
        Me.tb_date.TabIndex = 19
        '
        'tb_description
        '
        Me.tb_description.Location = New System.Drawing.Point(187, 230)
        Me.tb_description.Multiline = True
        Me.tb_description.Name = "tb_description"
        Me.tb_description.Size = New System.Drawing.Size(127, 41)
        Me.tb_description.TabIndex = 20
        '
        'bt_annuler
        '
        Me.bt_annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_annuler.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_annuler.ForeColor = System.Drawing.Color.White
        Me.bt_annuler.Location = New System.Drawing.Point(226, 316)
        Me.bt_annuler.Name = "bt_annuler"
        Me.bt_annuler.Size = New System.Drawing.Size(88, 23)
        Me.bt_annuler.TabIndex = 28
        Me.bt_annuler.Text = "Annuler"
        Me.bt_annuler.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightYellow
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_evenement, Me.nom_evenement})
        Me.DataGridView1.Location = New System.Drawing.Point(572, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(243, 322)
        Me.DataGridView1.TabIndex = 27
        '
        'ID_evenement
        '
        Me.ID_evenement.HeaderText = "ID Evénement"
        Me.ID_evenement.Name = "ID_evenement"
        '
        'nom_evenement
        '
        Me.nom_evenement.HeaderText = "Nom Evénement"
        Me.nom_evenement.Name = "nom_evenement"
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(425, 316)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 29
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'Gestion_des_évenements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(844, 503)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.bt_annuler)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tb_description)
        Me.Controls.Add(Me.tb_date)
        Me.Controls.Add(Me.tb_type)
        Me.Controls.Add(Me.tb_Nom_Evénement)
        Me.Controls.Add(Me.tb_ID_Evénement)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RE)
        Me.Controls.Add(Me.bt_enregistrer)
        Me.Controls.Add(Me.bt_chercher)
        Me.Controls.Add(Me.bt_modifier)
        Me.Controls.Add(Me.bt_supprimer)
        Me.Controls.Add(Me.bt_ajouter)
        Me.Name = "Gestion_des_évenements"
        Me.Text = "Gestion des évenements"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_ajouter As System.Windows.Forms.Button
    Friend WithEvents bt_supprimer As System.Windows.Forms.Button
    Friend WithEvents bt_modifier As System.Windows.Forms.Button
    Friend WithEvents bt_chercher As System.Windows.Forms.Button
    Friend WithEvents bt_enregistrer As System.Windows.Forms.Button
    Friend WithEvents RE As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_ID_Evénement As System.Windows.Forms.TextBox
    Friend WithEvents tb_Nom_Evénement As System.Windows.Forms.TextBox
    Friend WithEvents tb_type As System.Windows.Forms.TextBox
    Friend WithEvents tb_date As System.Windows.Forms.TextBox
    Friend WithEvents tb_description As System.Windows.Forms.TextBox
    Friend WithEvents bt_annuler As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ID_evenement As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nom_evenement As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bt_Quitter As Button
End Class
