using InformatinApp.ViewModel;

namespace InformatinApp.View;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
		this.BindingContext = new SecondViewModel();
	}
}