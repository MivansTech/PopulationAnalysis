Public Class frmIndividual

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboResidential.SelectedIndexChanged

    End Sub

    Private Sub lblClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblClose.LinkClicked
        Me.Close()

    End Sub

    Private Sub frmIndividual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PASDataSet.Individual' table. You can move, or remove it, as needed.
        Me.IndividualTableAdapter.Fill(Me.PASDataSet.Individual)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.IndividualBindingSource.RemoveCurrent()
        MessageBox.Show("Deleted Successful", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        On Error Resume Next
        Me.IndividualBindingSource.EndEdit()
        Me.IndividualTableAdapter.Update(Me.PASDataSet.Individual)
        MessageBox.Show("Updated Successful", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Validate()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        On Error Resume Next
        Me.IndividualBindingSource.EndEdit()
        Me.IndividualTableAdapter.Update(Me.PASDataSet.Individual)
        MessageBox.Show("Saved Successful", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Validate()
        Me.IndividualBindingSource.AddNew()
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

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim myfont As New Font("Arial Black", 20)
        e.Graphics.DrawString("Adamawa State Population Analysis System" & vbNewLine, New Font(myfont, FontStyle.Underline), Brushes.DarkGreen, 80, 70)
        Dim myfont2 As New Font("Lucida bright", 12)

        e.Graphics.DrawString("Surname:" & vbTab & txtSurname.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 120)
        e.Graphics.DrawString("First Name:" & vbTab & txtfname.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 140)
        e.Graphics.DrawString("Other Names:" & vbTab & txtSurname.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 160)
        e.Graphics.DrawString("Sex:" & vbTab & vbTab & cboSex.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 180)
        e.Graphics.DrawString("Date Of Birth:" & vbTab & dtpDOB.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 200)
        e.Graphics.DrawString("Address:" & vbTab & txtAddress.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 220)
        e.Graphics.DrawString("Email:" & vbTab & vbTab & txtEmail.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 240)
        e.Graphics.DrawString("Phone Number:" & vbTab & mtxtPhoneNumber.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 260)
        e.Graphics.DrawString("Nationality:" & vbTab & cboNationality.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 280)
        e.Graphics.DrawString("State of Birth:" & vbTab & cboStateOfBirth.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 300)
        e.Graphics.DrawString("L.G.A of Birth:" & vbTab & cboLGAbirth.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 320)
        e.Graphics.DrawString("Resident L.G.A:" & vbTab & cboResidential.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 340)
        e.Graphics.DrawString("Address:" & vbTab & txtAddress.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 360)
        e.Graphics.DrawString("Occupation:" & vbTab & cboOccupation.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 380)
        e.Graphics.DrawString("Disabled:" & vbTab & cboDisable.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 400)
      



        Dim xsingle, Ysingle As Single
        xsingle = e.MarginBounds.Left
        Ysingle = e.MarginBounds.Top
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        On Error Resume Next
        Me.IndividualBindingSource.Filter = "Individual_ID='" & txtSearch.Text & "'"
        If IndividualBindingSource.Count <> 0 Then
            With DataGridView1
                .Refresh()
                .DataSource = Me.IndividualBindingSource
                .MultiSelect = False
                .ClearSelection()

            End With
        Else
            Dim nommatch As String = txtSearch.Text
            MessageBox.Show("Oops! Sorry, No Match Found---->", "" & txtSearch.Text & "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            With DataGridView1
                .Refresh()
                .DataSource = Me.IndividualBindingSource
                .MultiSelect = True
                .ClearSelection()
                txtSearch.Text = Nothing
            End With
        End If
    End Sub
End Class