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
        Me.components = New System.ComponentModel.Container()
        Me.DgAsset = New System.Windows.Forms.DataGridView()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnGenerate = New System.Windows.Forms.Button()
        Me.BtnLoad = New System.Windows.Forms.Button()
        Me.BarcodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DgAsset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarcodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DgAsset.Location = New System.Drawing.Point(12, 85)
        Me.DgAsset.Name = "DgAsset"
        Me.DgAsset.ReadOnly = True
        Me.DgAsset.Size = New System.Drawing.Size(350, 458)
        Me.DgAsset.TabIndex = 0
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Image = Global.BarcodeGenerator.My.Resources.Resources._Exit
        Me.BtnKeluar.Location = New System.Drawing.Point(269, 21)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(75, 58)
        Me.BtnKeluar.TabIndex = 4
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Image = Global.BarcodeGenerator.My.Resources.Resources.Clear
        Me.BtnClear.Location = New System.Drawing.Point(188, 21)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 58)
        Me.BtnClear.TabIndex = 3
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnGenerate
        '
        Me.BtnGenerate.Image = Global.BarcodeGenerator.My.Resources.Resources.Generate2
        Me.BtnGenerate.Location = New System.Drawing.Point(107, 21)
        Me.BtnGenerate.Name = "BtnGenerate"
        Me.BtnGenerate.Size = New System.Drawing.Size(75, 58)
        Me.BtnGenerate.TabIndex = 2
        Me.BtnGenerate.Text = "Generate"
        Me.BtnGenerate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGenerate.UseVisualStyleBackColor = True
        '
        'BtnLoad
        '
        Me.BtnLoad.Image = Global.BarcodeGenerator.My.Resources.Resources.Load
        Me.BtnLoad.Location = New System.Drawing.Point(26, 21)
        Me.BtnLoad.Name = "BtnLoad"
        Me.BtnLoad.Size = New System.Drawing.Size(75, 58)
        Me.BtnLoad.TabIndex = 1
        Me.BtnLoad.Text = "Load"
        Me.BtnLoad.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnLoad.UseVisualStyleBackColor = True
        '
        'Frm_Generate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 555)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnGenerate)
        Me.Controls.Add(Me.BtnLoad)
        Me.Controls.Add(Me.DgAsset)
        Me.Name = "Frm_Generate"
        Me.Text = "Generate Barcode"
        CType(Me.DgAsset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarcodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgAsset As System.Windows.Forms.DataGridView
    Friend WithEvents BtnLoad As System.Windows.Forms.Button
    Friend WithEvents BarcodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BtnGenerate As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button

End Class
