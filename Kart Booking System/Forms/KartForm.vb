Public Class KartForm
    Private _staffId As Integer
    Public Sub New(staffId As Integer)
        InitializeComponent()
        _staffId = staffId
    End Sub

    Private Sub KartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKartsGrid()
    End Sub

    Private Sub LoadKartsGrid()
        dgvKarts.DataSource = KartsDAL.GetAllKarts()
    End Sub

    Private Sub btnAddKart_Click(sender As Object, e As EventArgs) Handles btnAddKart.Click
        Dim id = KartsDAL.AddKart(txtKartNumber.Text.Trim(), txtKartType.Text.Trim(), chkAvailable.Checked, txtNotes.Text.Trim())
        If id > 0 Then
            MessageBox.Show("Kart added")
            LoadKartsGrid()
            ClearInputs()
        End If
    End Sub

    Private Sub btnSetAvailable_Click(sender As Object, e As EventArgs) Handles btnSetAvailable.Click
        If dgvKarts.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a kart row")
            Return
        End If
        Dim id = Convert.ToInt32(dgvKarts.SelectedRows(0).Cells("KartID").Value)
        If KartsDAL.SetKartAvailability(id, chkAvailable.Checked) Then
            MessageBox.Show("Availability updated")
            LoadKartsGrid()
        End If
    End Sub

    Private Sub ClearInputs()
        txtKartNumber.Clear()
        txtKartType.Clear()
        chkAvailable.Checked = True
        txtNotes.Clear()
    End Sub
End Class
