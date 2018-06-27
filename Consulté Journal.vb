Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types




Public Class Consulté_Journal

    Private Sub RE_Click(sender As Object, e As EventArgs) Handles RE.Click
        Rebrique_Trésorier.Show()
        Me.Close()
        tb_montant.Text = ""
        cb_annee.Text = "choisir une année"

        DataGridView1.Visible = False
    End Sub

    Private Sub tb_Annuler_Click(sender As Object, e As EventArgs) Handles bt_Annuler.Click
        tb_montant.Text = ""
        cb_annee.Text = "choisir une année"
        DataGridView1.Visible = False
    End Sub
    Function verif2() As Boolean
        Dim v As Boolean = True
        Dim c As Boolean = False
        Dim i As Integer = 0

        If cb_annee.Text Is Nothing Or cb_annee.Text = "choisir une année" Then

            v = False
        Else

            While i < cb_annee.Items.Count() And c = False
                If cb_annee.Text = cb_annee.Items.Item(i) Then

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
    Private Sub bt_journal_Click(sender As Object, e As EventArgs) Handles bt_journal.Click
        If verif2() Then
            If cb_annee.Text = "2015" Then
                Dim xe As String = "data source=xe;user id=system;password=firas123;"
                Dim con As New OracleConnection(xe)
                con.Open()
                Dim cmd As New OracleCommand
                cmd.Connection = con
                cmd.CommandText = "select * from JOURNAL where DATE_ENTREES_SORTIES>'31/12/2014' and DATE_ENTREES_SORTIES<'01/01/2016'"
                cmd.CommandType = CommandType.Text
                Dim dr As OracleDataReader = cmd.ExecuteReader()
                DataGridView1.Rows.Clear()
                DataGridView1.Visible = True
                While dr.Read()
                    DataGridView1.Rows.Add(dr.Item("DATE_ENTREES_SORTIES"), dr.Item("nom_entrees_sorties"), dr.Item("TYPE_ENTREES_SORTIES"), dr.Item("LIBELE_ENTREES_SORTIES"), dr.Item("QUANTITE_ENTREES_SORTIES"), dr.Item("MONTANT_ENTREES_SORTIES"))
                End While
                con.Dispose()
            ElseIf cb_annee.Text = "2016" Then

                Dim xe As String = "data source=xe;user id=system;password=firas123;"
                Dim con As New OracleConnection(xe)
                con.Open()
                Dim cmd As New OracleCommand
                cmd.Connection = con
                cmd.CommandText = "select * from JOURNAL where DATE_ENTREES_SORTIES>'31/12/2015' and DATE_ENTREES_SORTIES<'01/01/2017'"
                cmd.CommandType = CommandType.Text
                Dim dr As OracleDataReader = cmd.ExecuteReader()
                DataGridView1.Rows.Clear()
                DataGridView1.Visible = True
                While dr.Read()
                    DataGridView1.Rows.Add(dr.Item("DATE_ENTREES_SORTIES"), dr.Item("nom_entrees_sorties"), dr.Item("TYPE_ENTREES_SORTIES"), dr.Item("LIBELE_ENTREES_SORTIES"), dr.Item("QUANTITE_ENTREES_SORTIES"), dr.Item("MONTANT_ENTREES_SORTIES"))
                End While
                con.Dispose()
            ElseIf cb_annee.Text = "2017" Then
                Dim xe As String = "data source=xe;user id=system;password=firas123;"
                Dim con As New OracleConnection(xe)
                con.Open()
                Dim cmd As New OracleCommand
                cmd.Connection = con
                cmd.CommandText = "select * from JOURNAL where DATE_ENTREES_SORTIES>'31/12/2016' and DATE_ENTREES_SORTIES<'01/01/2018'"
                cmd.CommandType = CommandType.Text
                Dim dr As OracleDataReader = cmd.ExecuteReader()
                DataGridView1.Rows.Clear()
                DataGridView1.Visible = True
                If dr.Read() = False Then
                    MessageBox.Show("n'existe rien à afficher ", ":)")
                End If
                While dr.Read()
                    DataGridView1.Rows.Add(dr.Item("DATE_ENTREES_SORTIES"), dr.Item("nom_entrees_sorties"), dr.Item("TYPE_ENTREES_SORTIES"), dr.Item("LIBELE_ENTREES_SORTIES"), dr.Item("QUANTITE_ENTREES_SORTIES"), dr.Item("MONTANT_ENTREES_SORTIES"))
                End While
                con.Dispose()
            ElseIf cb_annee.Text = "tous les années" Then
                Dim xe As String = "data source=xe;user id=system;password=firas123;"
                Dim con As New OracleConnection(xe)
                con.Open()
                Dim cmd As New OracleCommand
                cmd.Connection = con
                cmd.CommandText = "select * from JOURNAL "
                cmd.CommandType = CommandType.Text
                Dim dr As OracleDataReader = cmd.ExecuteReader()
                DataGridView1.Rows.Clear()
                DataGridView1.Visible = True
                While dr.Read()
                    DataGridView1.Rows.Add(dr.Item("DATE_ENTREES_SORTIES"), dr.Item("nom_entrees_sorties"), dr.Item("TYPE_ENTREES_SORTIES"), dr.Item("LIBELE_ENTREES_SORTIES"), dr.Item("QUANTITE_ENTREES_SORTIES"), dr.Item("MONTANT_ENTREES_SORTIES"))
                End While
                con.Dispose()
            End If
        Else
            MessageBox.Show("il faut choisir un des choix ", "erreur")
        End If
    End Sub

    Private Sub bt_Afficher_Montant_Totale_Click(sender As Object, e As EventArgs) Handles bt_Afficher_Montant_Totale.Click
        If verif2() Then
            If cb_annee.Text = "2015" Then
                Dim xe As String = "data source=xe;user id=system;password=firas123;"
                Dim con As New OracleConnection(xe)
                con.Open()
                Dim cmd As New OracleCommand
                cmd.Connection = con
                cmd.CommandText = "select sum(MONTANT_ENTREES_SORTIES) from JOURNAL where DATE_ENTREES_SORTIES>'31/12/2014' and DATE_ENTREES_SORTIES<'01/01/2016'"
                cmd.CommandType = CommandType.Text
                Dim dr As OracleDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    tb_montant.Text = dr.Item("sum(MONTANT_ENTREES_SORTIES)")
                End If
            ElseIf cb_annee.Text = "2016" Then
                Dim xe As String = "data source=xe;user id=system;password=firas123;"
                Dim con As New OracleConnection(xe)
                con.Open()
                Dim cmd As New OracleCommand
                cmd.Connection = con
                cmd.CommandText = "select sum(MONTANT_ENTREES_SORTIES) from JOURNAL where DATE_ENTREES_SORTIES>'31/12/2015' and DATE_ENTREES_SORTIES<'01/01/2017'"
                cmd.CommandType = CommandType.Text
                Dim dr As OracleDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    tb_montant.Text = dr.Item("sum(MONTANT_ENTREES_SORTIES)")
                End If
            ElseIf cb_annee.Text = "2017" Then
                Dim xe As String = "data source=xe;user id=system;password=firas123;"
                Dim con As New OracleConnection(xe)
                con.Open()
                Dim cmd As New OracleCommand
                cmd.Connection = con
                cmd.CommandText = "select sum(MONTANT_ENTREES_SORTIES) from JOURNAL where DATE_ENTREES_SORTIES>'31/12/2016' and DATE_ENTREES_SORTIES<'01/01/2018'"
                cmd.CommandType = CommandType.Text
                Dim dr As OracleDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    tb_montant.Text = dr.Item("sum(MONTANT_ENTREES_SORTIES)")
                End If
            ElseIf cb_annee.Text = "tous les années" Then
                Dim xe As String = "data source=xe;user id=system;password=firas123;"
                Dim con As New OracleConnection(xe)
                con.Open()
                Dim cmd As New OracleCommand
                cmd.Connection = con
                cmd.CommandText = "select sum(MONTANT_ENTREES_SORTIES) from JOURNAL "
                cmd.CommandType = CommandType.Text
                Dim dr As OracleDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    tb_montant.Text = dr.Item("sum(MONTANT_ENTREES_SORTIES)")
                End If
            End If
        Else
            MessageBox.Show("il faut choisir un des choix ", "erreur")
        End If

    End Sub

    Private Sub Consulté_Journal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bt_Quitter_Click(sender As Object, e As EventArgs) Handles bt_Quitter.Click
        Me.Close()
        connexion.Close()
    End Sub
End Class