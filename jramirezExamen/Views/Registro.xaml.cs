namespace jramirezExamen.Views;

public partial class Registro : ContentPage
{
    private string _usuario;
    public Registro(string usuario)
	{
		InitializeComponent();
        _usuario = usuario;
        Conectado.Text = "Usuario conectado: " + _usuario;
    }

    private void calcular_Clicked(object sender, EventArgs e)
    {
        double montoInicial = double.Parse(InitialAmountTextBox.Text);
        double cuotaMensual = montoInicial * 0.05;  // Ejemplo de cálculo
        MonthlyFeeTextBox.Text = cuotaMensual.ToString("C2");
    }

    private async void resumen_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(Nombre.Text) ||
            string.IsNullOrWhiteSpace(Apellido.Text) ||
            VAComboBox.SelectedIndex == -1 ||
            CityComboBox.SelectedIndex == -1 ||
            string.IsNullOrWhiteSpace(InitialAmountTextBox.Text) ||
            string.IsNullOrWhiteSpace(MonthlyFeeTextBox.Text))
            
        {
            await DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
            return;
        }

        var resumen = new Resumen();   
        {


            Nombre = Nombre.Text;
            Apellido = Apellido.Text;
            TipoIdentificacion = VAComboBox.SelectedItem.ToString();
            FechaNacimiento = DatePicker.Date; 
            InitialAmountTextBox = double.Parse(InitialAmountTextBox.Text);
            MonthlyFeeTextBox = double.Parse(MonthlyFeeTextBox.Text);
        }
        ;

        await Navigation.PushAsync(new Resumen(resumen));
    }
}