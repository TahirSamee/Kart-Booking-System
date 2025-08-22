Partial Class BookingForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents grpBookingDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblBookingID As System.Windows.Forms.Label
    Friend WithEvents txtBookingID As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerID As System.Windows.Forms.Label
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents txtBookingNotes As System.Windows.Forms.TextBox
    Friend WithEvents lblKarts As System.Windows.Forms.Label
    Friend WithEvents clbKarts As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnCreateBooking As System.Windows.Forms.Button
    Friend WithEvents btnRemoveKart As System.Windows.Forms.Button
    Friend WithEvents btnMarkAttended As System.Windows.Forms.Button

    Friend WithEvents dgvBookings As System.Windows.Forms.DataGridView
    Friend WithEvents dgvBookingKarts As System.Windows.Forms.DataGridView
    Friend WithEvents lblSearchDate As System.Windows.Forms.Label
    Friend WithEvents dtpSearchDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSearchDate As System.Windows.Forms.Button

    Private Sub InitializeComponent()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.grpBookingDetails = New System.Windows.Forms.GroupBox()
        Me.lblBookingID = New System.Windows.Forms.Label()
        Me.txtBookingID = New System.Windows.Forms.TextBox()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtBookingNotes = New System.Windows.Forms.TextBox()
        Me.lblKarts = New System.Windows.Forms.Label()
        Me.clbKarts = New System.Windows.Forms.CheckedListBox()
        Me.btnCreateBooking = New System.Windows.Forms.Button()
        Me.btnRemoveKart = New System.Windows.Forms.Button()
        Me.btnMarkAttended = New System.Windows.Forms.Button()
        Me.dgvBookings = New System.Windows.Forms.DataGridView()
        Me.dgvBookingKarts = New System.Windows.Forms.DataGridView()
        Me.lblSearchDate = New System.Windows.Forms.Label()
        Me.dtpSearchDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSearchDate = New System.Windows.Forms.Button()
        Me.grpBookingDetails.SuspendLayout()
        CType(Me.dgvBookings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBookingKarts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' Header
        Me.lblHeader.BackColor = System.Drawing.Color.SteelBlue
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Size = New System.Drawing.Size(1000, 50)
        Me.lblHeader.Text = "📅 Booking Management"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' GroupBox Booking Details
        Me.grpBookingDetails.BackColor = System.Drawing.Color.White
        Me.grpBookingDetails.Controls.Add(Me.lblBookingID)
        Me.grpBookingDetails.Controls.Add(Me.txtBookingID)
        Me.grpBookingDetails.Controls.Add(Me.lblCustomerID)
        Me.grpBookingDetails.Controls.Add(Me.txtCustomerID)
        Me.grpBookingDetails.Controls.Add(Me.lblStart)
        Me.grpBookingDetails.Controls.Add(Me.dtpStart)
        Me.grpBookingDetails.Controls.Add(Me.lblEnd)
        Me.grpBookingDetails.Controls.Add(Me.dtpEnd)
        Me.grpBookingDetails.Controls.Add(Me.lblNotes)
        Me.grpBookingDetails.Controls.Add(Me.txtBookingNotes)
        Me.grpBookingDetails.Controls.Add(Me.lblKarts)
        Me.grpBookingDetails.Controls.Add(Me.clbKarts)
        Me.grpBookingDetails.Controls.Add(Me.btnCreateBooking)
        Me.grpBookingDetails.Controls.Add(Me.btnRemoveKart)
        Me.grpBookingDetails.Controls.Add(Me.btnMarkAttended)
        Me.grpBookingDetails.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpBookingDetails.Location = New System.Drawing.Point(20, 60)
        Me.grpBookingDetails.Size = New System.Drawing.Size(400, 420)
        Me.grpBookingDetails.Text = "Booking Details"

        ' Booking ID
        Me.lblBookingID.Text = "Booking ID:"
        Me.lblBookingID.Location = New System.Drawing.Point(15, 30)
        Me.txtBookingID.Location = New System.Drawing.Point(120, 28)
        Me.txtBookingID.Size = New System.Drawing.Size(250, 30)
        Me.txtBookingID.ReadOnly = True

        ' Customer ID
        Me.lblCustomerID.Text = "Customer ID:"
        Me.lblCustomerID.Location = New System.Drawing.Point(15, 65)
        Me.txtCustomerID.Location = New System.Drawing.Point(120, 63)
        Me.txtCustomerID.Size = New System.Drawing.Size(250, 30)

        ' Start Date
        Me.lblStart.Text = "Start:"
        Me.lblStart.Location = New System.Drawing.Point(15, 100)
        Me.dtpStart.Location = New System.Drawing.Point(120, 98)

        ' End Date
        Me.lblEnd.Text = "End:"
        Me.lblEnd.Location = New System.Drawing.Point(15, 135)
        Me.dtpEnd.Location = New System.Drawing.Point(120, 133)

        ' Notes
        Me.lblNotes.Text = "Notes:"
        Me.lblNotes.Location = New System.Drawing.Point(15, 170)
        Me.txtBookingNotes.Location = New System.Drawing.Point(120, 168)
        Me.txtBookingNotes.Multiline = True
        Me.txtBookingNotes.Size = New System.Drawing.Size(250, 50)

        ' Karts
        Me.lblKarts.Text = "Select Karts:"
        Me.lblKarts.Location = New System.Drawing.Point(15, 225)
        Me.clbKarts.Location = New System.Drawing.Point(120, 223)
        Me.clbKarts.Size = New System.Drawing.Size(250, 79)

        ' Buttons
        Me.btnCreateBooking.Text = "➕ Create"
        Me.btnCreateBooking.BackColor = System.Drawing.Color.SeaGreen
        Me.btnCreateBooking.ForeColor = System.Drawing.Color.White
        Me.btnCreateBooking.Location = New System.Drawing.Point(20, 330)
        Me.btnCreateBooking.Size = New System.Drawing.Size(97, 56)

        Me.btnRemoveKart.Text = "🗑 Remove Kart"
        Me.btnRemoveKart.BackColor = System.Drawing.Color.DarkRed
        Me.btnRemoveKart.ForeColor = System.Drawing.Color.White
        Me.btnRemoveKart.Location = New System.Drawing.Point(140, 330)
        Me.btnRemoveKart.Size = New System.Drawing.Size(120, 56)

        Me.btnMarkAttended.Text = "✔ Attended"
        Me.btnMarkAttended.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnMarkAttended.ForeColor = System.Drawing.Color.White
        Me.btnMarkAttended.Location = New System.Drawing.Point(270, 330)
        Me.btnMarkAttended.Size = New System.Drawing.Size(100, 56)

        ' DataGridView - Bookings
        Me.dgvBookings.Location = New System.Drawing.Point(440, 100)
        Me.dgvBookings.Size = New System.Drawing.Size(540, 200)
        Me.dgvBookings.BackgroundColor = System.Drawing.Color.White
        Me.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBookings.ReadOnly = True

        ' DataGridView - Booking Karts
        Me.dgvBookingKarts.Location = New System.Drawing.Point(440, 320)
        Me.dgvBookingKarts.Size = New System.Drawing.Size(540, 160)
        Me.dgvBookingKarts.BackgroundColor = System.Drawing.Color.White
        Me.dgvBookingKarts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBookingKarts.ReadOnly = True

        ' Search Date
        Me.lblSearchDate.Text = "Search by Date:"
        Me.lblSearchDate.Location = New System.Drawing.Point(440, 65)
        Me.dtpSearchDate.Location = New System.Drawing.Point(550, 60)
        Me.btnSearchDate.Text = "🔍 Search"
        Me.btnSearchDate.BackColor = System.Drawing.Color.OrangeRed
        Me.btnSearchDate.ForeColor = System.Drawing.Color.White
        Me.btnSearchDate.Location = New System.Drawing.Point(770, 57)
        Me.btnSearchDate.Size = New System.Drawing.Size(120, 30)

        ' BookingForm
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1000, 500)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.grpBookingDetails)
        Me.Controls.Add(Me.dgvBookings)
        Me.Controls.Add(Me.dgvBookingKarts)
        Me.Controls.Add(Me.lblSearchDate)
        Me.Controls.Add(Me.dtpSearchDate)
        Me.Controls.Add(Me.btnSearchDate)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking Management"

        Me.grpBookingDetails.ResumeLayout(False)
        Me.grpBookingDetails.PerformLayout()
        CType(Me.dgvBookings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBookingKarts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
End Class
