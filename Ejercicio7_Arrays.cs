namespace WinFormsApp2;

public partial class Ejercicio7_Arrays : Form
{
    public Ejercicio7_Arrays()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        listBox = new System.Windows.Forms.ListBox();
        SuspendLayout();
        // 
        // listBox
        // 
        listBox.FormattingEnabled = true;
        listBox.Location = new System.Drawing.Point(61, 52);
        listBox.Name = "listBox";
        listBox.Size = new System.Drawing.Size(183, 169);
        listBox.TabIndex = 0;
        // 
        // Ejercicio7_Arrays
        // 
        ClientSize = new System.Drawing.Size(284, 261);
        Controls.Add(listBox);
        ResumeLayout(false);
    }

    private System.Windows.Forms.ListBox listBox;


    private void listBox_SelectedIndexChanged(object sender, EventArgs e)
    {
  
    }
}