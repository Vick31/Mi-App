using MiApp.Vistas.CuentasXPagar;

namespace MiApp.Vistas;

public partial class Inicio : ContentPage
{
	public Inicio()
	{
		InitializeComponent();
	}

    private async void btnCuentasXPagar_Clicked(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new frmListaCuentasPagar());
    }

    private async void btnRecordatorios_Clicked(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new frmListaCuentasPagar());
    }
}