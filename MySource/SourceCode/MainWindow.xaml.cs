using BUS;
using DTO;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           // UIProcess.Inst.LoadConfigFile();
        }
    
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<ACCOUNT> listAcc=AccountBUS.IsLogin(txbUserName.Text, FloatingPasswordBox.Password);
            if (listAcc.Count<1)
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng");           
                return;
            }

            new  managerWindow(listAcc[0]).ShowDialog();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
