<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbsenAdd
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
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.cbSchedule = New System.Windows.Forms.ComboBox()
        Me.btnSimpanAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Hadir", "Tidak Hadir"})
        Me.cbStatus.Location = New System.Drawing.Point(23, 30)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(144, 21)
        Me.cbStatus.TabIndex = 0
        '
        'cbSchedule
        '
        Me.cbSchedule.FormattingEnabled = True
        Me.cbSchedule.Location = New System.Drawing.Point(222, 30)
        Me.cbSchedule.Name = "cbSchedule"
        Me.cbSchedule.Size = New System.Drawing.Size(144, 21)
        Me.cbSchedule.TabIndex = 1
        '
        'btnSimpanAdd
        '
        Me.btnSimpanAdd.Location = New System.Drawing.Point(222, 93)
        Me.btnSimpanAdd.Name = "btnSimpanAdd"
        Me.btnSimpanAdd.Size = New System.Drawing.Size(144, 27)
        Me.btnSimpanAdd.TabIndex = 2
        Me.btnSimpanAdd.Text = "Simpan"
        Me.btnSimpanAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(219, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Jadwal"
        '
        'FormAbsenAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(392, 132)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSimpanAdd)
        Me.Controls.Add(Me.cbSchedule)
        Me.Controls.Add(Me.cbStatus)
        Me.Name = "FormAbsenAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tambah Absen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents cbSchedule As ComboBox
    Friend WithEvents btnSimpanAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
