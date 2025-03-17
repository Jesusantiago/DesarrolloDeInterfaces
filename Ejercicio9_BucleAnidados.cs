namespace WinFormsApp2;

public partial class Ejercicio9_BucleAnidados : Form
{
    public Ejercicio9_BucleAnidados()
    {
        InitializeComponent();
        
        
    }
    
    private void Ejercicio9_BucleAnidados_Load(object sender, EventArgs e)
    {
        
        for (int i = 0; i <= 10; i++)
        {
            for (int j = 0; j <= 10; j++)
            {
                listBox.Items.Add(i + " x " + j + " = " + (i * j));
            }

            listBox.Items.Add("\n");
        }
        
        // throw new System.NotImplementedException();
    }
}