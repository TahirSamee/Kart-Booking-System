Imports System.Data.OleDb

Public Class KartsDAL

    Public Shared Function GetAllKarts() As DataTable
        Dim dt As New DataTable()
        Dim sql = "SELECT KartID, KartNumber, KartType, IsAvailable, Notes FROM Karts"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                Using da = New OleDbDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Shared Function AddKart(kartNumber As String, kartType As String, isAvailable As Boolean, notes As String) As Integer
        Dim sql = "INSERT INTO Karts (KartNumber, KartType, IsAvailable, Notes, CreatedAt, UpdatedAt) VALUES (?,?,?,?,?,?)"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("@KartNumber", kartNumber)
                cmd.Parameters.AddWithValue("@KartType", kartType)
                cmd.Parameters.AddWithValue("@IsAvailable", isAvailable)
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

    Public Shared Function SetKartAvailability(kartId As Integer, isAvailable As Boolean) As Boolean
        Dim sql = "UPDATE Karts SET IsAvailable = ?, UpdatedAt = ? WHERE KartID = ?"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("@IsAvailable", isAvailable)
                cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now)
                cmd.Parameters.AddWithValue("@KartID", kartId)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Shared Function GetKartByID(kartId As Integer) As DataRow
        Dim dt As New DataTable()
        Dim sql = "SELECT * FROM Karts WHERE KartID = ?"
        Using cn = DBHelper.GetConnection()
            Using cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("@KartID", kartId)
                Using da = New OleDbDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        If dt.Rows.Count > 0 Then Return dt.Rows(0)
        Return Nothing
    End Function

End Class
