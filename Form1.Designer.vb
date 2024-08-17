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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.chkLevel2 = New System.Windows.Forms.CheckBox()
        Me.chkLevel3 = New System.Windows.Forms.CheckBox()
        Me.chkLevel4 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name of Student"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Amount of Subjects"
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(174, 34)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(100, 20)
        Me.txtStudentName.TabIndex = 2
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(174, 89)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkLevel4)
        Me.GroupBox1.Controls.Add(Me.chkLevel3)
        Me.GroupBox1.Controls.Add(Me.chkLevel2)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 120)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Level Attending"
        '
        'lblAnswer
        '
        Me.lblAnswer.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblAnswer.Location = New System.Drawing.Point(40, 278)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(342, 70)
        Me.lblAnswer.TabIndex = 5
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(40, 376)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 39)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Calculate amount"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(162, 376)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 39)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear Entries"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(307, 376)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 39)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit Program"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'chkLevel2
        '
        Me.chkLevel2.AutoSize = True
        Me.chkLevel2.Location = New System.Drawing.Point(7, 20)
        Me.chkLevel2.Name = "chkLevel2"
        Me.chkLevel2.Size = New System.Drawing.Size(61, 17)
        Me.chkLevel2.TabIndex = 0
        Me.chkLevel2.Text = "Level 2"
        Me.chkLevel2.UseVisualStyleBackColor = True
        '
        'chkLevel3
        '
        Me.chkLevel3.AutoSize = True
        Me.chkLevel3.Location = New System.Drawing.Point(7, 55)
        Me.chkLevel3.Name = "chkLevel3"
        Me.chkLevel3.Size = New System.Drawing.Size(61, 17)
        Me.chkLevel3.TabIndex = 1
        Me.chkLevel3.Text = "Level 3"
        Me.chkLevel3.UseVisualStyleBackColor = True
        '
        'chkLevel4
        '
        Me.chkLevel4.AutoSize = True
        Me.chkLevel4.Location = New System.Drawing.Point(7, 88)
        Me.chkLevel4.Name = "chkLevel4"
        Me.chkLevel4.Size = New System.Drawing.Size(61, 17)
        Me.chkLevel4.TabIndex = 2
        Me.chkLevel4.Text = "Level 4"
        Me.chkLevel4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkLevel2 As CheckBox
    Friend WithEvents lblAnswer As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents chkLevel4 As CheckBox
    Friend WithEvents chkLevel3 As CheckBox
End Class
