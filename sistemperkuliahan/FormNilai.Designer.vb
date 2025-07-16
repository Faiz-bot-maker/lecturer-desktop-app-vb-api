<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNilai
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
        Me.txtNilai = New System.Windows.Forms.TextBox()
        Me.tugas = New System.Windows.Forms.Label()
        Me.cbNilai = New System.Windows.Forms.ComboBox()
        Me.btnSimpannilai = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNilai
        '
        Me.txtNilai.Location = New System.Drawing.Point(220, 43)
        Me.txtNilai.Multiline = True
        Me.txtNilai.Name = "txtNilai"
        Me.txtNilai.Size = New System.Drawing.Size(85, 45)
        Me.txtNilai.TabIndex = 0
        '
        'tugas
        '
        Me.tugas.AutoSize = True
        Me.tugas.Location = New System.Drawing.Point(220, 24)
        Me.tugas.Name = "tugas"
        Me.tugas.Size = New System.Drawing.Size(80, 13)
        Me.tugas.TabIndex = 4
        Me.tugas.Text = "Masukkan Nilai"
        '
        'cbNilai
        '
        Me.cbNilai.FormattingEnabled = True
        Me.cbNilai.Location = New System.Drawing.Point(32, 43)
        Me.cbNilai.Name = "cbNilai"
        Me.cbNilai.Size = New System.Drawing.Size(121, 21)
        Me.cbNilai.TabIndex = 8
        '
        'btnSimpannilai
        '
        Me.btnSimpannilai.Location = New System.Drawing.Point(220, 94)
        Me.btnSimpannilai.Name = "btnSimpannilai"
        Me.btnSimpannilai.Size = New System.Drawing.Size(85, 23)
        Me.btnSimpannilai.TabIndex = 9
        Me.btnSimpannilai.Text = "SIMPAN"
        Me.btnSimpannilai.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Pilih Nilai"
        '
        'FormNilai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 131)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSimpannilai)
        Me.Controls.Add(Me.cbNilai)
        Me.Controls.Add(Me.tugas)
        Me.Controls.Add(Me.txtNilai)
        Me.Name = "FormNilai"
        Me.Text = "FormNilai"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNilai As TextBox
    Friend WithEvents tugas As Label
    Friend WithEvents cbNilai As ComboBox
    Friend WithEvents btnSimpannilai As Button
    Friend WithEvents Label1 As Label
End Class
