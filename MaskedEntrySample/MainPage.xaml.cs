using Microsoft.Extensions.Logging.Abstractions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MaskedEntrySample
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private  void OnValidateClicked(object sender, EventArgs e)
        {
            if (phoneNumberEntry.HasError)
            {
                DisplayAlertAsync("Alert ", "Enter a Valid credentials", "OK");
                return;
            }
            DisplayAlertAsync("Alert ", "Submitted Successfully", "OK");
            
        }
        
    }
    
}
