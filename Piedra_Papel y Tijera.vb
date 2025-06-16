Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usuario As Integer = 0
        Dim sistema As Integer = 0
        Dim Rnd As New Random()

    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged

        If RadioButton1.Checked Then
            TextBox1.Text = "✊"
        ElseIf RadioButton2.Checked Then
            TextBox1.Text = "🖐️"
        ElseIf RadioButton3.Checked Then
            TextBox1.Text = "✌️"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Rnd As New Random()
        Dim sistema As Integer = Rnd.Next(1, 4)

        Select Case sistema
            Case 1
                TextBox2.Text = "✊"
            Case 2
                TextBox2.Text = "🖐️"
            Case 3
                TextBox2.Text = "✌️"
        End Select

        Dim resultado As String = ""
        If TextBox1.Text = TextBox2.Text Then
            resultado = "Empatamos"
        ElseIf (TextBox1.Text = "✊" And TextBox2.Text = "✌️") Or
               (TextBox1.Text = "🖐️" And TextBox2.Text = "✊") Or
               (TextBox1.Text = "✌️" And TextBox2.Text = "🖐️") Then
            resultado = "Ganaste, Felicidades"
        Else
            resultado = "Perdiste"
        End If

        MessageBox.Show(resultado, "Resultado")
    End Sub

End Class

