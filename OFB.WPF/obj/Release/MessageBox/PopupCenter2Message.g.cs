﻿#pragma checksum "..\..\..\MessageBox\PopupCenter2Message.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "466E29E23940F18625E6D91997C461A48274A851"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using OFB.WPF.MessageBox;
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


namespace OFB.WPF.MessageBox {
    
    
    /// <summary>
    /// PopupCenter2Message
    /// </summary>
    public partial class PopupCenter2Message : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\MessageBox\PopupCenter2Message.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\MessageBox\PopupCenter2Message.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox richTextBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\MessageBox\PopupCenter2Message.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox richTextBox_Copy;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\MessageBox\PopupCenter2Message.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border borderversiyon;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\MessageBox\PopupCenter2Message.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblVersiyon;
        
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
            System.Uri resourceLocater = new System.Uri("/OFB.WPF;component/messagebox/popupcenter2message.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MessageBox\PopupCenter2Message.xaml"
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
            
            #line 10 "..\..\..\MessageBox\PopupCenter2Message.xaml"
            ((OFB.WPF.MessageBox.PopupCenter2Message)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.richTextBox = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 4:
            this.richTextBox_Copy = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 5:
            this.borderversiyon = ((System.Windows.Controls.Border)(target));
            return;
            case 6:
            this.lblVersiyon = ((System.Windows.Controls.Label)(target));
            
            #line 34 "..\..\..\MessageBox\PopupCenter2Message.xaml"
            this.lblVersiyon.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lblVersiyon_MouseDown);
            
            #line default
            #line hidden
            
            #line 34 "..\..\..\MessageBox\PopupCenter2Message.xaml"
            this.lblVersiyon.MouseEnter += new System.Windows.Input.MouseEventHandler(this.lblVersiyon_MouseEnter);
            
            #line default
            #line hidden
            
            #line 34 "..\..\..\MessageBox\PopupCenter2Message.xaml"
            this.lblVersiyon.MouseLeave += new System.Windows.Input.MouseEventHandler(this.lblVersiyon_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

