﻿#pragma checksum "C:\Users\autum\Desktop\discoverdeis-uwp\Discover Deis\Pages\Navigate.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3C80ABE7A500C72D1B8EE21B8EBABB94"
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
    partial class Navigate : 
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
                    this.navGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 11 "..\..\..\Pages\Navigate.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.navGrid).SizeChanged += this.grid_SizeChanged;
                    #line default
                }
                break;
            case 2:
                {
                    this.LayoutGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 3:
                {
                    this.NavigateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 4:
                {
                    this.OneCol = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5:
                {
                    this.TwoCols = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6:
                {
                    this.VSPhone = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 7:
                {
                    this.VSTablet = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 8:
                {
                    this.VSLaptop = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 9:
                {
                    this.layoutGrid = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 10:
                {
                    this.navCommandBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 11:
                {
                    this.bottomCurrentLoc = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.startPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 13:
                {
                    this.endPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 14:
                {
                    this.mapPanel = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 15:
                {
                    this.routeMap = (global::Windows.UI.Xaml.Controls.Maps.MapControl)(target);
                }
                break;
            case 16:
                {
                    this.end = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                }
                break;
            case 17:
                {
                    this.start = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
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

