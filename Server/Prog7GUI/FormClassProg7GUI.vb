'----------------------------------------------
' Name: Quang Tran
' Date: Date the project is created
' Description: Program7
'              Class FormClassProg7GUI
'----------------------------------------------
Public Class FormClassProg7GUI
   Private formEmp As New UWPCS3340.FormGridClass
   Private formProd As New UWPCS3340.FormGridClass
   Private formCustomer As New UWPCS3340.FormGridClass
   Private formOrder As New FormOrderClass
   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      formEmp.Show()
      formEmp.BringToFront()
   End Sub


   Private Sub FormClassProg7GUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      formEmp.MainForm = Me
      formEmp.Text = "Employees"
      formEmp.TheTable = DataClass.employeeTbl
      formEmp.TheAdapter = DataClass.employeeAdapter


      formCustomer.MainForm = Me
      formCustomer.Text = "Customers"
      formCustomer.TheTable = DataClass.customerTbl
      formCustomer.TheAdapter = DataClass.customerAdapter


      formProd.MainForm = Me
      formProd.Text = "Products"
      formProd.TheTable = DataClass.productTbl
      formProd.TheAdapter = DataClass.productAdapter
   End Sub

   Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
      formProd.Show()
      formProd.BringToFront()
   End Sub

   Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
      formCustomer.Show()
      formCustomer.BringToFront()
   End Sub

   Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
      formOrder.theForm = Me
      Me.Hide()
      formOrder.Show()
      formOrder.BringToFront()
   End Sub

   Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
      Application.Exit()
   End Sub

   Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
      MessageBox.Show(DataClass.myCon.DataSource)
   End Sub
End Class
