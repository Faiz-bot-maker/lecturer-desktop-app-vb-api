<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbsenEdit
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
        Me.btnSimpanEdit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Hadir", "Tidak Hadir"})
        Me.cbStatus.Location = New System.Drawing.Point(81, 65)
        Me.cbStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(160, 24)
        Me.cbStatus.TabIndex = 0
        '
        'btnSimpanEdit
        '
        Me.btnSimpanEdit.Location = New System.Drawing.Point(107, 114)
        Me.btnSimpanEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSimpanEdit.Name = "btnSimpanEdit"
        Me.btnSimpanEdit.Size = New System.Drawing.Size(136, 33)
        Me.btnSimpanEdit.TabIndex = 1
        Me.btnSimpanEdit.Text = "Simpan"
        Me.btnSimpanEdit.UseVisualStyleBackColor = True
        '
        'FormAbsenEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 162)
        Me.Controls.Add(Me.btnSimpanEdit)
        Me.Controls.Add(Me.cbStatus)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormAbsenEdit"
        Me.Text = "FormAbsenEdit"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents btnSimpanEdit As Button
End Class
