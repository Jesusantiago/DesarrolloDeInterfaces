using System.Diagnostics;

namespace proyectoFinal;

public partial class ProyectoFinal : Form
{
    private double numero1 = 0;
    private double numero2 = 0;
    private string operador = "";
    private bool operacionEnProgreso = false;
    private double resultado = 0;
    
    public ProyectoFinal()
    {
        InitializeComponent(); 
    }

    private void ProyectoFinal_Load(object sender, EventArgs e)
    {
        
        int resultado = int.Parse(result.Text);
        int unoUser = int.Parse(uno.Text);
        
        Console.WriteLine(result);
        
        throw new System.NotImplementedException();
    }

    private void btnOperador_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        operador = btn.Text;
        numero1 = Convert.ToDouble(result.Text);
        result.Clear();
        operacionEnProgreso = true;
    }

    private void btnIgual_Click(object sender, EventArgs e)
    {
        numero2 = Convert.ToDouble(result.Text);
    
        
        switch (operador)
        {
            case "+":
                resultado = numero1 + numero2;
                break;
            case "-":
                resultado = numero1 - numero2;
                break;
            case "*":
                resultado = numero1 * numero2;
                break;
            case "/":
                if (numero2 != 0)
                    resultado = numero1 / numero2;
                else
                    MessageBox.Show("Error: No se puede dividir entre cero.");
                
                break;
        }

        result.Text = resultado.ToString();
        operacionEnProgreso = false;

    }


    
    private void btnNumero_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;  
        string numero = btn.Text;    
        result.Text += numero; 
        Console.WriteLine(result.Text);
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        resultado = 0;
        result.Clear();
    }

    private void btnClearOnlyOne_Click(object sender, EventArgs e)
    {
        if (result.Text.Length > 0)
        {
            result.Text = result.Text.Remove((result.Text.Length - 1));
        }
    }
}