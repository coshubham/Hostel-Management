Imports System.Data.SqlClient
Public Class Rooms
    Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Rooms;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)
    Dim cmd As SqlCommand
    Private Sub Rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RoomsDataSet.Rooms' table. You can move, or remove it, as needed.
        Me.RoomsTableAdapter.Fill(Me.RoomsDataSet.Rooms)
        connection.Open()
        display()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Textnumber.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Application.Exit()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Hostel_Information.Show()
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Fees.Show()
        Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'button add
        Textnumber.Enabled = True
        Textnumber.Focus()
        insertNew()
        clear()
        display()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'coding on delete
        delRooms()
        display()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'coding on update button
        Update_Rooms()
        display()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub clear()
        Textnumber.Text = ""
        ListStatus.Text = ""
        ListBooked.Text = ""
    End Sub

    Private Sub insertNew()
        cmd = New SqlCommand("insert into Rooms
     values(@RoomNumber,@RoomStatus,@Booked)", connection)
        cmd.Parameters.AddWithValue("@RoomNumber", Textnumber.Text.Trim)
        cmd.Parameters.AddWithValue("@RoomStatus", ListStatus.Text.Trim)
        cmd.Parameters.AddWithValue("@Booked", ListBooked.Text.Trim)
        cmd.ExecuteNonQuery()
        MsgBox("Record Add successfully")
    End Sub

    Private Sub delRooms()
        Dim RoomNumber1 As Integer
        RoomNumber1 = InputBox("Enter the recocrd to delete")
        cmd = New SqlCommand("delete from Rooms where RoomNumber=@RoomNumber", connection)
        cmd.Parameters.AddWithValue("@RoomNumber", RoomNumber1)
        cmd.ExecuteNonQuery()
        MsgBox("Record Delete Successfully")
    End Sub
    Public Sub display()
        cmd = New SqlCommand("select * from Rooms", connection)
        cmd.ExecuteNonQuery()
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Roomsds")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Roomsds"

    End Sub
    Public Sub update_Rooms()
        cmd = New SqlCommand("Update Rooms set RoomStatus=@RoomStatus,Booked=@Booked where RoomNumber=@RoomNumber", connection)
        cmd.Parameters.AddWithValue("@RoomNumber", Textnumber.Text.Trim)
        cmd.Parameters.AddWithValue("@RoomStatus", ListStatus.Text.Trim)
        cmd.Parameters.AddWithValue("@Booked", ListBooked.Text.Trim)
        cmd.ExecuteNonQuery()
        MsgBox("Record Update Successfully")
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        'coding on cell click event
        'datagrid view
        Textnumber.Enabled = False
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        If i = DataGridView1.RowCount - 1 Then
            Textnumber.Text = DataGridView1.Item(0, i).Value
            ListStatus.Text = DataGridView1.Item(1, i).Value
            ListBooked.Text = DataGridView1.Item(2, i).Value
            MsgBox("passed last record")
        Else
            Textnumber.Text = DataGridView1.Item(0, i).Value
            ListStatus.Text = DataGridView1.Item(1, i).Value
            ListBooked.Text = DataGridView1.Item(2, i).Value
        End If
    End Sub
End Class