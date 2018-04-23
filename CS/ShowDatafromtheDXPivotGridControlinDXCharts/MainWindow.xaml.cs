using System.Data;
using System.Data.OleDb;
using System.Windows;
using DevExpress.Xpf.PivotGrid;
using HowToBindToMDB.NwindDataSetTableAdapters;
using DevExpress.XtraPivotGrid;

namespace HowToBindToMDB {
    public partial class MainWindow : Window {
        NwindDataSet.SalesPersonDataTable salesPersonDataTable = 
            new NwindDataSet.SalesPersonDataTable();

        SalesPersonTableAdapter salesPersonDataAdapter = 
            new SalesPersonTableAdapter();

        int minSum = 500;

        public MainWindow() {
            InitializeComponent();
            pivotGridControl1.DataSource = salesPersonDataTable;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            salesPersonDataAdapter.Fill(salesPersonDataTable);
        }
    }
}
