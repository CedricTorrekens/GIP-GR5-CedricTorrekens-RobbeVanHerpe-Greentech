﻿#pragma checksum "..\..\DataGraph.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8C74828500E7FD21AA7F73F4B630944C66DDDFD9193064A74BC522B5A22A405A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GIP_GR5_CedricTorrekens_RobbeVanHerpe_Greentech;
using LiveCharts.Wpf;
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


namespace GIP_GR5_CedricTorrekens_RobbeVanHerpe_Greentech {
    
    
    /// <summary>
    /// DataGraph
    /// </summary>
    public partial class DataGraph : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 75 "..\..\DataGraph.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmdViewSelect;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\DataGraph.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid plotter;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\DataGraph.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.Axis X;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\DataGraph.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.Axis Y;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\DataGraph.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgvData;
        
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
            System.Uri resourceLocater = new System.Uri("/GIP-GR5-CedricTorrekens-RobbeVanHerpe-Greentech;component/datagraph.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DataGraph.xaml"
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
            this.cmdViewSelect = ((System.Windows.Controls.ComboBox)(target));
            
            #line 75 "..\..\DataGraph.xaml"
            this.cmdViewSelect.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ViewSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 81 "..\..\DataGraph.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnSearchData_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.plotter = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            
            #line 91 "..\..\DataGraph.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ResetZoomOnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.X = ((LiveCharts.Wpf.Axis)(target));
            return;
            case 6:
            this.Y = ((LiveCharts.Wpf.Axis)(target));
            return;
            case 7:
            this.dgvData = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

