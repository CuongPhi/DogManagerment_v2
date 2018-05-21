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
using System.Windows.Shapes;

namespace SourceCode
{
    /// <summary>
    /// Interaction logic for ChangePassWordWindow.xaml
    /// </summary>
    public partial class ChangePassWordWindow : Window
    {
        ACCOUNT _thisAccount = null;
        public ChangePassWordWindow(string userName)
        {
            _thisAccount = AccountBUS.GetById(userName);
            if (_thisAccount == null)
                this.Close();
            InitializeComponent();

        }
        
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {            
            if (_thisAccount.PASSWORD != txbPassWord.Password)
            {
                MessageBox.Show("Mật khẩu không đúng !");
                return;
            }
            if (txbNewPass.Password.Length < 5)
            {
                MessageBox.Show("Mật khẩu mới quá ngắn!");
                return;
            }
            if(txbNewPass.Password != txbReNewPass.Password)
            {
                MessageBox.Show("Nhập lại mật khẩu không chính xác");
                return;
            }
            if(txbNewPass.Password == txbPassWord.Password)
            {
                MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu hiện tại");
                return;
            }
            AccountBUS.ChangePassword(_thisAccount, txbNewPass.Password);
            MessageBox.Show("Đổi mật khẩu thành công!");
            this.Close();
        }
    }
}
