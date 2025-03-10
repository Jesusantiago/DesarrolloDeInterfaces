namespace WinFormsApp2;

public partial class Ejercicio4_Edad : Form
{
    public const string mayor = "Eres mayor de edad";
    public const string menor = "Eres menor de edad";
    public const string nombre = "Tu nombre es: ";
    public const string edad = "tu edad es: ";
    
    public Ejercicio4_Edad()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string name = txtName.Text;
        int age = int.Parse(txtAge.Text);
        string message = nombre + " " + name + " y " + edad + " " + age + ". ";
        if (age > 18)
        {
            message += mayor;
        }
        else
        {
            message += menor;
        }
        
        MessageBox.Show(message);
    }
 
}