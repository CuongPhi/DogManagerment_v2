using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for ListStaff.xaml
    /// </summary>
    public partial class ListStaff : UserControl
    {
        List<Object> _ListStaff = new List<Object>();

        public ListStaff()
        {
            InitializeComponent();
            RunningProgressBar(Visibility.Hidden);

        }
        public void LoadListStaff()
        {
            RunningProgressBar(Visibility.Visible);
            Thread thread = new Thread(new ThreadStart(loadFromData));
            thread.Start();
        }
        void loadFromData()
        {
            _ListStaff = UserBUS.GetAll();
            SetDataSource(_ListStaff);
        }
        internal delegate void SetDataSourceDelegate(List<Object> ls);

        void SetDataSource(List<Object> t) 
        {
            if (!this.Dispatcher.CheckAccess())
            {
                this.Dispatcher.Invoke(new SetDataSourceDelegate(SetDataSource), t);
            }
            else
            {
                lvListStaff.ItemsSource = t;
                RunningProgressBar(Visibility.Hidden);
            }
        }
        void RunningProgressBar(Visibility t)
        {
            prgb.Visibility = lbprgrb.Visibility = t;
        }
        bool InsertUserApp(USERAPP obj)
        {
            return UserBUS.Insert(obj) != null;
        }

        private void UCNhanVien_Loaded(object sender, RoutedEventArgs e)
        {
            LoadListStaff();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void lvListStaff_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           Object t = lvListStaff.SelectedItem;
            SelectedItemWraPnel.DataContext = t;
        }
    }
}
