
namespace cchuquitarcoExamen.Vistas;

public partial class Resumen : ContentPage
{
	public Resumen(Dictionary<string, object> datos)
    {
		InitializeComponent();
        var resumen = datos;

        lblUsuario.Text = (string)resumen["Usuario"];
        txtNombre.Text = (string)resumen["Nombre"];
        txtApellido.Text = (string)resumen["Apellido"];
        txtEdad.Text = (string)resumen["Edad"];
        dpFecha.Date = Convert.ToDateTime(resumen["Fecha"]);
        pkCiudad.SelectedIndex = (int)resumen["Ciudad"];
        pkPais.SelectedIndex = (int)resumen["Pais"];
        txtMontoInicial.Text = (string)resumen["MontoInicial"];
        txtPagoMensual.Text = (string)resumen["PagoMensual"];
        txtPagoTotal.Text = Convert.ToString(resumen["PagoTotal"]);
    }

    private void btnCerrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Login());
    }
}