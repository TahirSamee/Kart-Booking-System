Imports System.Data.OleDb

Public Class StaffDAL

    Public Shared Function GetAllStaff() As DataTable
        Dim dt As New DataTable()
        Dim sql = "SELECT StaffID, Username, FullName, Role, Phone, Email, IsArchived FROM Staff"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                Using da = New OleDbDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Shared Function AddStaff(username As String, passwordPlain As String, fullName As String, role As String, phone As String, email As String) As Integer
        Dim salt = SecurityHelper.GenerateSalt()
        Dim hash = SecurityHelper.HashPassword(passwordPlain, salt)

        Dim sql = "INSERT INTO Staff (Username, PasswordHash, Salt, FullName, Role, Phone, Email, IsArchived, CreatedAt, UpdatedAt) VALUES (?,?,?,?,?,?,?,?,?,?)"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.Add("@Username", OleDbType.VarChar, 100).Value = username
                cmd.Parameters.Add("@PasswordHash", OleDbType.VarChar, 200).Value = hash
                cmd.Parameters.Add("@Salt", OleDbType.VarChar, 200).Value = salt
                cmd.Parameters.Add("@FullName", OleDbType.VarChar, 150).Value = fullName
                cmd.Parameters.Add("@Role", OleDbType.VarChar, 50).Value = role
                cmd.Parameters.Add("@Phone", OleDbType.VarChar, 30).Value = phone
                cmd.Parameters.Add("@Email", OleDbType.VarChar, 100).Value = email
                cmd.Parameters.Add("@IsArchived", OleDbType.Boolean).Value = False
                cmd.Parameters.Add("@CreatedAt", OleDbType.Date).Value = DateTime.Now
                cmd.Parameters.Add("@UpdatedAt", OleDbType.Date).Value = DateTime.Now

                cn.Open()
                cmd.ExecuteNonQuery()
                cmd.CommandText = "SELECT @@IDENTITY"
                Return Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

    Public Shared Function GetStaffByUsername(username As String) As DataRow
        Dim dt As New DataTable()
        Dim sql = "SELECT * FROM Staff WHERE Username = ? AND IsArchived = 0"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.Add("@Username", OleDbType.VarChar, 100).Value = username
                Using da = New OleDbDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        If dt.Rows.Count > 0 Then Return dt.Rows(0)
        Return Nothing
    End Function

    Public Shared Function UpdateStaffPassword(staffId As Integer, newPassword As String) As Boolean
        Dim salt = SecurityHelper.GenerateSalt()
        Dim hash = SecurityHelper.HashPassword(newPassword, salt)

        Dim sql = "UPDATE Staff SET PasswordHash = ?, Salt = ?, UpdatedAt = ? WHERE StaffID = ?"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.Add("@PasswordHash", OleDbType.VarChar, 200).Value = hash
                cmd.Parameters.Add("@Salt", OleDbType.VarChar, 200).Value = salt
                cmd.Parameters.Add("@UpdatedAt", OleDbType.Date).Value = DateTime.Now
                cmd.Parameters.Add("@StaffID", OleDbType.Integer).Value = staffId

                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Shared Function ArchiveStaff(staffId As Integer) As Boolean
        Dim sql = "UPDATE Staff SET IsArchived = 1, UpdatedAt = ? WHERE StaffID = ?"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.Add("@UpdatedAt", OleDbType.Date).Value = DateTime.Now
                cmd.Parameters.Add("@StaffID", OleDbType.Integer).Value = staffId

                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

End Class
