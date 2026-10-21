namespace Semana3.Views;

public partial class vLogin : ContentPage
{
    private const string usuario = "pablouchuari";
    private const string contrasena = "123456Aa*";

    public vLogin()
    {
        InitializeComponent();
    }

    private void OnTogglePasswordTapped(object? sender, TappedEventArgs e)
    {
        txtcontrasena.IsPassword = !txtcontrasena.IsPassword;
        EyeSlash.IsVisible = txtcontrasena.IsPassword; // slash = password hidden
    }

    private async void btnIniciarSesion_Clicked(object? sender, EventArgs e)
    {
        try
        {
            string usuarioingresado = txtUsuario.Text;
            string contrasenaIngresada = txtcontrasena.Text;
            if (usuario == usuarioingresado && contrasena == contrasenaIngresada)
            {
                await Navigation.PushAsync(new vPrincipal(usuarioingresado));
            }
            else
            {
                await DisplayAlertAsync("ERROR", "Usuario/Contraseña Incorrectos", "Cerrar");
                txtUsuario.Text = string.Empty;
                txtcontrasena.Text = string.Empty;
                txtUsuario.Focus();
            }
        }
        catch (Exception ex)
        {
            await DisplayAlertAsync("ERROR", ex.Message, "Cerrar");
        }
    }

    private async void btnRegistrar_Clicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new vRegistro());
    }
}
