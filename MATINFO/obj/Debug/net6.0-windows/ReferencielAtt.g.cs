﻿#pragma checksum "..\..\..\ReferencielAtt.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "746ED94E0F8969539A69F703D358CBF0FEB28BEE"
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
    /// ReferencielAtt
    /// </summary>
    public partial class ReferencielAtt : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\ReferencielAtt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MATINFO.GestionAttribution gestionAttribution;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\ReferencielAtt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txTitre;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\ReferencielAtt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btSupprimer;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\ReferencielAtt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgCategorie;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\ReferencielAtt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btAjouter;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\ReferencielAtt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgPersonnel;
        
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
            System.Uri resourceLocater = new System.Uri("/MATINFO;component/referencielatt.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ReferencielAtt.xaml"
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
            
            #line 11 "..\..\..\ReferencielAtt.xaml"
            ((MATINFO.ReferencielAtt)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Modale_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gestionAttribution = ((MATINFO.GestionAttribution)(target));
            return;
            case 3:
            this.txTitre = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.btSupprimer = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\ReferencielAtt.xaml"
            this.btSupprimer.Click += new System.Windows.RoutedEventHandler(this.btSupprimer_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dgCategorie = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.btAjouter = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\ReferencielAtt.xaml"
            this.btAjouter.Click += new System.Windows.RoutedEventHandler(this.btAjouter_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.dgPersonnel = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

