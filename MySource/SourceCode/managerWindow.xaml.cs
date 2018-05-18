using DTO;
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
        private ACCOUNT _acc = null;
        private SliderBar sliderBar = new SliderBar();
        private ProgressBar progessbar = new ProgressBar();
      // private object Prev_Window = null;
        private object uC_MainWindow = null;
        public managerWindow(ACCOUNT p_acc)
        {
            _acc = p_acc;
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
                //case TypeUserControl.Accountant_Statistic_ThisDay:
                //    uC_MainWindow = new SliderBar();
                //    break;
                case TypeUserControl.Staff_ListDog:
                    uC_MainWindow = new NhanVien();
                    break;
                case TypeUserControl.Manager_ListStaff:
                    //if(_acc.TYPE == 0)
                        uC_MainWindow = new ListStaff();
                    break;
                case TypeUserControl.Staff_DogIn:
                    uC_MainWindow = new NhanVienNhap();
                    break;
                case TypeUserControl.Manger_CashBook:
                    uC_MainWindow = new SoQuy();
                    break;
                case TypeUserControl.Manager_Bill:
                    uC_MainWindow = new ThongKeHoaDon();
                    break;
                case TypeUserControl.Staff_Customer:
                  //  uC_MainWindow = new ThongKeHoaDon();
                    break;
                default:
                    return;                    
            }
            if(uC_MainWindow!=null)
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
            if (MessageBox.Show("Bạn muốn thoát chương trình ?", "Cảnh báo !", MessageBoxButton.OKCancel,MessageBoxImage.Warning) != MessageBoxResult.OK)
                return;
            this.Close();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Menu_SliderBar.Children.Add(sliderBar);
            MenuItemAccount.Header = _acc.USERNAME;
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
            MenuItem_Click(sender, e);
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

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            WindowState wds = this.WindowState;
            //this.WindowState = this.WindowState == WindowState.Normal ?  WindowState.Maximized : WindowState.Normal;
            if(wds == WindowState.Normal)
            {
                iconMaximize.Kind = MaterialDesignThemes.Wpf.PackIconKind.WindowRestore;
                this.WindowState = WindowState.Maximized;
                btnMaximize.ToolTip = "Thu nhỏ";
                someName.Width = new GridLength(728);

                return;
            }
            iconMaximize.Kind = MaterialDesignThemes.Wpf.PackIconKind.WindowMaximize;
            this.WindowState = WindowState.Normal;
            btnMaximize.ToolTip = "Phóng to";
            someName.Width = new GridLength(638);

        }

        private void btnMaximize_MouseEnter(object sender, MouseEventArgs e)
        {
            btnMaximize.Background = Brushes.Yellow;

        }

        private void btnMaximize_MouseLeave(object sender, MouseEventArgs e)
        {
            btnMaximize.Background = Brushes.Orange;

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }
    }
}
