﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cart
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
        Button3 = New Button()
        Button1 = New Button()
        Panel3 = New Panel()
        ListView1 = New ListView()
        Panel2 = New Panel()
        Label1 = New Label()
        Button2 = New Button()
        Button4 = New Button()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(ListView1)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1118, 780)
        Panel1.TabIndex = 9
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.White
        Button3.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(281, 806)
        Button3.Name = "Button3"
        Button3.Size = New Size(420, 61)
        Button3.TabIndex = 22
        Button3.Text = "Need help?"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(54, 256)
        Button1.Name = "Button1"
        Button1.Size = New Size(420, 61)
        Button1.TabIndex = 20
        Button1.Text = "Edit cart"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(Button1)
        Panel3.Location = New Point(581, -2)
        Panel3.Margin = New Padding(3, 3, 3, 30)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(535, 780)
        Panel3.TabIndex = 19
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(86, 156)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(420, 425)
        ListView1.TabIndex = 23
        ListView1.UseCompatibleStateImageBehavior = False
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
        Label1.Location = New Point(187, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 44)
        Label1.TabIndex = 0
        Label1.Text = "MY CART"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(54, 374)
        Button2.Name = "Button2"
        Button2.Size = New Size(420, 61)
        Button2.TabIndex = 23
        Button2.Text = "Proceed with payment"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.White
        Button4.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(54, 494)
        Button4.Name = "Button4"
        Button4.Size = New Size(420, 61)
        Button4.TabIndex = 24
        Button4.Text = "Home"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Cart
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1118, 780)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Cart"
        Text = "Cart"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
End Class
