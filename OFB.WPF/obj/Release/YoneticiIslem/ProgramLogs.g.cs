﻿#pragma checksum "..\..\..\YoneticiIslem\ProgramLogs.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51A88EA9FF4F07DD2BB80D01AE46FEF41D39E7F4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using OFB.WPF.YoneticiIslem;
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


namespace OFB.WPF.YoneticiIslem {
    
    
    /// <summary>
    /// ProgramLogs
    /// </summary>
    public partial class ProgramLogs : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\YoneticiIslem\ProgramLogs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid1;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\YoneticiIslem\ProgramLogs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnKapat;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\YoneticiIslem\ProgramLogs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAnasayfa;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\YoneticiIslem\ProgramLogs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_Anasayfa;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\YoneticiIslem\ProgramLogs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid1;
        
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
            System.Uri resourceLocater = new System.Uri("/OFB.WPF;component/yoneticiislem/programlogs.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\YoneticiIslem\ProgramLogs.xaml"
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
            
            #line 8 "..\..\..\YoneticiIslem\ProgramLogs.xaml"
            ((OFB.WPF.YoneticiIslem.ProgramLogs)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.grid1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            
            #line 10 "..\..\..\YoneticiIslem\ProgramLogs.xaml"
            ((System.Windows.Controls.StackPanel)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.StackPanel_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnKapat = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\YoneticiIslem\ProgramLogs.xaml"
            this.btnKapat.Click += new System.Windows.RoutedEventHandler(this.thisWindowClose_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnAnasayfa = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\YoneticiIslem\ProgramLogs.xaml"
            this.btnAnasayfa.Click += new System.Windows.RoutedEventHandler(this.Button_Clickk);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lbl_Anasayfa = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.dataGrid1 = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

