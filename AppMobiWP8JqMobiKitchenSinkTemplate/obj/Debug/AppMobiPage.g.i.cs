﻿#pragma checksum "C:\Users\Ryan\SkyDrive\Development\window8\AppMobiWP8JqMobiKitchenSinkTemplate\AppMobiWP8JqMobiKitchenSinkTemplate\AppMobiPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "84DD23E0C4E21827925FC531AD4523DE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace AppMobiWP8SimpleJqMobiTemplate {
    
    
    public partial class AppMobiPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Controls.PhoneApplicationPage phoneApplicationPage;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.WebBrowser webView;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/AppMobiWP8JqMobiKitchenSinkTemplate;component/AppMobiPage.xaml", System.UriKind.Relative));
            this.phoneApplicationPage = ((Microsoft.Phone.Controls.PhoneApplicationPage)(this.FindName("phoneApplicationPage")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.webView = ((Microsoft.Phone.Controls.WebBrowser)(this.FindName("webView")));
        }
    }
}

