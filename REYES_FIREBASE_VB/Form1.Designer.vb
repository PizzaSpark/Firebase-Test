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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pushbtn = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.setbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.retrieveSet = New System.Windows.Forms.Button()
        Me.retrievePush = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(131, 83)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(303, 30)
        Me.TextBox1.TabIndex = 0
        '
        'pushbtn
        '
        Me.pushbtn.Location = New System.Drawing.Point(131, 178)
        Me.pushbtn.Name = "pushbtn"
        Me.pushbtn.Size = New System.Drawing.Size(86, 23)
        Me.pushbtn.TabIndex = 1
        Me.pushbtn.Text = "Push"
        Me.pushbtn.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(131, 120)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(303, 30)
        Me.TextBox2.TabIndex = 2
        '
        'setbtn
        '
        Me.setbtn.Location = New System.Drawing.Point(223, 178)
        Me.setbtn.Name = "setbtn"
        Me.setbtn.Size = New System.Drawing.Size(87, 23)
        Me.setbtn.TabIndex = 3
        Me.setbtn.Text = "Set"
        Me.setbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Value"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Key"
        '
        'retrieveSet
        '
        Me.retrieveSet.Location = New System.Drawing.Point(223, 303)
        Me.retrieveSet.Name = "retrieveSet"
        Me.retrieveSet.Size = New System.Drawing.Size(87, 52)
        Me.retrieveSet.TabIndex = 6
        Me.retrieveSet.Text = "Retrieve from Set"
        Me.retrieveSet.UseVisualStyleBackColor = True
        '
        'retrievePush
        '
        Me.retrievePush.Location = New System.Drawing.Point(131, 303)
        Me.retrievePush.Name = "retrievePush"
        Me.retrievePush.Size = New System.Drawing.Size(87, 52)
        Me.retrievePush.TabIndex = 7
        Me.retrievePush.Text = "Retrieve from Push"
        Me.retrievePush.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(530, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Retrieved"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(533, 61)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(553, 356)
        Me.ListBox1.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 450)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.retrievePush)
        Me.Controls.Add(Me.retrieveSet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.setbtn)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.pushbtn)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents pushbtn As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents setbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents retrieveSet As Button
    Friend WithEvents retrievePush As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox1 As ListBox
End Class
