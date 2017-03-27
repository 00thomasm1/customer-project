<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomersInfoProg
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
        Me.txtCustomerFirstName = New System.Windows.Forms.TextBox()
        Me.txtCustomerSurname = New System.Windows.Forms.TextBox()
        Me.txtCustomerDOB = New System.Windows.Forms.TextBox()
        Me.txtCustomerAddress = New System.Windows.Forms.TextBox()
        Me.txtCustomerPostcode = New System.Windows.Forms.TextBox()
        Me.txtCustomerPhoneNumber = New System.Windows.Forms.TextBox()
        Me.rbtnVerify = New System.Windows.Forms.RadioButton()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtCustomerNIN = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(313, 53)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(76, 45)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add details"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtCustomerFirstName
        '
        Me.txtCustomerFirstName.Location = New System.Drawing.Point(123, 35)
        Me.txtCustomerFirstName.Name = "txtCustomerFirstName"
        Me.txtCustomerFirstName.Size = New System.Drawing.Size(151, 20)
        Me.txtCustomerFirstName.TabIndex = 1
        '
        'txtCustomerSurname
        '
        Me.txtCustomerSurname.Location = New System.Drawing.Point(123, 61)
        Me.txtCustomerSurname.Name = "txtCustomerSurname"
        Me.txtCustomerSurname.Size = New System.Drawing.Size(151, 20)
        Me.txtCustomerSurname.TabIndex = 2
        '
        'txtCustomerDOB
        '
        Me.txtCustomerDOB.Location = New System.Drawing.Point(123, 87)
        Me.txtCustomerDOB.Name = "txtCustomerDOB"
        Me.txtCustomerDOB.Size = New System.Drawing.Size(151, 20)
        Me.txtCustomerDOB.TabIndex = 3
        '
        'txtCustomerAddress
        '
        Me.txtCustomerAddress.Location = New System.Drawing.Point(123, 113)
        Me.txtCustomerAddress.Name = "txtCustomerAddress"
        Me.txtCustomerAddress.Size = New System.Drawing.Size(151, 20)
        Me.txtCustomerAddress.TabIndex = 4
        '
        'txtCustomerPostcode
        '
        Me.txtCustomerPostcode.Location = New System.Drawing.Point(123, 139)
        Me.txtCustomerPostcode.Name = "txtCustomerPostcode"
        Me.txtCustomerPostcode.Size = New System.Drawing.Size(151, 20)
        Me.txtCustomerPostcode.TabIndex = 5
        '
        'txtCustomerPhoneNumber
        '
        Me.txtCustomerPhoneNumber.Location = New System.Drawing.Point(123, 165)
        Me.txtCustomerPhoneNumber.Name = "txtCustomerPhoneNumber"
        Me.txtCustomerPhoneNumber.Size = New System.Drawing.Size(151, 20)
        Me.txtCustomerPhoneNumber.TabIndex = 6
        '
        'rbtnVerify
        '
        Me.rbtnVerify.AutoSize = True
        Me.rbtnVerify.Location = New System.Drawing.Point(186, 12)
        Me.rbtnVerify.Name = "rbtnVerify"
        Me.rbtnVerify.Size = New System.Drawing.Size(203, 17)
        Me.rbtnVerify.TabIndex = 7
        Me.rbtnVerify.TabStop = True
        Me.rbtnVerify.Text = "click here if all data inputted is correct"
        Me.rbtnVerify.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(300, 206)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(76, 56)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(123, 217)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(151, 20)
        Me.txtSearch.TabIndex = 9
        '
        'txtCustomerNIN
        '
        Me.txtCustomerNIN.Location = New System.Drawing.Point(123, 191)
        Me.txtCustomerNIN.Name = "txtCustomerNIN"
        Me.txtCustomerNIN.Size = New System.Drawing.Size(151, 20)
        Me.txtCustomerNIN.TabIndex = 10
        '
        'CustomersInfoProg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 274)
        Me.Controls.Add(Me.txtCustomerNIN)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.rbtnVerify)
        Me.Controls.Add(Me.txtCustomerPhoneNumber)
        Me.Controls.Add(Me.txtCustomerPostcode)
        Me.Controls.Add(Me.txtCustomerAddress)
        Me.Controls.Add(Me.txtCustomerDOB)
        Me.Controls.Add(Me.txtCustomerSurname)
        Me.Controls.Add(Me.txtCustomerFirstName)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "CustomersInfoProg"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtCustomerFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerDOB As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerPostcode As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents rbtnVerify As System.Windows.Forms.RadioButton
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerNIN As System.Windows.Forms.TextBox

End Class
