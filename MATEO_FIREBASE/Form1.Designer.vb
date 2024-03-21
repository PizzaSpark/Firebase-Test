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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.valuetxt = New System.Windows.Forms.TextBox()
        Me.keytxt = New System.Windows.Forms.TextBox()
        Me.retrievebtn = New System.Windows.Forms.Button()
        Me.setbtn = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 22)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Key"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 22)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Value"
        '
        'valuetxt
        '
        Me.valuetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valuetxt.Location = New System.Drawing.Point(95, 81)
        Me.valuetxt.Name = "valuetxt"
        Me.valuetxt.Size = New System.Drawing.Size(303, 28)
        Me.valuetxt.TabIndex = 7
        '
        'keytxt
        '
        Me.keytxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keytxt.Location = New System.Drawing.Point(95, 40)
        Me.keytxt.Name = "keytxt"
        Me.keytxt.Size = New System.Drawing.Size(303, 28)
        Me.keytxt.TabIndex = 6
        '
        'retrievebtn
        '
        Me.retrievebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retrievebtn.Location = New System.Drawing.Point(238, 140)
        Me.retrievebtn.Name = "retrievebtn"
        Me.retrievebtn.Size = New System.Drawing.Size(160, 39)
        Me.retrievebtn.TabIndex = 11
        Me.retrievebtn.Text = "Retrieve"
        Me.retrievebtn.UseVisualStyleBackColor = True
        '
        'setbtn
        '
        Me.setbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.setbtn.Location = New System.Drawing.Point(95, 140)
        Me.setbtn.Name = "setbtn"
        Me.setbtn.Size = New System.Drawing.Size(137, 39)
        Me.setbtn.TabIndex = 10
        Me.setbtn.Text = "Set"
        Me.setbtn.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(12, 196)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(416, 244)
        Me.ListBox1.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 450)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.retrievebtn)
        Me.Controls.Add(Me.setbtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.valuetxt)
        Me.Controls.Add(Me.keytxt)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Firebase "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents valuetxt As TextBox
    Friend WithEvents keytxt As TextBox
    Friend WithEvents retrievebtn As Button
    Friend WithEvents setbtn As Button
    Friend WithEvents ListBox1 As ListBox
End Class
