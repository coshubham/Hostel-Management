Imports System.Data.SqlClient
Public Class Student
    Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Student;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)
    Dim cmd As SqlCommand
    Private Sub Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.StudentDataSet.Student)
        connection.Open()
        display()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Hostel_Information.Show()
        Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Rooms.Show()
        Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Employee.Show()
        Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Fees.Show()
        Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'button add
        TextRollNo.Enabled = True
        TextRollNo.Focus()
        insertNew()
        clear()
        display()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'coding on update button
        Update_Student()
        display()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'coding on delete
        delStudent()
        display()
    End Sub
    Private Sub clear()
        TextRollNo.Text = ""
        TextName.Text = ""
        TextFatherName.Text = ""
        TextMotherName.Text = ""
        TextAddress.Text = ""
        TextCollege.Text = ""
        TextNumber.Text = ""
        ListStatus.Text = ""
    End Sub

    Private Sub insertNew()
        cmd = New SqlCommand("insert into Student
     values(@StudentRollNo,@StudentName,@FatherName,@MotherName,@Address,@College,@RoomNumber,@StudentStatus)", connection)
        cmd.Parameters.AddWithValue("@StudentRollNo", TextRollNo.Text.Trim)
        cmd.Parameters.AddWithValue("@StudentName", TextName.Text.Trim)
        cmd.Parameters.AddWithValue("@FatherName", TextFatherName.Text.Trim)
        cmd.Parameters.AddWithValue("@MotherName", TextMotherName.Text.Trim)
        cmd.Parameters.AddWithValue("@Address", TextAddress.Text.Trim)
        cmd.Parameters.AddWithValue("@College", TextCollege.Text.Trim)
        cmd.Parameters.AddWithValue("@RoomNumber", TextNumber.Text.Trim)
        cmd.Parameters.AddWithValue("@StudentStatus", ListStatus.Text.Trim)
        cmd.ExecuteNonQuery()
        MsgBox("Record Add Successfully")
    End Sub

    Private Sub delStudent()
        Dim StudentRollNo1 As Integer
        StudentRollNo1 = InputBox("Enter the recocrd to delete")
        cmd = New SqlCommand("delete from Student where StudentRollNo=@StudentRollNo", connection)
        cmd.Parameters.AddWithValue("@StudentRollNo", StudentRollNo1)
        cmd.ExecuteNonQuery()
        MsgBox("Record Delete Successfully")
    End Sub

    Public Sub display()
        cmd = New SqlCommand("select * from Student", connection)
        cmd.ExecuteNonQuery()
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Studentds")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Studentds"

    End Sub

    Public Sub update_student()
        cmd = New SqlCommand("Update Student set StudentName=@StudentName,FatherName=@FatherName,MotherName=@MotherName,Address=@Address,College=@College,RoomNumber=@RoomNumber,StudentStatus=@StudentStatus where StudentRollNo=@StudentRollNo", connection)
        cmd.Parameters.AddWithValue("@StudentRollNo", TextRollNo.Text.Trim)
        cmd.Parameters.AddWithValue("@StudentName", TextName.Text.Trim)
        cmd.Parameters.AddWithValue("@FatherName", TextFatherName.Text.Trim)
        cmd.Parameters.AddWithValue("@MotherName", TextMotherName.Text.Trim)
        cmd.Parameters.AddWithValue("@Address", TextAddress.Text.Trim)
        cmd.Parameters.AddWithValue("@College", TextCollege.Text.Trim)
        cmd.Parameters.AddWithValue("@RoomNumber", TextNumber.Text.Trim)
        cmd.Parameters.AddWithValue("@StudentStatus", ListStatus.Text.Trim)
        cmd.ExecuteNonQuery()
        MsgBox("Record Update Successfully")
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'coding on cell click event
        'datagrid view
        TextRollNo.Enabled = False
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        If i = DataGridView1.RowCount - 1 Then
            TextRollNo.Text = DataGridView1.Item(0, i).Value
            TextName.Text = DataGridView1.Item(1, i).Value
            TextFatherName.Text = DataGridView1.Item(2, i).Value
            TextMotherName.Text = DataGridView1.Item(3, i).Value
            TextAddress.Text = DataGridView1.Item(4, i).Value
            TextCollege.Text = DataGridView1.Item(5, i).Value
            TextNumber.Text = DataGridView1.Item(6, i).Value
            ListStatus.Text = DataGridView1.Item(7, i).Value
            MsgBox("passed Last Record")
        Else
            TextRollNo.Text = DataGridView1.Item(0, i).Value
            TextName.Text = DataGridView1.Item(1, i).Value
            TextFatherName.Text = DataGridView1.Item(2, i).Value
            TextMotherName.Text = DataGridView1.Item(3, i).Value
            TextAddress.Text = DataGridView1.Item(4, i).Value
            TextCollege.Text = DataGridView1.Item(5, i).Value
            TextNumber.Text = DataGridView1.Item(6, i).Value
            ListStatus.Text = DataGridView1.Item(7, i).Value
        End If
    End Sub
End Class