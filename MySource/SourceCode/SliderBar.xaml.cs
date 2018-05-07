using SourceCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace MilcanxWpf_SliderMenu
{
    /// <summary>
    /// Interaction logic for SliderBar.xaml
    /// </summary>
    public partial class SliderBar : UserControl, INotifyPropertyChanged
    {
        private TypeUserControl typeUC;
        public TypeUserControl TypeUC { get => typeUC;

            set
            {
                typeUC = value;
                OnPropertyChanged(typeUC);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(TypeUserControl t)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(t.ToString()));
            }
        }

        public SliderBar()
        {
            
            InitializeComponent();
        }
      
        private void TreeView_MouseEnter(object sender, MouseEventArgs e)
        {
            UIProcess.Inst.ExpanAllNodesOf(treeView_0, true);

        }

        private void treeView_0_MouseLeave(object sender, MouseEventArgs e)
        {
            UIProcess.Inst.ExpanAllNodesOf(treeView_0, false);
        }

        private void treeView1_MouseEnter(object sender, MouseEventArgs e)
        {
            UIProcess.Inst.ExpanAllNodesOf(treeView1, true);

        }

        private void treeView1_MouseLeave(object sender, MouseEventArgs e)
        {
            UIProcess.Inst.ExpanAllNodesOf(treeView1, false);

        }

        private void TreeViewItem_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TypeUC = TypeUserControl.Accountant_Handover;
        }

        private void TreeViewItem_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            TypeUC = TypeUserControl.Accountant_Statistic_ThisDay;

        }

        private void TreeViewItem_MouseLeftButtonUp_2(object sender, MouseButtonEventArgs e)
        {
            TypeUC = TypeUserControl.Staff_List;

        }

        private void TreeViewItem_MouseLeftButtonUp_3(object sender, MouseButtonEventArgs e)
        {
            TypeUC = TypeUserControl.Manager_ListStaff;
        }

        private void treeview_Staff_MouseEnter(object sender, MouseEventArgs e)
        {
           // UIProcess.Inst.ExpanAllNodesOf(treeview_Staff, true);

        }

        private void treeview_Staff_MouseEnter_1(object sender, MouseEventArgs e)
        {
            UIProcess.Inst.ExpanAllNodesOf(treeview_Staff, true);
        }

        private void accountant_Bill_Out_MouseEnter(object sender, MouseEventArgs e)
        {
            UIProcess.Inst.ExpanAllNodesOf(accountant_Bill_Out, true);
        }

        private void accoutant_satistic_MouseEnter(object sender, MouseEventArgs e)
        {
            UIProcess.Inst.ExpanAllNodesOf(accoutant_satistic, true);
        }

        private void treeview2_Staff_MouseEnter(object sender, MouseEventArgs e)
        {
            UIProcess.Inst.ExpanAllNodesOf(treeview2_Staff, true);
        }

        private void treeview2_Staff_MouseLeave(object sender, MouseEventArgs e)
        {
            UIProcess.Inst.ExpanAllNodesOf(treeview2_Staff, false);

        }

        private void treeview_Staff_MouseLeave(object sender, MouseEventArgs e)
        {
            UIProcess.Inst.ExpanAllNodesOf(treeview_Staff, false);

        }

        private void accountant_Bill_Out_MouseLeave(object sender, MouseEventArgs e)
        {
            UIProcess.Inst.ExpanAllNodesOf(accountant_Bill_Out, false);

        }

        private void accountant_Bill_Out_MouseLeave_1(object sender, MouseEventArgs e)
        {

        }

        private void accoutant_satistic_MouseLeave(object sender, MouseEventArgs e)
        {
            UIProcess.Inst.ExpanAllNodesOf(accoutant_satistic, false);

        }
    }

    public enum TypeUserControl
    {
        Accountant_Handover = 0,
        Accountant_Statistic_ThisDay = 1,
        Staff_List =2,
        Manager_ListStaff = 11,
    }

}
