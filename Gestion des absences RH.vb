Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types
Imports System.Data


Public Class Gestion_des_absences_RH
    Function verif() As Boolean
        Dim v As Boolean = True
        If TB_NCIN_MEMBRE.Text = "" And Me.TB_NCIN_MEMBRE.Text Is Nothing Or Not IsNumeric(Me.TB_NCIN_MEMBRE.Text) Or TB_NCIN_MEMBRE.TextLength <> 7 Then

            v = False

        End If


        Return v

    End Function


    Private Sub RE_Click(sender As Object, e As EventArgs) Handles RE.Click
        Responsable_Ressources_humaines_et_son_adjoint.Show()
        cb_Nom_évenement.Text = ""
        TB_NCIN_MEMBRE.Text = ""
        tb_nom_membre.Text = ""
        r_non.Checked = False
        r_oui.Checked = False
        Me.Close()

    End Sub

    Private Sub Annuler_Click(sender As Object, e As EventArgs) Handles Annuler.Click
        cb_Nom_évenement.Text = ""
        TB_NCIN_MEMBRE.Text = ""
        tb_nom_membre.Text = ""
        r_non.Checked = False
        r_oui.Checked = False


    End Sub





    Private Sub Gestion_des_absences_RH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tb_nom_membre.Enabled = True
        TB_NCIN_MEMBRE.Enabled = True
        cb_Nom_évenement.Enabled = True
        tb_nom_membre.Text = ""




        TB_NCIN_MEMBRE.Text = ""
        tb_nom_membre.Text = ""
        r_non.Checked = False
        r_oui.Checked = False

        Dim xe As String = "data source=xe;user id=system;password=firas123;"

        Dim con As New OracleConnection(xe)
        con.Open()
        Dim cmd As New OracleCommand
        cmd.Connection = con
        cmd.CommandText = "select * from EVENEMENT "
        cmd.CommandType = CommandType.Text
        Dim dr As OracleDataReader = cmd.ExecuteReader()
        While dr.Read()
            cb_Nom_évenement.Items.Add(dr.Item("id_EVENEMENT"))
        End While
    End Sub




    
    Private Sub cb_Nom_évenement_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Nom_évenement.SelectedIndexChanged


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

    Private Sub bt_Afficher_Click(sender As Object, e As EventArgs) Handles bt_Afficher.Click
        If verif() = True Then
            Dim XE As String = "data source=XE ; user id=system ; password=firas123; "
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


                Dim parm_OUT As New OracleParameter
                parm_OUT.Direction = ParameterDirection.ReturnValue
                parm_OUT.OracleDbType = OracleDbType.Int64

                Dim ncin As New OracleParameter
                ncin.OracleDbType = OracleDbType.Decimal
                ncin.Value = TB_NCIN_MEMBRE.Text
                ncin.Direction = ParameterDirection.Input

                Dim cmd As New OracleCommand("application.nb_abcsence", con)
                cmd.Connection = con
                cmd.Parameters.Add(parm_OUT)
                cmd.Parameters.Add(ncin)
                '       cmd.CommandText = "select count(presence_membre) from participe_membre where NCIN_MEMBRE=:1 and PRESENCE_MEMBRE='Non' "

                cmd.CommandType = CommandType.StoredProcedure
                cmd.ExecuteNonQuery()

                tb_Afficher.Text = cmd.Parameters(0).Value.ToString

                'Dim dr As OracleDataReader = cmd.ExecuteReader()



            Else
                MsgBox("Ce cin n'existe pas")

                tb_nom_membre.Text = ""
                cb_Nom_évenement.Text = ""
                TB_NCIN_MEMBRE.Text = ""
                tb_nom_membre.Text = ""
                tb_nom_membre.Enabled = True
                TB_NCIN_MEMBRE.Enabled = True
                cb_Nom_évenement.Enabled = True
                r_non.Checked = False
                cb_Nom_évenement.Text = ""
                r_oui.Checked = False
            End If


        Else
            MsgBox("Tapez un CIN de membre valide")
            TB_NCIN_MEMBRE.Text = ""
            tb_nom_membre.Text = ""
            cb_Nom_évenement.Text = ""
            r_non.Checked = False
            r_oui.Checked = False
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
                eventt.Value = cb_Nom_évenement.Text








                Dim cmd As New OracleCommand
                cmd.Connection = con

                cmd.Parameters.Add(ncin)

                cmd.Parameters.Add(eventt)





                cmd.CommandText = "select NCIN_MEMBRE,ID_EVENEMENT from PARTICIPE_MEMBRE where NCIN_MEMBRE=:1 and ID_EVENEMENT=:2 "
                cmd.CommandType = CommandType.Text

                Dim dr As OracleDataReader = cmd.ExecuteReader()
                Dim p As Boolean
                p = dr.Read()
                If p = True Then
                    con.Dispose()

                    Dim conn1 As New OracleConnection(XE)
                    conn1.Open()

                    Dim ncin1 As New OracleParameter
                    ncin.OracleDbType = OracleDbType.Decimal
                    ncin1.Value = TB_NCIN_MEMBRE.Text

                    Dim eventt1 As New OracleParameter
                    eventt1.OracleDbType = OracleDbType.NVarchar2
                    eventt1.Value = cb_Nom_évenement.Text






                    Dim cmd2 As New OracleCommand
                    cmd2.Connection = conn1

                    cmd2.Parameters.Add(ncin1)
                    cmd2.Parameters.Add(eventt1)


                    cmd2.CommandText = "update PARTICIPE_MEMBRE set presence_membre='Non' where ncin_membre=:1 and id_evenement=:2  "
                    cmd2.CommandType = CommandType.Text

                    Dim dr2 As OracleDataReader = cmd2.ExecuteReader()
                    dr2.Read()
                    cb_Nom_évenement.Text = ""

                    TB_NCIN_MEMBRE.Text = ""
                    tb_nom_membre.Text = ""
                    tb_nom_membre.Enabled = True
                    TB_NCIN_MEMBRE.Enabled = True
                    cb_Nom_évenement.Enabled = True
                    r_non.Checked = False
                    r_oui.Checked = False
                    MsgBox("Absence est Noter pour ce membre")
                    con.Dispose()
                Else
                    MsgBox("ce membre n'est pas participer dans ce evenement")
                    tb_nom_membre.Text = ""
                    cb_Nom_évenement.Text = ""
                    TB_NCIN_MEMBRE.Text = ""
                    tb_nom_membre.Text = ""
                    tb_nom_membre.Enabled = True
                    TB_NCIN_MEMBRE.Enabled = True
                    cb_Nom_évenement.Enabled = True
                    r_non.Checked = False
                    cb_Nom_évenement.Text = ""
                    r_oui.Checked = False
                    con.Dispose()

                End If

                ''badilt fil participe membre
            Else
                MsgBox("Ce cin n'existe pas")

                tb_nom_membre.Text = ""
                cb_Nom_évenement.Text = ""
                TB_NCIN_MEMBRE.Text = ""
                tb_nom_membre.Text = ""
                tb_nom_membre.Enabled = True
                TB_NCIN_MEMBRE.Enabled = True
                cb_Nom_évenement.Enabled = True
                r_non.Checked = False
                cb_Nom_évenement.Text = ""
                r_oui.Checked = False

            End If


        Else

            MsgBox("Tapez un CIN de membre valide")
            TB_NCIN_MEMBRE.Text = ""
            tb_nom_membre.Text = ""
            cb_Nom_évenement.Text = ""
            r_non.Checked = False
            r_oui.Checked = False


        End If
    End Sub

    Private Sub bt_Quitter_Click(sender As Object, e As EventArgs) Handles bt_Quitter.Click
        Me.Close()
        connexion.Close()
    End Sub
End Class

