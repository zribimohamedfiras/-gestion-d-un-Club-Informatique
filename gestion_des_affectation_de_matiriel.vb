Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types


Public Class gestion_des_affectation_de_matiriel

    Function verif() As Boolean
        Dim v As Boolean = True
        If tb_id_matériel.Text Is Nothing And tb_id_matériel.Text = "" Then
            v = False
        Else
            If tb_id_matériel.Text(0) <> "m" Then
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

    Private Sub bt_retour_Click(sender As Object, e As EventArgs) Handles bt_retour.Click
        Rebrique_Secrétaire_Général.Show()

        tb_id_matériel.Text = ""

        tb_prix.Text = ""
        tb_Quantite.Text = ""
        tb_afficher_prix.Text = ""
        cb__Nom_Evenement.Text = ""
        cb__Nom_Evenement.Text = ""
        bt_Afficher_Prix_total_materiel.Enabled = True
        bt_ajouter.Enabled = False
        bt_chercher.Enabled = True
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False
        tb_afficher_prix.Enabled = False
        tb_id_matériel.Enabled = True
        tb_prix.Enabled = False
        cb__Nom_Evenement.Enabled = True
        tb_Quantite.Enabled = False
        Me.Close()
    End Sub

    Private Sub bt_annuler_Click(sender As Object, e As EventArgs) Handles bt_annuler.Click
        tb_id_matériel.Text = ""

        tb_prix.Text = ""
        tb_Quantite.Text = ""
        tb_afficher_prix.Text = ""
        cb__Nom_Evenement.Text = ""
        bt_Afficher_Prix_total_materiel.Enabled = True
        bt_ajouter.Enabled = False
        bt_chercher.Enabled = True
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False
        tb_afficher_prix.Enabled = False
        tb_id_matériel.Enabled = True
        tb_Quantite.Enabled = False
        tb_prix.Enabled = False

        cb__Nom_Evenement.Enabled = True
    End Sub

    Private Sub gestion_des_affectation_de_matiriel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_id_matériel.Text = ""
        tb_prix.Text = ""
        tb_afficher_prix.Text = ""
        cb__Nom_Evenement.Text = ""
        tb_Quantite.Text = ""
        bt_Afficher_Prix_total_materiel.Enabled = True
        bt_ajouter.Enabled = False
        bt_chercher.Enabled = True
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False
        tb_afficher_prix.Enabled = False
        tb_id_matériel.Enabled = True
        tb_prix.Enabled = False
        tb_Quantite.Enabled = False
        cb__Nom_Evenement.Enabled = True



        Dim xe As String = "data source=xe;user id=system;password=firas123;"


        DataGridView1.Rows.Clear()


        Dim con1 As New OracleConnection(xe)
        con1.Open()


        Dim cmd1 As New OracleCommand
        cmd1.Connection = con1

        cmd1.CommandText = "select * from MATERIEL "
        cmd1.CommandType = CommandType.Text
        Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
        While dr1.Read()
            DataGridView1.Rows.Add(dr1.Item("ID_MATERIEL"), dr1.Item("NOM_MATERIEL"), dr1.Item("TYPE_MATERIEL"))

        End While
        con1.Dispose()

        DataGridView2.Rows.Clear()

        Dim con As New OracleConnection(xe)
        con.Open()
        Dim cmd As New OracleCommand
        cmd.Connection = con
        cmd.CommandText = "select NOM_EVENEMENT from EVENEMENT "
        cmd.CommandType = CommandType.Text
        Dim dr As OracleDataReader = cmd.ExecuteReader()
        While dr.Read()
            cb__Nom_Evenement.Items.Add(dr.Item("NOM_EVENEMENT"))
        End While
        con.Dispose()


        Dim con18 As New OracleConnection(xe)
        con18.Open()


        Dim cmd18 As New OracleCommand
        cmd18.Connection = con18

        cmd18.CommandText = "select * from UTILISE_MATERIEL "
        cmd18.CommandType = CommandType.Text
        Dim dr18 As OracleDataReader = cmd18.ExecuteReader()
        While dr18.Read()
            DataGridView2.Rows.Add(dr18.Item("ID_EVENEMENT"), dr18.Item("ID_MATERIEL"), dr18.Item("QUANTITE"))

        End While
        con18.Dispose()

    End Sub

    Private Sub bt_chercher_Click(sender As Object, e As EventArgs) Handles bt_chercher.Click
        bt_ajouter.Enabled = False
        bt_chercher.Enabled = True
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False
        tb_id_matériel.Enabled = True
        tb_prix.Enabled = False
        tb_Quantite.Enabled = False
        cb__Nom_Evenement.Enabled = True
        tb_prix.Text = ""
        tb_afficher_prix.Text = ""
        tb_Quantite.Text = ""
        If verif() And verif2() Then
            Dim xe As String = "data source=xe;user id=system;password=firas123;"
            Dim con1 As New OracleConnection(xe)
            con1.Open()
            Dim parm1 As New OracleParameter
            parm1.OracleDbType = OracleDbType.Varchar2
            parm1.Value = id_evenemenet()
            Dim parm2 As New OracleParameter
            parm2.OracleDbType = OracleDbType.Varchar2
            parm2.Value = tb_id_matériel.Text
            Dim cmd1 As New OracleCommand
            cmd1.Connection = con1
            cmd1.Parameters.Add(parm1)
            cmd1.Parameters.Add(parm2)
            cmd1.CommandText = "select * from utilise_materiel where id_evenement=:1 and id_materiel=:2"
            cmd1.CommandType = CommandType.Text
            Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
            If dr1.Read() Then
                tb_prix.Text = dr1.Item("prix_materiel")
                tb_Quantite.Text = dr1.Item("quantite")
                bt_ajouter.Enabled = False
                bt_chercher.Enabled = True
                bt_enregistrer.Enabled = False
                bt_modifier.Enabled = True
                bt_supprimer.Enabled = True
                bt_chercher.Enabled = False
                con1.Dispose()


            Else
                If MsgBox("affectation possible si " + tb_id_matériel.Text + " trouver dans la base de donnes", vbYesNo, "tu peut affecter ce materiel à l'evenement " + cb__Nom_Evenement.Text) = MsgBoxResult.Yes Then
                    bt_ajouter.Enabled = True
                    bt_chercher.Enabled = False
                    bt_enregistrer.Enabled = False
                    bt_modifier.Enabled = False
                    bt_supprimer.Enabled = False
                    con1.Dispose()

                End If
            End If
        Else
            If verif() = False Then
                MsgBox("il faut introduire une chaine de caractere dont sa premier caracter est 'm'")
            End If
            If verif2() = False Then
                MsgBox("il doit respecter les evenement qui est annoncé dans le liste")
            End If
        End If
    End Sub

    Private Sub bt_ajouter_Click(sender As Object, e As EventArgs) Handles bt_ajouter.Click

        tb_prix.Text = ""
        tb_afficher_prix.Text = ""

        tb_Quantite.Text = ""

        bt_ajouter.Enabled = False
        bt_chercher.Enabled = False
        bt_enregistrer.Enabled = True
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False

        tb_id_matériel.Enabled = False
        tb_prix.Enabled = True
        tb_Quantite.Enabled = True
        cb__Nom_Evenement.Enabled = False

    End Sub

    Private Sub bt_modifier_Click(sender As Object, e As EventArgs) Handles bt_modifier.Click

        bt_ajouter.Enabled = False
        bt_chercher.Enabled = False
        bt_enregistrer.Enabled = True
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False

        tb_id_matériel.Enabled = False
        tb_prix.Enabled = True
        tb_Quantite.Enabled = True
        cb__Nom_Evenement.Enabled = False
    End Sub

    Private Sub bt_supprimer_Click(sender As Object, e As EventArgs) Handles bt_supprimer.Click
        bt_chercher.Enabled = False

        If MsgBox("Etes vous sûr de vouloir supprimer?", vbYesNo, "Suppression") = MsgBoxResult.Yes Then
            Dim xe As String = "data source=xe;user id=system;password=firas123;"
            Dim con As New OracleConnection(xe)
            con.Open()
            Dim sup1 As New OracleParameter
            sup1.OracleDbType = OracleDbType.Varchar2
            sup1.Value = tb_id_matériel.Text
            Dim sup2 As New OracleParameter
            sup2.OracleDbType = OracleDbType.Varchar2
            sup2.Value = id_evenemenet()
            Dim cm As New OracleCommand
            cm.Connection = con
            cm.Parameters.Add(sup1)
            cm.Parameters.Add(sup2)

            cm.CommandText = "DELETE FROM utilise_materiel where id_materiel=:1 and id_evenement=:2"
            cm.CommandType = CommandType.Text
            Dim dr As OracleDataReader = cm.ExecuteReader()

            con.Dispose()
            tb_id_matériel.Text = ""
            tb_prix.Text = ""
            tb_afficher_prix.Text = ""
            cb__Nom_Evenement.Text = ""
            tb_Quantite.Text = ""
            bt_Afficher_Prix_total_materiel.Enabled = True
            bt_ajouter.Enabled = False
            bt_chercher.Enabled = True
            bt_enregistrer.Enabled = False
            bt_modifier.Enabled = False
            bt_supprimer.Enabled = False
            tb_afficher_prix.Enabled = False
            tb_id_matériel.Enabled = True
            tb_prix.Enabled = False
            tb_Quantite.Enabled = False
            cb__Nom_Evenement.Enabled = True
            MsgBox("supprission avec succés")
            DataGridView2.Rows.Clear()

            Dim con18 As New OracleConnection(xe)
            con18.Open()


            Dim cmd18 As New OracleCommand
            cmd18.Connection = con18

            cmd18.CommandText = "select * from UTILISE_MATERIEL "
            cmd18.CommandType = CommandType.Text
            Dim dr18 As OracleDataReader = cmd18.ExecuteReader()
            While dr18.Read()
                DataGridView2.Rows.Add(dr18.Item("ID_EVENEMENT"), dr18.Item("ID_MATERIEL"), dr18.Item("QUANTITE"))

            End While
            con18.Dispose()

        End If

    End Sub

    Private Sub bt_enregistrer_Click(sender As Object, e As EventArgs) Handles bt_enregistrer.Click
        Dim xe As String = "data source=xe;user id=system;password=firas123;"
        Dim con1 As New OracleConnection(xe)
        con1.Open()
        Dim parm1 As New OracleParameter
        parm1.OracleDbType = OracleDbType.Varchar2
        parm1.Value = id_evenemenet()
        Dim parm2 As New OracleParameter
        parm2.OracleDbType = OracleDbType.Varchar2
        parm2.Value = tb_id_matériel.Text
        Dim cmd1 As New OracleCommand
        cmd1.Connection = con1
        cmd1.Parameters.Add(parm1)
        cmd1.Parameters.Add(parm2)
        cmd1.CommandText = "select * from utilise_materiel where id_evenement=:1 and id_materiel=:2"
        cmd1.CommandType = CommandType.Text
        Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
        If dr1.Read() = False Then
            con1.Dispose()
            If MsgBox("Etes vous sûr de vouloir ajouter?", vbYesNo, "Ajouter") = MsgBoxResult.Yes Then
                Dim con5 As New OracleConnection(xe)
                con5.Open()



                Dim paranoa As New OracleParameter
                paranoa.OracleDbType = OracleDbType.Varchar2
                paranoa.Value = tb_id_matériel.Text
                Dim cmd5 As New OracleCommand
                cmd5.Connection = con5
                cmd5.Parameters.Add(paranoa)
                cmd5.CommandText = "select * from MATERIEL where id_materiel =:1 "
                cmd5.CommandType = CommandType.Text
                Dim dr5 As OracleDataReader = cmd5.ExecuteReader()
                If dr5.Read() = False Then
                    con5.Dispose()
                    tb_id_matériel.Text = ""
                    tb_prix.Text = ""
                    tb_afficher_prix.Text = ""
                    cb__Nom_Evenement.Text = ""
                    tb_Quantite.Text = ""
                    bt_Afficher_Prix_total_materiel.Enabled = True
                    bt_ajouter.Enabled = False
                    bt_chercher.Enabled = True
                    bt_enregistrer.Enabled = False
                    bt_modifier.Enabled = False
                    bt_supprimer.Enabled = False
                    tb_afficher_prix.Enabled = False
                    tb_id_matériel.Enabled = True
                    tb_prix.Enabled = False
                    tb_Quantite.Enabled = False
                    cb__Nom_Evenement.Enabled = True
                    MessageBox.Show("oups,desolé il faut saisir le materiel dans l'espace de saisie de materiel avant que lui est affecter à l'evenemenent " + cb__Nom_Evenement.Text, "erreur")
                Else
                    con5.Dispose()
                    Dim con2 As New OracleConnection(xe)
                    con2.Open()
                    Dim parm3 As New OracleParameter
                    parm3.OracleDbType = OracleDbType.Varchar2
                    parm3.Value = tb_id_matériel.Text
                    Dim parm4 As New OracleParameter
                    parm4.OracleDbType = OracleDbType.Varchar2
                    parm4.Value = id_evenemenet()
                    Dim parm5 As New OracleParameter
                    parm5.OracleDbType = OracleDbType.Varchar2
                    parm5.Value = tb_prix.Text
                    Dim parm6 As New OracleParameter
                    parm6.OracleDbType = OracleDbType.Varchar2
                    parm6.Value = tb_Quantite.Text

                    Dim cmd3 As New OracleCommand
                    cmd3.Connection = con2
                    cmd3.Parameters.Add(parm3)
                    cmd3.Parameters.Add(parm4)
                    cmd3.Parameters.Add(parm5)
                    cmd3.Parameters.Add(parm6)

                    cmd3.CommandText = "insert into UTILISE_MATERIEL(ID_MATERIEL,ID_EVENEMENT,PRIX_MATERIEL,QUANTITE) values(:1,:2,:3,:4)"
                    cmd3.CommandType = CommandType.Text

                    Dim dr3 As OracleDataReader = cmd3.ExecuteReader()
                    con2.Dispose()
                    tb_id_matériel.Text = ""
                    tb_prix.Text = ""
                    tb_afficher_prix.Text = ""
                    cb__Nom_Evenement.Text = ""
                    tb_Quantite.Text = ""
                    bt_Afficher_Prix_total_materiel.Enabled = True
                    bt_ajouter.Enabled = False
                    bt_chercher.Enabled = True
                    bt_enregistrer.Enabled = False
                    bt_modifier.Enabled = False
                    bt_supprimer.Enabled = False
                    tb_afficher_prix.Enabled = False
                    tb_id_matériel.Enabled = True
                    tb_prix.Enabled = False
                    tb_Quantite.Enabled = False
                    cb__Nom_Evenement.Enabled = True
                    MsgBox("Materiel ajoutéé avec succée")
                    DataGridView2.Rows.Clear()

                    Dim con18 As New OracleConnection(xe)
                    con18.Open()


                    Dim cmd18 As New OracleCommand
                    cmd18.Connection = con18

                    cmd18.CommandText = "select * from UTILISE_MATERIEL "
                    cmd18.CommandType = CommandType.Text
                    Dim dr18 As OracleDataReader = cmd18.ExecuteReader()
                    While dr18.Read()
                        DataGridView2.Rows.Add(dr18.Item("ID_EVENEMENT"), dr18.Item("ID_MATERIEL"), dr18.Item("QUANTITE"))

                    End While
                    con18.Dispose()

                End If
            End If
        Else
            con1.Dispose()
            If MsgBox("Etes vous sûr de vouloir modifier?", vbYesNo, "Modifier") = MsgBoxResult.Yes Then
                Dim con2 As New OracleConnection(xe)
                con2.Open()
                Dim parm3 As New OracleParameter
                parm3.OracleDbType = OracleDbType.Varchar2
                parm3.Value = tb_id_matériel.Text
                Dim parm4 As New OracleParameter
                parm4.OracleDbType = OracleDbType.Varchar2
                parm4.Value = id_evenemenet()
                Dim parm5 As New OracleParameter
                parm5.OracleDbType = OracleDbType.Decimal
                parm5.Value = tb_prix.Text
                Dim parm6 As New OracleParameter
                parm6.OracleDbType = OracleDbType.Int64
                parm6.Value = tb_Quantite.Text

                Dim cmd3 As New OracleCommand
                cmd3.Connection = con2
                cmd3.Parameters.Add(parm3)
                cmd3.Parameters.Add(parm4)
                cmd3.Parameters.Add(parm5)
                cmd3.Parameters.Add(parm6)

                cmd3.CommandText = "update UTILISE_MATERIEL set ID_MATERIEL=:1,ID_EVENEMENT=:2,PRIX_MATERIEL=:3,QUANTITE=:4 where ID_MATERIEL=:1 and ID_EVENEMENT=:2"
                cmd3.CommandType = CommandType.Text

                Dim dr3 As OracleDataReader = cmd3.ExecuteReader()
                con2.Dispose()
                tb_id_matériel.Text = ""
                tb_prix.Text = ""
                tb_afficher_prix.Text = ""
                cb__Nom_Evenement.Text = ""
                tb_Quantite.Text = ""
                bt_Afficher_Prix_total_materiel.Enabled = True
                bt_ajouter.Enabled = False
                bt_chercher.Enabled = True
                bt_enregistrer.Enabled = False
                bt_modifier.Enabled = False
                bt_supprimer.Enabled = False
                tb_afficher_prix.Enabled = False
                tb_id_matériel.Enabled = True
                tb_prix.Enabled = False
                tb_Quantite.Enabled = False
                cb__Nom_Evenement.Enabled = True
                MsgBox("Materiel modifier avec succée")
                DataGridView2.Rows.Clear()

                Dim con18 As New OracleConnection(xe)
                con18.Open()


                Dim cmd18 As New OracleCommand
                cmd18.Connection = con18

                cmd18.CommandText = "select * from UTILISE_MATERIEL "
                cmd18.CommandType = CommandType.Text
                Dim dr18 As OracleDataReader = cmd18.ExecuteReader()
                While dr18.Read()
                    DataGridView2.Rows.Add(dr18.Item("ID_EVENEMENT"), dr18.Item("ID_MATERIEL"), dr18.Item("QUANTITE"))

                End While
                con18.Dispose()

            End If
        End If
    End Sub

    Private Sub bt_Afficher_Prix_total_materiel_Click(sender As Object, e As EventArgs) Handles bt_Afficher_Prix_total_materiel.Click
        If verif2() Then
            Dim xe As String = "data source=xe;user id=system;password=firas123;"
            Dim con18 As New OracleConnection(xe)
            con18.Open()
            Dim parm As New OracleParameter
            parm.OracleDbType = OracleDbType.Varchar2
            parm.Value = id_evenemenet()

            Dim cmd18 As New OracleCommand
            cmd18.Connection = con18
            cmd18.Parameters.Add(parm)
            cmd18.CommandText = "select sum(PRIX_MATERIEL) from UTILISE_MATERIEL where ID_EVENEMENT=:1 "
            cmd18.CommandType = CommandType.Text

            Dim x As Decimal = cmd18.ExecuteScalar()
            Dim dr18 As OracleDataReader = cmd18.ExecuteReader()
            If dr18.Read() Then
                tb_afficher_prix.Text = x
            Else
                MessageBox.Show("cet evenement n'y a aucun materiel lui à affecter", "vous devez saisir des materiel dans cette evenement")
            End If
        Else
            MessageBox.Show("il faut detterminer l'evenement qui tu veut voir leur cout !", "erreur")
        End If
    End Sub

    Private Sub bt_Quitter_Click(sender As Object, e As EventArgs) Handles bt_Quitter.Click
        Me.Close()
        connexion.Close()
    End Sub
End Class