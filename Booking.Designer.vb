<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Booking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Booking))
        Label1 = New Label()
        TextBox1txt = New TextBox()
        TextBox2txt = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        NumericUpDown1txt = New NumericUpDown()
        Button1 = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        CType(NumericUpDown1txt, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(455, 169)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 15)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' TextBox1txt
        ' 
        TextBox1txt.Location = New Point(455, 187)
        TextBox1txt.Name = "TextBox1txt"
        TextBox1txt.Size = New Size(294, 23)
        TextBox1txt.TabIndex = 1
        ' 
        ' TextBox2txt
        ' 
        TextBox2txt.Location = New Point(455, 231)
        TextBox2txt.Name = "TextBox2txt"
        TextBox2txt.Size = New Size(294, 23)
        TextBox2txt.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(457, 213)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 2
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 145)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(457, 257)
        Label4.Name = "Label4"
        Label4.Size = New Size(126, 15)
        Label4.TabIndex = 5
        Label4.Text = "Amount of  ticket(s)"
        ' 
        ' NumericUpDown1txt
        ' 
        NumericUpDown1txt.Location = New Point(455, 275)
        NumericUpDown1txt.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        NumericUpDown1txt.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown1txt.Name = "NumericUpDown1txt"
        NumericUpDown1txt.Size = New Size(137, 23)
        NumericUpDown1txt.TabIndex = 6
        NumericUpDown1txt.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(673, 298)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 23)
        Button1.TabIndex = 7
        Button1.Text = "Book"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.Info
        Label5.Location = New Point(505, 145)
        Label5.Name = "Label5"
        Label5.Size = New Size(135, 15)
        Label5.TabIndex = 8
        Label5.Text = "Book your ticket now!"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(303, 74)
        Label6.Name = "Label6"
        Label6.Size = New Size(139, 15)
        Label6.TabIndex = 12
        Label6.Text = "#OneArellano Concert"
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(135, 18)
        Label7.Name = "Label7"
        Label7.Size = New Size(514, 56)
        Label7.TabIndex = 13
        Label7.Text = "Arellano University Concert Grounds"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(655, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(131, 118)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' Booking
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = SystemColors.Info
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(786, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Controls.Add(NumericUpDown1txt)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox2txt)
        Controls.Add(Label2)
        Controls.Add(TextBox1txt)
        Controls.Add(Label1)
        Font = New Font("Segoe UI Black", 9.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Name = "Booking"
        Text = "Booking"
        CType(NumericUpDown1txt, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1txt As TextBox
    Friend WithEvents TextBox2txt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown1txt As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
