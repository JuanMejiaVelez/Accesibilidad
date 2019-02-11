using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Teclado
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
            // Process something

            ContainerOne.Visibility = Visibility.Collapsed;
            ContainerTwo.Visibility = Visibility.Visible;
        }
    }
}
