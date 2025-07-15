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
        Me.txtTugas = New System.Windows.Forms.TextBox()
        Me.txtUts = New System.Windows.Forms.TextBox()
        Me.txtUas = New System.Windows.Forms.TextBox()
        Me.txtKeaktifan = New System.Windows.Forms.TextBox()
        Me.Tugas = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnSimpannilai = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTugas
        '
        Me.txtTugas.Location = New System.Drawing.Point(58, 95)
        Me.txtTugas.Multiline = True
        Me.txtTugas.Name = "txtTugas"
        Me.txtTugas.Size = New System.Drawing.Size(85, 45)
        Me.txtTugas.TabIndex = 0
        '
        'txtUts
        '
        Me.txtUts.Location = New System.Drawing.Point(58, 185)
        Me.txtUts.Multiline = True
        Me.txtUts.Name = "txtUts"
        Me.txtUts.Size = New System.Drawing.Size(85, 45)
        Me.txtUts.TabIndex = 1
        '
        'txtUas
        '
        Me.txtUas.Location = New System.Drawing.Point(58, 264)
        Me.txtUas.Multiline = True
        Me.txtUas.Name = "txtUas"
        Me.txtUas.Size = New System.Drawing.Size(85, 45)
        Me.txtUas.TabIndex = 2
        '
        'txtKeaktifan
        '
        Me.txtKeaktifan.Location = New System.Drawing.Point(58, 352)
        Me.txtKeaktifan.Multiline = True
        Me.txtKeaktifan.Name = "txtKeaktifan"
        Me.txtKeaktifan.Size = New System.Drawing.Size(85, 45)
        Me.txtKeaktifan.TabIndex = 3
        '
        'Tugas
        '
        Me.Tugas.AutoSize = True
        Me.Tugas.Location = New System.Drawing.Point(58, 76)
        Me.Tugas.Name = "Tugas"
        Me.Tugas.Size = New System.Drawing.Size(44, 13)
        Me.Tugas.TabIndex = 4
        Me.Tugas.Text = "TUGAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "UTS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "UAS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "KEAKTIFAN"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(58, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'btnSimpannilai
        '
        Me.btnSimpannilai.Location = New System.Drawing.Point(255, 415)
        Me.btnSimpannilai.Name = "btnSimpannilai"
        Me.btnSimpannilai.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpannilai.TabIndex = 9
        Me.btnSimpannilai.Text = "SIMPAN"
        Me.btnSimpannilai.UseVisualStyleBackColor = True
        '
        'FormNilai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 450)
        Me.Controls.Add(Me.btnSimpannilai)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Tugas)
        Me.Controls.Add(Me.txtKeaktifan)
        Me.Controls.Add(Me.txtUas)
        Me.Controls.Add(Me.txtUts)
        Me.Controls.Add(Me.txtTugas)
        Me.Name = "FormNilai"
        Me.Text = "FormNilai"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTugas As TextBox
    Friend WithEvents txtUts As TextBox
    Friend WithEvents txtUas As TextBox
    Friend WithEvents txtKeaktifan As TextBox
    Friend WithEvents Tugas As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnSimpannilai As Button
End Class
