namespace cchuquitarcoExamen.Vistas;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
        LimpiarCampos();
	}

    private void btnLogin_Clicked(object sender, EventArgs e)
    {
        string[][] usuarios = [["estudiante2024", "examen1", "NombreEstudiante"], 
        ["uisrael2024", "parcial1", "2024"]];

        int position = Array.IndexOf(usuarios[0], txtUsuario.Text);

        if (position != -1 && txtPassword.Text == usuarios[1][position])
        {
            Navigation.PushAsync(new Registro(usuarios[1][position]));
        }
        else
        {
            DisplayAlert("Error", "Usuario/Contraseña incorrecta.", "Cerrar");
        }
    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Acerca());
    }

    private void LimpiarCampos()
    {
        txtUsuario.Text = "";
        txtPassword.Text = "";
    }
}