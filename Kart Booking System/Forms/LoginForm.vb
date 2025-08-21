Imports System.Data.OleDb

Public Class LoginForm
    Public Sub New()
        InitializeComponent()
    End Sub
    Sub EnsureAdminExists()
        Dim dt = StaffDAL.GetAllStaff() ' implement to return DataTable
        If dt.Rows.Count = 0 Then
            ' Dim salt = SecurityHelper.GenerateSalt()
            Dim pwd = "admin123" ' change after first login
            ' Dim hash = SecurityHelper.HashPassword(pwd, salt)
            StaffDAL.AddStaff("admin", pwd, "Administrator", "Admin", "", "admin@example.com")
            MessageBox.Show("Default admin created. Username: admin Password: admin123 (change after login)")
        End If
    End Sub
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        EnsureAdminExists()
        Dim err As String = ""
        If Not DBHelper.TestConnection(err) Then
            MessageBox.Show("Database connection failed: " & err, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
            Return
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Provide username and password.")
            Return
        End If

        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand("SELECT StaffID, Username, PasswordHash, Salt, FullName, Role FROM Staff WHERE Username = ? AND IsArchived = 0", cn)
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
                cn.Open()
                Using rdr = cmd.ExecuteReader()
                    If rdr.Read() Then
                        Dim storedHash = If(rdr("PasswordHash") Is DBNull.Value, "", Convert.ToString(rdr("PasswordHash")))
                        Dim salt = If(rdr("Salt") Is DBNull.Value, "", Convert.ToString(rdr("Salt")))
                        Dim computed = SecurityHelper.HashPassword(txtPassword.Text.Trim(), salt)
                        If storedHash = computed Then
                            ' Success
                            Dim staffId = Convert.ToInt32(rdr("StaffID"))
                            Dim fullName = Convert.ToString(rdr("FullName"))
                            Dim role = Convert.ToString(rdr("Role"))
                            Me.Hide()
                            Dim main = New MainForm(staffId, fullName, role)
                            main.Show()
                            Return
                        End If
                    End If
                End Using
            End Using
        End Using

        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        txtPassword.Clear()
        txtPassword.Focus()
    End Sub

End Class