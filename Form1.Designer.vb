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
        Panel1 = New Panel()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel3 = New Panel()
        Button5 = New Button()
        Button4 = New Button()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1118, 780)
        Panel1.TabIndex = 8
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.White
        Button3.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(84, 525)
        Button3.Name = "Button3"
        Button3.Size = New Size(420, 61)
        Button3.TabIndex = 22
        Button3.Text = "Need help?"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(84, 413)
        Button2.Name = "Button2"
        Button2.Size = New Size(420, 61)
        Button2.TabIndex = 21
        Button2.Text = "Buy a bag"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(84, 305)
        Button1.Name = "Button1"
        Button1.Size = New Size(420, 61)
        Button1.TabIndex = 20
        Button1.Text = "Enter product ID"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel3.Controls.Add(Button5)
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(TextBox1)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(581, -2)
        Panel3.Margin = New Padding(3, 3, 3, 30)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(535, 780)
        Panel3.TabIndex = 19
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.White
        Button5.Font = New Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(26, 571)
        Button5.Name = "Button5"
        Button5.Size = New Size(273, 40)
        Button5.TabIndex = 24
        Button5.Text = "add item to cart"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.White
        Button4.Font = New Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(393, 699)
        Button4.Name = "Button4"
        Button4.Size = New Size(103, 40)
        Button4.TabIndex = 22
        Button4.Text = "next"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 14F)
        TextBox1.Location = New Point(26, 36)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "enter product name"
        TextBox1.Size = New Size(340, 39)
        TextBox1.TabIndex = 21
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(382, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 30)
        Label2.TabIndex = 20
        Label2.Text = "Search"
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label1.Location = New Point(138, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(297, 44)
        Label1.TabIndex = 0
        Label1.Text = "SELF CHECKOUT"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1118, 780)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button

End Class
