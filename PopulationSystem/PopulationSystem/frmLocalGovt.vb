Public Class frmLocalGovt

    Private Sub lblClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub frmLocalGovt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PASDataSet.LGA' table. You can move, or remove it, as needed.
        Me.LGATableAdapter.Fill(Me.PASDataSet.LGA)

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        On Error Resume Next
        Me.LGABindingSource.EndEdit()
        Me.LGATableAdapter.Update(Me.PASDataSet.LGA)
        MessageBox.Show("Saved Successful", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Validate()
        Me.LGABindingSource.AddNew()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        On Error Resume Next
        Me.LGABindingSource.EndEdit()
        Me.LGATableAdapter.Update(Me.PASDataSet.LGA)
        MessageBox.Show("Updated Successful", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Validate()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.LGABindingSource.RemoveCurrent()
        MessageBox.Show("Deleted Successful!", "Deleted", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim myfont As New Font("Arial Black", 20)
        e.Graphics.DrawString("Adamawa State Population Analysis System" & vbNewLine, New Font(myfont, FontStyle.Underline), Brushes.DarkGreen, 50, 50)
        Dim myfont2 As New Font("Lucida bright", 12)
        e.Graphics.DrawString("L.G.A Name:" & vbTab & txtLGAName.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 100)
        e.Graphics.DrawString("Zone:" & vbTab & txtzone.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 120)
        e.Graphics.DrawString("State:" & vbTab & cboState.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 140)
        e.Graphics.DrawString("Date of Registration:" & vbTab & dtpDateRegistered.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 160)


        Dim xsingle, Ysingle As Single
        xsingle = e.MarginBounds.Left
        Ysingle = e.MarginBounds.Top
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDialog1.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        On Error Resume Next
        Me.LGABindingSource.Filter = "LGA_Name='" & txtSearch.Text & "'"
        If LGABindingSource.Count <> 0 Then
            With DataGridView1
                .Refresh()
                .DataSource = Me.LGABindingSource
                .MultiSelect = False
                .ClearSelection()

            End With
        Else
            Dim nommatch As String = txtSearch.Text
            MessageBox.Show("Oops! Sorry, No Match Found---->", "" & txtSearch.Text & "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            With DataGridView1
                .Refresh()
                .DataSource = Me.LGABindingSource
                .MultiSelect = True
                .ClearSelection()
                txtSearch.Text = Nothing
            End With
        End If
    End Sub
End Class