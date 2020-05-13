Imports System.Data.SqlClient
Public Class login
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub But_Login_Click(sender As Object, e As EventArgs) Handles But_Login.Click
        If TxtBrugernavn.Text = My.Settings.LærerBruger And TxtPassword.Text = My.Settings.LærerPass Then
            Call Gary()
        ElseIf TxtBrugernavn.Text = My.Settings.ElevBruger And TxtPassword.Text = My.Settings.ElevPass Then
            Call cto69h3()
        ElseIf TxtBrugernavn.Text = "" And TxtPassword.Text = "" Then
            MsgBox("Udfyld venligst alle felterne korrekt")
            TxtBrugernavn.Focus()
        ElseIf TxtBrugernavn.Text <> My.Settings.LærerBruger And TxtPassword.Text = My.Settings.ElevBruger Then
            MsgBox("Username er ikke korrekt")
            TxtBrugernavn.Focus()
            Return
        Else
            MsgBox("Password er ikke korrekt")
        End If
    End Sub 'Hvis koden du skriver i teksfeltet ikke er korrekt, så kan du ikke få lov til at ændre spørgmålene'
    Private Sub Admin()
        Forside.Show()
        Me.Hide()

        Forside.Text = "Lærer"
    End Sub
    Private Sub User()
        Forside.Show()
        Me.Hide()
    End Sub
End Class
