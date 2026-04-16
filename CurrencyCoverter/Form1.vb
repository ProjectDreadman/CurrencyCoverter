Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub optSingapore_CheckedChanged(sender As Object, e As EventArgs) Handles optSingapore.CheckedChanged
        If optSingapore.Checked = True Then
            picFlag.Image = My.Resources.singapore
        End If
    End Sub

    Function Singapore(ByVal USA As Decimal) As Decimal
        Dim Conversion As Decimal
        Conversion = USA * 1.29
        Return Conversion
    End Function

    Private Sub btnClac_Click(sender As Object, e As EventArgs) Handles btnClac.Click
        Dim USD As Decimal
        Dim FinalAmount As String

        'INPUT -->PROCESS -->OUTPUT
        USD = txtUSD.Text

        'PROCESS
        If optSingapore.Checked = True Then
            FinalAmount = "S$" & Singapore(USD)
        ElseIf optBrazil.Checked = True Then
            FinalAmount = "R$" & Brazil(USD)
        ElseIf optEuro.Checked = True Then
            FinalAmount = "€" & Euro(USD)
        ElseIf optIndia.Checked = True Then
            FinalAmount = "₹" & India(USD)
        ElseIf optAstraila.Checked = True Then
            FinalAmount = "A$" & Astraila(USD)
        ElseIf optMexico.Checked = True Then
            FinalAmount = "MXN$" & Mexico(USD)
        ElseIf optCanada.Checked = True Then
            FinalAmount = "C$" & Canada(USD)
        ElseIf optJapen.Checked = True Then
            FinalAmount = "¥" & Japen(USD)
        ElseIf optCuba.Checked = True Then
            FinalAmount = "₱" & Cuba(USD)
        ElseIf optRussia.Checked = True Then
            FinalAmount = "₽" & Russia(USD)
        End If

        'OUTPUT
        lblFinal.Text = FinalAmount
    End Sub

    Private Sub optBrazil_CheckedChanged(sender As Object, e As EventArgs) Handles optBrazil.CheckedChanged
        If optBrazil.Checked = True Then
            picFlag.Image = My.Resources.Brazil
        End If
    End Sub

    Function Brazil(ByVal usa As Decimal)
        Dim Conversion As Decimal
        Conversion = usa * 5.37
        Return Conversion
    End Function

    Private Sub optEuro_CheckedChanged(sender As Object, e As EventArgs) Handles optEuro.CheckedChanged
        If optEuro.Checked = True Then
            picFlag.Image = My.Resources.euro
        End If
    End Sub

    Function Euro(ByVal USA As Decimal)
        Dim Conversion As Decimal
        Conversion = USA * 0.86
        Return Conversion
    End Function

    Private Sub optIndia_CheckedChanged(sender As Object, e As EventArgs) Handles optIndia.CheckedChanged
        If optIndia.Checked = True Then
            picFlag.Image = My.Resources.india
        End If
    End Sub

    Function India(ByVal USA As Decimal)
        Dim Conversion As Decimal
        Conversion = USA * 90.14
        Return Conversion
    End Function

    Private Sub optAstraila_CheckedChanged(sender As Object, e As EventArgs) Handles optAstraila.CheckedChanged
        If optAstraila.Checked = True Then
            picFlag.Image = My.Resources.australia
        End If
    End Sub

    Function Astraila(ByVal USA As Decimal)
        Dim Conversion As Decimal
        Conversion = USA * 1.56
        Return Conversion
    End Function

    Private Sub optMexico_CheckedChanged(sender As Object, e As EventArgs) Handles optMexico.CheckedChanged
        If optMexico.Checked Then
            picFlag.Image = My.Resources.mexico
        End If
    End Sub

    Function Mexico(ByVal USA As Decimal)
        Dim Conversion As Decimal
        Conversion = USA * 18.0
        Return Conversion
    End Function

    Private Sub optCanada_CheckedChanged(sender As Object, e As EventArgs) Handles optCanada.CheckedChanged
        If optCanada.Checked = True Then
            picFlag.Image = My.Resources.canada
        End If
    End Sub

    Function Canada(ByVal USA As Decimal)
        Dim Conversion As Decimal
        Conversion = USA * 1.39
        Return Conversion
    End Function

    Private Sub optJapen_CheckedChanged(sender As Object, e As EventArgs) Handles optJapen.CheckedChanged
        If optJapen.Checked = True Then
            picFlag.Image = My.Resources.japan
        End If
    End Sub

    Function Japen(ByVal USA As Decimal)
        Dim Conversion As Decimal
        Conversion = USA * 157.61
        Return Conversion
    End Function

    Private Sub optCuba_CheckedChanged(sender As Object, e As EventArgs) Handles optCuba.CheckedChanged
        If optCuba.Checked = True Then
            picFlag.Image = My.Resources.cuba
        End If
    End Sub

    Function Cuba(ByVal USA As Decimal)
        Dim Conversion As Decimal
        Conversion = USA * 24.0
        Return Conversion
    End Function

    Private Sub optRussia_CheckedChanged(sender As Object, e As EventArgs) Handles optRussia.CheckedChanged
        If optRussia.Checked = True Then
            picFlag.Image = My.Resources.russia
        End If
    End Sub

    Function Russia(ByVal USA As Decimal)
        Dim Conversion As Decimal
        Conversion = USA * 79.25
        Return Conversion
    End Function
End Class
