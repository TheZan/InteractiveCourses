﻿#pragma checksum "..\..\..\Page\AddSubmodule.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B0B2F6AACFCB9949372943A83021C1DF3C1AB486961F214B9F77B9B89B010A59"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CoursesAdmin.Page;
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


namespace CoursesAdmin.Page {
    
    
    /// <summary>
    /// AddSubmodule
    /// </summary>
    public partial class AddSubmodule : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Page\AddSubmodule.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid main;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Page\AddSubmodule.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox submoduleName;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Page\AddSubmodule.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Page\AddSubmodule.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush submoduleImage;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Page\AddSubmodule.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addImage;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Page\AddSubmodule.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox rtbEditor;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Page\AddSubmodule.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addEditButton;
        
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
            System.Uri resourceLocater = new System.Uri("/CoursesAdmin;component/page/addsubmodule.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Page\AddSubmodule.xaml"
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
            this.main = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.submoduleName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Page\AddSubmodule.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.submoduleImage = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 5:
            this.addImage = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Page\AddSubmodule.xaml"
            this.addImage.Click += new System.Windows.RoutedEventHandler(this.addImage_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.rtbEditor = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 7:
            this.addEditButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Page\AddSubmodule.xaml"
            this.addEditButton.Click += new System.Windows.RoutedEventHandler(this.addEditButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

