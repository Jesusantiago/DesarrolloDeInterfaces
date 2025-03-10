namespace WinFormsApp2;

public partial class Ejercicio8_While : Form
{
    public Ejercicio8_While()
    {
        InitializeComponent();
    }

    private void Ingresar_Click(object sender, EventArgs e)
    {
        int user = int.Parse(txtBox.Text);

        while (user > 0)
        {
            listBox.Items.Add("Mensaje de preba repetido.");
            user--;
        }
    }
}