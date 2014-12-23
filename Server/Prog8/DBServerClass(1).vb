Public Class DBServerClass
   Inherits MarshalByRefObject
   Public Function getTable(ByVal tableName As String) As DataTable
      Dim tbl As New DataTable


      If tableName.ToLower = "employees" Then
         DataClass.employeeAdapter.Fill(tbl)
         Console.WriteLine("Loading table " & tableName)
      ElseIf (tableName.ToLower = "customers") Then
         DataClass.customerAdapter.Fill(tbl)
         Console.WriteLine("Loading table " & tableName)
      ElseIf (tableName.ToLower = "orderdetails") Then
         DataClass.detailAdapter.Fill(tbl)
         Console.WriteLine("Loading table " & tableName)
      ElseIf (tableName.ToLower = "orders") Then
         DataClass.orderAdapter.Fill(tbl)
         Console.WriteLine("Loading table " & tableName)
      ElseIf (tableName.ToLower = "products") Then
         DataClass.productAdapter.Fill(tbl)
         Console.WriteLine("Loading table " & tableName)
      Else

         Throw New Exception("Invalid table name")
      End If

      Return tbl
   End Function

   Public Sub updateTable(ByVal tableName As String, ByVal theTable As DataTable)
      If tableName.ToLower = "employees" Then
         DataClass.employeeAdapter.Update(theTable)
         Console.WriteLine("Update table " & tableName)
      ElseIf (tableName.ToLower = "customers") Then
         DataClass.customerAdapter.Update(theTable)
         Console.WriteLine("Update table " & tableName)
      ElseIf (tableName.ToLower = "orderdetails") Then
         DataClass.detailAdapter.Update(theTable)
         Console.WriteLine("Update table " & tableName)
      ElseIf (tableName.ToLower = "orders") Then
         DataClass.orderAdapter.Update(theTable)
         Console.WriteLine("Update table " & tableName)
      ElseIf (tableName.ToLower = "products") Then
         DataClass.productAdapter.Update(theTable)
         Console.WriteLine("Update table " & tableName)
      Else
         Throw New Exception("Invalid table name")
      End If
   End Sub
   Public Sub New()
      DataClass.setUpAdapters()
   End Sub
End Class
