'----------------------------------------------
' Name: Quang Tran
' Date: Date the project is created
' Description: Program7
'              Class FormGridClass
'----------------------------------------------
Public Class FormGridClass
   Private _mainForm As Form
   Private _theTable As DataTable
   Private _adapter As OleDb.OleDbDataAdapter

   Public WriteOnly Property MainForm
      Set(value)
         _mainForm = value
      End Set
   End Property
   Public WriteOnly Property TheTable As DataTable
      Set(value As DataTable)
         _theTable = value
      End Set
   End Property
   Public WriteOnly Property TheAdapter
      Set(value)
         _adapter = value
      End Set
   End Property

   Private Sub FormGridClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      BindingSource.DataSource = _theTable
      BindingNavigator.BindingSource = BindingSource
      _adapter.Fill(_theTable)
      DataGrid.DataSource = BindingSource

   End Sub

   Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
      Try
         Me.Validate()
         Me.BindingSource.EndEdit()
         _adapter.Update(_theTable)
         toogle(True)
      Catch ex As Exception
         MsgBox(ex.Message)
      End Try
   End Sub

   Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
      Me.Hide()
      _mainForm.Show()
      _mainForm.BringToFront()
   End Sub



   Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
      _theTable.RejectChanges()
      _adapter.Fill(_theTable)
      DataGrid.DataSource = BindingSource
   End Sub

   Private Sub toogle(ByVal flag)
      ToolStripButton2.Enabled = flag
      ToolStripButton3.Enabled = flag
      If flag = False Then
         BindingNavigator.MoveFirstItem = Nothing
         BindingNavigator.MovePreviousItem = Nothing
         BindingNavigator.MoveNextItem = Nothing
         BindingNavigator.MoveLastItem = Nothing
         BindingNavigatorAddNewItem.Enabled = False
         BindingNavigatorMoveFirstItem.Enabled = False
         BindingNavigatorMovePreviousItem.Enabled = False
         BindingNavigatorMoveNextItem.Enabled = False
         BindingNavigatorMoveLastItem.Enabled = False

      Else
         BindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem
         BindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem
         BindingNavigator.MoveNextItem = BindingNavigatorMoveNextItem
         BindingNavigator.MoveLastItem = BindingNavigatorMoveLastItem
         BindingNavigatorAddNewItem.Enabled = True
         BindingNavigatorMoveFirstItem.Enabled = True
         BindingNavigatorMovePreviousItem.Enabled = True

      End If

   End Sub

   Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
      toogle(False)
   End Sub

   Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
      toogle(True)
   End Sub
End Class
