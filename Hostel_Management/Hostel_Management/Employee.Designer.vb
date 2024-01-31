<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ListStatus = New System.Windows.Forms.ListBox()
        Me.ListPosition = New System.Windows.Forms.ListBox()
        Me.TextAddress = New System.Windows.Forms.TextBox()
        Me.TextNumber = New System.Windows.Forms.TextBox()
        Me.TextEmpName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextEmpId = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EmployeeDataSet = New Hostel_Management.EmployeeDataSet()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New Hostel_Management.EmployeeDataSetTableAdapters.EmployeeTableAdapter()
        Me.EmpIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListStatus
        '
        Me.ListStatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListStatus.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListStatus.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.ListStatus.FormattingEnabled = True
        Me.ListStatus.ItemHeight = 21
        Me.ListStatus.Items.AddRange(New Object() {"WORKING", "LEFT"})
        Me.ListStatus.Location = New System.Drawing.Point(259, 548)
        Me.ListStatus.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ListStatus.Name = "ListStatus"
        Me.ListStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ListStatus.Size = New System.Drawing.Size(212, 25)
        Me.ListStatus.TabIndex = 93
        '
        'ListPosition
        '
        Me.ListPosition.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListPosition.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListPosition.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.ListPosition.FormattingEnabled = True
        Me.ListPosition.ItemHeight = 21
        Me.ListPosition.Items.AddRange(New Object() {"MESS STAFF", "ACCOUNTANT", "CLEANER", "SECURITY GUARD"})
        Me.ListPosition.Location = New System.Drawing.Point(259, 486)
        Me.ListPosition.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ListPosition.Name = "ListPosition"
        Me.ListPosition.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ListPosition.Size = New System.Drawing.Size(212, 25)
        Me.ListPosition.TabIndex = 92
        '
        'TextAddress
        '
        Me.TextAddress.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextAddress.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextAddress.ForeColor = System.Drawing.Color.DodgerBlue
        Me.TextAddress.Location = New System.Drawing.Point(259, 431)
        Me.TextAddress.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextAddress.Multiline = True
        Me.TextAddress.Name = "TextAddress"
        Me.TextAddress.Size = New System.Drawing.Size(212, 27)
        Me.TextAddress.TabIndex = 89
        '
        'TextNumber
        '
        Me.TextNumber.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextNumber.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNumber.ForeColor = System.Drawing.Color.DodgerBlue
        Me.TextNumber.Location = New System.Drawing.Point(259, 374)
        Me.TextNumber.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextNumber.Multiline = True
        Me.TextNumber.Name = "TextNumber"
        Me.TextNumber.Size = New System.Drawing.Size(212, 27)
        Me.TextNumber.TabIndex = 88
        '
        'TextEmpName
        '
        Me.TextEmpName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextEmpName.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEmpName.ForeColor = System.Drawing.Color.DodgerBlue
        Me.TextEmpName.Location = New System.Drawing.Point(259, 321)
        Me.TextEmpName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextEmpName.Multiline = True
        Me.TextEmpName.Name = "TextEmpName"
        Me.TextEmpName.Size = New System.Drawing.Size(212, 27)
        Me.TextEmpName.TabIndex = 87
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Crimson
        Me.Label11.Location = New System.Drawing.Point(10, 548)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(219, 24)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "EMPLOYEE STATUS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Crimson
        Me.Label10.Location = New System.Drawing.Point(10, 487)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 24)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "POSITION"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Crimson
        Me.Label7.Location = New System.Drawing.Point(10, 431)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 24)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "ADDRESS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Crimson
        Me.Label6.Location = New System.Drawing.Point(10, 374)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 24)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "PHONE NUMBER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Crimson
        Me.Label5.Location = New System.Drawing.Point(10, 321)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 24)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "EMPLOYEE NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(10, 269)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 24)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "EMPLOYEE ID"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Location = New System.Drawing.Point(-53, 186)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1343, 26)
        Me.Panel3.TabIndex = 77
        '
        'Button8
        '
        Me.Button8.CausesValidation = False
        Me.Button8.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button8.ForeColor = System.Drawing.Color.Crimson
        Me.Button8.Location = New System.Drawing.Point(152, 659)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(114, 37)
        Me.Button8.TabIndex = 76
        Me.Button8.Text = "BACK"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.CausesValidation = False
        Me.Button7.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button7.ForeColor = System.Drawing.Color.Crimson
        Me.Button7.Location = New System.Drawing.Point(279, 605)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(122, 37)
        Me.Button7.TabIndex = 75
        Me.Button7.Text = "DELETE"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.CausesValidation = False
        Me.Button6.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button6.ForeColor = System.Drawing.Color.Crimson
        Me.Button6.Location = New System.Drawing.Point(140, 605)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(126, 37)
        Me.Button6.TabIndex = 74
        Me.Button6.Text = "UPDATE"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.CausesValidation = False
        Me.Button5.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.ForeColor = System.Drawing.Color.Crimson
        Me.Button5.Location = New System.Drawing.Point(13, 605)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(110, 37)
        Me.Button5.TabIndex = 73
        Me.Button5.Text = "ADD"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(735, 234)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(237, 30)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "EMPLOYEE LIST"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Crimson
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 715)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1234, 31)
        Me.Panel4.TabIndex = 70
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Crimson
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Bookman Old Style", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button4.Location = New System.Drawing.Point(978, 132)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(191, 46)
        Me.Button4.TabIndex = 69
        Me.Button4.Text = "FEES"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Crimson
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Bookman Old Style", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.Location = New System.Drawing.Point(646, 132)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(271, 46)
        Me.Button3.TabIndex = 68
        Me.Button3.Text = "EMPLOYEES "
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Crimson
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Bookman Old Style", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Location = New System.Drawing.Point(336, 132)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(240, 46)
        Me.Button2.TabIndex = 67
        Me.Button2.Text = "STUDENTS"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Bookman Old Style", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Location = New System.Drawing.Point(83, 132)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 46)
        Me.Button1.TabIndex = 64
        Me.Button1.Text = "ROOMS  "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Crimson
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(1249, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(377, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(636, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMPLOYEE INFORMATION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Crimson
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-55, -4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1343, 105)
        Me.Panel1.TabIndex = 65
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Location = New System.Drawing.Point(-57, 100)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1343, 26)
        Me.Panel2.TabIndex = 66
        '
        'TextEmpId
        '
        Me.TextEmpId.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextEmpId.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEmpId.ForeColor = System.Drawing.Color.DodgerBlue
        Me.TextEmpId.Location = New System.Drawing.Point(259, 266)
        Me.TextEmpId.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextEmpId.Multiline = True
        Me.TextEmpId.Name = "TextEmpId"
        Me.TextEmpId.Size = New System.Drawing.Size(212, 27)
        Me.TextEmpId.TabIndex = 86
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumPurple
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Bookman Old Style", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Wheat
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.OrangeRed
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpIdDataGridViewTextBoxColumn, Me.EmpNameDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn, Me.EmpStatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmployeeBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Bookman Old Style", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.Location = New System.Drawing.Point(514, 269)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Bookman Old Style", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersWidth = 62
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Bookman Old Style", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Red
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(708, 404)
        Me.DataGridView1.TabIndex = 94
        '
        'EmployeeDataSet
        '
        Me.EmployeeDataSet.DataSetName = "EmployeeDataSet"
        Me.EmployeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.EmployeeDataSet
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'EmpIdDataGridViewTextBoxColumn
        '
        Me.EmpIdDataGridViewTextBoxColumn.DataPropertyName = "EmpId"
        Me.EmpIdDataGridViewTextBoxColumn.HeaderText = "EmpId"
        Me.EmpIdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EmpIdDataGridViewTextBoxColumn.Name = "EmpIdDataGridViewTextBoxColumn"
        Me.EmpIdDataGridViewTextBoxColumn.Width = 150
        '
        'EmpNameDataGridViewTextBoxColumn
        '
        Me.EmpNameDataGridViewTextBoxColumn.DataPropertyName = "EmpName"
        Me.EmpNameDataGridViewTextBoxColumn.HeaderText = "EmpName"
        Me.EmpNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EmpNameDataGridViewTextBoxColumn.Name = "EmpNameDataGridViewTextBoxColumn"
        Me.EmpNameDataGridViewTextBoxColumn.Width = 150
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        Me.PhoneNumberDataGridViewTextBoxColumn.Width = 150
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.Width = 150
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "Position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.PositionDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        Me.PositionDataGridViewTextBoxColumn.Width = 150
        '
        'EmpStatusDataGridViewTextBoxColumn
        '
        Me.EmpStatusDataGridViewTextBoxColumn.DataPropertyName = "EmpStatus"
        Me.EmpStatusDataGridViewTextBoxColumn.HeaderText = "EmpStatus"
        Me.EmpStatusDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EmpStatusDataGridViewTextBoxColumn.Name = "EmpStatusDataGridViewTextBoxColumn"
        Me.EmpStatusDataGridViewTextBoxColumn.Width = 150
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1234, 746)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListStatus)
        Me.Controls.Add(Me.ListPosition)
        Me.Controls.Add(Me.TextAddress)
        Me.Controls.Add(Me.TextNumber)
        Me.Controls.Add(Me.TextEmpName)
        Me.Controls.Add(Me.TextEmpId)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Employee"
        Me.Text = "Employee"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListStatus As ListBox
    Friend WithEvents ListPosition As ListBox
    Friend WithEvents TextAddress As TextBox
    Friend WithEvents TextNumber As TextBox
    Friend WithEvents TextEmpName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextEmpId As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EmployeeDataSet As EmployeeDataSet
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As EmployeeDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents EmpIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
