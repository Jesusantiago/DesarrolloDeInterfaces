namespace WinFormsApp2;

public partial class Ejercicio3_clase_switch : Form
{
    public Ejercicio3_clase_switch()
    {
        InitializeComponent();
    }

    private void btn_procesar_Click(object sender, EventArgs e)
    {
        int option = int.Parse(lbl_Input.SelectedItem.ToString());
        
        switch (option)
        {
            case 1:
            {
                lbl_Out.Text = "Lunes";
                lbl_Out.Visible = true;
                lbl_Title_Day.Visible = true;
                break;
            }
            case 2:
            {
                lbl_Out.Text = "Martes";
                lbl_Out.Visible = true;
                lbl_Title_Day.Visible = true;
                break;
            }   
            case 3:
            {
                lbl_Out.Text = "Miercoles";
                lbl_Out.Visible = true;
                lbl_Title_Day.Visible = true;
                break;
            }   
            case 4:
            {
                lbl_Out.Text = "Jueves";
                lbl_Out.Visible = true;
                lbl_Title_Day.Visible = true;
                break;
            }   
            case 5:
            {
                lbl_Out.Text = "Viernes";
                lbl_Out.Visible = true;
                lbl_Title_Day.Visible = true;
                break;
            }   case 6:
            {
                lbl_Out.Text = "Sabado";
                lbl_Out.Visible = true;
                lbl_Title_Day.Visible = true;
                break;
            }   case 7:
            {
                lbl_Out.Text = "Domingo";
                lbl_Out.Visible = true;
                lbl_Title_Day.Visible = true;
                break;
            }
            default:
                lbl_Out.Text = "Ha habído un error";
                break;
        }
        
    }
}