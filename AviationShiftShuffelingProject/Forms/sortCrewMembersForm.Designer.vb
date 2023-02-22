<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sortCrewMembersForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lvRic = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lvCrewman = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbGroupPicker = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PowderBlue
        Me.Panel1.Controls.Add(Me.lvRic)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lvCrewman)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbGroupPicker)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 452)
        Me.Panel1.TabIndex = 0
        '
        'lvRic
        '
        Me.lvRic.AllowDrop = True
        Me.lvRic.FormattingEnabled = True
        Me.lvRic.ItemHeight = 15
        Me.lvRic.Location = New System.Drawing.Point(16, 243)
        Me.lvRic.Name = "lvRic"
        Me.lvRic.Size = New System.Drawing.Size(74, 124)
        Me.lvRic.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "RIC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "CREWMAN"
        '
        'lvCrewman
        '
        Me.lvCrewman.AllowDrop = True
        Me.lvCrewman.FormattingEnabled = True
        Me.lvCrewman.ItemHeight = 15
        Me.lvCrewman.Location = New System.Drawing.Point(16, 82)
        Me.lvCrewman.Name = "lvCrewman"
        Me.lvCrewman.Size = New System.Drawing.Size(74, 124)
        Me.lvCrewman.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select Group"
        '
        'cbGroupPicker
        '
        Me.cbGroupPicker.FormattingEnabled = True
        Me.cbGroupPicker.Location = New System.Drawing.Point(98, 15)
        Me.cbGroupPicker.Name = "cbGroupPicker"
        Me.cbGroupPicker.Size = New System.Drawing.Size(44, 23)
        Me.cbGroupPicker.TabIndex = 0
        '
        'sortCrewMembersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "sortCrewMembersForm"
        Me.Text = "sortCrewMembersForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbGroupPicker As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lvCrewman As ListBox
    Public WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lvRic As ListBox
End Class
