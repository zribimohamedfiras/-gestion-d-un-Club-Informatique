<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulté_Journal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consulté_Journal))
        Me.bt_journal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bt_Annuler = New System.Windows.Forms.Button()
        Me.RE = New System.Windows.Forms.Button()
        Me.bt_Afficher_Montant_Totale = New System.Windows.Forms.Button()
        Me.tb_montant = New System.Windows.Forms.TextBox()
        Me.lb_montant = New System.Windows.Forms.Label()
        Me.cb_annee = New System.Windows.Forms.ComboBox()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        Me.Date_entrés_sorties = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.libellé = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantité = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mantant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_journal
        '
        Me.bt_journal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_journal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_journal.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_journal.ForeColor = System.Drawing.Color.White
        Me.bt_journal.Location = New System.Drawing.Point(470, 12)
        Me.bt_journal.Name = "bt_journal"
        Me.bt_journal.Size = New System.Drawing.Size(255, 43)
        Me.bt_journal.TabIndex = 32
        Me.bt_journal.Text = "Afficher Journal"
        Me.bt_journal.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(108, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Année"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightYellow
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Date_entrés_sorties, Me.Nom, Me.type, Me.libellé, Me.quantité, Me.mantant})
        Me.DataGridView1.Location = New System.Drawing.Point(53, 118)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(722, 265)
        Me.DataGridView1.TabIndex = 35
        Me.DataGridView1.Visible = False
        '
        'bt_Annuler
        '
        Me.bt_Annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Annuler.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_Annuler.ForeColor = System.Drawing.Color.White
        Me.bt_Annuler.Location = New System.Drawing.Point(742, 384)
        Me.bt_Annuler.Name = "bt_Annuler"
        Me.bt_Annuler.Size = New System.Drawing.Size(88, 28)
        Me.bt_Annuler.TabIndex = 37
        Me.bt_Annuler.Text = "Annuler"
        Me.bt_Annuler.UseVisualStyleBackColor = False
        '
        'RE
        '
        Me.RE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RE.ForeColor = System.Drawing.Color.White
        Me.RE.Location = New System.Drawing.Point(12, 384)
        Me.RE.Name = "RE"
        Me.RE.Size = New System.Drawing.Size(88, 28)
        Me.RE.TabIndex = 36
        Me.RE.Text = "Retour"
        Me.RE.UseVisualStyleBackColor = False
        '
        'bt_Afficher_Montant_Totale
        '
        Me.bt_Afficher_Montant_Totale.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Afficher_Montant_Totale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Afficher_Montant_Totale.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Afficher_Montant_Totale.ForeColor = System.Drawing.Color.White
        Me.bt_Afficher_Montant_Totale.Location = New System.Drawing.Point(470, 69)
        Me.bt_Afficher_Montant_Totale.Name = "bt_Afficher_Montant_Totale"
        Me.bt_Afficher_Montant_Totale.Size = New System.Drawing.Size(255, 43)
        Me.bt_Afficher_Montant_Totale.TabIndex = 38
        Me.bt_Afficher_Montant_Totale.Text = "Afficher Montant Totale"
        Me.bt_Afficher_Montant_Totale.UseVisualStyleBackColor = False
        '
        'tb_montant
        '
        Me.tb_montant.Enabled = False
        Me.tb_montant.Location = New System.Drawing.Point(249, 86)
        Me.tb_montant.Name = "tb_montant"
        Me.tb_montant.Size = New System.Drawing.Size(190, 20)
        Me.tb_montant.TabIndex = 39
        '
        'lb_montant
        '
        Me.lb_montant.AutoSize = True
        Me.lb_montant.BackColor = System.Drawing.Color.Yellow
        Me.lb_montant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lb_montant.Location = New System.Drawing.Point(108, 87)
        Me.lb_montant.Name = "lb_montant"
        Me.lb_montant.Size = New System.Drawing.Size(75, 13)
        Me.lb_montant.TabIndex = 40
        Me.lb_montant.Text = "Montant totale"
        '
        'cb_annee
        '
        Me.cb_annee.FormattingEnabled = True
        Me.cb_annee.Items.AddRange(New Object() {"2015", "2016", "2017", "tous les années"})
        Me.cb_annee.Location = New System.Drawing.Point(249, 25)
        Me.cb_annee.Name = "cb_annee"
        Me.cb_annee.Size = New System.Drawing.Size(190, 21)
        Me.cb_annee.TabIndex = 41
        Me.cb_annee.Text = "choisir une année"
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(364, 389)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 42
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'Date_entrés_sorties
        '
        Me.Date_entrés_sorties.HeaderText = "Date"
        Me.Date_entrés_sorties.Name = "Date_entrés_sorties"
        Me.Date_entrés_sorties.ReadOnly = True
        Me.Date_entrés_sorties.Width = 120
        '
        'Nom
        '
        Me.Nom.HeaderText = "Nom"
        Me.Nom.Name = "Nom"
        Me.Nom.ReadOnly = True
        '
        'type
        '
        Me.type.HeaderText = "Type"
        Me.type.Name = "type"
        Me.type.ReadOnly = True
        Me.type.Width = 120
        '
        'libellé
        '
        Me.libellé.HeaderText = "Libellé"
        Me.libellé.Name = "libellé"
        Me.libellé.ReadOnly = True
        Me.libellé.Width = 120
        '
        'quantité
        '
        Me.quantité.HeaderText = "Quantité"
        Me.quantité.Name = "quantité"
        Me.quantité.ReadOnly = True
        '
        'mantant
        '
        Me.mantant.HeaderText = "Mantant"
        Me.mantant.Name = "mantant"
        Me.mantant.ReadOnly = True
        Me.mantant.Width = 120
        '
        'Consulté_Journal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(842, 503)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.cb_annee)
        Me.Controls.Add(Me.lb_montant)
        Me.Controls.Add(Me.tb_montant)
        Me.Controls.Add(Me.bt_Afficher_Montant_Totale)
        Me.Controls.Add(Me.bt_Annuler)
        Me.Controls.Add(Me.RE)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_journal)
        Me.Name = "Consulté_Journal"
        Me.Text = "Consulté_Journal"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_journal As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents bt_Annuler As System.Windows.Forms.Button
    Friend WithEvents RE As System.Windows.Forms.Button
    Friend WithEvents bt_Afficher_Montant_Totale As System.Windows.Forms.Button
    Friend WithEvents tb_montant As System.Windows.Forms.TextBox
    Friend WithEvents lb_montant As System.Windows.Forms.Label
    Friend WithEvents cb_annee As System.Windows.Forms.ComboBox
    Friend WithEvents bt_Quitter As Button
    Friend WithEvents Date_entrés_sorties As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents type As DataGridViewTextBoxColumn
    Friend WithEvents libellé As DataGridViewTextBoxColumn
    Friend WithEvents quantité As DataGridViewTextBoxColumn
    Friend WithEvents mantant As DataGridViewTextBoxColumn
End Class
