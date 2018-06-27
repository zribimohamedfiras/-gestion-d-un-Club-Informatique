Imports Oracle.DataAccess.Types
Imports Oracle.DataAccess.Client
Imports System.Data
Imports System.Net.Mail
Imports System.Data.SqlClient
Imports System.IO
Public Class Gestion_des_Membres_Sonsoring
    Function verif() As Boolean
        Dim v As Boolean = True
        If TB_NCIN_MEMBRE.Text = "" And Me.TB_NCIN_MEMBRE.Text Is Nothing Or Not IsNumeric(Me.TB_NCIN_MEMBRE.Text) Or TB_NCIN_MEMBRE.TextLength <> 7 Then

            v = False

        End If


        Return v

    End Function
    Function verif2() As Boolean
        Dim v As Boolean = True
        If cb_id_evenement.Text = "" And Me.cb_id_evenement.Text Is Nothing Then

            v = False

        End If


        Return v

    End Function
 
  

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

    Private Sub Gestion_des_Membres_Sonsoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TB_NCIN_MEMBRE.Text = ""
        cb_id_evenement.Text = ""
        tb_nom_membre.Text = ""
        tb_date_evenement.Text = ""
        tb_tache.Text = ""
        tb_nom_evenement.Text = ""

        tb_nom_membre.Enabled = False
        tb_date_evenement.Enabled = False
        tb_tache.Text = False
    End Sub

    Private Sub cb_nom_evenement_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_id_evenement.SelectedIndexChanged
        If verif2() = True Then
            Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123;"
            Dim con As New OracleConnection(XE)
            con.Open()

            Dim id As New OracleParameter
            id.OracleDbType = OracleDbType.NVarchar2
            id.Value = cb_id_evenement.Text



            Dim cmd As New OracleCommand
            cmd.Connection = con
            cmd.Parameters.Add(id)


            cmd.CommandText = "select DATE_EVENEMENT,NOM_EVENEMENT from EVENEMENT where ID_EVENEMENT=:1 "
            cmd.CommandType = CommandType.Text
            Dim dr As OracleDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                tb_date_evenement.Text = dr.Item("DATE_EVENEMENT").ToString
                tb_nom_evenement.Text = dr.Item("NOM_EVENEMENT").ToString
            End If

        End If
    End Sub


   
    Private Sub bt_Ajouter_Click_1(sender As Object, e As EventArgs) Handles bt_Ajouter.Click
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

                Dim id As New OracleParameter
                id.OracleDbType = OracleDbType.NVarchar2
                id.Value = cb_id_evenement.Text

                Dim cmd As New OracleCommand
                cmd.Connection = con
                cmd.Parameters.Add(ncin)
                cmd.Parameters.Add(id)





                cmd.CommandText = "select NCIN_MEMBRE,ID_EVENEMENT from PARTICIPE_MEMBRE where NCIN_MEMBRE=:1 and ID_EVENEMENT=:2 "
                cmd.CommandType = CommandType.Text

                Dim dr As OracleDataReader = cmd.ExecuteReader()
                Dim p As Boolean
                p = dr.Read()
                If p = False Then
                    con.Dispose()

                    Dim conn1 As New OracleConnection(XE)
                    conn1.Open()

                    Dim ncin1 As New OracleParameter
                    ncin1.OracleDbType = OracleDbType.Decimal
                    ncin1.Value = TB_NCIN_MEMBRE.Text

                    Dim id1 As New OracleParameter
                    id1.OracleDbType = OracleDbType.NVarchar2
                    id1.Value = cb_id_evenement.Text


                    Dim tache As New OracleParameter
                    tache.OracleDbType = OracleDbType.NVarchar2
                    tache.Value = tb_tache.Text



                    Dim cmd2 As New OracleCommand
                    cmd2.Connection = conn1

                    cmd2.Parameters.Add(ncin1)
                    cmd2.Parameters.Add(id1)

                    cmd2.Parameters.Add(tache)

                    cmd2.CommandText = " insert into PARTICIPE_MEMBRE values(:1,:2,'',:4,'') "
                    cmd2.CommandType = CommandType.Text
                    Dim dr2 As OracleDataReader = cmd2.ExecuteReader()
                    dr2.Read()
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
                        mail.Body = ("Salut" + tb_tache.Text)
                        smtpServer.Send(mail)
                        MsgBox("Thanks for your email !")

                    End If

                    cb_id_evenement.Text = ""
                    tb_nom_evenement.Text = ""
                    TB_NCIN_MEMBRE.Text = ""
                    tb_nom_membre.Text = ""
                    tb_nom_membre.Enabled = True
                    TB_NCIN_MEMBRE.Enabled = True
                    cb_id_evenement.Enabled = True
                    tb_tache.Text = ""
                    MsgBox(" tache ajouter pour ce membre  avec succes")
                    con.Dispose()
                Else
                    MsgBox("ce membre est deja une tache dans ce evenement")
                    tb_nom_membre.Text = ""
                    cb_id_evenement.Text = ""
                    TB_NCIN_MEMBRE.Text = ""
                    tb_nom_membre.Text = ""
                    tb_nom_evenement.Text = ""
                    tb_nom_membre.Enabled = True
                    TB_NCIN_MEMBRE.Enabled = True
                    cb_id_evenement.Enabled = True
                    tb_nom_evenement.Text = ""
                    cb_id_evenement.Text = ""
                    tb_tache.Text = ""
                    con.Dispose()
                End If
            Else
                MsgBox("Ce cin n'existe pas")

                tb_nom_membre.Text = ""
                tb_nom_evenement.Text = ""
                TB_NCIN_MEMBRE.Text = ""
                tb_nom_membre.Text = ""
                tb_nom_membre.Enabled = True
                TB_NCIN_MEMBRE.Enabled = True
                tb_nom_evenement.Enabled = True

                tb_nom_evenement.Text = ""
                tb_tache.Text = ""
                con.Dispose()

            End If


        Else

            MsgBox("Tapez un CIN de membre valide")
            TB_NCIN_MEMBRE.Text = ""
            tb_nom_membre.Text = ""
            tb_nom_evenement.Text = ""


        End If
    End Sub

    Private Sub RE_Click(sender As Object, e As EventArgs) Handles RE.Click
        Responsable_Sponsoring.Show()
        tb_date_evenement.Text = ""
        TB_NCIN_MEMBRE.Text = ""
        tb_nom_membre.Text = ""
        tb_tache.Text = ""
        cb_id_evenement.Text = ""
        tb_nom_evenement.Text = ""
        Me.Close()
        tb_nom_membre.Enabled = False
        tb_date_evenement.Enabled = False
        tb_tache.Text = False
    End Sub

    Private Sub bt_Annuler_Click(sender As Object, e As EventArgs) Handles bt_Annuler.Click
        tb_date_evenement.Text = ""
        TB_NCIN_MEMBRE.Text = ""
        tb_nom_membre.Text = ""
        tb_tache.Text = ""
        cb_id_evenement.Text = ""
        tb_nom_evenement.Text = ""
        tb_nom_membre.Enabled = False
        tb_date_evenement.Enabled = False
        tb_tache.Text = False

    End Sub

    Private Sub bt_Quitter_Click(sender As Object, e As EventArgs) Handles bt_Quitter.Click
        Me.Close()
        connexion.Close()
    End Sub
End Class