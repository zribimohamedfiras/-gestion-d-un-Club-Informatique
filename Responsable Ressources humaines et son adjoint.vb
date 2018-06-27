Public Class Responsable_Ressources_humaines_et_son_adjoint

  

 
    Private Sub bt_Gestion_des_Membres_Click(sender As Object, e As EventArgs) Handles bt_Gestion_des_Membres.Click
        Gestion_des_Membres_RH.Show()
        Me.Close()

    End Sub

    Private Sub bt_Noter_un_membre_Click(sender As Object, e As EventArgs) Handles bt_absences.Click
        Gestion_des_absences_RH.Show()
        Me.Close()

    End Sub


    Private Sub bt_gestion_notes_Click(sender As Object, e As EventArgs) Handles bt_gestion_notes.Click
        Gestion_des_Notes.Show()
        Me.Close()

    End Sub

    Private Sub bt_acedoite_Click(sender As Object, e As EventArgs) Handles bt_acedoite.Click
        Productivité.Show()
        Me.Close()

    End Sub

    Private Sub RE_Click(sender As Object, e As EventArgs) Handles RE.Click
        Rebrique_Ressources_humaines.Show()
        Me.Close()
    End Sub

    Private Sub bt_Quitter_Click(sender As Object, e As EventArgs) Handles bt_Quitter.Click
        Me.Close()
        connexion.Close()
    End Sub
End Class