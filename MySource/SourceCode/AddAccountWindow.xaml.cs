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
using BUS;
namespace SourceCode
{
    /// <summary>
    /// Interaction logic for AddAccountWindow.xaml
    /// </summary>
    public partial class AddAccountWindow : Window
    {
        public delegate void addAccountHandler(bool b);
        public addAccountHandler addAccount;

        bool isOKAddNew = false;
        public AddAccountWindow()
        {
            var ListStaff_UC = this.DataContext;
            InitializeComponent();
        }

        private void addNewAccWindw_Closed(object sender, EventArgs e)
        {
            if(isOKAddNew)
            {
                addAccount(isOKAddNew);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int id = 0, salar=0;
            try
            {
              id= int.Parse("0" + txtMa.Text);
            } catch { MessageBox.Show("Mã quá dài");  return; }
            string name = " "+ txbName.Text;
            string CMND = "0" + txbCMND.Text;
            try
            {
                salar = int.Parse("0" + txbSalary.Text);
                if (salar < 0)
                {
                    MessageBox.Show("Nhập lương sai!");
                    return;
                }
            }
            catch { MessageBox.Show("Lương quá lớn"); return; }
            string userName = txbUserName.Text;
            PERSON newPer = new PERSON() { ID = id };
            try
            {
                PersonBUS.Insert(newPer);
               
            }
            catch { MessageBox.Show("Mã người dùng đã tồn tại !"); return; }
            
            PERSONINFOR newPerInf = new PERSONINFOR() { NAME = name, ID_TT = CMND, ID = id };
            try
            {
                PersonInforBUS.Insert(newPerInf);
            }
            catch { MessageBox.Show("CMND đã tồn tại !"); return; }

            string strType = ((ComboBoxItem)cbbTypeAcc.SelectedItem).Content.ToString();
            int type = -1;
            if (strType == "Quản lý") type = 0;
            else if (strType == "Nhân viên") type = 1;
            else if (strType == "Kế toán") type = 2;
            else { MessageBox.Show("Hãy chọn loại tài khoản !"); return; }
            USERAPP userApp = new USERAPP() { IDPERSON = id, SALARY = salar, DAYJOIN = DateTime.Now };
            UserBUS.Insert(userApp);

            ACCOUNT newAcc = new ACCOUNT() {ID_USER = UserBUS.GetIdByIDPerson(id) ,  USERNAME = userName, TYPE = type };
            try
            {
                AccountBUS.Insert(newAcc);
            }
            catch { MessageBox.Show("Tài khoản đã tồn tại !"); return; }
            MessageBox.Show("Thêm thành công");

            isOKAddNew = true;

        }

        private void txtSoLuong_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e);
            this.Close();
        }
    }
}
