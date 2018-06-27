Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types
Imports System.Windows.Forms.DataVisualization.Charting




Public Class Statistique_Departement
    Private Sub Statistique_Departement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim xe As String = "data source=xe;user id=system;password=firas123;"
        Dim con As New OracleConnection(xe)
        con.Open()


        Dim parm_OUT As New OracleParameter
        parm_OUT.Direction = ParameterDirection.ReturnValue
        parm_OUT.OracleDbType = OracleDbType.Decimal
        Dim parm_IN As New OracleParameter
        parm_IN.OracleDbType = OracleDbType.Varchar2
        parm_IN.Value = "d1"
        parm_IN.Direction = ParameterDirection.Input
        Dim cmd As New OracleCommand("gestion_club.moyenne", con)
        cmd.Connection = con
        cmd.Parameters.Add(parm_OUT)
        cmd.Parameters.Add(parm_IN)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.ExecuteNonQuery()
        Dim ch As String = cmd.Parameters(0).Value.ToString
        Dim v_dep_evenmentiel As Double = Convert.ToDouble(ch)



        con.Dispose()


        Dim con2 As New OracleConnection(xe)
        con2.Open()

        Dim parm_OUT1 As New OracleParameter
        parm_OUT1.Direction = ParameterDirection.ReturnValue
        parm_OUT1.OracleDbType = OracleDbType.Decimal
        Dim parm_IN1 As New OracleParameter
        parm_IN1.OracleDbType = OracleDbType.Varchar2
        parm_IN1.Value = "d2"
        parm_IN1.Direction = ParameterDirection.Input
        Dim cmd1 As New OracleCommand("gestion_club.moyenne", con2)
        cmd1.Connection = con2
        cmd1.Parameters.Add(parm_OUT1)
        cmd1.Parameters.Add(parm_IN1)
        cmd1.CommandType = CommandType.StoredProcedure
        cmd1.ExecuteNonQuery()
        Dim ch1 As String = cmd1.Parameters(0).Value.ToString
        Dim v_dep_communication As Double = Convert.ToDouble(ch1)


        con2.Dispose()

        Dim con3 As New OracleConnection(xe)
        con3.Open()

        Dim parm_OUT2 As New OracleParameter
        parm_OUT2.Direction = ParameterDirection.ReturnValue
        parm_OUT2.OracleDbType = OracleDbType.Decimal
        Dim parm_IN2 As New OracleParameter
        parm_IN2.OracleDbType = OracleDbType.Varchar2
        parm_IN2.Value = "d3"
        parm_IN2.Direction = ParameterDirection.Input
        Dim cmd2 As New OracleCommand("gestion_club.moyenne", con3)
        cmd2.Connection = con3
        cmd2.Parameters.Add(parm_OUT2)
        cmd2.Parameters.Add(parm_IN2)
        cmd2.CommandType = CommandType.StoredProcedure
        cmd2.ExecuteNonQuery()
        Dim ch2 As String = cmd2.Parameters(0).Value.ToString
        Dim v_dep_sponsoring As Double = Convert.ToDouble(ch2)





        con3.Dispose()



        '*******************************************************************************************************************************************************************************







        ' Creation d'un Chart Area
        Dim chartArea1 As New ChartArea()

            ' Ajout ChartArea au Chart
            Chart1.ChartAreas.Add(chartArea1)

        'Ajout d'une Series nommée "Equipe2"
        Chart1.Series.Add("Departement")
        Chart1.Series("Departement").Points.AddXY("Evenmentiel", v_dep_evenmentiel)
        Chart1.Series("Departement").Points.AddXY("Communication", v_dep_communication)
        Chart1.Series("Departement").Points.AddXY("Sponsoring", v_dep_sponsoring)

        Chart1.Series("Departement").Points(0).ToolTip = "#VALX : #VALY"
        Chart1.Series("Departement").Points(1).ToolTip = "#VALX : #VALY"
        Chart1.Series("Departement").Points(2).ToolTip = "#VALX : #VALY"



        'partie des axe
        'titre des ordooné et titre des abscisse
        Chart1.ChartAreas(0).AxisX.Title = "Nom de departement"
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
        Chart1.Titles(0).Text = "Graphique affichant la productivité de chaque departement de club"

        ' font, taille.. du titre
        Chart1.Titles(0).Font = New Font("Arial", 20, FontStyle.Bold)

            ' Position du texte dans le rectangle
            Chart1.Titles(0).Alignment = System.Drawing.ContentAlignment.MiddleCenter

            '***************************LEGEND******************************************
            Dim legend1 As New Legend
        'Titre du rectangle des légendes.
        legend1.Title = "productivité de departement"
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
        Chart1.Series("Departement").ChartArea = "ChartArea1"



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