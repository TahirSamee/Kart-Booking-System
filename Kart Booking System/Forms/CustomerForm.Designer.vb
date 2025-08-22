
Partial Class CustomerForm


    Inherits System.Windows.Forms.Form


    Private components As System.ComponentModel.IContainer
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents grpCustomerDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblCustomerID As System.Windows.Forms.Label
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnArchive As System.Windows.Forms.Button

    Friend WithEvents grpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearchID As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchByID As System.Windows.Forms.Button
    Friend WithEvents txtSearchSurname As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchBySurname As System.Windows.Forms.Button
    Friend WithEvents lstSurnameResults As System.Windows.Forms.ListBox

    Friend WithEvents dgvBookings As System.Windows.Forms.DataGridView

    Private Sub InitializeComponent()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.grpCustomerDetails = New System.Windows.Forms.GroupBox()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnArchive = New System.Windows.Forms.Button()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.txtSearchID = New System.Windows.Forms.TextBox()
        Me.btnSearchByID = New System.Windows.Forms.Button()
        Me.txtSearchSurname = New System.Windows.Forms.TextBox()
        Me.btnSearchBySurname = New System.Windows.Forms.Button()
        Me.lstSurnameResults = New System.Windows.Forms.ListBox()
        Me.dgvBookings = New System.Windows.Forms.DataGridView()
        Me.grpCustomerDetails.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        CType(Me.dgvBookings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.SteelBlue
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(851, 50)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "👥 Customer Management"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpCustomerDetails
        '
        Me.grpCustomerDetails.BackColor = System.Drawing.Color.White
        Me.grpCustomerDetails.Controls.Add(Me.lblCustomerID)
        Me.grpCustomerDetails.Controls.Add(Me.txtCustomerID)
        Me.grpCustomerDetails.Controls.Add(Me.lblFirstName)
        Me.grpCustomerDetails.Controls.Add(Me.txtFirstName)
        Me.grpCustomerDetails.Controls.Add(Me.lblLastName)
        Me.grpCustomerDetails.Controls.Add(Me.txtLastName)
        Me.grpCustomerDetails.Controls.Add(Me.lblDOB)
        Me.grpCustomerDetails.Controls.Add(Me.dtpDOB)
        Me.grpCustomerDetails.Controls.Add(Me.lblPhone)
        Me.grpCustomerDetails.Controls.Add(Me.txtPhone)
        Me.grpCustomerDetails.Controls.Add(Me.lblEmail)
        Me.grpCustomerDetails.Controls.Add(Me.txtEmail)
        Me.grpCustomerDetails.Controls.Add(Me.lblAddress)
        Me.grpCustomerDetails.Controls.Add(Me.txtAddress)
        Me.grpCustomerDetails.Controls.Add(Me.btnAdd)
        Me.grpCustomerDetails.Controls.Add(Me.btnUpdate)
        Me.grpCustomerDetails.Controls.Add(Me.btnArchive)
        Me.grpCustomerDetails.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpCustomerDetails.Location = New System.Drawing.Point(20, 60)
        Me.grpCustomerDetails.Name = "grpCustomerDetails"
        Me.grpCustomerDetails.Size = New System.Drawing.Size(395, 320)
        Me.grpCustomerDetails.TabIndex = 1
        Me.grpCustomerDetails.TabStop = False
        Me.grpCustomerDetails.Text = "Customer Details"
        '
        'lblCustomerID
        '
        Me.lblCustomerID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCustomerID.Location = New System.Drawing.Point(15, 30)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(100, 23)
        Me.lblCustomerID.TabIndex = 0
        Me.lblCustomerID.Text = "Customer ID:"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(120, 28)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(246, 30)
        Me.txtCustomerID.TabIndex = 1
        '
        'lblFirstName
        '
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFirstName.Location = New System.Drawing.Point(15, 65)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(100, 23)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "First Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(120, 63)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(246, 30)
        Me.txtFirstName.TabIndex = 3
        '
        'lblLastName
        '
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblLastName.Location = New System.Drawing.Point(15, 100)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(100, 23)
        Me.lblLastName.TabIndex = 4
        Me.lblLastName.Text = "Last Name:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(120, 98)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(246, 30)
        Me.txtLastName.TabIndex = 5
        '
        'lblDOB
        '
        Me.lblDOB.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDOB.Location = New System.Drawing.Point(15, 135)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(100, 23)
        Me.lblDOB.TabIndex = 6
        Me.lblDOB.Text = "Date of Birth:"
        '
        'dtpDOB
        '
        Me.dtpDOB.Location = New System.Drawing.Point(120, 133)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(246, 30)
        Me.dtpDOB.TabIndex = 7
        '
        'lblPhone
        '
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPhone.Location = New System.Drawing.Point(15, 170)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(100, 23)
        Me.lblPhone.TabIndex = 8
        Me.lblPhone.Text = "Phone:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(120, 168)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(246, 30)
        Me.txtPhone.TabIndex = 9
        '
        'lblEmail
        '
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblEmail.Location = New System.Drawing.Point(15, 205)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(100, 23)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(120, 203)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(246, 30)
        Me.txtEmail.TabIndex = 11
        '
        'lblAddress
        '
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblAddress.Location = New System.Drawing.Point(15, 240)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(100, 23)
        Me.lblAddress.TabIndex = 12
        Me.lblAddress.Text = "Address:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(120, 238)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(246, 30)
        Me.txtAddress.TabIndex = 13
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.SeaGreen
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(20, 275)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(114, 39)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "➕ Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(139, 275)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(114, 39)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "✏ Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnArchive
        '
        Me.btnArchive.BackColor = System.Drawing.Color.DarkRed
        Me.btnArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArchive.ForeColor = System.Drawing.Color.White
        Me.btnArchive.Location = New System.Drawing.Point(258, 275)
        Me.btnArchive.Name = "btnArchive"
        Me.btnArchive.Size = New System.Drawing.Size(114, 39)
        Me.btnArchive.TabIndex = 16
        Me.btnArchive.Text = "📦 Archive"
        Me.btnArchive.UseVisualStyleBackColor = False
        '
        'grpSearch
        '
        Me.grpSearch.BackColor = System.Drawing.Color.White
        Me.grpSearch.Controls.Add(Me.txtSearchID)
        Me.grpSearch.Controls.Add(Me.btnSearchByID)
        Me.grpSearch.Controls.Add(Me.txtSearchSurname)
        Me.grpSearch.Controls.Add(Me.btnSearchBySurname)
        Me.grpSearch.Controls.Add(Me.lstSurnameResults)
        Me.grpSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpSearch.Location = New System.Drawing.Point(421, 60)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(418, 320)
        Me.grpSearch.TabIndex = 2
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search Customers"
        '
        'txtSearchID
        '
        Me.txtSearchID.Location = New System.Drawing.Point(20, 30)
        Me.txtSearchID.Name = "txtSearchID"
        Me.txtSearchID.Size = New System.Drawing.Size(180, 30)
        Me.txtSearchID.TabIndex = 0
        '
        'btnSearchByID
        '
        Me.btnSearchByID.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSearchByID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchByID.ForeColor = System.Drawing.Color.White
        Me.btnSearchByID.Location = New System.Drawing.Point(220, 28)
        Me.btnSearchByID.Name = "btnSearchByID"
        Me.btnSearchByID.Size = New System.Drawing.Size(182, 34)
        Me.btnSearchByID.TabIndex = 1
        Me.btnSearchByID.Text = "🔍 By ID"
        Me.btnSearchByID.UseVisualStyleBackColor = False
        '
        'txtSearchSurname
        '
        Me.txtSearchSurname.Location = New System.Drawing.Point(20, 70)
        Me.txtSearchSurname.Name = "txtSearchSurname"
        Me.txtSearchSurname.Size = New System.Drawing.Size(180, 30)
        Me.txtSearchSurname.TabIndex = 2
        '
        'btnSearchBySurname
        '
        Me.btnSearchBySurname.BackColor = System.Drawing.Color.MediumPurple
        Me.btnSearchBySurname.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchBySurname.ForeColor = System.Drawing.Color.White
        Me.btnSearchBySurname.Location = New System.Drawing.Point(220, 68)
        Me.btnSearchBySurname.Name = "btnSearchBySurname"
        Me.btnSearchBySurname.Size = New System.Drawing.Size(182, 36)
        Me.btnSearchBySurname.TabIndex = 3
        Me.btnSearchBySurname.Text = "🔍 By Surname"
        Me.btnSearchBySurname.UseVisualStyleBackColor = False
        '
        'lstSurnameResults
        '
        Me.lstSurnameResults.ItemHeight = 23
        Me.lstSurnameResults.Location = New System.Drawing.Point(20, 110)
        Me.lstSurnameResults.Name = "lstSurnameResults"
        Me.lstSurnameResults.Size = New System.Drawing.Size(382, 188)
        Me.lstSurnameResults.TabIndex = 4
        '
        'dgvBookings
        '
        Me.dgvBookings.AllowUserToAddRows = False
        Me.dgvBookings.AllowUserToDeleteRows = False
        Me.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBookings.BackgroundColor = System.Drawing.Color.White
        Me.dgvBookings.ColumnHeadersHeight = 29
        Me.dgvBookings.Location = New System.Drawing.Point(20, 400)
        Me.dgvBookings.Name = "dgvBookings"
        Me.dgvBookings.ReadOnly = True
        Me.dgvBookings.RowHeadersVisible = False
        Me.dgvBookings.RowHeadersWidth = 51
        Me.dgvBookings.Size = New System.Drawing.Size(819, 241)
        Me.dgvBookings.TabIndex = 3
        '
        'CustomerForm
        '
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(851, 653)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.grpCustomerDetails)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.dgvBookings)
        Me.Name = "CustomerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Management"
        Me.grpCustomerDetails.ResumeLayout(False)
        Me.grpCustomerDetails.PerformLayout()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        CType(Me.dgvBookings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
End Class
