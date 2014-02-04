Imports System.Data.OleDb
Imports System.IO
Public Class Form1
    Dim num As Integer = 0
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Cn As OleDbConnection
        Cn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Directory.GetCurrentDirectory & "\data.mdb;")

        Dim rs As OleDbDataReader
        Dim rs1 As OleDbDataReader
        Dim Cmm As OleDbCommand
        Dim c As Integer = 0

        Dim ran As Random = New Random
        num = ran.Next(1, 22)

        Cn.Open()


        Cmm = New OleDbCommand("select * from question_master where q_id=" & num, Cn)
        rs = Cmm.ExecuteReader

        While rs.Read
            Label1.Text = rs(1).ToString
        End While

        Cmm = New OleDbCommand("select * from answer_master where a_q_id=" & num, Cn)
        rs1 = Cmm.ExecuteReader

        While (rs1.Read) = True
            c = c + 1
            If c = 1 Then
                RadioButton1.Text = rs1(2).ToString
            End If
            If c = 2 Then
                RadioButton2.Text = rs1(2).ToString
            End If
            If c = 3 Then
                RadioButton3.Text = rs1(2).ToString
            End If
            If c = 4 Then
                RadioButton4.Text = rs1(2).ToString
            End If

        End While


        rs.Close()
        rs1.Close()
        Cn.Close()
        Cmm.Dispose()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Cn As OleDbConnection
        Dim asel As String = 0
        Cn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Directory.GetCurrentDirectory & "\data.mdb;")
        Dim rs As OleDbDataReader
        Dim Cmm As OleDbCommand
        Cn.Open()

        If RadioButton1.Checked = True Then
            asel = RadioButton1.Text
        ElseIf RadioButton2.Checked = True Then
            asel = RadioButton2.Text
        ElseIf RadioButton3.Checked = True Then
            asel = RadioButton3.Text
        ElseIf RadioButton4.Checked = True Then
            asel = RadioButton4.Text
        End If

        Cmm = New OleDbCommand("select * from answer_master where a_q_id=" & num & "AND a_text='" & asel & "'", Cn)
        rs = Cmm.ExecuteReader
        While (rs.Read) = True
            If rs(3) = 1 Then
                MsgBox("Right Answer")
                Form1_Load(sender, e)
            Else


                MsgBox("Wrong Answer")
                If ProgressBar1.Value > 20 Then
                    ProgressBar1.Value -= 20
                Else
                    ProgressBar1.Value -= 20
                    MsgBox("GAME-OVER")
                    Form2.Close()
                End If
            End If
        End While
        rs.Close()
        Cn.Close()
        Cmm.Dispose()
    End Sub

    Private Sub Button4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseEnter
        Button2.Text = "Quit"
        Button4.Text = "Sucide"
    End Sub


    Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button4.Text = "Quit"
        Button2.Text = "Sucide"
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
        Form2.Close()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Form5.Show()
    End Sub

   
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
        Form5.Show()
    End Sub
End Class
