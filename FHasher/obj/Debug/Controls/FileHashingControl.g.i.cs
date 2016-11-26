﻿#pragma checksum "..\..\..\Controls\FileHashingControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CCCE338529AE2966C65CCB68B9B638C6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DownloadWatcherHashHelper;
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


namespace Fhasher.Controls {
    
    
    /// <summary>
    /// FileHashingControl
    /// </summary>
    public partial class FileHashingControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Controls\FileHashingControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdFileHashCnt;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Controls\FileHashingControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBxFileName;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Controls\FileHashingControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFileBrowse;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Controls\FileHashingControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBxFileHash;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Controls\FileHashingControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbHashType;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Controls\FileHashingControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem cbi1;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Controls\FileHashingControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem cbi2;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Controls\FileHashingControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBxFileSize;
        
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
            System.Uri resourceLocater = new System.Uri("/FHasher;component/controls/filehashingcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\FileHashingControl.xaml"
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
            
            #line 8 "..\..\..\Controls\FileHashingControl.xaml"
            ((Fhasher.Controls.FileHashingControl)(target)).Drop += new System.Windows.DragEventHandler(this.grdFileHashCnt_Drop);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\Controls\FileHashingControl.xaml"
            ((Fhasher.Controls.FileHashingControl)(target)).DragOver += new System.Windows.DragEventHandler(this.grdFileHashCnt_DragOver);
            
            #line default
            #line hidden
            return;
            case 2:
            this.grdFileHashCnt = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.txtBxFileName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnFileBrowse = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Controls\FileHashingControl.xaml"
            this.btnFileBrowse.Click += new System.Windows.RoutedEventHandler(this.btnFileBrowse_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtBxFileHash = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\..\Controls\FileHashingControl.xaml"
            this.txtBxFileHash.LostFocus += new System.Windows.RoutedEventHandler(this.txtBxFileHash_LostFocus);
            
            #line default
            #line hidden
            
            #line 40 "..\..\..\Controls\FileHashingControl.xaml"
            this.txtBxFileHash.KeyUp += new System.Windows.Input.KeyEventHandler(this.txtBxFileHash_KeyUp);
            
            #line default
            #line hidden
            
            #line 41 "..\..\..\Controls\FileHashingControl.xaml"
            this.txtBxFileHash.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.txtBxFileHash_GotFocus);
            
            #line default
            #line hidden
            
            #line 43 "..\..\..\Controls\FileHashingControl.xaml"
            this.txtBxFileHash.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.txtBxFileHash_GotFocus);
            
            #line default
            #line hidden
            
            #line 45 "..\..\..\Controls\FileHashingControl.xaml"
            this.txtBxFileHash.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.txtBxFileHash_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cmbHashType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 51 "..\..\..\Controls\FileHashingControl.xaml"
            this.cmbHashType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbHashType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cbi1 = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 8:
            this.cbi2 = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 9:
            this.txtBxFileSize = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

