﻿#pragma checksum "..\..\progressWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7F83E01C77942EA050FD3292A4B373FD4CED6332011840935480AB733C6EE4D7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using VMATTBI_optLoop;


namespace VMATTBI_optLoop {
    
    
    /// <summary>
    /// progressWindow
    /// </summary>
    public partial class progressWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\progressWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer scroller;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\progressWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock update;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\progressWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button abort;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\progressWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox abortStatus;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\progressWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button write;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\progressWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar progress;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\progressWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock runTime;
        
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
            System.Uri resourceLocater = new System.Uri("/VMATTBI_optLoopMT_v1.0;component/progresswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\progressWindow.xaml"
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
            
            #line 8 "..\..\progressWindow.xaml"
            ((VMATTBI_optLoop.progressWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.scroller = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 3:
            this.update = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.abort = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\progressWindow.xaml"
            this.abort.Click += new System.Windows.RoutedEventHandler(this.Abort_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.abortStatus = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.write = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\progressWindow.xaml"
            this.write.Click += new System.Windows.RoutedEventHandler(this.WriteResults_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.progress = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 8:
            this.runTime = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

