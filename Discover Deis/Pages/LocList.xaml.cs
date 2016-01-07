﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Discover_Deis.Models;
using Windows.UI.Core;
using Windows.UI.Xaml.Media.Animation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Discover_Deis
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LocList : Page
    {
        private List<Loc> Locs;
        SystemNavigationManager systemNavigationManager = SystemNavigationManager.GetForCurrentView();

        public LocList()
        {
            this.InitializeComponent();
            Locs = LocManager.GetLocList();
        }


        private void view_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (Window.Current.Bounds.Width < 720)
            {
                view.OpenPaneLength = Window.Current.Bounds.Width;
            }
        }

        private void listOfLocs_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Window.Current.Bounds.Width < 720)
            {
                view.IsPaneOpen = false;

                //systemNavigationManager.BackRequested += DetailPage_BackRequested;
                SystemNavigationManager.GetForCurrentView().BackRequested += OnBackRequested;
                systemNavigationManager.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            }

            var selectedLoc = (Loc)e.ClickedItem;
            List<string> cat = selectedLoc.category;

            locTitle.Text = selectedLoc.name;
            if (cat != null)
            {
                if (cat.Count == 1)
                {
                    locCategories.Text = cat[0];
                } else
                {
                    string c = "";
                    for (int i = 0; i < cat.Count - 1; i++)
                    {
                        c += cat[i];
                        c += ", ";
                    }
                    c += cat[cat.Count - 1];
                    locCategories.Text = c;
                }
            }
        }

        private void OnBackRequested(object sender, BackRequestedEventArgs e)
        {
            if (!view.IsPaneOpen)
            {
                view.IsPaneOpen = true;
                systemNavigationManager.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            }
        }
    }
}
