using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace InformatinApp.ViewModel
{
    public class SecondViewModel
    {
        public ICommand GoBackCommand => new Command(async () => await BackCommand());

        private async Task BackCommand()
        {
            try
            {
                await App.Current.MainPage.Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }   
    }
}
