﻿#pragma checksum "..\..\SliderBar.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AFF16BB21A852265CC04EB0A8C456A42F81AA689"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MilcanxWpf_SliderMenu;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MilcanxWpf_SliderMenu {
    
    
    /// <summary>
    /// SliderBar
    /// </summary>
    public partial class SliderBar : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\SliderBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid UserContrl_SliderBar;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\SliderBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel spLeft;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\SliderBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView treeView_0;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\SliderBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView treeView1;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\SliderBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView treeview_Staff;
        
        #line default
        #line hidden
        
        
        #line 233 "..\..\SliderBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView treeview2_Staff;
        
        #line default
        #line hidden
        
        
        #line 266 "..\..\SliderBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView accountant_Bill_Out;
        
        #line default
        #line hidden
        
        
        #line 295 "..\..\SliderBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView accoutant_satistic;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SourceCode;component/sliderbar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SliderBar.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.UserContrl_SliderBar = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.spLeft = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.treeView_0 = ((System.Windows.Controls.TreeView)(target));
            
            #line 16 "..\..\SliderBar.xaml"
            this.treeView_0.MouseLeave += new System.Windows.Input.MouseEventHandler(this.treeView_0_MouseLeave);
            
            #line default
            #line hidden
            
            #line 16 "..\..\SliderBar.xaml"
            this.treeView_0.MouseEnter += new System.Windows.Input.MouseEventHandler(this.TreeView_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 66 "..\..\SliderBar.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.TreeViewItem_MouseRightButtonUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.treeView1 = ((System.Windows.Controls.TreeView)(target));
            
            #line 92 "..\..\SliderBar.xaml"
            this.treeView1.MouseEnter += new System.Windows.Input.MouseEventHandler(this.treeView1_MouseEnter);
            
            #line default
            #line hidden
            
            #line 92 "..\..\SliderBar.xaml"
            this.treeView1.MouseLeave += new System.Windows.Input.MouseEventHandler(this.treeView1_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 99 "..\..\SliderBar.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.TreeViewItem_MouseLeftButtonUp_3);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 123 "..\..\SliderBar.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.TreeViewItem_MouseLeftButtonUp_4);
            
            #line default
            #line hidden
            return;
            case 8:
            this.treeview_Staff = ((System.Windows.Controls.TreeView)(target));
            
            #line 180 "..\..\SliderBar.xaml"
            this.treeview_Staff.MouseLeave += new System.Windows.Input.MouseEventHandler(this.treeview_Staff_MouseLeave);
            
            #line default
            #line hidden
            
            #line 180 "..\..\SliderBar.xaml"
            this.treeview_Staff.MouseEnter += new System.Windows.Input.MouseEventHandler(this.treeview_Staff_MouseEnter_1);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 181 "..\..\SliderBar.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.treeview_Staff_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 182 "..\..\SliderBar.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.TreeViewItem_MouseLeftButtonUp_2);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 205 "..\..\SliderBar.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.TreeViewItem_MouseLeftButtonUp_5);
            
            #line default
            #line hidden
            return;
            case 12:
            this.treeview2_Staff = ((System.Windows.Controls.TreeView)(target));
            
            #line 233 "..\..\SliderBar.xaml"
            this.treeview2_Staff.MouseEnter += new System.Windows.Input.MouseEventHandler(this.treeview2_Staff_MouseEnter);
            
            #line default
            #line hidden
            
            #line 233 "..\..\SliderBar.xaml"
            this.treeview2_Staff.MouseLeave += new System.Windows.Input.MouseEventHandler(this.treeview2_Staff_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 234 "..\..\SliderBar.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.treeview_Staff_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 235 "..\..\SliderBar.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.TreeViewItem_MouseLeftButtonUp_2);
            
            #line default
            #line hidden
            return;
            case 15:
            this.accountant_Bill_Out = ((System.Windows.Controls.TreeView)(target));
            
            #line 266 "..\..\SliderBar.xaml"
            this.accountant_Bill_Out.MouseLeave += new System.Windows.Input.MouseEventHandler(this.accountant_Bill_Out_MouseLeave);
            
            #line default
            #line hidden
            
            #line 266 "..\..\SliderBar.xaml"
            this.accountant_Bill_Out.MouseEnter += new System.Windows.Input.MouseEventHandler(this.accountant_Bill_Out_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 268 "..\..\SliderBar.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.TreeViewItem_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 17:
            this.accoutant_satistic = ((System.Windows.Controls.TreeView)(target));
            
            #line 295 "..\..\SliderBar.xaml"
            this.accoutant_satistic.MouseLeave += new System.Windows.Input.MouseEventHandler(this.accoutant_satistic_MouseLeave);
            
            #line default
            #line hidden
            
            #line 295 "..\..\SliderBar.xaml"
            this.accoutant_satistic.MouseEnter += new System.Windows.Input.MouseEventHandler(this.accoutant_satistic_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 297 "..\..\SliderBar.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.TreeViewItem_MouseLeftButtonUp_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

