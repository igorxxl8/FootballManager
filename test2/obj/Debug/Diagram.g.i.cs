﻿#pragma checksum "..\..\Diagram.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "454D3822347A662CEACC0F80CA56DE54281B0983"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace FootballManager {
    
    
    /// <summary>
    /// Diagram
    /// </summary>
    public partial class Diagram : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\Diagram.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid container;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Diagram.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider Slider;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Diagram.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Sel;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Diagram.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Pan;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Diagram.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MoreValue;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\Diagram.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LessValue;
        
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
            System.Uri resourceLocater = new System.Uri("/FootballManager;component/diagram.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Diagram.xaml"
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
            this.container = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Slider = ((System.Windows.Controls.Slider)(target));
            return;
            case 3:
            this.Sel = ((System.Windows.Controls.TextBox)(target));
            
            #line 43 "..\..\Diagram.xaml"
            this.Sel.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Sel_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Pan = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.MoreValue = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\Diagram.xaml"
            this.MoreValue.Click += new System.Windows.RoutedEventHandler(this.MoreValue_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LessValue = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\Diagram.xaml"
            this.LessValue.Click += new System.Windows.RoutedEventHandler(this.LessValue_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

