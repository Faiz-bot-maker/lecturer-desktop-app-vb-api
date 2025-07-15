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
        Me.cbStatus.Location = New System.Drawing.Point(61, 53)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(121, 21)
        Me.cbStatus.TabIndex = 0
        '
        'btnSimpanEdit
        '
        Me.btnSimpanEdit.Location = New System.Drawing.Point(80, 93)
        Me.btnSimpanEdit.Name = "btnSimpanEdit"
        Me.btnSimpanEdit.Size = New System.Drawing.Size(102, 27)
        Me.btnSimpanEdit.TabIndex = 1
        Me.btnSimpanEdit.Text = "Simpan"
        Me.btnSimpanEdit.UseVisualStyleBackColor = True
        '
        'FormAbsenEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 132)
        Me.Controls.Add(Me.btnSimpanEdit)
        Me.Controls.Add(Me.cbStatus)
        Me.Name = "FormAbsenEdit"
        Me.Text = "FormAbsenEdit"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents btnSimpanEdit As Button
End Class
