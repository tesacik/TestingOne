Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Debug.WriteLine("PPP OOO")
        Debug.WriteLine("PPP OOO PPP")
        Debug.WriteLine("Other line added")
        Debug.WriteLine("Next line added")

        For i As Long = 1 To 20
            Debug.WriteLine(i)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i As Long = 1 To 30 ' changed to 30
            Debug.WriteLine(i)
        Next
    End Sub


    'Changes on Github directly
    'Bla bla
    'more Bla bla
End Class
