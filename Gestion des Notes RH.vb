Imports Oracle.DataAccess.Types
Imports Oracle.DataAccess.Client
Imports System.Data

Imports System.Net.Mail
Imports System.Data.SqlClient
Imports System.IO

Public Class Gestion_des_Notes

    Function verif() As Boolean
        Dim v As Boolean = True
        If TB_NCIN_MEMBRE.Text = "" And Me.TB_NCIN_MEMBRE.Text Is Nothing Or Not IsNumeric(Me.TB_NCIN_MEMBRE.Text) Or TB_NCIN_MEMBRE.TextLength <> 7 Then

            v = False

        End If


        Return v

    End Function
 

  


    Structure grid

        Dim ncin1 As Decimal
        Dim nom1 As String
        Dim prenom1 As String
        Dim depart1 As String
    End Structure


    Private Sub Gestion_des_absences_RH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tb_nom_membre.Enabled = True
        TB_NCIN_MEMBRE.Enabled = True
        cb_id_évenement.Enabled = True
        tb_nom_membre.Text = ""
        Dim xe As String = "data source=xe;user id=system;password=firas123;"

        Dim con As New OracleConnection(xe)
        con.Open()
        Dim cmd As New OracleCommand
        cmd.Connection = con
        cmd.CommandText = "select * from EVENEMENT "
        cmd.CommandType = CommandType.Text
        Dim dr As OracleDataReader = cmd.ExecuteReader()
        While dr.Read()
            cb_id_évenement.Items.Add(dr.Item("id_EVENEMENT"))
        End While



        TB_NCIN_MEMBRE.Text = ""
        tb_nom_membre.Text = ""
        cb_note.Text = ""

    End Sub





    Private Sub TB_NCIN_MEMBRE_TextChanged_1(sender As Object, e As EventArgs) Handles TB_NCIN_MEMBRE.TextChanged
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
            cmd.CommandText = "select * from MEMBRE where NCIN_MEMBRE=:1"
            cmd.CommandType = CommandType.Text
            Dim dr As OracleDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                tb_nom_membre.Text = dr.Item("nom_membre").ToString
            End If

        End If
    End Sub













    Private Sub bt_retour_Click(sender As Object, e As EventArgs) Handles bt_retour.Click
        Responsable_Ressources_humaines_et_son_adjoint.Show()
        cb_id_évenement.Text = ""
        TB_NCIN_MEMBRE.Text = ""
        tb_nom_membre.Text = ""
        cb_note.Text = ""
        Me.Close()
    End Sub

    Private Sub bt_annuler_Click(sender As Object, e As EventArgs) Handles bt_annuler.Click
        cb_id_évenement.Text = ""
        TB_NCIN_MEMBRE.Text = ""
        tb_nom_membre.Text = ""
        cb_note.Text = ""
    End Sub

    Private Sub bt_enregistrer_Click(sender As Object, e As EventArgs) Handles bt_enregistrer.Click
        If verif() = True Then
            Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123;"
            Dim con As New OracleConnection(XE)
            con.Open()

            Dim ncin3 As New OracleParameter
            ncin3.OracleDbType = OracleDbType.Decimal
            ncin3.Value = TB_NCIN_MEMBRE.Text
            Dim cmd3 As New OracleCommand
            cmd3.Connection = con
            cmd3.Parameters.Add(ncin3)

            cmd3.CommandText = "select * from MEMBRE where NCIN_MEMBRE=:1"
            Dim dr3 As OracleDataReader = cmd3.ExecuteReader()
            If dr3.Read Then



                Dim ncin As New OracleParameter
                ncin.OracleDbType = OracleDbType.Decimal
                ncin.Value = TB_NCIN_MEMBRE.Text

                Dim eventt As New OracleParameter
                eventt.OracleDbType = OracleDbType.NVarchar2
                eventt.Value = cb_id_évenement.Text

                Dim cmd As New OracleCommand
                cmd.Connection = con
                cmd.Parameters.Add(ncin)
                cmd.Parameters.Add(eventt)





                cmd.CommandText = "select NCIN_MEMBRE,ID_EVENEMENT from PARTICIPE_MEMBRE where NCIN_MEMBRE=:1 and ID_EVENEMENT=:2   "
                cmd.CommandType = CommandType.Text

                Dim dr As OracleDataReader = cmd.ExecuteReader()
                Dim p As Boolean
                p = dr.Read()
                If p = True Then
                    con.Dispose()

                    Dim conn1 As New OracleConnection(XE)
                    conn1.Open()

                    Dim ncin1 As New OracleParameter
                    ncin1.OracleDbType = OracleDbType.Decimal
                    ncin1.Value = TB_NCIN_MEMBRE.Text

                    Dim eventt1 As New OracleParameter
                    eventt1.OracleDbType = OracleDbType.NVarchar2
                    eventt1.Value = cb_id_évenement.Text


                    Dim note As New OracleParameter
                    note.OracleDbType = OracleDbType.Decimal
                    note.Value = cb_note.Text






                    Dim cmd2 As New OracleCommand
                    cmd2.Connection = conn1
                    cmd2.Parameters.Add(note)
                    cmd2.Parameters.Add(ncin1)
                    cmd2.Parameters.Add(eventt1)



                    cmd2.CommandText = " update PARTICIPE_MEMBRE set tache_note=:1 where ncin_membre=:2 and id_evenement=:3 "
                    cmd2.CommandType = CommandType.Text
                    Dim dr2 As OracleDataReader = cmd2.ExecuteReader()
                    dr2.Read()

                    'Donnner une note et envoyer dans un email



                    Dim ncin_re As New OracleParameter
                    ncin_re.OracleDbType = OracleDbType.Decimal
                    ncin_re.Value = TB_NCIN_MEMBRE.Text
                    Dim event1 As New OracleParameter
                    event1.OracleDbType = OracleDbType.NVarchar2
                    event1.Value = cb_id_évenement.Text
                    Dim cmd_re As New OracleCommand
                    cmd_re.Connection = conn1
                    cmd_re.Parameters.Add(ncin_re)
                    cmd_re.Parameters.Add(event1)

                    cmd_re.CommandText = "select * from PARTICIPE_MEMBRE p,membre m where m.ncin_membre=p.ncin_membre and m.ncin_membre=:1 and id_evenement=:2"
                    cmd_re.CommandType = CommandType.Text
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

                        mail.Body = (" votre note" + cb_note.Text + "dans ce evenement" + dr_re.Item("MAIL_MEMBRE").ToString)
                            smtpServer.Send(mail)
                            MsgBox("Thanks for your email !")

                    End If

                    cb_id_évenement.Text = ""

                    TB_NCIN_MEMBRE.Text = ""
                    tb_nom_membre.Text = ""
                    tb_nom_membre.Enabled = True
                    TB_NCIN_MEMBRE.Enabled = True
                    cb_id_évenement.Enabled = True
                    cb_note.Text = ""
                    MsgBox(" ce membre est noter avec succes")
                    con.Dispose()
                Else
                    MsgBox("ce membre n'est pas participer dans ce evenement")
                    tb_nom_membre.Text = ""
                    cb_id_évenement.Text = ""
                    TB_NCIN_MEMBRE.Text = ""
                    tb_nom_membre.Text = ""
                    tb_nom_membre.Enabled = True
                    TB_NCIN_MEMBRE.Enabled = True
                    cb_id_évenement.Enabled = True

                    cb_id_évenement.Text = ""
                    cb_note.Text = ""
                End If
            Else
                MsgBox("Ce cin n'existe pas")

                tb_nom_membre.Text = ""
                cb_id_évenement.Text = ""
                TB_NCIN_MEMBRE.Text = ""
                tb_nom_membre.Text = ""
                tb_nom_membre.Enabled = True
                TB_NCIN_MEMBRE.Enabled = True
                cb_id_évenement.Enabled = True

                cb_id_évenement.Text = ""
                cb_note.Text = ""

            End If


        Else

            MsgBox("Tapez un CIN de membre valide")
            TB_NCIN_MEMBRE.Text = ""
            tb_nom_membre.Text = ""
            cb_id_évenement.Text = ""
            cb_note.Text = ""

        End If
    End Sub

    Private Sub bt_Quitter_Click(sender As Object, e As EventArgs) Handles bt_Quitter.Click
        Me.Close()
        connexion.Close()
    End Sub

    Private Sub bt_Affiche_Click(sender As Object, e As EventArgs) Handles bt_Affiche.Click
        If verif() = True Then
            Dim XE As String = "data source=XE ; user id=system ; password=firas123; "
            Dim con As New OracleConnection(XE)
            con.Open()

            Dim ncin As New OracleParameter
            ncin.OracleDbType = OracleDbType.Decimal
            ncin.Value = TB_NCIN_MEMBRE.Text
            Dim cmd As New OracleCommand
            cmd.Connection = con
            cmd.Parameters.Add(ncin)

            cmd.CommandText = "select * from MEMBRE where NCIN_MEMBRE=:1"
            cmd.CommandType = CommandType.Text
            Dim dr As OracleDataReader = cmd.ExecuteReader()
            If dr.Read Then

                Dim ncin1 As New OracleParameter
                ncin1.OracleDbType = OracleDbType.Decimal
                ncin1.Value = TB_NCIN_MEMBRE.Text

                Dim eventt1 As New OracleParameter
                eventt1.OracleDbType = OracleDbType.NVarchar2
                eventt1.Value = cb_id_évenement.Text

                Dim cmd1 As New OracleCommand
                cmd1.Connection = con
                cmd1.Parameters.Add(ncin1)
                cmd1.Parameters.Add(eventt1)



                cmd1.CommandText = "select * from PARTICIPE_MEMBRE where NCIN_MEMBRE=:1 and ID_EVENEMENT=:2 "
                cmd1.CommandType = CommandType.Text

                Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
                Dim p1 As Boolean
                p1 = dr1.Read()
                If p1 = True Then

                    Dim ncin2 As New OracleParameter
                    ncin2.OracleDbType = OracleDbType.Decimal
                    ncin2.Value = TB_NCIN_MEMBRE.Text

                    Dim eventt2 As New OracleParameter
                    eventt2.OracleDbType = OracleDbType.NVarchar2
                    eventt2.Value = cb_id_évenement.Text

                    Dim cmd2 As New OracleCommand
                    cmd2.Connection = con


                    cmd2.Parameters.Add(ncin2)
                    cmd2.Parameters.Add(eventt2)
                    cmd2.CommandText = "select * from PARTICIPE_MEMBRE where NCIN_MEMBRE=:1 and ID_EVENEMENT=:2"

                    cmd2.CommandType = CommandType.Text






                    Dim dr2 As OracleDataReader = cmd2.ExecuteReader()



                    If dr2.Read() Then
                        If dr2.Item("tache_note").ToString = "" Then
                            tb_Afficher.Text = "Ce membre n'a pas encore une note"
                        Else

                            tb_Afficher.Text = dr2.Item("tache_note").ToString
                        End If
                    End If

                Else
                    MsgBox("ce membre n'est pas participer dans ce evenement")
                    tb_nom_membre.Text = ""
                    cb_id_évenement.Text = ""
                    TB_NCIN_MEMBRE.Text = ""
                    tb_nom_membre.Text = ""
                    tb_nom_membre.Enabled = True
                    TB_NCIN_MEMBRE.Enabled = True
                    cb_id_évenement.Enabled = True

                    cb_id_évenement.Text = ""
                    cb_note.Text = ""

                End If

            Else
                MsgBox("Ce cin n'existe pas")

                tb_nom_membre.Text = ""

                TB_NCIN_MEMBRE.Text = ""
                tb_nom_membre.Text = ""
                tb_nom_membre.Enabled = True
                TB_NCIN_MEMBRE.Enabled = True



            End If


        Else
            MsgBox("Tapez un CIN de membre valide")
            TB_NCIN_MEMBRE.Text = ""
            tb_nom_membre.Text = ""



        End If
    End Sub

    Private Sub TB_NCIN_MEMBRE_TextChanged(sender As Object, e As EventArgs) Handles TB_NCIN_MEMBRE.TextChanged

    End Sub
End Class