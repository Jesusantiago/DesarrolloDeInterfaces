namespace WinFormsApp2;

public partial class Ejercicio10_CalcularLaMedia : Form
{
    public Ejercicio10_CalcularLaMedia()
    {
        InitializeComponent();
    }

    private void btn_Click(object sender, EventArgs e)
    {
        int user1 = int.Parse(txt1.Text);
        int user2 = int.Parse(txt2.Text);
        int user3 = int.Parse(txt3.Text);
        
        int media = (user1 + user2 + user3) / 3;
        
        MessageBox.Show("La media del alumno es: " + media);
        
        // throw new System.NotImplementedException();
    }
}