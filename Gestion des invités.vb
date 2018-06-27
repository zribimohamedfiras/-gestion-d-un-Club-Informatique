Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types

Public Class Gestion_des_invités

    Private Sub RE_Click(sender As Object, e As EventArgs) Handles RE.Click
        President_et_Vise_Président.Show()
        tb_ID_invité.Text = ""
        tb_mail.Text = ""
        tb_Nom_invité.Text = ""
        tb_prenom_invite.Text = ""
        tb_type.Text = ""
        bt_supprimer.Enabled = False
        bt_modifier.Enabled = False
        bt_enregistrer.Enabled = False
        bt_chercher.Enabled = True
        bt_ajouter.Enabled = False
        tb_mail.Enabled = False
        tb_Nom_invité.Enabled = False
        tb_prenom_invite.Enabled = False
        tb_type.Enabled = False
        tb_ID_invité.Enabled = True
        Me.Close()
    End Sub

    Private Sub Gestion_des_invités_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tb_ID_invité.Text = ""
        tb_mail.Text = ""
        tb_Nom_invité.Text = ""
        tb_prenom_invite.Text = ""
        tb_type.Text = ""
        bt_supprimer.Enabled = False
        bt_modifier.Enabled = False
        bt_enregistrer.Enabled = False
        bt_chercher.Enabled = True
        bt_ajouter.Enabled = False
        tb_mail.Enabled = False
        tb_Nom_invité.Enabled = False
        tb_prenom_invite.Enabled = False
        tb_type.Enabled = False
        tb_ID_invité.Enabled = True
        DataGridView1.Rows.Clear()
        Dim xe As String = "data source=xe;user id=system;password=firas123;"


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
    End Sub

    Private Sub tb_Annuler_Click(sender As Object, e As EventArgs) Handles tb_Annuler.Click
        tb_ID_invité.Text = ""
        tb_mail.Text = ""
        tb_Nom_invité.Text = ""
        tb_prenom_invite.Text = ""
        tb_type.Text = ""
        bt_supprimer.Enabled = False
        bt_modifier.Enabled = False
        bt_enregistrer.Enabled = False
        bt_chercher.Enabled = True
        bt_ajouter.Enabled = False
        tb_mail.Enabled = False
        tb_Nom_invité.Enabled = False
        tb_prenom_invite.Enabled = False
        tb_type.Enabled = False
        tb_ID_invité.Enabled = True

    End Sub

    Function verif1() As Boolean
        Dim v As Boolean = True
        If Me.tb_ID_invité.Text Is Nothing Then

            v = False
        ElseIf Me.tb_ID_invité.Text(0) <> "i" Then
            v = False
        End If
        Return v
    End Function



    Private Sub bt_chercher_Click(sender As Object, e As EventArgs) Handles bt_chercher.Click
        tb_mail.Text = ""
        tb_Nom_invité.Text = ""
        tb_prenom_invite.Text = ""
        tb_type.Text = ""
        bt_supprimer.Enabled = False
        bt_modifier.Enabled = False
        bt_enregistrer.Enabled = False
        bt_chercher.Enabled = True
        bt_ajouter.Enabled = False
        tb_mail.Enabled = False
        tb_Nom_invité.Enabled = False
        tb_prenom_invite.Enabled = False
        tb_type.Enabled = False
        tb_ID_invité.Enabled = True
        If verif1() Then
            Dim xe As String = "data source=xe;user id=system;password=firas123;"
            Dim con1 As New OracleConnection(xe)
            con1.Open()
            Dim parm1 As New OracleParameter
            parm1.OracleDbType = OracleDbType.Varchar2
            parm1.Value = tb_ID_invité.Text
            Dim cmd1 As New OracleCommand
            cmd1.Connection = con1
            cmd1.Parameters.Add(parm1)
            cmd1.CommandText = "select * from invite where id_invite= :1"
            cmd1.CommandType = CommandType.Text
            Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
            If dr1.Read Then

                tb_mail.Text = dr1.Item("MAIL_INVITE")
                tb_Nom_invité.Text = dr1.Item("NOM_INVITE")
                tb_prenom_invite.Text = dr1.Item("PRENOM_INVITE")
                tb_type.Text = dr1.Item("TYPE_INVITE")
                bt_modifier.Enabled = True
                bt_supprimer.Enabled = True
                bt_enregistrer.Enabled = False
                bt_ajouter.Enabled = False
                bt_chercher.Enabled = False
                con1.Dispose()

            Else
                    MessageBox.Show("tu peut ajouter un nouveau invité ou tu peut l'affecter à l'évenement")
                    bt_enregistrer.Enabled = False
                    bt_ajouter.Enabled = True
                    bt_modifier.Enabled = False
                    bt_supprimer.Enabled = False

                End If
            Else

            MessageBox.Show("il faut saisie une chaine de caractere sa premier caractere est 'i'", "attention")
            tb_ID_invité.Text = ""
            tb_mail.Text = ""
            tb_Nom_invité.Text = ""
            tb_prenom_invite.Text = ""
            tb_type.Text = ""

        End If

    End Sub

    Private Sub bt_ajouter_Click(sender As Object, e As EventArgs) Handles bt_ajouter.Click
        bt_enregistrer.Enabled = True
        tb_ID_invité.Enabled = False
        tb_mail.Enabled = True
        tb_Nom_invité.Enabled = True
        tb_prenom_invite.Enabled = True
        tb_type.Enabled = True
        bt_ajouter.Enabled = False

    End Sub

    Private Sub bt_modifier_Click(sender As Object, e As EventArgs) Handles bt_modifier.Click
        bt_enregistrer.Enabled = True
        tb_ID_invité.Enabled = False
        tb_mail.Enabled = True
        tb_Nom_invité.Enabled = True
        tb_prenom_invite.Enabled = True
        tb_type.Enabled = True
        bt_ajouter.Enabled = False
        bt_modifier.Enabled = False

    End Sub

    Private Sub bt_supprimer_Click(sender As Object, e As EventArgs) Handles bt_supprimer.Click
        If MsgBox("Etes vous sûr de vouloir supprimer?", vbYesNo, "Suppression") = MsgBoxResult.Yes Then

            Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123"

            Dim con As New OracleConnection(XE)
            con.Open()

            Dim parm As New OracleParameter
            parm.OracleDbType = OracleDbType.Varchar2
            parm.Value = tb_ID_invité.Text
            Dim cmd1 As New OracleCommand
            cmd1.Connection = con
            cmd1.Parameters.Add(parm)
            cmd1.CommandText = "DELETE FROM invite where id_invite=:1"
            cmd1.CommandType = CommandType.Text

            Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
            bt_modifier.Enabled = False
            bt_supprimer.Enabled = False
            bt_enregistrer.Enabled = False
            tb_ID_invité.Text = ""
            tb_mail.Text = ""
            tb_Nom_invité.Text = ""
            tb_prenom_invite.Text = ""
            tb_type.Text = ""
            tb_ID_invité.Enabled = True
            tb_mail.Enabled = False
            tb_Nom_invité.Enabled = False
            tb_prenom_invite.Enabled = False
            tb_type.Enabled = False
            MsgBox("supprission   avec succes")

            con.Dispose()
            bt_chercher.Enabled = True
            bt_ajouter.Enabled = False
            DataGridView1.Rows.Clear()



            Dim con1 As New OracleConnection(XE)
            con1.Open()


            Dim cmd2 As New OracleCommand
            cmd2.Connection = con1

            cmd2.CommandText = "select *  from   INVITE "
            cmd2.CommandType = CommandType.Text
            Dim dr2 As OracleDataReader = cmd2.ExecuteReader()
            While dr2.Read
                DataGridView1.Rows.Add(dr2.Item("ID_INVITE"), dr2.Item("NOM_INVITE"), dr2.Item("PRENOM_INVITE"))

            End While
            con1.Dispose()
        End If
    End Sub

    Private Sub bt_enregistrer_Click(sender As Object, e As EventArgs) Handles bt_enregistrer.Click
        Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123"
        Dim con As New OracleConnection(XE)
        con.Open()

        Dim parm As New OracleParameter
        parm.OracleDbType = OracleDbType.Varchar2
        parm.Value = tb_ID_invité.Text
        Dim cmd As New OracleCommand
        cmd.Connection = con
        cmd.Parameters.Add(parm)
        cmd.CommandText = "select * from invite where id_invite=:1"
        cmd.CommandType = CommandType.Text
        Dim dr As OracleDataReader = cmd.ExecuteReader()
        If dr.Read() = False Then

            If MsgBox("Etes vous sûr de vouloir ajouter?", vbYesNo, "Ajout") = MsgBoxResult.Yes Then

                Dim conn1 As New OracleConnection(XE)
                conn1.Open()
                Dim parm1 As New OracleParameter
                parm1.OracleDbType = OracleDbType.Varchar2
                parm1.Value = tb_ID_invité.Text
                Dim parm2 As New OracleParameter
                parm2.OracleDbType = OracleDbType.Varchar2
                parm2.Value = tb_mail.Text
                Dim parm3 As New OracleParameter
                parm3.OracleDbType = OracleDbType.Varchar2
                parm3.Value = tb_Nom_invité.Text
                Dim parm4 As New OracleParameter
                parm4.OracleDbType = OracleDbType.Varchar2
                parm4.Value = tb_prenom_invite.Text
                Dim parm5 As New OracleParameter
                parm5.OracleDbType = OracleDbType.Varchar2
                parm5.Value = tb_type.Text
                Dim cmd1 As New OracleCommand
                cmd1.Connection = conn1
                cmd1.Parameters.Add(parm1)
                cmd1.Parameters.Add(parm2)
                cmd1.Parameters.Add(parm3)
                cmd1.Parameters.Add(parm4)
                cmd1.Parameters.Add(parm5)

                cmd1.CommandText = "insert into INVITE(ID_INVITE,NOM_INVITE,PRENOM_INVITE,TYPE_INVITE,MAIL_INVITE)values(:1,:3,:4,:5,:2)"
                cmd1.CommandType = CommandType.Text
                Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
                bt_modifier.Enabled = False
                bt_enregistrer.Enabled = False
                bt_ajouter.Enabled = False
                bt_supprimer.Enabled = False
                bt_chercher.Enabled = True
                bt_ajouter.Enabled = False
                conn1.Dispose()
                MsgBox("invitée ajoute avec succeé")
                tb_ID_invité.Text = ""
                tb_mail.Text = ""
                tb_Nom_invité.Text = ""
                tb_prenom_invite.Text = ""
                tb_type.Text = ""

                tb_ID_invité.Enabled = True
                tb_mail.Enabled = False
                tb_Nom_invité.Enabled = False
                tb_prenom_invite.Enabled = False
                tb_type.Enabled = False
                DataGridView1.Rows.Clear()



                Dim con1 As New OracleConnection(XE)
                con1.Open()


                Dim cmd2 As New OracleCommand
                cmd2.Connection = con1

                cmd2.CommandText = "select *  from   INVITE "
                cmd2.CommandType = CommandType.Text
                Dim dr2 As OracleDataReader = cmd2.ExecuteReader()
                While dr2.Read
                    DataGridView1.Rows.Add(dr2.Item("ID_INVITE"), dr2.Item("NOM_INVITE"), dr2.Item("PRENOM_INVITE"))

                End While
                con1.Dispose()
            End If


        Else
            If MsgBox("Etes vous sûr de vouloir modifier?", vbYesNo, "Modifier") = MsgBoxResult.Yes Then
                Dim conn1 As New OracleConnection(XE)
                conn1.Open()
                Dim parm1 As New OracleParameter
                parm1.OracleDbType = OracleDbType.Varchar2
                parm1.Value = tb_ID_invité.Text
                Dim parm2 As New OracleParameter
                parm2.OracleDbType = OracleDbType.Varchar2
                parm2.Value = tb_mail.Text
                Dim parm3 As New OracleParameter
                parm3.OracleDbType = OracleDbType.Varchar2
                parm3.Value = tb_Nom_invité.Text
                Dim parm4 As New OracleParameter
                parm4.OracleDbType = OracleDbType.Varchar2
                parm4.Value = tb_prenom_invite.Text
                Dim parm5 As New OracleParameter
                parm5.OracleDbType = OracleDbType.Varchar2
                parm5.Value = tb_type.Text
                Dim cmd1 As New OracleCommand
                cmd1.Connection = conn1
                cmd1.Parameters.Add(parm1)
                cmd1.Parameters.Add(parm2)
                cmd1.Parameters.Add(parm3)
                cmd1.Parameters.Add(parm4)
                cmd1.Parameters.Add(parm5)
                cmd1.CommandText = "update INVITE set ID_INVITE=:1,MAIL_INVITE=:2,NOM_INVITE=:3,PRENOM_INVITE=:4,TYPE_INVITE=:5 where ID_INVITE=:1"
                cmd1.CommandType = CommandType.Text
                Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
                bt_modifier.Enabled = False
                bt_enregistrer.Enabled = False
                bt_ajouter.Enabled = False
                bt_supprimer.Enabled = False
                bt_chercher.Enabled = True
                bt_ajouter.Enabled = False
                conn1.Dispose()
                MsgBox("invitée modifier avec succeé")
                tb_ID_invité.Text = ""
                tb_mail.Text = ""
                tb_Nom_invité.Text = ""
                tb_prenom_invite.Text = ""
                tb_type.Text = ""

                tb_ID_invité.Enabled = True
                tb_mail.Enabled = False
                tb_Nom_invité.Enabled = False
                tb_prenom_invite.Enabled = False
            tb_type.Enabled = False
            DataGridView1.Rows.Clear()



            Dim con1 As New OracleConnection(XE)
            con1.Open()


            Dim cmd2 As New OracleCommand
            cmd2.Connection = con1

            cmd2.CommandText = "select *  from   INVITE "
            cmd2.CommandType = CommandType.Text
            Dim dr2 As OracleDataReader = cmd2.ExecuteReader()
            While dr2.Read
                DataGridView1.Rows.Add(dr2.Item("ID_INVITE"), dr2.Item("NOM_INVITE"), dr2.Item("PRENOM_INVITE"))

            End While
            con1.Dispose()
        End If
        End If



    End Sub

    Private Sub bt_Quitter_Click(sender As Object, e As EventArgs) Handles bt_Quitter.Click
        Me.Close()
        connexion.Close()
    End Sub
End Class
