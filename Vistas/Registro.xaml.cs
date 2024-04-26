using System.Runtime.InteropServices.ComTypes;

namespace cchuquitarcoExamen.Vistas;

public partial class Registro : ContentPage
{
	public Registro(string usuario)
	{
		InitializeComponent();
        lblUsuario.Text = "Hola, " + usuario;
    }

    private void txtMontoInicial_TextChanged(object sender, TextChangedEventArgs e)
    {
        if(txtMontoInicial.Text != "")
        { 
            double montoInicial = Convert.ToDouble(txtMontoInicial.Text);
            if (montoInicial > 1500 || montoInicial < 0)
            {
                DisplayAlert("Error", "El monto inicial debe ser entre 0 y 1500", "Cerrar");
            }
        }
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        double costo = 1500;
        double montoInicial = Convert.ToDouble(txtMontoInicial.Text);
        double pagoMensual = ((costo - montoInicial) / 4) + (costo * 4 / 100);
        txtPagoMensual.Text = Convert.ToString(pagoMensual);
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        var detalles = new Dictionary<string, object>()
        {
            {"Usuario", lblUsuario.Text},
            {"Nombre", txtNombre.Text},
            {"Apellido", txtApellido.Text},
            {"Edad", txtEdad.Text},
            {"Fecha", dpFecha.Date.ToString("dd/MM/yyyy")},
            {"Ciudad", pkCiudad.SelectedIndex},
            {"Pais", pkPais.SelectedIndex},
            {"MontoInicial", txtMontoInicial.Text},
            {"PagoMensual", txtPagoMensual.Text},
            {"PagoTotal", (Convert.ToDouble(txtPagoMensual.Text) * 4) + Convert.ToDouble(txtMontoInicial.Text)}
        };
        Navigation.PushAsync(new Resumen(detalles));
    }
}