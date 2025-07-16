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
        Me.SuspendLayout()
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Hadir", "Tidak Hadir"})
        Me.cbStatus.Location = New System.Drawing.Point(103, 58)
        Me.cbStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(191, 24)
        Me.cbStatus.TabIndex = 0
        '
        'cbSchedule
        '
        Me.cbSchedule.FormattingEnabled = True
        Me.cbSchedule.Location = New System.Drawing.Point(103, 137)
        Me.cbSchedule.Margin = New System.Windows.Forms.Padding(4)
        Me.cbSchedule.Name = "cbSchedule"
        Me.cbSchedule.Size = New System.Drawing.Size(191, 24)
        Me.cbSchedule.TabIndex = 1
        '
        'btnSimpanAdd
        '
        Me.btnSimpanAdd.Location = New System.Drawing.Point(131, 192)
        Me.btnSimpanAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSimpanAdd.Name = "btnSimpanAdd"
        Me.btnSimpanAdd.Size = New System.Drawing.Size(136, 33)
        Me.btnSimpanAdd.TabIndex = 2
        Me.btnSimpanAdd.Text = "Simpan"
        Me.btnSimpanAdd.UseVisualStyleBackColor = True
        '
        'FormAbsenAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 277)
        Me.Controls.Add(Me.btnSimpanAdd)
        Me.Controls.Add(Me.cbSchedule)
        Me.Controls.Add(Me.cbStatus)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormAbsenAdd"
        Me.Text = "FormAbsenAdd"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents cbSchedule As ComboBox
    Friend WithEvents btnSimpanAdd As Button
End Class
