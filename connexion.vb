Imports System.Data

Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types






Public Class connexion
    Dim somme As Integer = 4

    Function verif() As Boolean
        Dim v As Boolean = True
        If TB_NOM.Text = "" And Me.TB_NOM.Text Is Nothing Or Not IsNumeric(Me.TB_NOM.Text) Or TB_NOM.TextLength <> 7 Then

            v = False

        End If


        Return v

    End Function

   


    Private Sub Connect_Click(sender As Object, e As EventArgs) Handles bt_connect.Click
        If verif() Then


            Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123"
            Dim con As New OracleConnection(XE)
            con.Open()

            Dim login1 As New OracleParameter
            login1.OracleDbType = OracleDbType.Varchar2
            login1.Value = TB_NOM.Text

            Dim cmd1 As New OracleCommand
            cmd1.Connection = con
            cmd1.Parameters.Add(login1)


            cmd1.CommandText = "select * from utilisateur where LOGIN=:1 "
            cmd1.CommandType = CommandType.Text



            Dim dr1 As OracleDataReader = cmd1.ExecuteReader()

            If dr1.Read() Then



                Dim login As New OracleParameter
                login.OracleDbType = OracleDbType.Varchar2
                login.Value = TB_NOM.Text

                Dim mdp As New OracleParameter
                mdp.OracleDbType = OracleDbType.Varchar2
                mdp.Value = TB_MDP.Text




                Dim cmd As New OracleCommand
                cmd.Connection = con
                cmd.Parameters.Add(login)
                cmd.Parameters.Add(mdp)

                cmd.CommandText = "select * from utilisateur where LOGIN=:1 and MOTDEPASSE=:2"
                cmd.CommandType = CommandType.Text



                Dim dr As OracleDataReader = cmd.ExecuteReader()



                If dr.Read() Then
                    Accueil.lb.Text = TB_NOM.Text

                    Dim login5 As New OracleParameter
                    login5.OracleDbType = OracleDbType.Varchar2
                    login5.Value = TB_NOM.Text

                    Dim cmd5 As New OracleCommand
                    cmd5.Connection = con
                    cmd5.Parameters.Add(login5)

                    Dim ch As String
                    Dim ch1 As String
                    cmd5.CommandText = "select * from membre m,UTILISATEUR u,DEPARTEMENT_CLUB d where u.LOGIN=m.NCIN_MEMBRE and m.ID_DEPARTEMENT=d.ID_DEPARTEMENT and m.NCIN_MEMBRE=:1 "
                    cmd5.CommandType = CommandType.Text
                    Dim dr5 As OracleDataReader = cmd5.ExecuteReader()
                    If dr5.Read Then


                        ch = dr5.Item("FONCTION").ToString

                        ch1 = dr5.Item("NOM_DEPARTEMENT").ToString
                        ''nom departement
                        If ch = "presedente" Then
                            Me.Hide()
                            Accueil.Show()


                        End If

                        If ch = "secretaire generale" Then
                            Me.Hide()

                            Accueil.Show()

                            My.Forms.Accueil.B2.Enabled = False
                            My.Forms.Accueil.B1.Enabled = False
                            My.Forms.Accueil.B8.Enabled = True
                            My.Forms.Accueil.B7.Enabled = False
                            My.Forms.Accueil.B5.Enabled = False
                            My.Forms.Accueil.B3.Enabled = False
                            My.Forms.Accueil.B4.Enabled = False
                            My.Forms.Accueil.B6.Enabled = False
                            My.Forms.Accueil.bt_Plan_Génerale.Enabled = False




                        End If
                        If ch1 = "Trésorier" Then
                            Me.Hide()

                            Accueil.Show()
                            My.Forms.Accueil.B2.Enabled = False
                            My.Forms.Accueil.B1.Enabled = False
                            My.Forms.Accueil.B8.Enabled = False
                            My.Forms.Accueil.B7.Enabled = True
                            My.Forms.Accueil.B5.Enabled = False
                            My.Forms.Accueil.B3.Enabled = False
                            My.Forms.Accueil.B4.Enabled = False
                            My.Forms.Accueil.B6.Enabled = False
                            My.Forms.Accueil.bt_Plan_Génerale.Enabled = False


                        End If

                        If ch = "vis_presedente" Then
                            Me.Hide()

                            Accueil.Show()


                        End If
                        If ch = "responsable" Then

                            Select Case (ch1)
                                Case "evenmentiel"
                                    Me.Hide()

                                    Accueil.Show()

                                    My.Forms.Accueil.B2.Enabled = False
                                    My.Forms.Accueil.B1.Enabled = False
                                    My.Forms.Accueil.B8.Enabled = False
                                    My.Forms.Accueil.B7.Enabled = False
                                    My.Forms.Accueil.B5.Enabled = False
                                    My.Forms.Accueil.B3.Enabled = False
                                    My.Forms.Accueil.B4.Enabled = True
                                    My.Forms.Accueil.B6.Enabled = False
                                    My.Forms.Accueil.bt_Plan_Génerale.Enabled = False


                                Case "communication"
                                    Me.Hide()
                                    Accueil.Show()


                                    My.Forms.Accueil.B2.Enabled = False
                                    My.Forms.Accueil.B1.Enabled = False
                                    My.Forms.Accueil.B8.Enabled = False
                                    My.Forms.Accueil.B7.Enabled = False
                                    My.Forms.Accueil.B5.Enabled = False
                                    My.Forms.Accueil.B3.Enabled = True
                                    My.Forms.Accueil.B4.Enabled = False
                                    My.Forms.Accueil.B6.Enabled = False
                                    My.Forms.Accueil.bt_Plan_Génerale.Enabled = False
                                Case "sponsoring"
                                    Me.Hide()

                                    Accueil.Show()

                                    My.Forms.Accueil.B2.Enabled = False
                                    My.Forms.Accueil.B1.Enabled = False
                                    My.Forms.Accueil.B8.Enabled = False
                                    My.Forms.Accueil.B7.Enabled = False
                                    My.Forms.Accueil.B5.Enabled = False
                                    My.Forms.Accueil.B3.Enabled = False
                                    My.Forms.Accueil.B4.Enabled = False
                                    My.Forms.Accueil.B6.Enabled = True
                                    My.Forms.Accueil.bt_Plan_Génerale.Enabled = False
                                Case "Rossource humains"
                                    Me.Hide()

                                    Accueil.Show()


                                    My.Forms.Accueil.B2.Enabled = False
                                    My.Forms.Accueil.B1.Enabled = False
                                    My.Forms.Accueil.B8.Enabled = False
                                    My.Forms.Accueil.B7.Enabled = False
                                    My.Forms.Accueil.B5.Enabled = True
                                    My.Forms.Accueil.B3.Enabled = False
                                    My.Forms.Accueil.B4.Enabled = False
                                    My.Forms.Accueil.B6.Enabled = False
                                    My.Forms.Accueil.bt_Plan_Génerale.Enabled = False
                            End Select

                        Else

                            Select Case (ch1)
                                Case "evenmentiel"
                                    Me.Hide()

                                    Accueil.Show()
                                    My.Forms.Accueil.B2.Enabled = False
                                    My.Forms.Accueil.B1.Enabled = False
                                    My.Forms.Accueil.B8.Enabled = False
                                    My.Forms.Accueil.B7.Enabled = False
                                    My.Forms.Accueil.B5.Enabled = False
                                    My.Forms.Accueil.B3.Enabled = False
                                    My.Forms.Accueil.B4.Enabled = True
                                    My.Forms.Accueil.B6.Enabled = False
                                    My.Forms.Accueil.bt_Plan_Génerale.Enabled = False
                                    My.Forms.Rebrique_Evenementiel.bt_responsable.Enabled = False


                                Case "communication"
                                    Me.Hide()

                                    Accueil.Show()

                                    My.Forms.Accueil.B2.Enabled = False
                                    My.Forms.Accueil.B1.Enabled = False
                                    My.Forms.Accueil.B8.Enabled = False
                                    My.Forms.Accueil.B7.Enabled = False
                                    My.Forms.Accueil.B5.Enabled = False
                                    My.Forms.Accueil.B3.Enabled = True
                                    My.Forms.Accueil.B4.Enabled = False
                                    My.Forms.Accueil.B6.Enabled = False
                                    My.Forms.Accueil.bt_Plan_Génerale.Enabled = False
                                    My.Forms.Rebrique_Communication.bt_Gestion_Membres.Enabled = False
                                Case "sponsoring"
                                    Me.Hide()

                                    Accueil.Show()
                                    My.Forms.Accueil.B2.Enabled = False
                                    My.Forms.Accueil.B1.Enabled = False
                                    My.Forms.Accueil.B8.Enabled = False
                                    My.Forms.Accueil.B7.Enabled = False
                                    My.Forms.Accueil.B5.Enabled = False
                                    My.Forms.Accueil.B3.Enabled = False
                                    My.Forms.Accueil.B4.Enabled = False
                                    My.Forms.Accueil.B6.Enabled = True
                                    My.Forms.Accueil.bt_Plan_Génerale.Enabled = False
                                Case "Rossource humains"
                                    Me.Hide()

                                    Accueil.Show()
                                    My.Forms.Rebrique_Ressources_humaines.Retour.Enabled = False
                                    My.Forms.Accueil.B2.Enabled = False
                                    My.Forms.Accueil.B1.Enabled = False
                                    My.Forms.Accueil.B8.Enabled = False
                                    My.Forms.Accueil.B7.Enabled = False
                                    My.Forms.Accueil.B5.Enabled = True
                                    My.Forms.Accueil.B3.Enabled = False
                                    My.Forms.Accueil.B4.Enabled = False
                                    My.Forms.Accueil.B6.Enabled = False
                                    My.Forms.Accueil.bt_Plan_Génerale.Enabled = False
                            End Select
                        End If


                    End If






                    TB_MDP.Text = ""
                    TB_NOM.Text = ""




                    TB_NOM.BackColor = Color.White
                    TB_MDP.BackColor = Color.White

                Else
                    somme = somme - 1
                    MsgBox("Mot De passe Incorrect ? Il vous reste " & somme & "tentative")
                    If somme <> 0 Then

                        TB_MDP.Text = ""
                        TB_NOM.BackColor = Color.White
                        TB_MDP.BackColor = Color.White
                    End If

                    If somme = 0 Then
                        TB_MDP.Enabled = False
                        TB_NOM.Enabled = False
                        bt_connect.Enabled = False
                        Annuler.Enabled = False
                        MsgBox("Vous avez utiliser ces Tentatives Cliquer sur Mot de passe oublier Sinon Creé un nouveau compte  ")


                    End If
                End If

            Else
                MsgBox("Ecrire votre Login correct!")
            End If
        Else

            MsgBox("Ecrire un LOGIN SVP!")
        End If


    End Sub






    Private Sub Annuler_Click(sender As Object, e As EventArgs) Handles Annuler.Click
        TB_MDP.Text = ""
        TB_NOM.Text = ""

        TB_NOM.BackColor = Color.White
        TB_MDP.BackColor = Color.White

    End Sub



    Private Sub MDP_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles MDP.LinkClicked
        If verif() Then


            Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123"
            Dim con As New OracleConnection(XE)
            con.Open()

            Dim login As New OracleParameter
            login.OracleDbType = OracleDbType.Varchar2
            login.Value = TB_NOM.Text

            Dim mdp As New OracleParameter
            mdp.OracleDbType = OracleDbType.Varchar2
            mdp.Value = TB_MDP.Text




            Dim cmd As New OracleCommand
            cmd.Connection = con
            cmd.Parameters.Add(login)


            cmd.CommandText = "select * from utilisateur where LOGIN=:1 "
            cmd.CommandType = CommandType.Text



            Dim dr As OracleDataReader = cmd.ExecuteReader()



            If dr.Read() Then


                Récuperation_MDP.Show()




                Me.Hide()
                TB_NOM.BackColor = Color.White
                TB_MDP.BackColor = Color.White

            Else
                MsgBox("compte inconnu")
                TB_MDP.Text = ""
                TB_NOM.Text = ""
                TB_NOM.BackColor = Color.White
                TB_MDP.BackColor = Color.White
            End If

            con.Dispose()
        Else

            MsgBox("ecrire un user pour recupere ton MDP")

        End If



    End Sub





    Private Sub TB_NOM_GotFocus(sender As Object, e As EventArgs) Handles TB_NOM.GotFocus
        TB_NOM.BackColor = Color.Beige

    End Sub


    Private Sub TB_MDP_GotFocus(sender As Object, e As EventArgs) Handles TB_MDP.GotFocus
        TB_MDP.BackColor = Color.Beige
    End Sub








    Private Sub connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Remplir dada

        Dim XE As String = "data source=XE;user Id=system;password=firas123"
        Dim con As New OracleConnection(XE)
        con.Open()

        Dim cmd As New OracleCommand
        cmd.Connection = con
        cmd.CommandText = "SELECT m.NCIN_MEMBRE,m.NOM_MEMBRE,m.PRENOM_MEMBRE,d.NOM_DEPARTEMENT FROM MEMBRE m,DEPARTEMENT_CLUB d  WHERE m.ID_DEPARTEMENT =d.ID_DEPARTEMENT"
        cmd.CommandType = CommandType.Text
        Dim dr As OracleDataReader = cmd.ExecuteReader

        Dim cmd1 As New OracleCommand
        cmd1.Connection = con
        cmd1.CommandText = " select count(NCIN_MEMBRE) from membre"
        cmd1.CommandType = CommandType.Text



        Dim x As Integer = cmd1.ExecuteScalar()


        For i = 1 To x

            If dr.Read() Then

                My.Forms.Gestion_des_Membres_RH.data_membre.Rows.Add(dr.Item("ncin_membre"), dr.Item("NOM_MEMBRE"), dr.Item("PRENOM_MEMBRE"), dr.Item("NOM_DEPARTEMENT"))
                My.Forms.Gestion_des_Membres_Sonsoring.data_membre.Rows.Add(dr.Item("ncin_membre"), dr.Item("NOM_MEMBRE"), dr.Item("PRENOM_MEMBRE"), dr.Item("NOM_DEPARTEMENT"))
                My.Forms.Gestion_des_Notes.data_membre.Rows.Add(dr.Item("ncin_membre"), dr.Item("NOM_MEMBRE"), dr.Item("PRENOM_MEMBRE"), dr.Item("NOM_DEPARTEMENT"))
                My.Forms.Gestion_des_absences_RH.data_membre.Rows.Add(dr.Item("ncin_membre"), dr.Item("NOM_MEMBRE"), dr.Item("PRENOM_MEMBRE"), dr.Item("NOM_DEPARTEMENT"))
                My.Forms.Responsable_Communication.data_membre.Rows.Add(dr.Item("ncin_membre"), dr.Item("NOM_MEMBRE"), dr.Item("PRENOM_MEMBRE"), dr.Item("NOM_DEPARTEMENT"))
                My.Forms.Responsable_Evenementiel.data_membre.Rows.Add(dr.Item("ncin_membre"), dr.Item("NOM_MEMBRE"), dr.Item("PRENOM_MEMBRE"), dr.Item("NOM_DEPARTEMENT"))

            End If


        Next i

        ''Remplir data sponsor

        Dim con2 As New OracleConnection(XE)
        con2.Open()

        Dim cmd2 As New OracleCommand
        cmd2.Connection = con2
        cmd2.CommandText = "select * from sponsor"
        cmd2.CommandType = CommandType.Text
        Dim dr2 As OracleDataReader = cmd2.ExecuteReader

        Dim cmd3 As New OracleCommand
        cmd3.Connection = con2
        cmd3.CommandText = " select count(ID_SPONSOR) from sponsor"
        cmd3.CommandType = CommandType.Text



        Dim x1 As Integer = cmd3.ExecuteScalar()


        For i = 1 To x1

            If dr2.Read() Then

                My.Forms.Gestion_des_Sponsors.Data_sponsor.Rows.Add(dr2.Item("ID_SPONSOR"), dr2.Item("NOM_SPONSOR"))
                My.Forms.Gestion_des_sponsors_de_membre.Data_sponsor.Rows.Add(dr2.Item("ID_SPONSOR"), dr2.Item("NOM_SPONSOR"))
            End If
        Next i
        con2.Dispose()

        Dim con5 As New OracleConnection(XE)
        con5.Open()

        Dim cmd5 As New OracleCommand
        cmd5.Connection = con5
        cmd5.CommandText = "select * from INVITE"
        cmd5.CommandType = CommandType.Text
        Dim dr5 As OracleDataReader = cmd5.ExecuteReader

        Dim cmd6 As New OracleCommand
        cmd6.Connection = con5
        cmd6.CommandText = " select count(ID_INVITE) from INVITE"
        cmd6.CommandType = CommandType.Text



        Dim x3 As Integer = cmd6.ExecuteScalar()
        dr5.Read()

        For i = 0 To x3

            My.Forms.Responsable_Communication.cb__Listes_Invités.Items.Add(dr5.Item("nom_invite"))

        Next i
    End Sub

    Private Sub l_new_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles l_new.LinkClicked
        TB_NOM.Text = 1

        TB_MDP.Text = ""
        My.Forms.Récuperation_MDP.tb_user.Enabled = True
        My.Forms.Récuperation_MDP.tb_Reponse1.Enabled = False
        My.Forms.Récuperation_MDP.tb_Question1.Enabled = False
        My.Forms.Récuperation_MDP.bt_recuper.Enabled = False
        My.Forms.Récuperation_MDP.tb_user.Enabled = True
        Récuperation_MDP.Show()
        Me.Hide()

    End Sub


End Class
