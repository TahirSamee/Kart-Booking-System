Imports System.Data.OleDb
Imports System.IO

Module DBHelper


    'Public ReadOnly Property DatabasePath As String
    '    Get
    '        ' If you placed the DB in a Data folder inside the project output
    '        Return Path.Combine(Application.StartupPath, "Data", "KartBooking.accdb")
    '    End Get
    'End Property
    Public ReadOnly Property DatabasePath As String
        Get
            ' Get the base directory of the project (move up from bin\Debug\)
            Dim projectDir As String = Directory.GetParent(Application.StartupPath).Parent.FullName
            ' Combine with "Data\KartBooking.accdb"
            Return Path.Combine(projectDir, "Data", "KartBooking.accdb")
        End Get
    End Property

    Public Function GetConnection() As OleDbConnection
        Dim connString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={DatabasePath};Persist Security Info=False;"
        Return New OleDbConnection(connString)
    End Function


    Public Function TestConnection(ByRef errMsg As String) As Boolean
        Try
            Using cn As OleDbConnection = GetConnection()
                cn.Open()
                cn.Close()
            End Using
            Return True
        Catch ex As Exception
            errMsg = ex.Message
            Return False
        End Try
    End Function


End Module