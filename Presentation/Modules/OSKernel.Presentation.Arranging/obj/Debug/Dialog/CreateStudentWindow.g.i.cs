﻿#pragma checksum "..\..\..\Dialog\CreateStudentWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AF8460F3D71B978726388CEAF5A7AC0C234883498BFF7D6C034DB2C4C099B254"
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
using OSKernel.Presentation.CustomControl;
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
    /// CreateStudentWindow
    /// </summary>
    public partial class CreateStudentWindow : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Dialog\CreateStudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_student;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Dialog\CreateStudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txt_message;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Dialog\CreateStudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_save;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Dialog\CreateStudentWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/OSKernel.Presentation.Arranging;component/dialog/createstudentwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Dialog\CreateStudentWindow.xaml"
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
            this.txt_student = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txt_message = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.btn_save = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Dialog\CreateStudentWindow.xaml"
            this.btn_save.Click += new System.Windows.RoutedEventHandler(this.Btn_save_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_cancel = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\Dialog\CreateStudentWindow.xaml"
            this.btn_cancel.Click += new System.Windows.RoutedEventHandler(this.Btn_cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

