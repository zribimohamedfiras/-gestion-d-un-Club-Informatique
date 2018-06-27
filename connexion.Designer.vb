<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class connexion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(connexion))
        Me.l_new = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MDP = New System.Windows.Forms.LinkLabel()
        Me.Annuler = New System.Windows.Forms.Button()
        Me.TB_NOM = New System.Windows.Forms.TextBox()
        Me.TB_MDP = New System.Windows.Forms.TextBox()
        Me.bt_connect = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'l_new
        '
        Me.l_new.AutoSize = True
        Me.l_new.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.l_new.Location = New System.Drawing.Point(250, 258)
        Me.l_new.Name = "l_new"
        Me.l_new.Size = New System.Drawing.Size(127, 13)
        Me.l_new.TabIndex = 25
        Me.l_new.TabStop = True
        Me.l_new.Text = "Creé un nouveau compte"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(204, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = " Nom d'utilisateur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(204, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Mot de Passe"
        '
        'MDP
        '
        Me.MDP.ActiveLinkColor = System.Drawing.Color.Yellow
        Me.MDP.AutoSize = True
        Me.MDP.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MDP.Location = New System.Drawing.Point(443, 258)
        Me.MDP.Name = "MDP"
        Me.MDP.Size = New System.Drawing.Size(111, 13)
        Me.MDP.TabIndex = 20
        Me.MDP.TabStop = True
        Me.MDP.Text = "Mot de Passe Oublié?"
        '
        'Annuler
        '
        Me.Annuler.BackColor = System.Drawing.Color.Green
        Me.Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Annuler.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Annuler.ForeColor = System.Drawing.Color.White
        Me.Annuler.Location = New System.Drawing.Point(446, 180)
        Me.Annuler.Name = "Annuler"
        Me.Annuler.Size = New System.Drawing.Size(108, 32)
        Me.Annuler.TabIndex = 19
        Me.Annuler.Text = "Annuler"
        Me.Annuler.UseVisualStyleBackColor = False
        '
        'TB_NOM
        '
        Me.TB_NOM.Location = New System.Drawing.Point(311, 78)
        Me.TB_NOM.Name = "TB_NOM"
        Me.TB_NOM.Size = New System.Drawing.Size(229, 20)
        Me.TB_NOM.TabIndex = 18
        '
        'TB_MDP
        '
        Me.TB_MDP.Location = New System.Drawing.Point(311, 135)
        Me.TB_MDP.Name = "TB_MDP"
        Me.TB_MDP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_MDP.Size = New System.Drawing.Size(229, 20)
        Me.TB_MDP.TabIndex = 17
        '
        'bt_connect
        '
        Me.bt_connect.BackColor = System.Drawing.Color.Green
        Me.bt_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_connect.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_connect.ForeColor = System.Drawing.Color.White
        Me.bt_connect.Location = New System.Drawing.Point(292, 180)
        Me.bt_connect.Name = "bt_connect"
        Me.bt_connect.Size = New System.Drawing.Size(108, 32)
        Me.bt_connect.TabIndex = 16
        Me.bt_connect.Text = "Connecter"
        Me.bt_connect.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(250, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(271, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = " de passe dans la Formulaire ci-dessous."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(162, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(466, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Pour Vous connecter, veuillez entrer votre Nom d'utilisateur et votre Mot"
        '
        'connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(797, 303)
        Me.Controls.Add(Me.l_new)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MDP)
        Me.Controls.Add(Me.Annuler)
        Me.Controls.Add(Me.TB_NOM)
        Me.Controls.Add(Me.TB_MDP)
        Me.Controls.Add(Me.bt_connect)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "connexion"
        Me.Text = "Connexion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents l_new As System.Windows.Forms.LinkLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MDP As System.Windows.Forms.LinkLabel
    Friend WithEvents Annuler As System.Windows.Forms.Button
    Friend WithEvents TB_NOM As System.Windows.Forms.TextBox
    Friend WithEvents TB_MDP As System.Windows.Forms.TextBox
    Friend WithEvents bt_connect As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
