using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // add my stuff here
        }


        private void StartButton(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Game));
        }

        private void OptionsButton(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Options));
        }

        private void QuitButton(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();


        }

        private void createNewTextBlock(String message)
        {
            // create the text block here.
            TextBlock mouse;

            // instantiate variable
            mouse = new TextBlock();

            // set attributes
            mouse.Text = message;
            mouse.Name = "tblMouse";
            mouse.HorizontalAlignment = HorizontalAlignment.Center;
            mouse.VerticalAlignment = VerticalAlignment.Bottom;
            mouse.Margin = new Thickness(0, 0, 0, 50);

            // add to the UI
            //Parent.children.add(new object)
            grdRoot.Children.Add(mouse);
        }

        private void navigateToGame(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Game));
        }


        //Addition of the music to the app
        SystemMediaTransportControls systemControls;

        public int SystemControls_ButtonPressed { get; private set; }
        public SystemMediaTransportControls MusicPlayer_CurrentStateChanged { get; private set; }

        void InitializeTransportControls()
        {
            // Hook up app to system transport controls.
            //systemControls = MusicPlayer_CurrentStateChanged;
        
            systemControls = SystemMediaTransportControls.GetForCurrentView();

            //systemControls.ButtonPressed += SystemControls_ButtonPressed;

            // Register to handle the following system transpot control buttons.
            systemControls.IsPlayEnabled = true;
            systemControls.IsPauseEnabled = true;
        }

    }
}
