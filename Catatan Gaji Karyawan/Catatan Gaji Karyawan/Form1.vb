Public Class Form1
    Dim dt As New DataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt.Columns.Add("Kode Karyawan", GetType(String))
        dt.Columns.Add("Nama Karyawan", GetType(String))
        dt.Columns.Add("Jabatan Karyawan", GetType(String))
        dt.Columns.Add("Gaji Karyawan", GetType(String))
        dt.Columns.Add("Tunjangan Karyawan", GetType(String))
        dt.Columns.Add("Pajak Karyawan", GetType(String))
        dt.Columns.Add("Gaji Bersih", GetType(String))
        ComboBox1.Items.Add("001")
        ComboBox1.Items.Add("002")
        ComboBox1.Items.Add("003")
        ComboBox1.Items.Add("004")
        ComboBox1.Items.Add("005")
        ComboBox2.Items.Add("Admin")
        ComboBox2.Items.Add("Leader")
        ComboBox2.Items.Add("Helper")
        ComboBox2.Items.Add("Kepala Gudang")
        ComboBox2.Items.Add("Security")
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "Admin" : TextBox2.Text = 3000000
            Case "Leader" : TextBox2.Text = 3000000
            Case "Helper" : TextBox2.Text = 1500000
            Case "Kepala Gudang" : TextBox2.Text = 5000000
            Case "Security" : TextBox2.Text = 2000000
        End Select
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "001" : TextBox1.Text = "Tommy"
            Case "002" : TextBox1.Text = "Chandra"
            Case "003" : TextBox1.Text = "Fernando"
            Case "004" : TextBox1.Text = "Junius"
            Case "005" : TextBox1.Text = "Nurfitra"
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        dt.Rows.Add(TextBox1.Text, ComboBox1.Text, TextBox2.Text, ComboBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
        DataGridView1.DataSource = dt
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox5.Text = Val(TextBox2.Text) + Val(TextBox3.Text) - Val(TextBox4.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
