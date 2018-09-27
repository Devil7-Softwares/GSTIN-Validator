<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.txt_GSTIN = New System.Windows.Forms.TextBox()
        Me.lbl_Result = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_GSTIN
        '
        Me.txt_GSTIN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_GSTIN.Location = New System.Drawing.Point(64, 12)
        Me.txt_GSTIN.Name = "txt_GSTIN"
        Me.txt_GSTIN.Size = New System.Drawing.Size(330, 20)
        Me.txt_GSTIN.TabIndex = 0
        '
        'lbl_Result
        '
        Me.lbl_Result.AutoSize = True
        Me.lbl_Result.Location = New System.Drawing.Point(67, 40)
        Me.lbl_Result.Name = "lbl_Result"
        Me.lbl_Result.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Result.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "GSTIN :"
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 66)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Result)
        Me.Controls.Add(Me.txt_GSTIN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Main"
        Me.Text = "GSTIN Validator - Example"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_GSTIN As TextBox
    Friend WithEvents lbl_Result As Label
    Friend WithEvents Label1 As Label
End Class
