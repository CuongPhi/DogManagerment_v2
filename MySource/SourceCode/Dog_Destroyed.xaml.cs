using BUS;
using DTO;
using Microsoft.Win32;
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
    /// Interaction logic for Dog_Destroyed.xaml
    /// </summary>
    public partial class Dog_Destroyed : UserControl
    {
        private List<object> lsDoyDetroy = null;
        private bool isXuat = false;
        public Dog_Destroyed()
        {
            InitializeComponent();
            lsDoyDetroy= DogBUS.getAllDogDetroy();
        }

        private void btnXuat_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = excel.ActiveSheet;
            excel.Visible = true;
            try
            {
               
                lsDoyDetroy = DogBUS.getAllDogDetroy();

                var row = 1;
                worksheet.Cells[1, "A"] = "Mã chó";
                worksheet.Cells[1, "B"] = "Ngày";
                worksheet.Cells[1, "C"] = "Loại";
                worksheet.Cells[1, "D"] = "Giá thức ăn";
                worksheet.Cells[1, "E"] = "Chuồng";
                worksheet.Cells[1, "F"] = "Đường";
                worksheet.Cells[1, "G"] = "Phường";
                worksheet.Cells[1, "H"] = "Quận";
                worksheet.Cells[1, "I"] = "Thời gian";
                worksheet.Cells[1, "J"] = "Số ngày";

                foreach (var st in lsDoyDetroy)
                {
                    row++;
                    worksheet.Cells[row, "A"] = st.GetType().GetProperty("ID_DOG").GetValue(st,null).ToString();
                    worksheet.Cells[row, "B"] = String.Format("{0:dd/MM/yyyy}",(st.GetType().GetProperty("DAYIN").GetValue(st, null).ToString()));
                    worksheet.Cells[row, "C"] = st.GetType().GetProperty("TYPE").GetValue(st, null).ToString();
                    worksheet.Cells[row, "D"] = st.GetType().GetProperty("FOODPRICE").GetValue(st, null).ToString();
                    worksheet.Cells[row, "E"] = st.GetType().GetProperty("IDDOGHOUSE").GetValue(st, null).ToString();
                    worksheet.Cells[row, "F"] = st.GetType().GetProperty("STREET").GetValue(st, null).ToString();
                    worksheet.Cells[row, "G"] = st.GetType().GetProperty("WARD").GetValue(st, null).ToString();
                    worksheet.Cells[row, "H"] = st.GetType().GetProperty("DISTRICT").GetValue(st, null).ToString();
                    worksheet.Cells[row, "I"] = String.Format("{0:hh/:mm}",st.GetType().GetProperty("TIME").GetValue(st, null).ToString());
                    worksheet.Cells[row, "J"] = st.GetType().GetProperty("NUMOFDAY").GetValue(st, null).ToString();
                }
            ((Microsoft.Office.Interop.Excel.Range)worksheet.Columns[1]).AutoFit();
                ((Microsoft.Office.Interop.Excel.Range)worksheet.Columns[2]).AutoFit();
                ((Microsoft.Office.Interop.Excel.Range)worksheet.Columns[3]).AutoFit();
                ((Microsoft.Office.Interop.Excel.Range)worksheet.Columns[4]).AutoFit();
                ((Microsoft.Office.Interop.Excel.Range)worksheet.Columns[5]).AutoFit();
                ((Microsoft.Office.Interop.Excel.Range)worksheet.Columns[6]).AutoFit();
                ((Microsoft.Office.Interop.Excel.Range)worksheet.Columns[7]).AutoFit();
                ((Microsoft.Office.Interop.Excel.Range)worksheet.Columns[8]).AutoFit();
                ((Microsoft.Office.Interop.Excel.Range)worksheet.Columns[9]).AutoFit();
                ((Microsoft.Office.Interop.Excel.Range)worksheet.Columns[10]).AutoFit();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Hủy tất cả chó trong danh sách này ?", "", MessageBoxButton.OKCancel) != MessageBoxResult.OK)
            {
                return;
            }
            if (isXuat)
            {
                if (MessageBox.Show("Xuất file trước khi hủy?", "", MessageBoxButton.OKCancel) != MessageBoxResult.OK)
                {
                    return;
                }

            }

            foreach (var item in lsDoyDetroy)
            {
                string id = item.GetType().GetProperty("ID_DOG").GetValue(item, null).ToString();
                DOG dog = DogBUS.getByID(id);
                dog.STATUS = 2;
                DogBUS.Update(dog);
            }
            listDogDetroy.ItemsSource = DogBUS.getAllDogDetroy();
        }

        private void UCNhanVien_Loaded(object sender, RoutedEventArgs e)
        {
            listDogDetroy.ItemsSource = lsDoyDetroy;
        }

        private void listDogDetroy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object t = listDogDetroy.SelectedItem;
            if (t == null)
            {
                return;
            }
            wrdogDetroy.DataContext = t;
        }
    }
}
