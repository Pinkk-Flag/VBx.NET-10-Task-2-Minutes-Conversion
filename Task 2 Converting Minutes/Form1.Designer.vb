<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtOut = New TextBox()
        vscroll = New VScrollBar()
        btnExit = New Button()
        lblMinutes = New Label()
        txtMinutes = New TextBox()
        txtHours = New TextBox()
        lblHours = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(148, 120)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 38)
        Label1.TabIndex = 0
        Label1.Text = "Minutes"
        ' 
        ' txtOut
        ' 
        txtOut.Location = New Point(136, 170)
        txtOut.Multiline = True
        txtOut.Name = "txtOut"
        txtOut.Size = New Size(150, 45)
        txtOut.TabIndex = 1
        ' 
        ' vscroll
        ' 
        vscroll.Location = New Point(9, 12)
        vscroll.Maximum = 5000
        vscroll.Name = "vscroll"
        vscroll.Size = New Size(39, 392)
        vscroll.TabIndex = 2
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(655, 12)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(112, 45)
        btnExit.TabIndex = 3
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblMinutes
        ' 
        lblMinutes.AutoSize = True
        lblMinutes.Location = New Point(479, 244)
        lblMinutes.Name = "lblMinutes"
        lblMinutes.Size = New Size(124, 38)
        lblMinutes.TabIndex = 4
        lblMinutes.Text = "Minutes"
        ' 
        ' txtMinutes
        ' 
        txtMinutes.Location = New Point(462, 285)
        txtMinutes.Multiline = True
        txtMinutes.Name = "txtMinutes"
        txtMinutes.Size = New Size(150, 45)
        txtMinutes.TabIndex = 5
        ' 
        ' txtHours
        ' 
        txtHours.Location = New Point(462, 114)
        txtHours.Multiline = True
        txtHours.Name = "txtHours"
        txtHours.Size = New Size(150, 45)
        txtHours.TabIndex = 6
        ' 
        ' lblHours
        ' 
        lblHours.AutoSize = True
        lblHours.Location = New Point(494, 73)
        lblHours.Name = "lblHours"
        lblHours.Size = New Size(95, 38)
        lblHours.TabIndex = 7
        lblHours.Text = "Hours"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 192)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 38)
        Label2.TabIndex = 8
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(213, 104)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(332, 204)
        TextBox1.TabIndex = 9
        TextBox1.Text = "Please add internal documentation and customise this. Also delete this. Make your own word doc"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(17F, 38F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(779, 413)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(lblHours)
        Controls.Add(txtHours)
        Controls.Add(txtMinutes)
        Controls.Add(lblMinutes)
        Controls.Add(btnExit)
        Controls.Add(vscroll)
        Controls.Add(txtOut)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(5)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtOut As TextBox
    Friend WithEvents vscroll As VScrollBar
    Friend WithEvents btnExit As Button
    Friend WithEvents lblMinutes As Label
    Friend WithEvents txtMinutes As TextBox
    Friend WithEvents txtHours As TextBox
    Friend WithEvents lblHours As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox

End Class
