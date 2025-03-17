using System.ComponentModel;

namespace WinFormsApp2;

partial class Ejercicio9_BucleAnidados
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

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
        listBox.Location = new System.Drawing.Point(31, 26);
        listBox.Name = "listBox";
        listBox.Size = new System.Drawing.Size(586, 379);
        listBox.TabIndex = 0;
        listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
        // 
        // Ejercicio9_BucleAnidados
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(660, 440);
        Controls.Add(listBox);
        Text = "Ejercicio9_BucleAnidados";
        Load += Ejercicio9_BucleAnidados_Load;
        ResumeLayout(false);
    }

    private System.Windows.Forms.ListBox listBox;

    #endregion
}