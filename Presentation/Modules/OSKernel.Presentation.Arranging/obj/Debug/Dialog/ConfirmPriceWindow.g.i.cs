﻿#pragma checksum "..\..\..\Dialog\ConfirmPriceWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6C37302DC50CF2395BF491A9F2A4547E63EF47C2B103E888482EE1A5B36A139E"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using OSKernel.Presentation.Arranging.Dialog;
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


namespace OSKernel.Presentation.Arranging.Dialog {
    
    
    /// <summary>
    /// ConfirmPriceWindow
    /// </summary>
    public partial class ConfirmPriceWindow : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\Dialog\ConfirmPriceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run txt_price;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Dialog\ConfirmPriceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_save;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Dialog\ConfirmPriceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_cancel;
        
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
            System.Uri resourceLocater = new System.Uri("/OSKernel.Presentation.Arranging;component/dialog/confirmpricewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Dialog\ConfirmPriceWindow.xaml"
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
            this.txt_price = ((System.Windows.Documents.Run)(target));
            return;
            case 2:
            this.btn_save = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\Dialog\ConfirmPriceWindow.xaml"
            this.btn_save.Click += new System.Windows.RoutedEventHandler(this.Btn_save_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_cancel = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\Dialog\ConfirmPriceWindow.xaml"
            this.btn_cancel.Click += new System.Windows.RoutedEventHandler(this.Btn_cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

