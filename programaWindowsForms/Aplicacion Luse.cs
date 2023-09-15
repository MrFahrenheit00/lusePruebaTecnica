namespace PruebaTecnica
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        private string nota = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void buttonGuardarNota_Click(object sender, EventArgs e)
        {
            nota = textBox.Text;
            textBox.Clear();

            await GuardarNotaEnElServicio(nota);
        }
        private async void buttonLeerNota_Click(object sender, EventArgs e)
        {
            label.Text = "";
            await LeerNotaDelServicio();
        }
        private async void buttonBorrarNota_Click(object sender, EventArgs e)
        {
            nota = string.Empty;
            label.Text = "";
            await BorrarNotaEnElServicio();
            
        }
        private async Task GuardarNotaEnElServicio(string nota)
        {
            try
            {
                var content = new FormUrlEncodedContent(new System.Collections.Generic.Dictionary<string, string>
                {
                    { "nota", nota }
                });

                HttpResponseMessage response = await httpClient.PostAsync("http://localhost:2023/guardar-nota", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Nota guardada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar la nota en el servicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar la nota al servicio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task LeerNotaDelServicio()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("http://localhost:2023/leer-nota");

                if (response.IsSuccessStatusCode)
                {
                    string notaLeida = await response.Content.ReadAsStringAsync();
                    label.Text = $"{notaLeida}";
                }
                else
                {
                    MessageBox.Show("Error al leer la nota desde el servicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener la nota desde el servicio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task BorrarNotaEnElServicio()
        {
            try
            {
                HttpResponseMessage response = await httpClient.DeleteAsync("http://localhost:2023/borrar-nota");

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Nota borrada con éxito en el servicio.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al borrar la nota en el servicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al borrar la nota en el servicio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}