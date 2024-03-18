<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Panel1 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button8 = New Button()
        Button5 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Button8)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1118, 780)
        Panel1.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label3.Location = New Point(1028, 26)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 44)
        Label3.TabIndex = 52
        Label3.Text = "x"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label2.Location = New Point(406, 179)
        Label2.Name = "Label2"
        Label2.Size = New Size(299, 29)
        Label2.TabIndex = 50
        Label2.Text = "swipe debit/credit card"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label1.Location = New Point(464, 110)
        Label1.Name = "Label1"
        Label1.Size = New Size(185, 44)
        Label1.TabIndex = 48
        Label1.Text = "PAYMENT"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BackgroundImage = My.Resources.Resources.african_print_fabric_seamless_tribal_pattern_vector_39871065
        Panel2.Location = New Point(-40, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(74, 795)
        Panel2.TabIndex = 18
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Century Gothic", 15F, FontStyle.Bold)
        Button1.Location = New Point(65, 313)
        Button1.Name = "Button1"
        Button1.Size = New Size(251, 168)
        Button1.TabIndex = 53
        Button1.Text = "Credit Card"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.Font = New Font("Century Gothic", 15F, FontStyle.Bold)
        Button2.Location = New Point(322, 313)
        Button2.Name = "Button2"
        Button2.Size = New Size(251, 168)
        Button2.TabIndex = 54
        Button2.Text = "Debit Card"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.White
        Button3.Font = New Font("Century Gothic", 15F, FontStyle.Bold)
        Button3.Location = New Point(579, 313)
        Button3.Name = "Button3"
        Button3.Size = New Size(251, 168)
        Button3.TabIndex = 55
        Button3.Text = "MPESA"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.White
        Button4.Font = New Font("Century Gothic", 15F, FontStyle.Bold)
        Button4.Location = New Point(836, 313)
        Button4.Name = "Button4"
        Button4.Size = New Size(251, 168)
        Button4.TabIndex = 56
        Button4.Text = "CASH"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Button8.Font = New Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button8.ForeColor = Color.White
        Button8.Location = New Point(178, 579)
        Button8.Name = "Button8"
        Button8.Size = New Size(103, 55)
        Button8.TabIndex = 58
        Button8.Text = "home"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Button5.Font = New Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.White
        Button5.Location = New Point(905, 579)
        Button5.Name = "Button5"
        Button5.Size = New Size(116, 55)
        Button5.TabIndex = 57
        Button5.Text = "cancel"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Payment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1118, 780)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Payment"
        Text = "Payment"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button5 As Button
End Class
