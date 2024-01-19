Imports ONLINE_DRESS_STRORE.ONLINE

Public Class DRESS
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        prod_id = "01"
        prod_name = "RED SATINO DRESS"
        prod_price = "200"

        Me.Hide()
        confirmoder.Show()


    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub DRESS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        prod_id = "02"
        prod_name = "BLUE FLORAL DRESS"
        prod_price = "400"

        Me.Hide()
        confirmoder.Show()
    End Sub
End Class