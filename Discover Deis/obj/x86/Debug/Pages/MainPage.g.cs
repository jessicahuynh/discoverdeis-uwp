﻿#pragma checksum "C:\Users\autum\Desktop\discoverdeis-uwp\Discover Deis\Pages\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F10B95109A9147C02464EF93D5408579"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Discover_Deis
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.MainPivot = (global::Windows.UI.Xaml.Controls.Pivot)(target);
                    #line 243 "..\..\..\Pages\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Pivot)this.MainPivot).SelectionChanged += this.MainPivot_SelectionChanged;
                    #line default
                }
                break;
            case 2:
                {
                    this.locListFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 3:
                {
                    this.navFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

