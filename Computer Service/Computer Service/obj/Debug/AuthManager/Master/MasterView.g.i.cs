﻿#pragma checksum "..\..\..\..\AuthManager\Master\MasterView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B01E2B81613C11C145F97EA09EBDD694711438A4151E70BA19B1BA1F7E837B57"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Computer_Service;
using MahApps.Metro.Controls;
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


namespace Computer_Service {
    
    
    /// <summary>
    /// MasterView
    /// </summary>
    public partial class MasterView : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\AuthManager\Master\MasterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid viewdgr;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\AuthManager\Master\MasterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btncreate;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\AuthManager\Master\MasterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnupdate;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\AuthManager\Master\MasterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btndelete;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\AuthManager\Master\MasterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\AuthManager\Master\MasterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sel;
        
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
            System.Uri resourceLocater = new System.Uri("/Computer Service;component/authmanager/master/masterview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\AuthManager\Master\MasterView.xaml"
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
            this.viewdgr = ((System.Windows.Controls.DataGrid)(target));
            
            #line 20 "..\..\..\..\AuthManager\Master\MasterView.xaml"
            this.viewdgr.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.viewdgr_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 20 "..\..\..\..\AuthManager\Master\MasterView.xaml"
            this.viewdgr.Loaded += new System.Windows.RoutedEventHandler(this.viewdgr_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btncreate = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\AuthManager\Master\MasterView.xaml"
            this.btncreate.Click += new System.Windows.RoutedEventHandler(this.btncreate_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnupdate = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\AuthManager\Master\MasterView.xaml"
            this.btnupdate.Click += new System.Windows.RoutedEventHandler(this.btnupdate_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btndelete = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\AuthManager\Master\MasterView.xaml"
            this.btndelete.Click += new System.Windows.RoutedEventHandler(this.btndelete_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\AuthManager\Master\MasterView.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.sel = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\AuthManager\Master\MasterView.xaml"
            this.sel.Click += new System.Windows.RoutedEventHandler(this.btnselect_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

