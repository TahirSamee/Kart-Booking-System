Partial Class BookingForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents clbKarts As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnCreateBooking As System.Windows.Forms.Button
    Friend WithEvents dtpSearchDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSearchDate As System.Windows.Forms.Button
    Friend WithEvents dgvBookings As System.Windows.Forms.DataGridView
    Friend WithEvents btnMarkAttended As System.Windows.Forms.Button
    Friend WithEvents txtBookingNotes As System.Windows.Forms.TextBox
    Friend WithEvents btnRemoveKart As System.Windows.Forms.Button
    ' Add this declaration at the top with the other controls
    Friend WithEvents dgvBookingKarts As System.Windows.Forms.DataGridView
    Friend WithEvents txtBookingID As System.Windows.Forms.TextBox



    Private Sub InitializeComponent()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.clbKarts = New System.Windows.Forms.CheckedListBox()
        Me.btnCreateBooking = New System.Windows.Forms.Button()
        Me.dtpSearchDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSearchDate = New System.Windows.Forms.Button()
        Me.dgvBookings = New System.Windows.Forms.DataGridView()
        Me.btnMarkAttended = New System.Windows.Forms.Button()
        Me.txtBookingNotes = New System.Windows.Forms.TextBox()
        CType(Me.dgvBookings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        Me.txtCustomerID.Location = New System.Drawing.Point(16, 16)
        Me.dtpStart.Location = New System.Drawing.Point(16, 48)
        Me.dtpEnd.Location = New System.Drawing.Point(220, 48)
        Me.clbKarts.Location = New System.Drawing.Point(16, 86)
        Me.clbKarts.Size = New System.Drawing.Size(360, 120)
        Me.txtBookingNotes.Location = New System.Drawing.Point(16, 220)
        Me.btnCreateBooking.Location = New System.Drawing.Point(16, 260)
        Me.btnCreateBooking.Text = "Create Booking"
        AddHandler Me.btnCreateBooking.Click, AddressOf Me.btnCreateBooking_Click

        Me.dtpSearchDate.Location = New System.Drawing.Point(420, 16)
        Me.btnSearchDate.Location = New System.Drawing.Point(620, 12)
        Me.btnSearchDate.Text = "Search Date"
        AddHandler Me.btnSearchDate.Click, AddressOf Me.btnSearchDate_Click

        Me.dgvBookings.Location = New System.Drawing.Point(420, 48)
        Me.dgvBookings.Size = New System.Drawing.Size(480, 300)

        Me.btnMarkAttended.Location = New System.Drawing.Point(420, 360)
        Me.btnMarkAttended.Text = "Mark Attended"
        AddHandler Me.btnMarkAttended.Click, AddressOf Me.btnMarkAttended_Click

        ' Booking ID textbox
        Me.txtBookingID = New System.Windows.Forms.TextBox()
        Me.txtBookingID.Location = New System.Drawing.Point(16, 400)
        Me.txtBookingID.Size = New System.Drawing.Size(100, 20)
        Me.txtBookingID.ReadOnly = True
        Me.Controls.Add(Me.txtBookingID)

        ' Booking Karts DataGridView
        Me.dgvBookingKarts = New System.Windows.Forms.DataGridView()
        Me.dgvBookingKarts.Location = New System.Drawing.Point(16, 430)
        Me.dgvBookingKarts.Size = New System.Drawing.Size(360, 150)
        Me.Controls.Add(Me.dgvBookingKarts)

        ' Remove Kart button
        Me.btnRemoveKart = New System.Windows.Forms.Button()
        Me.btnRemoveKart.Location = New System.Drawing.Point(16, 590)
        Me.btnRemoveKart.Text = "Remove Kart"
        AddHandler Me.btnRemoveKart.Click, AddressOf Me.btnRemoveKart_Click
        Me.Controls.Add(Me.btnRemoveKart)


        Me.ClientSize = New System.Drawing.Size(920, 430)
        Me.Controls.Add(Me.btnMarkAttended)
        Me.Controls.Add(Me.dgvBookings)
        Me.Controls.Add(Me.btnSearchDate)
        Me.Controls.Add(Me.dtpSearchDate)
        Me.Controls.Add(Me.btnCreateBooking)
        Me.Controls.Add(Me.txtBookingNotes)
        Me.Controls.Add(Me.clbKarts)
        Me.Controls.Add(Me.dtpEnd)
        Me.Controls.Add(Me.dtpStart)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Name = "BookingForm"
        Me.Text = "Bookings"
        CType(Me.dgvBookings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
End Class