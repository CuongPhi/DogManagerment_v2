using BUS;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace SourceCode
{
    /// <summary>
    /// Interaction logic for Accountant_Handover.xaml
    /// </summary>
    public partial class Accountant_Handover : UserControl
    {
        List<Object> _ListDogs = new List<Object>();

        public Accountant_Handover()
        {
            InitializeComponent();
            RunningProgressBar(Visibility.Hidden);

        }
        public void LoadListDogs()
        {
            RunningProgressBar(Visibility.Visible);
            Thread thread = new Thread(new ThreadStart(loadFromData));
            thread.Start();
        }
        void loadFromData()
        {
            _ListDogs = DogBUS.GetAll();
            SetDataSource(_ListDogs);
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
                dogBox.ItemsSource = t;
                RunningProgressBar(Visibility.Hidden);
            }
        }
        void RunningProgressBar(Visibility t)
        {
            prgb_acc_dog.Visibility = lbprgrb_acc_dog.Visibility = t;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            LoadListDogs();
        }

        private void dogBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Object t = dogBox.SelectedItem;
           
            SelectedItemMaterialCard.DataContext = t;
        }
    }
}
