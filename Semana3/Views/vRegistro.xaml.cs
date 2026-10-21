namespace Semana3.Views;

public partial class vRegistro : ContentPage
{
    public vRegistro()
    {
        InitializeComponent();
    }

    private void OnTogglePasswordTapped(object? sender, TappedEventArgs e)
    {
        txtcontrasena.IsPassword = !txtcontrasena.IsPassword;
        EyeSlash.IsVisible = txtcontrasena.IsPassword;
    }

    private async void btnRegistrar_Clicked(object? sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrEmpty(txtcontrasena.Text))
            {
                await DisplayAlertAsync("ERROR", "Completa usuario y contraseña", "Cerrar");
                return;
            }

            if (txtcontrasena.Text != txtConfirmar.Text)
            {
                await DisplayAlertAsync("ERROR", "Las contraseñas no coinciden", "Cerrar");
                return;
            }

            await DisplayAlertAsync("Registro", $"Cuenta creada para {txtUsuario.Text.Trim()}", "OK");
            await Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            await DisplayAlertAsync("ERROR", ex.Message, "Cerrar");
        }
    }

    private async void btnVolver_Clicked(object? sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
