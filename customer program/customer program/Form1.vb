Imports System.IO
Public Class CustomersInfoProg
    Dim records(63) As CustomerTable
    Dim i As Integer
    Public Structure CustomerTable
        Dim CustomerFirstName As String
        Dim CustomerSurname As String
        Dim CustomerDOB As Integer
        Dim CustomerAddress As String
        Dim CustomerPostcode As String
        Dim CustomerPhonenumber As String
        Dim CustomerNationalInsuranceNumber As Integer
    End Structure
    Private Sub LeisureSessionsComplete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Dir$("customer.txt") = "" Then
            Dim sw As New StreamWriter(Application.StartupPath & "\Leisure.txt", True)    'This makes sure there is actually a database to enter/read data. If not, it creates a new blank one.
            sw.WriteLine("                                                                                                                                                                                                                                                                                                                                    ")
            sw.Close()
            MsgBox("A new database has been created", vbExclamation, "Warning!")
        End If
    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If rbtnVerify.Checked = False Then
            MessageBox.Show("make sure you have checked through your inputted data and tick the button down below before adding the data")
        Else
            records(i).CustomerFirstName = txtCustomerFirstName.Text
            records(i).CustomerSurname = txtCustomerSurname.Text
            records(i).CustomerDOB = txtCustomerDOB.Text
            records(i).CustomerAddress = txtCustomerAddress.Text
            records(i).CustomerPostcode = txtCustomerPostcode.Text
            records(i).CustomerPhonenumber = txtCustomerPhoneNumber.Text
            records(i).CutomerNationalInsuranceNumber = txtCustomerNIN.Text
        End If
    End Sub
    Private Sub CustomerInfoProg_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        i = 0
    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim Search As String
        Search = txtSearch.Text
        For q = 0 To 63
            If records(q).CustomerNationalInsuranceNumber = Search Or records(q).CustomerFirstName = Search Then
                MessageBox.Show("The customers first name is " & records(q).CustomerFirstName & "")
            End If
        Next
    End Sub
End Class
