Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types


Public Class Presence_Invité

    Private Sub bt_retour_Click_1(sender As Object, e As EventArgs) Handles bt_retour.Click
        Rebrique_Secrétaire_Général.Show()

        bt_Afficher_Nombre_Présence.Enabled = True
        bt_ajouter.Enabled = False
        bt_Chercher.Enabled = True
        bt_Enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_Supprimer.Enabled = False
        tb__Afficher_Nombre_Présence.Enabled = False
        tb_id_invite.Enabled = True
        cb__Nom_Evenement.Enabled = True
        r_non.Enabled = False
        r_oui.Enabled = False
        tb_id_invite.Text = ""
        tb__Afficher_Nombre_Présence.Text = ""
        cb__Nom_Evenement.Text = ""
        r_non.Checked = False
        r_oui.Checked = False

        Me.Close()
    End Sub

    Private Sub bt_annuler_Click_1(sender As Object, e As EventArgs) Handles bt_annuler.Click
        bt_Afficher_Nombre_Présence.Enabled = True
        bt_ajouter.Enabled = False
        bt_Chercher.Enabled = True
        bt_Enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_Supprimer.Enabled = False
        tb__Afficher_Nombre_Présence.Enabled = False
        tb_id_invite.Enabled = True
        cb__Nom_Evenement.Enabled = True
        r_non.Enabled = False
        r_oui.Enabled = False
        tb_id_invite.Text = ""
        tb__Afficher_Nombre_Présence.Text = ""
        cb__Nom_Evenement.Text = ""
        r_non.Checked = False
        r_oui.Checked = False
    End Sub

    Private Sub Presence_Invité_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bt_Afficher_Nombre_Présence.Enabled = True
        bt_ajouter.Enabled = False
        bt_Chercher.Enabled = True
        bt_Enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_Supprimer.Enabled = False
        tb__Afficher_Nombre_Présence.Enabled = False
        tb_id_invite.Enabled = True
        cb__Nom_Evenement.Enabled = True
        r_non.Enabled = False
        r_oui.Enabled = False
        tb_id_invite.Text = ""
        tb__Afficher_Nombre_Présence.Text = ""
        cb__Nom_Evenement.Text = ""
        r_non.Checked = False
        r_oui.Checked = False

        Dim xe As String = "data source=xe;user id=system;password=firas123;"
        Dim con As New OracleConnection(xe)
        con.Open()
        Dim cmd As New OracleCommand
        cmd.Connection = con

        cmd.CommandText = "select nom_evenement from evenement "
        cmd.CommandType = CommandType.Text
        Dim dr As OracleDataReader = cmd.ExecuteReader()
        While dr.Read
            cb__Nom_Evenement.Items.Add(dr.Item("nom_evenement"))
        End While
        con.Dispose()

        DataGridView1.Rows.Clear()



        Dim con1 As New OracleConnection(xe)
        con1.Open()


        Dim cmd1 As New OracleCommand
        cmd1.Connection = con1

        cmd1.CommandText = "select *  from   INVITE "
        cmd1.CommandType = CommandType.Text
        Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
        While dr1.Read
            DataGridView1.Rows.Add(dr1.Item("ID_INVITE"), dr1.Item("NOM_INVITE"), dr1.Item("PRENOM_INVITE"))

        End While
        con1.Dispose()


        DataGridView2.Rows.Clear()


        Dim con18 As New OracleConnection(xe)
        con18.Open()


        Dim cmd18 As New OracleCommand
        cmd18.Connection = con18

        cmd18.CommandText = "select *  from   participe_invite "
        cmd18.CommandType = CommandType.Text
        Dim dr18 As OracleDataReader = cmd18.ExecuteReader()
        While dr18.Read()
            DataGridView2.Rows.Add(dr18.Item("id_evenement"), dr18.Item("id_invite"), dr18.Item("presence_invite"))

        End While
        con18.Dispose()


    End Sub

    Function verif1() As Boolean
        Dim v As Boolean = True
        If Me.tb_id_invite.Text Is Nothing And Me.tb_id_invite.Text = "" Then
            v = False
        Else
            If Me.tb_id_invite.Text(0) <> "i" Then
                v = False
            End If
        End If

        Return v
    End Function


    Function verif2() As Boolean
        Dim v As Boolean = True
        Dim c As Boolean = False
        Dim i As Integer = 0

        If cb__Nom_Evenement.Text Is Nothing Then

            v = False
        Else

            While i < cb__Nom_Evenement.Items.Count() And c = False
                If cb__Nom_Evenement.Text = cb__Nom_Evenement.Items.Item(i) Then

                    c = True
                End If
                i = i + 1
            End While

            If c = False Then
                v = False
            End If

        End If

        Return v



    End Function


    Function id_evenemenet() As String
        Dim xe As String = "data source=xe;user id=system;password=firas123;"
        Dim con As New OracleConnection(xe)
        con.Open()
        Dim parm As New OracleParameter
        parm.OracleDbType = OracleDbType.Varchar2
        parm.Value = cb__Nom_Evenement.Text

        Dim cmd As New OracleCommand
        cmd.Connection = con
        cmd.Parameters.Add(parm)

        cmd.CommandText = "select id_evenement from evenement where nom_evenement=:1"
        cmd.CommandType = CommandType.Text
        Dim dr As OracleDataReader = cmd.ExecuteReader()
        dr.Read()
        Dim x As String = dr.Item("id_evenement")


        con.Dispose()

        Return x
    End Function

    Private Sub bt_Chercher_Click(sender As Object, e As EventArgs) Handles bt_Chercher.Click
        bt_ajouter.Enabled = False
        bt_Chercher.Enabled = True
        bt_Enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_Supprimer.Enabled = False
        tb__Afficher_Nombre_Présence.Enabled = False
        tb_id_invite.Enabled = True
        r_non.Enabled = False
        r_oui.Enabled = False
        r_non.Checked = False
        r_oui.Checked = False
        If verif1() And verif2() Then
            Dim xe As String = "data source=xe;user id=system;password=firas123;"
            Dim con As New OracleConnection(xe)
            con.Open()

            Dim parm1 As New OracleParameter
            parm1.OracleDbType = OracleDbType.Varchar2
            parm1.Value = tb_id_invite.Text

            Dim parm2 As New OracleParameter
            parm2.OracleDbType = OracleDbType.Varchar2
            parm2.Value = id_evenemenet()

            Dim cmd As New OracleCommand
            cmd.Connection = con
            cmd.Parameters.Add(parm1)
            cmd.Parameters.Add(parm2)

            cmd.CommandText = "select * from participe_invite where id_invite=:1 and id_evenement=:2"
            cmd.CommandType = CommandType.Text

            Dim dr As OracleDataReader = cmd.ExecuteReader()
            If dr.Read() Then
                If dr.Item("presence_invite") = "Oui" Then
                    r_oui.Checked = True
                    r_non.Checked = False
                Else
                    r_non.Checked = True
                    r_oui.Checked = False

                End If
                bt_Afficher_Nombre_Présence.Enabled = True
                bt_Chercher.Enabled = False
                bt_modifier.Enabled = True
                bt_Supprimer.Enabled = True
                bt_ajouter.Enabled = False
                bt_Enregistrer.Enabled = False
                tb__Afficher_Nombre_Présence.Enabled = False
                tb_id_invite.Enabled = True
                cb__Nom_Evenement.Enabled = True
                r_oui.Enabled = False
                r_non.Enabled = False
                con.Dispose()
            Else
                If MsgBox("affectation possible si " + tb_id_invite.Text + " trouver dans la base de donnes", vbYesNo, "tu peut affecter cette invité à l'evenement " + cb__Nom_Evenement.Text) = MsgBoxResult.Yes Then
                    bt_Afficher_Nombre_Présence.Enabled = True
                    bt_Chercher.Enabled = True
                    bt_modifier.Enabled = False
                    bt_ajouter.Enabled = True
                    bt_Enregistrer.Enabled = False
                    bt_Supprimer.Enabled = False
                    tb__Afficher_Nombre_Présence.Enabled = False
                    tb_id_invite.Enabled = True
                    cb__Nom_Evenement.Enabled = True
                    r_oui.Enabled = False
                    r_non.Enabled = False
                    r_non.Checked = False
                    r_oui.Checked = False
                End If
                con.Dispose()
            End If
        Else
            If verif1() = False Then
                MessageBox.Show("tapez le id de l'invité sachant que le premier caractere de cette derniere est 'i' ", "erreur")


            End If
            If verif2() = False Then
                MessageBox.Show("il doit respecter les evenement qui est annoncé dans le liste", "erreur")
            End If
            bt_Afficher_Nombre_Présence.Enabled = True
            bt_Chercher.Enabled = True
            bt_modifier.Enabled = False
            bt_ajouter.Enabled = False
            bt_Enregistrer.Enabled = False
            bt_Supprimer.Enabled = False
            tb__Afficher_Nombre_Présence.Enabled = False
            tb_id_invite.Enabled = True
            cb__Nom_Evenement.Enabled = True
            r_oui.Enabled = False
            r_non.Enabled = False
            tb_id_invite.Text = ""
            cb__Nom_Evenement.Text = ""
            r_non.Checked = False
            r_oui.Checked = False
        End If
    End Sub

    Private Sub bt_modifier_Click(sender As Object, e As EventArgs) Handles bt_modifier.Click
        bt_Afficher_Nombre_Présence.Enabled = True
        bt_Chercher.Enabled = False
        bt_modifier.Enabled = False
        bt_ajouter.Enabled = False
        bt_Enregistrer.Enabled = True
        bt_Supprimer.Enabled = False
        tb__Afficher_Nombre_Présence.Enabled = False
        tb_id_invite.Enabled = False
        cb__Nom_Evenement.Enabled = False
        r_oui.Enabled = True
        r_non.Enabled = True
        tb__Afficher_Nombre_Présence.Text = ""
        r_non.Checked = False
        r_oui.Checked = False
    End Sub

    Private Sub bt_ajouter_Click(sender As Object, e As EventArgs) Handles bt_ajouter.Click
        bt_Afficher_Nombre_Présence.Enabled = True
        bt_Chercher.Enabled = False
        bt_modifier.Enabled = False
        bt_ajouter.Enabled = False
        bt_Enregistrer.Enabled = True
        bt_Supprimer.Enabled = False
        tb__Afficher_Nombre_Présence.Enabled = False
        tb_id_invite.Enabled = False
        cb__Nom_Evenement.Enabled = False
        r_oui.Enabled = True
        r_non.Enabled = True
        tb__Afficher_Nombre_Présence.Text = ""
        r_non.Checked = False
        r_oui.Checked = False
    End Sub

    Private Sub bt_Supprimer_Click(sender As Object, e As EventArgs) Handles bt_Supprimer.Click
        bt_Chercher.Enabled = False

        If MsgBox("Etes vous sûr de vouloir supprimer?", vbYesNo, "Suppression") = MsgBoxResult.Yes Then
            Dim xe As String = "data source=xe;user id=system;password=firas123;"
            Dim con As New OracleConnection(xe)
            con.Open()
            Dim sup1 As New OracleParameter
            sup1.OracleDbType = OracleDbType.Varchar2
            sup1.Value = tb_id_invite.Text
            Dim sup2 As New OracleParameter
            sup2.OracleDbType = OracleDbType.Varchar2
            sup2.Value = id_evenemenet()
            Dim cm As New OracleCommand
            cm.Connection = con
            cm.Parameters.Add(sup1)
            cm.Parameters.Add(sup2)

            cm.CommandText = "DELETE FROM participe_invite where id_invite=:1 and id_evenement=:2"
            cm.CommandType = CommandType.Text
            Dim dr As OracleDataReader = cm.ExecuteReader()

            con.Dispose()

            bt_Afficher_Nombre_Présence.Enabled = True
            bt_ajouter.Enabled = False
            bt_Chercher.Enabled = True
            bt_Enregistrer.Enabled = False
            bt_modifier.Enabled = False
            bt_Supprimer.Enabled = False
            tb__Afficher_Nombre_Présence.Enabled = False
            tb_id_invite.Enabled = True
            cb__Nom_Evenement.Enabled = True
            r_non.Enabled = False
            r_oui.Enabled = False
            tb_id_invite.Text = ""
            tb__Afficher_Nombre_Présence.Text = ""
            cb__Nom_Evenement.Text = ""
            r_non.Checked = False
            r_oui.Checked = False
            MsgBox("supprission avec succés")

            DataGridView2.Rows.Clear()


            Dim con18 As New OracleConnection(xe)
            con18.Open()


            Dim cmd18 As New OracleCommand
            cmd18.Connection = con18

            cmd18.CommandText = "select *  from   participe_invite "
            cmd18.CommandType = CommandType.Text
            Dim dr18 As OracleDataReader = cmd18.ExecuteReader()
            While dr18.Read()
                DataGridView2.Rows.Add(dr18.Item("id_evenement"), dr18.Item("id_invite"), dr18.Item("presence_invite"))

            End While
            con18.Dispose()

        End If
    End Sub

    Private Sub bt_Enregistrer_Click(sender As Object, e As EventArgs) Handles bt_Enregistrer.Click

        Dim xe As String = "data source=xe;user id=system;password=firas123;"
        Dim con As New OracleConnection(xe)
        con.Open()

        Dim parm1 As New OracleParameter
        parm1.OracleDbType = OracleDbType.Varchar2
        parm1.Value = tb_id_invite.Text

        Dim parm2 As New OracleParameter
        parm2.OracleDbType = OracleDbType.Varchar2
        parm2.Value = id_evenemenet()

        Dim cmd As New OracleCommand
        cmd.Connection = con
        cmd.Parameters.Add(parm1)
        cmd.Parameters.Add(parm2)

        cmd.CommandText = "select * from participe_invite where id_invite=:1 and id_evenement=:2"
        cmd.CommandType = CommandType.Text

        Dim dr As OracleDataReader = cmd.ExecuteReader()
        If dr.Read() = False Then
            con.Dispose()
            If MsgBox("Etes vous sûr de vouloir ajouter?", vbYesNo, "Ajouter") = MsgBoxResult.Yes Then

                Dim con5 As New OracleConnection(xe)
                con5.Open()

                Dim paranoa As New OracleParameter
                paranoa.OracleDbType = OracleDbType.Varchar2
                paranoa.Value = tb_id_invite.Text
                Dim cmd5 As New OracleCommand
                cmd5.Connection = con5
                cmd5.Parameters.Add(paranoa)
                cmd5.CommandText = "select * from invite where id_invite=:1 "
                cmd5.CommandType = CommandType.Text
                Dim dr5 As OracleDataReader = cmd5.ExecuteReader()
                If dr5.Read() = False Then
                    con5.Dispose()
                    bt_Afficher_Nombre_Présence.Enabled = True
                    bt_Chercher.Enabled = True
                    bt_modifier.Enabled = False
                    bt_ajouter.Enabled = False
                    bt_Enregistrer.Enabled = False
                    bt_Supprimer.Enabled = False
                    tb__Afficher_Nombre_Présence.Enabled = False
                    tb_id_invite.Enabled = True
                    cb__Nom_Evenement.Enabled = True
                    r_oui.Enabled = False
                    r_non.Enabled = False
                    tb_id_invite.Text = ""
                    cb__Nom_Evenement.Text = ""
                    r_non.Checked = False
                    r_oui.Checked = False
                    MessageBox.Show("oups,desolé il faut saisir le personne dans l'espace des invités  avant que lui est affecter à l'evenemenent " + cb__Nom_Evenement.Text, "erreur")
                Else
                    con5.Dispose()
                    Dim con10 As New OracleConnection(xe)
                    con10.Open()
                    Dim parm3 As New OracleParameter
                    parm3.OracleDbType = OracleDbType.Varchar2
                    parm3.Value = tb_id_invite.Text
                    Dim parm4 As New OracleParameter
                    parm4.OracleDbType = OracleDbType.Varchar2
                    parm4.Value = id_evenemenet()
                    Dim parm5 As New OracleParameter
                    parm5.OracleDbType = OracleDbType.Varchar2

                    If r_oui.Checked = True Then
                        parm5.Value = "Oui"
                    Else
                        parm5.Value = "Non"

                    End If

                    Dim cmd10 As New OracleCommand
                    cmd10.Connection = con10
                    cmd10.Parameters.Add(parm3)
                    cmd10.Parameters.Add(parm4)
                    cmd10.Parameters.Add(parm5)

                    cmd10.CommandText = "insert into participe_invite(id_invite,ID_EVENEMENT,presence_invite) values(:1,:2,:3)"
                    cmd10.CommandType = CommandType.Text

                    Dim dr10 As OracleDataReader = cmd10.ExecuteReader()
                    con10.Dispose()
                    bt_Afficher_Nombre_Présence.Enabled = True
                    bt_ajouter.Enabled = False
                    bt_Chercher.Enabled = True
                    bt_Enregistrer.Enabled = False
                    bt_modifier.Enabled = False
                    bt_Supprimer.Enabled = False
                    tb__Afficher_Nombre_Présence.Enabled = False
                    tb_id_invite.Enabled = True
                    cb__Nom_Evenement.Enabled = True
                    r_non.Enabled = False
                    r_oui.Enabled = False
                    tb_id_invite.Text = ""
                    tb__Afficher_Nombre_Présence.Text = ""
                    cb__Nom_Evenement.Text = ""
                    r_non.Checked = False
                    r_oui.Checked = False
                    MsgBox("ligne ajoutéé avec succée")

                    DataGridView2.Rows.Clear()


                    Dim con18 As New OracleConnection(xe)
                    con18.Open()


                    Dim cmd18 As New OracleCommand
                    cmd18.Connection = con18

                    cmd18.CommandText = "select *  from   participe_invite "
                    cmd18.CommandType = CommandType.Text
                    Dim dr18 As OracleDataReader = cmd18.ExecuteReader()
                    While dr18.Read()
                        DataGridView2.Rows.Add(dr18.Item("id_evenement"), dr18.Item("id_invite"), dr18.Item("presence_invite"))

                    End While
                    con18.Dispose()


                End If


            End If
        Else
            con.Dispose()
            If MsgBox("Etes vous sûr de vouloir modifier?", vbYesNo, "Modifier") = MsgBoxResult.Yes Then
                Dim con10 As New OracleConnection(xe)
                con10.Open()
                Dim parm3 As New OracleParameter
                parm3.OracleDbType = OracleDbType.Varchar2
                parm3.Value = tb_id_invite.Text
                Dim parm4 As New OracleParameter
                parm4.OracleDbType = OracleDbType.Varchar2
                parm4.Value = id_evenemenet()
                Dim parm5 As New OracleParameter
                parm5.OracleDbType = OracleDbType.Varchar2

                If r_oui.Checked = True Then
                    parm5.Value = "Oui"
                Else
                    parm5.Value = "Non"

                End If
                Dim cmd10 As New OracleCommand
                cmd10.Connection = con10
                cmd10.Parameters.Add(parm3)
                cmd10.Parameters.Add(parm4)
                cmd10.Parameters.Add(parm5)

                cmd10.CommandText = "update participe_invite set id_invite=:1,ID_EVENEMENT=:2,presence_invite=:3 where id_invite=:1 and ID_EVENEMENT=:2"
                cmd10.CommandType = CommandType.Text

                Dim dr10 As OracleDataReader = cmd10.ExecuteReader()
                con10.Dispose()


                bt_Afficher_Nombre_Présence.Enabled = True
                bt_ajouter.Enabled = False
                bt_Chercher.Enabled = True
                bt_Enregistrer.Enabled = False
                bt_modifier.Enabled = False
                bt_Supprimer.Enabled = False
                tb__Afficher_Nombre_Présence.Enabled = False
                tb_id_invite.Enabled = True
                cb__Nom_Evenement.Enabled = True
                r_non.Enabled = False
                r_oui.Enabled = False
                tb_id_invite.Text = ""
                tb__Afficher_Nombre_Présence.Text = ""
                cb__Nom_Evenement.Text = ""
                r_non.Checked = False
                r_oui.Checked = False
                MsgBox("ligne modifier avec succée")


                DataGridView2.Rows.Clear()


                Dim con18 As New OracleConnection(xe)
                con18.Open()


                Dim cmd18 As New OracleCommand
                cmd18.Connection = con18

                cmd18.CommandText = "select *  from   participe_invite "
                cmd18.CommandType = CommandType.Text
                Dim dr18 As OracleDataReader = cmd18.ExecuteReader()
                While dr18.Read()
                    DataGridView2.Rows.Add(dr18.Item("id_evenement"), dr18.Item("id_invite"), dr18.Item("presence_invite"))

                End While
                con18.Dispose()


            End If
        End If
    End Sub

    Private Sub bt_Afficher_Nombre_Présence_Click(sender As Object, e As EventArgs) Handles bt_Afficher_Nombre_Présence.Click
        If verif2() Then


            Dim xe As String = "data source=xe;user id=system;password=firas123;"
            Dim con As New OracleConnection(xe)
            con.Open()
            Dim parm As New OracleParameter
            parm.OracleDbType = OracleDbType.Varchar2
            parm.Value = id_evenemenet()

            Dim cmd As New OracleCommand
            cmd.Connection = con
            cmd.Parameters.Add(parm)
            cmd.CommandText = "select count(PRESENCE_INVITE) from PARTICIPE_INVITE where ID_EVENEMENT=:1 and PRESENCE_INVITE='Oui'"
            cmd.CommandType = CommandType.Text

            Dim dr As OracleDataReader = cmd.ExecuteReader()
            If dr.Read() Then
                tb__Afficher_Nombre_Présence.Text = dr.Item("count(PRESENCE_INVITE)")
            End If
        Else
            MessageBox.Show("il faut preciser l'evenement qui vous veut voir le nombre de presence des invités dans celle ci ", "erreur")
        End If
    End Sub

    Private Sub bt_Quitter_Click(sender As Object, e As EventArgs) Handles bt_Quitter.Click
        Me.Close()
        connexion.Close()
    End Sub
End Class