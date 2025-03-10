using System.ComponentModel;

namespace WinFormsApp2;

partial class Ejercicio8_While
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
        txtBox = new System.Windows.Forms.TextBox();
        Ingresar = new System.Windows.Forms.Button();
        listBox = new System.Windows.Forms.ListBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(65, 24);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(125, 21);
        label1.TabIndex = 0;
        label1.Text = "Ingrese un Número";
        // 
        // txtBox
        // 
        txtBox.Location = new System.Drawing.Point(25, 72);
        txtBox.Name = "txtBox";
        txtBox.Size = new System.Drawing.Size(271, 23);
        txtBox.TabIndex = 1;
        // 
        // Ingresar
        // 
        Ingresar.Location = new System.Drawing.Point(84, 124);
        Ingresar.Name = "Ingresar";
        Ingresar.Size = new System.Drawing.Size(127, 34);
        Ingresar.TabIndex = 2;
        Ingresar.Text = "btn";
        Ingresar.UseVisualStyleBackColor = true;
        Ingresar.Click += Ingresar_Click;
        // 
        // listBox
        // 
        listBox.FormattingEnabled = true;
        listBox.Location = new System.Drawing.Point(30, 198);
        listBox.Name = "listBox";
        listBox.Size = new System.Drawing.Size(265, 184);
        listBox.TabIndex = 3;
        // 
        // Ejercicio8_While
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(312, 427);
        Controls.Add(listBox);
        Controls.Add(Ingresar);
        Controls.Add(txtBox);
        Controls.Add(label1);
        Text = "Ejercicio8_While";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtBox;
    private System.Windows.Forms.Button Ingresar;
    private System.Windows.Forms.ListBox listBox;

    #endregion
}