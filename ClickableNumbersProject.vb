﻿Public Class ClickableNumbers
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub picOne_Click(sender As Object, e As EventArgs) Handles picOne.Click
        lblNumber.Text = "One"
    End Sub

    Private Sub picTwo_Click(sender As Object, e As EventArgs) Handles picTwo.Click
        lblNumber.Text = "Two"
    End Sub

    Private Sub picThree_Click(sender As Object, e As EventArgs) Handles picThree.Click
        lblNumber.Text = "Three"
    End Sub

    Private Sub PicFour_Click(sender As Object, e As EventArgs) Handles picFour.Click
        lblNumber.Text = "Four"
    End Sub

    Private Sub PicFive_Click(sender As Object, e As EventArgs) Handles picFive.Click
        lblNumber.Text = "Five"
    End Sub
End Class
