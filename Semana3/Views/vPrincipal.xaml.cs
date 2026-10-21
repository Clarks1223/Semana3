namespace Semana3.Views;

public partial class vPrincipal : ContentPage
{
    public vPrincipal(string usuario)
    {
        InitializeComponent();
        lblBienvenida.Text = $"Hola, {usuario}";
    }

    protected override bool OnBackButtonPressed() => true; // no volver al login con atrás

    private async void btnCerrarSesion_Clicked(object? sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}
