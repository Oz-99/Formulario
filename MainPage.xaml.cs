namespace Formulario
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnRegistrarClicked(object sender, EventArgs e)
        {
            string nombre = nombreEntry.Text;
            string email = emailEntry.Text;
            string telefono = telefonoEntry.Text;
            string genero = generoPicker.SelectedItem?.ToString() ?? "Genero no Seleccionado";

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telefono))
            {
                await DisplayAlert("Error", "Llena todos los campos!", "OK");
                return;
            }
            await DisplayAlert("Formulario Diligenciado con Exito!", $"Nombre: {nombre}\nEmail: {email}\nTelefono: {telefono}\nGenero: {genero}", "OK");
        }


    }

}
