Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types


Public Class Ajout_inscrit

    Function verif1() As Boolean
        Dim v As Boolean = True
        If Me.tb_ncin.Text Is Nothing Or Me.tb_ncin.TextLength <> 7 Or Not IsNumeric(Me.tb_ncin.Text) Then

            v = False
        End If

        Return v
    End Function



    Private Sub Ajout_inscrit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tb_mail.Enabled = False
        tb_nom.Enabled = False
        tb_prenom.Enabled = False
        bt_ajouter.Enabled = False
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False
        tb_mail.Text = ""
        tb_nom.Text = ""
        tb_prenom.Text = ""
        tb_ncin.Text = ""


        Dim xe As String = "data source=xe;user id=system;password=firas123;"


        DataGridView1.Rows.Clear()


        Dim con1 As New OracleConnection(xe)
        con1.Open()


        Dim cmd1 As New OracleCommand
        cmd1.Connection = con1

        cmd1.CommandText = "select *  from   INSCRIT "
        cmd1.CommandType = CommandType.Text
        Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
        While dr1.Read
            DataGridView1.Rows.Add(dr1.Item("ncin_inscrit"), dr1.Item("nom_inscrit"), dr1.Item("prenom_inscrit"))

        End While
        con1.Dispose()
    End Sub

    Private Sub bt_retour_Click(sender As Object, e As EventArgs) Handles bt_retour.Click
        Rebrique_Secrétaire_Général.Show()
        Me.Close()

        tb_mail.Text = ""
        tb_ncin.Text = ""
        tb_nom.Text = ""
        tb_prenom.Text = ""

    End Sub

    Private Sub bt_annuler_Click(sender As Object, e As EventArgs) Handles bt_annuler.Click
        tb_mail.Text = ""
        tb_ncin.Text = ""
        tb_nom.Text = ""
        tb_prenom.Text = ""
        tb_mail.Enabled = False
        tb_nom.Enabled = False
        tb_prenom.Enabled = False
        bt_ajouter.Enabled = False
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False

    End Sub



    Private Sub bt_chercher_Click(sender As Object, e As EventArgs) Handles bt_chercher.Click
        tb_ncin.Enabled = True

        tb_mail.Enabled = False
        tb_nom.Enabled = False
        tb_prenom.Enabled = False
        bt_ajouter.Enabled = False
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False
        tb_mail.Text = ""
        tb_nom.Text = ""
        tb_prenom.Text = ""



        If verif1() = True Then

            Dim xe As String = "data source=xe;user id=system;password=firas123;"
            Dim con As New OracleConnection(xe)
            con.Open()


            Dim parm2 As New OracleParameter
            parm2.Value = tb_ncin.Text
            parm2.OracleDbType = OracleDbType.Decimal
            Dim cmd As New OracleCommand
            cmd.Connection = con

            cmd.Parameters.Add(parm2)
            cmd.CommandText = "select * from inscrit where NCIN_INSCRIT=:1"
            cmd.CommandType = CommandType.Text
            Dim dr As OracleDataReader = cmd.ExecuteReader()
            If dr.Read() Then
                bt_enregistrer.Enabled = False
                bt_ajouter.Enabled = False
                bt_modifier.Enabled = True
                bt_supprimer.Enabled = True
                tb_nom.Text = dr.Item("nom_inscrit")
                tb_prenom.Text = dr.Item("prenom_inscrit")
                tb_mail.Text = dr.Item("mail_inscrit")
                con.Dispose()


            Else
                If MsgBox("cet personne n'existe pas", vbYesNo, "tu peut ajouter un personne dans leur ncin est que te l'induire") = MsgBoxResult.Yes Then
                    bt_enregistrer.Enabled = False
                    bt_ajouter.Enabled = True
                    bt_modifier.Enabled = False
                    bt_supprimer.Enabled = False
                    con.Dispose()

                End If
            End If
                Else



            MessageBox.Show("erreur", "tapez un numero de cin SVP")
            bt_ajouter.Enabled = False
            bt_modifier.Enabled = False
            bt_supprimer.Enabled = False
            bt_enregistrer.Enabled = False
            tb_ncin.Text = ""
            tb_mail.Text = ""
            tb_nom.Text = ""
            tb_prenom.Text = ""

        End If

    End Sub

    Private Sub bt_ajouter_Click(sender As Object, e As EventArgs) Handles bt_ajouter.Click
        bt_enregistrer.Enabled = True
        tb_mail.Text = ""
        tb_nom.Text = ""
        tb_prenom.Text = ""
        tb_mail.Enabled = True
        tb_ncin.Enabled = False
        tb_nom.Enabled = True
        tb_prenom.Enabled = True
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False
        bt_chercher.Enabled = False

    End Sub

    Private Sub bt_modifier_Click(sender As Object, e As EventArgs) Handles bt_modifier.Click
        bt_enregistrer.Enabled = True
        bt_chercher.Enabled = False
        tb_mail.Enabled = True
        tb_ncin.Enabled = False
        tb_nom.Enabled = True
        tb_prenom.Enabled = True
        bt_ajouter.Enabled = False

    End Sub

    Private Sub bt_supprimer_Click(sender As Object, e As EventArgs) Handles bt_supprimer.Click
        bt_chercher.Enabled = False

        If MsgBox("Etes vous sûr de vouloir supprimer?", vbYesNo, "Suppression") = MsgBoxResult.Yes Then
            Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123"
            Dim con As New OracleConnection(XE)
            con.Open()

            Dim ncin_suprimer As New OracleParameter
            ncin_suprimer.OracleDbType = OracleDbType.Decimal
            ncin_suprimer.Value = tb_ncin.Text

            Dim cmd1 As New OracleCommand()
            cmd1.Connection = con
            cmd1.Parameters.Add(ncin_suprimer)
            cmd1.CommandText = "DELETE FROM inscrit where NCIN_INSCRIT=:1"
            cmd1.CommandType = CommandType.Text

            Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
            bt_ajouter.Enabled = False
            bt_chercher.Enabled = True
            bt_enregistrer.Enabled = False
            bt_modifier.Enabled = False
            bt_supprimer.Enabled = False
            tb_ncin.Enabled = True
            tb_mail.Enabled = False
            tb_nom.Enabled = False
            tb_prenom.Enabled = False
            tb_ncin.Text = ""
            tb_mail.Text = ""
            tb_nom.Text = ""
            tb_prenom.Text = ""
            con.Dispose()
            MsgBox("supprission avec succés")

            DataGridView1.Rows.Clear()


            Dim con2 As New OracleConnection(XE)
            con2.Open()


            Dim cmd3 As New OracleCommand
            cmd3.Connection = con2

            cmd3.CommandText = "select *  from   INSCRIT "
            cmd3.CommandType = CommandType.Text
            Dim dr5 As OracleDataReader = cmd3.ExecuteReader()
            While dr5.Read()
                DataGridView1.Rows.Add(dr5.Item("ncin_inscrit"), dr5.Item("nom_inscrit"), dr5.Item("prenom_inscrit"))

            End While
            con2.Dispose()
            bt_chercher.Enabled = True
            tb_ncin.Enabled = True
        End If

    End Sub

    Private Sub bt_enregistrer_Click(sender As Object, e As EventArgs) Handles bt_enregistrer.Click
        Dim xe As String = "data source=xe;user id=system;password=firas123;"
        Dim con As New OracleConnection(xe)
        con.Open()


        Dim parm2 As New OracleParameter
        parm2.Value = tb_ncin.Text
        parm2.OracleDbType = OracleDbType.Decimal
        Dim cmd As New OracleCommand
        cmd.Connection = con

        cmd.Parameters.Add(parm2)
        cmd.CommandText = "select * from inscrit where NCIN_INSCRIT=:1"
        cmd.CommandType = CommandType.Text
        Dim dr As OracleDataReader = cmd.ExecuteReader()
        If dr.Read() = False Then
            con.Dispose()
            If MsgBox("Etes vous sûr de vouloir ajouter?", vbYesNo, "Ajouter") = MsgBoxResult.Yes Then
                Dim con1 As New OracleConnection(xe)
                con1.Open()


                Dim parm3 As New OracleParameter
                parm3.Value = tb_ncin.Text
                parm3.OracleDbType = OracleDbType.Decimal
                Dim parm4 As New OracleParameter
                parm4.Value = tb_nom.Text
                parm4.OracleDbType = OracleDbType.Varchar2
                Dim parm5 As New OracleParameter
                parm5.Value = tb_prenom.Text
                parm5.OracleDbType = OracleDbType.Varchar2
                Dim parm6 As New OracleParameter
                parm6.Value = tb_mail.Text
                parm6.OracleDbType = OracleDbType.Varchar2

                Dim cmd2 As New OracleCommand
                cmd2.Connection = con1

                cmd2.Parameters.Add(parm3)
                cmd2.Parameters.Add(parm4)
                cmd2.Parameters.Add(parm5)
                cmd2.Parameters.Add(parm6)
                cmd2.CommandText = "insert into INSCRIT(NCIN_INSCRIT,NOM_INSCRIT,PRENOM_INSCRIT,MAIL_INSCRIT) values(:1,:2,:3,:4)"
                cmd2.CommandType = CommandType.Text
                Dim dr1 As OracleDataReader = cmd2.ExecuteReader()
                con1.Dispose()
                bt_chercher.Enabled = True
                tb_mail.Enabled = False
                tb_nom.Enabled = False
                tb_prenom.Enabled = False
                bt_ajouter.Enabled = False
                bt_enregistrer.Enabled = False
                bt_modifier.Enabled = False
                bt_supprimer.Enabled = False
                tb_mail.Text = ""
                tb_nom.Text = ""
                tb_prenom.Text = ""
                tb_ncin.Text = ""

                MsgBox("inscrit ajoute avec succée")



                DataGridView1.Rows.Clear()


                Dim con2 As New OracleConnection(xe)
                con2.Open()


                Dim cmd3 As New OracleCommand
                cmd3.Connection = con2

                cmd3.CommandText = "select *  from   INSCRIT "
                cmd3.CommandType = CommandType.Text
                Dim dr5 As OracleDataReader = cmd3.ExecuteReader()
                While dr5.Read()
                    DataGridView1.Rows.Add(dr5.Item("ncin_inscrit"), dr5.Item("nom_inscrit"), dr5.Item("prenom_inscrit"))

                End While
                con2.Dispose()
                bt_chercher.Enabled = True
                tb_ncin.Enabled = True
            End If
        Else
            con.Dispose()
            If MsgBox("Etes vous sûr de vouloir modifier?", vbYesNo, "Modifier") = MsgBoxResult.Yes Then
                Dim con1 As New OracleConnection(xe)
                con1.Open()


                Dim parm3 As New OracleParameter
                parm3.Value = tb_ncin.Text
                parm3.OracleDbType = OracleDbType.Decimal
                Dim parm4 As New OracleParameter
                parm4.Value = tb_nom.Text
                parm4.OracleDbType = OracleDbType.Varchar2
                Dim parm5 As New OracleParameter
                parm5.Value = tb_prenom.Text
                parm5.OracleDbType = OracleDbType.Varchar2
                Dim parm6 As New OracleParameter
                parm6.Value = tb_mail.Text
                parm6.OracleDbType = OracleDbType.Varchar2

                Dim cmd2 As New OracleCommand
                cmd2.Connection = con1

                cmd2.Parameters.Add(parm3)
                cmd2.Parameters.Add(parm4)
                cmd2.Parameters.Add(parm5)
                cmd2.Parameters.Add(parm6)
                cmd2.CommandText = "update INSCRIT set NCIN_INSCRIT=:1,NOM_INSCRIT=:2,PRENOM_INSCRIT=:3,MAIL_INSCRIT=:4 where NCIN_INSCRIT=:1"
                cmd2.CommandType = CommandType.Text
                Dim dr1 As OracleDataReader = cmd2.ExecuteReader()
                con1.Dispose()

                tb_mail.Enabled = False
                tb_nom.Enabled = False
                tb_prenom.Enabled = False
                bt_ajouter.Enabled = False
                bt_enregistrer.Enabled = False
                bt_modifier.Enabled = False
                bt_supprimer.Enabled = False
                tb_mail.Text = ""
                tb_nom.Text = ""
                tb_prenom.Text = ""
                tb_ncin.Text = ""

                MsgBox("inscrit modifié avec succés")



                DataGridView1.Rows.Clear()


                Dim con2 As New OracleConnection(xe)
                con2.Open()


                Dim cmd3 As New OracleCommand
                cmd3.Connection = con2

                cmd3.CommandText = "select *  from   INSCRIT "
                cmd3.CommandType = CommandType.Text
                Dim dr5 As OracleDataReader = cmd3.ExecuteReader()
                While dr5.Read()
                    DataGridView1.Rows.Add(dr5.Item("ncin_inscrit"), dr5.Item("nom_inscrit"), dr5.Item("prenom_inscrit"))

                End While
                con2.Dispose()
                bt_chercher.Enabled = True
                tb_ncin.Enabled = True
            End If

        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub lb_ncin_Click(sender As Object, e As EventArgs) Handles lb_ncin.Click

    End Sub

    Private Sub lb_nom_Click(sender As Object, e As EventArgs) Handles lb_nom.Click

    End Sub

    Private Sub lb_Prenom_Click(sender As Object, e As EventArgs) Handles lb_Prenom.Click

    End Sub

    Private Sub lb_mail_Click(sender As Object, e As EventArgs) Handles lb_mail.Click

    End Sub

    Private Sub tb_ncin_TextChanged(sender As Object, e As EventArgs) Handles tb_ncin.TextChanged

    End Sub

    Private Sub tb_nom_TextChanged(sender As Object, e As EventArgs) Handles tb_nom.TextChanged

    End Sub

    Private Sub tb_prenom_TextChanged(sender As Object, e As EventArgs) Handles tb_prenom.TextChanged

    End Sub

    Private Sub tb_mail_TextChanged(sender As Object, e As EventArgs) Handles tb_mail.TextChanged

    End Sub

    Private Sub bt_Quitter_Click(sender As Object, e As EventArgs) Handles bt_Quitter.Click
        Me.Close()
        connexion.Close()
    End Sub
End Class