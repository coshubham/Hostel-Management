Imports System.Data.SqlClient
Public Class Employee
    Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Employee;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)
    Dim cmd As SqlCommand
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Hostel_Information.Show()
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Rooms.Show()
        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Student.Show()
        Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Fees.Show()
        Hide()
    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.EmployeeDataSet.Employee)
        connection.Open()
        display()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'add button
        TextEmpId.Enabled = True
        TextEmpId.Focus()
        insertNew()
        clear()
        display()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'coding on update button
        Update_Employee()
        display()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'coding on delete
        delEmployee()
        display()
    End Sub

    Private Sub clear()
        TextEmpId.Text = ""
        TextEmpName.Text = ""
        TextNumber.Text = ""
        TextAddress.Text = ""
        ListPosition.Text = ""
        ListStatus.Text = ""
    End Sub
    Private Sub insertNew()
        cmd = New SqlCommand("insert into Employee
     values(@EmpId,@EmpName,@PhoneNumber,@Address,@Position,@EmpStatus)", connection)
        cmd.Parameters.AddWithValue("@EmpId", TextEmpId.Text.Trim)
        cmd.Parameters.AddWithValue("@EmpName", TextEmpName.Text.Trim)
        cmd.Parameters.AddWithValue("@PhoneNumber", TextNumber.Text.Trim)
        cmd.Parameters.AddWithValue("@Address", TextAddress.Text.Trim)
        cmd.Parameters.AddWithValue("@Position", ListPosition.Text.Trim)
        cmd.Parameters.AddWithValue("@EmpStatus", ListStatus.Text.Trim)
        cmd.ExecuteNonQuery()
        MsgBox("Record Add Successfully")
    End Sub

    Private Sub delEmployee()
        Dim EmpId1 As Integer
        EmpId1 = InputBox("Enter The Recocrd To Delete")
        cmd = New SqlCommand("delete from Employee where EmpId=@EmpId", connection)
        cmd.Parameters.AddWithValue("@EmpId", EmpId1)
        cmd.ExecuteNonQuery()
        MsgBox("Record Delete Successfully")
    End Sub

    Public Sub display()
        cmd = New SqlCommand("select * from Employee", connection)
        cmd.ExecuteNonQuery()
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Employeeds")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Employeeds"

    End Sub

    Public Sub update_Employee()
        cmd = New SqlCommand("Update Employee set EmpName=@EmpName,PhoneNumber=@PhoneNumber,Address=@Address,Position=@Position,EmpStatus=@EmpStatus where EmpId=@EmpId", connection)
        cmd.Parameters.AddWithValue("@EmpId", TextEmpId.Text.Trim)
        cmd.Parameters.AddWithValue("@EmpName", TextEmpName.Text.Trim)
        cmd.Parameters.AddWithValue("@PhoneNumber", TextNumber.Text.Trim)
        cmd.Parameters.AddWithValue("@Address", TextAddress.Text.Trim)
        cmd.Parameters.AddWithValue("@Position", ListPosition.Text.Trim)
        cmd.Parameters.AddWithValue("@EmpStatus", ListStatus.Text.Trim)
        cmd.ExecuteNonQuery()
        MsgBox("Record Update Successfully")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'coding on cell click event
        'datagrid view
        TextEmpId.Enabled = False
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        If i = DataGridView1.RowCount - 1 Then
            TextEmpId.Text = DataGridView1.Item(0, i).Value
            TextEmpName.Text = DataGridView1.Item(1, i).Value
            TextNumber.Text = DataGridView1.Item(2, i).Value
            TextAddress.Text = DataGridView1.Item(3, i).Value
            ListPosition.Text = DataGridView1.Item(4, i).Value
            ListStatus.Text = DataGridView1.Item(5, i).Value
            MsgBox("passed Last Record")
        Else
            TextEmpId.Text = DataGridView1.Item(0, i).Value
            TextEmpName.Text = DataGridView1.Item(1, i).Value
            TextNumber.Text = DataGridView1.Item(2, i).Value
            TextAddress.Text = DataGridView1.Item(3, i).Value
            ListPosition.Text = DataGridView1.Item(4, i).Value
            ListStatus.Text = DataGridView1.Item(5, i).Value
        End If
    End Sub
End Class