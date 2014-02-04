Public Class Form2

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form4.Show()
    End Sub


    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.Size = New Size(200, 60)
        Button2.Size = New Size(180, 50)
        Button3.Size = New Size(180, 50)
        Button4.Size = New Size(180, 50)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Visible = False
        Form1.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button2.Size = New Size(200, 60)
        Button1.Size = New Size(180, 50)
        Button3.Size = New Size(180, 50)
        Button4.Size = New Size(180, 50)
    End Sub

    Private Sub Button3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseEnter
        Button3.Size = New Size(200, 60)
        Button2.Size = New Size(180, 50)
        Button1.Size = New Size(180, 50)
        Button4.Size = New Size(180, 50)
    End Sub

    Private Sub Button4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseEnter
        Button4.Size = New Size(200, 60)
        Button2.Size = New Size(180, 50)
        Button3.Size = New Size(180, 50)
        Button1.Size = New Size(180, 50)
    End Sub
End Class