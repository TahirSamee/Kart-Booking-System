Imports System.Data.OleDb

Public Class BookingsDAL

    Public Shared Function AddBooking(customerId As Integer, staffId As Integer, startDt As DateTime, endDt As DateTime, status As String, notes As String) As Integer
        Dim sql = "INSERT INTO Bookings (CustomerID, CreatedByStaffID, StartDateTime, EndDateTime, Status, Attended, Notes, CreatedAt, UpdatedAt) 
                   VALUES (?,?,?,?,?,?,?,?,?)"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.Add("@CustomerID", OleDbType.Integer).Value = customerId
                cmd.Parameters.Add("@CreatedByStaffID", OleDbType.Integer).Value = staffId
                cmd.Parameters.Add("@StartDateTime", OleDbType.Date).Value = startDt
                cmd.Parameters.Add("@EndDateTime", OleDbType.Date).Value = endDt
                cmd.Parameters.Add("@Status", OleDbType.VarWChar, 50).Value = status
                cmd.Parameters.Add("@Attended", OleDbType.Boolean).Value = False
                cmd.Parameters.Add("@Notes", OleDbType.LongVarWChar).Value = notes
                cmd.Parameters.Add("@CreatedAt", OleDbType.Date).Value = DateTime.Now
                cmd.Parameters.Add("@UpdatedAt", OleDbType.Date).Value = DateTime.Now

                cn.Open()
                cmd.ExecuteNonQuery()
                cmd.CommandText = "SELECT @@IDENTITY"
                Return Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

    Public Shared Function GetBookingsByRange(startDate As DateTime, endDate As DateTime) As DataTable
        Dim dt As New DataTable()
        Dim sql = "SELECT BookingID, CustomerID, CreatedByStaffID, StartDateTime, EndDateTime, Status, Attended 
                   FROM Bookings 
                   WHERE StartDateTime >= ? AND StartDateTime < ? 
                   ORDER BY StartDateTime"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.Add("@StartDateTime", OleDbType.Date).Value = startDate
                cmd.Parameters.Add("@EndDateTime", OleDbType.Date).Value = endDate
                Using da = New OleDbDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Shared Function MarkAttended(bookingId As Integer, attended As Boolean) As Boolean
        Dim sql = "UPDATE Bookings SET Attended = ?, UpdatedAt = ? WHERE BookingID = ?"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.Add("@Attended", OleDbType.Boolean).Value = attended
                cmd.Parameters.Add("@UpdatedAt", OleDbType.Date).Value = DateTime.Now
                cmd.Parameters.Add("@BookingID", OleDbType.Integer).Value = bookingId

                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Shared Function GetBookingByID(bookingId As Integer) As DataRow
        Dim dt As New DataTable()
        Dim sql = "SELECT * FROM Bookings WHERE BookingID = ?"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.Add("@BookingID", OleDbType.Integer).Value = bookingId
                Using da = New OleDbDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        If dt.Rows.Count > 0 Then Return dt.Rows(0)
        Return Nothing
    End Function

End Class
