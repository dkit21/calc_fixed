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
using Windows.UI.Xaml.Media.Animation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private void SetUpPageAnimation()
        {
            TransitionCollection collection = new TransitionCollection();
            NavigationThemeTransition theme = new NavigationThemeTransition();

            var info = new ContinuumNavigationTransitionInfo();

            theme.DefaultNavigationTransitionInfo = info;
            collection.Add(theme);
            this.Transitions = collection;
        }
        public MainPage()
        {
            this.InitializeComponent();
            SetUpPageAnimation();
        }

        private void nameInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void click_tambah(object sender, RoutedEventArgs e)
        {
            {
                int data1 = int.Parse(nameInput2.Text);
                int data2 = int.Parse(nameInput.Text);
                int result = data1 + data2;
                Hasil.Text = result.ToString();
            }
        }

        private void click_kurang(object sender, RoutedEventArgs e)
        {
            int data1 = int.Parse(nameInput2.Text);
            int data2 = int.Parse(nameInput.Text);
            int result = data1 - data2;
            Hasil.Text = result.ToString();
        }

        private void click_kali(object sender, RoutedEventArgs e)
        {
            int data1 = int.Parse(nameInput2.Text);
            int data2 = int.Parse(nameInput.Text);
            int result = data1 * data2;
            Hasil.Text = result.ToString();
        }

        private void click_bagi(object sender, RoutedEventArgs e)
        {
            double data1 = double.Parse(nameInput2.Text);
            double data2 = double.Parse(nameInput.Text);
            double result = data1 / data2;
            Hasil.Text = result.ToString();
        }

        private void click_about(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(hal_about));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
        }
    }
}
