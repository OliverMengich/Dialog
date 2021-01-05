using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DialogsExample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void CLickButton_Click(object sender, RoutedEventArgs e)
        {
            DispLocation();

        }
        private async void Disp()
        {
            ContentDialog contentDialog = new ContentDialog
            {
                Title = "MyContent Dialog",
                Content = "Hello The Hotel is Closed now come back later",
                CloseButtonText = "OK"
            };
            ContentDialogResult result = await contentDialog.ShowAsync();
        }
        private async void DispLocation()
        {
            ContentDialog locationdiag = new ContentDialog
            {
                Title = "Allow App to Access Location",
                Content = "Allow Tagur to access the location of your phone",
                CloseButtonText="Block",
                PrimaryButtonText="Allow",
                
                
            };
            ContentDialogResult dialog = await locationdiag.ShowAsync();
            //
            

        }
        private void mymethod()
        { }
    }
}
