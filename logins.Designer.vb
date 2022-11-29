<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logins
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.AutoScroll = True
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Panel1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(800, 425)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(800, 450)
        Me.ToolStripContainer1.TabIndex = 7
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(168, 30)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(150, 31)
        Me.txtUsername.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(168, 100)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(150, 31)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(206, 157)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(112, 34)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Log in"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "username"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WinFormsApp4.My.Resources.Resources.download__1_1
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Location = New System.Drawing.Point(133, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(534, 279)
        Me.Panel1.TabIndex = 6
        '
        'logins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "logins"
        Me.Text = "logins"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
End Class
