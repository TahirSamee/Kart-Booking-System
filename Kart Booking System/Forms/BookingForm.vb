Imports System.Data.OleDb

Public Class BookingForm
    Private _staffId As Integer

    Public Sub New(staffId As Integer)
        InitializeComponent()
        _staffId = staffId
    End Sub

    Private Sub BookingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load karts into checkedlist
        LoadKarts()
    End Sub

    Private Sub LoadKarts()
        Dim dt = KartsDAL.GetAllKarts() ' implement this to return KartID, KartNumber, IsAvailable
        clbKarts.Items.Clear()
        For Each r As DataRow In dt.Rows
            Dim itemText = String.Format("{0} - {1} ({2})", r("KartID"), r("KartNumber"), If(Convert.ToBoolean(r("IsAvailable")), "Available", "Not Available"))
            clbKarts.Items.Add(New ListItemWithID(Convert.ToInt32(r("KartID")), itemText))
        Next
    End Sub

    Private Sub btnCreateBooking_Click(sender As Object, e As EventArgs) Handles btnCreateBooking.Click
        ' Validate customer loaded
        Dim customerId As Integer
        If Not Integer.TryParse(txtCustomerID.Text, customerId) Then
            MessageBox.Show("Load a customer first.")
            Return
        End If
        Dim startDt = dtpStart.Value
        Dim endDt = dtpEnd.Value
        If endDt <= startDt Then
            MessageBox.Show("End must be after start")
            Return
        End If

        ' Insert booking
        Dim bookingId = BookingsDAL.AddBooking(customerId, _staffId, startDt, endDt, "Booked", txtBookingNotes.Text)
        If bookingId <= 0 Then
            MessageBox.Show("Failed to create booking")
            Return
        End If

        ' Add selected karts
        For i = 0 To clbKarts.Items.Count - 1
            If clbKarts.GetItemChecked(i) Then
                Dim li = CType(clbKarts.Items(i), ListItemWithID)
                BookingKartsDAL.AddBookingKart(bookingId, li.ID)
                ' mark kart unavailable for this time range — simple approach
                KartsDAL.SetKartAvailability(li.ID, False)
            End If
        Next

        MessageBox.Show("Booking created: " & bookingId)
        LoadKarts() ' refresh availability
    End Sub

    Private Sub btnSearchDate_Click(sender As Object, e As EventArgs) Handles btnSearchDate.Click
        Dim dateSel = dtpSearchDate.Value.Date
        Dim startDate = dateSel
        Dim endDate = dateSel.AddDays(1)
        Dim dt = BookingsDAL.GetBookingsByRange(startDate, endDate)
        dgvBookings.DataSource = dt
    End Sub

    Private Sub btnMarkAttended_Click(sender As Object, e As EventArgs) Handles btnMarkAttended.Click
        If dgvBookings.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a booking first")
            Return
        End If
        Dim bookingId = Convert.ToInt32(dgvBookings.SelectedRows(0).Cells("BookingID").Value)
        BookingsDAL.MarkAttended(bookingId, True)
        MessageBox.Show("Marked attended")
    End Sub


    Private Sub btnRemoveKart_Click(sender As Object, e As EventArgs) Handles btnRemoveKart.Click
        If dgvBookingKarts.SelectedRows.Count > 0 Then
            Dim bookingID As Integer = CInt(txtBookingID.Text)
            Dim kartID As Integer = CInt(dgvBookingKarts.SelectedRows(0).Cells("KartID").Value)

            If BookingKartsDAL.RemoveKartFromBooking(bookingID, kartID) Then
                MessageBox.Show("Kart removed successfully.")
                LoadBookingKarts(bookingID) ' refresh grid
            End If
        Else
            MessageBox.Show("Please select a kart to remove.")
        End If
    End Sub
    Private Sub LoadBookingKarts(bookingID As Integer)
        Dim dt = BookingKartsDAL.GetKartsByBooking(bookingID) ' You must implement this in DAL
        dgvBookingKarts.DataSource = dt
    End Sub


End Class