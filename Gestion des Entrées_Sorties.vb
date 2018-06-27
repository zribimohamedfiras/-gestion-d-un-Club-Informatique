Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types



Public Class Gestion_des_Entrées_Sorties


    Function verif() As Boolean
        Dim v As Boolean = True
        If tb_ID_Entrées_Sorties.Text Is Nothing And tb_ID_Entrées_Sorties.Text = "" Then
            v = False
        Else
            If tb_ID_Entrées_Sorties.Text(0) <> "j" Then
                v = False
            End If
        End If
        Return v

    End Function


    Private Sub tb_Annuler_Click(sender As Object, e As EventArgs) Handles tb_Annuler.Click
        tb_date.Text = ""
        tb_Libelle.Text = ""
        tb_mantant.Text = ""
        tb_quantité.Text = ""
        tb_type.Text = ""
        tb_ID_Entrées_Sorties.Text = ""
        tb_nom.Text = ""

        tb_date.Enabled = False
        tb_ID_Entrées_Sorties.Enabled = True
        tb_Libelle.Enabled = False
        tb_mantant.Enabled = False
        tb_nom.Enabled = False
        tb_quantité.Enabled = False
        tb_type.Enabled = False

        bt_Ajouter.Enabled = False
        bt_chercher.Enabled = True
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False

    End Sub

    Private Sub RE_Click(sender As Object, e As EventArgs) Handles RE.Click
        Rebrique_Trésorier.Show()
        Me.Close()
        tb_date.Text = ""
        tb_Libelle.Text = ""
        tb_mantant.Text = ""
        tb_quantité.Text = ""
        tb_type.Text = ""
        tb_ID_Entrées_Sorties.Text = ""
        tb_nom.Text = ""

        tb_date.Enabled = False
        tb_ID_Entrées_Sorties.Enabled = True
        tb_Libelle.Enabled = False
        tb_mantant.Enabled = False
        tb_nom.Enabled = False
        tb_quantité.Enabled = False
        tb_type.Enabled = False

        bt_Ajouter.Enabled = False
        bt_chercher.Enabled = True
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False
    End Sub


    Private Sub Gestion_des_Entrées_Sorties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_date.Text = ""
        tb_Libelle.Text = ""
        tb_mantant.Text = ""
        tb_quantité.Text = ""
        tb_type.Text = ""
        tb_ID_Entrées_Sorties.Text = ""
        tb_nom.Text = ""

        tb_date.Enabled = False
        tb_ID_Entrées_Sorties.Enabled = True
        tb_Libelle.Enabled = False
        tb_mantant.Enabled = False
        tb_nom.Enabled = False
        tb_quantité.Enabled = False
        tb_type.Enabled = False

        bt_Ajouter.Enabled = False
        bt_chercher.Enabled = True
        bt_enregistrer.Enabled = False
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False
        Dim xe As String = "data source=xe;user id=system;password=firas123;"


        DataGridView1.Rows.Clear()


        Dim con1 As New OracleConnection(xe)
        con1.Open()


        Dim cmd1 As New OracleCommand
        cmd1.Connection = con1

        cmd1.CommandText = "select * from JOURNAL "
        cmd1.CommandType = CommandType.Text
        Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
        While dr1.Read()
            DataGridView1.Rows.Add(dr1.Item("ID_ENTREES_SORTIES"), dr1.Item("NOM_ENTREES_SORTIES"), dr1.Item("TYPE_ENTREES_SORTIES"))

        End While
        con1.Dispose()
    End Sub

    Private Sub bt_chercher_Click(sender As Object, e As EventArgs) Handles bt_chercher.Click
        tb_date.Enabled = False
        tb_ID_Entrées_Sorties.Enabled = True
        tb_Libelle.Enabled = False
        tb_mantant.Enabled = False
        tb_nom.Enabled = False
        tb_quantité.Enabled = False
        tb_type.Enabled = False

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
            parm2.Value = tb_ID_Entrées_Sorties.Text
            Dim cmd1 As New OracleCommand
            cmd1.Connection = con1

            cmd1.Parameters.Add(parm2)
            cmd1.CommandText = "select * from JOURNAL where ID_ENTREES_SORTIES=:1 "
            cmd1.CommandType = CommandType.Text
            Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
            If dr1.Read() Then

                tb_Libelle.Text = dr1.Item("LIBELE_ENTREES_SORTIES")
                tb_date.Text = dr1.Item("DATE_ENTREES_SORTIES")
                tb_mantant.Text = dr1.Item("MONTANT_ENTREES_SORTIES")
                tb_nom.Text = dr1.Item("NOM_ENTREES_SORTIES")
                tb_quantité.Text = dr1.Item("QUANTITE_ENTREES_SORTIES")
                tb_type.Text = dr1.Item("TYPE_ENTREES_SORTIES")

                tb_date.Enabled = False
                tb_ID_Entrées_Sorties.Enabled = True
                tb_Libelle.Enabled = False
                tb_mantant.Enabled = False
                tb_nom.Enabled = False
                tb_quantité.Enabled = False
                tb_type.Enabled = False

                bt_Ajouter.Enabled = False
                bt_chercher.Enabled = False
                bt_enregistrer.Enabled = False
                bt_modifier.Enabled = True
                bt_supprimer.Enabled = True
            Else
                tb_date.Enabled = False
                tb_ID_Entrées_Sorties.Enabled = True
                tb_Libelle.Enabled = False
                tb_mantant.Enabled = False
                tb_nom.Enabled = False
                tb_quantité.Enabled = False
                tb_type.Enabled = False

                bt_Ajouter.Enabled = True
                bt_chercher.Enabled = False
                bt_enregistrer.Enabled = False
                bt_modifier.Enabled = False
                bt_supprimer.Enabled = False
            End If







        End If
    End Sub

    Private Sub bt_Ajouter_Click(sender As Object, e As EventArgs) Handles bt_Ajouter.Click
        tb_date.Enabled = True
        tb_ID_Entrées_Sorties.Enabled = False
        tb_Libelle.Enabled = True
        tb_mantant.Enabled = True
        tb_nom.Enabled = True
        tb_quantité.Enabled = True
        tb_type.Enabled = True

        bt_Ajouter.Enabled = False
        bt_chercher.Enabled = False
        bt_enregistrer.Enabled = True
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False
    End Sub

    Private Sub bt_modifier_Click(sender As Object, e As EventArgs) Handles bt_modifier.Click
        tb_date.Enabled = True
        tb_ID_Entrées_Sorties.Enabled = False
        tb_Libelle.Enabled = True
        tb_mantant.Enabled = True
        tb_nom.Enabled = True
        tb_quantité.Enabled = True
        tb_type.Enabled = True

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
            sup1.Value = tb_ID_Entrées_Sorties.Text

            Dim cmd1 As New OracleCommand
            cmd1.Connection = con
            cmd1.Parameters.Add(sup1)
            cmd1.CommandText = "delete from JOURNAL where ID_ENTREES_SORTIES=:1"
            cmd1.CommandType = CommandType.Text
            Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
            con.Dispose()

            tb_date.Text = ""
            tb_Libelle.Text = ""
            tb_mantant.Text = ""
            tb_quantité.Text = ""
            tb_type.Text = ""
            tb_ID_Entrées_Sorties.Text = ""
            tb_nom.Text = ""

            tb_date.Enabled = False
            tb_ID_Entrées_Sorties.Enabled = True
            tb_Libelle.Enabled = False
            tb_mantant.Enabled = False
            tb_nom.Enabled = False
            tb_quantité.Enabled = False
            tb_type.Enabled = False

            bt_Ajouter.Enabled = False
            bt_chercher.Enabled = True
            bt_enregistrer.Enabled = False
            bt_modifier.Enabled = False
            bt_supprimer.Enabled = False
            MsgBox("supprission avec succés")

            DataGridView1.Rows.Clear()


            Dim con18 As New OracleConnection(xe)
            con18.Open()


            Dim cmd18 As New OracleCommand
            cmd18.Connection = con18

            cmd18.CommandText = "select * from JOURNAL "
            cmd18.CommandType = CommandType.Text
            Dim dr18 As OracleDataReader = cmd18.ExecuteReader()
            While dr18.Read()
                DataGridView1.Rows.Add(dr18.Item("ID_ENTREES_SORTIES"), dr18.Item("NOM_ENTREES_SORTIES"), dr18.Item("TYPE_ENTREES_SORTIES"))

            End While
            con18.Dispose()
        End If

    End Sub

    Private Sub bt_enregistrer_Click(sender As Object, e As EventArgs) Handles bt_enregistrer.Click
        Dim xe As String = "data source=xe;user id=system;password=firas123;"
        Dim con1 As New OracleConnection(xe)
        con1.Open()


        Dim parm2 As New OracleParameter
        parm2.OracleDbType = OracleDbType.Varchar2
        parm2.Value = tb_ID_Entrées_Sorties.Text
        Dim cmd1 As New OracleCommand
        cmd1.Connection = con1

        cmd1.Parameters.Add(parm2)
        cmd1.CommandText = "select * from JOURNAL where ID_ENTREES_SORTIES=:1 "
        cmd1.CommandType = CommandType.Text
        Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
        If dr1.Read() = False Then
            If MsgBox("Etes vous sûr de vouloir ajouter?", vbYesNo, "Ajouter") = MsgBoxResult.Yes Then
                Dim con5 As New OracleConnection(xe)
                con5.Open()

                Dim parm3 As New OracleParameter
                parm3.OracleDbType = OracleDbType.Varchar2
                parm3.Value = tb_ID_Entrées_Sorties.Text

                Dim parm4 As New OracleParameter
                parm4.OracleDbType = OracleDbType.Date
                parm4.Value = Convert.ToDateTime(tb_date.Text)

                Dim parm5 As New OracleParameter
                parm5.OracleDbType = OracleDbType.Varchar2
                parm5.Value = tb_Libelle.Text

                Dim parm6 As New OracleParameter
                parm6.OracleDbType = OracleDbType.Varchar2
                parm6.Value = tb_type.Text

                Dim parm7 As New OracleParameter
                parm7.OracleDbType = OracleDbType.Varchar2
                parm7.Value = tb_nom.Text

                Dim parm8 As New OracleParameter
                parm8.OracleDbType = OracleDbType.Int64
                parm8.Value = Convert.ToInt64(tb_quantité.Text)

                Dim parm9 As New OracleParameter
                parm9.OracleDbType = OracleDbType.Double
                parm9.Value = Convert.ToDouble(tb_mantant.Text)

                Dim cmd5 As New OracleCommand
                cmd5.Connection = con5

                cmd5.Parameters.Add(parm3)
                cmd5.Parameters.Add(parm4)
                cmd5.Parameters.Add(parm5)
                cmd5.Parameters.Add(parm6)
                cmd5.Parameters.Add(parm7)
                cmd5.Parameters.Add(parm8)
                cmd5.Parameters.Add(parm9)

                cmd5.CommandText = "insert into JOURNAL(ID_ENTREES_SORTIES,DATE_ENTREES_SORTIES,NOM_ENTREES_SORTIES,TYPE_ENTREES_SORTIES,LIBELE_ENTREES_SORTIES,QUANTITE_ENTREES_SORTIES,MONTANT_ENTREES_SORTIES) values(:1,:2,:5,:4,:3,:6,:7)"
                cmd5.CommandType = CommandType.Text

                Dim dr5 As OracleDataReader = cmd5.ExecuteReader()
                con5.Dispose()
                tb_date.Text = ""
                tb_Libelle.Text = ""
                tb_mantant.Text = ""
                tb_quantité.Text = ""
                tb_type.Text = ""
                tb_ID_Entrées_Sorties.Text = ""
                tb_nom.Text = ""

                tb_date.Enabled = False
                tb_ID_Entrées_Sorties.Enabled = True
                tb_Libelle.Enabled = False
                tb_mantant.Enabled = False
                tb_nom.Enabled = False
                tb_quantité.Enabled = False
                tb_type.Enabled = False

                bt_Ajouter.Enabled = False
                bt_chercher.Enabled = True
                bt_enregistrer.Enabled = False
                bt_modifier.Enabled = False
                bt_supprimer.Enabled = False
                MsgBox("ligne ajoutéé avec succée")

                DataGridView1.Rows.Clear()


                Dim con18 As New OracleConnection(xe)
                con18.Open()


                Dim cmd18 As New OracleCommand
                cmd18.Connection = con18

                cmd18.CommandText = "select * from JOURNAL "
                cmd18.CommandType = CommandType.Text
                Dim dr18 As OracleDataReader = cmd18.ExecuteReader()
                While dr18.Read()
                    DataGridView1.Rows.Add(dr18.Item("ID_ENTREES_SORTIES"), dr18.Item("NOM_ENTREES_SORTIES"), dr18.Item("TYPE_ENTREES_SORTIES"))

                End While
                con18.Dispose()
            End If
        Else

            If MsgBox("Etes vous sûr de vouloir modifier?", vbYesNo, "Modifier") = MsgBoxResult.Yes Then
                Dim con5 As New OracleConnection(xe)
                con5.Open()

                Dim parm3 As New OracleParameter
                parm3.OracleDbType = OracleDbType.Varchar2
                parm3.Value = tb_ID_Entrées_Sorties.Text

                Dim parm4 As New OracleParameter
                parm4.OracleDbType = OracleDbType.Date
                parm4.Value = tb_date.Text

                Dim parm5 As New OracleParameter
                parm5.OracleDbType = OracleDbType.Varchar2
                parm5.Value = tb_Libelle.Text

                Dim parm6 As New OracleParameter
                parm6.OracleDbType = OracleDbType.Varchar2
                parm6.Value = tb_type.Text

                Dim parm7 As New OracleParameter
                parm7.OracleDbType = OracleDbType.Varchar2
                parm7.Value = tb_nom.Text

                Dim parm8 As New OracleParameter
                parm8.OracleDbType = OracleDbType.Int64
                parm8.Value = tb_quantité.Text

                Dim parm9 As New OracleParameter
                parm9.OracleDbType = OracleDbType.Double
                parm9.Value = tb_mantant.Text

                Dim cmd5 As New OracleCommand
                cmd5.Connection = con5

                cmd5.Parameters.Add(parm3)
                cmd5.Parameters.Add(parm4)
                cmd5.Parameters.Add(parm5)
                cmd5.Parameters.Add(parm6)
                cmd5.Parameters.Add(parm7)
                cmd5.Parameters.Add(parm8)
                cmd5.Parameters.Add(parm9)

                cmd5.CommandText = "update JOURNAL set ID_ENTREES_SORTIES=:1,DATE_ENTREES_SORTIES=:2,NOM_ENTREES_SORTIES=:5,TYPE_ENTREES_SORTIES=:4,LIBELE_ENTREES_SORTIES=:3,QUANTITE_ENTREES_SORTIES=:6,MONTANT_ENTREES_SORTIES=:7  where ID_ENTREES_SORTIES=:1"
                cmd5.CommandType = CommandType.Text

                Dim dr5 As OracleDataReader = cmd5.ExecuteReader()
                con5.Dispose()
                tb_date.Text = ""
                tb_Libelle.Text = ""
                tb_mantant.Text = ""
                tb_quantité.Text = ""
                tb_type.Text = ""
                tb_ID_Entrées_Sorties.Text = ""
                tb_nom.Text = ""

                tb_date.Enabled = False
                tb_ID_Entrées_Sorties.Enabled = True
                tb_Libelle.Enabled = False
                tb_mantant.Enabled = False
                tb_nom.Enabled = False
                tb_quantité.Enabled = False
                tb_type.Enabled = False

                bt_Ajouter.Enabled = False
                bt_chercher.Enabled = True
                bt_enregistrer.Enabled = False
                bt_modifier.Enabled = False
                bt_supprimer.Enabled = False
                MsgBox("ligne modifier avec succée")

                DataGridView1.Rows.Clear()


                Dim con18 As New OracleConnection(xe)
                con18.Open()


                Dim cmd18 As New OracleCommand
                cmd18.Connection = con18

                cmd18.CommandText = "select * from JOURNAL "
                cmd18.CommandType = CommandType.Text
                Dim dr18 As OracleDataReader = cmd18.ExecuteReader()
                While dr18.Read()
                    DataGridView1.Rows.Add(dr18.Item("ID_ENTREES_SORTIES"), dr18.Item("NOM_ENTREES_SORTIES"), dr18.Item("TYPE_ENTREES_SORTIES"))

                End While
                con18.Dispose()
            End If
        End If
    End Sub

    Private Sub bt_Quitter_Click(sender As Object, e As EventArgs) Handles bt_Quitter.Click
        Me.Close()
        connexion.Close()
    End Sub
End Class