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
        private string _userName = null;
        public ChangePassWordWindow(string userName)
        {
            _userName = userName;
            InitializeComponent();
        }
    }
}
