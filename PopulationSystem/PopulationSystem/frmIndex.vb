Public Class frmIndex

    Private Sub frmIndex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tlsDateShow.Text = Date.Now.ToLongDateString
        tlsTimeShow.Text = Now.ToLongTimeString
    End Sub

    Private Sub btnDepartment_Click(sender As Object, e As EventArgs) Handles btnDepartment.Click
        pnlContent.Controls.Clear()
        Dim dept As New frmDepartment
        dept.Height = pnlContent.Height
        dept.Width = pnlContent.Width
        dept.Top = pnlContent.Top
        dept.TopLevel = False
        dept.Parent = pnlContent
        dept.Visible = True


    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        pnlContent.Controls.Clear()
        Dim staff As New frmStaff
        staff.Height = pnlContent.Height
        staff.Width = pnlContent.Width
        staff.Top = pnlContent.Top
        staff.TopLevel = False
        staff.Parent = pnlContent
        staff.Visible = True
    End Sub

    Private Sub btnLGA_Click(sender As Object, e As EventArgs) Handles btnLGA.Click
        pnlContent.Controls.Clear()
        Dim nlga As New frmLocalGovt
        nlga.Height = pnlContent.Height
        nlga.Width = pnlContent.Width
        nlga.Top = pnlContent.Top
        nlga.TopLevel = False
        nlga.Parent = pnlContent
        nlga.Visible = True
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        On Error Resume Next
        frmAboutBox.ShowDialog()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        frmLogin.ShowDialog()
    End Sub

    Private Sub btnIndividual_Click(sender As Object, e As EventArgs) Handles btnIndividual.Click
        pnlContent.Controls.Clear()
        Dim person As New frmIndividual
        person.Height = pnlContent.Height
        person.Width = pnlContent.Width
        person.Top = pnlContent.Top
        person.TopLevel = False
        person.Parent = pnlContent
        person.Visible = True
    End Sub
End Class
