﻿#pragma checksum "..\..\CaseProcess.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B9C7E92932293BC85E2D5A5954598001727E404045218F209CE8A62F3F200721"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace OSKernel.Presentation.CustomControl {
    
    
    /// <summary>
    /// CaseProcess
    /// </summary>
    public partial class CaseProcess : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\CaseProcess.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OSKernel.Presentation.CustomControl.CaseProcess caseProcessUC;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\CaseProcess.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cb_control;
        
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
            System.Uri resourceLocater = new System.Uri("/OSKernel.Presentation.CustomControl;component/caseprocess.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CaseProcess.xaml"
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
            this.caseProcessUC = ((OSKernel.Presentation.CustomControl.CaseProcess)(target));
            return;
            case 2:
            this.cb_control = ((System.Windows.Controls.CheckBox)(target));
            
            #line 17 "..\..\CaseProcess.xaml"
            this.cb_control.MouseMove += new System.Windows.Input.MouseEventHandler(this.cb_control_MouseMove);
            
            #line default
            #line hidden
            
            #line 18 "..\..\CaseProcess.xaml"
            this.cb_control.MouseLeave += new System.Windows.Input.MouseEventHandler(this.cb_control_MouseLeave);
            
            #line default
            #line hidden
            
            #line 19 "..\..\CaseProcess.xaml"
            this.cb_control.Unchecked += new System.Windows.RoutedEventHandler(this.cb_control_Unchecked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

