﻿#pragma checksum "..\..\Mainpage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C5B8A3CCAAD32706D62924D8A54EEB29"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PhMS;
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


namespace PhMS {
    
    
    /// <summary>
    /// Mainpage
    /// </summary>
    public partial class Mainpage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\Mainpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Madicine;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Mainpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sta_btn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Mainpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_c;
        
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
            System.Uri resourceLocater = new System.Uri("/PhMS;component/mainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Mainpage.xaml"
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
            this.Madicine = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Mainpage.xaml"
            this.Madicine.Click += new System.Windows.RoutedEventHandler(this.btn_medi);
            
            #line default
            #line hidden
            return;
            case 2:
            this.sta_btn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Mainpage.xaml"
            this.sta_btn.Click += new System.Windows.RoutedEventHandler(this.satffp_btn);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_c = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Mainpage.xaml"
            this.btn_c.Click += new System.Windows.RoutedEventHandler(this.btn_company);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 36 "..\..\Mainpage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.bi);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

