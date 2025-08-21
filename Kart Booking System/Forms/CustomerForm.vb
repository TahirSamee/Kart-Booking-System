Public Class CustomerForm
    Private _staffId As Integer

    Public Sub New(staffId As Integer)
        InitializeComponent()
        _staffId = staffId
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim id = CustomersDAL.AddCustomer(txtFirstName.Text.Trim(), txtLastName.Text.Trim(), If(dtpDOB.Checked, dtpDOB.Value, CType(Nothing, DateTime?)), txtPhone.Text.Trim(), txtEmail.Text.Trim(), txtAddress.Text.Trim())
        If id > 0 Then
            MessageBox.Show("Customer added. ID: " & id)
            ClearInputs()
        End If
    End Sub

    Private Sub btnSearchByID_Click(sender As Object, e As EventArgs) Handles btnSearchByID.Click
        If Not Integer.TryParse(txtSearchID.Text.Trim(), 0) Then
            MessageBox.Show("Enter valid Customer ID")
            Return
        End If
        Dim dt = CustomersDAL.GetCustomerByID(Convert.ToInt32(txtSearchID.Text.Trim()))
        If dt.Rows.Count = 0 Then
            MessageBox.Show("Not found")
            Return
        End If
        LoadCustomerRow(dt.Rows(0))
    End Sub

    Private Sub btnSearchBySurname_Click(sender As Object, e As EventArgs) Handles btnSearchBySurname.Click
        Dim dt = CustomersDAL.SearchCustomersBySurname(txtSearchSurname.Text.Trim())
        lstSurnameResults.Items.Clear()
        For Each r As DataRow In dt.Rows
            lstSurnameResults.Items.Add(New ListItemWithID(Convert.ToInt32(r("CustomerID")), String.Format("{0} {1} - {2}", r("FirstName"), r("LastName"), r("Phone"))))
        Next
        If lstSurnameResults.Items.Count = 0 Then MessageBox.Show("No matches")
    End Sub

    Private Sub lstSurnameResults_DoubleClick(sender As Object, e As EventArgs) Handles lstSurnameResults.DoubleClick
        If lstSurnameResults.SelectedItem Is Nothing Then Return
        Dim li = CType(lstSurnameResults.SelectedItem, ListItemWithID)
        Dim dt = CustomersDAL.GetCustomerByID(li.ID)
        If dt.Rows.Count > 0 Then LoadCustomerRow(dt.Rows(0))
    End Sub

    Private Sub LoadCustomerRow(row As DataRow)
        txtCustomerID.Text = row("CustomerID").ToString()
        txtFirstName.Text = row("FirstName").ToString()
        txtLastName.Text = row("LastName").ToString()
        If Not IsDBNull(row("DOB")) Then dtpDOB.Value = Convert.ToDateTime(row("DOB"))
        txtPhone.Text = row("Phone").ToString()
        txtEmail.Text = row("Email").ToString()
        txtAddress.Text = row("Address").ToString()
        ' Load booking history
        Dim dtBookings = CustomersDAL.GetBookingHistoryForCustomer(Convert.ToInt32(row("CustomerID")))
        dgvBookings.DataSource = dtBookings
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim id As Integer
        If Not Integer.TryParse(txtCustomerID.Text, id) Then
            MessageBox.Show("Load a customer first.")
            Return
        End If
        If CustomersDAL.UpdateCustomer(id, txtFirstName.Text.Trim(), txtLastName.Text.Trim(), If(dtpDOB.Checked, dtpDOB.Value, CType(Nothing, DateTime?)), txtPhone.Text.Trim(), txtEmail.Text.Trim(), txtAddress.Text.Trim()) Then
            MessageBox.Show("Updated")
        Else
            MessageBox.Show("Update failed")
        End If
    End Sub

    Private Sub btnArchive_Click(sender As Object, e As EventArgs) Handles btnArchive.Click
        Dim id As Integer
        If Not Integer.TryParse(txtCustomerID.Text, id) Then
            MessageBox.Show("Load a customer first.")
            Return
        End If
        If MessageBox.Show("Archive this customer?", "Archive", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If CustomersDAL.ArchiveCustomer(id) Then
                MessageBox.Show("Customer archived")
                ClearInputs()
            Else
                MessageBox.Show("Archive failed")
            End If
        End If
    End Sub

    Private Sub ClearInputs()
        txtCustomerID.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        dtpDOB.Value = DateTime.Now
        txtPhone.Clear()
        txtEmail.Clear()
        txtAddress.Clear()
        dgvBookings.DataSource = Nothing
        lstSurnameResults.Items.Clear()
    End Sub

End Class

' helper class to show listbox items with ID
Public Class ListItemWithID
    Public Property ID As Integer
    Public Property DisplayText As String
    Public Sub New(id As Integer, text As String)
        id = id
        DisplayText = text
    End Sub
    Public Overrides Function ToString() As String
        Return DisplayText
    End Function
End Class