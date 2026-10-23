namespace Semana3.Views;

public partial class vEstilos : ContentPage
{
    public vEstilos()
    {
        InitializeComponent();
    }

    private async void btnVolver_Clicked(object? sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
