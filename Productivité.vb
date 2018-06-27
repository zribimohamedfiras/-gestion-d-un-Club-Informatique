Public Class Productivité
    Private Sub bt_retour_Click(sender As Object, e As EventArgs) Handles bt_retour.Click
        Rebrique_Ressources_humaines.Show()
        Me.Close()

    End Sub

    Private Sub bt_Quiter_Click(sender As Object, e As EventArgs) Handles bt_Quiter.Click
        Me.Close()
        connexion.Close()

    End Sub

    Private Sub bt_departements_Click(sender As Object, e As EventArgs) Handles bt_departements.Click
        Statistique_Departement.Show()
        Me.Close()

    End Sub

    Private Sub Button1abt_departement_evenementiel_Click(sender As Object, e As EventArgs) Handles Button1abt_departement_evenementiel.Click
        Statistique_Departement_Evenmentiel.Show()
        Me.Close()

    End Sub

    Private Sub bt_Departement_Communication_Click(sender As Object, e As EventArgs) Handles bt_Departement_Communication.Click
        Statistique_Departement_Communication.Show()
        Me.Close()

    End Sub

    Private Sub bt_Departement_Sponsoring_Click(sender As Object, e As EventArgs) Handles bt_Departement_Sponsoring.Click
        Statistique_Departement_Sponsoring.Show()
        Me.Close()

    End Sub

    Private Sub Productivité_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class