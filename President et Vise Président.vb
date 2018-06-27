Public Class President_et_Vise_Président

    Private Sub RE_Click(sender As Object, e As EventArgs) Handles RE.Click
        Accueil.Show()
        Me.Close()

    End Sub

    Private Sub bt_évenements_Click(sender As Object, e As EventArgs) Handles bt_évenements.Click
        Gestion_des_évenements.Show()
        Me.Close()

    End Sub

    Private Sub bt_invite_Click(sender As Object, e As EventArgs) Handles bt_invite.Click
        Gestion_des_invités.Show()
        Me.Close()

    End Sub

    Private Sub President_et_Vise_Président_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bt_Quitter_Click(sender As Object, e As EventArgs) Handles bt_Quitter.Click
        Me.Close()
        connexion.Close()
    End Sub
End Class