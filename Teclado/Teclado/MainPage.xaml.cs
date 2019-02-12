﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Teclado
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        #region Stage 2
        private bool preventLosingFocus = false;
        #endregion
        public MainPage()
        {
            InitializeComponent();

            #region Stage 2
            //FocusManager.LosingFocus += FocusManager_LosingFocus;
            #endregion
        }

        #region Stage 2
        //private void FocusManager_LosingFocus(object sender, LosingFocusEventArgs e)
        //{
        //    if (preventLosingFocus)
        //    {
        //        e.Cancel = true;
        //        preventLosingFocus = false;
        //    }
        //}
        #endregion

        private void StepOneButton_Click(object sender, RoutedEventArgs e)
        {
            #region Stage 2
            //preventLosingFocus = true;
            #endregion
            
            StepOneButton.IsEnabled = false;
            // Process something

            ContainerOne.Visibility = Visibility.Collapsed;
            ContainerTwo.Visibility = Visibility.Visible;

            #region Stage 2
            //var next = FocusManager.FindNextElement(FocusNavigationDirection.Next);
            //if (next.GetType() == typeof(Microsoft.UI.Xaml.Controls.NavigationViewItem))
            //{
            //    FocusManager.TryFocusAsync(EmailTextBox, FocusState.Programmatic);
            //}
            #endregion
        }

    }
}
