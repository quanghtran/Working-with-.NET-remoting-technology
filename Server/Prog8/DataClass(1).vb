Public Class DataClass
   Private Shared myCon As New OleDb.OleDbConnection

   Friend Shared employeeTbl As New System.Data.DataTable
   Private Shared employeeCmd As New OleDb.OleDbCommand
   Friend Shared employeeAdapter As New OleDb.OleDbDataAdapter
   Private Shared employeeBuilder As New OleDb.OleDbCommandBuilder

   Private Shared productTbl As New System.Data.DataTable
   Private Shared productCmd As New OleDb.OleDbCommand
   Friend Shared productAdapter As New OleDb.OleDbDataAdapter
   Private Shared productBuilder As New OleDb.OleDbCommandBuilder

   Private Shared customerTbl As New System.Data.DataTable
   Private Shared customerCmd As New OleDb.OleDbCommand
   Friend Shared customerAdapter As New OleDb.OleDbDataAdapter
   Private Shared customerBuilder As New OleDb.OleDbCommandBuilder

   Friend Shared orderTbl As New System.Data.DataTable("Orders")
   Private Shared orderCmd As New OleDb.OleDbCommand
   Friend Shared orderAdapter As New OleDb.OleDbDataAdapter
   Private Shared orderBuilder As New OleDb.OleDbCommandBuilder

   Friend Shared detailTbl As New System.Data.DataTable
   Private Shared detailCmd As New OleDb.OleDbCommand
   Friend Shared detailAdapter As New OleDb.OleDbDataAdapter
   Private Shared detailBuilder As New OleDb.OleDbCommandBuilder

   Friend Shared Sub setUpAdapters()
      Dim dblocation As String
      Dim connString As String
      Dim connected As Boolean = False
      myCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Company.mdb"
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
