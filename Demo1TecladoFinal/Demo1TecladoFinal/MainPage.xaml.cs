using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Demo1TecladoFinal
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

        /// <summary>
        /// Evento que se dispara antes que el Enfoque cambie hacia otro elemento
        /// </summary>
        private void FocusManager_LosingFocus(object sender, LosingFocusEventArgs e)
        {
            if(preventLosingFocus)
            {
                e.Cancel = true;
                // Igualmente se puede hacer uso de
                // e.TryCancel();
                // Ya que no siempre se puede garantizar que el 
                // evento se puede cancelar y se evita una excepción.
                preventLosingFocus = false;
            }
        }

        private void StepOneButton_Click(object sender, RoutedEventArgs e)
        {
            // Proteger que la siguiente acción cause que el enfoque
            // se desplace a un objecto indeseado.
            preventLosingFocus = true;

            StepOneButton.IsEnabled = false;

            ContainerOne.Visibility = Visibility.Collapsed;
            ContainerTwo.Visibility = Visibility.Visible;

            var next = FocusManager.FindNextElement(FocusNavigationDirection.Next);
            if (next.GetType() == typeof(Microsoft.UI.Xaml.Controls.NavigationViewItem))
            {
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                FocusManager.TryFocusAsync(EmailTextBox, FocusState.Programmatic);
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            }
        }
    }
}
