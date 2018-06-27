Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types

Imports System.Net.Mail
Imports System.Data.SqlClient
Imports System.IO









Public Class Gestion_des_évenements

    Function verif_() As Boolean
        Dim f As Boolean = True
        If tb_Nom_Evénement.Text Is Nothing Or tb_type.Text Is Nothing Or tb_description.Text Is Nothing Or tb_date.Text Is Nothing Then
            f = False
        ElseIf tb_date.Text(2) <> "/" Or tb_date.Text(5) <> "/" Then
            f = False


        End If

        Return f
    End Function


    Function verif() As Boolean
        Dim v As Boolean = True
        If tb_ID_Evénement.Text Is Nothing Then
            v = False
        Else
            If Me.tb_ID_Evénement.Text(0) <> "e" Then
                v = False
            End If
        End If
        Return v
    End Function
    Private Sub Rebrique_Vice_Président_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_date.Text = ""
        tb_description.Text = ""
        tb_ID_Evénement.Text = ""
        tb_Nom_Evénement.Text = ""
        tb_type.Text = ""

        tb_type.Enabled = False
        tb_Nom_Evénement.Enabled = False
        tb_description.Enabled = False
        tb_date.Enabled = False

        bt_ajouter.Enabled = False
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False
        DataGridView1.Rows.Clear()

        Dim xe As String = "data source=xe;user id=system;password=firas123;"
        Dim con As New OracleConnection(xe)
        con.Open()
        Dim cmd As New OracleCommand
        cmd.Connection = con
        cmd.CommandText = "select ID_EVENEMENT,NOM_EVENEMENT from evenement"
        cmd.CommandType = CommandType.Text
        Dim dr As OracleDataReader = cmd.ExecuteReader()
        While dr.Read
            DataGridView1.Rows.Add(dr.Item("ID_EVENEMENT"), dr.Item("NOM_EVENEMENT"))
        End While
        con.Dispose()

    End Sub

    Private Sub RE_Click(sender As Object, e As EventArgs) Handles RE.Click
        President_et_Vise_Président.Show()
        tb_date.Text = ""
        tb_description.Text = ""
        tb_ID_Evénement.Text = ""
        tb_Nom_Evénement.Text = ""
        tb_type.Text = ""
        tb_ID_Evénement.Enabled = True
        tb_Nom_Evénement.Enabled = False
        tb_type.Enabled = False
        tb_date.Enabled = False
        tb_date.Enabled = False
        bt_chercher.Enabled = True
        bt_ajouter.Enabled = False
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False
        Me.Close()

    End Sub

    Private Sub bt_annuler_Click(sender As Object, e As EventArgs) Handles bt_annuler.Click
        tb_date.Text = ""
        tb_description.Text = ""
        tb_ID_Evénement.Text = ""
        tb_Nom_Evénement.Text = ""
        tb_type.Text = ""
        tb_ID_Evénement.Enabled = True
        tb_Nom_Evénement.Enabled = False
        tb_type.Enabled = False
        tb_date.Enabled = False
        tb_date.Enabled = False
        bt_chercher.Enabled = True
        bt_ajouter.Enabled = False
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False
    End Sub

    Private Sub bt_chercher_Click(sender As Object, e As EventArgs) Handles bt_chercher.Click

        tb_date.Text = ""
        tb_description.Text = ""

        tb_Nom_Evénement.Text = ""
        tb_type.Text = ""
        tb_ID_Evénement.Enabled = True
        tb_type.Enabled = False
        tb_Nom_Evénement.Enabled = False
        tb_description.Enabled = False
        tb_date.Enabled = False

        bt_ajouter.Enabled = False
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False
        If verif() Then

            Dim xe As String = "data source=xe;user id=system;password=firas123;"
            Dim con As New OracleConnection(xe)
            con.Open()
            Dim parm As New OracleParameter()
            parm.OracleDbType = OracleDbType.Varchar2
            parm.Value = tb_ID_Evénement.Text
            Dim cmd As New OracleCommand()
            cmd.Connection = con
            cmd.Parameters.Add(parm)
            cmd.CommandText = "select * from evenement where ID_EVENEMENT= :1"
            cmd.CommandType = CommandType.Text
            Dim dr As OracleDataReader = cmd.ExecuteReader()
            If dr.Read() Then
                tb_date.Text = dr.Item("DATE_EVENEMENT")
                tb_description.Text = dr.Item("DESCRIPTION_EVENEMENT")
                tb_Nom_Evénement.Text = dr.Item("NOM_EVENEMENT")
                tb_type.Text = dr.Item("TYPE_EVENEMENT")
                con.Dispose()
                bt_modifier.Enabled = True
                bt_supprimer.Enabled = True
                bt_ajouter.Enabled = False
                bt_enregistrer.Enabled = False
                bt_chercher.Enabled = False
            Else
                MessageBox.Show("cette evenement n'existe pas", "tu peut ajouter un evenemenet")
                bt_ajouter.Enabled = True
                bt_modifier.Enabled = False
                bt_supprimer.Enabled = False
                bt_enregistrer.Enabled = False
            End If
        Else
            MessageBox.Show("il faut induire un chaine de caractere ou sa premier caractere est 'e'", "erreur")
            tb_date.Text = ""
            tb_description.Text = ""
            tb_ID_Evénement.Text = ""
            tb_Nom_Evénement.Text = ""
            tb_type.Text = ""
            tb_ID_Evénement.Enabled = True
            tb_Nom_Evénement.Enabled = False
            tb_type.Enabled = False
            tb_date.Enabled = False
            tb_date.Enabled = False
            bt_chercher.Enabled = True
            bt_ajouter.Enabled = False
            bt_enregistrer.Enabled = False
            bt_modifier.Enabled = False
            bt_supprimer.Enabled = False
        End If
    End Sub

    Private Sub bt_ajouter_Click(sender As Object, e As EventArgs) Handles bt_ajouter.Click
        bt_enregistrer.Enabled = True
        tb_ID_Evénement.Enabled = False
        tb_date.Enabled = True
        tb_description.Enabled = True
        tb_Nom_Evénement.Enabled = True
        tb_type.Enabled = True
        bt_chercher.Enabled = False


    End Sub

    Private Sub bt_modifier_Click(sender As Object, e As EventArgs) Handles bt_modifier.Click
        bt_enregistrer.Enabled = True
        tb_ID_Evénement.Enabled = False
        tb_date.Enabled = True
        tb_description.Enabled = True
        tb_Nom_Evénement.Enabled = True
        tb_type.Enabled = True
        bt_chercher.Enabled = False

    End Sub

    Private Sub bt_supprimer_Click(sender As Object, e As EventArgs) Handles bt_supprimer.Click
        bt_chercher.Enabled = False
        If MsgBox("Etes vous sûr de vouloir supprimer?", vbYesNo, "Suppression") = MsgBoxResult.Yes Then
            bt_modifier.Enabled = False
            bt_enregistrer.Enabled = False
            Dim xe As String = "data source=xe;user id=system;password=firas123"
            Dim con As New OracleConnection(xe)
            con.Open()
            Dim parm1 As New OracleParameter
            parm1.OracleDbType = OracleDbType.Varchar2
            parm1.Value = tb_ID_Evénement.Text
            Dim cmd1 As New OracleCommand()
            cmd1.Connection = con
            cmd1.Parameters.Add(parm1)
            cmd1.CommandText = "DELETE FROM evenement where ID_EVENEMENT=:1"
            cmd1.CommandType = CommandType.Text
            Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
            bt_ajouter.Enabled = False
            bt_enregistrer.Enabled = False
            bt_modifier.Enabled = False
            bt_supprimer.Enabled = False
            bt_chercher.Enabled = True
            tb_ID_Evénement.Text = ""
            tb_date.Text = ""
            tb_description.Text = ""
            tb_Nom_Evénement.Text = ""
            tb_type.Text = ""
            MsgBox("supprission avec succes")
            con.Dispose()

            DataGridView1.Rows.Clear()

            Dim con2 As New OracleConnection(xe)
            con2.Open()
            Dim cmd2 As New OracleCommand
            cmd2.Connection = con2
            cmd2.CommandText = "select ID_EVENEMENT,NOM_EVENEMENT from evenement"
            cmd2.CommandType = CommandType.Text
            Dim dr2 As OracleDataReader = cmd2.ExecuteReader()
            While dr2.Read
                DataGridView1.Rows.Add(dr2.Item("ID_EVENEMENT"), dr2.Item("NOM_EVENEMENT"))
            End While

            'il ya un nouvau event avec mail
            Dim cmd_re As New OracleCommand
            cmd_re.Connection = con2


            cmd_re.CommandText = "select * from MEMBRE"
            cmd_re.CommandType = CommandType.Text

            Dim dr_re As OracleDataReader = cmd_re.ExecuteReader()
            If dr_re.Read Then

                Dim cmd3 As New OracleCommand
                cmd3.Connection = con2
                cmd3.CommandText = "select * from membre"

                cmd3.CommandType = CommandType.Text
                Dim dr3 As OracleDataReader = cmd3.ExecuteReader

                'If dr3.Read() Then
                '    x = cmd3.ExecuteScalar
                'End If
                'Dim i As Integer
                'i = 1

                'While i < x


                While dr3.Read()
                    Dim smtpServer As New SmtpClient()

                    Dim mail As New MailMessage()
                    smtpServer.Credentials = New Net.NetworkCredential("essectmicclub@gmail.com", "zribijouini")
                    smtpServer.Port = 587
                    smtpServer.Host = "smtp.gmail.com"
                    smtpServer.EnableSsl = True
                    mail = New MailMessage()
                    mail.From = New MailAddress("essectmicclub@gmail.com")
                    Dim x As String

                    x = dr3.Item("mail_membre")
                    mail.To.Add(x)

                    mail.Subject = "Login: "
                    mail.Body = ("Salut Ce evenement" + ":" + tb_Nom_Evénement.Text + " a été annuleé")
                    smtpServer.Send(mail)

                End While

                MsgBox("Thanks for your email !")

            End If

            ''rrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr



            con2.Dispose()
            bt_chercher.Enabled = True
            tb_ID_Evénement.Enabled = True
        End If
    End Sub

    Private Sub bt_enregistrer_Click(sender As Object, e As EventArgs) Handles bt_enregistrer.Click



        If bt_ajouter.Enabled = True Then
                If MsgBox("Etes vous sûr de vouloir ajouter?", vbYesNo, "Ajouter") = MsgBoxResult.Yes Then
                    Dim xe As String = "data source=xe;user id=system;password=firas123;"
                    Dim con As New OracleConnection(xe)
                    con.Open()
                    Dim parm1 As New OracleParameter()
                    parm1.OracleDbType = OracleDbType.Varchar2
                    parm1.Value = tb_ID_Evénement.Text
                    Dim parm2 As New OracleParameter()
                    parm2.OracleDbType = OracleDbType.Date
                    parm2.Value = Convert.ToDateTime(tb_date.Text)
                    Dim parm3 As New OracleParameter()
                    parm3.OracleDbType = OracleDbType.Varchar2
                    parm3.Value = tb_description.Text
                    Dim parm4 As New OracleParameter()
                    parm4.OracleDbType = OracleDbType.Varchar2
                    parm4.Value = tb_Nom_Evénement.Text
                    Dim parm5 As New OracleParameter()
                    parm5.OracleDbType = OracleDbType.Varchar2
                    parm5.Value = tb_type.Text

                    Dim cmd As New OracleCommand()
                    cmd.Connection = con
                    cmd.Parameters.Add(parm1)
                    cmd.Parameters.Add(parm4)
                    cmd.Parameters.Add(parm5)
                    cmd.Parameters.Add(parm2)
                    cmd.Parameters.Add(parm3)
                    cmd.CommandText = "insert into EVENEMENT(ID_EVENEMENT,NOM_EVENEMENT,TYPE_EVENEMENT,DATE_EVENEMENT,DESCRIPTION_EVENEMENT) values(:1,:2,:3,:4,:5)"
                    cmd.CommandType = CommandType.Text
                    Dim dr As OracleDataReader = cmd.ExecuteReader()


                'il ya un nouvau event avec mail
                Dim cmd_re As New OracleCommand
                cmd_re.Connection = con


                cmd_re.CommandText = "select * from MEMBRE"
                cmd_re.CommandType = CommandType.Text

                Dim dr_re As OracleDataReader = cmd_re.ExecuteReader()
                If dr_re.Read Then

                    Dim cmd3 As New OracleCommand
                    cmd3.Connection = con
                    cmd3.CommandText = "select * from membre "

                    cmd3.CommandType = CommandType.Text
                    Dim dr3 As OracleDataReader = cmd3.ExecuteReader




                    While dr3.Read()
                        Dim smtpServer As New SmtpClient()

                        Dim mail As New MailMessage()
                        smtpServer.Credentials = New Net.NetworkCredential("essectmicclub@gmail.com", "zribijouini")
                        smtpServer.Port = 587
                        smtpServer.Host = "smtp.gmail.com"
                        smtpServer.EnableSsl = True
                        mail = New MailMessage()
                        mail.From = New MailAddress("essectmicclub@gmail.com")
                        Dim x As String

                        x = dr3.Item("mail_membre")
                        mail.To.Add(x)

                        mail.Subject = "Login: "
                        mail.Body = ("Salut il y un nouvaux evenement c'est" + ":" + tb_Nom_Evénement.Text)
                        smtpServer.Send(mail)

                    End While

                    MsgBox("Thanks for your email !")
                    con.Dispose()
                End If

                ''rrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr


                MsgBox("Evenement ajoute avec succée")
                tb_ID_Evénement.Enabled = True
                    tb_Nom_Evénement.Enabled = False
                    tb_type.Enabled = False
                    tb_date.Enabled = False
                    tb_date.Enabled = False
                    tb_date.Text = ""
                    tb_description.Text = ""
                    tb_ID_Evénement.Text = ""
                    tb_Nom_Evénement.Text = ""
                    tb_type.Text = ""
                    bt_chercher.Enabled = True
                    bt_ajouter.Enabled = False
                    bt_enregistrer.Enabled = False
                    bt_modifier.Enabled = False
                    bt_supprimer.Enabled = False

                    DataGridView1.Rows.Clear()

                    Dim con2 As New OracleConnection(xe)
                    con2.Open()
                    Dim cmd2 As New OracleCommand
                    cmd2.Connection = con2
                    cmd2.CommandText = "select ID_EVENEMENT,NOM_EVENEMENT from evenement"
                    cmd2.CommandType = CommandType.Text
                    Dim dr2 As OracleDataReader = cmd2.ExecuteReader()
                    While dr2.Read
                        DataGridView1.Rows.Add(dr2.Item("ID_EVENEMENT"), dr2.Item("NOM_EVENEMENT"))
                    End While
                    con2.Dispose()
                    bt_chercher.Enabled = True
                    tb_ID_Evénement.Enabled = True

                End If
            Else
                Dim xe As String = "data source=xe;user id=system;password=firas123;"
                Dim con As New OracleConnection(xe)
                con.Open()
                Dim parm1 As New OracleParameter()
                parm1.OracleDbType = OracleDbType.Varchar2
                parm1.Value = tb_ID_Evénement.Text
                Dim parm2 As New OracleParameter()
                parm2.OracleDbType = OracleDbType.Date
                parm2.Value = Convert.ToDateTime(tb_date.Text)
                Dim parm3 As New OracleParameter()
                parm3.OracleDbType = OracleDbType.Varchar2
                parm3.Value = tb_description.Text
                Dim parm4 As New OracleParameter()
                parm4.OracleDbType = OracleDbType.Varchar2
                parm4.Value = tb_Nom_Evénement.Text
                Dim parm5 As New OracleParameter()
                parm5.OracleDbType = OracleDbType.Varchar2
                parm5.Value = tb_type.Text

                Dim cmd As New OracleCommand()
                cmd.Connection = con
                cmd.Parameters.Add(parm1)
                cmd.Parameters.Add(parm4)
                cmd.Parameters.Add(parm5)
                cmd.Parameters.Add(parm2)
                cmd.Parameters.Add(parm3)
                cmd.CommandText = "update EVENEMENT set ID_EVENEMENT=:1,NOM_EVENEMENT=:2,TYPE_EVENEMENT=:3,DATE_EVENEMENT=:4,DESCRIPTION_EVENEMENT=:5 where ID_EVENEMENT=:1"
                cmd.CommandType = CommandType.Text
                Dim dr As OracleDataReader = cmd.ExecuteReader()


            Dim cmd_re As New OracleCommand
            cmd_re.Connection = con


            cmd_re.CommandText = "select * from MEMBRE"
            cmd_re.CommandType = CommandType.Text

            Dim dr_re As OracleDataReader = cmd_re.ExecuteReader()
            If dr_re.Read Then

                Dim cmd3 As New OracleCommand
                cmd3.Connection = con
                cmd3.CommandText = "select * from membre"

                cmd3.CommandType = CommandType.Text
                Dim dr3 As OracleDataReader = cmd3.ExecuteReader

                'If dr3.Read() Then
                '    x = cmd3.ExecuteScalar
                'End If
                'Dim i As Integer
                'i = 1

                'While i < x


                While dr3.Read()
                    Dim smtpServer As New SmtpClient()

                    Dim mail As New MailMessage()
                    smtpServer.Credentials = New Net.NetworkCredential("essectmicclub@gmail.com", "zribijouini")
                    smtpServer.Port = 587
                    smtpServer.Host = "smtp.gmail.com"
                    smtpServer.EnableSsl = True
                    mail = New MailMessage()
                    mail.From = New MailAddress("essectmicclub@gmail.com")
                    Dim x As String

                    x = dr3.Item("mail_membre")
                    mail.To.Add(x)

                    mail.Subject = "Login: "
                    mail.Body = ("Ce nouvaux evenement " + tb_Nom_Evénement.Text + " à été modifier ")
                    smtpServer.Send(mail)

                End While
                con.Dispose()
                MsgBox("Thanks for your email !")

            End If

            ''rrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr



            MsgBox("Evenement modifié avec succés")
            tb_ID_Evénement.Enabled = True
                tb_Nom_Evénement.Enabled = False
                tb_type.Enabled = False
                tb_date.Enabled = False
                tb_date.Enabled = False
                tb_date.Text = ""
                tb_description.Text = ""
                tb_ID_Evénement.Text = ""
                tb_Nom_Evénement.Text = ""
                tb_type.Text = ""
                bt_chercher.Enabled = True
                bt_ajouter.Enabled = False
                bt_enregistrer.Enabled = False
                bt_modifier.Enabled = False
                bt_supprimer.Enabled = False

                DataGridView1.Rows.Clear()

                Dim con2 As New OracleConnection(xe)
                con2.Open()
                Dim cmd2 As New OracleCommand
                cmd2.Connection = con2
                cmd2.CommandText = "select ID_EVENEMENT,NOM_EVENEMENT from evenement"
                cmd2.CommandType = CommandType.Text
                Dim dr2 As OracleDataReader = cmd2.ExecuteReader()
                While dr2.Read
                    DataGridView1.Rows.Add(dr2.Item("ID_EVENEMENT"), dr2.Item("NOM_EVENEMENT"))
                End While
                con2.Dispose()
                bt_chercher.Enabled = True
                tb_ID_Evénement.Enabled = True

            End If



    End Sub

    Private Sub bt_Quitter_Click(sender As Object, e As EventArgs) Handles bt_Quitter.Click
        Me.Close()
        connexion.Close()
    End Sub
End Class