Imports Oracle.DataAccess.Types
Imports Oracle.DataAccess.Client
Imports System.Data

Public Class Consulter_Tache_Sponsoring
    Function verif() As Boolean
        Dim v As Boolean = True
        If TB_NCIN_MEMBRE.Text = "" And Me.TB_NCIN_MEMBRE.Text Is Nothing Or Not IsNumeric(Me.TB_NCIN_MEMBRE.Text) Or TB_NCIN_MEMBRE.TextLength <> 7 Then

            v = False

        End If


        Return v

    End Function
 



 

    Private Sub Consulter_Tache_Sponsoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TB_NCIN_MEMBRE.Text = ""
        cb_id_evenement.Text = ""
        tb_nom_membre.Text = ""
        tb_date_evenement.Text = ""
        tb_tache.Text = ""
        tb_nom_evenement.Text = ""
        tb_nom_evenement.Enabled = False
        tb_nom_membre.Enabled = False
        tb_date_evenement.Enabled = False
        tb_tache.Text = False


        Dim xe As String = "data source=xe;user id=system;password=firas123;"

        Dim con As New OracleConnection(xe)
        con.Open()
        Dim cmd As New OracleCommand
        cmd.Connection = con
        cmd.CommandText = "select * from EVENEMENT "
        cmd.CommandType = CommandType.Text
        Dim dr As OracleDataReader = cmd.ExecuteReader()
        While dr.Read()
            cb_id_evenement.Items.Add(dr.Item("id_EVENEMENT"))
        End While

    End Sub







    Private Sub bt_retour_Click_1(sender As Object, e As EventArgs) Handles bt_retour.Click
        Membre_Sponsoring.Show()
        Me.Close()
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

    Private Sub bt_annuler_Click(sender As Object, e As EventArgs) Handles bt_annuler.Click
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

    Private Sub bt_chercher_Click_1(sender As Object, e As EventArgs) Handles bt_chercher.Click

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
                If dr1.Read() = True Then
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



                        MsgBox("Voila votre tache  ")
                        con1.Dispose()

                    Else

                        MsgBox("vous n'avez de tache dans ce evenement")
                        con.Dispose()
                    End If


                Else



                    MsgBox("Membre n'existe pas dans ce evenement")




                    TB_NCIN_MEMBRE.Enabled = True
                    cb_id_evenement.Enabled = True
                    TB_NCIN_MEMBRE.Text = ""
                    cb_id_evenement.Text = ""
                    tb_nom_membre.Text = ""
                    tb_nom_evenement.Text = ""
                    tb_date_evenement.Text = ""
                    tb_tache.Text = ""
                    con.Dispose()
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

                tb_nom_evenement.Text = ""
                tb_tache.Text = ""
                con.Dispose()
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

    Private Sub bt_Quitter_Click(sender As Object, e As EventArgs) Handles bt_Quitter.Click
        Me.Close()
        connexion.Close()
    End Sub
End Class

