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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Game : Page
    {
        public Game()
        {
            this.InitializeComponent();
        }


        private void navigateToMenu(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        /*private void AddLettersToResult(String name)
        {
            if (char.IsNumber(result.Text.Last()))
            {
                if (result.Text.Length == 1 && result.Text == "0")
                {
                    result.Text = string.Empty;
                }
                result.Text += name;
            }
            else
            {
                if (result.Text.Length !=  0)
                {
                    result.Text += name;
                }
            }
        }*/ 


        //private void AddOperationToResult(BindingOperations operation)
        //{
        //    if (result.Text.Length == 1 && result.Text == "0") return;

        //    if (!char.IsNumber(result.Text.Last()))
        //    {
        //        result.Text = result.Text.Substring(0, result.Text.Length - 1);
        //    }
        //}


        //#region Equal

        //private class Operand
        //{
        //    public BindingOperations operation = OperationCanceledException.NAME; //DEFAULT
        //}

        //private void play_Click (object sender, RoutedEventArgs e)
        //{
        //    AddOperationToResult(BindingOperations);
        //}

        //#endregion Equal

    }
}
