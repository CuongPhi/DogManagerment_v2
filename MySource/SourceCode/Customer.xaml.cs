using BUS;
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

namespace SourceCode
{
    /// <summary>
    /// Interaction logic for Customer.xaml
    /// </summary>
    public partial class Customer : UserControl
    {
        private List<object> _listCustomer = null;
        public Customer()
        {
            InitializeComponent();
            loadFromData();
        }
        void loadFromData()
        {
            _listCustomer = CustomerBUS.GetAll();
            listCustomer.ItemsSource = _listCustomer;
            
        }

        private void listCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object t = listCustomer.SelectedItem;
            if (t == null) return;
            binding_data.DataContext = t;
        }
    }
}
