namespace WinFormsApp2;

public class Telefono
{
    private string marca;
    private string modelo;
    private int precio;

    public Telefono(string marca, string modelo, int precio)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.precio = precio;
    }

    public decimal aplicarDescuento(decimal porcentaje)
    {
        return precio * porcentaje / 100;
    }

    public void setMarca(string marca)
    {
        this.marca = marca;
    }

    public void setModelo(string modelo)
    {
        this.modelo = modelo;
    }

    public void setPrecio(int precio)
    {
        this.precio = precio;
    }

    public string getMarca()
    {
        return this.marca;
    }

    public string getModelo()
    {
        return this.modelo;
    }

    public int getPrecio()
    {
        return this.precio;
    }
    
    
    
    
}