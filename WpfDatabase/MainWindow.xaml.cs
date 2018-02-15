using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDatabase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OleDbConnection cn;
        public MainWindow()
        {
            InitializeComponent();
            cn = new OleDbConnection(< Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CUserswadhwakeDocumentsDatabase11.accdb >);

        }

        

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string query = "select * from Assets";

            OleDbCommand cmd = new OleDbCommand(query, cn);

            cn.Open();
            OleDbDataReader read = cmd.ExecuteReader();
        }
    }
}
