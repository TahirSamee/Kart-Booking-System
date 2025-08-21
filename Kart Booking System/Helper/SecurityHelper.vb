Imports System.Security.Cryptography
Imports System.Text

Module SecurityHelper


    Public Function GenerateSalt() As String
        Dim bytes(15) As Byte
        Using rng = RandomNumberGenerator.Create()
            rng.GetBytes(bytes)
        End Using
        Return Convert.ToBase64String(bytes)
    End Function


    Public Function HashPassword(password As String, salt As String) As String
        Dim combined = password & salt
        Using sha = SHA256.Create()
            Dim bytes = Encoding.UTF8.GetBytes(combined)
            Dim hash = sha.ComputeHash(bytes)
            Return Convert.ToBase64String(hash)
        End Using
    End Function


End Module
