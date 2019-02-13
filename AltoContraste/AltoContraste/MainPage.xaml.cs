using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AltoContraste
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private bool preventLosingFocus = false;

        public MainPage()
        {
            InitializeComponent();

            FocusManager.LosingFocus += FocusManager_LosingFocus;
        }

        private void FocusManager_LosingFocus(object sender, LosingFocusEventArgs e)
        {
            if (preventLosingFocus)
            {
                e.Cancel = true;
                preventLosingFocus = false;
            }
        }

        private void StepOneButton_Click(object sender, RoutedEventArgs e)
        {
            preventLosingFocus = true;

            StepOneButton.IsEnabled = false;
            // Process something

            ContainerOne.Visibility = Visibility.Collapsed;
            ContainerTwo.Visibility = Visibility.Visible;

            var next = FocusManager.FindNextElement(FocusNavigationDirection.Next);
            if (next.GetType() == typeof(Microsoft.UI.Xaml.Controls.NavigationViewItem))
            {
                FocusManager.TryFocusAsync(EmailTextBox, FocusState.Programmatic);
            }
        }

        private void StepTwoButton_Click(object sender, RoutedEventArgs e)
        {
            ContainerThree.Visibility = Visibility.Visible;
        }
    }
}
