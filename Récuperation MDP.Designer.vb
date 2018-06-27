<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Récuperation_MDP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Récuperation_MDP))
        Me.bt_connect = New System.Windows.Forms.Button()
        Me.bt_enregistrer = New System.Windows.Forms.Button()
        Me.bt_chercher = New System.Windows.Forms.Button()
        Me.bt_modifier = New System.Windows.Forms.Button()
        Me.bt_supprimer = New System.Windows.Forms.Button()
        Me.bt_ajouter = New System.Windows.Forms.Button()
        Me.bt_recuper = New System.Windows.Forms.Button()
        Me.bt_Annuler1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_Reponse1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_Question1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.s = New System.Windows.Forms.GroupBox()
        Me.tb_Reponse = New System.Windows.Forms.TextBox()
        Me.cb_Question = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_mdp = New System.Windows.Forms.TextBox()
        Me.tb_user = New System.Windows.Forms.TextBox()
        Me.Annuler = New System.Windows.Forms.Button()
        Me.bt_Quitter = New System.Windows.Forms.Button()
        Me.bt_Retour = New System.Windows.Forms.Button()
        Me.s.SuspendLayout()
        Me.SuspendLayout()
        '
        'bt_connect
        '
        Me.bt_connect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_connect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_connect.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_connect.ForeColor = System.Drawing.Color.White
        Me.bt_connect.Location = New System.Drawing.Point(266, 462)
        Me.bt_connect.Name = "bt_connect"
        Me.bt_connect.Size = New System.Drawing.Size(82, 31)
        Me.bt_connect.TabIndex = 54
        Me.bt_connect.Text = "Connecter"
        Me.bt_connect.UseVisualStyleBackColor = False
        '
        'bt_enregistrer
        '
        Me.bt_enregistrer.BackColor = System.Drawing.Color.Green
        Me.bt_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_enregistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_enregistrer.ForeColor = System.Drawing.Color.White
        Me.bt_enregistrer.Location = New System.Drawing.Point(759, 332)
        Me.bt_enregistrer.Name = "bt_enregistrer"
        Me.bt_enregistrer.Size = New System.Drawing.Size(88, 37)
        Me.bt_enregistrer.TabIndex = 53
        Me.bt_enregistrer.Text = "Enregistrer"
        Me.bt_enregistrer.UseVisualStyleBackColor = False
        '
        'bt_chercher
        '
        Me.bt_chercher.BackColor = System.Drawing.Color.Green
        Me.bt_chercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_chercher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_chercher.ForeColor = System.Drawing.Color.White
        Me.bt_chercher.Location = New System.Drawing.Point(759, 387)
        Me.bt_chercher.Name = "bt_chercher"
        Me.bt_chercher.Size = New System.Drawing.Size(88, 25)
        Me.bt_chercher.TabIndex = 52
        Me.bt_chercher.Text = "Chercher"
        Me.bt_chercher.UseVisualStyleBackColor = False
        '
        'bt_modifier
        '
        Me.bt_modifier.BackColor = System.Drawing.Color.Green
        Me.bt_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_modifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_modifier.ForeColor = System.Drawing.Color.White
        Me.bt_modifier.Location = New System.Drawing.Point(759, 242)
        Me.bt_modifier.Name = "bt_modifier"
        Me.bt_modifier.Size = New System.Drawing.Size(88, 25)
        Me.bt_modifier.TabIndex = 51
        Me.bt_modifier.Text = "Modifier"
        Me.bt_modifier.UseVisualStyleBackColor = False
        '
        'bt_supprimer
        '
        Me.bt_supprimer.BackColor = System.Drawing.Color.Green
        Me.bt_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_supprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_supprimer.ForeColor = System.Drawing.Color.White
        Me.bt_supprimer.Location = New System.Drawing.Point(759, 280)
        Me.bt_supprimer.Name = "bt_supprimer"
        Me.bt_supprimer.Size = New System.Drawing.Size(88, 30)
        Me.bt_supprimer.TabIndex = 50
        Me.bt_supprimer.Text = "Supprimer"
        Me.bt_supprimer.UseVisualStyleBackColor = False
        '
        'bt_ajouter
        '
        Me.bt_ajouter.BackColor = System.Drawing.Color.Green
        Me.bt_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_ajouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ajouter.ForeColor = System.Drawing.Color.White
        Me.bt_ajouter.Location = New System.Drawing.Point(759, 200)
        Me.bt_ajouter.Name = "bt_ajouter"
        Me.bt_ajouter.Size = New System.Drawing.Size(88, 25)
        Me.bt_ajouter.TabIndex = 49
        Me.bt_ajouter.Text = "Ajouter"
        Me.bt_ajouter.UseVisualStyleBackColor = False
        '
        'bt_recuper
        '
        Me.bt_recuper.BackColor = System.Drawing.Color.Green
        Me.bt_recuper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_recuper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_recuper.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_recuper.ForeColor = System.Drawing.Color.White
        Me.bt_recuper.Location = New System.Drawing.Point(541, 122)
        Me.bt_recuper.Name = "bt_recuper"
        Me.bt_recuper.Size = New System.Drawing.Size(170, 26)
        Me.bt_recuper.TabIndex = 48
        Me.bt_recuper.Text = "Recupération MDP"
        Me.bt_recuper.UseVisualStyleBackColor = False
        '
        'bt_Annuler1
        '
        Me.bt_Annuler1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Annuler1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_Annuler1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_Annuler1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_Annuler1.ForeColor = System.Drawing.Color.White
        Me.bt_Annuler1.Location = New System.Drawing.Point(384, 127)
        Me.bt_Annuler1.Name = "bt_Annuler1"
        Me.bt_Annuler1.Size = New System.Drawing.Size(97, 23)
        Me.bt_Annuler1.TabIndex = 47
        Me.bt_Annuler1.Text = "Annuler"
        Me.bt_Annuler1.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(40, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(157, 21)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "*Recupération MDP*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(40, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(459, 21)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "*Ou Creé un nouveau user avec des nouvaux   Identification*"
        '
        'tb_Reponse1
        '
        Me.tb_Reponse1.Location = New System.Drawing.Point(384, 98)
        Me.tb_Reponse1.Name = "tb_Reponse1"
        Me.tb_Reponse1.Size = New System.Drawing.Size(327, 20)
        Me.tb_Reponse1.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Yellow
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(29, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 21)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Réponse"
        '
        'tb_Question1
        '
        Me.tb_Question1.Location = New System.Drawing.Point(384, 50)
        Me.tb_Question1.Name = "tb_Question1"
        Me.tb_Question1.Size = New System.Drawing.Size(287, 20)
        Me.tb_Question1.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(29, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 21)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Question de Sécurité"
        '
        's
        '
        Me.s.BackColor = System.Drawing.Color.LightSkyBlue
        Me.s.Controls.Add(Me.tb_Reponse)
        Me.s.Controls.Add(Me.cb_Question)
        Me.s.Controls.Add(Me.Label2)
        Me.s.Controls.Add(Me.Label6)
        Me.s.Controls.Add(Me.Label3)
        Me.s.Controls.Add(Me.Label4)
        Me.s.Controls.Add(Me.tb_mdp)
        Me.s.Controls.Add(Me.tb_user)
        Me.s.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s.ForeColor = System.Drawing.Color.Navy
        Me.s.Location = New System.Drawing.Point(10, 180)
        Me.s.Name = "s"
        Me.s.Size = New System.Drawing.Size(670, 255)
        Me.s.TabIndex = 40
        Me.s.TabStop = False
        Me.s.Text = "Nouveau Identification"
        '
        'tb_Reponse
        '
        Me.tb_Reponse.Location = New System.Drawing.Point(411, 186)
        Me.tb_Reponse.Name = "tb_Reponse"
        Me.tb_Reponse.Size = New System.Drawing.Size(250, 29)
        Me.tb_Reponse.TabIndex = 38
        '
        'cb_Question
        '
        Me.cb_Question.FormattingEnabled = True
        Me.cb_Question.Items.AddRange(New Object() {"Quelle est la marque de votre voiture ?", "quelle est votre EDI preferer?", "quelle est votre sport preféré?", "quelle est votre meilleur amie?", "quelle est le nom de votre langage de programmation prefere?"})
        Me.cb_Question.Location = New System.Drawing.Point(411, 139)
        Me.cb_Question.Name = "cb_Question"
        Me.cb_Question.Size = New System.Drawing.Size(250, 30)
        Me.cb_Question.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(18, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 21)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Réponse"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Yellow
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(19, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 21)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Question de Sécurité"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(19, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Entrer un nouveau User Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(19, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(245, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Entrer un nouveau Mot de Passe"
        '
        'tb_mdp
        '
        Me.tb_mdp.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_mdp.Location = New System.Drawing.Point(411, 94)
        Me.tb_mdp.Name = "tb_mdp"
        Me.tb_mdp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.tb_mdp.Size = New System.Drawing.Size(250, 28)
        Me.tb_mdp.TabIndex = 9
        Me.tb_mdp.UseSystemPasswordChar = True
        Me.tb_mdp.WordWrap = False
        '
        'tb_user
        '
        Me.tb_user.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_user.Location = New System.Drawing.Point(411, 47)
        Me.tb_user.Name = "tb_user"
        Me.tb_user.Size = New System.Drawing.Size(250, 28)
        Me.tb_user.TabIndex = 8
        '
        'Annuler
        '
        Me.Annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Annuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Annuler.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Annuler.ForeColor = System.Drawing.Color.White
        Me.Annuler.Location = New System.Drawing.Point(100, 462)
        Me.Annuler.Name = "Annuler"
        Me.Annuler.Size = New System.Drawing.Size(97, 31)
        Me.Annuler.TabIndex = 39
        Me.Annuler.Text = "Annuler"
        Me.Annuler.UseVisualStyleBackColor = False
        '
        'bt_Quitter
        '
        Me.bt_Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Quitter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Quitter.ForeColor = System.Drawing.Color.White
        Me.bt_Quitter.Location = New System.Drawing.Point(740, 470)
        Me.bt_Quitter.Name = "bt_Quitter"
        Me.bt_Quitter.Size = New System.Drawing.Size(75, 23)
        Me.bt_Quitter.TabIndex = 55
        Me.bt_Quitter.Text = "Quitter"
        Me.bt_Quitter.UseVisualStyleBackColor = False
        '
        'bt_Retour
        '
        Me.bt_Retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Retour.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Retour.ForeColor = System.Drawing.Color.White
        Me.bt_Retour.Location = New System.Drawing.Point(626, 470)
        Me.bt_Retour.Name = "bt_Retour"
        Me.bt_Retour.Size = New System.Drawing.Size(75, 23)
        Me.bt_Retour.TabIndex = 56
        Me.bt_Retour.Text = "Retour"
        Me.bt_Retour.UseVisualStyleBackColor = False
        '
        'Récuperation_MDP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(887, 505)
        Me.Controls.Add(Me.bt_Retour)
        Me.Controls.Add(Me.bt_Quitter)
        Me.Controls.Add(Me.bt_connect)
        Me.Controls.Add(Me.bt_enregistrer)
        Me.Controls.Add(Me.bt_chercher)
        Me.Controls.Add(Me.bt_modifier)
        Me.Controls.Add(Me.bt_supprimer)
        Me.Controls.Add(Me.bt_ajouter)
        Me.Controls.Add(Me.bt_recuper)
        Me.Controls.Add(Me.bt_Annuler1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tb_Reponse1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tb_Question1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.s)
        Me.Controls.Add(Me.Annuler)
        Me.Name = "Récuperation_MDP"
        Me.Text = "Récuperation_MDP"
        Me.s.ResumeLayout(False)
        Me.s.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_connect As System.Windows.Forms.Button
    Friend WithEvents bt_enregistrer As System.Windows.Forms.Button
    Friend WithEvents bt_chercher As System.Windows.Forms.Button
    Friend WithEvents bt_modifier As System.Windows.Forms.Button
    Friend WithEvents bt_supprimer As System.Windows.Forms.Button
    Friend WithEvents bt_ajouter As System.Windows.Forms.Button
    Friend WithEvents bt_recuper As System.Windows.Forms.Button
    Friend WithEvents bt_Annuler1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tb_Reponse1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tb_Question1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents s As System.Windows.Forms.GroupBox
    Friend WithEvents tb_Reponse As System.Windows.Forms.TextBox
    Friend WithEvents cb_Question As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_mdp As System.Windows.Forms.TextBox
    Friend WithEvents tb_user As System.Windows.Forms.TextBox
    Friend WithEvents Annuler As System.Windows.Forms.Button
    Friend WithEvents bt_Quitter As Button
    Friend WithEvents bt_Retour As Button
End Class
