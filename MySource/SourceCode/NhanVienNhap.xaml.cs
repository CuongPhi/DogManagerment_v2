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
    public partial class NhanVienNhap : UserControl
    {
        List<Object> _ListDogs = new List<Object>();
        private ACCOUNT _acc;
        BitmapImage ImageDog;
        public NhanVienNhap(ACCOUNT acc)
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
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            string fileName = op.FileName;
            if (string.IsNullOrEmpty(fileName))
                return;
            ImageDog= new BitmapImage(new Uri(fileName));
            if(MessageBox.Show("Cập hình hình ảnh cho chó ?","",MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                var t = dogBox.SelectedItem;
                if (t == null)
                {
                    MessageBox.Show("Chọn chó để cập nhật hình ảnh !");
                    return;
                }
                string idDog = t.GetType().GetProperty("ID_DOG").GetValue(t, null).ToString();
                DOG selectedDog = DogBUS.GetById(idDog);
                selectedDog.IMAGES = UIProcess.Inst.ImageToByteArray(ImageDog);
                DogBUS.Update(selectedDog);
                LoadListDogs();
            }
        }
        void ResetBillIn()
        {
            txbBill_District.Text = txbBill_Streets.Text = txbBill_Ward.Text = 
                txbIDBill.Text = txbnewPricefood.Text = txbnewWeight.Text = "";
            imagedogin.Source = null;
        }
        private void txbTotalPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void txbBill_TotalPr_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txbBill_Cus_Pay_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            float wei;
            long fd;
            try
            {
                wei = float.Parse(txbnewWeight.Text);
                fd = long.Parse(txbnewPricefood.Text);
            }
            catch { MessageBox.Show("Cân nặng hoặc tiền thức ăn không đúng !"); return; }
            string type = ((ComboBoxItem)(cbbnewtype.SelectedItem)).Content.ToString();
            if (txbIDBill.Text.Length <= 0 || txbIDBill.Text.Length > 10)
            {
                MessageBox.Show("Mã hóa đơn không đúng !");
                return;
            }
            if(txbIDBill.Text == "" || txbIDBill.Text == " ")
            {
                MessageBox.Show("Mã hóa đơn không được rỗng !");
                return;
            }
            BILL_IN bill = BillinBUS.GetById(txbIDBill.Text);

            if (bill != null)
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại !");
                return;
            }
            if (type == "Loại 1")
                type = "DTYPE_1";
            else if (type == "Loại 2")
                type = "DTYPE_2";
            else if (type == "Loại 3")
                type = "DTYPE_3";

            string doghouse = ((ComboBoxItem)(cbbnewMaChuong.SelectedItem)).Content.ToString();
            if (doghouse == "Chuồng 1")
                doghouse = "DH01";
            else if (doghouse == "Chuồng 2")
                doghouse = "DH02";
            else if (doghouse == "Chuồng 3")
                doghouse = "DH03";

            byte[] dogimage = UIProcess.Inst.ImageToByteArray(ImageDog);
            DOG newDog = new DOG() { TYPE = type, WEIGHT = wei, FOODPRICE = fd, DAYIN = DateTime.Now, STATUS = 0, IDDOGHOUSE = doghouse, IMAGES = dogimage };
            DOG DogAferInset;
            try
            {
                DogAferInset = DogBUS.Insert(newDog);

            }
            catch { MessageBox.Show("Thất bại, kiểm tra kết nối !"); return; };
            DOG_INFOR doginfo = new DOG_INFOR()
            {
                STREET = txbBill_Streets.Text,
                WARD = txbBill_Ward.Text,
                DISTRICT = txbBill_District.Text,
                TIME = TimeSpan.Parse(DateTime.Now.TimeOfDay.ToString(@"hh\:mm\:ss")),
                IDDOG = DogAferInset.ID
            };
            try
            {
                DogInforBUS.Insert(doginfo);
            }
            catch
            {
                DOG dogdelete = DogBUS.getByID(DogAferInset.ID.ToString());
                DogBUS.Delete(dogdelete);
                MessageBox.Show("Thêm thất bại, kiểm tra kết nối !");
                return;
            }

            BILL_IN billin = new BILL_IN()
            {
                IDDOG = DogAferInset.ID,
                DAY_BILL = DateTime.Now,
                FINE = long.Parse(txbnewPricefood.Text),
                ID_BILL = txbIDBill.Text,
                ID_USER = _acc.ID_USER,
            };

            BillinBUS.Insert(billin);
            LoadListDogs();

            MessageBox.Show("Thêm chó thành công !");
            ResetBillIn();


        }
        void RefreshBill()
        {
           
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

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            string fileName = op.FileName;
            if (string.IsNullOrEmpty(fileName))
                return;
              ImageDog =  new BitmapImage(new Uri(fileName));
            imagedogin.Source = ImageDog;

        }
        private void btnEdit_Click(object sender, RoutedEventArgs e)//Cập nhật thông tin
        {
            int macho = int.Parse(this.txbIDDog.Text);
            string loai = this.txbIDTypeDog.Text.ToString();
            //bool thieuhuy = false;
           
            float cannang = float.Parse(this.txbWeight.Text);
            if (cannang <= 0 && cannang >= 30)
            {
                MessageBox.Show("Cân nặng không chính xác");
                this.txbWeight.Focus();
            }
            cannang = float.Parse(this.txbWeight.Text);
            DateTime ngay = DateTime.Parse(this.txtday.Text);
           


            string chuog = this.txbIDHouseDog.Text.ToString();
           
            int tienthucan = int.Parse(this.txbFoodPrice.Text);
            if (tienthucan < 1 && tienthucan > 200000)
            {
                MessageBox.Show("Tiền thức ăn phải hợp lệ");
                this.txbFoodPrice.Focus();
            }
            tienthucan = int.Parse(this.txbFoodPrice.Text);
            string tg = this.txttime.Text.ToString();
            //string[] a = tg.Split(' ');
            //TimeSpan time = TimeSpan.Parse(a[0]);
            //if (ngay == null)
            //{
            //    MessageBox.Show("Nhập giờ!");
            //    this.tgian.Focus();
            //}

            //tg = this.tgian.Text.ToString();
            //a = tg.Split(' ');
            //time = TimeSpan.Parse(a[0]);

            
            string idms = this.txbIDDog.Text.ToString();
            DOG dog = DogBUS.getByID(idms);
            dog.WEIGHT = cannang;
            dog.TYPE = loai;
            dog.DAYIN = ngay;
            dog.FOODPRICE = tienthucan;
            dog.IDDOGHOUSE = chuog;
            try
            {
                DogBUS.Update(dog);
            }
            catch { MessageBox.Show("Cập nhật bảng chó không thành công!"); return; }
           
            loadFromData();
           

        }
        //private void btnEdit_Click(object sender, RoutedEventArgs e)
        //{
        //    object SelectedDog = dogBox.SelectedItem;
        //    string id = SelectedDog.GetType().GetProperty("ID_DOG").GetValue(SelectedDog, null).ToString();
        //    DOG getDog = DogBUS.getByID(id);
        //    getDog.WEIGHT = float.Parse(txbWeight.Text);

        //    DogBUS.Update(getDog);

        //}
    }
}

