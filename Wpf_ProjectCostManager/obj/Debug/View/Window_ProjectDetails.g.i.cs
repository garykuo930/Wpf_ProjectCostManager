﻿#pragma checksum "..\..\..\View\Window_ProjectDetails.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0C07A7D7FAB6C3CFD481F2C647A321281F52B2F7"
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

using De.TorstenMandelkow.MetroChart;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using Wpf_ProjectCostManager;


namespace Wpf_ProjectCostManager {
    
    
    /// <summary>
    /// Window_ProjectDetails
    /// </summary>
    public partial class Window_ProjectDetails : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\View\Window_ProjectDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_ID;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\View\Window_ProjectDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Name;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\View\Window_ProjectDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Department;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\View\Window_ProjectDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_InputCost;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\View\Window_ProjectDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_TotalCost;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\View\Window_ProjectDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar progressBar_Complete;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\View\Window_ProjectDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar progressBar_Budget;
        
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
            System.Uri resourceLocater = new System.Uri("/Wpf_ProjectCostManager;component/view/window_projectdetails.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Window_ProjectDetails.xaml"
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
            this.tb_ID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tb_Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tb_Department = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tb_InputCost = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tb_TotalCost = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.progressBar_Complete = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 7:
            this.progressBar_Budget = ((System.Windows.Controls.ProgressBar)(target));
            
            #line 37 "..\..\..\View\Window_ProjectDetails.xaml"
            this.progressBar_Budget.Loaded += new System.Windows.RoutedEventHandler(this.progressBar_Budget_Loaded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
