'----------------------------------------------
' Name: Quang Tran
' Date: Date the project is created
' Description: Program7
'              Class DataClass
'----------------------------------------------
Public Class DataClass
   Public Shared myCon As New OleDb.OleDbConnection

   Public Shared employeeTbl As New System.Data.DataTable
   Public Shared employeeCmd As New OleDb.OleDbCommand
   Public Shared employeeAdapter As New OleDb.OleDbDataAdapter
   Public Shared employeeBuilder As New OleDb.OleDbCommandBuilder

   Public Shared productTbl As New System.Data.DataTable
   Public Shared productCmd As New OleDb.OleDbCommand
   Public Shared productAdapter As New OleDb.OleDbDataAdapter
   Public Shared productBuilder As New OleDb.OleDbCommandBuilder

   Public Shared customerTbl As New System.Data.DataTable
   Public Shared customerCmd As New OleDb.OleDbCommand
   Public Shared customerAdapter As New OleDb.OleDbDataAdapter
   Public Shared customerBuilder As New OleDb.OleDbCommandBuilder

   Public Shared orderTbl As New System.Data.DataTable("Orders")
   Public Shared orderCmd As New OleDb.OleDbCommand
   Public Shared orderAdapter As New OleDb.OleDbDataAdapter
   Public Shared orderBuilder As New OleDb.OleDbCommandBuilder

   Public Shared detailTbl As New System.Data.DataTable
   Public Shared detailCmd As New OleDb.OleDbCommand
   Public Shared detailAdapter As New OleDb.OleDbDataAdapter
   Public Shared detailBuilder As New OleDb.OleDbCommandBuilder

   Public Shared Sub setUpTable()
      Dim dblocation As String
      Dim connString As String
      Dim connected As Boolean = False
      myCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\temp\Company.mdb"
      While Not connected
         Try
            employeeCmd.Connection = myCon
            employeeCmd.CommandType = CommandType.Text
            employeeCmd.CommandText = "Select * from employees"
            employeeAdapter.SelectCommand = employeeCmd
            employeeBuilder = New OleDb.OleDbCommandBuilder(employeeAdapter)
            employeeAdapter.FillSchema(employeeTbl, SchemaType.Source)
            employeeAdapter.Fill(employeeTbl)

            customerCmd.Connection = myCon
            customerCmd.CommandType = CommandType.Text
            customerCmd.CommandText = "Select * from Customers"
            customerAdapter.SelectCommand = customerCmd
            customerBuilder = New OleDb.OleDbCommandBuilder(customerAdapter)
            customerAdapter.FillSchema(customerTbl, SchemaType.Source)
            customerAdapter.Fill(customerTbl)

            productCmd.Connection = myCon
            productCmd.CommandType = CommandType.Text
            productCmd.CommandText = "Select * from products"
            productAdapter.SelectCommand = productCmd
            productBuilder = New OleDb.OleDbCommandBuilder(productAdapter)
            productAdapter.FillSchema(productTbl, SchemaType.Source)
            productAdapter.Fill(productTbl)
            connected = True

            orderCmd.Connection = myCon
            orderCmd.CommandType = CommandType.Text
            orderCmd.CommandText = "Select * from orders"
            orderAdapter.SelectCommand = orderCmd

            orderBuilder = New OleDb.OleDbCommandBuilder(orderAdapter)
            orderAdapter.Fill(orderTbl)

            ' Table detail
            detailCmd.Connection = myCon
            detailCmd.CommandType = CommandType.Text
            detailCmd.CommandText = "Select * from orderDetails"
            detailAdapter.SelectCommand = detailCmd

            detailBuilder = New OleDb.OleDbCommandBuilder(detailAdapter)
            detailAdapter.Fill(detailTbl)

         Catch ex As Exception
            Dim openDB As New OpenFileDialog
            If openDB.ShowDialog() = Windows.Forms.DialogResult.OK Then
               dblocation = openDB.FileName
               connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
               connString &= dblocation
               myCon.ConnectionString = connString
            Else
               MessageBox.Show("No database selected!")
               Exit While
            End If
         End Try
      End While




   End Sub
End Class
