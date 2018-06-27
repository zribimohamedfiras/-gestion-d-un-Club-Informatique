Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types


Public Class Rebrique_Secrétaire_Général

    Private Sub bt_Saisie_Inscrit_Click(sender As Object, e As EventArgs) Handles bt_Saisie_Inscrit.Click
        Ajout_inscrit.Show()
        Me.Close()

    End Sub

    Private Sub tb_Saisie_Materiel_Click(sender As Object, e As EventArgs) Handles tb_Saisie_Materiel.Click
        Gestion_des_Materiel.Show()
        Me.Close()

    End Sub

    Private Sub bt_Presence_Inscrit_Click(sender As Object, e As EventArgs) Handles bt_Presence_Inscrit.Click
        Presence_Inscrit.Show()
        Me.Close()

    End Sub

    Private Sub bt_presence_invite_Click(sender As Object, e As EventArgs) Handles bt_presence_invite.Click
        Presence_Invité.Show()
        Me.Close()

    End Sub

    Private Sub bt_retour_Click(sender As Object, e As EventArgs) Handles bt_retour.Click
        Accueil.Show()
        Me.Close()

    End Sub

    Private Sub Rebrique_Secrétaire_Général_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim xe As String = "data source=xe;user id=system;password=firas123;"
        Dim con As New OracleConnection(xe)
        con.Open()
        Dim cmd As New OracleCommand
        cmd.Connection = con
        cmd.CommandText = "select NOM_EVENEMENT from EVENEMENT where DATE_EVENEMENT=(select max(DATE_EVENEMENT) from EVENEMENT)"
        cmd.CommandType = CommandType.Text
        Dim dr As OracleDataReader = cmd.ExecuteReader()
        If dr.Read() Then
            ComboBox1.Items.Add(dr.Item("NOM_EVENEMENT"))
            ComboBox1.Text = ComboBox1.Items.Item(0)

        End If
        con.Dispose()

    End Sub

    Private Sub bt_Affectation_Matériels_Click(sender As Object, e As EventArgs) Handles bt_Affectation_Matériels.Click
        gestion_des_affectation_de_matiriel.Show()
        Me.Close()
    End Sub

    Private Sub bt_Quitter_Click(sender As Object, e As EventArgs) Handles bt_Quitter.Click
        Me.Close()
        connexion.Close()
    End Sub
End Class