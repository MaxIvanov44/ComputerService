﻿#pragma checksum "..\..\..\..\AuthMaster\Orders\UpdateOrderMaster.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EFF45F00E75CE3E37D7A544A33EF1CFF6A49301B33F8677CCB6B037EA7641C5B"
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
    /// UpdateOrderMaster
    /// </summary>
    public partial class UpdateOrderMaster : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\AuthMaster\Orders\UpdateOrderMaster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox description;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\AuthMaster\Orders\UpdateOrderMaster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox price;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\AuthMaster\Orders\UpdateOrderMaster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox status;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\AuthMaster\Orders\UpdateOrderMaster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker accept;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\AuthMaster\Orders\UpdateOrderMaster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker @return;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\AuthMaster\Orders\UpdateOrderMaster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idtxt;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\AuthMaster\Orders\UpdateOrderMaster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox master;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\AuthMaster\Orders\UpdateOrderMaster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pc;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\AuthMaster\Orders\UpdateOrderMaster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox client;
        
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
            System.Uri resourceLocater = new System.Uri("/Computer Service;component/authmaster/orders/updateordermaster.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\AuthMaster\Orders\UpdateOrderMaster.xaml"
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
            
            #line 11 "..\..\..\..\AuthMaster\Orders\UpdateOrderMaster.xaml"
            ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Grid_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.description = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.price = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            
            #line 21 "..\..\..\..\AuthMaster\Orders\UpdateOrderMaster.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.status = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.accept = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.@return = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.idtxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 32 "..\..\..\..\AuthMaster\Orders\UpdateOrderMaster.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 10:
            this.master = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.pc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.client = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

