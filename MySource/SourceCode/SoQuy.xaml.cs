using System;
using System.Collections.Generic;
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
using BUS;
using Microsoft.Win32;
using Excel = Microsoft.Office.Interop.Excel;
namespace SourceCode
{
    /// <summary>
    /// Interaction logic for SoQuy.xaml
    /// </summary>
    public partial class SoQuy : UserControl
    {
        List<DTO.SoQuy> sq = new List<DTO.SoQuy>();
        public SoQuy()
        {

            InitializeComponent();

        }
        private void UCSoQuy_Loaded(object sender, RoutedEventArgs e)
        {
            load();

        }
        public void load()
        {
            sq = StatisticBillBUS.thongKe();
            this.statistic.ItemsSource = sq;
        }
        public void LoadBillIn()
        {
            Thread thread = new Thread(new ThreadStart(loadFromData));
            thread.Start();
        }
        void loadFromData()
        {
            sq = StatisticBillBUS.thongKe();
            SetDataSource(sq);

        }
        internal delegate void SetDataSourceDelegate(List<DTO.SoQuy> ls);

        void SetDataSource(List<DTO.SoQuy> t)
        {
            if (!this.Dispatcher.CheckAccess())
            {
                this.Dispatcher.Invoke(new SetDataSourceDelegate(SetDataSource), t);
            }
            else
            {
                this.statistic.ItemsSource = t;
                // RunningProgressBar(Visibility.Hidden);
            }
        }

        private void timKiem(object sender, TextChangedEventArgs e)
        {
            string ten = this.timkiem.Text.ToString();
            statistic.ItemsSource = StatisticBillBUS.search(ten);
        }

        private void DaThanhToan(object sender, RoutedEventArgs e)
        {
            statistic.ItemsSource = StatisticBillBUS.DaThanhToan();
        }

        private void DaHuy(object sender, RoutedEventArgs e)
        {
            statistic.ItemsSource = StatisticBillBUS.DaHuy();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PhieuThu(object sender, RoutedEventArgs e)
        {
            DateTime start = DateTime.Parse(this.start.Text);
            DateTime end = DateTime.Parse(this.end.Text);
            statistic.ItemsSource = StatisticBillBUS.LoaiThu(start, end);
        }

        private void PhieuChi(object sender, RoutedEventArgs e)
        {
            DateTime start = DateTime.Parse(this.start.Text);
            DateTime end = DateTime.Parse(this.end.Text);
            statistic.ItemsSource = StatisticBillBUS.LoaiChi(start, end);
        }
        private void trove_Click(object sender, RoutedEventArgs e)
        {
            statistic.ItemsSource = StatisticBillBUS.thongKe();
        }
        private void xuat_Click(object sender, RoutedEventArgs e)
        {

            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = excel.ActiveSheet;
            excel.Visible = true;
            try
            {
                List<DTO.SoQuy> sq = new List<DTO.SoQuy>();
                sq = ((IEnumerable<DTO.SoQuy>)this.statistic.ItemsSource).ToList<DTO.SoQuy>();

                var row = 1;
                worksheet.Cells[1, "A"] = "Mã phiếu";
                worksheet.Cells[1, "B"] = "Thời gian";
                worksheet.Cells[1, "C"] = "Loại";
                worksheet.Cells[1, "D"] = "Người thu/chi";
                worksheet.Cells[1, "E"] = "Giá trị";

                foreach (var st in sq)
                {
                    row++;
                    worksheet.Cells[row, "A"] = st.ID_BILL;
                    worksheet.Cells[row, "B"] = String.Format("{0:dd/MM/yyyy}", st.DAY_BILL);
                    worksheet.Cells[row, "C"] = st.TYPE;
                    worksheet.Cells[row, "D"] = st.NAME;
                    worksheet.Cells[row, "E"] = st.VALUE;
                }
            ((Excel.Range)worksheet.Columns[1]).AutoFit();
                ((Excel.Range)worksheet.Columns[2]).AutoFit();
                ((Excel.Range)worksheet.Columns[3]).AutoFit();
                ((Excel.Range)worksheet.Columns[4]).AutoFit();
                ((Excel.Range)worksheet.Columns[5]).AutoFit();
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;
                Nullable<bool> result = saveDialog.ShowDialog();
                if (result == true)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Xuất thành công!");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }
    }
}
