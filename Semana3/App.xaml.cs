using Microsoft.Extensions.DependencyInjection;
using Semana3.Views;

namespace Semana3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new vLogin()));
        }
    }
}
