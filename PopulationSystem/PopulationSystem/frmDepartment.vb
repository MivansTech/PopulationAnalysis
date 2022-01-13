Public Class frmDepartment

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblDepartmentName.Click

    End Sub

    Private Sub lblClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub frmDepartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PASDataSet.Department' table. You can move, or remove it, as needed.
        Me.DepartmentTableAdapter.Fill(Me.PASDataSet.Department)
        Me.DepartmentBindingSource.AddNew()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.DepartmentBindingSource.RemoveCurrent()
        MessageBox.Show("Deleted Successful!", "Deleted", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        On Error Resume Next
        Me.DepartmentBindingSource.EndEdit()
        Me.DepartmentTableAdapter.Update(Me.PASDataSet.Department)
        MessageBox.Show("Saved Successful", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Validate()
        Me.DepartmentBindingSource.AddNew()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        On Error Resume Next
        Me.DepartmentBindingSource.EndEdit()
        Me.DepartmentTableAdapter.Update(Me.PASDataSet.Department)
        MessageBox.Show("Updated Successful", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Validate()
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
        e.Graphics.DrawString("Adamawa State Population Analysis System" & vbNewLine, New Font(myfont, FontStyle.Underline), Brushes.DarkGreen, 50, 50)
        Dim myfont2 As New Font("Lucida bright", 12)
        e.Graphics.DrawString("Department Name:" & vbTab & txtDeptName.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 100)
        e.Graphics.DrawString("Head of Department:" & vbTab & txtHOD.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 120)
        e.Graphics.DrawString("No. of Staff:" & vbTab & vbTab & txtNoStaff.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 140)
        e.Graphics.DrawString("Date of Registration:" & vbTab & dtpDateRegistered.Text & vbNewLine, New Font(myfont2, FontStyle.Bold), Brushes.Black, 50, 160)


        Dim xsingle, Ysingle As Single
        xsingle = e.MarginBounds.Left
        Ysingle = e.MarginBounds.Top
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        On Error Resume Next
        Me.DepartmentBindingSource.Filter = "Dept_Name='" & txtSearch.Text & "'"
        If DepartmentBindingSource.Count <> 0 Then
            With DataGridView1
                .Refresh()
                .DataSource = Me.DepartmentBindingSource
                .MultiSelect = False
                .ClearSelection()

            End With
        Else
            Dim nommatch As String = txtSearch.Text
            MessageBox.Show("Oops! Sorry, No Match Found---->", "" & txtSearch.Text & "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            With DataGridView1
                .Refresh()
                .DataSource = Me.DepartmentBindingSource
                .MultiSelect = True
                .ClearSelection()
                txtSearch.Text = Nothing
            End With
        End If
    End Sub
End Class