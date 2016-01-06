using System;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Discover_Deis
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            navFrame.Navigate(typeof(Navigate));
        }

        private void MainPivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
#if false
            for (int i = 0; i < MainPivot.Items.Count; i++)
            {
                if (i == MainPivot.SelectedIndex)
                {
                    PivotItem selectedPivotItem = MainPivot.SelectedItem as PivotItem;
                    (selectedPivotItem.Header as TabHeader).Foreground = new SolidColorBrush(Windows.UI.Colors.Red);

                }
                else
                {
                    PivotItem unselectedPivotItem = MainPivot.Items[i] as PivotItem;
                    (unselectedPivotItem.Header as TabHeader).Foreground = new SolidColorBrush(Windows.UI.Colors.DarkBlue);
                }
            } 
#endif

        }
    }
}
