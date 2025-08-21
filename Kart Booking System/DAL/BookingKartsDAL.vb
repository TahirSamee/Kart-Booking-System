Imports System.Data.OleDb

Public Class BookingKartsDAL
    Public Shared Function GetKartsByBooking(bookingID As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As OleDbConnection = DBHelper.GetConnection()
                conn.Open()
                Dim query As String = "SELECT BK.KartID, K.KartNumber 
                                   FROM BookingKarts BK 
                                   INNER JOIN Karts K ON BK.KartID = K.KartID
                                   WHERE BK.BookingID=@BookingID"
                Using cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@BookingID", bookingID)
                    Using da As New OleDbDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading booking karts: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Shared Function RemoveKartFromBooking(bookingID As Integer, kartID As Integer) As Boolean
        Try
            Using conn As OleDbConnection = DBHelper.GetConnection()
                conn.Open()

                ' Delete from BookingKarts
                Using cmd As New OleDbCommand("DELETE FROM BookingKarts WHERE BookingID=@BookingID AND KartID=@KartID", conn)
                    cmd.Parameters.AddWithValue("@BookingID", bookingID)
                    cmd.Parameters.AddWithValue("@KartID", kartID)
                    cmd.ExecuteNonQuery()
                End Using

                ' Set kart available again
                Using cmd2 As New OleDbCommand("UPDATE Karts SET Available=@Available WHERE KartID=@KartID", conn)
                    cmd2.Parameters.AddWithValue("@Available", True)
                    cmd2.Parameters.AddWithValue("@KartID", kartID)
                    cmd2.ExecuteNonQuery()
                End Using

                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error removing kart from booking: " & ex.Message)
            Return False
        End Try
    End Function
    Public Shared Function AddBookingKart(bookingId As Integer, kartId As Integer) As Integer
        Dim sql = "INSERT INTO BookingKarts (BookingID, KartID) VALUES (?,?)"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("@BookingID", bookingId)
                cmd.Parameters.AddWithValue("@KartID", kartId)
                cn.Open()
                cmd.ExecuteNonQuery()
                cmd.CommandText = "SELECT @@IDENTITY"
                Return Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

    Public Shared Function RemoveBookingKart(bookingId As Integer, kartId As Integer) As Boolean
        Dim sql = "DELETE FROM BookingKarts WHERE BookingID = ? AND KartID = ?"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("@BookingID", bookingId)
                cmd.Parameters.AddWithValue("@KartID", kartId)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Shared Function GetKartsForBooking(bookingId As Integer) As DataTable
        Dim dt As New DataTable()
        Dim sql = "SELECT bk.KartID, k.KartNumber, k.KartType FROM BookingKarts bk INNER JOIN Karts k ON bk.KartID = k.KartID WHERE bk.BookingID = ?"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("@BookingID", bookingId)
                Using da = New OleDbDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

End Class
