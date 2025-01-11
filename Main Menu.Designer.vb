<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12.096F, FontStyle.Bold)
        Button1.ForeColor = Color.ForestGreen
        Button1.Location = New Point(99, 66)
        Button1.Name = "Button1"
        Button1.Size = New Size(232, 72)
        Button1.TabIndex = 0
        Button1.Text = "Array Exercises"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12.096F, FontStyle.Bold)
        Button2.ForeColor = Color.ForestGreen
        Button2.Location = New Point(99, 264)
        Button2.Name = "Button2"
        Button2.Size = New Size(232, 72)
        Button2.TabIndex = 1
        Button2.Text = "Object Exercises"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12.096F, FontStyle.Bold)
        Button3.ForeColor = Color.ForestGreen
        Button3.Location = New Point(99, 382)
        Button3.Name = "Button3"
        Button3.Size = New Size(232, 72)
        Button3.TabIndex = 2
        Button3.Text = "Search Algorithms"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 12.096F, FontStyle.Bold)
        Button4.ForeColor = Color.ForestGreen
        Button4.Location = New Point(99, 157)
        Button4.Name = "Button4"
        Button4.Size = New Size(232, 72)
        Button4.TabIndex = 3
        Button4.Text = "More Arrays"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AntiqueWhite
        ClientSize = New Size(482, 552)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button

End Class
