Imports System.Data.OleDb

Public Class CustomersDAL
    Public Shared Function AddCustomer(firstName As String, lastName As String, dob As DateTime?, phone As String, email As String, address As String) As Integer
        Dim sql = "INSERT INTO Customers (FirstName, LastName, DOB, Phone, Email, Address, IsArchived, CreatedAt, UpdatedAt) VALUES (?,?,?,?,?,?,?,?,?)"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("@FirstName", firstName)
                cmd.Parameters.AddWithValue("@LastName", lastName)
                cmd.Parameters.AddWithValue("@DOB", If(dob.HasValue, CType(dob.Value, Object), DBNull.Value))
                cmd.Parameters.AddWithValue("@Phone", phone)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@Address", address)
                cmd.Parameters.AddWithValue("@IsArchived", False)
                cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now)
                cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now)


                cn.Open()
                cmd.ExecuteNonQuery()
                ' Retrieve last inserted id
                cmd.CommandText = "SELECT @@IDENTITY"
                Dim idObj = cmd.ExecuteScalar()
                Return Convert.ToInt32(idObj)
            End Using
        End Using
    End Function

    Public Shared Function UpdateCustomer(id As Integer, firstName As String, lastName As String, dob As DateTime?, phone As String, email As String, address As String) As Boolean
        Dim sql = "UPDATE Customers SET FirstName=?, LastName=?, DOB=?, Phone=?, Email=?, Address=?, UpdatedAt=? WHERE CustomerID=?"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("@FirstName", firstName)
                cmd.Parameters.AddWithValue("@LastName", lastName)
                cmd.Parameters.AddWithValue("@DOB", If(dob.HasValue, CType(dob.Value, Object), DBNull.Value))
                cmd.Parameters.AddWithValue("@Phone", phone)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@Address", address)
                cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now)
                cmd.Parameters.AddWithValue("@CustomerID", id)


                cn.Open()
                Dim affected = cmd.ExecuteNonQuery()
                Return affected > 0
            End Using
        End Using
    End Function


    Public Shared Function GetCustomerByID(id As Integer) As DataTable
        Dim dt = New DataTable()
        Dim sql = "SELECT * FROM Customers WHERE CustomerID = ?"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("@CustomerID", id)
                Using da = New OleDbDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function
    Public Shared Function SearchCustomersBySurname(surname As String) As DataTable
        Dim dt = New DataTable()
        Dim sql = "SELECT CustomerID, FirstName, LastName, Phone FROM Customers WHERE LastName LIKE ? AND IsArchived = 0"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("@LastName", surname & "%")
                Using da = New OleDbDataAdapter(cmd)
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
                cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now)
                cmd.Parameters.AddWithValue("@CustomerID", id)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function
    Public Shared Function GetBookingHistoryForCustomer(customerId As Integer) As DataTable
        Dim sql = "SELECT b.BookingID, b.StartDateTime, b.EndDateTime, b.Status, b.Attended FROM Bookings b WHERE b.CustomerID = ? ORDER BY b.StartDateTime DESC"
        Dim dt = New DataTable()
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("@CustomerID", customerId)
                Using da = New OleDbDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function


End Class