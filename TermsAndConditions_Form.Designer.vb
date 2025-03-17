<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TermsAndConditions_Form
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
        TextBox_Terms = New TextBox()
        CheckBox_Agree = New CheckBox()
        Button_Accept = New Button()
        Button_Cancel = New Button()
        SuspendLayout()
        ' 
        ' TextBox_Terms
        ' 
        TextBox_Terms.Location = New Point(12, 12)
        TextBox_Terms.Multiline = True
        TextBox_Terms.Name = "TextBox_Terms"
        TextBox_Terms.ReadOnly = True
        TextBox_Terms.ScrollBars = ScrollBars.Vertical
        TextBox_Terms.Size = New Size(398, 110)
        TextBox_Terms.TabIndex = 0
        ' 
        ' CheckBox_Agree
        ' 
        CheckBox_Agree.AutoSize = True
        CheckBox_Agree.Location = New Point(12, 128)
        CheckBox_Agree.Name = "CheckBox_Agree"
        CheckBox_Agree.Size = New Size(206, 19)
        CheckBox_Agree.TabIndex = 1
        CheckBox_Agree.Text = "I accept the terms and agreement."
        CheckBox_Agree.UseVisualStyleBackColor = True
        ' 
        ' Button_Accept
        ' 
        Button_Accept.Location = New Point(123, 155)
        Button_Accept.Name = "Button_Accept"
        Button_Accept.Size = New Size(75, 23)
        Button_Accept.TabIndex = 2
        Button_Accept.Text = "Accept"
        Button_Accept.UseVisualStyleBackColor = True
        ' 
        ' Button_Cancel
        ' 
        Button_Cancel.Location = New Point(204, 155)
        Button_Cancel.Name = "Button_Cancel"
        Button_Cancel.Size = New Size(75, 23)
        Button_Cancel.TabIndex = 3
        Button_Cancel.Text = "Cancel"
        Button_Cancel.UseVisualStyleBackColor = True
        ' 
        ' TermsAndConditions_Form
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button_Cancel)
        Controls.Add(Button_Accept)
        Controls.Add(CheckBox_Agree)
        Controls.Add(TextBox_Terms)
        Name = "TermsAndConditions_Form"
        Text = "TermsAndConditions_Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox_Terms As TextBox
    Friend WithEvents CheckBox_Agree As CheckBox
    Friend WithEvents Button_Accept As Button
    Friend WithEvents Button_Cancel As Button

End Class
