<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SEDUForm
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Copy64Button = New System.Windows.Forms.Button()
        Me.Clear64Button = New System.Windows.Forms.Button()
        Me.DecodeButton = New System.Windows.Forms.Button()
        Me.EncodeButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Base64ResultTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Base64InputTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ClearHashButton = New System.Windows.Forms.Button()
        Me.CopyHashButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.HashResultDataGridView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.HashInputTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.HashResultDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(438, 450)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Copy64Button)
        Me.TabPage1.Controls.Add(Me.Clear64Button)
        Me.TabPage1.Controls.Add(Me.DecodeButton)
        Me.TabPage1.Controls.Add(Me.EncodeButton)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(430, 424)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Base64"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Copy64Button
        '
        Me.Copy64Button.Location = New System.Drawing.Point(261, 380)
        Me.Copy64Button.Name = "Copy64Button"
        Me.Copy64Button.Size = New System.Drawing.Size(75, 23)
        Me.Copy64Button.TabIndex = 5
        Me.Copy64Button.Text = "Copy"
        Me.Copy64Button.UseVisualStyleBackColor = True
        '
        'Clear64Button
        '
        Me.Clear64Button.Location = New System.Drawing.Point(342, 380)
        Me.Clear64Button.Name = "Clear64Button"
        Me.Clear64Button.Size = New System.Drawing.Size(75, 23)
        Me.Clear64Button.TabIndex = 4
        Me.Clear64Button.Text = "Clear"
        Me.Clear64Button.UseVisualStyleBackColor = True
        '
        'DecodeButton
        '
        Me.DecodeButton.Location = New System.Drawing.Point(89, 380)
        Me.DecodeButton.Name = "DecodeButton"
        Me.DecodeButton.Size = New System.Drawing.Size(75, 23)
        Me.DecodeButton.TabIndex = 3
        Me.DecodeButton.Text = "Decode"
        Me.DecodeButton.UseVisualStyleBackColor = True
        '
        'EncodeButton
        '
        Me.EncodeButton.Location = New System.Drawing.Point(8, 380)
        Me.EncodeButton.Name = "EncodeButton"
        Me.EncodeButton.Size = New System.Drawing.Size(75, 23)
        Me.EncodeButton.TabIndex = 2
        Me.EncodeButton.Text = "Encode"
        Me.EncodeButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Base64ResultTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 149)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(409, 225)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Result"
        '
        'Base64ResultTextBox
        '
        Me.Base64ResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Base64ResultTextBox.Enabled = False
        Me.Base64ResultTextBox.Location = New System.Drawing.Point(6, 19)
        Me.Base64ResultTextBox.Multiline = True
        Me.Base64ResultTextBox.Name = "Base64ResultTextBox"
        Me.Base64ResultTextBox.ReadOnly = True
        Me.Base64ResultTextBox.Size = New System.Drawing.Size(397, 200)
        Me.Base64ResultTextBox.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Base64InputTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'Base64InputTextBox
        '
        Me.Base64InputTextBox.Location = New System.Drawing.Point(6, 19)
        Me.Base64InputTextBox.Multiline = True
        Me.Base64InputTextBox.Name = "Base64InputTextBox"
        Me.Base64InputTextBox.Size = New System.Drawing.Size(397, 103)
        Me.Base64InputTextBox.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ClearHashButton)
        Me.TabPage2.Controls.Add(Me.CopyHashButton)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(430, 424)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Hash"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ClearHashButton
        '
        Me.ClearHashButton.Location = New System.Drawing.Point(340, 371)
        Me.ClearHashButton.Name = "ClearHashButton"
        Me.ClearHashButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearHashButton.TabIndex = 5
        Me.ClearHashButton.Text = "Clear"
        Me.ClearHashButton.UseVisualStyleBackColor = True
        '
        'CopyHashButton
        '
        Me.CopyHashButton.Location = New System.Drawing.Point(259, 371)
        Me.CopyHashButton.Name = "CopyHashButton"
        Me.CopyHashButton.Size = New System.Drawing.Size(75, 23)
        Me.CopyHashButton.TabIndex = 4
        Me.CopyHashButton.Text = "Copy"
        Me.CopyHashButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 371)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Run"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.HashResultDataGridView)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 140)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(409, 225)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Result"
        '
        'HashResultDataGridView
        '
        Me.HashResultDataGridView.AllowUserToAddRows = False
        Me.HashResultDataGridView.AllowUserToDeleteRows = False
        Me.HashResultDataGridView.AllowUserToResizeColumns = False
        Me.HashResultDataGridView.AllowUserToResizeRows = False
        Me.HashResultDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.HashResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HashResultDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.HashResultDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.HashResultDataGridView.Name = "HashResultDataGridView"
        Me.HashResultDataGridView.ReadOnly = True
        Me.HashResultDataGridView.RowHeadersVisible = False
        Me.HashResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.HashResultDataGridView.Size = New System.Drawing.Size(397, 200)
        Me.HashResultDataGridView.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Algorithm"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Hash Value"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.HashInputTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(409, 128)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Input: Text"
        '
        'HashInputTextBox
        '
        Me.HashInputTextBox.AllowDrop = True
        Me.HashInputTextBox.Location = New System.Drawing.Point(6, 19)
        Me.HashInputTextBox.Multiline = True
        Me.HashInputTextBox.Name = "HashInputTextBox"
        Me.HashInputTextBox.Size = New System.Drawing.Size(397, 103)
        Me.HashInputTextBox.TabIndex = 1
        '
        'SEDUForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "SEDUForm"
        Me.ShowIcon = False
        Me.Text = "Simple Encoder/Decoder Utility (SEDU)"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.HashResultDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Clear64Button As Button
    Friend WithEvents DecodeButton As Button
    Friend WithEvents EncodeButton As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Base64ResultTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Base64InputTextBox As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Copy64Button As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents HashInputTextBox As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents HashResultDataGridView As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents ClearHashButton As Button
    Friend WithEvents CopyHashButton As Button
End Class
