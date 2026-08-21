using Microsoft.Extensions.Logging.Abstractions;
using Syncfusion.Maui.Inputs;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MaskedEntrySample
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

    private void OnMaskedEntry_ValueChanged(object sender, MaskedEntryValueChangedEventArgs e)
    {
            SfMaskedEntry maskedEntry = sender as SfMaskedEntry;
            if (maskedEntry.HasError)
            {
                DisplayAlertAsync("Validation", "Enter a valid Number.", "OK");
            }

            if (e.IsMaskCompleted)
            {
                DisplayAlertAsync("Validation", "Valid phone number.", "OK");
            }
        }
        
    }
    
}
