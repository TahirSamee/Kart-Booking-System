Partial Class StaffForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
    Friend WithEvents dgvStaff As System.Windows.Forms.DataGridView
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents cmbRole As System.Windows.Forms.ComboBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnArchive As System.Windows.Forms.Button

    Private Sub InitializeComponent()
        Me.dgvStaff = New System.Windows.Forms.DataGridView()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnArchive = New System.Windows.Forms.Button()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        Me.dgvStaff.Location = New System.Drawing.Point(16, 16)
        Me.dgvStaff.Size = New System.Drawing.Size(640, 200)

        Me.txtUsername.Location = New System.Drawing.Point(16, 230)
        Me.txtPassword.Location = New System.Drawing.Point(160, 230)
        Me.txtFullName.Location = New System.Drawing.Point(16, 266)
        Me.cmbRole.Location = New System.Drawing.Point(160, 266)
        Me.cmbRole.Items.AddRange(New Object() {"Admin", "Staff"})
        Me.txtPhone.Location = New System.Drawing.Point(16, 302)
        Me.txtEmail.Location = New System.Drawing.Point(160, 302)

        Me.btnAdd.Location = New System.Drawing.Point(16, 338)
        Me.btnAdd.Text = "Add"
        AddHandler Me.btnAdd.Click, AddressOf Me.btnAdd_Click
        Me.btnArchive.Location = New System.Drawing.Point(96, 338)
        Me.btnArchive.Text = "Archive"
        AddHandler Me.btnArchive.Click, AddressOf Me.btnArchive_Click

        Me.ClientSize = New System.Drawing.Size(680, 400)
        Me.Controls.Add(Me.btnArchive)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.cmbRole)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.dgvStaff)
        Me.Text = "Staff Management"
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
End Class
