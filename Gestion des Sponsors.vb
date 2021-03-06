﻿Imports System.Data
Imports Oracle.DataAccess.Types
Imports Oracle.DataAccess.Client
Public Class Gestion_des_Sponsors
    Function verif() As Boolean
        Dim v As Boolean = True
        If tb_id_sponsor.Text = "" And Me.tb_id_sponsor.Text Is Nothing Or tb_id_sponsor.TextLength <> 2 Then
            v = False

        End If
        Return v

    End Function
    Function supper(x As DataGridView, p As String)
        Dim c As Integer
        Dim i As Integer = 0
        While x.Rows(i).Cells(0).Value <> p
            i = i + 1
        End While
        c = i
        Return c
    End Function


    Sub ajout(d As DataGridView, x As String, x1 As String)
        d.Rows.Add(x, x1)
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
    
 

    Private Sub Gestion_des_Sponsors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_id_sponsor.Enabled = True
        tb_adresse_sponsor.Enabled = False
        tb_mail_sponsor.Enabled = False
        tb_nom_sponsor.Enabled = False
        tb_tel_sponsor.Enabled = False
        bt_supprimer.Enabled = False
        bt_modifier.Enabled = False
        bt_enregistrer.Enabled = False
    End Sub
 

    Function verif2() As Boolean
        Dim t As Boolean
        t = True

        If ((tb_adresse_sponsor.Text = "") And (tb_mail_sponsor.Text = "") And (tb_nom_sponsor.Text = "") And (tb_tel_sponsor.Text = "")) Then
            t = False


        End If
        Return t
    End Function

     

 

   
     


     

    Private Sub bt_chercher_Click(sender As Object, e As EventArgs) Handles bt_chercher.Click
        tb_id_sponsor.Enabled = True
        tb_adresse_sponsor.Enabled = False
        tb_mail_sponsor.Enabled = False
        tb_nom_sponsor.Enabled = False
        tb_tel_sponsor.Enabled = False
        'vider des TB, si la recherche ne retourne rien ils restent vides.

        tb_adresse_sponsor.Text = ""

        tb_mail_sponsor.Text = ""
        tb_nom_sponsor.Text = ""
        tb_tel_sponsor.Text = ""
        bt_supprimer.Enabled = True
        bt_modifier.Enabled = True

        ''-Vérifier si le pilote existe dans la base

        If verif() = True Then

            Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123;"
            Dim con As New OracleConnection(XE)
            con.Open()

            Dim id As New OracleParameter
            id.OracleDbType = OracleDbType.NVarchar2
            id.Value = tb_id_sponsor.Text

            Dim cmd As New OracleCommand
            cmd.Connection = con
            cmd.Parameters.Add(id)

            cmd.CommandText = "select * from  sponsor where ID_SPONSOR=:1"
            cmd.CommandType = CommandType.Text



            Dim dr As OracleDataReader = cmd.ExecuteReader()
            Dim p As Boolean
            p = dr.Read()
            ''si la cle primare ecrit existe ou non
            If p = True Then

                ''tb_adresse_sponsor.Text = ""
                ''  tb_id_sponsor.Text = ""
                '' tb_mail_sponsor.Text = ""
                ''tb_nom_sponsor.Text = ""
                ''tb_tel_sponsor.Text = ""
                tb_tel_sponsor.Text = dr.Item("TEL_SPONSOR").ToString
                tb_mail_sponsor.Text = dr.Item("MAIL_SPONSOR").ToString
                tb_nom_sponsor.Text = dr.Item("NOM_SPONSOR").ToString
                tb_adresse_sponsor.Text = dr.Item("ADRESSE_SPONSOR").ToString
                con.Dispose()

                bt_supprimer.Enabled = True
                bt_modifier.Enabled = True
                bt_ajouter.Enabled = False
                bt_enregistrer.Enabled = False

                bt_chercher.Enabled = False
                'si le membre existe on ne peut pas l’ajouter
            Else
                MsgBox("ce id n'existe pas vous voulez ajouter")

                bt_supprimer.Enabled = False
                bt_modifier.Enabled = False
                bt_enregistrer.Enabled = False
                bt_ajouter.Enabled = True
                'Si le membre n’existe pas dans la base on peut donc l’ajouter End If
            End If
        Else
            MsgBox("Tapez un id de sponsor valide")
            tb_id_sponsor.Text = ""
            bt_modifier.Enabled = False
            bt_supprimer.Enabled = False
            bt_enregistrer.Enabled = False

        End If
    End Sub

    Private Sub bt_ajouter_Click(sender As Object, e As EventArgs) Handles bt_ajouter.Click
        If verif() = True Then

            Dim XE As String = "Data source=XE;user Id=system;password=firas123;"
            Dim conn As New OracleConnection(XE)
            conn.Open()

            Dim id As New OracleParameter
            id.OracleDbType = OracleDbType.NVarchar2
            id.Value = tb_id_sponsor.Text


            Dim cmd As New OracleCommand
            cmd.Connection = conn

            cmd.Parameters.Add(id)
            cmd.CommandText = "select * from sponsor where id_sponsor=:1"
            cmd.CommandType = CommandType.Text
            Dim dr As OracleDataReader = cmd.ExecuteReader()

            If dr.Read() = False Then





                bt_enregistrer.Enabled = True
                bt_modifier.Enabled = False
                bt_supprimer.Enabled = False
                tb_id_sponsor.Enabled = False
                tb_mail_sponsor.Enabled = True
                tb_tel_sponsor.Enabled = True
                tb_nom_sponsor.Enabled = True
                tb_adresse_sponsor.Enabled = True



                tb_adresse_sponsor.Text = ""

                tb_mail_sponsor.Text = ""
                tb_nom_sponsor.Text = ""
                tb_tel_sponsor.Text = ""

            Else
                MsgBox("Ce cin est existe dans la BD est deja utiliser")
            End If

        Else
            MsgBox("Tapez ID de membre valide")

            bt_modifier.Enabled = False
            bt_supprimer.Enabled = False
            bt_enregistrer.Enabled = False
            tb_id_sponsor.Text = ""
        End If

    End Sub

    Private Sub bt_enregistrer_Click(sender As Object, e As EventArgs) Handles bt_enregistrer.Click
        If MsgBox("Etes vous sûr de vouloir ajouter ou modifier?", vbYesNo, "ajouter ou modifier") = MsgBoxResult.Yes Then
            Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123;"
            Dim con As New OracleConnection(XE)
            con.Open()
            'Paramètres pour la sauvegarde 

            Dim id As New OracleParameter
            id.OracleDbType = OracleDbType.NVarchar2
            id.Value = tb_id_sponsor.Text

            Dim id_enegistre As New OracleParameter
            id_enegistre.OracleDbType = OracleDbType.NVarchar2
            id_enegistre.Value = tb_id_sponsor.Text


            Dim TEL_SPONSOR As New OracleParameter
            TEL_SPONSOR.OracleDbType = OracleDbType.Decimal
            TEL_SPONSOR.Value = tb_tel_sponsor.Text

            Dim MAIL_SPONSOR As New OracleParameter
            MAIL_SPONSOR.OracleDbType = OracleDbType.NVarchar2
            MAIL_SPONSOR.Value = tb_mail_sponsor.Text

            Dim NOM_SPONSOR As New OracleParameter
            NOM_SPONSOR.OracleDbType = OracleDbType.NVarchar2
            NOM_SPONSOR.Value = tb_nom_sponsor.Text


            Dim ADRESSE_SPONSOR As New OracleParameter
            ADRESSE_SPONSOR.OracleDbType = OracleDbType.NVarchar2
            ADRESSE_SPONSOR.Value = tb_adresse_sponsor.Text



            'Vérifier si c’est un ajout ou modification

            Dim cmd As New OracleCommand
            cmd.Connection = con
            cmd.Parameters.Add(id_enegistre)
            cmd.CommandText = "SELECT * FROM SPONSOR where ID_SPONSOR=:1"
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
                    cmd2.Parameters.Add(id)
                    cmd2.Parameters.Add(TEL_SPONSOR)
                    cmd2.Parameters.Add(MAIL_SPONSOR)
                    cmd2.Parameters.Add(NOM_SPONSOR)
                    cmd2.Parameters.Add(ADRESSE_SPONSOR)

                    cmd2.CommandText = "update SPONSOR set ID_SPONSOR=:1,TEL_SPONSOR=:2,MAIL_SPONSOR=:3,NOM_SPONSOR=:4,ADRESSE_SPONSOR=:5  where ID_SPONSOR=:1"

                    cmd2.CommandType = CommandType.Text
                    Dim dr1 As OracleDataReader = cmd2.ExecuteReader()
                    'Désactiver la modification 

                    tb_id_sponsor.Enabled = True
                    tb_mail_sponsor.Enabled = False
                    tb_tel_sponsor.Enabled = False
                    tb_nom_sponsor.Enabled = False
                    tb_adresse_sponsor.Enabled = False


                    Dim p As String = tb_id_sponsor.Text
                    Dim d As DataGridView = Data_sponsor
                    Dim c As Integer
                    c = supper(d, p)
                    Data_sponsor.Rows(c).Cells(0).Value = tb_id_sponsor.Text
                    Data_sponsor.Rows(c).Cells(1).Value = tb_nom_sponsor.Text


                    bt_modifier.Enabled = False
                    bt_enregistrer.Enabled = False
                    bt_ajouter.Enabled = False
                    bt_supprimer.Enabled = False
                    bt_chercher.Enabled = True
                    bt_ajouter.Enabled = True
                    tb_adresse_sponsor.Text = ""
                    tb_id_sponsor.Text = ""
                    tb_mail_sponsor.Text = ""
                    tb_nom_sponsor.Text = ""
                    tb_tel_sponsor.Text = ""
                    MsgBox("Sponsor est modifié avec succés")
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

                        cmd2.Parameters.Add(id)
                        cmd2.Parameters.Add(TEL_SPONSOR)
                        cmd2.Parameters.Add(MAIL_SPONSOR)
                        cmd2.Parameters.Add(NOM_SPONSOR)
                        cmd2.Parameters.Add(ADRESSE_SPONSOR)
                        cmd2.CommandText = "insert into SPONSOR values(:1,:2,:3,:4,:5)"

                        cmd2.CommandType = CommandType.Text

                        Dim dr1 As OracleDataReader = cmd2.ExecuteReader()
                        'Désactiver la modification 


                        tb_id_sponsor.Enabled = True
                        tb_mail_sponsor.Enabled = False
                        tb_tel_sponsor.Enabled = False
                        tb_nom_sponsor.Enabled = False
                        tb_adresse_sponsor.Enabled = False

                        ajout(Data_sponsor, tb_id_sponsor.Text, tb_nom_sponsor.Text)

                        bt_modifier.Enabled = False
                        bt_enregistrer.Enabled = False
                        bt_ajouter.Enabled = False
                        bt_supprimer.Enabled = False
                        bt_chercher.Enabled = True
                        bt_ajouter.Enabled = True
                        MsgBox("Sponsor est ajoute avec succeé")
                        tb_adresse_sponsor.Text = ""
                        tb_id_sponsor.Text = ""
                        tb_mail_sponsor.Text = ""
                        tb_nom_sponsor.Text = ""
                        tb_tel_sponsor.Text = ""

                        conn1.Dispose()
                    Else
                        MsgBox("Il faur remplir tout les champs")
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub bt_modifier_Click(sender As Object, e As EventArgs) Handles bt_modifier.Click
        bt_enregistrer.Enabled = True

        tb_id_sponsor.Enabled = False
        tb_mail_sponsor.Enabled = True
        tb_tel_sponsor.Enabled = True
        tb_nom_sponsor.Enabled = True
        tb_adresse_sponsor.Enabled = True
    End Sub

    Private Sub bt_supprimer_Click(sender As Object, e As EventArgs) Handles bt_supprimer.Click
        If MsgBox("Etes vous sûr de vouloir supprimer?", vbYesNo, "Suppression") = MsgBoxResult.Yes Then
            Dim XE As String = "Data source=XE;User Id=SYSTEM ; password=firas123;"
            Dim con As New OracleConnection(XE)
            con.Open()

            Dim id_suprimer As New OracleParameter
            id_suprimer.OracleDbType = OracleDbType.NVarchar2
            id_suprimer.Value = tb_id_sponsor.Text

            Dim cmd1 As New OracleCommand
            cmd1.Connection = con
            cmd1.Parameters.Add(id_suprimer)
            cmd1.CommandText = "DELETE FROM SPONSOR where ID_SPONSOR=:1"
            cmd1.CommandType = CommandType.Text

            Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
            Dim x As DataGridView = Data_sponsor

            Dim c As Integer

            Dim p As String = tb_id_sponsor.Text


            c = supper(x, p)
            Data_sponsor.Rows.RemoveAt(c)


            bt_modifier.Enabled = False
            bt_supprimer.Enabled = False
            bt_enregistrer.Enabled = False
            tb_adresse_sponsor.Text = ""
            tb_id_sponsor.Text = ""
            tb_mail_sponsor.Text = ""
            tb_nom_sponsor.Text = ""
            tb_tel_sponsor.Text = ""
            MsgBox("supprission   avec succes")

            con.Dispose()
            bt_chercher.Enabled = True
            bt_ajouter.Enabled = True
        End If
    End Sub

    Private Sub bt_annuler_Click(sender As Object, e As EventArgs) Handles bt_annuler.Click
        tb_adresse_sponsor.Text = ""
        tb_id_sponsor.Text = ""
        tb_mail_sponsor.Text = ""
        tb_nom_sponsor.Text = ""
        tb_tel_sponsor.Text = ""


        tb_adresse_sponsor.Enabled = False
        tb_id_sponsor.Enabled = True
        tb_mail_sponsor.Enabled = False
        tb_nom_sponsor.Enabled = False
        tb_tel_sponsor.Enabled = False

        bt_supprimer.Enabled = False
        bt_modifier.Enabled = False
        bt_enregistrer.Enabled = False
        bt_ajouter.Enabled = True
        bt_chercher.Enabled = True
    End Sub

    Private Sub bt_retour_Click(sender As Object, e As EventArgs) Handles bt_retour.Click
        Responsable_Sponsoring.Show()
        tb_adresse_sponsor.Text = ""
        tb_id_sponsor.Text = ""
        tb_mail_sponsor.Text = ""
        tb_nom_sponsor.Text = ""
        tb_tel_sponsor.Text = ""

        tb_adresse_sponsor.Enabled = False
        tb_id_sponsor.Enabled = True
        tb_mail_sponsor.Enabled = False
        tb_nom_sponsor.Enabled = False
        tb_tel_sponsor.Enabled = False

        bt_supprimer.Enabled = False
        bt_modifier.Enabled = False
        bt_enregistrer.Enabled = False
        bt_ajouter.Enabled = True
        bt_chercher.Enabled = True
        Me.Close()
    End Sub

    Private Sub bt_Quitter_Click(sender As Object, e As EventArgs) Handles bt_Quitter.Click
        Me.Close()
        connexion.Close()
    End Sub
End Class