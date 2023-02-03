﻿#pragma checksum "..\..\WindowMappingKeypadBaseStationView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D09BFCCBC278EF69C10E6F6C130D24327F0E29B571387E2DD0E3338E1173DFA8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace EVotingDashBoard {
    
    
    /// <summary>
    /// WindowMappingKeypadBaseStationView
    /// </summary>
    public partial class WindowMappingKeypadBaseStationView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\WindowMappingKeypadBaseStationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.DoubleAnimation AniOpacity;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\WindowMappingKeypadBaseStationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Card cardHeader;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\WindowMappingKeypadBaseStationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\WindowMappingKeypadBaseStationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBaseID;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\WindowMappingKeypadBaseStationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtModel;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\WindowMappingKeypadBaseStationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtKeypadSN;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\WindowMappingKeypadBaseStationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox keypadId;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\WindowMappingKeypadBaseStationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVersion;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\WindowMappingKeypadBaseStationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRemarks;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\WindowMappingKeypadBaseStationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridView gridViewClassMaster;
        
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
            System.Uri resourceLocater = new System.Uri("/EVotingDashBoard;component/windowmappingkeypadbasestationview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowMappingKeypadBaseStationView.xaml"
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
            this.AniOpacity = ((System.Windows.Media.Animation.DoubleAnimation)(target));
            return;
            case 2:
            this.cardHeader = ((MaterialDesignThemes.Wpf.Card)(target));
            return;
            case 3:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\WindowMappingKeypadBaseStationView.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtBaseID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtModel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtKeypadSN = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.keypadId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtVersion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtRemarks = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.gridViewClassMaster = ((System.Windows.Controls.GridView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

