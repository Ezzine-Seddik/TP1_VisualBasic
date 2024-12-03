<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clc
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
        In1 = New TextBox()
        In2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Plus = New Button()
        Reset = New Button()
        Eq = New Button()
        Div = New Button()
        Mult = New Button()
        Minus = New Button()
        Lb = New Label()
        SuspendLayout()
        ' 
        ' In1
        ' 
        In1.Location = New Point(321, 49)
        In1.Name = "In1"
        In1.Size = New Size(125, 27)
        In1.TabIndex = 0
        ' 
        ' In2
        ' 
        In2.Location = New Point(321, 99)
        In2.Name = "In2"
        In2.Size = New Size(125, 27)
        In2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(225, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(19, 20)
        Label1.TabIndex = 2
        Label1.Text = "A"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(384, 213)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 20)
        Label2.TabIndex = 3
        Label2.Text = "Resultat :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(225, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(18, 20)
        Label3.TabIndex = 4
        Label3.Text = "B"
        ' 
        ' Plus
        ' 
        Plus.Location = New Point(147, 195)
        Plus.Name = "Plus"
        Plus.Size = New Size(56, 56)
        Plus.TabIndex = 5
        Plus.Text = "+"
        Plus.UseVisualStyleBackColor = True
        ' 
        ' Reset
        ' 
        Reset.Location = New Point(271, 257)
        Reset.Name = "Reset"
        Reset.Size = New Size(56, 56)
        Reset.TabIndex = 6
        Reset.Text = "Reset"
        Reset.UseVisualStyleBackColor = True
        ' 
        ' Eq
        ' 
        Eq.Location = New Point(209, 257)
        Eq.Name = "Eq"
        Eq.Size = New Size(56, 56)
        Eq.TabIndex = 7
        Eq.Text = "="
        Eq.UseVisualStyleBackColor = True
        ' 
        ' Div
        ' 
        Div.Location = New Point(147, 257)
        Div.Name = "Div"
        Div.Size = New Size(56, 56)
        Div.TabIndex = 8
        Div.Text = "/"
        Div.UseVisualStyleBackColor = True
        ' 
        ' Mult
        ' 
        Mult.Location = New Point(271, 197)
        Mult.Name = "Mult"
        Mult.Size = New Size(56, 56)
        Mult.TabIndex = 9
        Mult.Text = "*"
        Mult.UseVisualStyleBackColor = True
        ' 
        ' Minus
        ' 
        Minus.Location = New Point(209, 195)
        Minus.Name = "Minus"
        Minus.Size = New Size(56, 56)
        Minus.TabIndex = 10
        Minus.Text = "-"
        Minus.UseVisualStyleBackColor = True
        ' 
        ' Lb
        ' 
        Lb.AutoSize = True
        Lb.Location = New Point(499, 215)
        Lb.MinimumSize = New Size(50, 30)
        Lb.Name = "Lb"
        Lb.Size = New Size(50, 30)
        Lb.TabIndex = 11
        ' 
        ' Clc
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(751, 450)
        Controls.Add(Lb)
        Controls.Add(Minus)
        Controls.Add(Mult)
        Controls.Add(Div)
        Controls.Add(Eq)
        Controls.Add(Reset)
        Controls.Add(Plus)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(In2)
        Controls.Add(In1)
        Name = "Clc"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents In1 As TextBox
    Friend WithEvents In2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Plus As Button
    Friend WithEvents Reset As Button
    Friend WithEvents Eq As Button
    Friend WithEvents Div As Button
    Friend WithEvents Mult As Button
    Friend WithEvents Minus As Button
    Friend WithEvents Lb As Label

End Class
