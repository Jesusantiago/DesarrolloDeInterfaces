using System.ComponentModel;

namespace WinFormsApp2;

partial class Ejercicio6_clase_bucleFor
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
        label1 = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(56, 22);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(180, 19);
        label1.TabIndex = 0;
        label1.Text = "Ingresa un número";
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(23, 59);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(236, 23);
        textBox1.TabIndex = 1;
        // 
        // Ejercicio6_clase_bucleFor
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(283, 450);
        Controls.Add(textBox1);
        Controls.Add(label1);
        Text = "Ejercicio6_clase_bucleFor";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;

    #endregion
}