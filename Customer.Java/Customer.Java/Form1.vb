Imports System.IO
Public Class customer
    Dim records(63) As CustomerInfo
    Dim i As Integer
    Private Structure CustomerInfo
        Public CustomerFirstName As String
        Public CustomerSurname As String
        Public CustomerHolidayLocation As String
        Public CustomerEmail As String              'creating a data structure to store the inputted data
    End Structure

    Private Sub customer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Dir$("Customer.txt") = "" Then
            Dim sw As New StreamWriter("Customer.txt", True)
            sw.WriteLine("")
            sw.Close()
            MsgBox("A new file has been created", vbExclamation, "Warning!")
        End If
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim CustomerData As New CustomerInfo
        Dim sw As New System.IO.StreamWriter("customer.txt", True)
        CustomerData.CustomerFirstName = LSet(txtFirstName.Text, 50)
        CustomerData.CustomerSurname = LSet(txtSurname.Text, 50)
        CustomerData.CustomerHolidayLocation = LSet(txtHolidayLocation.Text, 50)
        CustomerData.CustomerEmail = LSet(txtEmail.Text, 50)
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Dim Search As String
        Search = txtSearch.Text
        For q = 0 To 63
            If records(q).CustomerFirstName = Search Or records(q).CustomerSurname = Search Or records(q).CustomerHolidayLocation = Search Or records(q).CustomerEmail = Search Then
                MessageBox.Show("records" & vbCrLf & _  "the customers name is" & records(q).CustomerFirstName  & records(q).CustomerSurname  &)
            End If
        Next Then
    End Sub
End Class ' not fininshed
