
Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types



Public Class Accueil

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BQ.Click
        Me.Close()
        connexion.Close()

    End Sub

 

   

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles B1.Click
        lb.Text = ""
        President_et_Vise_Président.Show()
        Me.Hide()

    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        lb.Text = ""
        President_et_Vise_Président.Show()
        Me.Hide()
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        lb.Text = ""
        Rebrique_Communication.Show()
        Me.Hide()
    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        lb.Text = ""
        Rebrique_Evenementiel.Show()
        Me.Hide()
    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        lb.Text = ""
        Rebrique_Ressources_humaines.Show()
        Me.Hide()
    End Sub

    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        lb.Text = ""
        Rebrique_Sponsoring.Show()
        Me.Hide()
    End Sub

    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click
        lb.Text = ""
        Rebrique_Trésorier.Show()
        Me.Hide()
    End Sub

    Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.Click
        lb.Text = ""
        Rebrique_Secrétaire_Général.Show()
        Me.Hide()


    End Sub

  
    Private Sub BCH_Click(sender As Object, e As EventArgs) Handles BCH.Click
        lb.Text = ""
        connexion.Show()
        Me.Hide()



    End Sub

   

    Private Sub bt_Plan_Génerale_Click(sender As Object, e As EventArgs) Handles bt_Plan_Génerale.Click
        lb.Text = ""
        Plan_générale.Show()
        Me.Hide()
        'firascampos@gmail.com
    End Sub


    Dim x As Integer
    Dim y As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        x = x + 1




        If x = 10 Then
            Picture1.Image = My.Resources._9

        End If
        If x = 30 Then
            Picture1.Image = My.Resources._8

        End If
        If x = 50 Then
            Picture1.Image = My.Resources._7

        End If
        If x = 70 Then
            Picture1.Image = My.Resources._3
        End If
        If x = 90 Then
            Picture1.Image = My.Resources._1

        End If
        If x = 110 Then
            Picture1.Image = My.Resources._5

        End If
        If x = 130 Then
            Picture1.Image = My.Resources._9

        End If
        If x = 150 Then
            Picture1.Image = My.Resources._2

        End If
        If x = 170 Then
            Picture1.Image = My.Resources._4

        End If

        If x = 190 Then
            Picture1.Image = My.Resources._6

        End If
        If x = 200 Then
            Picture1.Image = My.Resources._10
            x = 0
        End If


    End Sub

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        If lb.Text <> "" Then

            Dim xe As String = "data source=xe;user id=system;password=firas123;"
            Dim con As New OracleConnection(xe)
            con.Open()
            Dim parm As New OracleParameter
            parm.OracleDbType = OracleDbType.Int64
            parm.Value = lb.Text
            Dim cmd As New OracleCommand
            cmd.Connection = con
            cmd.Parameters.Add(parm)
            cmd.CommandText = "select nom_membre from membre where NCIN_MEMBRE=:1"
            cmd.CommandType = CommandType.Text
            Dim dr As OracleDataReader = cmd.ExecuteReader()
            dr.Read()

            lb.Text = dr.Item("nom_membre")
            con.Dispose()
            Dim sapi
            sapi = CreateObject("sapi.spvoice")
            sapi.speak("bienvenue " + lb.Text + "!")
        End If

    End Sub


    Dim i As Integer

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        i = i + 1
        y = y + 1
        If y = 1 Then
            Picture2.Image = My.Resources.t1


        End If
        If y = 2 Then
            Picture2.Image = My.Resources.t2
        End If
        If y = 3 Then
            Picture2.Image = My.Resources.t3

        End If
        If y = 3 Then
            Picture2.Image = My.Resources.t4
            y = 0
        End If

        Picture2.Location = New Point(763 + i, 169)
        While Picture2.Left = 1000
            Picture2.Location = New System.Drawing.Point(763, 169)
        End While
        ''problemeatiqut()
        ''besoin de appli fonctonnel(site marchand: securite) et non fonctionne

        ''conception (merise diapo MCD
        ''originalite de application
        ''qustion technique
        ''decloncheur,exception,

    End Sub

    Private Sub Picture1_Click(sender As Object, e As EventArgs) Handles Picture1.Click
        Timer1.Start()
    End Sub


    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        lb.Text = ""
        Gestion_des_évenements.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        lb.Text = ""
        Gestion_des_invités.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        lb.Text = ""
        Gestion_des_évenements.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        lb.Text = ""
        Gestion_des_invités.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        lb.Text = ""
        Ajout_inscrit.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        lb.Text = ""
        Gestion_des_Materiel.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        lb.Text = ""
        Presence_Inscrit.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        lb.Text = ""
        Presence_Invité.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem15.Click
        lb.Text = ""
        Consulté_Journal.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem16.Click
        lb.Text = ""
        Gestion_des_Entrées_Sorties.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem19_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem19.Click
        lb.Text = ""
        Gestion_des_Membres_RH.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem20_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem20.Click
        lb.Text = ""
        Gestion_des_Notes.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem21_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem21.Click
        lb.Text = ""
        Gestion_des_absences_RH.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem22_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem22.Click
        lb.Text = ""
        Productivité.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem29_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem29.Click
        lb.Text = ""
        Responsable_Communication.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem30_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem30.Click
        lb.Text = ""
        Membre_Communicatuin.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem33_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem33.Click
        lb.Text = ""
        Gestion_des_Membres_Sonsoring.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem34_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem34.Click
        lb.Text = ""
        Gestion_des_Sponsors.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem35_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem35.Click
        lb.Text = ""
        Membre_Sponsoring.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem37_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem37.Click
        lb.Text = ""
        Responsable_Evenementiel.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem38_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem38.Click
        lb.Text = ""
        Membre_Evenementiel.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem40_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem40.Click
        lb.Text = ""
        Plan_communication.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem41_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem41.Click
        lb.Text = ""
        Plan_sponsoring.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem42_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem42.Click
        lb.Text = ""
        Plan_Evénementiel.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem24_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem24.Click
        lb.Text = ""
        Gestion_des_Membres_RH.Show()
        Me.Hide()


    End Sub

    Private Sub ToolStripMenuItem25_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem25.Click
        lb.Text = ""
        Gestion_des_Notes.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem26_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem26.Click
        lb.Text = ""
        Gestion_des_absences_RH.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem27_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem27.Click
        lb.Text = ""
        Productivité.Show()
        Me.Hide()

    End Sub
End Class