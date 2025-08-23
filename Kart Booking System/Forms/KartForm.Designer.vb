Partial Class KartForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents grpKartDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblKartNumber As System.Windows.Forms.Label
    Friend WithEvents txtKartNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblKartType As System.Windows.Forms.Label
    Friend WithEvents txtKartType As System.Windows.Forms.TextBox
    Friend WithEvents chkAvailable As System.Windows.Forms.CheckBox
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents btnAddKart As System.Windows.Forms.Button
    Friend WithEvents btnSetAvailable As System.Windows.Forms.Button
    Friend WithEvents btnRemoveKart As System.Windows.Forms.Button
    Friend WithEvents dgvKarts As System.Windows.Forms.DataGridView

    Private Sub InitializeComponent()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.grpKartDetails = New System.Windows.Forms.GroupBox()
        Me.lblKartNumber = New System.Windows.Forms.Label()
        Me.txtKartNumber = New System.Windows.Forms.TextBox()
        Me.lblKartType = New System.Windows.Forms.Label()
        Me.txtKartType = New System.Windows.Forms.TextBox()
        Me.chkAvailable = New System.Windows.Forms.CheckBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.btnAddKart = New System.Windows.Forms.Button()
        Me.btnSetAvailable = New System.Windows.Forms.Button()
        Me.btnRemoveKart = New System.Windows.Forms.Button()
        Me.dgvKarts = New System.Windows.Forms.DataGridView()
        Me.grpKartDetails.SuspendLayout()
        CType(Me.dgvKarts, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblHeader.Text = "🏎 Kart Management"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpKartDetails
        '
        Me.grpKartDetails.BackColor = System.Drawing.Color.White
        Me.grpKartDetails.Controls.Add(Me.lblKartNumber)
        Me.grpKartDetails.Controls.Add(Me.txtKartNumber)
        Me.grpKartDetails.Controls.Add(Me.lblKartType)
        Me.grpKartDetails.Controls.Add(Me.txtKartType)
        Me.grpKartDetails.Controls.Add(Me.chkAvailable)
        Me.grpKartDetails.Controls.Add(Me.lblNotes)
        Me.grpKartDetails.Controls.Add(Me.txtNotes)
        Me.grpKartDetails.Controls.Add(Me.btnAddKart)
        Me.grpKartDetails.Controls.Add(Me.btnSetAvailable)
        Me.grpKartDetails.Controls.Add(Me.btnRemoveKart)
        Me.grpKartDetails.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpKartDetails.Location = New System.Drawing.Point(20, 60)
        Me.grpKartDetails.Name = "grpKartDetails"
        Me.grpKartDetails.Size = New System.Drawing.Size(395, 320)
        Me.grpKartDetails.TabIndex = 1
        Me.grpKartDetails.TabStop = False
        Me.grpKartDetails.Text = "Kart Details"
        '
        'lblKartNumber
        '
        Me.lblKartNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKartNumber.Location = New System.Drawing.Point(15, 30)
        Me.lblKartNumber.Name = "lblKartNumber"
        Me.lblKartNumber.Size = New System.Drawing.Size(100, 23)
        Me.lblKartNumber.TabIndex = 0
        Me.lblKartNumber.Text = "Kart Number:"
        '
        'txtKartNumber
        '
        Me.txtKartNumber.Location = New System.Drawing.Point(120, 28)
        Me.txtKartNumber.Name = "txtKartNumber"
        Me.txtKartNumber.Size = New System.Drawing.Size(246, 30)
        Me.txtKartNumber.TabIndex = 1
        '
        'lblKartType
        '
        Me.lblKartType.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKartType.Location = New System.Drawing.Point(15, 65)
        Me.lblKartType.Name = "lblKartType"
        Me.lblKartType.Size = New System.Drawing.Size(100, 23)
        Me.lblKartType.TabIndex = 2
        Me.lblKartType.Text = "Kart Type:"
        '
        'txtKartType
        '
        Me.txtKartType.Location = New System.Drawing.Point(120, 63)
        Me.txtKartType.Name = "txtKartType"
        Me.txtKartType.Size = New System.Drawing.Size(246, 30)
        Me.txtKartType.TabIndex = 3
        '
        'chkAvailable
        '
        Me.chkAvailable.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkAvailable.Location = New System.Drawing.Point(120, 100)
        Me.chkAvailable.Name = "chkAvailable"
        Me.chkAvailable.Size = New System.Drawing.Size(246, 25)
        Me.chkAvailable.TabIndex = 4
        Me.chkAvailable.Text = "Available"
        Me.chkAvailable.UseVisualStyleBackColor = True
        '
        'lblNotes
        '
        Me.lblNotes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNotes.Location = New System.Drawing.Point(15, 135)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(100, 23)
        Me.lblNotes.TabIndex = 5
        Me.lblNotes.Text = "Notes:"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(120, 133)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(246, 60)
        Me.txtNotes.TabIndex = 6
        '
        'btnAddKart
        '
        Me.btnAddKart.BackColor = System.Drawing.Color.SeaGreen
        Me.btnAddKart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddKart.ForeColor = System.Drawing.Color.White
        Me.btnAddKart.Location = New System.Drawing.Point(20, 210)
        Me.btnAddKart.Name = "btnAddKart"
        Me.btnAddKart.Size = New System.Drawing.Size(114, 39)
        Me.btnAddKart.TabIndex = 7
        Me.btnAddKart.Text = "➕ Add"
        Me.btnAddKart.UseVisualStyleBackColor = False
        '
        'btnSetAvailable
        '
        Me.btnSetAvailable.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSetAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetAvailable.ForeColor = System.Drawing.Color.White
        Me.btnSetAvailable.Location = New System.Drawing.Point(139, 210)
        Me.btnSetAvailable.Name = "btnSetAvailable"
        Me.btnSetAvailable.Size = New System.Drawing.Size(114, 39)
        Me.btnSetAvailable.TabIndex = 8
        Me.btnSetAvailable.Text = "✔ Set"
        Me.btnSetAvailable.UseVisualStyleBackColor = False
        '
        'btnRemoveKart
        '
        Me.btnRemoveKart.BackColor = System.Drawing.Color.DarkRed
        Me.btnRemoveKart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveKart.ForeColor = System.Drawing.Color.White
        Me.btnRemoveKart.Location = New System.Drawing.Point(258, 210)
        Me.btnRemoveKart.Name = "btnRemoveKart"
        Me.btnRemoveKart.Size = New System.Drawing.Size(114, 39)
        Me.btnRemoveKart.TabIndex = 9
        Me.btnRemoveKart.Text = "🗑 Remove"
        Me.btnRemoveKart.UseVisualStyleBackColor = False
        '
        'dgvKarts
        '
        Me.dgvKarts.AllowUserToAddRows = False
        Me.dgvKarts.AllowUserToDeleteRows = False
        Me.dgvKarts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvKarts.BackgroundColor = System.Drawing.Color.White
        Me.dgvKarts.ColumnHeadersHeight = 29
        Me.dgvKarts.Location = New System.Drawing.Point(421, 60)
        Me.dgvKarts.Name = "dgvKarts"
        Me.dgvKarts.ReadOnly = True
        Me.dgvKarts.RowHeadersVisible = False
        Me.dgvKarts.RowHeadersWidth = 51
        Me.dgvKarts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvKarts.Size = New System.Drawing.Size(418, 320)
        Me.dgvKarts.TabIndex = 2
        '
        'KartForm
        '
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(851, 400)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.grpKartDetails)
        Me.Controls.Add(Me.dgvKarts)
        Me.Name = "KartForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kart Management"
        Me.grpKartDetails.ResumeLayout(False)
        Me.grpKartDetails.PerformLayout()
        CType(Me.dgvKarts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
End Class
