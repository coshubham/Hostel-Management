<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextNumber = New System.Windows.Forms.TextBox()
        Me.ListStatus = New System.Windows.Forms.ListBox()
        Me.TextCollege = New System.Windows.Forms.TextBox()
        Me.TextAddress = New System.Windows.Forms.TextBox()
        Me.TextMotherName = New System.Windows.Forms.TextBox()
        Me.TextFatherName = New System.Windows.Forms.TextBox()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.TextRollNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StudentDataSet = New Hostel_Management.StudentDataSet()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New Hostel_Management.StudentDataSetTableAdapters.StudentTableAdapter()
        Me.StudentRollNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FatherNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotherNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollegeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextNumber
        '
        Me.TextNumber.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextNumber.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNumber.ForeColor = System.Drawing.Color.DodgerBlue
        Me.TextNumber.Location = New System.Drawing.Point(249, 463)
        Me.TextNumber.Multiline = True
        Me.TextNumber.Name = "TextNumber"
        Me.TextNumber.Size = New System.Drawing.Size(160, 26)
        Me.TextNumber.TabIndex = 94
        '
        'ListStatus
        '
        Me.ListStatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListStatus.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListStatus.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.ListStatus.FormattingEnabled = True
        Me.ListStatus.ItemHeight = 21
        Me.ListStatus.Items.AddRange(New Object() {"Living", "Non-Living"})
        Me.ListStatus.Location = New System.Drawing.Point(249, 506)
        Me.ListStatus.Name = "ListStatus"
        Me.ListStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ListStatus.Size = New System.Drawing.Size(160, 25)
        Me.ListStatus.TabIndex = 93
        '
        'TextCollege
        '
        Me.TextCollege.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextCollege.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCollege.ForeColor = System.Drawing.Color.DodgerBlue
        Me.TextCollege.Location = New System.Drawing.Point(249, 421)
        Me.TextCollege.Multiline = True
        Me.TextCollege.Name = "TextCollege"
        Me.TextCollege.Size = New System.Drawing.Size(160, 26)
        Me.TextCollege.TabIndex = 92
        '
        'TextAddress
        '
        Me.TextAddress.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextAddress.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextAddress.ForeColor = System.Drawing.Color.DodgerBlue
        Me.TextAddress.Location = New System.Drawing.Point(249, 372)
        Me.TextAddress.Multiline = True
        Me.TextAddress.Name = "TextAddress"
        Me.TextAddress.Size = New System.Drawing.Size(160, 26)
        Me.TextAddress.TabIndex = 91
        '
        'TextMotherName
        '
        Me.TextMotherName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextMotherName.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextMotherName.ForeColor = System.Drawing.Color.DodgerBlue
        Me.TextMotherName.Location = New System.Drawing.Point(249, 329)
        Me.TextMotherName.Multiline = True
        Me.TextMotherName.Name = "TextMotherName"
        Me.TextMotherName.Size = New System.Drawing.Size(160, 26)
        Me.TextMotherName.TabIndex = 90
        '
        'TextFatherName
        '
        Me.TextFatherName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextFatherName.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFatherName.ForeColor = System.Drawing.Color.DodgerBlue
        Me.TextFatherName.Location = New System.Drawing.Point(249, 287)
        Me.TextFatherName.Multiline = True
        Me.TextFatherName.Name = "TextFatherName"
        Me.TextFatherName.Size = New System.Drawing.Size(160, 26)
        Me.TextFatherName.TabIndex = 89
        '
        'TextName
        '
        Me.TextName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextName.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextName.ForeColor = System.Drawing.Color.DodgerBlue
        Me.TextName.Location = New System.Drawing.Point(249, 243)
        Me.TextName.Multiline = True
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(160, 26)
        Me.TextName.TabIndex = 88
        '
        'TextRollNo
        '
        Me.TextRollNo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextRollNo.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextRollNo.ForeColor = System.Drawing.Color.DodgerBlue
        Me.TextRollNo.Location = New System.Drawing.Point(249, 200)
        Me.TextRollNo.Multiline = True
        Me.TextRollNo.Name = "TextRollNo"
        Me.TextRollNo.Size = New System.Drawing.Size(160, 26)
        Me.TextRollNo.TabIndex = 87
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Crimson
        Me.Label11.Location = New System.Drawing.Point(36, 505)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(202, 24)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "STUDENT STATUS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Crimson
        Me.Label10.Location = New System.Drawing.Point(36, 464)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(176, 24)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "ROOM NUMBER"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Crimson
        Me.Label9.Location = New System.Drawing.Point(36, 420)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 24)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "COLLEGE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Crimson
        Me.Label8.Location = New System.Drawing.Point(36, 373)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 24)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "ADDRESS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Crimson
        Me.Label7.Location = New System.Drawing.Point(36, 328)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 24)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "MOTHER NAME"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Crimson
        Me.Label6.Location = New System.Drawing.Point(36, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 24)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "FATHER NAME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Crimson
        Me.Label5.Location = New System.Drawing.Point(36, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 24)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "STUDENT NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(36, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 24)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "STUDENT ROLLNO"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Location = New System.Drawing.Point(1, 153)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1237, 25)
        Me.Panel3.TabIndex = 78
        '
        'Button8
        '
        Me.Button8.CausesValidation = False
        Me.Button8.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button8.ForeColor = System.Drawing.Color.Crimson
        Me.Button8.Location = New System.Drawing.Point(138, 636)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(108, 35)
        Me.Button8.TabIndex = 77
        Me.Button8.Text = "BACK"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.CausesValidation = False
        Me.Button7.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button7.ForeColor = System.Drawing.Color.Crimson
        Me.Button7.Location = New System.Drawing.Point(271, 578)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(110, 35)
        Me.Button7.TabIndex = 76
        Me.Button7.Text = "DELETE"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.CausesValidation = False
        Me.Button6.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button6.ForeColor = System.Drawing.Color.Crimson
        Me.Button6.Location = New System.Drawing.Point(133, 578)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(111, 35)
        Me.Button6.TabIndex = 75
        Me.Button6.Text = "UPDATE"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.CausesValidation = False
        Me.Button5.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.ForeColor = System.Drawing.Color.Crimson
        Me.Button5.Location = New System.Drawing.Point(40, 578)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(74, 35)
        Me.Button5.TabIndex = 74
        Me.Button5.Text = "ADD"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(810, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 30)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "STUDENT LIST"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Crimson
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 710)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1239, 29)
        Me.Panel4.TabIndex = 71
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Crimson
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Bookman Old Style", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button4.Location = New System.Drawing.Point(1023, 104)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(149, 44)
        Me.Button4.TabIndex = 70
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
        Me.Button3.Location = New System.Drawing.Point(706, 104)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(212, 44)
        Me.Button3.TabIndex = 69
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
        Me.Button2.Location = New System.Drawing.Point(388, 105)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(209, 44)
        Me.Button2.TabIndex = 68
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
        Me.Button1.Location = New System.Drawing.Point(157, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 44)
        Me.Button1.TabIndex = 65
        Me.Button1.Text = "ROOMS  "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Crimson
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(1222, 9)
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
        Me.Label1.Location = New System.Drawing.Point(376, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(600, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STUDENT INFORMATION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Crimson
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-14, -6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1275, 81)
        Me.Panel1.TabIndex = 66
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Location = New System.Drawing.Point(1, 76)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1237, 25)
        Me.Panel2.TabIndex = 67
        '
        'DataGridView1
        '
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.MediumPurple
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Bookman Old Style", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Wheat
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.OrangeRed
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentRollNoDataGridViewTextBoxColumn, Me.StudentNameDataGridViewTextBoxColumn, Me.FatherNameDataGridViewTextBoxColumn, Me.MotherNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.CollegeDataGridViewTextBoxColumn, Me.RoomNumberDataGridViewTextBoxColumn, Me.StudentStatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentBindingSource
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Bookman Old Style", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridView1.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.Location = New System.Drawing.Point(429, 226)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Bookman Old Style", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridView1.RowHeadersWidth = 62
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Bookman Old Style", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Red
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(798, 404)
        Me.DataGridView1.TabIndex = 95
        '
        'StudentDataSet
        '
        Me.StudentDataSet.DataSetName = "StudentDataSet"
        Me.StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.StudentDataSet
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'StudentRollNoDataGridViewTextBoxColumn
        '
        Me.StudentRollNoDataGridViewTextBoxColumn.DataPropertyName = "StudentRollNo"
        Me.StudentRollNoDataGridViewTextBoxColumn.HeaderText = "StudentRollNo"
        Me.StudentRollNoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StudentRollNoDataGridViewTextBoxColumn.Name = "StudentRollNoDataGridViewTextBoxColumn"
        Me.StudentRollNoDataGridViewTextBoxColumn.Width = 150
        '
        'StudentNameDataGridViewTextBoxColumn
        '
        Me.StudentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName"
        Me.StudentNameDataGridViewTextBoxColumn.HeaderText = "StudentName"
        Me.StudentNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StudentNameDataGridViewTextBoxColumn.Name = "StudentNameDataGridViewTextBoxColumn"
        Me.StudentNameDataGridViewTextBoxColumn.Width = 150
        '
        'FatherNameDataGridViewTextBoxColumn
        '
        Me.FatherNameDataGridViewTextBoxColumn.DataPropertyName = "FatherName"
        Me.FatherNameDataGridViewTextBoxColumn.HeaderText = "FatherName"
        Me.FatherNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FatherNameDataGridViewTextBoxColumn.Name = "FatherNameDataGridViewTextBoxColumn"
        Me.FatherNameDataGridViewTextBoxColumn.Width = 150
        '
        'MotherNameDataGridViewTextBoxColumn
        '
        Me.MotherNameDataGridViewTextBoxColumn.DataPropertyName = "MotherName"
        Me.MotherNameDataGridViewTextBoxColumn.HeaderText = "MotherName"
        Me.MotherNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MotherNameDataGridViewTextBoxColumn.Name = "MotherNameDataGridViewTextBoxColumn"
        Me.MotherNameDataGridViewTextBoxColumn.Width = 150
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.Width = 150
        '
        'CollegeDataGridViewTextBoxColumn
        '
        Me.CollegeDataGridViewTextBoxColumn.DataPropertyName = "College"
        Me.CollegeDataGridViewTextBoxColumn.HeaderText = "College"
        Me.CollegeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CollegeDataGridViewTextBoxColumn.Name = "CollegeDataGridViewTextBoxColumn"
        Me.CollegeDataGridViewTextBoxColumn.Width = 150
        '
        'RoomNumberDataGridViewTextBoxColumn
        '
        Me.RoomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber"
        Me.RoomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber"
        Me.RoomNumberDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RoomNumberDataGridViewTextBoxColumn.Name = "RoomNumberDataGridViewTextBoxColumn"
        Me.RoomNumberDataGridViewTextBoxColumn.Width = 150
        '
        'StudentStatusDataGridViewTextBoxColumn
        '
        Me.StudentStatusDataGridViewTextBoxColumn.DataPropertyName = "StudentStatus"
        Me.StudentStatusDataGridViewTextBoxColumn.HeaderText = "StudentStatus"
        Me.StudentStatusDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StudentStatusDataGridViewTextBoxColumn.Name = "StudentStatusDataGridViewTextBoxColumn"
        Me.StudentStatusDataGridViewTextBoxColumn.Width = 150
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1239, 739)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextNumber)
        Me.Controls.Add(Me.ListStatus)
        Me.Controls.Add(Me.TextCollege)
        Me.Controls.Add(Me.TextAddress)
        Me.Controls.Add(Me.TextMotherName)
        Me.Controls.Add(Me.TextFatherName)
        Me.Controls.Add(Me.TextName)
        Me.Controls.Add(Me.TextRollNo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
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
        Me.Name = "Student"
        Me.Text = "Student"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextNumber As TextBox
    Friend WithEvents ListStatus As ListBox
    Friend WithEvents TextCollege As TextBox
    Friend WithEvents TextAddress As TextBox
    Friend WithEvents TextMotherName As TextBox
    Friend WithEvents TextFatherName As TextBox
    Friend WithEvents TextName As TextBox
    Friend WithEvents TextRollNo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StudentDataSet As StudentDataSet
    Friend WithEvents StudentRollNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FatherNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MotherNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CollegeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As StudentDataSetTableAdapters.StudentTableAdapter
End Class
