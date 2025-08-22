Partial Class StaffForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents grpStaffDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents lblRole As System.Windows.Forms.Label
    Friend WithEvents cmbRole As System.Windows.Forms.ComboBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnArchive As System.Windows.Forms.Button
    Friend WithEvents dgvStaff As System.Windows.Forms.DataGridView

    Private Sub InitializeComponent()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.grpStaffDetails = New System.Windows.Forms.GroupBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnArchive = New System.Windows.Forms.Button()
        Me.dgvStaff = New System.Windows.Forms.DataGridView()

        Me.grpStaffDetails.SuspendLayout()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' Header
        Me.lblHeader.BackColor = System.Drawing.Color.SteelBlue
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Size = New System.Drawing.Size(900, 50)
        Me.lblHeader.Text = "👨‍💼 Staff Management"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' GroupBox - Staff Details
        Me.grpStaffDetails.BackColor = System.Drawing.Color.White
        Me.grpStaffDetails.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpStaffDetails.Location = New System.Drawing.Point(20, 70)
        Me.grpStaffDetails.Size = New System.Drawing.Size(380, 350)
        Me.grpStaffDetails.Text = "Staff Details"

        ' Username
        Me.lblUsername.Text = "Username:"
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblUsername.Location = New System.Drawing.Point(20, 30)
        Me.txtUsername.Location = New System.Drawing.Point(120, 28)
        Me.txtUsername.Size = New System.Drawing.Size(230, 30)

        ' Password
        Me.lblPassword.Text = "Password:"
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPassword.Location = New System.Drawing.Point(20, 65)
        Me.txtPassword.Location = New System.Drawing.Point(120, 63)
        Me.txtPassword.Size = New System.Drawing.Size(230, 30)
        Me.txtPassword.UseSystemPasswordChar = True

        ' Full Name
        Me.lblFullName.Text = "Full Name:"
        Me.lblFullName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFullName.Location = New System.Drawing.Point(20, 100)
        Me.txtFullName.Location = New System.Drawing.Point(120, 98)
        Me.txtFullName.Size = New System.Drawing.Size(230, 30)

        ' Role
        Me.lblRole.Text = "Role:"
        Me.lblRole.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblRole.Location = New System.Drawing.Point(20, 135)
        Me.cmbRole.Location = New System.Drawing.Point(120, 133)
        Me.cmbRole.Size = New System.Drawing.Size(230, 30)
        Me.cmbRole.Items.AddRange(New Object() {"Admin", "Staff"})

        ' Phone
        Me.lblPhone.Text = "Phone:"
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPhone.Location = New System.Drawing.Point(20, 170)
        Me.txtPhone.Location = New System.Drawing.Point(120, 168)
        Me.txtPhone.Size = New System.Drawing.Size(230, 30)

        ' Email
        Me.lblEmail.Text = "Email:"
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblEmail.Location = New System.Drawing.Point(20, 205)
        Me.txtEmail.Location = New System.Drawing.Point(120, 203)
        Me.txtEmail.Size = New System.Drawing.Size(230, 30)

        ' Buttons
        Me.btnAdd.BackColor = System.Drawing.Color.SeaGreen
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(20, 260)
        Me.btnAdd.Size = New System.Drawing.Size(110, 40)
        Me.btnAdd.Text = "➕ Add"

        Me.btnArchive.BackColor = System.Drawing.Color.DarkRed
        Me.btnArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArchive.ForeColor = System.Drawing.Color.White
        Me.btnArchive.Location = New System.Drawing.Point(140, 260)
        Me.btnArchive.Size = New System.Drawing.Size(110, 40)
        Me.btnArchive.Text = "🗑 Archive"

        ' Add controls into GroupBox
        Me.grpStaffDetails.Controls.AddRange(New Control() {
            Me.lblUsername, Me.txtUsername,
            Me.lblPassword, Me.txtPassword,
            Me.lblFullName, Me.txtFullName,
            Me.lblRole, Me.cmbRole,
            Me.lblPhone, Me.txtPhone,
            Me.lblEmail, Me.txtEmail,
            Me.btnAdd, Me.btnArchive
        })

        ' DataGridView
        Me.dgvStaff.Location = New System.Drawing.Point(420, 70)
        Me.dgvStaff.Size = New System.Drawing.Size(460, 350)
        Me.dgvStaff.BackgroundColor = System.Drawing.Color.White
        Me.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStaff.ReadOnly = True
        Me.dgvStaff.AllowUserToAddRows = False
        Me.dgvStaff.AllowUserToDeleteRows = False
        Me.dgvStaff.RowHeadersVisible = False

        ' StaffForm
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(900, 450)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.grpStaffDetails)
        Me.Controls.Add(Me.dgvStaff)
        Me.Name = "StaffForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Management"

        Me.grpStaffDetails.ResumeLayout(False)
        Me.grpStaffDetails.PerformLayout()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
End Class
