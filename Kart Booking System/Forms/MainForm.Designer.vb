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
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.Location = New System.Drawing.Point(21, 19)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(90, 23)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome!"
        '
        'btnCustomers
        '
        Me.btnCustomers.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCustomers.FlatAppearance.BorderSize = 0
        Me.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomers.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCustomers.ForeColor = System.Drawing.Color.White
        Me.btnCustomers.Location = New System.Drawing.Point(104, 58)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(150, 40)
        Me.btnCustomers.TabIndex = 1
        Me.btnCustomers.Text = "👥 Customers"
        Me.btnCustomers.UseVisualStyleBackColor = False
        '
        'btnBookings
        '
        Me.btnBookings.BackColor = System.Drawing.Color.SeaGreen
        Me.btnBookings.FlatAppearance.BorderSize = 0
        Me.btnBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookings.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnBookings.ForeColor = System.Drawing.Color.White
        Me.btnBookings.Location = New System.Drawing.Point(104, 168)
        Me.btnBookings.Name = "btnBookings"
        Me.btnBookings.Size = New System.Drawing.Size(150, 40)
        Me.btnBookings.TabIndex = 2
        Me.btnBookings.Text = "📅 Bookings"
        Me.btnBookings.UseVisualStyleBackColor = False
        '
        'btnKarts
        '
        Me.btnKarts.BackColor = System.Drawing.Color.OrangeRed
        Me.btnKarts.FlatAppearance.BorderSize = 0
        Me.btnKarts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKarts.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnKarts.ForeColor = System.Drawing.Color.White
        Me.btnKarts.Location = New System.Drawing.Point(103, 113)
        Me.btnKarts.Name = "btnKarts"
        Me.btnKarts.Size = New System.Drawing.Size(150, 40)
        Me.btnKarts.TabIndex = 3
        Me.btnKarts.Text = "🏎 Karts"
        Me.btnKarts.UseVisualStyleBackColor = False
        '
        'btnStaffManagement
        '
        Me.btnStaffManagement.BackColor = System.Drawing.Color.MediumPurple
        Me.btnStaffManagement.FlatAppearance.BorderSize = 0
        Me.btnStaffManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaffManagement.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnStaffManagement.ForeColor = System.Drawing.Color.White
        Me.btnStaffManagement.Location = New System.Drawing.Point(103, 233)
        Me.btnStaffManagement.Name = "btnStaffManagement"
        Me.btnStaffManagement.Size = New System.Drawing.Size(150, 40)
        Me.btnStaffManagement.TabIndex = 4
        Me.btnStaffManagement.Text = "👨‍💼 Staff"
        Me.btnStaffManagement.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.DarkRed
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(104, 297)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(150, 40)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "🚪 Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
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
        Me.pnlContainer.Location = New System.Drawing.Point(30, 59)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(360, 371)
        Me.pnlContainer.TabIndex = 0
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.SteelBlue
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(420, 50)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "🏎 Kart Booking Dashboard"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(420, 448)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.pnlContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kart Booking - Main"
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
End Class
