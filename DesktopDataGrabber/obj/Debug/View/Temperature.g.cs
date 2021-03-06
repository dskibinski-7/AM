#pragma checksum "..\..\..\View\Temperature.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "488F252122F7A8B836E6909CC905B1409F1D8D4E7F34A2FAD7A0C7EF12558D62"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DesktopDataGrabber.ViewModel;
using OxyPlot.Wpf;
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


namespace DesktopDataGrabber.View {
    
    
    /// <summary>
    /// Temperature
    /// </summary>
    public partial class Temperature : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\View\Temperature.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MenuBtn;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\View\Temperature.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Menu;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\View\Temperature.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TempUnit;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\View\Temperature.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock HumUnit;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\View\Temperature.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PressUnit;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\View\Temperature.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OxyPlot.Wpf.PlotView CTemperaturePlotView;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\View\Temperature.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OxyPlot.Wpf.PlotView FTemperaturePlotView;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\View\Temperature.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OxyPlot.Wpf.PlotView HumidityPlotView;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\View\Temperature.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OxyPlot.Wpf.PlotView LHumidityPlotView;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\View\Temperature.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OxyPlot.Wpf.PlotView PressurePlotView;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\View\Temperature.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OxyPlot.Wpf.PlotView HgPressurePlotView;
        
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
            System.Uri resourceLocater = new System.Uri("/DesktopDataGrabber;component/view/temperature.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Temperature.xaml"
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
            this.MenuBtn = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\View\Temperature.xaml"
            this.MenuBtn.Click += new System.Windows.RoutedEventHandler(this.MenuBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Menu = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            
            #line 49 "..\..\..\View\Temperature.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RPYButton);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 50 "..\..\..\View\Temperature.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LedsButton);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 51 "..\..\..\View\Temperature.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.TableInfoButton);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 53 "..\..\..\View\Temperature.xaml"
            ((System.Windows.Controls.Primitives.ToggleButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.TemperatureChecked);
            
            #line default
            #line hidden
            
            #line 53 "..\..\..\View\Temperature.xaml"
            ((System.Windows.Controls.Primitives.ToggleButton)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.TemperatureUnchecked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TempUnit = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            
            #line 55 "..\..\..\View\Temperature.xaml"
            ((System.Windows.Controls.Primitives.ToggleButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.HumidityChecked);
            
            #line default
            #line hidden
            
            #line 55 "..\..\..\View\Temperature.xaml"
            ((System.Windows.Controls.Primitives.ToggleButton)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.HumidityUnchecked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.HumUnit = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            
            #line 57 "..\..\..\View\Temperature.xaml"
            ((System.Windows.Controls.Primitives.ToggleButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.PressureChecked);
            
            #line default
            #line hidden
            
            #line 57 "..\..\..\View\Temperature.xaml"
            ((System.Windows.Controls.Primitives.ToggleButton)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.PressureUnchecked);
            
            #line default
            #line hidden
            return;
            case 11:
            this.PressUnit = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.CTemperaturePlotView = ((OxyPlot.Wpf.PlotView)(target));
            return;
            case 13:
            this.FTemperaturePlotView = ((OxyPlot.Wpf.PlotView)(target));
            return;
            case 14:
            this.HumidityPlotView = ((OxyPlot.Wpf.PlotView)(target));
            return;
            case 15:
            this.LHumidityPlotView = ((OxyPlot.Wpf.PlotView)(target));
            return;
            case 16:
            this.PressurePlotView = ((OxyPlot.Wpf.PlotView)(target));
            return;
            case 17:
            this.HgPressurePlotView = ((OxyPlot.Wpf.PlotView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

