using BUS;
using DTO;
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
        private ACCOUNT _acc;
        public Accountant_Handover(ACCOUNT acc)
        {
            InitializeComponent();
            _acc = acc;
            StaffName.Text += acc.USERNAME;
            DateInput.Text = DateTime.Now.ToShortDateString();
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
            //try
            //{
            //    foreach (var dog in _ListDogs)
            //    {
            //        var getProp = dog.GetType().GetProperty("IMAGES");
            //        var newValue = Convert.ChangeType(UIProcess.Inst.LoadImage((byte[])getProp.GetValue(dog, null)), getProp.PropertyType);
            //        getProp.SetValue(dog, newValue, null);
            //    }
            //}
            //catch { }
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
        void Search(string key)
        {
            _ListDogs = DogBUS.search(key);
            dogBox.ItemsSource = _ListDogs;

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
            try
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
            catch { }
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
 
        }

        private void txbTotalPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            txbBill_TotalPr.Text = txbTotalPrice.Text;
            txbBill_Cus_Pay.Text = txbTotalPrice.Text;
        }

        private void txbBill_TotalPr_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txbBill_Cus_Pay_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                txbBill_Cus_Rec.Text = (int.Parse(txbBill_Cus_Pay.Text) - int.Parse(txbBill_TotalPr.Text)).ToString();
            }
            catch { }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            object Sdog = dogBox.SelectedItem;
            if(Sdog == null)
            {
                MessageBox.Show("Hãy chọn chó !");
                return;
            }
            int id;
            try
            {
                if (txbBill_ID.Text == "")
                {
                    MessageBox.Show("Mã KH không được rỗng !");
                    return;
                }
                id = int.Parse(txbBill_ID.Text);
            }
            catch { MessageBox.Show("Mã KH quá lớn !"); return; }
            if (txbBill_CMND.Text.Length > 10 || txbBill_CMND.Text.Length < 9)
            {
                MessageBox.Show("Số CMND không chính xác !");
                return;
            }
            if (CustomerBUS.GetByID(txbBill_ID.Text) != null)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại !");
                return;
            }
            if (PersonInforBUS.GetById(txbBill_CMND.Text) != null)
            {
                MessageBox.Show("Số CMND đã tồn tại !");
                return;
            }
            if (txbIDBill.Text.Length > 10 || txbIDBill.Text.Length < 1)
            {
                MessageBox.Show("Mã hóa đơn không chính xác !");
                return;
            }
            if (PersonBUS.GetById(id.ToString()) != null)
            {
                MessageBox.Show("Mã KH đã tồn tại !");
                return;
            }

            PERSON per = new PERSON() { ID = id, NOTE = "Khách hàng nhận chó!" };
            PERSONINFOR perinf = new PERSONINFOR()
            {
                ID_TT = txbBill_CMND.Text,
                ID = id,
                EMAIL = txbBill_Mail.Text,
                PHONE = txbBill_SĐT.Text,
                NAME = txbBill_Name.Text,
                gender = ((ComboBoxItem)cbbBill_gender.SelectedItem).Content.ToString()
            };
            ADDRESS add = new ADDRESS()
            {
                IDPERSON = txbBill_CMND.Text,
                STREET = txbBill_Streets.Text,
                WARD = txbBill_Ward.Text,
                DISTRICT = txbBill_District.Text
            };

            CUSTOMER cus = new CUSTOMER() { IDPERSON = id };

            DOG dog = DogBUS.GetById(txbIDDog.Text);
            dog.STATUS = 1;
            BILL_OUT bill_Out = new BILL_OUT()
            {
                ID_USER = _acc.ID_USER,
                ID_BILL = txbIDBill.Text,
                IDDOG = int.Parse(txbIDDog.Text),
                DAY_BILL = DateTime.Now,
                FINE = long.Parse(txbFoodPrice.Text),
                TOTALPRICE = long.Parse(txbTotalPrice.Text)
            };

            PAYMENT_RECEIPT_VOUCHER pay = new PAYMENT_RECEIPT_VOUCHER()
            {
                DATETIME = DateTime.Now,
                TYPE = true,
                VALUE = long.Parse(txbTotalPrice.Text),
                DESTRIPTION = "Nhận tiền trả chó !",
                ID_USER = _acc.ID_USER,

            };
            if (MessageBox.Show("Xác nhận trả chó !", "", MessageBoxButton.OKCancel) != MessageBoxResult.OK)
            {
                return;
            }

            try
            {
                PersonBUS.Insert(per);
            }
            catch { MessageBox.Show("Trả thất bại (per) !"); return; }
            try
            {
                PersonInforBUS.Insert(perinf);
            }
            catch
            {
                MessageBox.Show("Trả thất bại (perinf) !");
                PersonBUS.Delete(per);
                return;
            }
            try
            {
                AddressBUS.Insert(add);
            }
            catch
            {
                MessageBox.Show("Trả thất bại  (addr)!");
                PersonInforBUS.Delete(perinf);
                PersonBUS.Delete(per);
                return;
            }
            try
            {
                CustomerBUS.Insert(cus);
            }
            catch
            {
                MessageBox.Show("Trả thất bại (cus) !");
                AddressBUS.Delete(add);
                PersonInforBUS.Delete(perinf);
                PersonBUS.Delete(per);
                return;
            }
            try
            {
                bill_Out.ID_CUSTOMER = CustomerBUS.GetIdByIDPerson(id);
                BillOutBUS.Insert(bill_Out);
            }
            catch
            {
                MessageBox.Show("Trả thất bại  (billout)!");
                CustomerBUS.Delete(cus);
                AddressBUS.Delete(add);
                PersonInforBUS.Delete(perinf);
                PersonBUS.Delete(per);
                return;
            }
            try
            {
                Pay_ReceiptBUS.Insert(pay);
            }
            catch
            {

                MessageBox.Show("Trả thất bại (pay_receipt) !");
                BillOutBUS.Delete(bill_Out);
                CustomerBUS.Delete(cus);
                AddressBUS.Delete(add);
                PersonInforBUS.Delete(perinf);
                PersonBUS.Delete(per);
                return;
            }
            try
            {
                DogBUS.Update(dog);
            }
            catch
            {
                MessageBox.Show("Trả thất bại (dogupdate) !");
                Pay_ReceiptBUS.Delete(pay);
                BillOutBUS.Delete(bill_Out);
                CustomerBUS.Delete(cus);
                AddressBUS.Delete(add);
                PersonInforBUS.Delete(perinf);
                PersonBUS.Delete(per);
                return;
            }
            MessageBox.Show("Trả chó thành công !");
            LoadListDogs();
            RefreshBill();
        }
        void RefreshBill()
        {
            txbBill_CMND.Text = txbBill_Cus_Pay.Text = 
                txbBill_Cus_Rec.Text = txbBill_District.Text =
                txbBill_ID.Text = txbBill_Mail.Text = txbBill_Name.Text = 
                txbBill_Note.Text = txbBill_Streets.Text = txbBill_SĐT.Text = 
                txbBill_TotalPr.Text = txbBill_Ward.Text = txbIDBill.Text= "";
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (txbSearchDog.Text == "")
                LoadListDogs();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Search(txbSearchDog.Text);
        }
    }
}

