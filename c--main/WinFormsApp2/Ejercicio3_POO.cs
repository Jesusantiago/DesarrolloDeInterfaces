namespace WinFormsApp2;

public partial class Ejercicio3_POO : Form
{
    
    private Telefono tf;
    public Ejercicio3_POO()
    {
        InitializeComponent();
    }

    private void btnInf_Click(object sender, EventArgs e)
    {
        string marca = txtMarca.Text;
        string modelo = txtModelo.Text;
        // int precio = int.Parse(txtMarca.Text);
        int precio = int.Parse(txtPrecio.Text);
        
       tf = new Telefono(marca, modelo, precio);
        
        MessageBox.Show("El telefono de la marca es: " + tf.getMarca() + " y el modelo es: " +
                        tf.getModelo() + " y el precio es: " + tf.getPrecio());
    }


    private void btnDesc_Click(object sender, EventArgs e)
    {
        decimal desc = Convert.ToDecimal(txtDesc.Text);
        
        decimal nuevoPrecio = tf.aplicarDescuento(desc);
        
        MessageBox.Show("El descuento al precio: " + tf.getPrecio() + " es de: " + nuevoPrecio);
    }
}