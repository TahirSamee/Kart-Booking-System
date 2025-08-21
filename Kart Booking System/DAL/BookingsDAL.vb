Imports System.Data.OleDb

Public Class BookingsDAL

    Public Shared Function AddBooking(customerId As Integer, staffId As Integer, startDt As DateTime, endDt As DateTime, status As String, notes As String) As Integer
        Dim sql = "INSERT INTO Bookings (CustomerID, CreatedByStaffID, StartDateTime, EndDateTime, Status, Attended, Notes, CreatedAt, UpdatedAt) VALUES (?,?,?,?,?,?,?,?,?)"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("@CustomerID", customerId)
                cmd.Parameters.AddWithValue("@CreatedByStaffID", staffId)
                cmd.Parameters.AddWithValue("@StartDateTime", startDt)
                cmd.Parameters.AddWithValue("@EndDateTime", endDt)
                cmd.Parameters.AddWithValue("@Status", status)
                cmd.Parameters.AddWithValue("@Attended", False)
                cmd.Parameters.AddWithValue("@Notes", notes)
                cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now)
                cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now)
                cn.Open()
                cmd.ExecuteNonQuery()
                cmd.CommandText = "SELECT @@IDENTITY"
                Return Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

    Public Shared Function GetBookingsByRange(startDate As DateTime, endDate As DateTime) As DataTable
        Dim dt As New DataTable()
        Dim sql = "SELECT BookingID, CustomerID, CreatedByStaffID, StartDateTime, EndDateTime, Status, Attended FROM Bookings WHERE StartDateTime >= ? AND StartDateTime < ? ORDER BY StartDateTime"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("@StartDateTime", startDate)
                cmd.Parameters.AddWithValue("@EndDateTime", endDate)
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
                cmd.Parameters.AddWithValue("@Attended", attended)
                cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now)
                cmd.Parameters.AddWithValue("@BookingID", bookingId)
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
                cmd.Parameters.AddWithValue("@BookingID", bookingId)
                Using da = New OleDbDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        If dt.Rows.Count > 0 Then Return dt.Rows(0)
        Return Nothing
    End Function

End Class
