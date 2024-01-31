Imports System.Data.SqlClient
Public Class Fees
    Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Fees;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)
    Dim cmd As SqlCommand
    Private Sub Fees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FeesDataSet3.Fees' table. You can move, or remove it, as needed.
        Me.FeesTableAdapter1.Fill(Me.FeesDataSet3.Fees)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Student.Show()
        Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Employee.Show()
        Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'button add
        TextPaymentId.Enabled = True
        TextPaymentId.Focus()
        insertNew()
        clear()
        display()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'coding on delete
        delFees()
        display()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'coding on update button
        Update_Fees()
        display()
    End Sub

    Private Sub clear()
        TextPaymentId.Text = ""
        TextRollNo.Text = ""
        TextName.Text = ""
        TextNumber.Text = ""
        DateTimePicker1.Text = ""
        TextAmount.Text = ""
    End Sub

    Private Sub insertNew()
        cmd = New SqlCommand("insert into Fees
     values(@PaymentId,@StudentRollNo,@StudentName,@RoomNumber,@Month,@Amount)", connection)

        cmd.Parameters.AddWithValue("@PaymentId", TextPaymentId.Text.Trim)
        cmd.Parameters.AddWithValue("@StudentRollNo", TextRollNo.Text.Trim)
        cmd.Parameters.AddWithValue("@StudentName", TextName.Text.Trim)
        cmd.Parameters.AddWithValue("@RoomNumber", TextNumber.Text.Trim)
        cmd.Parameters.AddWithValue("@Month", DateTimePicker1.Text.Trim)
        cmd.Parameters.AddWithValue("@Amount", TextAmount.Text.Trim)
        cmd.ExecuteNonQuery()
        MsgBox("Record Add Successfully")
    End Sub

    Private Sub delFees()
        Dim StudentRollNo1 As Integer
        StudentRollNo1 = InputBox("Enter The Recocrd To Delete")
        cmd = New SqlCommand("delete from Fees where StudentRollNo=@StudentRollNo", connection)
        cmd.Parameters.AddWithValue("@StudentRollNo", StudentRollNo1)
        cmd.ExecuteNonQuery()
        MsgBox("Record Delete Successfully")
    End Sub

    Public Sub display()
        cmd = New SqlCommand("select * from Fees", connection)
        cmd.ExecuteNonQuery()
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Feesds")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Feesds"
    End Sub

    Public Sub update_Fees()
        cmd = New SqlCommand("Update Fees set PaymentId=@PaymentId,StudentName=@StudentName,RoomNumber=@RoomNumber,Month=@Month,Amount=@Amount where StudentRollNo=@StudentRollNo", connection)
        cmd.Parameters.AddWithValue("@PaymentId", TextPaymentId.Text.Trim)
        cmd.Parameters.AddWithValue("@StudentRollNo", TextRollNo.Text.Trim)
        cmd.Parameters.AddWithValue("@StudentName", TextName.Text.Trim)
        cmd.Parameters.AddWithValue("@RoomNumber", TextNumber.Text.Trim)
        cmd.Parameters.AddWithValue("@Month", DateTimePicker1.Text.Trim)
        cmd.Parameters.AddWithValue("@Amount", TextAmount.Text.Trim)
        cmd.ExecuteNonQuery()
        MsgBox("Record Update Successfully")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'coding on cell click event
        'datagrid view
        TextPaymentId.Enabled = False
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        If i = DataGridView1.RowCount - 1 Then
            TextPaymentId.Text = DataGridView1.Item(0, i).Value
            TextRollNo.Text = DataGridView1.Item(1, i).Value
            TextName.Text = DataGridView1.Item(2, i).Value
            TextNumber.Text = DataGridView1.Item(3, i).Value
            DateTimePicker1.Text = DataGridView1.Item(4, i).Value
            TextAmount.Text = DataGridView1.Item(5, i).Value

            MsgBox("passed last record")
        Else
            TextPaymentId.Text = DataGridView1.Item(0, i).Value
            TextRollNo.Text = DataGridView1.Item(1, i).Value
            TextName.Text = DataGridView1.Item(2, i).Value
            TextNumber.Text = DataGridView1.Item(3, i).Value
            DateTimePicker1.Text = DataGridView1.Item(4, i).Value
            TextAmount.Text = DataGridView1.Item(5, i).Value
        End If
    End Sub
End Class