﻿#pragma checksum "..\..\SoQuy.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63C251CE690E74CA56D8373261971153B86E78B3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using Microsoft.Office.Interop.Excel;
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


namespace SourceCode {
    
    
    /// <summary>
    /// SoQuy
    /// </summary>
    public partial class SoQuy : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\SoQuy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid UCSoQuy;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\SoQuy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox timkiem;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\SoQuy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker start;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\SoQuy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker end;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\SoQuy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox dthu;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\SoQuy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox chi;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\SoQuy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView statistic;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\SoQuy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel wrap;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\SoQuy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button trove;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\SoQuy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button xuat;
        
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
            System.Uri resourceLocater = new System.Uri("/SourceCode;component/soquy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SoQuy.xaml"
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
            this.UCSoQuy = ((System.Windows.Controls.Grid)(target));
            
            #line 11 "..\..\SoQuy.xaml"
            this.UCSoQuy.Loaded += new System.Windows.RoutedEventHandler(this.UCSoQuy_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.timkiem = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\SoQuy.xaml"
            this.timkiem.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.timKiem);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 47 "..\..\SoQuy.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.DaThanhToan);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 48 "..\..\SoQuy.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.DaHuy);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 57 "..\..\SoQuy.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.start = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.end = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            
            #line 63 "..\..\SoQuy.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.PhieuThu);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 64 "..\..\SoQuy.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.PhieuChi);
            
            #line default
            #line hidden
            return;
            case 10:
            this.dthu = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.chi = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.statistic = ((System.Windows.Controls.ListView)(target));
            return;
            case 13:
            this.wrap = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 14:
            this.trove = ((System.Windows.Controls.Button)(target));
            
            #line 122 "..\..\SoQuy.xaml"
            this.trove.Click += new System.Windows.RoutedEventHandler(this.trove_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.xuat = ((System.Windows.Controls.Button)(target));
            
            #line 123 "..\..\SoQuy.xaml"
            this.xuat.Click += new System.Windows.RoutedEventHandler(this.xuat_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

