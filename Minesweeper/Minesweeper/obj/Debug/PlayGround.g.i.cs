﻿#pragma checksum "..\..\PlayGround.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F3092F8647221DCDAD419BAABFE7E9EC7BB4AED91B8A727DB4E625696DE7B384"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Minesweeper;
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


namespace Minesweeper {
    
    
    /// <summary>
    /// PlayGround
    /// </summary>
    public partial class PlayGround : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\PlayGround.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Minesweeper.PlayGround PlayGround1;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\PlayGround.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Mygrid;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\PlayGround.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Restart;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\PlayGround.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Field;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\PlayGround.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\PlayGround.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\PlayGround.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/Minesweeper;component/playground.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PlayGround.xaml"
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
            this.PlayGround1 = ((Minesweeper.PlayGround)(target));
            
            #line 8 "..\..\PlayGround.xaml"
            this.PlayGround1.Closing += new System.ComponentModel.CancelEventHandler(this.PlayGround_Closing);
            
            #line default
            #line hidden
            
            #line 8 "..\..\PlayGround.xaml"
            this.PlayGround1.Loaded += new System.Windows.RoutedEventHandler(this.PlayGround1_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Mygrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Restart = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\PlayGround.xaml"
            this.Restart.Click += new System.Windows.RoutedEventHandler(this.Restart_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Field = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.tb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\PlayGround.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tbBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
