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
    }
}
