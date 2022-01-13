Public Class frmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
              If txtUsername.Text = Nothing Then
            MessageBox.Show("Username is required!", "Required Field", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            txtUsername.Clear()
            txtUsername.Focus()
            Exit Sub
        End If

        If txtUsername.Text <> "admin" Then
            MessageBox.Show("Invalid Username", "Required Valid Username", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            txtUsername.Focus()
            Exit Sub
        End If

        If txtPassword.Text = Nothing Then
            MessageBox.Show("Password is required!", "Required field", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtPassword.Focus()
            Exit Sub
        End If

        If txtPassword.Text <> "admin" Then
            MessageBox.Show("Invalid Password", "Required Valid Password", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtPassword.Focus()
            Exit Sub
        End If
        Me.Hide()

        frmIndex.Show()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
