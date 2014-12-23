'----------------------------------------------
' Name: Quang Tran
' Date: Date the project is created
' Description: Program7
'              Class FormOrderClass
'----------------------------------------------
Public Class FormOrderClass
   Private orderView As New DataView()

   Private detailView As New DataView(DataClass.detailTbl)

   Private orderBinding As New BindingSource

   Private employeeBinding As New BindingSource

   Private _mainForm As Form
   Public WriteOnly Property theForm
      Set(value)
         _mainForm = value
      End Set
   End Property

   Private Sub FormOrderClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      dgvDetail.DataSource = detailView

      orderView.Table = DataClass.orderTbl

      orderBinding.DataSource = orderView

      ' Binding DataGridView to DataView
      dgvOrder.DataSource = orderBinding
      dgvDetail.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
      dgvDetail.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
      dgvDetail.Columns(4).DefaultCellStyle.Format = "c"
      dgvDetail.Columns(3).DefaultCellStyle.Format = "c"
      employeeBinding.DataSource = DataClass.employeeTbl

   End Sub

   Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnNext.Click
      employeeBinding.MoveNext()
      btnPrevious.Enabled = True
      If employeeBinding.Position = employeeBinding.Count - 1 Then
         btnNext.Enabled = False
      End If

   End Sub

   Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
      employeeBinding.MovePrevious()
      btnNext.Enabled = True
      If employeeBinding.Position = 0 Then
         btnPrevious.Enabled = False
      End If
   End Sub

   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      Try
         Me.Validate()
         dgvOrder.EndEdit()
         DataClass.orderAdapter.Update(DataClass.orderTbl)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
         DataClass.orderTbl.RejectChanges()
         dgvOrder.ShowRowErrors = False
      End Try
   End Sub

   Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
      Try
         Me.Validate()
         dgvDetail.EndEdit()
         DataClass.detailAdapter.Update(DataClass.detailTbl)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
         DataClass.detailTbl.RejectChanges()
         dgvDetail.ShowRowErrors = False
      End Try
   End Sub

   Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAll.CheckedChanged
      txtID.DataBindings.Clear()
      txtName.DataBindings.Clear()

      If rdoAll.Checked Then
         txtID.Text = ""
         txtName.Text = ""
         btnPrevious.Enabled = False
         btnNext.Enabled = False

         ' No conditions: retrieve all orders
         orderView.RowFilter = ""

      ElseIf rdoEmp.Checked Then
         ' Select the first Employee
         employeeBinding.Position = 0

         btnPrevious.Enabled = False
         If employeeBinding.Count > 1 Then
            btnNext.Enabled = True
         Else
            btnNext.Enabled = False
         End If

         txtID.DataBindings.Add("text", employeeBinding, "EmployeeID")
         txtName.DataBindings.Add("text", employeeBinding, "Name")
         orderView.RowFilter = "EmployeeID = '" & txtID.Text & "'"
      End If
   End Sub

   Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles rdoEmp.CheckedChanged
      txtID.DataBindings.Clear()
      txtName.DataBindings.Clear()


      txtID.DataBindings.Clear()
      txtName.DataBindings.Clear()

      If rdoAll.Checked Then
         txtID.Text = ""
         txtName.Text = ""
         btnPrevious.Enabled = False
         btnNext.Enabled = False

         ' No conditions: retrieve all orders
         orderView.RowFilter = ""

      ElseIf rdoEmp.Checked Then
         ' Select the first Employee
         employeeBinding.Position = 0

         btnPrevious.Enabled = False
         If employeeBinding.Count > 1 Then
            btnNext.Enabled = True
         Else
            btnNext.Enabled = False
         End If

         txtID.DataBindings.Add("text", employeeBinding, "EmployeeID")
         txtName.DataBindings.Add("text", employeeBinding, "Name")
         orderView.RowFilter = "EmployeeID = '" & txtID.Text & "'"
      End If
   End Sub

   Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

   End Sub

   Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
      Me.Hide()
      _mainForm.Show()
      _mainForm.BringToFront()
   End Sub

   Private Sub dgvOrder_SelectionChanged(sender As Object, e As EventArgs) Handles dgvOrder.SelectionChanged
      Dim ID As String

      '' Current is the current row of orderBinding
      '' The first column is ID
      'ID = orderBinding.Current(0).ToString()

      'detailView.RowFilter = "OrderID = " & ID

      ' We need this condition!!!
      If orderBinding.Position <> -1 Then
         ' Get the OrderID of the current row of orderBinding
         ' OrderID is the first column
         ' Use ToString to convert DBNull to an empty string
         ID = orderBinding.Current(0).ToString()

         If ID <> "" Then
            detailView.RowFilter = "OrderID = " & ID
         Else
            ' False for all records
            detailView.RowFilter = "1 = 0"
         End If
      Else
         ' False for all records
         detailView.RowFilter = "2 = 1"
      End If

   End Sub
End Class