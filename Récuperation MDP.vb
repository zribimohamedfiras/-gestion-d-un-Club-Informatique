Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types
Imports System.Data
Public Class Récuperation_MDP
    Dim somme As Integer = 5







    Function verif() As Boolean
        Dim v As Boolean = True
        If tb_user.Text = "" And Me.tb_user.Text Is Nothing Or Not IsNumeric(Me.tb_user.Text) Or tb_user.TextLength <> 7 Then
            v = False

        End If
        Return v

    End Function



    


    Function verif2() As Boolean
        Dim t As Boolean
        t = True

        If ((tb_mdp.Text = "") And (cb_Question.Text = "") And (tb_Reponse.Text = "")) Then
            t = False


        End If
        Return t
    End Function




 

    Private Sub bt_connect_Click_1(sender As Object, e As EventArgs) Handles bt_connect.Click
        connexion.Show()
        Me.Hide()
    End Sub


    Private Sub bt_Annuler1_Click_1(sender As Object, e As EventArgs) Handles bt_Annuler1.Click
        tb_Reponse1.Text = ""
    End Sub

    Private Sub Annuler_Click(sender As Object, e As EventArgs) Handles Annuler.Click
        tb_mdp.Text = ""
        tb_user.Text = ""
        cb_Question.Text = ""

        tb_Reponse.Text = ""
        bt_chercher.Enabled = True
        bt_ajouter.Enabled = False
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False

    End Sub

    Private Sub bt_recuper_Click(sender As Object, e As EventArgs) Handles bt_recuper.Click
        If tb_Reponse1.Text <> "" Then



            Dim x As Integer = My.Forms.connexion.TB_NOM.Text


            Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123"
            Dim con As New OracleConnection(XE)
            con.Open()


            Dim ncin As New OracleParameter
            ncin.OracleDbType = OracleDbType.Decimal
            ncin.Value = x

            Dim question1 As New OracleParameter
            question1.OracleDbType = OracleDbType.NVarchar2
            question1.Value = tb_Question1.Text



            Dim Reponse1 As New OracleParameter
            Reponse1.OracleDbType = OracleDbType.NVarchar2
            Reponse1.Value = tb_Reponse1.Text

            Dim cmd3 As New OracleCommand
            cmd3.Connection = con
            cmd3.Parameters.Add(ncin)
            cmd3.Parameters.Add(question1)
            cmd3.Parameters.Add(Reponse1)

            cmd3.CommandText = "select * from UTILISATEUR where LOGIN=:1 and QUESTIONSECURITE=:2 and REPONSE=:3"
            Dim dr3 As OracleDataReader = cmd3.ExecuteReader()
            If dr3.Read Then
                My.Forms.connexion.TB_MDP.Text = dr3.Item("MOTDEPASSE").ToString
                MsgBox("votre MDP est " & dr3.Item("MOTDEPASSE"))
                connexion.Show()
                Me.Hide()
                tb_Question1.Text = ""
                tb_Reponse1.Text = ""
            Else
                somme = somme - 1
                MsgBox("votre reponse est faux Il vous reste  " & somme & " tentative")
                If somme = 0 Then

                    MsgBox("* Creé un nouveau Compte avec des nouvaux   Identification*")

                    tb_Question1.Text = ""
                    tb_Reponse1.Text = ""
                    bt_Annuler1.Enabled = False
                    bt_recuper.Enabled = False

                End If


            End If
        Else

            MsgBox("Ecrire une reponse SVP!")

        End If
    End Sub

    Private Sub Récuperation_MDP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_user.Enabled = True
        tb_mdp.Enabled = False
        cb_Question.Enabled = False

        tb_Reponse.Enabled = False
        bt_supprimer.Enabled = False
        bt_modifier.Enabled = False
        bt_enregistrer.Enabled = False


        Dim x As Integer = My.Forms.connexion.TB_NOM.Text

        Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123;"
        Dim con As New OracleConnection(XE)
        con.Open()

        Dim ncin As New OracleParameter
        ncin.OracleDbType = OracleDbType.Decimal
        ncin.Value = x

        Dim cmd3 As New OracleCommand
        cmd3.Connection = con
        cmd3.Parameters.Add(ncin)

        cmd3.CommandText = "select * from UTILISATEUR where LOGIN=:1"
        Dim dr3 As OracleDataReader = cmd3.ExecuteReader()
        If dr3.Read Then
            tb_Question1.Text = dr3.Item("QUESTIONSECURITE").ToString

        End If
    End Sub

    Private Sub bt_chercher_Click(sender As Object, e As EventArgs) Handles bt_chercher.Click
        tb_user.Enabled = True
        tb_mdp.Enabled = False
        cb_Question.Enabled = False

        tb_Reponse.Enabled = False
        'vider des TB, si la recherche ne retourne rien ils restent vides.
        tb_mdp.Text = ""

        cb_Question.Text = ""

        tb_Reponse.Text = ""
        bt_supprimer.Enabled = True
        bt_modifier.Enabled = True

        ''-Vérifier si le pilote existe dans la base

        If verif() = True Then

            Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123;"
            Dim con As New OracleConnection(XE)
            con.Open()

            Dim user As New OracleParameter
            user.OracleDbType = OracleDbType.Decimal
            user.Value = tb_user.Text()

            Dim cmd As New OracleCommand
            cmd.Connection = con
            cmd.Parameters.Add(user)

            cmd.CommandText = "select * from UTILISATEUR where LOGIN=:1"
            cmd.CommandType = CommandType.Text



            Dim dr As OracleDataReader = cmd.ExecuteReader()
            Dim p As Boolean
            p = dr.Read()
            ''si la cle primare ecrit existe ou non
            If p = True Then

                cb_Question.Text = ""

                tb_Reponse.Text = ""

                tb_mdp.Text = dr.Item("MOTDEPASSE").ToString
                cb_Question.Text = dr.Item("QUESTIONSECURITE").ToString
                tb_Reponse.Text = dr.Item("REPONSE").ToString

                con.Dispose()

                bt_supprimer.Enabled = True
                bt_modifier.Enabled = True
                bt_ajouter.Enabled = False
                bt_enregistrer.Enabled = False

                bt_chercher.Enabled = False
                'si le membre existe on ne peut pas l’ajouter
            Else
                MsgBox("ce User n'existe pas vous voulez ajouter")

                bt_supprimer.Enabled = False
                bt_modifier.Enabled = False
                bt_enregistrer.Enabled = False
                bt_ajouter.Enabled = True
                'Si le membre n’existe pas dans la base on peut donc l’ajouter End If
            End If
        Else
            MsgBox("Tapez un User de membre valide")
            bt_chercher.Enabled = True
            bt_modifier.Enabled = False
            bt_supprimer.Enabled = False
            bt_enregistrer.Enabled = False

        End If
    End Sub

    Private Sub bt_ajouter_Click(sender As Object, e As EventArgs) Handles bt_ajouter.Click
        If verif() = True Then

            Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123;"
            Dim con As New OracleConnection(XE)
            con.Open()

            Dim user As New OracleParameter
            user.OracleDbType = OracleDbType.Decimal
            user.Value = tb_user.Text()

            Dim cmd As New OracleCommand
            cmd.Connection = con
            cmd.Parameters.Add(user)

            cmd.CommandText = "select * from UTILISATEUR where LOGIN=:1"
            cmd.CommandType = CommandType.Text




            Dim dr As OracleDataReader = cmd.ExecuteReader()
            If dr.Read = False Then
                con.Dispose()



                bt_enregistrer.Enabled = True
                bt_modifier.Enabled = False
                bt_supprimer.Enabled = False
                tb_user.Enabled = False
                tb_mdp.Enabled = True
                cb_Question.Enabled = True

                tb_Reponse.Enabled = True


                tb_mdp.Text = ""
                cb_Question.Text = ""

                tb_Reponse.Text = ""
            Else
                MsgBox("ce User est deja utiliser")
                tb_user.Text = ""

            End If

        Else
            MsgBox("Tapez un User   valide")

            bt_modifier.Enabled = False
            bt_supprimer.Enabled = False
            bt_enregistrer.Enabled = False
            tb_user.Text = ""
        End If
    End Sub

    Private Sub bt_modifier_Click(sender As Object, e As EventArgs) Handles bt_modifier.Click
        bt_enregistrer.Enabled = True
        tb_user.Enabled = False
        tb_mdp.Enabled = True
        cb_Question.Enabled = True

        tb_Reponse.Enabled = True
    End Sub

    Private Sub bt_supprimer_Click(sender As Object, e As EventArgs) Handles bt_supprimer.Click
        If MsgBox("Etes vous sûr de vouloir supprimer?", vbYesNo, "Suppression") = MsgBoxResult.Yes Then
            Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123;"
            Dim con As New OracleConnection(XE)
            con.Open()

            Dim user_suprimer As New OracleParameter
            user_suprimer.OracleDbType = OracleDbType.Decimal
            user_suprimer.Value = tb_user.Text



            Dim cmd1 As New OracleCommand
            cmd1.Connection = con
            cmd1.Parameters.Add(user_suprimer)

            cmd1.CommandText = "DELETE FROM UTILISATEUR where login=:1"
            cmd1.CommandType = CommandType.Text

            Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
            dr1.Read()

            bt_modifier.Enabled = False
            bt_supprimer.Enabled = False
            bt_enregistrer.Enabled = False
            tb_mdp.Text = ""
            tb_user.Text = ""
            cb_Question.Text = ""

            tb_Reponse.Text = ""
            MsgBox("supprission avec succes")


            con.Dispose()
            bt_chercher.Enabled = True
            bt_ajouter.Enabled = True
        End If
    End Sub

    Private Sub bt_enregistrer_Click(sender As Object, e As EventArgs) Handles bt_enregistrer.Click
        If MsgBox("Etes vous sûr de vouloir ajouter ou modifier?", vbYesNo, "ajouter ou modifier") = MsgBoxResult.Yes Then
            Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123;"
            Dim con As New OracleConnection(XE)
            con.Open()
            'Paramètres pour la sauvegarde 
            Dim user As New OracleParameter
            user.OracleDbType = OracleDbType.Decimal
            user.Value = tb_user.Text

            Dim user_enegistre As New OracleParameter
            user_enegistre.OracleDbType = OracleDbType.Decimal
            user_enegistre.Value = tb_user.Text


            tb_mdp.Enabled = False
            cb_Question.Enabled = False

            tb_Reponse.Enabled = False


            Dim mdp As New OracleParameter
            mdp.OracleDbType = OracleDbType.NVarchar2
            mdp.Value = tb_mdp.Text




            Dim Question As New OracleParameter
            Question.OracleDbType = OracleDbType.NVarchar2
            Question.Value = cb_Question.Text



            Dim Reponse As New OracleParameter
            Reponse.OracleDbType = OracleDbType.NVarchar2
            Reponse.Value = tb_Reponse.Text



            'Vérifier si c’est un ajout ou modification

            Dim cmd As New OracleCommand
            cmd.Connection = con
            cmd.Parameters.Add(user_enegistre)
            cmd.CommandText = "SELECT * FROM UTILISATEUR where LOGIN=:1"
            cmd.CommandType = CommandType.Text
            Dim dr As OracleDataReader = cmd.ExecuteReader()
            If dr.Read Then
                con.Dispose()
                MsgBox("On a une modification")
                If MsgBox("Etes vous sûr de vouloir modifier?", vbYesNo, "Modifier") = MsgBoxResult.Yes Then
                    Dim conn1 As New OracleConnection(XE)
                    conn1.Open()
                    Dim cmd2 As New OracleCommand
                    cmd2.Connection = conn1
                    cmd2.Parameters.Add(user)
                    cmd2.Parameters.Add(mdp)

                    cmd2.Parameters.Add(Question)
                    cmd2.Parameters.Add(Reponse)


                    cmd2.CommandText = "update UTILISATEUR set LOGIN=:1,MOTDEPASSE=:2,QUESTIONSECURITE=:3,REPONSE=:4 where LOGIN=:1"



                    cmd2.CommandType = CommandType.Text
                    Dim dr1 As OracleDataReader = cmd2.ExecuteReader()
                    'Désactiver la modification 

                    tb_user.Enabled = True
                    tb_mdp.Enabled = False
                    cb_Question.Enabled = False

                    tb_Reponse.Enabled = False




                    bt_modifier.Enabled = False
                    bt_enregistrer.Enabled = False
                    bt_ajouter.Enabled = False
                    bt_supprimer.Enabled = False
                    bt_chercher.Enabled = True
                    bt_ajouter.Enabled = True
                    tb_mdp.Text = ""
                    tb_user.Text = ""
                    cb_Question.Text = ""

                    tb_Reponse.Text = ""
                    MsgBox("User modifié avec succés")
                    conn1.Dispose()
                End If

            Else
                con.Dispose()
                If verif2() Then
                    MsgBox("insertion dans la base")
                    If MsgBox("Etes vous sûr de vouloir ajouter?", vbYesNo, "Modifier") = MsgBoxResult.Yes Then
                        Dim conn1 As New OracleConnection(XE)
                        conn1.Open()

                        Dim cmd2 As New OracleCommand
                        cmd2.Connection = conn1
                        cmd2.Parameters.Add(user)
                        cmd2.Parameters.Add(mdp)

                        cmd2.Parameters.Add(Question)
                        cmd2.Parameters.Add(Reponse)
                        cmd2.CommandText = "insert into UTILISATEUR values(:1,:2,:3,:4)"

                        cmd2.CommandType = CommandType.Text

                        Dim dr1 As OracleDataReader = cmd2.ExecuteReader()
                        'Désactiver la modification 

                        tb_user.Enabled = True
                        tb_mdp.Enabled = False
                        cb_Question.Enabled = False

                        tb_Reponse.Enabled = False




                        bt_modifier.Enabled = False
                        bt_enregistrer.Enabled = False
                        bt_ajouter.Enabled = False
                        bt_supprimer.Enabled = False
                        bt_chercher.Enabled = True
                        bt_ajouter.Enabled = True
                        MsgBox("User ajoute avec succeé")


                        tb_mdp.Text = ""
                        tb_user.Text = ""
                        cb_Question.Text = ""

                        tb_Reponse.Text = ""

                        conn1.Dispose()
                    Else
                        MsgBox("Il faur remplir tout les champs")
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub bt_Quitter_Click(sender As Object, e As EventArgs) Handles bt_Quitter.Click
        Me.Close()
        connexion.Close()
    End Sub

    Private Sub bt_Retour_Click(sender As Object, e As EventArgs) Handles bt_Retour.Click
        connexion.Show()
        Me.Close()
    End Sub
End Class