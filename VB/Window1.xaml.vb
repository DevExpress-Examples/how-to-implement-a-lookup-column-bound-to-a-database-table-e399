Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Windows

Namespace WpfApplication1

	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class

	Public NotInheritable Class NWindData
		Private Shared ds As nwindDataSet
		Private Sub New()
		End Sub
		Shared Sub New()
			ds = New nwindDataSet()
			Dim categoriesAdapter As New nwindDataSetTableAdapters.CategoriesTableAdapter()
			Dim productsAdapter As New nwindDataSetTableAdapters.ProductsTableAdapter()
			categoriesAdapter.Fill(ds.Categories)
			productsAdapter.Fill(ds.Products)
		End Sub

		Public Shared ReadOnly Property Products() As DataView
			Get
				Return ds.Products.DefaultView
			End Get
		End Property
		Public Shared ReadOnly Property Categories() As DataView
			Get
				Return ds.Categories.DefaultView
			End Get
		End Property
	End Class
End Namespace
