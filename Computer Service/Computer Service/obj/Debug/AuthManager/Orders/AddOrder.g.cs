﻿#pragma checksum "..\..\..\..\AuthManager\Orders\AddOrder.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BC73D80AEC5EF21C2842FC4B8FA990CEE67D7B809034043BD91F889C42AA5FFF"
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
    /// AddOrder
    /// </summary>
    public partial class AddOrder : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\AuthManager\Orders\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox price;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\AuthManager\Orders\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox description;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\AuthManager\Orders\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox status;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\AuthManager\Orders\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker accept;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\AuthManager\Orders\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker @return;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\AuthManager\Orders\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button viewCOMP;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\AuthManager\Orders\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button viewMaster;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\AuthManager\Orders\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button viewClient;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\AuthManager\Orders\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox client;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\AuthManager\Orders\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox master;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\AuthManager\Orders\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pc;
        
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
            System.Uri resourceLocater = new System.Uri("/Computer Service;component/authmanager/orders/addorder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\AuthManager\Orders\AddOrder.xaml"
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
            this.price = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.description = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 23 "..\..\..\..\AuthManager\Orders\AddOrder.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.status = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\..\..\AuthManager\Orders\AddOrder.xaml"
            this.status.ContextMenuClosing += new System.Windows.Controls.ContextMenuEventHandler(this.status_ContextMenuClosing);
            
            #line default
            #line hidden
            
            #line 25 "..\..\..\..\AuthManager\Orders\AddOrder.xaml"
            this.status.ContextMenuOpening += new System.Windows.Controls.ContextMenuEventHandler(this.status_ContextMenuOpening);
            
            #line default
            #line hidden
            return;
            case 5:
            this.accept = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.@return = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            
            #line 31 "..\..\..\..\AuthManager\Orders\AddOrder.xaml"
            ((System.Windows.Controls.Label)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Label_Loaded);
            
            #line default
            #line hidden
            return;
            case 8:
            this.viewCOMP = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\AuthManager\Orders\AddOrder.xaml"
            this.viewCOMP.Click += new System.Windows.RoutedEventHandler(this.viewCOMP_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 33 "..\..\..\..\AuthManager\Orders\AddOrder.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 34 "..\..\..\..\AuthManager\Orders\AddOrder.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 11:
            this.viewMaster = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\AuthManager\Orders\AddOrder.xaml"
            this.viewMaster.Click += new System.Windows.RoutedEventHandler(this.viewMaster_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.viewClient = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\AuthManager\Orders\AddOrder.xaml"
            this.viewClient.Click += new System.Windows.RoutedEventHandler(this.viewClient_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 37 "..\..\..\..\AuthManager\Orders\AddOrder.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 14:
            this.client = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.master = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.pc = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
