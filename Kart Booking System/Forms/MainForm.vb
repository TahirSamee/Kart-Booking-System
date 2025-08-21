Public Class MainForm
    Private _staffId As Integer
    Private _fullName As String
    Private _role As String

    Public Sub New(staffId As Integer, fullName As String, role As String)
        InitializeComponent()
        _staffId = staffId
        _fullName = fullName
        _role = role
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = $"Welcome, {_fullName} ({_role})"
        ' If not admin, disable some buttons
        If Not _role.Equals("Admin", StringComparison.InvariantCultureIgnoreCase) Then
            btnStaffManagement.Enabled = False
        End If
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Dim frm = New CustomerForm(_staffId)
        frm.ShowDialog()
    End Sub

    Private Sub btnBookings_Click(sender As Object, e As EventArgs) Handles btnBookings.Click
        Dim frm As New BookingForm(_staffId)
        frm.ShowDialog()
    End Sub

    Private Sub btnKarts_Click(sender As Object, e As EventArgs) Handles btnKarts.Click
        Dim frm As New KartForm(_staffId)
        frm.ShowDialog()
    End Sub

    Private Sub btnStaffManagement_Click(sender As Object, e As EventArgs) Handles btnStaffManagement.Click
        Dim frm As New StaffForm(_staffId)
        frm.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        LoginForm.Show()
    End Sub

End Class