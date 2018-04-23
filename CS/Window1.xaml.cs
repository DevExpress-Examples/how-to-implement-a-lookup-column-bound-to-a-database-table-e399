using System.Data;
using System.Windows;

namespace WpfApplication1 {

    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }
    }

    public static class NWindData {
        static nwindDataSet ds;
        static NWindData() {
            ds = new nwindDataSet();
            nwindDataSetTableAdapters.CategoriesTableAdapter categoriesAdapter = 
                new nwindDataSetTableAdapters.CategoriesTableAdapter();
            nwindDataSetTableAdapters.ProductsTableAdapter productsAdapter = 
                new nwindDataSetTableAdapters.ProductsTableAdapter();
            categoriesAdapter.Fill(ds.Categories);
            productsAdapter.Fill(ds.Products);
        }

        public static DataView Products { get { return ds.Products.DefaultView; } }
        public static DataView Categories { get { return ds.Categories.DefaultView; } }
    }
}
