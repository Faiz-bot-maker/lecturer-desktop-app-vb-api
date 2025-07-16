<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNilaiEdit
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
        Me.nudNilai = New System.Windows.Forms.NumericUpDown()
        Me.btnSimpannilai = New System.Windows.Forms.Button()
        CType(Me.nudNilai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudNilai
        '
        Me.nudNilai.Location = New System.Drawing.Point(81, 33)
        Me.nudNilai.Margin = New System.Windows.Forms.Padding(2)
        Me.nudNilai.Name = "nudNilai"
        Me.nudNilai.Size = New System.Drawing.Size(92, 20)
        Me.nudNilai.TabIndex = 13
        '
        'btnSimpannilai
        '
        Me.btnSimpannilai.Location = New System.Drawing.Point(81, 75)
        Me.btnSimpannilai.Name = "btnSimpannilai"
        Me.btnSimpannilai.Size = New System.Drawing.Size(92, 23)
        Me.btnSimpannilai.TabIndex = 12
        Me.btnSimpannilai.Text = "SIMPAN"
        Me.btnSimpannilai.UseVisualStyleBackColor = True
        '
        'FormNilaiEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(254, 124)
        Me.Controls.Add(Me.nudNilai)
        Me.Controls.Add(Me.btnSimpannilai)
        Me.Name = "FormNilaiEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Nilai"
        CType(Me.nudNilai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents nudNilai As NumericUpDown
    Friend WithEvents btnSimpannilai As Button
End Class
