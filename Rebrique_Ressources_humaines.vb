Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types




Public Class Rebrique_Ressources_humaines

    Private Sub bt_responsable_Click(sender As Object, e As EventArgs) Handles bt_responsable.Click
        Responsable_Ressources_humaines_et_son_adjoint.Show()
        Me.Close()

    End Sub

    Private Sub Retour_Click(sender As Object, e As EventArgs) Handles Retour.Click
        Accueil.Show()
        Me.Close()
    End Sub

    Private Sub bt_membre_Click(sender As Object, e As EventArgs) Handles bt_membre.Click
        Responsable_Ressources_humaines_et_son_adjoint.Show()
        Me.Close()
    End Sub

    Private Sub Rebrique_Ressources_humaines_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub bt_Quitter_Click(sender As Object, e As EventArgs) Handles bt_Quitter.Click
        Me.Close()
        connexion.Close()
    End Sub
End Class