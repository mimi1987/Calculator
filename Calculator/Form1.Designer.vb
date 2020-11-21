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
        Me.TBNumber1 = New System.Windows.Forms.TextBox()
        Me.LBNumber1 = New System.Windows.Forms.Label()
        Me.LBNumber2 = New System.Windows.Forms.Label()
        Me.TBNumber2 = New System.Windows.Forms.TextBox()
        Me.LBResult = New System.Windows.Forms.Label()
        Me.TBResult = New System.Windows.Forms.TextBox()
        Me.BTNAdd = New System.Windows.Forms.Button()
        Me.BTNMult = New System.Windows.Forms.Button()
        Me.BTNSub = New System.Windows.Forms.Button()
        Me.BTNDiv = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TBNumber1
        '
        Me.TBNumber1.Location = New System.Drawing.Point(125, 45)
        Me.TBNumber1.Name = "TBNumber1"
        Me.TBNumber1.Size = New System.Drawing.Size(100, 23)
        Me.TBNumber1.TabIndex = 0
        '
        'LBNumber1
        '
        Me.LBNumber1.AutoSize = True
        Me.LBNumber1.Location = New System.Drawing.Point(62, 48)
        Me.LBNumber1.Name = "LBNumber1"
        Me.LBNumber1.Size = New System.Drawing.Size(57, 15)
        Me.LBNumber1.TabIndex = 1
        Me.LBNumber1.Text = "Number1"
        '
        'LBNumber2
        '
        Me.LBNumber2.AutoSize = True
        Me.LBNumber2.Location = New System.Drawing.Point(62, 92)
        Me.LBNumber2.Name = "LBNumber2"
        Me.LBNumber2.Size = New System.Drawing.Size(57, 15)
        Me.LBNumber2.TabIndex = 3
        Me.LBNumber2.Text = "Number2"
        '
        'TBNumber2
        '
        Me.TBNumber2.Location = New System.Drawing.Point(125, 92)
        Me.TBNumber2.Name = "TBNumber2"
        Me.TBNumber2.Size = New System.Drawing.Size(100, 23)
        Me.TBNumber2.TabIndex = 2
        '
        'LBResult
        '
        Me.LBResult.AutoSize = True
        Me.LBResult.Location = New System.Drawing.Point(62, 136)
        Me.LBResult.Name = "LBResult"
        Me.LBResult.Size = New System.Drawing.Size(39, 15)
        Me.LBResult.TabIndex = 5
        Me.LBResult.Text = "Result"
        '
        'TBResult
        '
        Me.TBResult.Location = New System.Drawing.Point(125, 133)
        Me.TBResult.Name = "TBResult"
        Me.TBResult.Size = New System.Drawing.Size(100, 23)
        Me.TBResult.TabIndex = 4
        '
        'BTNAdd
        '
        Me.BTNAdd.Location = New System.Drawing.Point(53, 188)
        Me.BTNAdd.Name = "BTNAdd"
        Me.BTNAdd.Size = New System.Drawing.Size(75, 23)
        Me.BTNAdd.TabIndex = 6
        Me.BTNAdd.Text = "+"
        Me.BTNAdd.UseVisualStyleBackColor = True
        '
        'BTNMult
        '
        Me.BTNMult.Location = New System.Drawing.Point(53, 242)
        Me.BTNMult.Name = "BTNMult"
        Me.BTNMult.Size = New System.Drawing.Size(75, 23)
        Me.BTNMult.TabIndex = 7
        Me.BTNMult.Text = "x"
        Me.BTNMult.UseVisualStyleBackColor = True
        '
        'BTNSub
        '
        Me.BTNSub.Location = New System.Drawing.Point(171, 188)
        Me.BTNSub.Name = "BTNSub"
        Me.BTNSub.Size = New System.Drawing.Size(75, 23)
        Me.BTNSub.TabIndex = 8
        Me.BTNSub.Text = "-"
        Me.BTNSub.UseVisualStyleBackColor = True
        '
        'BTNDiv
        '
        Me.BTNDiv.Location = New System.Drawing.Point(171, 242)
        Me.BTNDiv.Name = "BTNDiv"
        Me.BTNDiv.Size = New System.Drawing.Size(75, 23)
        Me.BTNDiv.TabIndex = 9
        Me.BTNDiv.Text = "/"
        Me.BTNDiv.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 317)
        Me.Controls.Add(Me.BTNDiv)
        Me.Controls.Add(Me.BTNSub)
        Me.Controls.Add(Me.BTNMult)
        Me.Controls.Add(Me.BTNAdd)
        Me.Controls.Add(Me.LBResult)
        Me.Controls.Add(Me.TBResult)
        Me.Controls.Add(Me.LBNumber2)
        Me.Controls.Add(Me.TBNumber2)
        Me.Controls.Add(Me.LBNumber1)
        Me.Controls.Add(Me.TBNumber1)
        Me.Name = "Form1"
        Me.Text = "Calc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBNumber1 As TextBox
    Friend WithEvents LBNumber1 As Label
    Friend WithEvents LBNumber2 As Label
    Friend WithEvents TBNumber2 As TextBox
    Friend WithEvents LBResult As Label
    Friend WithEvents TBResult As TextBox
    Friend WithEvents BTNAdd As Button
    Friend WithEvents BTNMult As Button
    Friend WithEvents BTNSub As Button
    Friend WithEvents BTNDiv As Button
End Class
