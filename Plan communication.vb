Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types


Public Class Plan_communication

    Private Sub bt_retour_Click(sender As Object, e As EventArgs) Handles bt_retour.Click
        Plan_générale.Show()


        tb_ID_PLANING.Text = ""
        tb_NCIN_responsable.Text = ""
        tb_nom_planing.Text = ""
        tb_plan_generale.Text = ""
        cb_evenement.Text = ""

        tb_ID_PLANING.Enabled = True
        tb_NCIN_responsable.Enabled = False
        tb_nom_planing.Enabled = False
        tb_plan_generale.Enabled = False
        cb_evenement.Enabled = False

        bt_Ajouter.Enabled = False
        bt_chercher.Enabled = True
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False
        Me.Close()

    End Sub

    Private Sub bt_Annuler_Click(sender As Object, e As EventArgs) Handles bt_Annuler.Click

        tb_ID_PLANING.Text = ""
        tb_NCIN_responsable.Text = ""
        tb_nom_planing.Text = ""
        tb_plan_generale.Text = ""
        cb_evenement.Text = ""

        tb_ID_PLANING.Enabled = True
        tb_NCIN_responsable.Enabled = False
        tb_nom_planing.Enabled = False
        tb_plan_generale.Enabled = False
        cb_evenement.Enabled = False

        bt_Ajouter.Enabled = False
        bt_chercher.Enabled = True
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False


    End Sub

    Private Sub Plan_communication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_ID_PLANING.Text = ""
        tb_NCIN_responsable.Text = ""
        tb_nom_planing.Text = ""
        tb_plan_generale.Text = ""
        cb_evenement.Text = ""

        tb_ID_PLANING.Enabled = True
        tb_NCIN_responsable.Enabled = False
        tb_nom_planing.Enabled = False
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

        cmd1.CommandText = "select * from planing where nom_planing='communication' "
        cmd1.CommandType = CommandType.Text
        Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
        While dr1.Read()
            DataGridView1.Rows.Add(dr1.Item("ID_PLANING"), dr1.Item("ID_EVENEMENT"), dr1.Item("PLAN_GENERAL"))

        End While
        con1.Dispose()

    End Sub

    Function verif() As Boolean
        Dim v As Boolean = True
        If tb_ID_PLANING.Text Is Nothing And tb_ID_PLANING.Text = "" Then
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

        tb_ID_PLANING.Enabled = True
        tb_NCIN_responsable.Enabled = False
        tb_nom_planing.Enabled = False
        tb_plan_generale.Enabled = False
        cb_evenement.Enabled = False

        bt_Ajouter.Enabled = False
        bt_chercher.Enabled = True
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False

        If verif() Then


            Dim xe As String = "data source=xe;user id=system;password=firas123;"
            Dim con As New OracleConnection(xe)
            con.Open()
            Dim parm As New OracleParameter
            parm.OracleDbType = OracleDbType.Varchar2
            parm.Value = tb_ID_PLANING.Text

            Dim cmd As New OracleCommand
            cmd.Connection = con
            cmd.Parameters.Add(parm)
            cmd.CommandText = "select * from planing where id_planing=:1"
            cmd.CommandType = CommandType.Text

            Dim dr As OracleDataReader = cmd.ExecuteReader()
            If dr.Read() Then
                If dr.Item("nom_planing") = "communication" Then
                    tb_NCIN_responsable.Text = dr.Item("ncin_membre")
                    tb_nom_planing.Text = dr.Item("nom_planing")
                    tb_plan_generale.Text = dr.Item("plan_general")
                    cb_evenement.Text = nom_evenemenet(dr.Item("id_evenement"))

                    tb_ID_PLANING.Enabled = True
                    tb_NCIN_responsable.Enabled = False
                    tb_nom_planing.Enabled = False
                    tb_plan_generale.Enabled = False
                    cb_evenement.Enabled = False

                    bt_Ajouter.Enabled = False
                    bt_chercher.Enabled = False
                    bt_enregistrer.Enabled = False
                    bt_modifier.Enabled = True
                    bt_supprimer.Enabled = True
                Else
                    MessageBox.Show("cette clé est utiliser par un autre departement ", "erreur")

                    tb_ID_PLANING.Text = ""
                    tb_NCIN_responsable.Text = ""
                    tb_nom_planing.Text = ""
                    tb_plan_generale.Text = ""
                    cb_evenement.Text = ""

                    tb_ID_PLANING.Enabled = True
                    tb_NCIN_responsable.Enabled = False
                    tb_nom_planing.Enabled = False
                    tb_plan_generale.Enabled = False
                    cb_evenement.Enabled = False

                    bt_Ajouter.Enabled = False
                    bt_chercher.Enabled = True
                    bt_enregistrer.Enabled = False
                    bt_modifier.Enabled = False
                    bt_supprimer.Enabled = False

                End If
            Else
                tb_ID_PLANING.Enabled = True
                tb_NCIN_responsable.Enabled = False
                tb_nom_planing.Enabled = False
                tb_plan_generale.Enabled = False
                cb_evenement.Enabled = False

                bt_Ajouter.Enabled = True
                bt_chercher.Enabled = False
                bt_enregistrer.Enabled = False
                bt_modifier.Enabled = False
                bt_supprimer.Enabled = False
            End If
        Else
            MessageBox.Show("il faut introduire une chaine dans sa premier caractere est 'p'")
            tb_ID_PLANING.Text = ""
            tb_NCIN_responsable.Text = ""
            tb_nom_planing.Text = ""
            tb_plan_generale.Text = ""
            cb_evenement.Text = ""

            tb_ID_PLANING.Enabled = True
            tb_NCIN_responsable.Enabled = False
            tb_nom_planing.Enabled = False
            tb_plan_generale.Enabled = False
            cb_evenement.Enabled = False

            bt_Ajouter.Enabled = False
            bt_chercher.Enabled = True
            bt_enregistrer.Enabled = False
            bt_modifier.Enabled = False
            bt_supprimer.Enabled = False

        End If
    End Sub

    Private Sub bt_Ajouter_Click(sender As Object, e As EventArgs) Handles bt_Ajouter.Click

        tb_nom_planing.Text = "communication"

        tb_ID_PLANING.Enabled = False
        tb_NCIN_responsable.Enabled = True
        tb_nom_planing.Enabled = False
        tb_plan_generale.Enabled = True
        cb_evenement.Enabled = True

        bt_Ajouter.Enabled = False
        bt_chercher.Enabled = False
        bt_enregistrer.Enabled = True
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False

    End Sub

    Private Sub bt_modifier_Click(sender As Object, e As EventArgs) Handles bt_modifier.Click

        tb_nom_planing.Text = "communication"

        tb_ID_PLANING.Enabled = False
        tb_NCIN_responsable.Enabled = True
        tb_nom_planing.Enabled = False
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

            Dim parm As New OracleParameter
            parm.OracleDbType = OracleDbType.Varchar2
            parm.Value = tb_ID_PLANING.Text

            Dim cmd As New OracleCommand
            cmd.Connection = con
            cmd.Parameters.Add(parm)
            cmd.CommandText = "delete from planing where ID_PLANING=:1"

            Dim dr As OracleDataReader = cmd.ExecuteReader()

            con.Dispose()

            tb_ID_PLANING.Text = ""
            tb_NCIN_responsable.Text = ""
            tb_nom_planing.Text = ""
            tb_plan_generale.Text = ""
            cb_evenement.Text = ""

            tb_ID_PLANING.Enabled = True
            tb_NCIN_responsable.Enabled = False
            tb_nom_planing.Enabled = False
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

            cmd1.CommandText = "select * from planing where nom_planing='communication' "
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
            Dim con As New OracleConnection(xe)
            con.Open()
            Dim parm As New OracleParameter
            parm.OracleDbType = OracleDbType.Varchar2
            parm.Value = tb_ID_PLANING.Text

            Dim cmd As New OracleCommand
            cmd.Connection = con
            cmd.Parameters.Add(parm)
            cmd.CommandText = "select * from planing where id_planing=:1"
            cmd.CommandType = CommandType.Text

            Dim dr As OracleDataReader = cmd.ExecuteReader()
            If dr.Read() = False Then
                con.Dispose()

                If MsgBox("Etes vous sûr de vouloir ajouter?", vbYesNo, "Ajouter") = MsgBoxResult.Yes Then
                    Dim con3 As New OracleConnection(xe)
                    con3.Open()

                    Dim ncin As New OracleParameter
                    ncin.OracleDbType = OracleDbType.Int64
                    ncin.Value = tb_NCIN_responsable.Text


                    Dim cmd3 As New OracleCommand
                    cmd3.Connection = con3
                    cmd3.Parameters.Add(ncin)
                    cmd3.CommandText = "select * from membre where NCIN_MEMBRE=:1"
                    cmd3.CommandType = CommandType.Text

                    Dim dr3 As OracleDataReader = cmd3.ExecuteReader()
                    If dr3.Read() = False Then
                        con3.Dispose()

                        MessageBox.Show("NCIN est incorect", "erreur")

                        tb_ID_PLANING.Text = ""
                        tb_NCIN_responsable.Text = ""
                        tb_nom_planing.Text = ""
                        tb_plan_generale.Text = ""
                        cb_evenement.Text = ""

                        tb_ID_PLANING.Enabled = True
                        tb_NCIN_responsable.Enabled = False
                        tb_nom_planing.Enabled = False
                        tb_plan_generale.Enabled = False
                        cb_evenement.Enabled = False

                        bt_Ajouter.Enabled = False
                        bt_chercher.Enabled = True
                        bt_enregistrer.Enabled = False
                        bt_modifier.Enabled = False
                        bt_supprimer.Enabled = False
                    Else
                        con3.Dispose()

                        Dim con5 As New OracleConnection(xe)
                        con5.Open()

                        Dim parm1 As New OracleParameter
                        parm1.OracleDbType = OracleDbType.Varchar2
                        parm1.Value = tb_ID_PLANING.Text
                        Dim parm2 As New OracleParameter
                        parm2.OracleDbType = OracleDbType.Varchar2
                        parm2.Value = tb_nom_planing.Text
                        Dim parm3 As New OracleParameter
                        parm3.OracleDbType = OracleDbType.Varchar2
                        parm3.Value = tb_plan_generale.Text
                        Dim parm4 As New OracleParameter
                        parm4.OracleDbType = OracleDbType.Int64
                        parm4.Value = tb_NCIN_responsable.Text
                        Dim parm5 As New OracleParameter
                        parm5.OracleDbType = OracleDbType.Varchar2
                        parm5.Value = id_evenemenet()

                        Dim cmd5 As New OracleCommand
                        cmd5.Connection = con5
                        cmd5.Parameters.Add(parm1)
                        cmd5.Parameters.Add(parm2)
                        cmd5.Parameters.Add(parm3)
                        cmd5.Parameters.Add(parm4)
                        cmd5.Parameters.Add(parm5)
                        cmd5.CommandText = "insert into PLANING (ID_PLANING,NOM_PLANING,PLAN_GENERAL,NCIN_MEMBRE,ID_EVENEMENT) values(:1,:2,:3,:4,:5)"
                        cmd5.CommandType = CommandType.Text

                        Dim dr5 As OracleDataReader = cmd5.ExecuteReader()
                        con5.Dispose()

                        tb_ID_PLANING.Text = ""
                        tb_NCIN_responsable.Text = ""
                        tb_nom_planing.Text = ""
                        tb_plan_generale.Text = ""
                        cb_evenement.Text = ""

                        tb_ID_PLANING.Enabled = True
                        tb_NCIN_responsable.Enabled = False
                        tb_nom_planing.Enabled = False
                        tb_plan_generale.Enabled = False
                        cb_evenement.Enabled = False

                        bt_Ajouter.Enabled = False
                        bt_chercher.Enabled = True
                        bt_enregistrer.Enabled = False
                        bt_modifier.Enabled = False
                        bt_supprimer.Enabled = False

                        MsgBox("ligne ajoutéé avec succée")

                        DataGridView1.Rows.Clear()


                        Dim con1 As New OracleConnection(xe)
                        con1.Open()


                        Dim cmd1 As New OracleCommand
                        cmd1.Connection = con1

                        cmd1.CommandText = "select * from planing where nom_planing='communication' "
                        cmd1.CommandType = CommandType.Text
                        Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
                        While dr1.Read()
                            DataGridView1.Rows.Add(dr1.Item("ID_PLANING"), dr1.Item("ID_EVENEMENT"), dr1.Item("PLAN_GENERAL"))

                        End While
                        con1.Dispose()
                    End If

                End If
            Else
                con.Dispose()
                If MsgBox("Etes vous sûr de vouloir modifier?", vbYesNo, "Modifier") = MsgBoxResult.Yes Then
                    Dim con3 As New OracleConnection(xe)
                    con3.Open()

                    Dim ncin As New OracleParameter
                    ncin.OracleDbType = OracleDbType.Int64
                    ncin.Value = tb_NCIN_responsable.Text


                    Dim cmd3 As New OracleCommand
                    cmd3.Connection = con3
                    cmd3.Parameters.Add(ncin)
                    cmd3.CommandText = "select * from membre where NCIN_MEMBRE=:1"
                    cmd3.CommandType = CommandType.Text

                    Dim dr3 As OracleDataReader = cmd3.ExecuteReader()
                    If dr3.Read() = False Then
                        con3.Dispose()

                        MessageBox.Show("NCIN est incorect", "erreur")

                        tb_ID_PLANING.Text = ""
                        tb_NCIN_responsable.Text = ""
                        tb_nom_planing.Text = ""
                        tb_plan_generale.Text = ""
                        cb_evenement.Text = ""

                        tb_ID_PLANING.Enabled = True
                        tb_NCIN_responsable.Enabled = False
                        tb_nom_planing.Enabled = False
                        tb_plan_generale.Enabled = False
                        cb_evenement.Enabled = False

                        bt_Ajouter.Enabled = False
                        bt_chercher.Enabled = True
                        bt_enregistrer.Enabled = False
                        bt_modifier.Enabled = False
                        bt_supprimer.Enabled = False
                    Else
                        con3.Dispose()

                        Dim con5 As New OracleConnection(xe)
                        con5.Open()

                        Dim parm1 As New OracleParameter
                        parm1.OracleDbType = OracleDbType.Varchar2
                        parm1.Value = tb_ID_PLANING.Text
                        Dim parm2 As New OracleParameter
                        parm2.OracleDbType = OracleDbType.Varchar2
                        parm2.Value = tb_nom_planing.Text
                        Dim parm3 As New OracleParameter
                        parm3.OracleDbType = OracleDbType.Varchar2
                        parm3.Value = tb_plan_generale.Text
                        Dim parm4 As New OracleParameter
                        parm4.OracleDbType = OracleDbType.Int64
                        parm4.Value = tb_NCIN_responsable.Text
                        Dim parm5 As New OracleParameter
                        parm5.OracleDbType = OracleDbType.Varchar2
                        parm5.Value = id_evenemenet()

                        Dim cmd5 As New OracleCommand
                        cmd5.Connection = con5
                        cmd5.Parameters.Add(parm1)
                        cmd5.Parameters.Add(parm2)
                        cmd5.Parameters.Add(parm3)
                        cmd5.Parameters.Add(parm4)
                        cmd5.Parameters.Add(parm5)
                        cmd5.CommandText = "update PLANING set ID_PLANING=:1,NOM_PLANING=:2 ,PLAN_GENERAL=:3,NCIN_MEMBRE=:4,ID_EVENEMENT=:5 where ID_PLANING=:1"
                        cmd5.CommandType = CommandType.Text

                        Dim dr5 As OracleDataReader = cmd5.ExecuteReader()
                        con5.Dispose()

                        tb_ID_PLANING.Text = ""
                        tb_NCIN_responsable.Text = ""
                        tb_nom_planing.Text = ""
                        tb_plan_generale.Text = ""
                        cb_evenement.Text = ""

                        tb_ID_PLANING.Enabled = True
                        tb_NCIN_responsable.Enabled = False
                        tb_nom_planing.Enabled = False
                        tb_plan_generale.Enabled = False
                        cb_evenement.Enabled = False

                        bt_Ajouter.Enabled = False
                        bt_chercher.Enabled = True
                        bt_enregistrer.Enabled = False
                        bt_modifier.Enabled = False
                        bt_supprimer.Enabled = False

                        MsgBox("ligne modifier avec succée")

                        DataGridView1.Rows.Clear()


                        Dim con1 As New OracleConnection(xe)
                        con1.Open()


                        Dim cmd1 As New OracleCommand
                        cmd1.Connection = con1

                        cmd1.CommandText = "select * from planing where nom_planing='communication' "
                        cmd1.CommandType = CommandType.Text
                        Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
                        While dr1.Read()
                            DataGridView1.Rows.Add(dr1.Item("ID_PLANING"), dr1.Item("ID_EVENEMENT"), dr1.Item("PLAN_GENERAL"))

                        End While
                        con1.Dispose()
                    End If
                End If
            End If
        Else
            MessageBox.Show("il faut choisir un evenement de la liste", "erreur")
        End If
    End Sub

    Private Sub bt_Quitter_Click(sender As Object, e As EventArgs) Handles bt_Quitter.Click
        Me.Close()
        connexion.Close()
    End Sub
End Class