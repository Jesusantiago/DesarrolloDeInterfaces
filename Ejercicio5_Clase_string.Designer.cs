using System.ComponentModel;

namespace WinFormsApp2;

partial class Ejercicio5_Clase_string
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
        textName = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        labelValid = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(46, 30);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(186, 33);
        label1.TabIndex = 0;
        label1.Text = "Ingrese su nombre de usuario:";
        label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // textName
        // 
        textName.Location = new System.Drawing.Point(31, 82);
        textName.Name = "textName";
        textName.Size = new System.Drawing.Size(224, 23);
        textName.TabIndex = 1;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(85, 170);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(125, 44);
        button1.TabIndex = 2;
        button1.Text = "btnValid";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // labelValid
        // 
        labelValid.Location = new System.Drawing.Point(45, 417);
        labelValid.Name = "labelValid";
        labelValid.Size = new System.Drawing.Size(209, 26);
        labelValid.TabIndex = 3;
        labelValid.Visible = false;
        // 
        // Ejercicio5_Clase_string
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(282, 450);
        Controls.Add(labelValid);
        Controls.Add(button1);
        Controls.Add(textName);
        Controls.Add(label1);
        Location = new System.Drawing.Point(15, 15);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textName;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label labelValid;

    private System.Windows.Forms.Label label1;

    #endregion
}