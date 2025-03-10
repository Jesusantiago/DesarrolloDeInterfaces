namespace WinFormsApp2;

public partial class Ejercicio6_clase_bucleFor : Form
{
    public Ejercicio6_clase_bucleFor()
    {
        InitializeComponent();
    }

    private void btn_Click(object sender, EventArgs e)
    {
        int user = int.Parse(txtBox.Text);


        for (int i = 1; i <= 10; i++)
        {
            // listBox.Items.Add(i.ToString(user + " X " + i + " = " + (user * i)) );
            listBox.Items.Add(user + " X " + i + " = " + (user * i)) ;

        }
        
    }
}
