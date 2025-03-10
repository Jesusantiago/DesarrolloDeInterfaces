namespace WinFormsApp2;

public partial class Ejercicio5_Clase_string : Form
{
    public Ejercicio5_Clase_string()
    {
        InitializeComponent();
    }


    private void button1_Click(object sender, EventArgs e)
    {
        string nombre = textName.Text;
        string message;

        nombre.Trim().ToLower();

        if (nombre.Length <= 5)
        {
            message = "El nombre del nombre es muy corto.";
        }
        else
        {
            message = "El nombre ha sido validado.";
        }

        labelValid.Visible = true;
        labelValid.Text = message;
    }
}