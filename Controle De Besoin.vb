Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types

Public Class Controle_De_Besoin
    Private Sub bt_Retour_Click(sender As Object, e As EventArgs) Handles bt_Retour.Click
        Rebrique_Trésorier.Show()
        Me.Close()
        connexion.Close()

        cb__Nom_Evenement.Text = ""
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub bt_Quitter_Click(sender As Object, e As EventArgs) Handles bt_Quitter.Click

        cb__Nom_Evenement.Text = ""
        DataGridView1.Rows.Clear()
        Me.Close()
        connexion.Close()
    End Sub

    Private Sub Controle_De_Besoin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb__Nom_Evenement.Text = ""
        DataGridView1.Rows.Clear()

        Dim xe As String = "data source=xe;user id=system;password=firas123;"
        Dim con As New OracleConnection(xe)
        con.Open()
        Dim cmd As New OracleCommand
        cmd.Connection = con
        cmd.CommandText = "select NOM_EVENEMENT from EVENEMENT "
        cmd.CommandType = CommandType.Text
        Dim dr As OracleDataReader = cmd.ExecuteReader()
        While dr.Read()
            cb__Nom_Evenement.Items.Add(dr.Item("NOM_EVENEMENT"))
        End While
        con.Dispose()
    End Sub


    Function verif2() As Boolean
        Dim v As Boolean = True
        Dim c As Boolean = False
        Dim i As Integer = 0

        If cb__Nom_Evenement.Text Is Nothing Then

            v = False
        Else

            While i < cb__Nom_Evenement.Items.Count() And c = False
                If cb__Nom_Evenement.Text = cb__Nom_Evenement.Items.Item(i) Then

                    c = True
                End If
                i = i + 1
            End While

            If c = False Then
                v = False
            End If

        End If

        Return v

    End Function


    Function id_evenemenet() As String
        Dim xe As String = "data source=xe;user id=system;password=firas123;"
        Dim con As New OracleConnection(xe)
        con.Open()
        Dim parm As New OracleParameter
        parm.OracleDbType = OracleDbType.Varchar2
        parm.Value = cb__Nom_Evenement.Text

        Dim cmd As New OracleCommand
        cmd.Connection = con
        cmd.Parameters.Add(parm)

        cmd.CommandText = "select id_evenement from evenement where nom_evenement=:1"
        cmd.CommandType = CommandType.Text
        Dim dr As OracleDataReader = cmd.ExecuteReader()
        dr.Read()
        Dim x As String = dr.Item("id_evenement")


        con.Dispose()

        Return x
    End Function

    Private Sub bt_Afficher_Click(sender As Object, e As EventArgs) Handles bt_Afficher.Click
        If verif2() Then
            DataGridView1.Rows.Clear()

            Dim xe As String = "data source=xe;user id=system;password=firas123;"
            Dim con As New OracleConnection(xe)
            con.Open()

            Dim parm As New OracleParameter
            parm.OracleDbType = OracleDbType.Varchar2
            parm.Value = id_evenemenet()

            Dim cmd As New OracleCommand
            cmd.Connection = con
            cmd.Parameters.Add(parm)
            cmd.CommandText = "select * from UTILISE_MATERIEL where ID_EVENEMENT=:1"
            cmd.CommandType = CommandType.Text

            Dim dr As OracleDataReader = cmd.ExecuteReader()
            While dr.Read()

                Dim id As String = dr.Item("ID_MATERIEL")
                Dim Q As String = dr.Item("QUANTITE")
                Dim P As String = dr.Item("PRIX_MATERIEL")
                DataGridView1.Rows.Add(id, "", "", Q, P)


            End While

            con.Dispose()

            If DataGridView1.RowCount > 0 Then
                Dim i As Integer
                Dim con1 As New OracleConnection(xe)
                con1.Open()



                Dim cmd1 As New OracleCommand
                cmd1.Connection = con1

                cmd1.CommandText = "select * from materiel "
                cmd1.CommandType = CommandType.Text

                Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
                While dr1.Read()
                    For i = 0 To (DataGridView1.RowCount - 1)
                        If DataGridView1.Item(0, i).Value = dr1.Item("ID_MATERIEL") Then
                            DataGridView1.Item(1, i).Value = dr1.Item("NOM_MATERIEL")
                            DataGridView1.Item(2, i).Value = dr1.Item("TYPE_MATERIEL")
                        End If
                    Next
                End While



                con1.Dispose()
            End If
        Else
            MessageBox.Show("il faut preciser l'evenement", "erreur")
        End If
    End Sub
End Class