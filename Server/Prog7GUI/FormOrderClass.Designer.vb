<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOrderClass
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
      Me.dgvOrder = New System.Windows.Forms.DataGridView()
      Me.dgvDetail = New System.Windows.Forms.DataGridView()
      Me.Button1 = New System.Windows.Forms.Button()
      Me.Button2 = New System.Windows.Forms.Button()
      Me.rdoAll = New System.Windows.Forms.RadioButton()
      Me.btnPrevious = New System.Windows.Forms.Button()
      Me.btnNext = New System.Windows.Forms.Button()
      Me.Button5 = New System.Windows.Forms.Button()
      Me.txtName = New System.Windows.Forms.TextBox()
      Me.txtID = New System.Windows.Forms.TextBox()
      Me.rdoEmp = New System.Windows.Forms.RadioButton()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'dgvOrder
      '
      Me.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.dgvOrder.Location = New System.Drawing.Point(34, 12)
      Me.dgvOrder.Name = "dgvOrder"
      Me.dgvOrder.Size = New System.Drawing.Size(421, 150)
      Me.dgvOrder.TabIndex = 0
      '
      'dgvDetail
      '
      Me.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.dgvDetail.Location = New System.Drawing.Point(34, 197)
      Me.dgvDetail.Name = "dgvDetail"
      Me.dgvDetail.Size = New System.Drawing.Size(421, 150)
      Me.dgvDetail.TabIndex = 1
      '
      'Button1
      '
      Me.Button1.Location = New System.Drawing.Point(34, 168)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(75, 23)
      Me.Button1.TabIndex = 2
      Me.Button1.Text = "SAVE"
      Me.Button1.UseVisualStyleBackColor = True
      '
      'Button2
      '
      Me.Button2.Location = New System.Drawing.Point(34, 353)
      Me.Button2.Name = "Button2"
      Me.Button2.Size = New System.Drawing.Size(75, 23)
      Me.Button2.TabIndex = 3
      Me.Button2.Text = "SAVE"
      Me.Button2.UseVisualStyleBackColor = True
      '
      'rdoAll
      '
      Me.rdoAll.AutoSize = True
      Me.rdoAll.Checked = True
      Me.rdoAll.Location = New System.Drawing.Point(584, 42)
      Me.rdoAll.Name = "rdoAll"
      Me.rdoAll.Size = New System.Drawing.Size(70, 17)
      Me.rdoAll.TabIndex = 4
      Me.rdoAll.TabStop = True
      Me.rdoAll.Text = "All Orders"
      Me.rdoAll.UseVisualStyleBackColor = True
      '
      'btnPrevious
      '
      Me.btnPrevious.Location = New System.Drawing.Point(512, 224)
      Me.btnPrevious.Name = "btnPrevious"
      Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
      Me.btnPrevious.TabIndex = 6
      Me.btnPrevious.Text = "Previous"
      Me.btnPrevious.UseVisualStyleBackColor = True
      '
      'btnNext
      '
      Me.btnNext.Location = New System.Drawing.Point(663, 224)
      Me.btnNext.Name = "btnNext"
      Me.btnNext.Size = New System.Drawing.Size(75, 23)
      Me.btnNext.TabIndex = 7
      Me.btnNext.Text = "Next"
      Me.btnNext.UseVisualStyleBackColor = True
      '
      'Button5
      '
      Me.Button5.Location = New System.Drawing.Point(584, 284)
      Me.Button5.Name = "Button5"
      Me.Button5.Size = New System.Drawing.Size(75, 23)
      Me.Button5.TabIndex = 8
      Me.Button5.Text = "Back"
      Me.Button5.UseVisualStyleBackColor = True
      '
      'txtName
      '
      Me.txtName.BackColor = System.Drawing.SystemColors.Window
      Me.txtName.Location = New System.Drawing.Point(574, 140)
      Me.txtName.Name = "txtName"
      Me.txtName.ReadOnly = True
      Me.txtName.Size = New System.Drawing.Size(100, 20)
      Me.txtName.TabIndex = 9
      '
      'txtID
      '
      Me.txtID.BackColor = System.Drawing.SystemColors.Window
      Me.txtID.Location = New System.Drawing.Point(574, 195)
      Me.txtID.Name = "txtID"
      Me.txtID.ReadOnly = True
      Me.txtID.Size = New System.Drawing.Size(100, 20)
      Me.txtID.TabIndex = 10
      '
      'rdoEmp
      '
      Me.rdoEmp.AutoSize = True
      Me.rdoEmp.Location = New System.Drawing.Point(584, 88)
      Me.rdoEmp.Name = "rdoEmp"
      Me.rdoEmp.Size = New System.Drawing.Size(119, 17)
      Me.rdoEmp.TabIndex = 11
      Me.rdoEmp.TabStop = True
      Me.rdoEmp.Text = "Orders by Employee"
      Me.rdoEmp.UseVisualStyleBackColor = True
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(484, 147)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(84, 13)
      Me.Label1.TabIndex = 12
      Me.Label1.Text = "Employee Name"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(501, 202)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(67, 13)
      Me.Label2.TabIndex = 13
      Me.Label2.Text = "Employee ID"
      '
      'FormOrderClass
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(791, 388)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.rdoEmp)
      Me.Controls.Add(Me.txtID)
      Me.Controls.Add(Me.txtName)
      Me.Controls.Add(Me.Button5)
      Me.Controls.Add(Me.btnNext)
      Me.Controls.Add(Me.btnPrevious)
      Me.Controls.Add(Me.rdoAll)
      Me.Controls.Add(Me.Button2)
      Me.Controls.Add(Me.Button1)
      Me.Controls.Add(Me.dgvDetail)
      Me.Controls.Add(Me.dgvOrder)
      Me.Name = "FormOrderClass"
      Me.Text = "Orders"
      CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents dgvOrder As System.Windows.Forms.DataGridView
   Friend WithEvents dgvDetail As System.Windows.Forms.DataGridView
   Friend WithEvents Button1 As System.Windows.Forms.Button
   Friend WithEvents Button2 As System.Windows.Forms.Button
   Friend WithEvents rdoAll As System.Windows.Forms.RadioButton
   Friend WithEvents btnPrevious As System.Windows.Forms.Button
   Friend WithEvents btnNext As System.Windows.Forms.Button
   Friend WithEvents Button5 As System.Windows.Forms.Button
   Friend WithEvents txtName As System.Windows.Forms.TextBox
   Friend WithEvents txtID As System.Windows.Forms.TextBox
   Friend WithEvents rdoEmp As System.Windows.Forms.RadioButton
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
