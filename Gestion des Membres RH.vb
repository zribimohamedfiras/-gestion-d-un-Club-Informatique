Imports System.Data
Imports Oracle.DataAccess.Types
Imports Oracle.DataAccess.Client

Public Class Gestion_des_Membres_RH
    Function supper(x As DataGridView, p As Integer)
        Dim c As Integer
        Dim i As Integer = 0
        While x.Rows(i).Cells(0).Value <> p
            i = i + 1
        End While
        c = i
        Return c
    End Function


    Sub ajout(d As DataGridView, x As String, x1 As String, x2 As String, x3 As String)
        d.Rows.Add(x, x1, x2, x3)
    End Sub

    Function modifier(d As DataGridView, p As Integer)
        Dim c As Integer
        Dim i As Integer = 0
        While d.Rows(i).Cells(0).Value <> p
            i = i + 1
        End While
        c = i
        Return c
    End Function

    Private Sub RE_Click(sender As Object, e As EventArgs) Handles RE.Click
        Responsable_Ressources_humaines_et_son_adjoint.Show()
        Tb_fonction.Enabled = False
        Tb_nom_membre.Enabled = False
        Tb_prenom_membre.Enabled = False
        Tb_mail_membre.Enabled = False
        Tb_id_departement.Enabled = False
        bt_supprimer.Enabled = False
        bt_modifier.Enabled = False
        bt_enregistrer.Enabled = False
        bt_ajouter.Enabled = False
        browse.Visible = False
        bt_chercher.Enabled = True

        PictureBox1.Image = My.Resources.c
        Tb_fonction.Text = ""
        Tb_id_departement.Text = ""
        tb_image.Text = ""
        Tb_mail_membre.Text = ""
        Tb_ncin_membre.Text = ""
        Tb_nom_membre.Text = ""
        Tb_prenom_membre.Text = ""
        Me.Close()

    End Sub
    ''si le cle primare est existe
    Function verif() As Boolean
        Dim v As Boolean = True
        If Tb_ncin_membre.Text = "" And Me.Tb_ncin_membre.Text Is Nothing Or Not IsNumeric(Me.Tb_ncin_membre.Text) Or Tb_ncin_membre.TextLength <> 7 Then
            v = False

        End If
        Return v

    End Function

    Private Sub Gestion_des_Membres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tb_fonction.Enabled = False
        Tb_nom_membre.Enabled = False
        Tb_prenom_membre.Enabled = False
        Tb_mail_membre.Enabled = False
        Tb_id_departement.Enabled = False
        bt_supprimer.Enabled = False
        bt_modifier.Enabled = False
        bt_enregistrer.Enabled = False
        bt_ajouter.Enabled = False
        browse.Visible = False
        bt_chercher.Enabled = True
        Tb_fonction.Text = ""
        Tb_id_departement.Text = ""
        tb_image.Text = ""
        Tb_mail_membre.Text = ""
        Tb_ncin_membre.Text = ""
        Tb_nom_membre.Text = ""
        Tb_prenom_membre.Text = ""
        PictureBox1.Image = My.Resources.c



    End Sub

    Private Sub bt_chercher_Click(sender As Object, e As EventArgs) Handles bt_chercher.Click
        Tb_ncin_membre.Enabled = True
        Tb_fonction.Enabled = False
        Tb_nom_membre.Enabled = False
        Tb_prenom_membre.Enabled = False
        Tb_mail_membre.Enabled = False
        Tb_id_departement.Enabled = False
        'vider des TB, si la recherche ne retourne rien ils restent vides.
        Tb_fonction.Text = ""
        Tb_nom_membre.Text = ""
        Tb_prenom_membre.Text = ""
        Tb_mail_membre.Text = ""
        Tb_id_departement.Text = ""
        bt_supprimer.Enabled = False
        bt_modifier.Enabled = False
        bt_ajouter.Enabled = False
        ''-Vérifier si le pilote existe dans la base

        If verif() = True Then

            Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123;"
            Dim con As New OracleConnection(XE)
            con.Open()

            Dim ncin As New OracleParameter
            ncin.OracleDbType = OracleDbType.NVarchar2
            ncin.Value = Tb_ncin_membre.Text()

            Dim cmd As New OracleCommand
            cmd.Connection = con
            cmd.Parameters.Add(ncin)

            cmd.CommandText = "select * from MEMBRE where NCIN_MEMBRE=:1"
            cmd.CommandType = CommandType.Text



            Dim dr As OracleDataReader = cmd.ExecuteReader()
            Dim p As Boolean
            p = dr.Read()
            ''si la cle primare ecrit existe ou non
            If p = True Then


                Tb_fonction.Text = dr.Item("fonction").ToString
                Tb_nom_membre.Text = dr.Item("nom_membre").ToString
                Tb_prenom_membre.Text = dr.Item("prenom_membre").ToString
                Tb_mail_membre.Text = dr.Item("mail_membre").ToString
                Tb_id_departement.Text = dr.Item("id_departement").ToString
                If Convert.ToString(dr.Item("image")) = "" Then
                    PictureBox1.Image = My.Resources.c
                Else
                    tb_image.Text = Convert.ToString(dr.Item("image"))

                    PictureBox1.Image = Image.FromFile(tb_image.Text)
                End If
                con.Dispose()

                bt_supprimer.Enabled = True
                bt_modifier.Enabled = True
                bt_ajouter.Enabled = False
                bt_enregistrer.Enabled = False

                bt_chercher.Enabled = False
                'si le membre existe on ne peut pas l’ajouter
            Else
                MsgBox("ce cin n'existe pas vous voulez ajouter")

                bt_supprimer.Enabled = False
                bt_modifier.Enabled = False
                bt_enregistrer.Enabled = False
                bt_ajouter.Enabled = True
                'Si le membre n’existe pas dans la base on peut donc l’ajouter End If
            End If
        Else
            MsgBox("Tapez un CIN de membre valide")
            bt_chercher.Enabled = True
            bt_modifier.Enabled = False
            bt_supprimer.Enabled = False
            bt_enregistrer.Enabled = False

        End If
    End Sub

    Function verif2() As Boolean
        Dim t As Boolean
        t = True

        If ((Tb_fonction.Text = "") And (Tb_nom_membre.Text = "") And (Tb_prenom_membre.Text = "") And (Tb_mail_membre.Text = "") And (Tb_id_departement.Text = "")) Then
            t = False


        End If
        Return t
    End Function

    Private Sub bt_ajouter_Click(sender As Object, e As EventArgs) Handles bt_ajouter.Click
        If verif() = True Then

            Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123;"
            Dim con As New OracleConnection(XE)
            con.Open()
            'Paramètres pour la sauvegarde 
            Dim ncin As New OracleParameter
            ncin.OracleDbType = OracleDbType.Decimal
            ncin.Value = Tb_ncin_membre.Text

            Dim cmd As New OracleCommand
            cmd.Connection = con
            cmd.Parameters.Add(ncin)
            cmd.CommandText = "SELECT * FROM MEMBRE where NCIN_MEMBRE=:1"
            cmd.CommandType = CommandType.Text
            Dim dr As OracleDataReader = cmd.ExecuteReader()
            If dr.Read = False Then
                con.Dispose()

                bt_ajouter.Enabled = False
                browse.Visible = True
                bt_enregistrer.Enabled = True
                bt_modifier.Enabled = False
                bt_supprimer.Enabled = False
                Tb_ncin_membre.Enabled = False
                Tb_fonction.Enabled = True
                Tb_nom_membre.Enabled = True
                Tb_prenom_membre.Enabled = True
                Tb_mail_membre.Enabled = True
                Tb_id_departement.Enabled = True


                tb_image.Text = ""
                Tb_fonction.Text = ""
                Tb_nom_membre.Text = ""
                Tb_prenom_membre.Text = ""
                Tb_mail_membre.Text = ""
                Tb_id_departement.Text = ""
            Else
                MsgBox("ce cin est deja utiliser")
                Tb_ncin_membre.Text = ""

            End If

        Else
            MsgBox("Tapez un CIN de membre valide")

            bt_modifier.Enabled = False
            bt_supprimer.Enabled = False
            bt_enregistrer.Enabled = False
            Tb_ncin_membre.Text = ""
        End If




    End Sub

    Private Sub bt_modifier_Click(sender As Object, e As EventArgs) Handles bt_modifier.Click
        bt_enregistrer.Enabled = True
        Tb_ncin_membre.Enabled = False
        Tb_fonction.Enabled = True
        Tb_nom_membre.Enabled = True
        Tb_prenom_membre.Enabled = True
        Tb_mail_membre.Enabled = True
        Tb_id_departement.Enabled = True
        browse.Visible = True
        bt_modifier.Enabled = False
        bt_supprimer.Enabled = False
        bt_chercher.Enabled = False
    End Sub

    Private Sub bt_supprimer_Click(sender As Object, e As EventArgs) Handles bt_supprimer.Click
        If MsgBox("Etes vous sûr de vouloir supprimer?", vbYesNo, "Suppression") = MsgBoxResult.Yes Then
            Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123;"
            Dim con As New OracleConnection(XE)
            con.Open()

            Dim ncin_suprimer As New OracleParameter
            ncin_suprimer.OracleDbType = OracleDbType.Decimal
            ncin_suprimer.Value = Tb_ncin_membre.Text

            Dim cmd1 As New OracleCommand
            cmd1.Connection = con
            cmd1.Parameters.Add(ncin_suprimer)
            cmd1.CommandText = "DELETE FROM MEMBRE where NCIN_MEMBRE=:1"
            cmd1.CommandType = CommandType.Text

            Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
            Dim x As DataGridView
            Dim c As Integer

            Dim p As Integer
            x = data_membre
            p = Tb_ncin_membre.Text
            c = supper(x, p)
            data_membre.Rows.RemoveAt(c)

            bt_ajouter.Enabled = False
            bt_modifier.Enabled = False
            bt_supprimer.Enabled = False
            bt_enregistrer.Enabled = False
            Tb_ncin_membre.Text = ""
            Tb_fonction.Text = ""
            Tb_nom_membre.Text = ""
            Tb_prenom_membre.Text = ""
            Tb_mail_membre.Text = ""
            Tb_id_departement.Text = ""
            PictureBox1.Image = My.Resources.c
            MsgBox("supprission   avec succes")


            con.Dispose()
            bt_chercher.Enabled = True
            bt_ajouter.Enabled = True
        End If

    End Sub

    Private Sub bt_enregistrer_Click(sender As Object, e As EventArgs) Handles bt_enregistrer.Click
        If MsgBox("Etes vous sûr de vouloir ajouter ou modifier?", vbYesNo, "ajouter ou modifier") = MsgBoxResult.Yes Then
            Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123;"
            Dim con As New OracleConnection(XE)
            con.Open()
            'Paramètres pour la sauvegarde 
            Dim ncin As New OracleParameter
            ncin.OracleDbType = OracleDbType.Decimal
            ncin.Value = Tb_ncin_membre.Text

            Dim ncin_enegistre As New OracleParameter
            ncin_enegistre.OracleDbType = OracleDbType.Decimal
            ncin_enegistre.Value = Tb_ncin_membre.Text




            Dim fonction As New OracleParameter
            fonction.OracleDbType = OracleDbType.NVarchar2
            fonction.Value = Tb_fonction.Text

            Dim nom_membre As New OracleParameter
            nom_membre.OracleDbType = OracleDbType.NVarchar2
            nom_membre.Value = Tb_nom_membre.Text
            Dim prenom_membre As New OracleParameter
            prenom_membre.OracleDbType = OracleDbType.NVarchar2
            prenom_membre.Value = Tb_prenom_membre.Text


            Dim mail_membre As New OracleParameter
            mail_membre.OracleDbType = OracleDbType.NVarchar2
            mail_membre.Value = Tb_mail_membre.Text


            Dim id_departement As New OracleParameter
            id_departement.OracleDbType = OracleDbType.NVarchar2
            id_departement.Value = Tb_id_departement.Text
            'Vérifier si c’est un ajout ou modification

            Dim cmd As New OracleCommand
            cmd.Connection = con
            cmd.Parameters.Add(ncin_enegistre)
            cmd.CommandText = "SELECT * FROM MEMBRE where NCIN_MEMBRE=:1"
            cmd.CommandType = CommandType.Text
            Dim dr As OracleDataReader = cmd.ExecuteReader()
            If dr.Read Then
                con.Dispose()
                MsgBox("On a une modification")
                If MsgBox("Etes vous sûr de vouloir modifier?", vbYesNo, "Modifier") = MsgBoxResult.Yes Then
                    Dim conn1 As New OracleConnection(XE)
                    conn1.Open()
                    Dim cmd2 As New OracleCommand
                    cmd2.Connection = conn1
                    If tb_image.Text = "" Then
                        cmd2.Parameters.Add(ncin)
                        cmd2.Parameters.Add(fonction)
                        cmd2.Parameters.Add(nom_membre)
                        cmd2.Parameters.Add(prenom_membre)
                        cmd2.Parameters.Add(mail_membre)
                        cmd2.Parameters.Add(id_departement)
                        cmd2.CommandText = "update membre set ncin_membre=:1,fonction=:2,nom_membre=:3,prenom_membre=:4,mail_membre=:5,id_departement=:6 where ncin_membre=:1"
                        cmd2.CommandType = CommandType.Text
                        Dim dr1 As OracleDataReader = cmd2.ExecuteReader()

                    Else
                        Dim image As New OracleParameter
                        image.OracleDbType = OracleDbType.Varchar2
                        image.Value = tb_image.Text

                        cmd2.Parameters.Add(ncin)
                        cmd2.Parameters.Add(fonction)
                        cmd2.Parameters.Add(nom_membre)
                        cmd2.Parameters.Add(prenom_membre)
                        cmd2.Parameters.Add(mail_membre)
                        cmd2.Parameters.Add(id_departement)
                        cmd2.Parameters.Add(image)
                        cmd2.CommandText = "update membre set ncin_membre=:1,fonction=:2,nom_membre=:3,prenom_membre=:4,mail_membre=:5,id_departement=:6,IMAGE=:7 where ncin_membre=:1"
                        cmd2.CommandType = CommandType.Text
                        Dim dr1 As OracleDataReader = cmd2.ExecuteReader()

                    End If
                    'Désactiver la modification 

                    Tb_ncin_membre.Enabled = True
                    Tb_fonction.Enabled = False
                    Tb_nom_membre.Enabled = False
                    Tb_prenom_membre.Enabled = False
                    Tb_mail_membre.Enabled = False
                    Tb_id_departement.Enabled = False

                    Dim id_departement1 As New OracleParameter
                    id_departement1.OracleDbType = OracleDbType.NVarchar2
                    id_departement1.Value = Tb_id_departement.Text
                    Dim cmd5 As New OracleCommand
                    cmd5.Connection = conn1
                    cmd5.Parameters.Add(id_departement1)
                    cmd5.CommandText = "select NOM_DEPARTEMENT from DEPARTEMENT_CLUB where ID_DEPARTEMENT=:1"
                    Dim dr5 As OracleDataReader = cmd5.ExecuteReader()
                    If dr5.Read = True Then
                        Dim ch As String
                        ch = dr5.Item("NOM_DEPARTEMENT").ToString

                        Dim p As Integer
                        Dim d As DataGridView
                        Dim c As Integer

                        d = data_membre
                        p = Tb_ncin_membre.Text
                        c = supper(d, p)
                        data_membre.Rows(c).Cells(0).Value = Tb_ncin_membre.Text
                        data_membre.Rows(c).Cells(1).Value = Tb_nom_membre.Text
                        data_membre.Rows(c).Cells(2).Value = Tb_prenom_membre.Text
                        data_membre.Rows(c).Cells(3).Value = ch

                    End If
                    Tb_fonction.Enabled = False
                    Tb_nom_membre.Enabled = False
                    Tb_prenom_membre.Enabled = False
                    Tb_mail_membre.Enabled = False
                    Tb_id_departement.Enabled = False
                    bt_supprimer.Enabled = False
                    bt_modifier.Enabled = False
                    bt_enregistrer.Enabled = False
                    bt_ajouter.Enabled = False
                    browse.Visible = False
                    bt_chercher.Enabled = True
                    Tb_fonction.Text = ""
                    Tb_id_departement.Text = ""
                    tb_image.Text = ""
                    Tb_mail_membre.Text = ""
                    Tb_ncin_membre.Text = ""
                    Tb_nom_membre.Text = ""
                    Tb_prenom_membre.Text = ""
                    PictureBox1.Image = My.Resources.c
                    MsgBox("Membre modifié avec succés")
                    conn1.Dispose()
                End If

            Else
                con.Dispose()
                If verif2() Then
                    MsgBox("insertion dans la base")
                    If MsgBox("Etes vous sûr de vouloir ajouter?", vbYesNo, "Modifier") = MsgBoxResult.Yes Then
                        Dim conn1 As New OracleConnection(XE)
                        conn1.Open()

                        Dim cmd2 As New OracleCommand
                        cmd2.Connection = conn1
                        If tb_image.Text = "" Then

                            cmd2.Parameters.Add(ncin)
                            cmd2.Parameters.Add(fonction)
                            cmd2.Parameters.Add(nom_membre)
                            cmd2.Parameters.Add(prenom_membre)
                            cmd2.Parameters.Add(mail_membre)
                            cmd2.Parameters.Add(id_departement)
                            cmd2.CommandText = "insert into MEMBRE(NCIN_MEMBRE, nom_membre, prenom_membre, fonction, mail_membre, id_departement)values(:1,:2,:3,:4,:5,:6)"

                            cmd2.CommandType = CommandType.Text
                        Else
                            Dim image As New OracleParameter
                            image.OracleDbType = OracleDbType.Varchar2
                            image.Value = tb_image.Text

                            cmd2.Parameters.Add(ncin)
                            cmd2.Parameters.Add(fonction)
                            cmd2.Parameters.Add(nom_membre)
                            cmd2.Parameters.Add(prenom_membre)
                            cmd2.Parameters.Add(mail_membre)
                            cmd2.Parameters.Add(id_departement)
                            cmd2.Parameters.Add(image)
                            cmd2.CommandText = "insert into MEMBRE(NCIN_MEMBRE,NOM_MEMBRE,PRENOM_MEMBRE,FONCTION,MAIL_MEMBRE,ID_DEPARTEMENT,IMAGE) values (:1,:2,:3,:4,:5,:6,:7)"
                            cmd2.CommandType = CommandType.Text
                        End If

                        Dim dr1 As OracleDataReader = cmd2.ExecuteReader()
                        'Désactiver la modification 

                        Tb_ncin_membre.Enabled = True
                        Tb_fonction.Enabled = False
                        Tb_nom_membre.Enabled = False
                        Tb_prenom_membre.Enabled = False
                        Tb_mail_membre.Enabled = False
                        Tb_id_departement.Enabled = False

                        ''fonction ajouter
                        Dim id_departement1 As New OracleParameter
                        id_departement1.OracleDbType = OracleDbType.NVarchar2
                        id_departement1.Value = Tb_id_departement.Text

                        Dim cmd5 As New OracleCommand
                        cmd5.Connection = conn1
                        cmd5.Parameters.Add(id_departement1)
                        cmd5.CommandText = "Select NOM_DEPARTEMENT from DEPARTEMENT_CLUB where ID_DEPARTEMENT=:1"
                        Dim dr5 As OracleDataReader = cmd5.ExecuteReader()
                        If dr5.Read = True Then
                            Dim ch As String
                            ch = dr5.Item("NOM_DEPARTEMENT").ToString

                            ajout(data_membre, Tb_ncin_membre.Text, Tb_nom_membre.Text, Tb_prenom_membre.Text, ch)
                        End If

                        Tb_fonction.Enabled = False
                        Tb_nom_membre.Enabled = False
                        Tb_prenom_membre.Enabled = False
                        Tb_mail_membre.Enabled = False
                        Tb_id_departement.Enabled = False
                        bt_supprimer.Enabled = False
                        bt_modifier.Enabled = False
                        bt_enregistrer.Enabled = False
                        bt_ajouter.Enabled = False
                        browse.Visible = False
                        bt_chercher.Enabled = True
                        Tb_fonction.Text = ""
                        Tb_id_departement.Text = ""
                        tb_image.Text = ""
                        Tb_mail_membre.Text = ""
                        Tb_ncin_membre.Text = ""
                        Tb_nom_membre.Text = ""
                        Tb_prenom_membre.Text = ""
                        PictureBox1.Image = My.Resources.c
                        MsgBox("Membre ajoute avec succeé")





                        conn1.Dispose()
                    Else
                        MsgBox("Il faut remplir tout les champs")
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub tb_Annuler_Click(sender As Object, e As EventArgs) Handles tb_Annuler.Click
        Tb_fonction.Enabled = False
        Tb_nom_membre.Enabled = False
        Tb_prenom_membre.Enabled = False
        Tb_mail_membre.Enabled = False
        Tb_id_departement.Enabled = False
        bt_supprimer.Enabled = False
        bt_modifier.Enabled = False
        bt_enregistrer.Enabled = False
        bt_ajouter.Enabled = False
        browse.Visible = False
        bt_chercher.Enabled = True
        PictureBox1.Image = My.Resources.c
        Tb_fonction.Text = ""
        Tb_id_departement.Text = ""
        tb_image.Text = ""
        Tb_mail_membre.Text = ""
        Tb_ncin_membre.Text = ""
        Tb_nom_membre.Text = ""
        Tb_prenom_membre.Text = ""
    End Sub

    Private Sub Tb_ncin_membre_TextChanged(sender As Object, e As EventArgs) Handles Tb_ncin_membre.TextChanged

    End Sub

    Private Sub browse_Click(sender As Object, e As EventArgs) Handles browse.Click
        OpenFileDialog1.ShowDialog()
        tb_image.Text = OpenFileDialog1.FileName
        PictureBox1.Image = Image.FromFile(tb_image.Text)

    End Sub

    Private Sub bt_Quitter_Click(sender As Object, e As EventArgs) Handles bt_Quitter.Click
        Me.Close()
        connexion.Close()
    End Sub
End Class