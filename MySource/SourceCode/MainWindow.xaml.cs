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
            try
            {
                InitializeComponent();
                // UIProcess.Inst.LoadConfigFile();
            }
            catch (Exception ex){ MessageBox.Show(ex.ToString()); }
        }
    
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ACCOUNT acc = checkUserAccount(txbUserName.Text, FloatingPasswordBox.Password);
            bool loginOK = acc!=null;
            if(!loginOK)
            {
                MessageBox.Show("Tài khoản - mật khẩu không đúng hoặc đang bị khóa!");
                return;
            }
            new managerWindow(acc).Show(); this.Close();

        }
        ACCOUNT checkUserAccount(string u, string p)
        {            
            if (u.Length < 5 || p.Length < 5)
            { //return null;
            }
            List<ACCOUNT> ls = AccountBUS.IsLogin(u, p);
            if (ls==null || ls.Count<1)
                 return null;
            return ls[0];
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
