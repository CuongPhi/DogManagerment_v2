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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddAccountWindow newWindow = new AddAccountWindow(false, null);
            newWindow.addAccount += new AddAccountWindow.addAccountHandler(AddNewAccountSuccess);
            newWindow.ShowDialog();
        }
        private void AddNewAccountSuccess(bool a)
        {
            if (a){
                LoadListStaff();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
          //   lvListStaff.SelectedItem;
        }

        private void lvListStaff_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
        }

        private void UpdateAccountMenuitem_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BanAccountMenuitem_Click(object sender, RoutedEventArgs e)
        {
            var t = lvListStaff.SelectedItem;
            if (t == null)
            {
                MessageBox.Show("Chọn tài khoản muốn khóa !");
                return;
            }
            try
            {
                string userName = t.GetType().GetProperty("USERNAME").GetValue(t, null).ToString();
                if (MessageBox.Show("Khóa tài khoản: " + userName, "", MessageBoxButton.OKCancel) != MessageBoxResult.OK)
                {
                    return;
                }
                if (AccountBUS.BanAccount(userName, true))
                {
                    LoadListStaff();
                    MessageBox.Show("Khóa tài khoản: " + userName + " thành công !");
                }
                else { MessageBox.Show("Tài khoản: " + userName + " đã bị khóa rồi!", "Không thể khóa", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
            catch { MessageBox.Show("Không thể khóa tài khoản, kiểm tra lại kết nối !"); }
        }

        private void ResetPasswordMenuItem_Click(object sender, RoutedEventArgs e)
        {
            
            var t = lvListStaff.SelectedItem;
            if (t == null)
            {

                MessageBox.Show("Chọn tài khoản muốn reset mật khẩu !");
                return;
            }
            try
            {
                string userName = t.GetType().GetProperty("USERNAME").GetValue(t, null).ToString();
                if (MessageBox.Show("Reset mật khẩu cho tài khoản: " + userName, "", MessageBoxButton.OKCancel) != MessageBoxResult.OK)
                {
                    return;
                }
                AccountBUS.ResetPass(userName, "1");
                MessageBox.Show("Reset mật khẩu cho tài khoản: " + userName + "thành công !");
            }
            catch { MessageBox.Show("Không thể reset mật khẩu, kiểm tra lại kết nối !"); }
        }

        private void NotBanAccountMenuitem_Click(object sender, RoutedEventArgs e)
        {
            var t = lvListStaff.SelectedItem;
            if (t == null)
            {

                MessageBox.Show("Chọn tài khoản muốn mở khóa  !");
                return;
            }
            try
            {
                string userName = t.GetType().GetProperty("USERNAME").GetValue(t, null).ToString();
                if (MessageBox.Show("Mở tài khoản: " + userName, "", MessageBoxButton.OKCancel) != MessageBoxResult.OK)
                {
                    return;
                }
                if (AccountBUS.BanAccount(userName, false))
                {
                    LoadListStaff();
                    MessageBox.Show("Mở tài khoản: " + userName + " thành công !");
                }
                else { MessageBox.Show("Tài khoản: " + userName + " đã không bị khóa !","Không thể mở khóa",MessageBoxButton.OK,MessageBoxImage.Error); }
            
            }
            catch { MessageBox.Show("Không thể  mở tài khoản, kiểm tra lại kết nối !"); }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            LoadListStaff();
        }

        private void SetSalaryMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Object t = lvListStaff.SelectedItem;
            if(t==null)
            {
                MessageBox.Show("Chọn tài khoản muốn cập nhật !");
                return;
            }
            AddAccountWindow newAddWind = new AddAccountWindow(true,  t);
            
            newAddWind.ShowDialog();         
            
        }
    }
}
