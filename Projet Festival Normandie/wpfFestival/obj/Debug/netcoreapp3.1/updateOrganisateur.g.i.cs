﻿#pragma checksum "..\..\..\updateOrganisateur.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84CE4917805DCD110BB3EE14E7D5BBE3E01A712B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

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
using wpfFestival;


namespace wpfFestival {
    
    
    /// <summary>
    /// updateOrganisateur
    /// </summary>
    public partial class updateOrganisateur : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\updateOrganisateur.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox updatePrenomBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\updateOrganisateur.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox updateNomBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\updateOrganisateur.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox updateEmailBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\updateOrganisateur.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox updateMdpBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\updateOrganisateur.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox updateIdFestivalBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\updateOrganisateur.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LbOrganisateur;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\updateOrganisateur.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LbFestival;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/wpfFestival;V1.0.0.0;component/updateorganisateur.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\updateOrganisateur.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.updatePrenomBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.updateNomBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.updateEmailBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.updateMdpBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.updateIdFestivalBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 35 "..\..\..\updateOrganisateur.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnUpdateOrga);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LbOrganisateur = ((System.Windows.Controls.ListBox)(target));
            
            #line 37 "..\..\..\updateOrganisateur.xaml"
            this.LbOrganisateur.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LbOrganisateur_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.LbFestival = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

