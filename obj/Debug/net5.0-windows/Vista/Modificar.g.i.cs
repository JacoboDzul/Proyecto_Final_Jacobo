﻿#pragma checksum "..\..\..\..\Vista\Modificar.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2D3E8A20691A8536BADA3D035742B2290CDDA13A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Proyecto_Final_23AM.Vista;
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


namespace Proyecto_Final_23AM.Vista {
    
    
    /// <summary>
    /// Modificar
    /// </summary>
    public partial class Modificar : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\Vista\Modificar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_Minimizar;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Vista\Modificar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Bt_Cerrar;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Vista\Modificar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txt_Cantidad;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Vista\Modificar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txt_Proveedor;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Vista\Modificar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_GuardarRegistro;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Vista\Modificar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txt_NombreAlimento;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Vista\Modificar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SelectAlimentos;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Proyecto_Final_23AM;component/vista/modificar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Vista\Modificar.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.bt_Minimizar = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\Vista\Modificar.xaml"
            this.bt_Minimizar.Click += new System.Windows.RoutedEventHandler(this.bt_Minimizar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Bt_Cerrar = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\Vista\Modificar.xaml"
            this.Bt_Cerrar.Click += new System.Windows.RoutedEventHandler(this.Bt_Cerrar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Txt_Cantidad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Txt_Proveedor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btn_GuardarRegistro = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\Vista\Modificar.xaml"
            this.btn_GuardarRegistro.Click += new System.Windows.RoutedEventHandler(this.btn_GuardarRegistro_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Txt_NombreAlimento = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.SelectAlimentos = ((System.Windows.Controls.ComboBox)(target));
            
            #line 64 "..\..\..\..\Vista\Modificar.xaml"
            this.SelectAlimentos.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectAlimentos_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

