using BUS;
using Microsoft.Win32;
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
            try
            {
                foreach (var dog in _ListDogs)
                {
                    var getProp = dog.GetType().GetProperty("IMAGES");
                    var newValue = Convert.ChangeType(UIProcess.Inst.LoadImage((byte[])getProp.GetValue(dog, null)), getProp.PropertyType);
                    getProp.SetValue(dog, newValue, null);
                }
            }
            catch { }
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
        // tính tổng tiền phạt chủ = 500k (tiền phạt) + tiền thúc ăn * số ngày + cân nặng * (5000 || 7000 || 9000 tùy loại chó)

        private void dogBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Object t = dogBox.SelectedItem;           
            SelectedItemBinding.DataContext = t;
            int TypePrice = 0;
            switch (txbIDTypeDog.Text)
            {
                case "DTYPE_1":
                    TypePrice = 5000;
                    break;
                case "DTYPE_2":
                    TypePrice = 7000;
                    break;
                case "DTYPE_3":
                    TypePrice = 9000;
                    break;
                default:
                    break;
            }
            txbTotalPrice.Text = (double.Parse(txbFine.Text) +
                double.Parse(txbFoodPrice.Text) * double.Parse(txbNumofDay.Text)
                + TypePrice * double.Parse(txbWeight.Text))
                .ToString();

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Border_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ImageDogBinding_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            string fileName = op.FileName;
            if (string.IsNullOrEmpty(fileName))
                return;
            ImageDogBinding.Source = new BitmapImage(new Uri(fileName));
        }
    }
}
