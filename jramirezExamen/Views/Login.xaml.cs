using System.Security.Principal;

namespace jramirezExamen.Resources;

public partial class Login : ContentPage
{
    private readonly Dictionary<string, string> usuariosValidos = new()
    {
        { "estudiante2025", "moviles" },
        { "uisrael", "2025" },
        { "sistemas", "2025_1" }
    };
    public Login()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        string usuario = usuarioEntry.Text?.Trim();
        string contrasena = contrasenaEntry.Text;

        if (usuario != null && usuariosValidos.TryGetValue(usuario, out string contrasenaEsperada))
        {
            if (contrasena == contrasenaEsperada)
            {
                // Login correcto: navegar a MainPage
                await Navigation.PushAsync(new Views.Registro(usuario));

                return;

            }
        }

        // Si no coincide, mostrar error
        await DisplayAlert("Error", "Usuario o contraseña incorrectos.", "OK");
    }
}