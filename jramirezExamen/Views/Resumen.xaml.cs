namespace jramirezExamen.Views;

public partial class Resumen : ContentPage
{
    private Resumen _resumen;
    public string Nombre => _resumen.Nombre;
    public string Apellidos => _resumen.Apellidos;
    public DateTime FechaNacimiento => _resumen.FechaNacimiento;
    public string Correo => _resumen.Correo;
    public double Salario => _resumen.Salario;
    public double AporteIESS => _resumen.CalcularAporteIESS();
    public Resumen()
	{
		InitializeComponent();
	}

    private void cerrar_Clicked(object sender, EventArgs e)
    {

    }
}