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
using BUS;
using DTO;
using Microsoft.Win32;

namespace SourceCode
{
    /// <summary>
    /// Interaction logic for End_Day.xaml
    /// </summary>
    public partial class End_Day : UserControl
    {
        public End_Day()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.dshd.ItemsSource = StatisticBillBUS.LoaiThuCuoiNgay(DateTime.Now);
            this.sl.Text = StatisticBillBUS.LoaiThuCuoiNgay(DateTime.Now).Count.ToString();
            this.dthu.Text = StatisticBillBUS.DoanhThuCuoiNgay(DateTime.Now).ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.dshd.ItemsSource = StatisticBillBUS.LoaiChiCuoiNgay(DateTime.Now);
            this.sl.Text = StatisticBillBUS.LoaiChiCuoiNgay(DateTime.Now).Count.ToString();
            this.dthu.Text = StatisticBillBUS.ChiCuoiNgay(DateTime.Now).ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = excel.ActiveSheet;
            excel.Visible = true;
            try
            {
                List<DTO.SoQuy> sq = new List<DTO.SoQuy>();
                sq = ((IEnumerable<DTO.SoQuy>)this.dshd.ItemsSource).ToList<DTO.SoQuy>();

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
            ((Microsoft.Office.Interop.Excel.Range)worksheet.Columns[1]).AutoFit();
                ((Microsoft.Office.Interop.Excel.Range)worksheet.Columns[2]).AutoFit();
                ((Microsoft.Office.Interop.Excel.Range)worksheet.Columns[3]).AutoFit();
                ((Microsoft.Office.Interop.Excel.Range)worksheet.Columns[4]).AutoFit();
                ((Microsoft.Office.Interop.Excel.Range)worksheet.Columns[5]).AutoFit();
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
