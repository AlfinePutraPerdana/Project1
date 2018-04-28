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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxTeam = New System.Windows.Forms.TextBox()
        Me.ButtonDaftar = New System.Windows.Forms.Button()
        Me.ButtonKeluar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBTurnamen = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBBiaya = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BoxTotalHadiah = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "E-Sport Competition"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Team :  "
        '
        'TextBoxTeam
        '
        Me.TextBoxTeam.Location = New System.Drawing.Point(122, 75)
        Me.TextBoxTeam.Name = "TextBoxTeam"
        Me.TextBoxTeam.Size = New System.Drawing.Size(146, 20)
        Me.TextBoxTeam.TabIndex = 2
        '
        'ButtonDaftar
        '
        Me.ButtonDaftar.Location = New System.Drawing.Point(333, 361)
        Me.ButtonDaftar.Name = "ButtonDaftar"
        Me.ButtonDaftar.Size = New System.Drawing.Size(94, 23)
        Me.ButtonDaftar.TabIndex = 6
        Me.ButtonDaftar.Text = "Daftar"
        Me.ButtonDaftar.UseVisualStyleBackColor = True
        '
        'ButtonKeluar
        '
        Me.ButtonKeluar.Location = New System.Drawing.Point(433, 361)
        Me.ButtonKeluar.Name = "ButtonKeluar"
        Me.ButtonKeluar.Size = New System.Drawing.Size(94, 23)
        Me.ButtonKeluar.TabIndex = 7
        Me.ButtonKeluar.Text = "Close"
        Me.ButtonKeluar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "E-mail :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Nomor HP :"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(122, 140)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(146, 20)
        Me.TextBox2.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(122, 109)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(146, 20)
        Me.TextBox3.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Pilih Turnamen :"
        '
        'CBTurnamen
        '
        Me.CBTurnamen.FormattingEnabled = True
        Me.CBTurnamen.Items.AddRange(New Object() {"Dota 2", "CounterStrike : Global Offensive", "Player Unknown's Battleground"})
        Me.CBTurnamen.Location = New System.Drawing.Point(122, 175)
        Me.CBTurnamen.Name = "CBTurnamen"
        Me.CBTurnamen.Size = New System.Drawing.Size(184, 21)
        Me.CBTurnamen.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Biaya Pendaftaran :"
        '
        'TBBiaya
        '
        Me.TBBiaya.Location = New System.Drawing.Point(122, 215)
        Me.TBBiaya.Name = "TBBiaya"
        Me.TBBiaya.Size = New System.Drawing.Size(119, 20)
        Me.TBBiaya.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Total Hadiah :"
        '
        'BoxTotalHadiah
        '
        Me.BoxTotalHadiah.Location = New System.Drawing.Point(122, 271)
        Me.BoxTotalHadiah.Name = "BoxTotalHadiah"
        Me.BoxTotalHadiah.Size = New System.Drawing.Size(119, 20)
        Me.BoxTotalHadiah.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 404)
        Me.Controls.Add(Me.BoxTotalHadiah)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TBBiaya)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBTurnamen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonKeluar)
        Me.Controls.Add(Me.ButtonDaftar)
        Me.Controls.Add(Me.TextBoxTeam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form Pendaftaran"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTeam As System.Windows.Forms.TextBox
    Friend WithEvents ButtonDaftar As System.Windows.Forms.Button
    Friend WithEvents ButtonKeluar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBTurnamen As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBBiaya As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BoxTotalHadiah As System.Windows.Forms.TextBox

End Class
