<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Controle_De_Besoin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Controle_De_Besoin))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cb__Nom_Evenement = New System.Windows.Forms.ComboBox()
        Me.lb_Nom_Evenement = New System.Windows.Forms.Label()
        Me.bt_Afficher = New System.Windows.Forms.Button()
        Me.bt_Retour = New System.Windows.Forms.Button()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        Me.ID_Materiel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prix_Estime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightYellow
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Materiel, Me.Nom, Me.Type, Me.Quantite, Me.Prix_Estime})
        Me.DataGridView1.Location = New System.Drawing.Point(169, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(543, 257)
        Me.DataGridView1.TabIndex = 0
        '
        'cb__Nom_Evenement
        '
        Me.cb__Nom_Evenement.FormattingEnabled = True
        Me.cb__Nom_Evenement.Location = New System.Drawing.Point(347, 34)
        Me.cb__Nom_Evenement.Name = "cb__Nom_Evenement"
        Me.cb__Nom_Evenement.Size = New System.Drawing.Size(156, 21)
        Me.cb__Nom_Evenement.TabIndex = 91
        '
        'lb_Nom_Evenement
        '
        Me.lb_Nom_Evenement.AutoSize = True
        Me.lb_Nom_Evenement.BackColor = System.Drawing.Color.Yellow
        Me.lb_Nom_Evenement.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lb_Nom_Evenement.Location = New System.Drawing.Point(218, 37)
        Me.lb_Nom_Evenement.Name = "lb_Nom_Evenement"
        Me.lb_Nom_Evenement.Size = New System.Drawing.Size(86, 13)
        Me.lb_Nom_Evenement.TabIndex = 90
        Me.lb_Nom_Evenement.Text = "Nom Evenement"
        '
        'bt_Afficher
        '
        Me.bt_Afficher.BackColor = System.Drawing.Color.Green
        Me.bt_Afficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Afficher.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Afficher.ForeColor = System.Drawing.Color.White
        Me.bt_Afficher.Location = New System.Drawing.Point(550, 24)
        Me.bt_Afficher.Name = "bt_Afficher"
        Me.bt_Afficher.Size = New System.Drawing.Size(105, 34)
        Me.bt_Afficher.TabIndex = 92
        Me.bt_Afficher.Text = "Afficher"
        Me.bt_Afficher.UseVisualStyleBackColor = False
        '
        'bt_Retour
        '
        Me.bt_Retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Retour.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Retour.ForeColor = System.Drawing.Color.White
        Me.bt_Retour.Location = New System.Drawing.Point(31, 341)
        Me.bt_Retour.Name = "bt_Retour"
        Me.bt_Retour.Size = New System.Drawing.Size(105, 29)
        Me.bt_Retour.TabIndex = 93
        Me.bt_Retour.Text = "Retour"
        Me.bt_Retour.UseVisualStyleBackColor = False
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(725, 341)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(105, 29)
        Me.bt_Quitter.TabIndex = 94
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'ID_Materiel
        '
        Me.ID_Materiel.HeaderText = "ID_Matériel"
        Me.ID_Materiel.Name = "ID_Materiel"
        Me.ID_Materiel.ReadOnly = True
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
        'Quantite
        '
        Me.Quantite.HeaderText = "Quantité"
        Me.Quantite.Name = "Quantite"
        Me.Quantite.ReadOnly = True
        '
        'Prix_Estime
        '
        Me.Prix_Estime.HeaderText = "Prix_Estimé"
        Me.Prix_Estime.Name = "Prix_Estime"
        Me.Prix_Estime.ReadOnly = True
        '
        'Controle_De_Besoin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(842, 503)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.bt_Retour)
        Me.Controls.Add(Me.bt_Afficher)
        Me.Controls.Add(Me.cb__Nom_Evenement)
        Me.Controls.Add(Me.lb_Nom_Evenement)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Controle_De_Besoin"
        Me.Text = "Controle_De_Besoin"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cb__Nom_Evenement As ComboBox
    Friend WithEvents lb_Nom_Evenement As Label
    Friend WithEvents bt_Afficher As Button
    Friend WithEvents bt_Retour As Button
    Friend WithEvents bt_Quitter As Button
    Friend WithEvents ID_Materiel As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents Quantite As DataGridViewTextBoxColumn
    Friend WithEvents Prix_Estime As DataGridViewTextBoxColumn
End Class
