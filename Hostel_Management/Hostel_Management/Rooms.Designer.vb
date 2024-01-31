<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Rooms
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Textnumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListStatus = New System.Windows.Forms.ListBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.ListBooked = New System.Windows.Forms.ListBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RoomsDataSet = New Hostel_Management.RoomsDataSet()
        Me.RoomsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoomsTableAdapter = New Hostel_Management.RoomsDataSetTableAdapters.RoomsTableAdapter()
        Me.RoomNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Location = New System.Drawing.Point(-47, 181)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1349, 25)
        Me.Panel3.TabIndex = 14
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Crimson
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Bookman Old Style", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button4.Location = New System.Drawing.Point(1044, 130)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(143, 44)
        Me.Button4.TabIndex = 13
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
        Me.Button3.Location = New System.Drawing.Point(700, 130)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(203, 44)
        Me.Button3.TabIndex = 12
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
        Me.Button2.Location = New System.Drawing.Point(371, 130)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 44)
        Me.Button2.TabIndex = 11
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
        Me.Button1.Location = New System.Drawing.Point(92, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 44)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "ROOMS  "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Location = New System.Drawing.Point(-47, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1349, 25)
        Me.Panel2.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Crimson
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-46, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1349, 100)
        Me.Panel1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Crimson
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(1261, 3)
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
        Me.Label1.Location = New System.Drawing.Point(414, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(550, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ROOMS INFORMATION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Crimson
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(-46, 1018)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1349, 43)
        Me.FlowLayoutPanel1.TabIndex = 9
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Crimson
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 685)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1256, 38)
        Me.Panel4.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(790, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 30)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "ROOMS LIST"
        '
        'Textnumber
        '
        Me.Textnumber.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Textnumber.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textnumber.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Textnumber.Location = New System.Drawing.Point(226, 301)
        Me.Textnumber.Multiline = True
        Me.Textnumber.Name = "Textnumber"
        Me.Textnumber.Size = New System.Drawing.Size(160, 26)
        Me.Textnumber.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(21, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 24)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "ROOM NUMBER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Crimson
        Me.Label5.Location = New System.Drawing.Point(21, 387)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 24)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "ROOM STATUS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Crimson
        Me.Label6.Location = New System.Drawing.Point(21, 457)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 24)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "BOOKED"
        '
        'ListStatus
        '
        Me.ListStatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListStatus.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListStatus.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.ListStatus.FormattingEnabled = True
        Me.ListStatus.ItemHeight = 21
        Me.ListStatus.Items.AddRange(New Object() {"ACTIVE", "NON-ACTIVE"})
        Me.ListStatus.Location = New System.Drawing.Point(227, 387)
        Me.ListStatus.Name = "ListStatus"
        Me.ListStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ListStatus.Size = New System.Drawing.Size(160, 25)
        Me.ListStatus.TabIndex = 25
        '
        'Button5
        '
        Me.Button5.CausesValidation = False
        Me.Button5.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.ForeColor = System.Drawing.Color.Crimson
        Me.Button5.Location = New System.Drawing.Point(34, 567)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(109, 35)
        Me.Button5.TabIndex = 30
        Me.Button5.Text = "ADD"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.CausesValidation = False
        Me.Button6.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button6.ForeColor = System.Drawing.Color.Crimson
        Me.Button6.Location = New System.Drawing.Point(197, 567)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(109, 35)
        Me.Button6.TabIndex = 31
        Me.Button6.Text = "UPDATE"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.CausesValidation = False
        Me.Button7.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button7.ForeColor = System.Drawing.Color.Crimson
        Me.Button7.Location = New System.Drawing.Point(358, 567)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(109, 35)
        Me.Button7.TabIndex = 32
        Me.Button7.Text = "DELETE"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.CausesValidation = False
        Me.Button8.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button8.ForeColor = System.Drawing.Color.Crimson
        Me.Button8.Location = New System.Drawing.Point(197, 622)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(109, 35)
        Me.Button8.TabIndex = 33
        Me.Button8.Text = "BACK"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'ListBooked
        '
        Me.ListBooked.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListBooked.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBooked.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.ListBooked.FormattingEnabled = True
        Me.ListBooked.ItemHeight = 21
        Me.ListBooked.Items.AddRange(New Object() {"YES", "NO"})
        Me.ListBooked.Location = New System.Drawing.Point(226, 457)
        Me.ListBooked.Name = "ListBooked"
        Me.ListBooked.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ListBooked.Size = New System.Drawing.Size(160, 25)
        Me.ListBooked.TabIndex = 34
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoomNumberDataGridViewTextBoxColumn, Me.RoomStatusDataGridViewTextBoxColumn, Me.BookedDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RoomsBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Bookman Old Style", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.Location = New System.Drawing.Point(495, 273)
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
        Me.DataGridView1.TabIndex = 95
        '
        'RoomsDataSet
        '
        Me.RoomsDataSet.DataSetName = "RoomsDataSet"
        Me.RoomsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RoomsBindingSource
        '
        Me.RoomsBindingSource.DataMember = "Rooms"
        Me.RoomsBindingSource.DataSource = Me.RoomsDataSet
        '
        'RoomsTableAdapter
        '
        Me.RoomsTableAdapter.ClearBeforeFill = True
        '
        'RoomNumberDataGridViewTextBoxColumn
        '
        Me.RoomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber"
        Me.RoomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber"
        Me.RoomNumberDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RoomNumberDataGridViewTextBoxColumn.Name = "RoomNumberDataGridViewTextBoxColumn"
        Me.RoomNumberDataGridViewTextBoxColumn.Width = 150
        '
        'RoomStatusDataGridViewTextBoxColumn
        '
        Me.RoomStatusDataGridViewTextBoxColumn.DataPropertyName = "RoomStatus"
        Me.RoomStatusDataGridViewTextBoxColumn.HeaderText = "RoomStatus"
        Me.RoomStatusDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RoomStatusDataGridViewTextBoxColumn.Name = "RoomStatusDataGridViewTextBoxColumn"
        Me.RoomStatusDataGridViewTextBoxColumn.Width = 150
        '
        'BookedDataGridViewTextBoxColumn
        '
        Me.BookedDataGridViewTextBoxColumn.DataPropertyName = "Booked"
        Me.BookedDataGridViewTextBoxColumn.HeaderText = "Booked"
        Me.BookedDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.BookedDataGridViewTextBoxColumn.Name = "BookedDataGridViewTextBoxColumn"
        Me.BookedDataGridViewTextBoxColumn.Width = 150
        '
        'Rooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1256, 723)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListBooked)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.ListStatus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Textnumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Rooms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Rooms"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Textnumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ListStatus As ListBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents ListBooked As ListBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RoomsDataSet As RoomsDataSet
    Friend WithEvents RoomsBindingSource As BindingSource
    Friend WithEvents RoomsTableAdapter As RoomsDataSetTableAdapters.RoomsTableAdapter
    Friend WithEvents RoomNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
