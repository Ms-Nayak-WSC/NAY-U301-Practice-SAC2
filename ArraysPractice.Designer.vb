<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArrayPractice
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(55, 42)
        Button1.Name = "Button1"
        Button1.Size = New Size(499, 33)
        Button1.TabIndex = 0
        Button1.Text = "Exercise 1: Output each item in separate MessageBox"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(55, 99)
        Button2.Name = "Button2"
        Button2.Size = New Size(499, 41)
        Button2.TabIndex = 1
        Button2.Text = "Exercise 2: Output all the items in one MessageBox"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(55, 146)
        Button3.Name = "Button3"
        Button3.Size = New Size(499, 38)
        Button3.TabIndex = 2
        Button3.Text = "Exercise 3: Add all the items and show the total in the MessageBox"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(55, 318)
        Button4.Name = "Button4"
        Button4.Size = New Size(499, 39)
        Button4.TabIndex = 5
        Button4.Text = "Exercise 6: Find the largest of the items"
        Button4.TextAlign = ContentAlignment.MiddleLeft
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(55, 190)
        Button6.Name = "Button6"
        Button6.Size = New Size(499, 36)
        Button6.TabIndex = 3
        Button6.Text = "Exercise 4: Calculate the average and show the total in the MessageBox"
        Button6.TextAlign = ContentAlignment.MiddleLeft
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(55, 251)
        Button7.Name = "Button7"
        Button7.Size = New Size(499, 40)
        Button7.TabIndex = 8
        Button7.Text = "Exercise 5: Add all items greater than 20 and show the total in the MessageBox"
        Button7.TextAlign = ContentAlignment.MiddleLeft
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(55, 441)
        Button8.Name = "Button8"
        Button8.Size = New Size(499, 60)
        Button8.TabIndex = 7
        Button8.Text = "Exercise 8: Replace all items in the array with items twice as big & then output the result"
        Button8.TextAlign = ContentAlignment.MiddleLeft
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(55, 377)
        Button9.Name = "Button9"
        Button9.Size = New Size(499, 33)
        Button9.TabIndex = 6
        Button9.Text = "Exercise 7: Find the smallest of the items"
        Button9.TextAlign = ContentAlignment.MiddleLeft
        Button9.UseVisualStyleBackColor = True
        ' 
        ' frmArrayPractice
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AntiqueWhite
        ClientSize = New Size(677, 552)
        Controls.Add(Button7)
        Controls.Add(Button8)
        Controls.Add(Button9)
        Controls.Add(Button4)
        Controls.Add(Button6)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "frmArrayPractice"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ArrayPractice"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
End Class
