<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbNama = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelRataan = New System.Windows.Forms.Label()
        Me.LabelHadiah = New System.Windows.Forms.Label()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.TextBoxNilai1 = New System.Windows.Forms.TextBox()
        Me.TextBoxNilai2 = New System.Windows.Forms.TextBox()
        Me.TextBoxNilai3 = New System.Windows.Forms.TextBox()
        Me.ButtonHitung = New System.Windows.Forms.Button()
        Me.ButtonUlang = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbNama
        '
        Me.lbNama.AutoSize = True
        Me.lbNama.Location = New System.Drawing.Point(11, 16)
        Me.lbNama.Name = "lbNama"
        Me.lbNama.Size = New System.Drawing.Size(41, 13)
        Me.lbNama.TabIndex = 0
        Me.lbNama.Text = "Nama :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nilai 1 :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nilai 2 :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nilai 3 :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Rataan :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Hadiah :"
        '
        'LabelRataan
        '
        Me.LabelRataan.AutoSize = True
        Me.LabelRataan.Location = New System.Drawing.Point(64, 144)
        Me.LabelRataan.Name = "LabelRataan"
        Me.LabelRataan.Size = New System.Drawing.Size(97, 13)
        Me.LabelRataan.TabIndex = 6
        Me.LabelRataan.Text = ".............................."
        '
        'LabelHadiah
        '
        Me.LabelHadiah.AutoSize = True
        Me.LabelHadiah.Location = New System.Drawing.Point(64, 192)
        Me.LabelHadiah.Name = "LabelHadiah"
        Me.LabelHadiah.Size = New System.Drawing.Size(97, 13)
        Me.LabelHadiah.TabIndex = 7
        Me.LabelHadiah.Text = ".............................."
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(76, 13)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(190, 20)
        Me.TextBoxNama.TabIndex = 8
        '
        'TextBoxNilai1
        '
        Me.TextBoxNilai1.Location = New System.Drawing.Point(76, 39)
        Me.TextBoxNilai1.Name = "TextBoxNilai1"
        Me.TextBoxNilai1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNilai1.TabIndex = 9
        '
        'TextBoxNilai2
        '
        Me.TextBoxNilai2.Location = New System.Drawing.Point(76, 65)
        Me.TextBoxNilai2.Name = "TextBoxNilai2"
        Me.TextBoxNilai2.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNilai2.TabIndex = 10
        '
        'TextBoxNilai3
        '
        Me.TextBoxNilai3.Location = New System.Drawing.Point(76, 91)
        Me.TextBoxNilai3.Name = "TextBoxNilai3"
        Me.TextBoxNilai3.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNilai3.TabIndex = 11
        '
        'ButtonHitung
        '
        Me.ButtonHitung.Location = New System.Drawing.Point(272, 144)
        Me.ButtonHitung.Name = "ButtonHitung"
        Me.ButtonHitung.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHitung.TabIndex = 12
        Me.ButtonHitung.Text = "Hitung"
        Me.ButtonHitung.UseVisualStyleBackColor = True
        '
        'ButtonUlang
        '
        Me.ButtonUlang.Location = New System.Drawing.Point(272, 182)
        Me.ButtonUlang.Name = "ButtonUlang"
        Me.ButtonUlang.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUlang.TabIndex = 13
        Me.ButtonUlang.Text = "Ulang"
        Me.ButtonUlang.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 341)
        Me.Controls.Add(Me.ButtonUlang)
        Me.Controls.Add(Me.ButtonHitung)
        Me.Controls.Add(Me.TextBoxNilai3)
        Me.Controls.Add(Me.TextBoxNilai2)
        Me.Controls.Add(Me.TextBoxNilai1)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.LabelHadiah)
        Me.Controls.Add(Me.LabelRataan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbNama)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbNama As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabelRataan As System.Windows.Forms.Label
    Friend WithEvents LabelHadiah As System.Windows.Forms.Label
    Friend WithEvents TextBoxNama As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNilai1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNilai2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNilai3 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonHitung As System.Windows.Forms.Button
    Friend WithEvents ButtonUlang As System.Windows.Forms.Button

End Class
