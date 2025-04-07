using System.ComponentModel;

namespace WinFormsApp2;

partial class Ejercicio10_CalcularLaMedia
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
        lbl1 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        txt1 = new System.Windows.Forms.TextBox();
        txt3 = new System.Windows.Forms.TextBox();
        txt2 = new System.Windows.Forms.TextBox();
        btn = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // lbl1
        // 
        lbl1.Location = new System.Drawing.Point(134, 39);
        lbl1.Name = "lbl1";
        lbl1.Size = new System.Drawing.Size(88, 17);
        lbl1.TabIndex = 0;
        lbl1.Text = "Indicar Nota 1";
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(134, 120);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(88, 17);
        label1.TabIndex = 1;
        label1.Text = "Indicar Nota 2";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(134, 214);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(88, 17);
        label2.TabIndex = 2;
        label2.Text = "Indicar Nota 3";
        // 
        // txt1
        // 
        txt1.Location = new System.Drawing.Point(96, 71);
        txt1.Name = "txt1";
        txt1.Size = new System.Drawing.Size(158, 23);
        txt1.TabIndex = 3;
        // 
        // txt3
        // 
        txt3.Location = new System.Drawing.Point(96, 234);
        txt3.Name = "txt3";
        txt3.Size = new System.Drawing.Size(158, 23);
        txt3.TabIndex = 4;
        // 
        // txt2
        // 
        txt2.Location = new System.Drawing.Point(96, 163);
        txt2.Name = "txt2";
        txt2.Size = new System.Drawing.Size(158, 23);
        txt2.TabIndex = 5;
        // 
        // btn
        // 
        btn.Location = new System.Drawing.Point(40, 296);
        btn.Name = "btn";
        btn.Size = new System.Drawing.Size(286, 38);
        btn.TabIndex = 6;
        btn.Text = "Calcular Media";
        btn.UseVisualStyleBackColor = true;
        btn.Click += btn_Click;
        // 
        // Ejercicio10_CalcularLaMedia
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(373, 499);
        Controls.Add(btn);
        Controls.Add(txt2);
        Controls.Add(txt3);
        Controls.Add(txt1);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(lbl1);
        Text = "Ejercicio10_CalcularLaMedia";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label lbl1;
    private System.Windows.Forms.TextBox txt1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txt3;
    private System.Windows.Forms.TextBox txt2;
    private System.Windows.Forms.Button btn;

    #endregion
}