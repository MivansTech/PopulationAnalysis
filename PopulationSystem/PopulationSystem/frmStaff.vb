Public Class frmStaff

    Private Sub lblClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim opf As New OpenFileDialog
        Dim filename As String
        filename = opf.FileName
        If (opf.ShowDialog) = Windows.Forms.DialogResult.OK Then
            opf.Filter = "images (*.jpg;*.png;*.bmp;*.jpeg)|*.jpg;*.png;*.bmp;*.jpeg;"
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If
       
    End Sub

    Private Sub frmStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PASDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.PASDataSet.Staff)
        Me.StaffBindingSource.AddNew()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.StaffBindingSource.RemoveCurrent()
        MessageBox.Show("Deleted Successful!", "Deleted", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        On Error Resume Next
        Me.StaffBindingSource.EndEdit()
        Me.StaffTableAdapter.Update(Me.PASDataSet.Staff)
        MessageBox.Show("Saved Successful", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Validate()
        Me.Staffbindingsource.AddNew()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        On Error Resume Next
        Me.StaffBindingSource.EndEdit()
        Me.StaffTableAdapter.Update(Me.PASDataSet.Staff)
        MessageBox.Show("Updated Successful", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Validate()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim myfont As New Font("Arial Black", 20)
        e.Graphics.DrawString("Adamawa State Population Analysis System" & vbNewLine, New Font(myfont, FontStyle.Underline), Brushes.DarkGreen, 70, 50)
        Dim myfont2 As New Font("Lucida bright", 12)
        e.Graphics.DrawString("Surname:" & vbTab & vbTab & txtSurname.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 100)
        e.Graphics.DrawString("First Name:" & vbTab & vbTab & txtFname.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 120)
        e.Graphics.DrawString("Other Names:" & vbTab & vbTab & txtSurname.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 140)
        e.Graphics.DrawString("Sex:" & vbTab & vbTab & vbTab & cboSex.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 160)
        e.Graphics.DrawString("Date Of Birth:" & vbTab & vbTab & dtpDOB.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 180)
        e.Graphics.DrawString("Address:" & vbTab & vbTab & txtAddress.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 200)
        e.Graphics.DrawString("Email:" & vbTab & vbTab & vbTab & txtEmail.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 220)
        e.Graphics.DrawString("Phone Number:" & vbTab & vbTab & mtxtPhoneNumber.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 240)
        e.Graphics.DrawString("Start Date:" & vbTab & vbTab & dtpStart.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 260)
        e.Graphics.DrawString("End Date:" & vbTab & vbTab & dtpEnd.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 280)
        e.Graphics.DrawString("Higher Qualification:" & vbTab & cboHighQualification.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 300)
        e.Graphics.DrawString("Result Obtained:" & vbTab & cboResultObtain.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 320)
        e.Graphics.DrawString("School Attended:" & vbTab & txtSchoolAttended.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 340)
        e.Graphics.DrawString("Date Obtained:" & vbTab & vbTab & dtpDateObtained.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 360)
        e.Graphics.DrawString("professional Qualification:" & txtProfessionalQualification.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 380)
        e.Graphics.DrawString("Other Qualification:" & vbTab & txtOtherqualification.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 400)






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

    Private Sub dtpEnd_ValueChanged(sender As Object, e As EventArgs) Handles dtpEnd.ValueChanged

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        On Error Resume Next
        Me.StaffBindingSource.Filter = "ID='" & txtSearch.Text & "'"
        If StaffBindingSource.Count <> 0 Then
            With DataGridView1

                .DataSource = Me.StaffBindingSource
                .MultiSelect = False
                .ClearSelection()
                .Refresh()

            End With
        Else
            Dim nommatch As String = txtSearch.Text
            MessageBox.Show("Oops! Sorry, No Match Found---->", "" & txtSearch.Text & "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            Me.StaffBindingSource.Filter = Nothing
            With DataGridView1
                .Refresh()
                .DataSource = Me.StaffBindingSource
                .MultiSelect = False
                .ClearSelection()

            End With
            txtSearch.Text = Nothing
        End If
    End Sub

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
       
    End Sub

 

   

   
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class