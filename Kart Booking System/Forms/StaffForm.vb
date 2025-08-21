Public Class StaffForm
    Private _currentStaffId As Integer
    Public Sub New(currentStaffId As Integer)
        InitializeComponent()
        _currentStaffId = currentStaffId
    End Sub

    Private Sub StaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStaffGrid()
    End Sub

    Private Sub LoadStaffGrid()
        dgvStaff.DataSource = StaffDAL.GetAllStaff()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Username and password required")
            Return
        End If
        Dim id = StaffDAL.AddStaff(txtUsername.Text.Trim(), txtPassword.Text, txtFullName.Text.Trim(), If(cmbRole.SelectedItem IsNot Nothing, cmbRole.SelectedItem.ToString(), "Staff"), txtPhone.Text.Trim(), txtEmail.Text.Trim())
        If id > 0 Then
            MessageBox.Show("Staff added")
            LoadStaffGrid()
            ClearInputs()
        End If
    End Sub

    Private Sub btnArchive_Click(sender As Object, e As EventArgs) Handles btnArchive.Click
        If dgvStaff.SelectedRows.Count = 0 Then
            MessageBox.Show("Select staff row")
            Return
        End If
        Dim id = Convert.ToInt32(dgvStaff.SelectedRows(0).Cells("StaffID").Value)
        If StaffDAL.ArchiveStaff(id) Then
            MessageBox.Show("Archived")
            LoadStaffGrid()
        End If
    End Sub

    Private Sub ClearInputs()
        txtUsername.Clear()
        txtPassword.Clear()
        txtFullName.Clear()
        cmbRole.SelectedIndex = -1
        txtPhone.Clear()
        txtEmail.Clear()
    End Sub
End Class
