<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Generate
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
        Me.DgAsset = New System.Windows.Forms.DataGridView()
        Me.BtnLoad = New System.Windows.Forms.Button()
        Me.BtnGenerate = New System.Windows.Forms.Button()
        CType(Me.DgAsset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgAsset
        '
        Me.DgAsset.AllowUserToAddRows = False
        Me.DgAsset.AllowUserToDeleteRows = False
        Me.DgAsset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgAsset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgAsset.Location = New System.Drawing.Point(12, 55)
        Me.DgAsset.Name = "DgAsset"
        Me.DgAsset.ReadOnly = True
        Me.DgAsset.Size = New System.Drawing.Size(436, 488)
        Me.DgAsset.TabIndex = 0
        '
        'BtnLoad
        '
        Me.BtnLoad.Location = New System.Drawing.Point(12, 12)
        Me.BtnLoad.Name = "BtnLoad"
        Me.BtnLoad.Size = New System.Drawing.Size(75, 37)
        Me.BtnLoad.TabIndex = 1
        Me.BtnLoad.Text = "Load"
        Me.BtnLoad.UseVisualStyleBackColor = True
        '
        'BtnGenerate
        '
        Me.BtnGenerate.Location = New System.Drawing.Point(106, 12)
        Me.BtnGenerate.Name = "BtnGenerate"
        Me.BtnGenerate.Size = New System.Drawing.Size(75, 37)
        Me.BtnGenerate.TabIndex = 1
        Me.BtnGenerate.Text = "Generate"
        Me.BtnGenerate.UseVisualStyleBackColor = True
        '
        'Frm_Generate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 555)
        Me.Controls.Add(Me.BtnGenerate)
        Me.Controls.Add(Me.BtnLoad)
        Me.Controls.Add(Me.DgAsset)
        Me.Name = "Frm_Generate"
        Me.Text = "Generate"
        CType(Me.DgAsset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgAsset As System.Windows.Forms.DataGridView
    Friend WithEvents BtnLoad As System.Windows.Forms.Button
    Friend WithEvents BtnGenerate As System.Windows.Forms.Button

End Class
