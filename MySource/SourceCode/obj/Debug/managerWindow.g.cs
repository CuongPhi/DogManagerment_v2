﻿#pragma checksum "..\..\managerWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F70609D1249A009F2C006527E4B654303A48AAE1"
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
    /// managerWindow
    /// </summary>
    public partial class managerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 88 "..\..\managerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition someName;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\managerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuItemAccount;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\managerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimize;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\managerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMaximize;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\managerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon iconMaximize;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\managerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\managerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid UserControl_MainWindow;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\managerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Menu_SliderBar;
        
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
            System.Uri resourceLocater = new System.Uri("/SourceCode;component/managerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\managerWindow.xaml"
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
            
            #line 17 "..\..\managerWindow.xaml"
            ((SourceCode.managerWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 82 "..\..\managerWindow.xaml"
            ((MaterialDesignThemes.Wpf.ColorZone)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ColorZone_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.someName = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 4:
            
            #line 96 "..\..\managerWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MenuItemAccount = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 6:
            
            #line 112 "..\..\managerWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_4);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 117 "..\..\managerWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_3);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 123 "..\..\managerWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_2);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnMinimize = ((System.Windows.Controls.Button)(target));
            
            #line 134 "..\..\managerWindow.xaml"
            this.btnMinimize.Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            
            #line 135 "..\..\managerWindow.xaml"
            this.btnMinimize.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btnMinimize_MouseEnter);
            
            #line default
            #line hidden
            
            #line 135 "..\..\managerWindow.xaml"
            this.btnMinimize.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnMinimize_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnMaximize = ((System.Windows.Controls.Button)(target));
            
            #line 140 "..\..\managerWindow.xaml"
            this.btnMaximize.Click += new System.Windows.RoutedEventHandler(this.btnMaximize_Click);
            
            #line default
            #line hidden
            
            #line 141 "..\..\managerWindow.xaml"
            this.btnMaximize.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btnMaximize_MouseEnter);
            
            #line default
            #line hidden
            
            #line 141 "..\..\managerWindow.xaml"
            this.btnMaximize.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnMaximize_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 11:
            this.iconMaximize = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 12:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 147 "..\..\managerWindow.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            
            #line 148 "..\..\managerWindow.xaml"
            this.btnClose.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Button_MouseEnter);
            
            #line default
            #line hidden
            
            #line 148 "..\..\managerWindow.xaml"
            this.btnClose.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnClose_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 160 "..\..\managerWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Grid_Loaded);
            
            #line default
            #line hidden
            return;
            case 14:
            this.UserControl_MainWindow = ((System.Windows.Controls.Grid)(target));
            return;
            case 15:
            this.Menu_SliderBar = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

