﻿#pragma checksum "..\..\..\Form\wndMain.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6CD94220E928FE843A31F70708733E26"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Anything;
using Anything_wpf_main_;
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


namespace Anything_wpf_main_ {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Form\wndMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Anything_wpf_main_.MainWindow Me;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Form\wndMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border bdrMain;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Form\wndMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border bdrMainForm;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Form\wndMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RowDefinition FunctionRD;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Form\wndMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BdrFunction;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Form\wndMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMin;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Form\wndMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMax;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Form\wndMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Form\wndMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMain;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\Form\wndMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer scrlist;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\Form\wndMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel Recent;
        
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
            System.Uri resourceLocater = new System.Uri("/Anything[wpf_main];component/form/wndmain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Form\wndMain.xaml"
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
            this.Me = ((Anything_wpf_main_.MainWindow)(target));
            
            #line 12 "..\..\..\Form\wndMain.xaml"
            this.Me.Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\Form\wndMain.xaml"
            this.Me.LocationChanged += new System.EventHandler(this.Window_LocationChanged);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\Form\wndMain.xaml"
            this.Me.MouseMove += new System.Windows.Input.MouseEventHandler(this.Me_MouseMove);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\Form\wndMain.xaml"
            this.Me.KeyDown += new System.Windows.Input.KeyEventHandler(this.Me_KeyDown);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\Form\wndMain.xaml"
            this.Me.Closing += new System.ComponentModel.CancelEventHandler(this.Me_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.bdrMain = ((System.Windows.Controls.Border)(target));
            
            #line 17 "..\..\..\Form\wndMain.xaml"
            this.bdrMain.MouseLeave += new System.Windows.Input.MouseEventHandler(this.bdrMain_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            this.bdrMainForm = ((System.Windows.Controls.Border)(target));
            
            #line 22 "..\..\..\Form\wndMain.xaml"
            this.bdrMainForm.DragEnter += new System.Windows.DragEventHandler(this.bdrMainForm_DragEnter);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\Form\wndMain.xaml"
            this.bdrMainForm.Drop += new System.Windows.DragEventHandler(this.bdrMainForm_Drop);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FunctionRD = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 5:
            this.BdrFunction = ((System.Windows.Controls.Border)(target));
            return;
            case 6:
            this.btnMin = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Form\wndMain.xaml"
            this.btnMin.Click += new System.Windows.RoutedEventHandler(this.btnMin_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnMax = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Form\wndMain.xaml"
            this.btnMax.Click += new System.Windows.RoutedEventHandler(this.btnMax_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\Form\wndMain.xaml"
            this.btnClose.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnClose_MouseLeave);
            
            #line default
            #line hidden
            
            #line 53 "..\..\..\Form\wndMain.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtMain = ((System.Windows.Controls.TextBox)(target));
            
            #line 86 "..\..\..\Form\wndMain.xaml"
            this.txtMain.GotFocus += new System.Windows.RoutedEventHandler(this.txtMain_GotFocus);
            
            #line default
            #line hidden
            
            #line 87 "..\..\..\Form\wndMain.xaml"
            this.txtMain.LostFocus += new System.Windows.RoutedEventHandler(this.txtMain_LostFocus);
            
            #line default
            #line hidden
            
            #line 88 "..\..\..\Form\wndMain.xaml"
            this.txtMain.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtMain_TextChanged);
            
            #line default
            #line hidden
            
            #line 89 "..\..\..\Form\wndMain.xaml"
            this.txtMain.MouseMove += new System.Windows.Input.MouseEventHandler(this.txtMain_MouseMove);
            
            #line default
            #line hidden
            
            #line 89 "..\..\..\Form\wndMain.xaml"
            this.txtMain.KeyDown += new System.Windows.Input.KeyEventHandler(this.txtMain_KeyDown);
            
            #line default
            #line hidden
            
            #line 89 "..\..\..\Form\wndMain.xaml"
            this.txtMain.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.txtMain_MouseDown);
            
            #line default
            #line hidden
            return;
            case 10:
            this.scrlist = ((System.Windows.Controls.ScrollViewer)(target));
            
            #line 108 "..\..\..\Form\wndMain.xaml"
            this.scrlist.KeyDown += new System.Windows.Input.KeyEventHandler(this.scrlist_KeyDown);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Recent = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 12:
            
            #line 113 "..\..\..\Form\wndMain.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AddNewMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 115 "..\..\..\Form\wndMain.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AddComputerMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 116 "..\..\..\Form\wndMain.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AddMyDocumentMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 117 "..\..\..\Form\wndMain.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AddRecycleBinMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 118 "..\..\..\Form\wndMain.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AddControlPanelMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 119 "..\..\..\Form\wndMain.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AddNetworkNeighborhoodMenuItem_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
