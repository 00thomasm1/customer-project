Imports System.IO
Public Class Form1
    Dim records(63) As CustomerTable
    Dim i As Integer
    Public Structure CustomerTable
        Dim CustomerFirstName As String
        Dim CustomerSurname As String
        Dim CustomerAddress As String
        Dim CustomerPostcode As String
        Dim CustomerPhonenumber As String ' list of all the fields 
    End Structure
    Private Sub LeisureSessionsComplete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Dir$("customer.txt") = "" Then
            Dim sw As New StreamWriter(Application.StartupPath & "\Leisure.txt", True)    'This makes sure there is actually a database to enter or read data. If not, it creates a new blank one.
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
            records(i).CustomerAddress = txtCustomerAddress.Text
            records(i).CustomerPostcode = txtCustomerPostcode.Text
            records(i).CustomerPhonenumber = txtCustomerPhoneNumber.Text
            System.IO.File.WriteAllLines("c:file.txt", records) ' creates a text file to write the added data too
        End If
    End Sub
    Private Sub CustomerInfoProg_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        i = 0 'makes sure the first file added is in the first space
    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim Search As String
        Search = txtSearch.Text
        For q = 0 To 63
            If records(q).CustomerFirstName = Search Or records(q).CustomerFirstName = Search Then
                MessageBox.Show("The customers name is " & records(q).CustomerFirstName & records(q).CustomerSurname & " their address is " & records(q).CustomerAddress & ", their postcode is " & records(q).CustomerPostcode & " you can contact them at " & records(q).CustomerPhonenumber)
            End If ' outputs data that has been search for in a message box
        Next
    End Sub
End Class

