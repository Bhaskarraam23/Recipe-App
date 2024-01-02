using System.Windows.Input;
using InformatinApp.View;

namespace InformatinApp.ViewModel
{
    public class MainViewModel 
    {
        public ICommand ButtonClickedCommand => new Command(async () => await OnButtonClicked());
       private async Task OnButtonClicked()
        {
            try
            {
                await App.Current.MainPage.Navigation.PushAsync(new SecondPage());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
