using MilcanxWpf_SliderMenu;
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
using System.Windows.Shapes;

namespace SourceCode
{
    /// <summary>
    /// Interaction logic for managerWindow.xaml
    /// </summary>
    public partial class managerWindow : Window
    {
        public SliderBar sliderBar = new SliderBar();
        private object uC_MainWindow = null;
        public managerWindow()
        {

            sliderBar.PropertyChanged += SliderBar_PropertyChanged;
            InitializeComponent();
        }

        private void SliderBar_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            UIProcess.Inst.RemoveAllChild(UserControl_MainWindow);
            switch (sliderBar.TypeUC)
            {
                case TypeUserControl.Accountant_Handover:
                    uC_MainWindow = new Accountant_Handover();
                    break;
                case TypeUserControl.Accountant_Statistic_ThisDay:
                    uC_MainWindow = new SliderBar();
                    break;
                case TypeUserControl.Staff_List:
                    uC_MainWindow = new NhanVien();
                    break;
                case TypeUserControl.Manager_ListStaff:
                    uC_MainWindow = new ListStaff();
                    break;
            }
            UserControl_MainWindow.Children.Add(uC_MainWindow as UIElement);

        }

        private void SliderBar_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void MenuItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
         
        }

        private void MenuItem_MouseUp(object sender, MouseButtonEventArgs e)
        {
          
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chhương trình ???", "", MessageBoxButton.OKCancel) != MessageBoxResult.OK)
                return;
            this.Close();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Menu_SliderBar.Children.Add(sliderBar);
        }

        private void ColorZone_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            btnClose.Background = Brushes.Orange;
        }

        private void btnClose_MouseLeave(object sender, MouseEventArgs e)
        {
            btnClose.Background = Brushes.OrangeRed;

        }

        private void btnMinimize_MouseEnter(object sender, MouseEventArgs e)
        {
            btnMinimize.Background = Brushes.LightGreen;

        }

        private void btnMinimize_MouseLeave(object sender, MouseEventArgs e)
        {
            btnMinimize.Background = Brushes.ForestGreen;
        }
    }
}
