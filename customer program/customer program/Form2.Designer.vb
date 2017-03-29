<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtCustomerFirstName = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtCustomerPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtCustomerPostcode = New System.Windows.Forms.TextBox()
        Me.txtCustomerAddress = New System.Windows.Forms.TextBox()
        Me.txtCustomerSurname = New System.Windows.Forms.TextBox()
        Me.rbtnVerify = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(547, 81)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(123, 82)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Button1"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(547, 230)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(123, 82)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Button2"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtCustomerFirstName
        '
        Me.txtCustomerFirstName.Location = New System.Drawing.Point(157, 12)
        Me.txtCustomerFirstName.Name = "txtCustomerFirstName"
        Me.txtCustomerFirstName.Size = New System.Drawing.Size(177, 22)
        Me.txtCustomerFirstName.TabIndex = 2
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(157, 152)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(177, 22)
        Me.txtSearch.TabIndex = 3
        '
        'txtCustomerPhoneNumber
        '
        Me.txtCustomerPhoneNumber.Location = New System.Drawing.Point(157, 124)
        Me.txtCustomerPhoneNumber.Name = "txtCustomerPhoneNumber"
        Me.txtCustomerPhoneNumber.Size = New System.Drawing.Size(177, 22)
        Me.txtCustomerPhoneNumber.TabIndex = 5
        '
        'txtCustomerPostcode
        '
        Me.txtCustomerPostcode.Location = New System.Drawing.Point(157, 96)
        Me.txtCustomerPostcode.Name = "txtCustomerPostcode"
        Me.txtCustomerPostcode.Size = New System.Drawing.Size(177, 22)
        Me.txtCustomerPostcode.TabIndex = 6
        '
        'txtCustomerAddress
        '
        Me.txtCustomerAddress.Location = New System.Drawing.Point(157, 68)
        Me.txtCustomerAddress.Name = "txtCustomerAddress"
        Me.txtCustomerAddress.Size = New System.Drawing.Size(177, 22)
        Me.txtCustomerAddress.TabIndex = 7
        '
        'txtCustomerSurname
        '
        Me.txtCustomerSurname.Location = New System.Drawing.Point(157, 40)
        Me.txtCustomerSurname.Name = "txtCustomerSurname"
        Me.txtCustomerSurname.Size = New System.Drawing.Size(177, 22)
        Me.txtCustomerSurname.TabIndex = 9
        '
        'rbtnVerify
        '
        Me.rbtnVerify.AutoSize = True
        Me.rbtnVerify.Location = New System.Drawing.Point(379, 25)
        Me.rbtnVerify.Name = "rbtnVerify"
        Me.rbtnVerify.Size = New System.Drawing.Size(374, 21)
        Me.rbtnVerify.TabIndex = 10
        Me.rbtnVerify.TabStop = True
        Me.rbtnVerify.Text = "tick this if you have verifyed the data entered is correct"
        Me.rbtnVerify.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "First name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Surname"
        '
        'Address
        '
        Me.Address.AutoSize = True
        Me.Address.Location = New System.Drawing.Point(50, 71)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(60, 17)
        Me.Address.TabIndex = 14
        Me.Address.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Postcode"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Phone number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(50, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Search"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 365)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbtnVerify)
        Me.Controls.Add(Me.txtCustomerSurname)
        Me.Controls.Add(Me.txtCustomerAddress)
        Me.Controls.Add(Me.txtCustomerPostcode)
        Me.Controls.Add(Me.txtCustomerPhoneNumber)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.txtCustomerFirstName)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtCustomerFirstName As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtCustomerPhoneNumber As TextBox
    Friend WithEvents txtCustomerPostcode As TextBox
    Friend WithEvents txtCustomerAddress As TextBox
    Friend WithEvents txtCustomerSurname As TextBox
    Friend WithEvents rbtnVerify As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Address As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
End Class
