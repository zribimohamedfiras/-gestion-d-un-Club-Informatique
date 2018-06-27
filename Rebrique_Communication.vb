Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types




Public Class Rebrique_Communication


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub








    Private Sub bt_Gestion_Sponsors_Click(sender As Object, e As EventArgs) Handles bt_Gestion_Sponsors.Click
        Membre_Communicatuin.Show()
        Me.Close()
    End Sub

    Private Sub bt_Gestion_Membres_Click(sender As Object, e As EventArgs) Handles bt_Gestion_Membres.Click
        Responsable_Communication.Show()
        Me.Close()
    End Sub

    Private Sub RE_Click(sender As Object, e As EventArgs) Handles RE.Click
        Accueil.Show()
        Me.Close()
    End Sub

    Private Sub Rebrique_Communication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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