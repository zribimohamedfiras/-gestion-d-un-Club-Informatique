Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types


Public Class Gestion_des_Materiel
    Function verif() As Boolean
        Dim v As Boolean = True
        If tb_id_matériel.Text Is Nothing Then
            v = False
        Else
            If tb_id_matériel.Text(0) <> "m" Then
                v = False
            End If
        End If
        Return v

    End Function
    Private Sub bt_annuler_Click(sender As Object, e As EventArgs) Handles bt_annuler.Click
        tb_id_matériel.Text = ""
        tb_nom_materiel.Text = ""
        tb_Description.Text = ""
        tb_type.Text = ""



        bt_ajouter.Enabled = False
        bt_chercher.Enabled = True
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False
        tb_Description.Enabled = False
        tb_id_matériel.Enabled = True
        tb_nom_materiel.Enabled = False

        tb_type.Enabled = False

    End Sub

    Private Sub bt_retour_Click(sender As Object, e As EventArgs) Handles bt_retour.Click
        Rebrique_Secrétaire_Général.Show()
        Me.Close()
        tb_id_matériel.Text = ""
        tb_nom_materiel.Text = ""
        tb_Description.Text = ""
        tb_type.Text = ""


        bt_ajouter.Enabled = False
        bt_chercher.Enabled = True
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False
        tb_Description.Enabled = False
        tb_id_matériel.Enabled = True
        tb_nom_materiel.Enabled = False

        tb_type.Enabled = False

    End Sub

    Private Sub Gestion_des_Materiel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tb_id_matériel.Text = ""
        tb_nom_materiel.Text = ""
        tb_Description.Text = ""
        tb_type.Text = ""
        bt_ajouter.Enabled = False
        bt_chercher.Enabled = True
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False

        tb_id_matériel.Enabled = True
        tb_nom_materiel.Enabled = False
        tb_Description.Enabled = False
        tb_type.Enabled = False

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



    End Sub

    Private Sub bt_chercher_Click(sender As Object, e As EventArgs) Handles bt_chercher.Click

        tb_nom_materiel.Text = ""
        tb_Description.Text = ""
        tb_type.Text = ""
        bt_ajouter.Enabled = False
        bt_chercher.Enabled = True
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False

        tb_id_matériel.Enabled = True
        tb_nom_materiel.Enabled = False
        tb_Description.Enabled = False
        tb_type.Enabled = False

        If verif() Then
            Dim xe As String = "data source=xe;user id=system;password=firas123;"
            Dim con1 As New OracleConnection(xe)
            con1.Open()
            Dim parm1 As New OracleParameter
            parm1.OracleDbType = OracleDbType.Varchar2
            parm1.Value = tb_id_matériel.Text

            Dim cmd1 As New OracleCommand
            cmd1.Connection = con1
            cmd1.Parameters.Add(parm1)
            cmd1.CommandText = "select * from MATERIEL where ID_MATERIEL=:1 "
            cmd1.CommandType = CommandType.Text
            Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
            If dr1.Read() Then
                tb_nom_materiel.Text = dr1.Item("NOM_MATERIEL")
                tb_type.Text = dr1.Item("TYPE_MATERIEL")
                tb_Description.Text = dr1.Item("DESCRIPTION_MATERIEL")
                bt_enregistrer.Enabled = False
                bt_ajouter.Enabled = False
                bt_modifier.Enabled = True
                bt_supprimer.Enabled = True
                bt_chercher.Enabled = False
            Else
                If MsgBox("cet materiel n'existe pas", vbYesNo, "tu peut ajouter un nouvel materiel dans leur key est que te l'induire") = MsgBoxResult.Yes Then
                    bt_enregistrer.Enabled = False
                    bt_ajouter.Enabled = True
                    bt_modifier.Enabled = False
                    bt_supprimer.Enabled = False
                End If
            End If
        Else
            MessageBox.Show("il faut introduire un chaune de caractere dans la premier caractere est 'm'", "erreur")
        End If

    End Sub

    Private Sub bt_ajouter_Click(sender As Object, e As EventArgs) Handles bt_ajouter.Click
        bt_ajouter.Enabled = False
        bt_chercher.Enabled = False
        bt_enregistrer.Enabled = True
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False

        tb_id_matériel.Enabled = False
        tb_nom_materiel.Enabled = True
        tb_Description.Enabled = True
        tb_type.Enabled = True
        tb_Description.Text = ""
        tb_nom_materiel.Text = ""
        tb_type.Text = ""

    End Sub

    Private Sub bt_modifier_Click(sender As Object, e As EventArgs) Handles bt_modifier.Click
        bt_ajouter.Enabled = False
        bt_chercher.Enabled = False
        bt_enregistrer.Enabled = True
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False

        tb_id_matériel.Enabled = False
        tb_nom_materiel.Enabled = True
        tb_Description.Enabled = True
        tb_type.Enabled = True
    End Sub

    Private Sub bt_supprimer_Click(sender As Object, e As EventArgs) Handles bt_supprimer.Click
        bt_chercher.Enabled = False

        If MsgBox("Etes vous sûr de vouloir supprimer?", vbYesNo, "Suppression") = MsgBoxResult.Yes Then
            Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123;"
            Dim con As New OracleConnection(XE)
            con.Open()
            Dim parm1 As New OracleParameter
            parm1.OracleDbType = OracleDbType.Varchar2
            parm1.Value = tb_id_matériel.Text

            Dim cmd1 As New OracleCommand
            cmd1.Connection = con
            cmd1.Parameters.Add(parm1)
            cmd1.CommandText = "DELETE FROM MATERIEL where ID_MATERIEL=:1"
            cmd1.CommandType = CommandType.Text
            Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
            con.Dispose()
            tb_id_matériel.Text = ""
            tb_nom_materiel.Text = ""
            tb_Description.Text = ""
            tb_type.Text = ""
            bt_ajouter.Enabled = False
            bt_chercher.Enabled = True
            bt_enregistrer.Enabled = False
            bt_modifier.Enabled = False
            bt_supprimer.Enabled = False

            tb_id_matériel.Enabled = True
            tb_nom_materiel.Enabled = False
            tb_Description.Enabled = False
            tb_type.Enabled = False

            MsgBox("supprission avec succés")

            DataGridView1.Rows.Clear()


            Dim con1 As New OracleConnection(XE)
            con1.Open()


            Dim cmd2 As New OracleCommand
            cmd2.Connection = con1

            cmd2.CommandText = "select * from MATERIEL "
            cmd2.CommandType = CommandType.Text
            Dim dr2 As OracleDataReader = cmd2.ExecuteReader()
            While dr2.Read()
                DataGridView1.Rows.Add(dr2.Item("ID_MATERIEL"), dr2.Item("NOM_MATERIEL"), dr2.Item("TYPE_MATERIEL"))

            End While
            con1.Dispose()

        End If

    End Sub

    Private Sub bt_enregistrer_Click(sender As Object, e As EventArgs) Handles bt_enregistrer.Click
        Dim xe As String = "data source=xe;user id=system;password=firas123;"
        Dim con1 As New OracleConnection(xe)
        con1.Open()
        Dim parm1 As New OracleParameter
        parm1.OracleDbType = OracleDbType.Varchar2
        parm1.Value = tb_id_matériel.Text

        Dim cmd1 As New OracleCommand
        cmd1.Connection = con1
        cmd1.Parameters.Add(parm1)
        cmd1.CommandText = "select * from MATERIEL where ID_MATERIEL=:1 "
        cmd1.CommandType = CommandType.Text
        Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
        If dr1.Read() = False Then
            con1.Dispose()
            If MsgBox("Etes vous sûr de vouloir ajouter?", vbYesNo, "Ajouter") = MsgBoxResult.Yes Then
                Dim con2 As New OracleConnection(xe)
                con2.Open()

                Dim parm2 As New OracleParameter
                parm2.OracleDbType = OracleDbType.Varchar2
                parm2.Value = tb_id_matériel.Text
                Dim parm3 As New OracleParameter
                parm3.OracleDbType = OracleDbType.Varchar2
                parm3.Value = tb_nom_materiel.Text
                Dim parm4 As New OracleParameter
                parm4.OracleDbType = OracleDbType.Varchar2
                parm4.Value = tb_Description.Text
                Dim parm5 As New OracleParameter
                parm5.OracleDbType = OracleDbType.Varchar2
                parm5.Value = tb_type.Text

                Dim cmd2 As New OracleCommand
                cmd2.Connection = con2
                cmd2.Parameters.Add(parm2)
                cmd2.Parameters.Add(parm3)
                cmd2.Parameters.Add(parm4)
                cmd2.Parameters.Add(parm5)

                cmd2.CommandText = "insert into  MATERIEL (ID_MATERIEL,NOM_MATERIEL,DESCRIPTION_MATERIEL,TYPE_MATERIEL) values(:1,:2,:3,:4) "
                cmd2.CommandType = CommandType.Text

                Dim dr2 As OracleDataReader = cmd2.ExecuteReader()
                con2.Dispose()
                tb_id_matériel.Text = ""
                tb_nom_materiel.Text = ""
                tb_Description.Text = ""
                tb_type.Text = ""
                bt_ajouter.Enabled = False
                bt_chercher.Enabled = True
                bt_enregistrer.Enabled = False
                bt_modifier.Enabled = False
                bt_supprimer.Enabled = False

                tb_id_matériel.Enabled = True
                tb_nom_materiel.Enabled = False
                tb_Description.Enabled = False
                tb_type.Enabled = False
                MsgBox("Materiel ajoutéé avec succée")

                DataGridView1.Rows.Clear()


                Dim con3 As New OracleConnection(xe)
                con3.Open()


                Dim cmd3 As New OracleCommand
                cmd3.Connection = con3

                cmd3.CommandText = "select * from MATERIEL "
                cmd3.CommandType = CommandType.Text
                Dim dr3 As OracleDataReader = cmd3.ExecuteReader()
                While dr3.Read()
                    DataGridView1.Rows.Add(dr3.Item("ID_MATERIEL"), dr3.Item("NOM_MATERIEL"), dr3.Item("TYPE_MATERIEL"))

                End While
                con3.Dispose()



            End If
        Else
            con1.Dispose()
            If MsgBox("Etes vous sûr de vouloir modifier?", vbYesNo, "Modifier") = MsgBoxResult.Yes Then
                Dim con2 As New OracleConnection(xe)
                con2.Open()

                Dim parm2 As New OracleParameter
                parm2.OracleDbType = OracleDbType.Varchar2
                parm2.Value = tb_id_matériel.Text
                Dim parm3 As New OracleParameter
                parm3.OracleDbType = OracleDbType.Varchar2
                parm3.Value = tb_nom_materiel.Text
                Dim parm4 As New OracleParameter
                parm4.OracleDbType = OracleDbType.Varchar2
                parm4.Value = tb_Description.Text
                Dim parm5 As New OracleParameter
                parm5.OracleDbType = OracleDbType.Varchar2
                parm5.Value = tb_type.Text

                Dim cmd2 As New OracleCommand
                cmd2.Connection = con2
                cmd2.Parameters.Add(parm2)
                cmd2.Parameters.Add(parm3)
                cmd2.Parameters.Add(parm4)
                cmd2.Parameters.Add(parm5)

                cmd2.CommandText = "update materiel set ID_MATERIEL=:1,NOM_MATERIEL=:2,DESCRIPTION_MATERIEL=:3,TYPE_MATERIEL=:4 where ID_MATERIEL=:1 "
                cmd2.CommandType = CommandType.Text

                Dim dr2 As OracleDataReader = cmd2.ExecuteReader()
                con2.Dispose()
                tb_id_matériel.Text = ""
                tb_nom_materiel.Text = ""
                tb_Description.Text = ""
                tb_type.Text = ""
                bt_ajouter.Enabled = False
                bt_chercher.Enabled = True
                bt_enregistrer.Enabled = False
                bt_modifier.Enabled = False
                bt_supprimer.Enabled = False

                tb_id_matériel.Enabled = True
                tb_nom_materiel.Enabled = False
                tb_Description.Enabled = False
                tb_type.Enabled = False
                MsgBox("Materiel modifier avec succée")

                DataGridView1.Rows.Clear()


                Dim con3 As New OracleConnection(xe)
                con3.Open()


                Dim cmd3 As New OracleCommand
                cmd3.Connection = con3

                cmd3.CommandText = "select * from MATERIEL "
                cmd3.CommandType = CommandType.Text
                Dim dr3 As OracleDataReader = cmd3.ExecuteReader()
                While dr3.Read()
                    DataGridView1.Rows.Add(dr3.Item("ID_MATERIEL"), dr3.Item("NOM_MATERIEL"), dr3.Item("TYPE_MATERIEL"))

                End While
                con3.Dispose()



            End If

        End If
    End Sub

    Private Sub bt_Quitter_Click(sender As Object, e As EventArgs) Handles bt_Quitter.Click
        Me.Close()
        connexion.Close()
    End Sub
End Class