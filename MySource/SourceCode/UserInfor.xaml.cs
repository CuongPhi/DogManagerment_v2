using DTO;
using BUS;
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
    /// Interaction logic for UserInfor.xaml
    /// </summary>
    public partial class UserInfor : Window
    {
        private object UserFull = null;
        private ACCOUNT _acc = null;
        private PERSONINFOR perinf;

        public UserInfor(ACCOUNT acc)
        {
            _acc = acc;
            InitializeComponent();
            this.Title += " [" + _acc.USERNAME + "]";
            LoadData();
        }
        void LoadData()
        {
            UserFull= UserBUS.GetAllByUserName(_acc.USERNAME);
            //var getProp = UserFull.GetType().GetProperty("TYPE");
            //int type= (int)getProp.GetValue(UserFull, null);
            //object sType = "";
            //if( type== 0)
            //{
            //    sType = "Quản lý";
            //}
            //else if (type == 1)
            //{
            //    sType = "Nhân viên";
            //}
            //else if (type==2)
            //{
            //    sType = "Kế toán";
            //}
            
            //var newValue = Convert.ChangeType(sType, Type.GetType("System.string".GetType().AssemblyQualifiedName));
            //getProp.SetValue(UserFull, newValue, null);
            UserFullBinding.DataContext = UserFull;
        }

        private void UserFullBinding_Loaded(object sender, RoutedEventArgs e)
        {
            if(txbTypeAcc.Text == "0")
            {
                txbTypeAcc.Text = "Quản lý";
            }
          else  if (txbTypeAcc.Text == "1")
            {
                txbTypeAcc.Text = "Nhân viên";
            }
           else  if (txbTypeAcc.Text == "2")
            {
                txbTypeAcc.Text = "Kế toán";
            }
            if(cbbGender.Text == "Nam")
            {
                cbbGender.SelectedIndex = 0;
            }
            else if (cbbGender.Text == "Nữ")
            {
                cbbGender.SelectedIndex = 1;
            }
            else if (cbbGender.Text == "Khác")
            {
                cbbGender.SelectedIndex = 2;
            }
            perinf = PersonInforBUS.GetById(txbCMND.Text);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string newID_TT = txbCMND.Text;
            string ID_TT = perinf.ID_TT;
            if (ID_TT.Equals(newID_TT))
            {
                perinf.EMAIL = txbEmail.Text;
                try
                {
                    perinf.BIRHDAY = DateTime.Parse(txbBirthday.Text);
                }
                catch { MessageBox.Show("Ngày không hợp lệ"); return; }
                perinf.NAME = txbName.Text;
                perinf.PHONE = txbPhone.Text;
                perinf.gender = ((ComboBoxItem)cbbGender.SelectedItem).Content.ToString();
                PersonInforBUS.Update(perinf);
                ADDRESS add = AddressBUS.GetByIDPersonInfor(perinf.ID_TT);
                add.STREET = txbStreet.Text;
                add.WARD = txbWard.Text;
                add.DISTRICT = txbDistrict.Text;
                AddressBUS.Update(add);
            }
            else
            {
                int idper = (int)perinf.ID;
                if (newID_TT.Length < 9) { MessageBox.Show("CMND không đúng !"); return; }
                perinf.ID_TT = newID_TT;
                perinf.ID = idper;
                PersonInforBUS.Insert(perinf);
                ADDRESS add = AddressBUS.GetByIDPersonInfor(ID_TT);
                add.IDPERSON = newID_TT;
                AddressBUS.Update(add);
                perinf.ID_TT = ID_TT;
                perinf.ID = idper;
                PersonInforBUS.Delete(perinf);
            }
            //AddressBUS.Delete(add);
            //PersonInforBUS.Delete(perinf);
            //perinf.ID_TT = ID_TT;
            //perinf.ID = idper;
            //PersonInforBUS.Insert(perinf);
            //add.IDPERSON = ID_TT;
            //AddressBUS.Insert(add);

            MessageBox.Show("Sửa thành công !");
            this.Close();
        }
    }
}
