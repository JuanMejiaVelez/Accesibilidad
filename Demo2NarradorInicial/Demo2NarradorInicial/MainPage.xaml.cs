using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Demo2NarradorInicial
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void StepOneButton_Click(object sender, RoutedEventArgs e)
        {
            StepOneButton.IsEnabled = false;

            ContainerOne.Visibility = Visibility.Collapsed;
            ContainerTwo.Visibility = Visibility.Visible;
        }

        private void StepTwoButton_Click(object sender, RoutedEventArgs e)
        {
            ContainerThree.Visibility = Visibility.Visible;
        }
    }
}
