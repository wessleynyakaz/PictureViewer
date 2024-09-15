Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ShowBtn_Click(sender As Object, e As EventArgs) Handles showBtn.Click
        'Show the Open File dialog. If the user clicks OK, load the
        'picture that the user chose.
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        PictureBox1.Image = Nothing
    End Sub

    Private Sub BgBtn_Click(sender As Object, e As EventArgs) Handles bgBtn.Click
        'Show the color dialog box. If the user clicks OK, change the
        'PictureBox control's background to the color the user chose.
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        'Close the form
        End
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'If the user selects the Stretch check box, change the PictureBox's SizeMode property to "Stretch". 
        If CheckBox1.Checked Then
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            'If the Then user clears the check box, change it to "Normal".
            PictureBox1.SizeMode = PictureBoxSizeMode.Normal
        End If

    End Sub
End Class
