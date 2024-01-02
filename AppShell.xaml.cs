using InformatinApp.View;

namespace InformatinApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(SecondPage), typeof(SecondPage));
        }
    }
}
