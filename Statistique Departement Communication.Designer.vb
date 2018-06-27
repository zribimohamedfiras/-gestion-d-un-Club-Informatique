<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statistique_Departement_Communication
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Statistique_Departement_Communication))
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bt_retour = New System.Windows.Forms.Button()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.Location = New System.Drawing.Point(51, 12)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(742, 363)
        Me.Chart1.TabIndex = 2
        Me.Chart1.Text = "Chart1"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nom, Me.Prenom, Me.Note})
        Me.DataGridView1.Location = New System.Drawing.Point(250, 176)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(343, 150)
        Me.DataGridView1.TabIndex = 3
        Me.DataGridView1.Visible = False
        '
        'Nom
        '
        Me.Nom.HeaderText = "Nom"
        Me.Nom.Name = "Nom"
        Me.Nom.ReadOnly = True
        '
        'Prenom
        '
        Me.Prenom.HeaderText = "Prenom"
        Me.Prenom.Name = "Prenom"
        Me.Prenom.ReadOnly = True
        '
        'Note
        '
        Me.Note.HeaderText = "Note"
        Me.Note.Name = "Note"
        Me.Note.ReadOnly = True
        '
        'bt_retour
        '
        Me.bt_retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_retour.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_retour.ForeColor = System.Drawing.Color.White
        Me.bt_retour.Location = New System.Drawing.Point(679, 401)
        Me.bt_retour.Name = "bt_retour"
        Me.bt_retour.Size = New System.Drawing.Size(75, 23)
        Me.bt_retour.TabIndex = 4
        Me.bt_retour.Text = "Retour"
        Me.bt_retour.UseVisualStyleBackColor = False
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(51, 401)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 5
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'Statistique_Departement_Communication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(842, 503)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.bt_retour)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "Statistique_Departement_Communication"
        Me.Text = "Statistique_Departement_Communication"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents Prenom As DataGridViewTextBoxColumn
    Friend WithEvents Note As DataGridViewTextBoxColumn
    Friend WithEvents bt_retour As Button
    Friend WithEvents bt_Quitter As Button
End Class
