﻿#pragma checksum "..\..\ButtonTestWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C2B16EE25BEC9D59EC11426D0EC56026B74E42B8E6BDD9FD8812FB27FE7A3D72"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Blad_Steen_Schaar_UI;
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


namespace Blad_Steen_Schaar_UI {
    
    
    /// <summary>
    /// ButtonTestWindow
    /// </summary>
    public partial class ButtonTestWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\ButtonTestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBlad;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\ButtonTestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btnBladImage;
        
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
            System.Uri resourceLocater = new System.Uri("/Blad Steen Schaar UI;component/buttontestwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ButtonTestWindow.xaml"
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
            this.btnBlad = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\ButtonTestWindow.xaml"
            this.btnBlad.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btnBlad_MouseEnter);
            
            #line default
            #line hidden
            
            #line 32 "..\..\ButtonTestWindow.xaml"
            this.btnBlad.Click += new System.Windows.RoutedEventHandler(this.btnBlad_Click);
            
            #line default
            #line hidden
            
            #line 32 "..\..\ButtonTestWindow.xaml"
            this.btnBlad.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnBlad_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnBladImage = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

