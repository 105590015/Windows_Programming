﻿#pragma checksum "D:\SourceTree\Windows_Programming\DrawingApp\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "63EB5FDF222906EE93BA03ED1029C719"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DrawingApp
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 12
                {
                    this._canvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 3: // MainPage.xaml line 41
                {
                    this._saveButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 4: // MainPage.xaml line 42
                {
                    this._loadButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 5: // MainPage.xaml line 27
                {
                    this._ellipseButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 6: // MainPage.xaml line 28
                {
                    this._diamondButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 7: // MainPage.xaml line 29
                {
                    this._lineButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 8: // MainPage.xaml line 30
                {
                    this._clearButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 9: // MainPage.xaml line 31
                {
                    this._undoButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 10: // MainPage.xaml line 32
                {
                    this._redoButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
