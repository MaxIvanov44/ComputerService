﻿#pragma checksum "..\..\..\..\AuthClient\Orders\ClientOrdersCurrent - Копировать.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "62F814A8386E6EC96B915091BE87F263F752EF7CE13DBDB3A42A366AE017BEE6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ClientOrdersCurrent;
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
    /// ClientOrdersCurrent
    /// </summary>
    public partial class ClientOrdersCurrent : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\AuthClient\Orders\ClientOrdersCurrent - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid viewdgr;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\AuthClient\Orders\ClientOrdersCurrent - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnupdate;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\AuthClient\Orders\ClientOrdersCurrent - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
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
            System.Uri resourceLocater = new System.Uri("/Computer Service;component/authclient/orders/clientorderscurrent%20-%20%d0%9a%d0" +
                    "%be%d0%bf%d0%b8%d1%80%d0%be%d0%b2%d0%b0%d1%82%d1%8c.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\AuthClient\Orders\ClientOrdersCurrent - Копировать.xaml"
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
            
            #line 15 "..\..\..\..\AuthClient\Orders\ClientOrdersCurrent - Копировать.xaml"
            this.viewdgr.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.viewdgr_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\..\AuthClient\Orders\ClientOrdersCurrent - Копировать.xaml"
            this.viewdgr.Loaded += new System.Windows.RoutedEventHandler(this.viewdgr_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnupdate = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\AuthClient\Orders\ClientOrdersCurrent - Копировать.xaml"
            this.btnupdate.Click += new System.Windows.RoutedEventHandler(this.btnupdate_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\AuthClient\Orders\ClientOrdersCurrent - Копировать.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

