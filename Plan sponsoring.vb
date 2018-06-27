Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types


Public Class Plan_sponsoring

    Private Sub bt_retour_Click_1(sender As Object, e As EventArgs) Handles bt_retour.Click
        Plan_générale.Show()

        tb_ID_PLANING.Text = ""
        tb_NCIN_responsable.Text = ""
        tb_nom_planing.Text = ""
        cb_evenement.Text = ""
        tb_plan_generale.Text = ""

        tb_ID_PLANING.Enabled = True
        tb_NCIN_responsable.Enabled = False

        tb_plan_generale.Enabled = False
        cb_evenement.Enabled = False

        bt_Ajouter.Enabled = False
        bt_chercher.Enabled = True
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False
        Me.Close()
    End Sub

    Private Sub bt_Annuler_Click_1(sender As Object, e As EventArgs) Handles bt_Annuler.Click

        tb_ID_PLANING.Text = ""
        tb_NCIN_responsable.Text = ""
        tb_nom_planing.Text = ""
        cb_evenement.Text = ""
        tb_plan_generale.Text = ""

        tb_ID_PLANING.Enabled = True
        tb_NCIN_responsable.Enabled = False

        tb_plan_generale.Enabled = False
        cb_evenement.Enabled = False

        bt_Ajouter.Enabled = False
        bt_chercher.Enabled = True
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False
    End Sub

    Private Sub Plan_sponsoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_ID_PLANING.Text = ""
        tb_NCIN_responsable.Text = ""
        tb_nom_planing.Text = ""
        cb_evenement.Text = ""
        tb_plan_generale.Text = ""
        tb_ID_PLANING.Enabled = True
        tb_NCIN_responsable.Enabled = False

        tb_plan_generale.Enabled = False
        cb_evenement.Enabled = False

        bt_Ajouter.Enabled = False
        bt_chercher.Enabled = True
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False

        Dim xe As String = "data source=xe;user id=system;password=firas123;"

        Dim con As New OracleConnection(xe)
        con.Open()
        Dim cmd As New OracleCommand
        cmd.Connection = con
        cmd.CommandText = "select NOM_EVENEMENT from EVENEMENT "
        cmd.CommandType = CommandType.Text
        Dim dr As OracleDataReader = cmd.ExecuteReader()
        While dr.Read()
            cb_evenement.Items.Add(dr.Item("NOM_EVENEMENT"))
        End While
        con.Dispose()

        DataGridView1.Rows.Clear()


        Dim con1 As New OracleConnection(xe)
        con1.Open()


        Dim cmd1 As New OracleCommand
        cmd1.Connection = con1

        cmd1.CommandText = "select * from planing where nom_planing='sponsoring' "
        cmd1.CommandType = CommandType.Text
        Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
        While dr1.Read()
            DataGridView1.Rows.Add(dr1.Item("ID_PLANING"), dr1.Item("ID_EVENEMENT"), dr1.Item("PLAN_GENERAL"))

        End While
        con1.Dispose()
    End Sub

    Function verif() As Boolean
        Dim v As Boolean = True
        If tb_ID_PLANING.Text = "" Then
            v = False
        Else
            If tb_ID_PLANING.Text(0) <> "p" Then
                v = False

            End If
        End If

        Return v

    End Function

    Function verif2() As Boolean
        Dim v As Boolean = True
        Dim c As Boolean = False
        Dim i As Integer = 0

        If cb_evenement.Text Is Nothing Then

            v = False
        Else

            While i < cb_evenement.Items.Count() And c = False
                If cb_evenement.Text = cb_evenement.Items.Item(i) Then

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
        parm.Value = cb_evenement.Text

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


    Function nom_evenemenet(ByVal s As String) As String
        Dim xe As String = "data source=xe;user id=system;password=firas123;"
        Dim con As New OracleConnection(xe)
        con.Open()
        Dim parm As New OracleParameter
        parm.OracleDbType = OracleDbType.Varchar2
        parm.Value = s

        Dim cmd As New OracleCommand
        cmd.Connection = con
        cmd.Parameters.Add(parm)

        cmd.CommandText = "select nom_evenement from evenement where id_evenement=:1"
        cmd.CommandType = CommandType.Text
        Dim dr As OracleDataReader = cmd.ExecuteReader()
        dr.Read()
        Dim x As String = dr.Item("nom_evenement")


        con.Dispose()

        Return x
    End Function
    Private Sub bt_chercher_Click(sender As Object, e As EventArgs) Handles bt_chercher.Click
        cb_evenement.Text = ""
        tb_NCIN_responsable.Text = ""
        tb_nom_planing.Text = ""

        tb_plan_generale.Text = ""
        tb_ID_PLANING.Enabled = True
        tb_NCIN_responsable.Enabled = False

        tb_plan_generale.Enabled = False
        cb_evenement.Enabled = False

        bt_Ajouter.Enabled = False
        bt_chercher.Enabled = True
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False

        If verif() Then
            Dim xe As String = "data source=xe;user id=system;password=firas123;"
            Dim con1 As New OracleConnection(xe)
            con1.Open()

            Dim parm2 As New OracleParameter
            parm2.OracleDbType = OracleDbType.Varchar2
            parm2.Value = tb_ID_PLANING.Text
            Dim cmd1 As New OracleCommand
            cmd1.Connection = con1

            cmd1.Parameters.Add(parm2)
            cmd1.CommandText = "select * from PLANING where  ID_PLANING=:1"
            cmd1.CommandType = CommandType.Text
            Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
            If dr1.Read() Then
                tb_NCIN_responsable.Text = dr1.Item("NCIN_MEMBRE")
                tb_plan_generale.Text = dr1.Item("PLAN_GENERAL")
                cb_evenement.Text = nom_evenemenet(dr1.Item("ID_EVENEMENT"))
                tb_nom_planing.Text = dr1.Item("NOM_PLANING")
                If tb_nom_planing.Text = "sponsoring" Then
                    bt_Ajouter.Enabled = False
                    bt_chercher.Enabled = False
                    bt_enregistrer.Enabled = False
                    bt_modifier.Enabled = True
                    bt_supprimer.Enabled = True
                    con1.Dispose()
                Else

                    tb_ID_PLANING.Text = ""
                    tb_NCIN_responsable.Text = ""

                    cb_evenement.Text = ""
                    tb_plan_generale.Text = ""
                    tb_ID_PLANING.Enabled = True
                    tb_NCIN_responsable.Enabled = False

                    tb_plan_generale.Enabled = False
                    cb_evenement.Enabled = False

                    bt_Ajouter.Enabled = False
                    bt_chercher.Enabled = True
                    bt_enregistrer.Enabled = False
                    bt_modifier.Enabled = False
                    bt_supprimer.Enabled = False
                    MsgBox("cette id de planing est utiliser par un autre departement tu ne peuve pas voir ces information")
                End If
            Else

                    bt_Ajouter.Enabled = True
                bt_chercher.Enabled = False
                bt_enregistrer.Enabled = False
                bt_modifier.Enabled = False
                bt_supprimer.Enabled = False
                con1.Dispose()
            End If
        Else

            MsgBox("il faut introduire une chaine de caractere dont sa premier caracter est 'p'")

            End If
    End Sub

    Private Sub bt_modifier_Click(sender As Object, e As EventArgs) Handles bt_modifier.Click

        tb_nom_planing.Text = "sponsoring"
        tb_ID_PLANING.Enabled = False
        tb_NCIN_responsable.Enabled = True

        tb_plan_generale.Enabled = True
        cb_evenement.Enabled = True

        bt_Ajouter.Enabled = False
        bt_chercher.Enabled = False
        bt_enregistrer.Enabled = True
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False

    End Sub


    Private Sub bt_Ajouter_Click(sender As Object, e As EventArgs) Handles bt_Ajouter.Click
        tb_nom_planing.Text = "sponsoring"
        tb_ID_PLANING.Enabled = False
        tb_NCIN_responsable.Enabled = True

        tb_plan_generale.Enabled = True
        cb_evenement.Enabled = True

        bt_Ajouter.Enabled = False
        bt_chercher.Enabled = False
        bt_enregistrer.Enabled = True
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False
    End Sub

    Private Sub bt_supprimer_Click(sender As Object, e As EventArgs) Handles bt_supprimer.Click
        If MsgBox("Etes vous sûr de vouloir supprimer?", vbYesNo, "Suppression") = MsgBoxResult.Yes Then
            Dim xe As String = "data source=xe;user id=system;password=firas123;"
            Dim con As New OracleConnection(xe)
            con.Open()
            Dim sup1 As New OracleParameter
            sup1.OracleDbType = OracleDbType.Varchar2
            sup1.Value = tb_ID_PLANING.Text

            Dim cm As New OracleCommand
            cm.Connection = con
            cm.Parameters.Add(sup1)


            cm.CommandText = "DELETE FROM PLANING where ID_PLANING=:1 "
            cm.CommandType = CommandType.Text
            Dim dr As OracleDataReader = cm.ExecuteReader()

            con.Dispose()
            tb_ID_PLANING.Text = ""
            tb_NCIN_responsable.Text = ""
            tb_nom_planing.Text = ""
            cb_evenement.Text = ""
            tb_plan_generale.Text = ""
            tb_ID_PLANING.Enabled = True
            tb_NCIN_responsable.Enabled = False

            tb_plan_generale.Enabled = False
            cb_evenement.Enabled = False

            bt_Ajouter.Enabled = False
            bt_chercher.Enabled = True
            bt_enregistrer.Enabled = False
            bt_modifier.Enabled = False
            bt_supprimer.Enabled = False

            MsgBox("supprission avec succés")

            DataGridView1.Rows.Clear()


            Dim con1 As New OracleConnection(xe)
            con1.Open()


            Dim cmd1 As New OracleCommand
            cmd1.Connection = con1

            cmd1.CommandText = "select * from planing where nom_planing='sponsoring' "
            cmd1.CommandType = CommandType.Text
            Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
            While dr1.Read()
                DataGridView1.Rows.Add(dr1.Item("ID_PLANING"), dr1.Item("ID_EVENEMENT"), dr1.Item("PLAN_GENERAL"))

            End While
            con1.Dispose()
        End If
    End Sub

    Private Sub bt_enregistrer_Click(sender As Object, e As EventArgs) Handles bt_enregistrer.Click
        If verif2() Then


            Dim xe As String = "data source=xe;user id=system;password=firas123;"
            Dim con1 As New OracleConnection(xe)
            con1.Open()

            Dim parm2 As New OracleParameter
            parm2.OracleDbType = OracleDbType.Varchar2
            parm2.Value = tb_ID_PLANING.Text
            Dim cmd1 As New OracleCommand
            cmd1.Connection = con1

            cmd1.Parameters.Add(parm2)
            cmd1.CommandText = "select * from PLANING where  ID_PLANING=:1"
            cmd1.CommandType = CommandType.Text
            Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
            If dr1.Read() = False Then
                con1.Dispose()
                If MsgBox("Etes vous sûr de vouloir ajouter?", vbYesNo, "Ajouter") = MsgBoxResult.Yes Then
                    Dim con5 As New OracleConnection(xe)
                    con5.Open()
                    Dim parm3 As New OracleParameter
                    parm3.OracleDbType = OracleDbType.Int64
                    parm3.Value = tb_NCIN_responsable.Text

                    Dim cmd5 As New OracleCommand
                    cmd5.Connection = con5
                    cmd5.Parameters.Add(parm3)
                    cmd5.CommandText = "select * from MEMBRE where NCIN_MEMBRE=:1"
                    cmd5.CommandType = CommandType.Text
                    Dim dr5 As OracleDataReader = cmd5.ExecuteReader()
                    If dr5.Read() = False Then
                        con5.Dispose()

                        MessageBox.Show("ncin est incorrect il faut le corrigée ", "erreur")
                        tb_ID_PLANING.Text = ""
                        tb_NCIN_responsable.Text = ""
                        tb_nom_planing.Text = ""
                        cb_evenement.Text = ""
                        tb_plan_generale.Text = ""
                        tb_ID_PLANING.Enabled = True
                        tb_NCIN_responsable.Enabled = False

                        tb_plan_generale.Enabled = False
                        cb_evenement.Enabled = False

                        bt_Ajouter.Enabled = False
                        bt_chercher.Enabled = True
                        bt_enregistrer.Enabled = False
                        bt_modifier.Enabled = False
                        bt_supprimer.Enabled = False
                    Else
                        con5.Dispose()
                        If verif2() Then
                            Dim con10 As New OracleConnection(xe)
                            con10.Open()

                            Dim parm5 As New OracleParameter
                            parm5.OracleDbType = OracleDbType.Varchar2
                            parm5.Value = tb_ID_PLANING.Text

                            Dim parm6 As New OracleParameter
                            parm6.OracleDbType = OracleDbType.Int64
                            parm6.Value = Convert.ToInt64(tb_NCIN_responsable.Text)

                            Dim parm7 As New OracleParameter
                            parm7.OracleDbType = OracleDbType.Varchar2
                            parm7.Value = id_evenemenet()

                            Dim parm8 As New OracleParameter
                            parm8.OracleDbType = OracleDbType.Varchar2
                            parm8.Value = tb_nom_planing.Text

                            Dim parm9 As New OracleParameter
                            parm9.OracleDbType = OracleDbType.Varchar2
                            parm9.Value = tb_plan_generale.Text

                            Dim cmd10 As New OracleCommand
                            cmd10.Connection = con10
                            cmd10.Parameters.Add(parm5)
                            cmd10.Parameters.Add(parm8)
                            cmd10.Parameters.Add(parm9)
                            cmd10.Parameters.Add(parm6)
                            cmd10.Parameters.Add(parm7)
                            cmd10.CommandText = "insert into PLANING (ID_PLANING,NOM_PLANING,PLAN_GENERAL,NCIN_MEMBRE,ID_EVENEMENT) values(:1,:2,:3,:4,:5)"
                            cmd10.CommandType = CommandType.Text
                            Dim dr10 As OracleDataReader = cmd10.ExecuteReader()
                            con10.Dispose()

                            tb_ID_PLANING.Text = ""
                            tb_NCIN_responsable.Text = ""
                            tb_nom_planing.Text = ""
                            cb_evenement.Text = ""
                            tb_plan_generale.Text = ""
                            tb_ID_PLANING.Enabled = True
                            tb_NCIN_responsable.Enabled = False

                            tb_plan_generale.Enabled = False
                            cb_evenement.Enabled = False

                            bt_Ajouter.Enabled = False
                            bt_chercher.Enabled = True
                            bt_enregistrer.Enabled = False
                            bt_modifier.Enabled = False
                            bt_supprimer.Enabled = False

                            MsgBox("planing ajoutéé avec succée")
                            DataGridView1.Rows.Clear()


                            Dim con18 As New OracleConnection(xe)
                            con18.Open()


                            Dim cmd18 As New OracleCommand
                            cmd18.Connection = con18

                            cmd18.CommandText = "select * from planing where nom_planing='sponsoring' "
                            cmd18.CommandType = CommandType.Text
                            Dim dr18 As OracleDataReader = cmd18.ExecuteReader()
                            While dr18.Read()
                                DataGridView1.Rows.Add(dr18.Item("ID_PLANING"), dr18.Item("ID_EVENEMENT"), dr18.Item("PLAN_GENERAL"))

                            End While
                            con18.Dispose()
                        Else
                            MessageBox.Show("il faut que tu selectionné un evenement de la liste des evenement")
                        End If
                    End If

                End If
            Else
                con1.Dispose()
                If MsgBox("Etes vous sûr de vouloir modifier?", vbYesNo, "Modifier") = MsgBoxResult.Yes Then
                    Dim con5 As New OracleConnection(xe)
                    con5.Open()
                    Dim parm3 As New OracleParameter
                    parm3.OracleDbType = OracleDbType.Int64
                    parm3.Value = tb_NCIN_responsable.Text

                    Dim cmd5 As New OracleCommand
                    cmd5.Connection = con5
                    cmd5.Parameters.Add(parm3)
                    cmd5.CommandText = "select * from MEMBRE where NCIN_MEMBRE=:1"
                    cmd5.CommandType = CommandType.Text
                    Dim dr5 As OracleDataReader = cmd5.ExecuteReader()
                    If dr5.Read() = False Then
                        con5.Dispose()

                        MessageBox.Show("ncin est incorrect il faut le corrigée ", "erreur")
                        tb_ID_PLANING.Text = ""
                        tb_NCIN_responsable.Text = ""
                        tb_nom_planing.Text = ""
                        cb_evenement.Text = ""
                        tb_plan_generale.Text = ""
                        tb_ID_PLANING.Enabled = True
                        tb_NCIN_responsable.Enabled = False

                        tb_plan_generale.Enabled = False
                        cb_evenement.Enabled = False

                        bt_Ajouter.Enabled = False
                        bt_chercher.Enabled = True
                        bt_enregistrer.Enabled = False
                        bt_modifier.Enabled = False
                        bt_supprimer.Enabled = False
                    Else
                        con5.Dispose()
                        Dim con10 As New OracleConnection(xe)
                        con10.Open()

                        Dim parm5 As New OracleParameter
                        parm5.OracleDbType = OracleDbType.Varchar2
                        parm5.Value = tb_ID_PLANING.Text

                        Dim parm6 As New OracleParameter
                        parm6.OracleDbType = OracleDbType.Int64
                        parm6.Value = Convert.ToInt64(tb_NCIN_responsable.Text)

                        Dim parm7 As New OracleParameter
                        parm7.OracleDbType = OracleDbType.Varchar2
                        parm7.Value = id_evenemenet()

                        Dim parm8 As New OracleParameter
                        parm8.OracleDbType = OracleDbType.Varchar2
                        parm8.Value = tb_nom_planing.Text

                        Dim parm9 As New OracleParameter
                        parm9.OracleDbType = OracleDbType.Varchar2
                        parm9.Value = tb_plan_generale.Text

                        Dim cmd10 As New OracleCommand
                        cmd10.Connection = con10
                        cmd10.Parameters.Add(parm5)
                        cmd10.Parameters.Add(parm8)
                        cmd10.Parameters.Add(parm9)
                        cmd10.Parameters.Add(parm6)
                        cmd10.Parameters.Add(parm7)
                        cmd10.CommandText = "update PLANING set ID_PLANING=:1,NOM_PLANING=:2 ,PLAN_GENERAL=:3,NCIN_MEMBRE=:4,ID_EVENEMENT=:5 where ID_PLANING=:1 "
                        cmd10.CommandType = CommandType.Text
                        Dim dr10 As OracleDataReader = cmd10.ExecuteReader()
                        con10.Dispose()

                        tb_ID_PLANING.Text = ""
                        tb_NCIN_responsable.Text = ""
                        tb_nom_planing.Text = ""
                        cb_evenement.Text = ""
                        tb_plan_generale.Text = ""
                        tb_ID_PLANING.Enabled = True
                        tb_NCIN_responsable.Enabled = False

                        tb_plan_generale.Enabled = False
                        cb_evenement.Enabled = False

                        bt_Ajouter.Enabled = False
                        bt_chercher.Enabled = True
                        bt_enregistrer.Enabled = False
                        bt_modifier.Enabled = False
                        bt_supprimer.Enabled = False

                        MsgBox("planing modifier avec succée")
                        DataGridView1.Rows.Clear()


                        Dim con18 As New OracleConnection(xe)
                        con18.Open()


                        Dim cmd18 As New OracleCommand
                        cmd18.Connection = con18

                        cmd18.CommandText = "select * from planing where nom_planing='sponsoring' "
                        cmd18.CommandType = CommandType.Text
                        Dim dr18 As OracleDataReader = cmd18.ExecuteReader()
                        While dr18.Read()
                            DataGridView1.Rows.Add(dr18.Item("ID_PLANING"), dr18.Item("ID_EVENEMENT"), dr18.Item("PLAN_GENERAL"))

                        End While
                        con18.Dispose()

                    End If
                End If
            End If
        Else
            MessageBox.Show("il faut choisir l'evenement parmit la liste ", "erreur")
        End If
    End Sub

    Private Sub bt_Quitter_Click(sender As Object, e As EventArgs) Handles bt_Quitter.Click
        Me.Close()
        connexion.Close()
    End Sub
End Class