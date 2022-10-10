<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class change_password
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUname = New System.Windows.Forms.TextBox()
        Me.ComboBoxUtype = New System.Windows.Forms.ComboBox()
        Me.txtOldPwd = New System.Windows.Forms.TextBox()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.lblOldPwd = New System.Windows.Forms.Label()
        Me.lblOldPwd1 = New System.Windows.Forms.Label()
        Me.txtNewPwd = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USER TYPE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "USER NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(105, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "OLD PASSWORD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(103, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "NEW PASSWORD"
        '
        'txtUname
        '
        Me.txtUname.Location = New System.Drawing.Point(241, 164)
        Me.txtUname.Name = "txtUname"
        Me.txtUname.Size = New System.Drawing.Size(300, 20)
        Me.txtUname.TabIndex = 5
        '
        'ComboBoxUtype
        '
        Me.ComboBoxUtype.FormattingEnabled = True
        Me.ComboBoxUtype.Items.AddRange(New Object() {"Admin", "Librarian"})
        Me.ComboBoxUtype.Location = New System.Drawing.Point(241, 117)
        Me.ComboBoxUtype.Name = "ComboBoxUtype"
        Me.ComboBoxUtype.Size = New System.Drawing.Size(307, 21)
        Me.ComboBoxUtype.TabIndex = 6
        '
        'txtOldPwd
        '
        Me.txtOldPwd.Location = New System.Drawing.Point(241, 214)
        Me.txtOldPwd.Name = "txtOldPwd"
        Me.txtOldPwd.Size = New System.Drawing.Size(300, 20)
        Me.txtOldPwd.TabIndex = 7
        '
        'btnChange
        '
        Me.btnChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.Location = New System.Drawing.Point(284, 357)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(124, 37)
        Me.btnChange.TabIndex = 9
        Me.btnChange.Text = "CHANGE"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'lblOldPwd
        '
        Me.lblOldPwd.AutoSize = True
        Me.lblOldPwd.Location = New System.Drawing.Point(400, 219)
        Me.lblOldPwd.Name = "lblOldPwd"
        Me.lblOldPwd.Size = New System.Drawing.Size(0, 13)
        Me.lblOldPwd.TabIndex = 10
        '
        'lblOldPwd1
        '
        Me.lblOldPwd1.AutoSize = True
        Me.lblOldPwd1.Location = New System.Drawing.Point(12, 412)
        Me.lblOldPwd1.Name = "lblOldPwd1"
        Me.lblOldPwd1.Size = New System.Drawing.Size(0, 13)
        Me.lblOldPwd1.TabIndex = 11
        '
        'txtNewPwd
        '
        Me.txtNewPwd.Location = New System.Drawing.Point(241, 268)
        Me.txtNewPwd.Name = "txtNewPwd"
        Me.txtNewPwd.Size = New System.Drawing.Size(300, 20)
        Me.txtNewPwd.TabIndex = 12
        '
        'change_password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtNewPwd)
        Me.Controls.Add(Me.lblOldPwd1)
        Me.Controls.Add(Me.lblOldPwd)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.txtOldPwd)
        Me.Controls.Add(Me.ComboBoxUtype)
        Me.Controls.Add(Me.txtUname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "change_password"
        Me.Text = "change_password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUname As TextBox
    Friend WithEvents ComboBoxUtype As ComboBox
    Friend WithEvents txtOldPwd As TextBox
    Friend WithEvents btnChange As Button
    Friend WithEvents lblOldPwd As Label
    Friend WithEvents lblOldPwd1 As Label
    Friend WithEvents txtNewPwd As TextBox
End Class
