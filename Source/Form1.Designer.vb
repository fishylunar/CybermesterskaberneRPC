<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.solvesTxt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 146)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(212, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Update Data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(226, -98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Raw"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(12, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Logged in as: "
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.username.Location = New System.Drawing.Point(100, 72)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(37, 15)
        Me.username.TabIndex = 7
        Me.username.Text = "name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Location = New System.Drawing.Point(12, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Solves: "
        '
        'solvesTxt
        '
        Me.solvesTxt.AutoSize = True
        Me.solvesTxt.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.solvesTxt.Location = New System.Drawing.Point(100, 102)
        Me.solvesTxt.Name = "solvesTxt"
        Me.solvesTxt.Size = New System.Drawing.Size(39, 15)
        Me.solvesTxt.TabIndex = 9
        Me.solvesTxt.Text = "solves"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(236, 183)
        Me.Controls.Add(Me.solvesTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Cybermesterskaberne 2021"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents username As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents solvesTxt As Label
    Friend WithEvents Cookie As TextBox
End Class
