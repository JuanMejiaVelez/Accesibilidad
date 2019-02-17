using Windows.UI.Xaml;
#region Stage 3
//using Windows.UI.Xaml.Automation.Peers;
#endregion
using Windows.UI.Xaml.Controls;
#region Stage 2
using Windows.UI.Xaml.Input;
#endregion

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Narrador
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
            FocusManager.LosingFocus += FocusManager_LosingFocus;
            #endregion
        }

        #region Stage 2
        private void FocusManager_LosingFocus(object sender, LosingFocusEventArgs e)
        {
            if (preventLosingFocus)
            {
                e.Cancel = true;
                preventLosingFocus = false;
            }
        }
        #endregion

        private void StepOneButton_Click(object sender, RoutedEventArgs e)
        {
            #region Stage 2
            preventLosingFocus = true;
            #endregion

            StepOneButton.IsEnabled = false;
            // Process something

            ContainerOne.Visibility = Visibility.Collapsed;
            ContainerTwo.Visibility = Visibility.Visible;

            #region Stage 2
            var next = FocusManager.FindNextElement(FocusNavigationDirection.Next);
            if (next.GetType() == typeof(Microsoft.UI.Xaml.Controls.NavigationViewItem))
            {
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                FocusManager.TryFocusAsync(EmailTextBox, FocusState.Programmatic);
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            }
            #endregion
        }

        private void StepTwoButton_Click(object sender, RoutedEventArgs e)
        {
            ContainerThree.Visibility = Visibility.Visible;
        }

        #region Stage 3
        //private void NotifyButton_Click(object sender, RoutedEventArgs e)
        //{
        //    AutomationPeer peer = ButtonAutomationPeer.CreatePeerForElement(NotifyButton);
        //    if (peer != null)
        //    {
        //        peer.RaiseNotificationEvent(AutomationNotificationKind.ActionCompleted, AutomationNotificationProcessing.ImportantAll, "The notification button has been clicked", "NotifyButtonActivity");
        //    }
        //}
        #endregion
    }
}
