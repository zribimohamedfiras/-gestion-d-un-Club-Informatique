<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productivité
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productivité))
        Me.bt_departements = New System.Windows.Forms.Button()
        Me.Button1abt_departement_evenementiel = New System.Windows.Forms.Button()
        Me.bt_Departement_Communication = New System.Windows.Forms.Button()
        Me.bt_Departement_Sponsoring = New System.Windows.Forms.Button()
        Me.bt_retour = New System.Windows.Forms.Button()
        Me.bt_Quiter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bt_departements
        '
        Me.bt_departements.BackColor = System.Drawing.Color.Green
        Me.bt_departements.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_departements.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_departements.ForeColor = System.Drawing.Color.White
        Me.bt_departements.Location = New System.Drawing.Point(268, 102)
        Me.bt_departements.Name = "bt_departements"
        Me.bt_departements.Size = New System.Drawing.Size(319, 46)
        Me.bt_departements.TabIndex = 0
        Me.bt_departements.Text = "Departements"
        Me.bt_departements.UseVisualStyleBackColor = False
        '
        'Button1abt_departement_evenementiel
        '
        Me.Button1abt_departement_evenementiel.BackColor = System.Drawing.Color.Green
        Me.Button1abt_departement_evenementiel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1abt_departement_evenementiel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1abt_departement_evenementiel.ForeColor = System.Drawing.Color.White
        Me.Button1abt_departement_evenementiel.Location = New System.Drawing.Point(268, 164)
        Me.Button1abt_departement_evenementiel.Name = "Button1abt_departement_evenementiel"
        Me.Button1abt_departement_evenementiel.Size = New System.Drawing.Size(319, 46)
        Me.Button1abt_departement_evenementiel.TabIndex = 1
        Me.Button1abt_departement_evenementiel.Text = "Departement Evenementiel"
        Me.Button1abt_departement_evenementiel.UseVisualStyleBackColor = False
        '
        'bt_Departement_Communication
        '
        Me.bt_Departement_Communication.BackColor = System.Drawing.Color.Green
        Me.bt_Departement_Communication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Departement_Communication.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Departement_Communication.ForeColor = System.Drawing.Color.White
        Me.bt_Departement_Communication.Location = New System.Drawing.Point(268, 228)
        Me.bt_Departement_Communication.Name = "bt_Departement_Communication"
        Me.bt_Departement_Communication.Size = New System.Drawing.Size(319, 46)
        Me.bt_Departement_Communication.TabIndex = 2
        Me.bt_Departement_Communication.Text = "Departement Communication"
        Me.bt_Departement_Communication.UseVisualStyleBackColor = False
        '
        'bt_Departement_Sponsoring
        '
        Me.bt_Departement_Sponsoring.BackColor = System.Drawing.Color.Green
        Me.bt_Departement_Sponsoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Departement_Sponsoring.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Departement_Sponsoring.ForeColor = System.Drawing.Color.White
        Me.bt_Departement_Sponsoring.Location = New System.Drawing.Point(268, 291)
        Me.bt_Departement_Sponsoring.Name = "bt_Departement_Sponsoring"
        Me.bt_Departement_Sponsoring.Size = New System.Drawing.Size(319, 46)
        Me.bt_Departement_Sponsoring.TabIndex = 3
        Me.bt_Departement_Sponsoring.Text = "Departement Sponsoring"
        Me.bt_Departement_Sponsoring.UseVisualStyleBackColor = False
        '
        'bt_retour
        '
        Me.bt_retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_retour.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_retour.ForeColor = System.Drawing.Color.White
        Me.bt_retour.Location = New System.Drawing.Point(501, 380)
        Me.bt_retour.Name = "bt_retour"
        Me.bt_retour.Size = New System.Drawing.Size(86, 26)
        Me.bt_retour.TabIndex = 4
        Me.bt_retour.Text = "Retour"
        Me.bt_retour.UseVisualStyleBackColor = False
        '
        'bt_Quiter
        '
        Me.bt_Quiter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quiter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quiter.ForeColor = System.Drawing.Color.White
        Me.bt_Quiter.Location = New System.Drawing.Point(268, 380)
        Me.bt_Quiter.Name = "bt_Quiter"
        Me.bt_Quiter.Size = New System.Drawing.Size(86, 26)
        Me.bt_Quiter.TabIndex = 5
        Me.bt_Quiter.Text = "Quiter"
        Me.bt_Quiter.UseVisualStyleBackColor = False
        '
        'Productivité
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(842, 503)
        Me.Controls.Add(Me.bt_Quiter)
        Me.Controls.Add(Me.bt_retour)
        Me.Controls.Add(Me.bt_Departement_Sponsoring)
        Me.Controls.Add(Me.bt_Departement_Communication)
        Me.Controls.Add(Me.Button1abt_departement_evenementiel)
        Me.Controls.Add(Me.bt_departements)
        Me.Name = "Productivité"
        Me.Text = "Productivité"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bt_departements As Button
    Friend WithEvents Button1abt_departement_evenementiel As Button
    Friend WithEvents bt_Departement_Communication As Button
    Friend WithEvents bt_Departement_Sponsoring As Button
    Friend WithEvents bt_retour As Button
    Friend WithEvents bt_Quiter As Button
End Class
