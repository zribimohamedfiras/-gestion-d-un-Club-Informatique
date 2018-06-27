Imports System.Data
Imports Oracle.DataAccess.Types
Imports Oracle.DataAccess.Client

Imports System.Net.Mail
Imports System.Data.SqlClient
Imports System.IO

Public Class Responsable_Evenementiel
    Function verif() As Boolean
        Dim v As Boolean = True
        If Tb_ncin_membre.Text = "" And Me.Tb_ncin_membre.Text Is Nothing Or Not IsNumeric(Me.Tb_ncin_membre.Text) Or Tb_ncin_membre.TextLength <> 7 Then

            v = False
        End If

        Return v

    End Function

    Function verif2() As Boolean
        Dim t As Boolean
        t = True

        If ((tb_date_evenement.Text = "") And (tb_nom_membre.Text = "") And (tb_nom_evenement.Text = "") And (tb_tache.Text = "")) Then
            t = False


        End If
        Return t
    End Function

    Private Sub Annuler_Click(sender As Object, e As EventArgs) Handles Annuler.Click
        TB_NCIN_MEMBRE.Text = ""
        cb_id_evenement.Text = ""
        tb_nom_membre.Text = ""
        tb_nom_evenement.Text = ""
        tb_date_evenement.Text = ""
        tb_tache.Text = ""


        TB_NCIN_MEMBRE.Enabled = True
        cb_id_evenement.Enabled = True
        tb_nom_evenement.Enabled = False
        tb_nom_membre.Enabled = False
        tb_date_evenement.Enabled = False
        tb_tache.Enabled = False
    End Sub

    Private Sub RE_Click(sender As Object, e As EventArgs) Handles RE.Click
        Rebrique_Evenementiel.Show()


        TB_NCIN_MEMBRE.Text = ""
        cb_id_evenement.Text = ""
        tb_nom_membre.Text = ""
        tb_nom_evenement.Text = ""
        tb_date_evenement.Text = ""
        tb_tache.Text = ""


        TB_NCIN_MEMBRE.Enabled = True
        cb_id_evenement.Enabled = True
        tb_nom_evenement.Enabled = False
        tb_nom_membre.Enabled = False
        tb_date_evenement.Enabled = False
        tb_tache.Enabled = False

        bt_supprimer.Enabled = False
        bt_modifier.Enabled = False
        bt_enregistrer.Enabled = False
        bt_ajouter.Enabled = True
        bt_chercher.Enabled = True

        Me.Close()
    End Sub

    Private Sub bt_ajouter_Click(sender As Object, e As EventArgs) Handles bt_ajouter.Click
        If verif() = True Then




            Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123;"
            Dim con As New OracleConnection(XE)
            con.Open()
            'Paramètres pour la sauvegarde 
            Dim id_event As New OracleParameter
            id_event.OracleDbType = OracleDbType.NVarchar2
            id_event.Value = cb_id_evenement.Text

            Dim cmd As New OracleCommand
            cmd.Connection = con
            cmd.Parameters.Add(id_event)

            cmd.CommandText = "SELECT NOM_EVENEMENT FROM EVENEMENT where ID_EVENEMENT=:1 "
            cmd.CommandType = CommandType.Text
            Dim dr As OracleDataReader = cmd.ExecuteReader()
            If dr.Read Then





                If cb_id_evenement.Text <> "" Then
                    bt_enregistrer.Enabled = True
                    bt_modifier.Enabled = False
                    bt_supprimer.Enabled = False



                    tb_tache.Text = ""
                    TB_NCIN_MEMBRE.Enabled = True
                    cb_id_evenement.Enabled = True
                    tb_nom_evenement.Enabled = False
                    tb_nom_membre.Enabled = False
                    tb_date_evenement.Enabled = False
                    tb_tache.Enabled = True
                Else
                    MsgBox("Tapez l'id de l'event SVP!!")
                    TB_NCIN_MEMBRE.Enabled = True
                    cb_id_evenement.Enabled = True
                    tb_nom_evenement.Enabled = False
                    tb_nom_membre.Enabled = False
                    tb_date_evenement.Enabled = False
                    tb_tache.Enabled = False
                End If
            Else

                MsgBox("ce id est deja deja utiliser")

            End If

        Else
            MsgBox("Tapez un CIN de membre valide")

            bt_modifier.Enabled = False
            bt_supprimer.Enabled = False
            bt_enregistrer.Enabled = False
            TB_NCIN_MEMBRE.Text = ""
        End If


    End Sub

    Private Sub Responsable_Evenementiel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bt_supprimer.Enabled = False
        bt_modifier.Enabled = False
        bt_enregistrer.Enabled = False

        TB_NCIN_MEMBRE.Enabled = True
        cb_id_evenement.Enabled = True
        tb_nom_evenement.Enabled = False
        tb_nom_membre.Enabled = False
        tb_date_evenement.Enabled = False
        tb_tache.Enabled = False
    End Sub

    Private Sub bt_chercher_Click(sender As Object, e As EventArgs) Handles bt_chercher.Click
        If verif() = True Then
            Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123;"
            Dim con As New OracleConnection(XE)
            con.Open()

            Dim ncin As New OracleParameter
            ncin.OracleDbType = OracleDbType.Decimal
            ncin.Value = TB_NCIN_MEMBRE.Text


            Dim cmd As New OracleCommand
            cmd.Connection = con
            cmd.Parameters.Add(ncin)
            cmd.CommandText = "select * from MEMBRE where NCIN_MEMBRE=:1 "
            cmd.CommandType = CommandType.Text
            Dim dr As OracleDataReader = cmd.ExecuteReader()

            If dr.Read() Then


                Dim ncin1 As New OracleParameter
                ncin1.OracleDbType = OracleDbType.Decimal
                ncin1.Value = TB_NCIN_MEMBRE.Text

                Dim id_event1 As New OracleParameter
                id_event1.OracleDbType = OracleDbType.NVarchar2
                id_event1.Value = cb_id_evenement.Text

                Dim cmd1 As New OracleCommand
                cmd1.Connection = con
                cmd1.Parameters.Add(ncin1)
                cmd1.Parameters.Add(id_event1)

                cmd1.CommandText = "select NCIN_MEMBRE,ID_EVENEMENT from PARTICIPE_MEMBRE where NCIN_MEMBRE=:1 and ID_EVENEMENT=:2"
                cmd.CommandType = CommandType.Text
                Dim dr1 As OracleDataReader = cmd1.ExecuteReader
                If dr1.Read() Then
                    con.Dispose()
                    Dim con1 As New OracleConnection(XE)
                    con1.Open()


                    Dim ncin2 As New OracleParameter
                    ncin2.OracleDbType = OracleDbType.Decimal
                    ncin2.Value = TB_NCIN_MEMBRE.Text

                    Dim id_event2 As New OracleParameter
                    id_event2.OracleDbType = OracleDbType.NVarchar2
                    id_event2.Value = cb_id_evenement.Text


                    Dim cmd2 As New OracleCommand
                    cmd2.Connection = con1
                    cmd2.Parameters.Add(ncin2)
                    cmd2.Parameters.Add(id_event2)
                    cmd2.CommandText = "select m.NOM_MEMBRE,e.NOM_EVENEMENT,e.DATE_EVENEMENT,p.TACHE_ACCORDE from MEMBRE m,PARTICIPE_MEMBRE p,EVENEMENT e where p.ID_EVENEMENT=e.ID_EVENEMENT and p.NCIN_MEMBRE=m.NCIN_MEMBRE and p.NCIN_MEMBRE=:1 and p.ID_EVENEMENT=:2"

                    cmd2.CommandType = CommandType.Text

                    Dim dr2 As OracleDataReader = cmd2.ExecuteReader()

                    If dr2.Read() Then


                        tb_nom_membre.Text = dr2.Item("NOM_MEMBRE")
                        tb_nom_evenement.Text = dr2.Item("NOM_EVENEMENT")
                        tb_date_evenement.Text = dr2.Item("DATE_EVENEMENT")
                        tb_tache.Text = dr2.Item("TACHE_ACCORDE")

                        TB_NCIN_MEMBRE.Enabled = False
                        cb_id_evenement.Enabled = False




                        MsgBox("Voila votre tache ")
                        bt_supprimer.Enabled = True
                        bt_modifier.Enabled = True
                        bt_ajouter.Enabled = False
                        TB_NCIN_MEMBRE.Enabled = False
                        cb_id_evenement.Enabled = False
                        tb_nom_evenement.Enabled = False
                        tb_nom_membre.Enabled = False
                        tb_date_evenement.Enabled = False
                        tb_tache.Enabled = False


                    Else

                        MsgBox("vous n'avez de tache dans ce evenement")

                    End If




                Else





                    MsgBox("Ce membre n'a aucun tache dans ce evenement vous pouvez donner une tache")
                    TB_NCIN_MEMBRE.Text = ""
                    cb_id_evenement.Text = ""
                    tb_nom_membre.Text = ""
                    tb_nom_evenement.Text = ""
                    tb_date_evenement.Text = ""
                    tb_tache.Text = ""
                    cb_id_evenement.Text = ""

                    TB_NCIN_MEMBRE.Enabled = True
                    tb_nom_evenement.Enabled = True

                End If






            Else
                MsgBox("Ce cin n'existe pas")
                TB_NCIN_MEMBRE.Text = ""
                cb_id_evenement.Text = ""
                tb_nom_membre.Text = ""
                tb_nom_evenement.Text = ""
                tb_date_evenement.Text = ""
                tb_tache.Text = ""

                tb_nom_membre.Enabled = True
                TB_NCIN_MEMBRE.Enabled = True
                tb_nom_evenement.Enabled = True


            End If


        Else
            MsgBox("Tapez un CIN de membre valide")
            TB_NCIN_MEMBRE.Text = ""
            cb_id_evenement.Text = ""
            tb_nom_membre.Text = ""
            tb_nom_evenement.Text = ""
            tb_date_evenement.Text = ""
            tb_tache.Text = ""

        End If
    End Sub

    Private Sub bt_modifier_Click(sender As Object, e As EventArgs) Handles bt_modifier.Click
        bt_enregistrer.Enabled = True
        bt_modifier.Enabled = True
        bt_chercher.Enabled = False

        TB_NCIN_MEMBRE.Enabled = False
        cb_id_evenement.Enabled = True
        tb_nom_evenement.Enabled = False
        tb_nom_membre.Enabled = False
        tb_date_evenement.Enabled = False
        tb_tache.Enabled = True



    End Sub

    Private Sub bt_supprimer_Click(sender As Object, e As EventArgs) Handles bt_supprimer.Click
        If MsgBox("Etes vous sûr de vouloir supprimer?", vbYesNo, "Suppression") = MsgBoxResult.Yes Then
            Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123;"
            Dim con As New OracleConnection(XE)
            con.Open()

            Dim ncin_suprimer As New OracleParameter
            ncin_suprimer.OracleDbType = OracleDbType.Decimal
            ncin_suprimer.Value = TB_NCIN_MEMBRE.Text

            Dim id_event As New OracleParameter
            id_event.OracleDbType = OracleDbType.NVarchar2
            id_event.Value = cb_id_evenement.Text

            Dim cmd1 As New OracleCommand
            cmd1.Connection = con
            cmd1.Parameters.Add(ncin_suprimer)
            cmd1.Parameters.Add(id_event)
            cmd1.CommandText = "DELETE FROM participe_membre where NCIN_MEMBRE=:1 and ID_EVENEMENT=:2"
            cmd1.CommandType = CommandType.Text



            Dim dr1 As OracleDataReader = cmd1.ExecuteReader()


            'tache envoyer dans un email



            Dim ncin_re As New OracleParameter
            ncin_re.OracleDbType = OracleDbType.Decimal
            ncin_re.Value = TB_NCIN_MEMBRE.Text
            Dim cmd_re As New OracleCommand
            cmd_re.Connection = con
            cmd_re.Parameters.Add(ncin_re)

            cmd_re.CommandText = "select * from MEMBRE where NCIN_MEMBRE=:1"
            Dim dr_re As OracleDataReader = cmd_re.ExecuteReader()
            If dr_re.Read Then
                Dim x As String
                x = dr_re.Item("MAIL_MEMBRE").ToString
                Dim smtpServer As New SmtpClient()
                Dim mail As New MailMessage()
                smtpServer.Credentials = New Net.NetworkCredential("essectmicclub@gmail.com", "zribijouini")
                smtpServer.Port = 587
                smtpServer.Host = "smtp.gmail.com"
                smtpServer.EnableSsl = True
                mail = New MailMessage()
                mail.From = New MailAddress("essectmicclub@gmail.com")
                mail.To.Add(x)
                mail.Subject = "Login: "
                mail.Body = ("Salut votre tache à eté supprimer")
                smtpServer.Send(mail)
                MsgBox("Thanks for your email !")

            End If


            bt_modifier.Enabled = False
            bt_supprimer.Enabled = False
            bt_enregistrer.Enabled = False
            TB_NCIN_MEMBRE.Text = ""
            cb_id_evenement.Text = ""
            tb_nom_membre.Text = ""
            tb_nom_evenement.Text = ""
            tb_date_evenement.Text = ""
            tb_tache.Text = ""

            MsgBox("supprission de tache pur ce membre avec succes")

            con.Dispose()
            bt_chercher.Enabled = True
            bt_ajouter.Enabled = False
            TB_NCIN_MEMBRE.Enabled = True
            cb_id_evenement.Enabled = True
            tb_nom_evenement.Enabled = False
            tb_nom_membre.Enabled = False
            tb_date_evenement.Enabled = False
            tb_tache.Enabled = False
        End If
    End Sub

    Private Sub bt_enregistrer_Click(sender As Object, e As EventArgs) Handles bt_enregistrer.Click
        If MsgBox("Etes vous sûr de vouloir ajouter ou modifier?", vbYesNo, "ajouter ou modifier") = MsgBoxResult.Yes Then
            Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123;"
            Dim con As New OracleConnection(XE)
            con.Open()
            'Paramètres pour la sauvegarde 
            Dim ncin_verif As New OracleParameter
            ncin_verif.OracleDbType = OracleDbType.Decimal
            ncin_verif.Value = TB_NCIN_MEMBRE.Text

            Dim id_verif As New OracleParameter
            id_verif.OracleDbType = OracleDbType.NVarchar2
            id_verif.Value = cb_id_evenement.Text


            Dim ncin As New OracleParameter
            ncin.OracleDbType = OracleDbType.Decimal
            ncin.Value = TB_NCIN_MEMBRE.Text

            Dim id_event As New OracleParameter
            id_event.OracleDbType = OracleDbType.NVarchar2
            id_event.Value = cb_id_evenement.Text

            Dim tache As New OracleParameter
            tache.OracleDbType = OracleDbType.NVarchar2
            tache.Value = tb_tache.Text

            'Vérifier si c’est un ajout ou modification

            Dim cmd As New OracleCommand
            cmd.Connection = con
            cmd.Parameters.Add(ncin_verif)
            cmd.Parameters.Add(id_verif)
            cmd.CommandText = "SELECT * FROM participe_membre where NCIN_MEMBRE=:1 and ID_EVENEMENT=:2 "
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

                    cmd2.Parameters.Add(tache)
                    cmd2.Parameters.Add(ncin)
                    cmd2.Parameters.Add(id_event)


                    cmd2.CommandText = "update participe_membre set TACHE_ACCORDE=:1 where NCIN_MEMBRE=:2 and ID_EVENEMENT=:3 "

                    cmd2.CommandType = CommandType.Text
                    Dim dr1 As OracleDataReader = cmd2.ExecuteReader()
                    'Désactiver la modification 

                    'tache envoyer dans un email



                    Dim ncin_re As New OracleParameter
                    ncin_re.OracleDbType = OracleDbType.Decimal
                    ncin_re.Value = TB_NCIN_MEMBRE.Text
                    Dim cmd_re As New OracleCommand
                    cmd_re.Connection = conn1
                    cmd_re.Parameters.Add(ncin_re)

                    cmd_re.CommandText = "select * from MEMBRE where NCIN_MEMBRE=:1"
                    Dim dr_re As OracleDataReader = cmd_re.ExecuteReader()
                    If dr_re.Read Then
                        Dim x As String
                        x = dr_re.Item("MAIL_MEMBRE").ToString
                        Dim smtpServer As New SmtpClient()
                        Dim mail As New MailMessage()
                        smtpServer.Credentials = New Net.NetworkCredential("essectmicclub@gmail.com", "zribijouini")
                        smtpServer.Port = 587
                        smtpServer.Host = "smtp.gmail.com"
                        smtpServer.EnableSsl = True
                        mail = New MailMessage()
                        mail.From = New MailAddress("essectmicclub@gmail.com")
                        mail.To.Add(x)
                        mail.Subject = "Login: "
                        mail.Body = ("Salut votre tache est modifier voici la nouvel tache " + tb_tache.Text)
                        smtpServer.Send(mail)
                        MsgBox("Thanks for your email !")

                    End If

                    TB_NCIN_MEMBRE.Enabled = True
                    cb_id_evenement.Enabled = True
                    tb_nom_evenement.Enabled = False
                    tb_nom_membre.Enabled = False
                    tb_date_evenement.Enabled = False
                    tb_tache.Enabled = False

                    bt_modifier.Enabled = False
                    bt_enregistrer.Enabled = False
                    bt_ajouter.Enabled = False
                    bt_supprimer.Enabled = False
                    bt_chercher.Enabled = True
                    bt_ajouter.Enabled = True

                    TB_NCIN_MEMBRE.Text = ""
                    cb_id_evenement.Text = ""
                    tb_nom_membre.Text = ""
                    tb_nom_evenement.Text = ""
                    tb_date_evenement.Text = ""
                    tb_tache.Text = ""
                    MsgBox("Membre modifié avec succés")
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
                        cmd2.Parameters.Add(ncin)
                        cmd2.Parameters.Add(id_event)
                        cmd2.Parameters.Add(tache)

                        cmd2.CommandText = "insert into participe_membre(NCIN_MEMBRE,ID_EVENEMENT,PRESENCE_MEMBRE,TACHE_ACCORDE,TACHE_NOTE) values (:1,:2,'',:3,'')"

                        cmd2.CommandType = CommandType.Text

                        Dim dr1 As OracleDataReader = cmd2.ExecuteReader()

                        'tache envoyer dans un email



                        Dim ncin_re As New OracleParameter
                        ncin_re.OracleDbType = OracleDbType.Decimal
                        ncin_re.Value = TB_NCIN_MEMBRE.Text
                        Dim cmd_re As New OracleCommand
                        cmd_re.Connection = conn1
                        cmd_re.Parameters.Add(ncin_re)

                        cmd_re.CommandText = "select * from MEMBRE where NCIN_MEMBRE=:1"
                        Dim dr_re As OracleDataReader = cmd_re.ExecuteReader()
                        If dr_re.Read Then
                            Dim x As String
                            x = dr_re.Item("MAIL_MEMBRE").ToString
                            Dim smtpServer As New SmtpClient()
                            Dim mail As New MailMessage()
                            smtpServer.Credentials = New Net.NetworkCredential("essectmicclub@gmail.com", "zribijouini")
                            smtpServer.Port = 587
                            smtpServer.Host = "smtp.gmail.com"
                            smtpServer.EnableSsl = True
                            mail = New MailMessage()
                            mail.From = New MailAddress("essectmicclub@gmail.com")
                            mail.To.Add(x)
                            mail.Subject = "Login: "
                            mail.Body = ("Salut c'est votre tache" + tb_tache.Text)
                            smtpServer.Send(mail)
                            MsgBox("Thanks for your email !")

                        End If


                        'Désactiver la modification




                        TB_NCIN_MEMBRE.Enabled = True
                        cb_id_evenement.Enabled = True
                        tb_nom_evenement.Enabled = False
                        tb_nom_membre.Enabled = False
                        tb_date_evenement.Enabled = False
                        tb_tache.Enabled = False

                        bt_modifier.Enabled = False
                        bt_enregistrer.Enabled = False
                        bt_ajouter.Enabled = False
                        bt_supprimer.Enabled = False
                        bt_chercher.Enabled = True
                        bt_ajouter.Enabled = True
                        MsgBox("Membre ajoute avec succeé")
                        TB_NCIN_MEMBRE.Text = ""
                        cb_id_evenement.Text = ""
                        tb_nom_membre.Text = ""
                        tb_nom_evenement.Text = ""
                        tb_date_evenement.Text = ""
                        tb_tache.Text = ""

                        conn1.Dispose()
                    Else
                        MsgBox("Il faur remplir tout les champs")
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub TB_NCIN_MEMBRE_TextChanged(sender As Object, e As EventArgs) Handles TB_NCIN_MEMBRE.TextChanged
        If verif() = True Then
            Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123;"
            Dim con As New OracleConnection(XE)
            con.Open()

            Dim ncin As New OracleParameter
            ncin.OracleDbType = OracleDbType.Decimal
            ncin.Value = TB_NCIN_MEMBRE.Text

            Dim cmd As New OracleCommand
            cmd.Connection = con
            cmd.Parameters.Add(ncin)
            cmd.CommandText = "select nom_membre from MEMBRE where NCIN_MEMBRE=:1   "
            cmd.CommandType = CommandType.Text
            Dim dr As OracleDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                tb_nom_membre.Text = dr.Item("nom_membre").ToString
            End If

        End If
    End Sub

    Private Sub cb_id_evenement_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_id_evenement.SelectedIndexChanged
        Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123;"
        Dim con As New OracleConnection(XE)
        con.Open()

        Dim id_event As New OracleParameter
        id_event.OracleDbType = OracleDbType.NVarchar2
        id_event.Value = cb_id_evenement.Text

        Dim cmd As New OracleCommand
        cmd.Connection = con


        cmd.Parameters.Add(id_event)

        cmd.CommandText = "select NOM_EVENEMENT from EVENEMENT where ID_EVENEMENT=:1 "
        cmd.CommandType = CommandType.Text
        Dim dr As OracleDataReader = cmd.ExecuteReader()

        If dr.Read() Then
            tb_nom_evenement.Text = dr.Item("NOM_EVENEMENT").ToString


        End If


    End Sub

    Private Sub bt_Quitter_Click(sender As Object, e As EventArgs) Handles bt_Quitter.Click
        Me.Close()
        connexion.Close()
    End Sub
End Class