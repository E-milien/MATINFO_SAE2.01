﻿#pragma checksum "..\..\..\AjtMateriel.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9AE56A11EC38964946989BC9DE5D5E6818314038"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MATINFO;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace MATINFO {
    
    
    /// <summary>
    /// AjtMateriel
    /// </summary>
    public partial class AjtMateriel : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\AjtMateriel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvCat;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\AjtMateriel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNom;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\AjtMateriel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbCB;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\AjtMateriel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbRefe;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\AjtMateriel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btEnregistrer;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MATINFO;component/ajtmateriel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AjtMateriel.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\AjtMateriel.xaml"
            ((MATINFO.AjtMateriel)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Modale_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lvCat = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.tbNom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbCB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbRefe = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btEnregistrer = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\AjtMateriel.xaml"
            this.btEnregistrer.Click += new System.Windows.RoutedEventHandler(this.btEnregistrer_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

