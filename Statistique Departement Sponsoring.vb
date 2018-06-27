Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types
Imports System.Windows.Forms.DataVisualization.Charting



Public Class Statistique_Departement_Sponsoring
    Private Sub Statistique_Departement_Sponsoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.Rows.Clear()

        Dim xe As String = "data source=xe;user id=system;password=firas123;"
        Dim con As New OracleConnection(xe)
        con.Open()

        Dim cmd As New OracleCommand
        cmd.Connection = con
        cmd.CommandText = "select MEMBRE.NOM_MEMBRE,MEMBRE.PRENOM_MEMBRE,tache_note from MEMBRE,PARTICIPE_MEMBRE where MEMBRE.NCIN_MEMBRE=PARTICIPE_MEMBRE.NCIN_MEMBRE and MEMBRE.ID_DEPARTEMENT='d3'"
        cmd.CommandType = CommandType.Text

        Dim dr As OracleDataReader = cmd.ExecuteReader()
        While dr.Read()
            DataGridView1.Rows.Add(dr.Item("NOM_MEMBRE"), dr.Item("PRENOM_MEMBRE"), dr.Item("tache_note"))

        End While
        con.Dispose()

        ' Creation d'un Chart Area
        Dim chartArea1 As New ChartArea()

        ' Ajout ChartArea au Chart
        Chart1.ChartAreas.Add(chartArea1)

        'Ajout d'une Series nommée "Equipe2"
        Chart1.Series.Add("Membre")


        Dim nom As String
        Dim k As Integer
        Dim j As Decimal
        Dim i As Integer
        Dim s As Integer = 0

        While DataGridView1.RowCount <> 1
            nom = DataGridView1.Item(0, 0).Value + " " + DataGridView1.Item(1, 0).Value
            j = DataGridView1.Item(2, 0).Value
            k = 1
            i = 1
            While i < (DataGridView1.RowCount - 1)
                If DataGridView1.Item(0, 0).Value = DataGridView1.Item(0, i).Value And DataGridView1.Item(1, 0).Value = DataGridView1.Item(1, i).Value Then
                    j = j + DataGridView1.Item(2, i).Value
                    k = k + 1
                    DataGridView1.Rows.RemoveAt(i)

                Else
                    i = i + 1
                End If
            End While
            DataGridView1.Rows.RemoveAt(0)
            Chart1.Series("Membre").Points.AddXY(nom, (j / k))
            s = s + 1

        End While


        Dim h As Integer
        For h = 0 To (s - 1)
            Chart1.Series("Membre").Points(h).ToolTip = "#VALX : #VALY"
        Next

        'partie des axe
        'titre des ordooné et titre des abscisse
        Chart1.ChartAreas(0).AxisX.Title = "Nom de Membre"
        Chart1.ChartAreas(0).AxisY.Title = "productivité"

        ' Couleur de l'axe
        Chart1.ChartAreas(0).AxisY.LineColor = Color.Red
        Chart1.ChartAreas(0).AxisX.LineColor = Color.Red
        '  Arrow Style
        Chart1.ChartAreas(0).AxisY.ArrowStyle = AxisArrowStyle.Lines
        Chart1.ChartAreas(0).AxisX.ArrowStyle = AxisArrowStyle.Lines

        ' On peut indiquer, et ainsi forcer, la plage des valeurs de l'axe.
        Chart1.ChartAreas(0).AxisY.Minimum = 0
        Chart1.ChartAreas(0).AxisY.Maximum = 10


        'Couleur de la grille principale
        Chart1.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.LightSkyBlue
        Chart1.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.Green

        'Chart1.Series(0).Label = "#VALY" 'ou "#VALX"
        '******************************DESIGN*********************************************
        '' Set Border Skin
        Chart1.BorderSkin.SkinStyle = BorderSkinStyle.FrameThin1

        '' Set Back Color
        Chart1.BorderSkin.BackColor = Color.LightGreen

        ' Back Color est la couleur autour de chaque ChartArea
        Chart1.BackColor = Color.LightGreen

        ' Seconde couleur (pour le dégradé)
        Chart1.BackSecondaryColor = Color.LightBlue

        ' Met un  Gradient sur le couleur du fond
        Chart1.BackGradientStyle = GradientStyle.DiagonalRight

        ' Couleur du bord du chart
        Chart1.BorderColor = Color.Black

        ' Back Color est la couleur de fond du ChartArea
        Chart1.ChartAreas("ChartArea1").BackColor = Color.LightSkyBlue

        ' Seconde couleur (pour le dégradé)
        Chart1.ChartAreas("ChartArea1").BackSecondaryColor = Color.White

        ' On pourrait mettre un motif, on ne le fait pas
        ' Chart1.ChartAreas("ChartArea1").BackHatchStyle = ChartHatchStyle.DashedHorizontal

        ' Met un  Gradient sur le couleur du fond
        Chart1.ChartAreas("ChartArea1").BackGradientStyle = GradientStyle.TopBottom

        'hedhy bech ibalew ls batton cylindrique
        Dim series As Series
        For Each series In Chart1.Series
            series.CustomProperties = "DrawingStyle=cylinder"
        Next

        '******************************TITRE***********************************
        'Création d'un titre qu'on ajoute à la collection Titles du Chart:
        Chart1.Titles.Add("Titre1")

        ' Texte  du titre
        Chart1.Titles(0).Text = "Graphique affichant la productivité de chaque membre de departement sponsoring"

        ' font, taille.. du titre
        Chart1.Titles(0).Font = New Font("Arial", 20, FontStyle.Bold)

        ' Position du texte dans le rectangle
        Chart1.Titles(0).Alignment = System.Drawing.ContentAlignment.MiddleCenter

        '***************************LEGEND******************************************
        Dim legend1 As New Legend
        'Titre du rectangle des légendes.
        legend1.Title = "productivité des Membres"
        legend1.LegendStyle = LegendStyle.Row
        'On l'ajoute à la collection Legends n du Chart
        Chart1.Legends.Add(legend1)

        ' On modifie l'aspect du rectangle
        Chart1.Legends(0).BackColor = Color.LightBlue


        Chart1.Legends(0).BorderColor = Color.LightGreen
        Chart1.Legends(0).BorderWidth = 2



        '**************************e5er 7aja****************************************
        'hedhy el partie le5raneya wine bech tsaker el program sayer
        'On indique d'afficher cette Series sur le ChartArea1
        Chart1.Series("Membre").ChartArea = "ChartArea1"



        ' On ajoute le Chart à la form
        Me.Controls.Add(Chart1)





    End Sub


    Private Sub bt_retour_Click(sender As Object, e As EventArgs) Handles bt_retour.Click
        Productivité.Show()
        Me.Close()

    End Sub

    Private Sub bt_Quitter_Click(sender As Object, e As EventArgs) Handles bt_Quitter.Click
        Me.Close()
        connexion.Close()

    End Sub


End Class