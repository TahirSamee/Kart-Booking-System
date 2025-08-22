Partial Class MainForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents btnCustomers As System.Windows.Forms.Button
    Friend WithEvents btnBookings As System.Windows.Forms.Button
    Friend WithEvents btnKarts As System.Windows.Forms.Button
    Friend WithEvents btnStaffManagement As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents pnlContainer As System.Windows.Forms.Panel
    Friend WithEvents lblHeader As System.Windows.Forms.Label

    Private Sub InitializeComponent()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnBookings = New System.Windows.Forms.Button()
        Me.btnKarts = New System.Windows.Forms.Button()
        Me.btnStaffManagement = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pnlContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.BackColor = System.Drawing.Color.SteelBlue
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(420, 50)
        Me.lblHeader.Text = "🏎 Kart Booking Dashboard"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.Location = New System.Drawing.Point(15, 15)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(96, 23)
        Me.lblWelcome.Text = "Welcome!"
        '
        'pnlContainer
        '
        Me.pnlContainer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlContainer.BackColor = System.Drawing.Color.White
        Me.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlContainer.Controls.Add(Me.lblWelcome)
        Me.pnlContainer.Controls.Add(Me.btnCustomers)
        Me.pnlContainer.Controls.Add(Me.btnBookings)
        Me.pnlContainer.Controls.Add(Me.btnKarts)
        Me.pnlContainer.Controls.Add(Me.btnStaffManagement)
        Me.pnlContainer.Controls.Add(Me.btnLogout)
        Me.pnlContainer.Location = New System.Drawing.Point(30, 70)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(360, 230)
        Me.pnlContainer.TabIndex = 0
        '
        'btnCustomers
        '
        Me.btnCustomers.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCustomers.FlatAppearance.BorderSize = 0
        Me.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomers.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCustomers.ForeColor = System.Drawing.Color.White
        Me.btnCustomers.Location = New System.Drawing.Point(20, 55)
        Me.btnCustomers.Size = New System.Drawing.Size(150, 40)
        Me.btnCustomers.Text = "👥 Customers"
        'AddHandler Me.btnCustomers.Click, AddressOf Me.btnCustomers_Click
        '
        'btnBookings
        '
        Me.btnBookings.BackColor = System.Drawing.Color.SeaGreen
        Me.btnBookings.FlatAppearance.BorderSize = 0
        Me.btnBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookings.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnBookings.ForeColor = System.Drawing.Color.White
        Me.btnBookings.Location = New System.Drawing.Point(190, 55)
        Me.btnBookings.Size = New System.Drawing.Size(150, 40)
        Me.btnBookings.Text = "📅 Bookings"
        'AddHandler Me.btnBookings.Click, AddressOf Me.btnBookings_Click
        '
        'btnKarts
        '
        Me.btnKarts.BackColor = System.Drawing.Color.OrangeRed
        Me.btnKarts.FlatAppearance.BorderSize = 0
        Me.btnKarts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKarts.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnKarts.ForeColor = System.Drawing.Color.White
        Me.btnKarts.Location = New System.Drawing.Point(20, 110)
        Me.btnKarts.Size = New System.Drawing.Size(150, 40)
        Me.btnKarts.Text = "🏎 Karts"
        'AddHandler Me.btnKarts.Click, AddressOf Me.btnKarts_Click
        '
        'btnStaffManagement
        '
        Me.btnStaffManagement.BackColor = System.Drawing.Color.MediumPurple
        Me.btnStaffManagement.FlatAppearance.BorderSize = 0
        Me.btnStaffManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaffManagement.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnStaffManagement.ForeColor = System.Drawing.Color.White
        Me.btnStaffManagement.Location = New System.Drawing.Point(190, 110)
        Me.btnStaffManagement.Size = New System.Drawing.Size(150, 40)
        Me.btnStaffManagement.Text = "👨‍💼 Staff"
        'AddHandler Me.btnStaffManagement.Click, AddressOf Me.btnStaffManagement_Click
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.DarkRed
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(105, 170)
        Me.btnLogout.Size = New System.Drawing.Size(150, 40)
        Me.btnLogout.Text = "🚪 Logout"
        'AddHandler Me.btnLogout.Click, AddressOf Me.btnLogout_Click
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(420, 320)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.pnlContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kart Booking - Main"
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlContainer.PerformLayout()
        Me.ResumeLayout(False)
    End Sub
End Class
