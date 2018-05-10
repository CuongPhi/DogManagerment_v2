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

namespace SourceCode
{
    /// <summary>
    /// Interaction logic for NhanVien.xaml
    /// </summary>
    public partial class NhanVien : UserControl
    {
        public NhanVien()
        {
            InitializeComponent();
            LoadListStaff();
        }
        void LoadListStaff()
        {
            UserBUS.GetAll();
        }
        bool InsertUserApp(USERAPP obj)
        {
            return UserBUS.Insert(obj) != null;
        }
    }
}
