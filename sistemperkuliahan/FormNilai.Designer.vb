<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNilai
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
        Me.tugas = New System.Windows.Forms.Label()
        Me.btnSimpannilai = New System.Windows.Forms.Button()
        Me.cbNilai = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudNilai = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudNilai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tugas
        '
        Me.tugas.AutoSize = True
        Me.tugas.Location = New System.Drawing.Point(293, 30)
        Me.tugas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tugas.Name = "tugas"
        Me.tugas.Size = New System.Drawing.Size(99, 16)
        Me.tugas.TabIndex = 4
        Me.tugas.Text = "Masukkan Nilai"
        '
        'btnSimpannilai
        '
        Me.btnSimpannilai.Location = New System.Drawing.Point(293, 116)
        Me.btnSimpannilai.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSimpannilai.Name = "btnSimpannilai"
        Me.btnSimpannilai.Size = New System.Drawing.Size(113, 28)
        Me.btnSimpannilai.TabIndex = 9
        Me.btnSimpannilai.Text = "SIMPAN"
        Me.btnSimpannilai.UseVisualStyleBackColor = True
        '
        'cbNilai
        '
        Me.cbNilai.FormattingEnabled = True
        Me.cbNilai.Location = New System.Drawing.Point(43, 53)
        Me.cbNilai.Margin = New System.Windows.Forms.Padding(4)
        Me.cbNilai.Name = "cbNilai"
        Me.cbNilai.Size = New System.Drawing.Size(160, 24)
        Me.cbNilai.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Pilih Nilai"
        '
        'nudNilai
        '
        Me.nudNilai.Location = New System.Drawing.Point(296, 55)
        Me.nudNilai.Name = "nudNilai"
        Me.nudNilai.Size = New System.Drawing.Size(120, 22)
        Me.nudNilai.TabIndex = 11
        '
        'FormNilai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 161)
        Me.Controls.Add(Me.nudNilai)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSimpannilai)
        Me.Controls.Add(Me.cbNilai)
        Me.Controls.Add(Me.tugas)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormNilai"
        Me.Text = "FormNilai"
        CType(Me.nudNilai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tugas As Label
    Friend WithEvents btnSimpannilai As Button
    Friend WithEvents cbNilai As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents nudNilai As NumericUpDown
End Class
