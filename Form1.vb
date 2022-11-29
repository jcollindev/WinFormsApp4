
Imports System.Data.OleDb
Public Class Form1



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbcereals.Items.Add("maize")
        cmbcereals.Items.Add("millet")
        cmbcereals.Items.Add("sorghum")
        cmbcereals.Items.Add("flour")
        cmbcereals.Items.Add("barley")
        cmbvegetables.Items.Add("sukumawiki")
        cmbvegetables.Items.Add("spinach")
        cmbvegetables.Items.Add("cabbages")
        cmbvegetables.Items.Add("tomatoes")
        cmbvegetables.Items.Add("onions")
        cmbfruits.Items.Add("mango")
        cmbfruits.Items.Add("orange")
        cmbfruits.Items.Add("guava")
        cmbfruits.Items.Add("watermelon")
        cmbfruits.Items.Add("apple")
        ComboBox1.Items.Add("cash")
        ComboBox1.Items.Add("mpesa")
        ComboBox1.Items.Add("cheque")
    End Sub

    Private Sub cmbcereals_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcereals.SelectedIndexChanged
        Dim stquantity As String
        Dim stprice As String
        stquantity = TextBox1.Text
        stprice = TextBox2.Text
        Try

            If cmbcereals.Text = "maize" Then
                TextBox2.Text = 200 * stquantity

            ElseIf (cmbcereals.Text = "barley") Then
                TextBox2.Text = 100 * stquantity
            ElseIf (cmbcereals.Text = "sorghum") Then
                TextBox2.Text = 150 * stquantity
            ElseIf (cmbcereals.Text = "flour") Then
                TextBox2.Text = 200 * stquantity
            ElseIf (cmbcereals.Text = "millet") Then
                TextBox2.Text = 50 * stquantity

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub cmbvegetables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbvegetables.SelectedIndexChanged
        Dim stvquantity As String
        Dim stvprice As String
        stvquantity = TextBox3.Text
        stvprice = TextBox4.Text
        Try

            If cmbvegetables.Text = "sukumawiki" Then
                TextBox4.Text = 5 * stvquantity

            ElseIf (cmbvegetables.Text = "spinach") Then
                TextBox4.Text = 10 * stvquantity
            ElseIf (cmbvegetables.Text = "cabbages") Then
                TextBox4.Text = 50 * stvquantity
            ElseIf (cmbvegetables.Text = "tomatoes") Then
                TextBox4.Text = 10 * stvquantity
            ElseIf (cmbvegetables.Text = "onions") Then
                TextBox4.Text = 5 * stvquantity

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub cmbfruits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbfruits.SelectedIndexChanged
        Dim stfquantity As String
        Dim stfprice As String
        stfquantity = TextBox5.Text
        stfprice = TextBox6.Text
        Try

            If cmbfruits.Text = "mango" Then
                TextBox6.Text = 5 * stfquantity

            ElseIf (cmbfruits.Text = "apple") Then
                TextBox6.Text = 50 * stfquantity
            ElseIf (cmbfruits.Text = "watermelon") Then
                TextBox6.Text = 100 * stfquantity
            ElseIf (cmbfruits.Text = "guava") Then
                TextBox6.Text = 10 * stfquantity
            ElseIf (cmbfruits.Text = "orange") Then
                TextBox6.Text = 5 * stfquantity

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iexit As DialogResult
        iexit = MessageBox.Show("Are you sure you want to exit", "KILIMANI SUPERMARKET", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iexit = DialogResult.Yes Then
            Application.Exit()

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sttotal As String
        sttotal = TextBox7.Text
        TextBox7.Text = (TextBox2.Text) - -(TextBox4.Text) - -(TextBox6.Text)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.Rows.Add(cmbcereals.Text, TextBox1.Text, TextBox2.Text)
        DataGridView1.Rows.Add(cmbvegetables.Text, TextBox3.Text, TextBox4.Text)
        DataGridView1.Rows.Add(cmbfruits.Text, TextBox5.Text, TextBox6.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim stid As String
        Dim stpay As String
        Dim stamount As String
        stid = TextBox8.Text
        stpay = ComboBox1.Text
        stamount = TextBox10.Text


    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DataGridView2.Rows.Add(TextBox8.Text, ComboBox1.Text, TextBox10.Text)

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub


    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HP\OneDrive\Documents\KILIMANI.accdb")
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        con.Open()
        Dim query As String
        query = "insert into Items values(" & TextBox9.Text & ",'" & TextBox12.Text & "'," & TextBox11.Text & ",'" & ComboBox2.SelectedText.ToString() & "'," & TextBox14.Text & ")"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, con)
        cmd.ExecuteNonQuery()
        MsgBox("Product Added Succesfully")
        con.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        DataGridView3.Rows.Add(TextBox9.Text, TextBox12.Text, TextBox11.Text, ComboBox2.Text, TextBox14.Text)

    End Sub
End Class
