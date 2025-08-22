Imports System.Data.OleDb

Public Class CustomersDAL

    Public Shared Function AddCustomer(firstName As String, lastName As String, dob As DateTime?, phone As String, email As String, address As String) As Integer
        Dim sql = "INSERT INTO Customers (FirstName, LastName, DOB, Phone, Email, Address, IsArchived, CreatedAt, UpdatedAt) 
                   VALUES (?,?,?,?,?,?,?,?,?)"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.Add("@FirstName", OleDbType.VarWChar, 100).Value = firstName
                cmd.Parameters.Add("@LastName", OleDbType.VarWChar, 100).Value = lastName
                cmd.Parameters.Add("@DOB", OleDbType.Date).Value = If(dob.HasValue, dob.Value, DBNull.Value)
                cmd.Parameters.Add("@Phone", OleDbType.VarWChar, 30).Value = phone
                cmd.Parameters.Add("@Email", OleDbType.VarWChar, 100).Value = email
                cmd.Parameters.Add("@Address", OleDbType.LongVarWChar).Value = address
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

    Public Shared Function UpdateCustomer(id As Integer, firstName As String, lastName As String, dob As DateTime?, phone As String, email As String, address As String) As Boolean
        Dim sql = "UPDATE Customers SET FirstName=?, LastName=?, DOB=?, Phone=?, Email=?, Address=?, UpdatedAt=? WHERE CustomerID=?"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.Add("@FirstName", OleDbType.VarWChar, 100).Value = firstName
                cmd.Parameters.Add("@LastName", OleDbType.VarWChar, 100).Value = lastName
                cmd.Parameters.Add("@DOB", OleDbType.Date).Value = If(dob.HasValue, dob.Value, DBNull.Value)
                cmd.Parameters.Add("@Phone", OleDbType.VarWChar, 30).Value = phone
                cmd.Parameters.Add("@Email", OleDbType.VarWChar, 100).Value = email
                cmd.Parameters.Add("@Address", OleDbType.LongVarWChar).Value = address
                cmd.Parameters.Add("@UpdatedAt", OleDbType.Date).Value = DateTime.Now
                cmd.Parameters.Add("@CustomerID", OleDbType.Integer).Value = id

                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Shared Function GetCustomerByID(id As Integer) As DataTable
        Dim dt As New DataTable()
        Dim sql = "SELECT * FROM Customers WHERE CustomerID = ?"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.Add("@CustomerID", OleDbType.Integer).Value = id
                Using da As New OleDbDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Shared Function SearchCustomersBySurname(surname As String) As DataTable
        Dim dt As New DataTable()
        Dim sql = "SELECT CustomerID, FirstName, LastName, Phone 
                   FROM Customers 
                   WHERE LastName LIKE ? AND IsArchived = 0"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.Add("@LastName", OleDbType.VarWChar, 100).Value = surname & "%"
                Using da As New OleDbDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Shared Function ArchiveCustomer(id As Integer) As Boolean
        Dim sql = "UPDATE Customers SET IsArchived = 1, UpdatedAt = ? WHERE CustomerID = ?"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.Add("@UpdatedAt", OleDbType.Date).Value = DateTime.Now
                cmd.Parameters.Add("@CustomerID", OleDbType.Integer).Value = id
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Shared Function GetBookingHistoryForCustomer(customerId As Integer) As DataTable
        Dim sql = "SELECT b.BookingID, b.StartDateTime, b.EndDateTime, b.Status, b.Attended 
                   FROM Bookings b 
                   WHERE b.CustomerID = ? 
                   ORDER BY b.StartDateTime DESC"
        Dim dt As New DataTable()
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.Add("@CustomerID", OleDbType.Integer).Value = customerId
                Using da As New OleDbDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

End Class
