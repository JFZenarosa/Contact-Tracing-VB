<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QRscan
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
        Me.QRread = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.pictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QRread
        '
        Me.QRread.Location = New System.Drawing.Point(338, 388)
        Me.QRread.Name = "QRread"
        Me.QRread.Size = New System.Drawing.Size(139, 41)
        Me.QRread.TabIndex = 12
        Me.QRread.Text = "Read QR"
        Me.QRread.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Maroon
        Me.label2.Location = New System.Drawing.Point(102, 13)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(281, 25)
        Me.label2.TabIndex = 9
        Me.label2.Text = "Scan your QR Code here!"
        '
        'pictureBox
        '
        Me.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox.Location = New System.Drawing.Point(12, 50)
        Me.pictureBox.Name = "pictureBox"
        Me.pictureBox.Size = New System.Drawing.Size(465, 321)
        Me.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox.TabIndex = 8
        Me.pictureBox.TabStop = False
        '
        'QRscan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 443)
        Me.Controls.Add(Me.QRread)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.pictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "QRscan"
        Me.Text = "QRscan"
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents QRread As Button
    Private WithEvents label2 As Label
    Private WithEvents pictureBox As PictureBox
End Class
