using System.ComponentModel;

namespace WinFormsApp2;

partial class Ejercicio3_POO
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
        txtMarca = new System.Windows.Forms.TextBox();
        txtModelo = new System.Windows.Forms.TextBox();
        txtPrecio = new System.Windows.Forms.TextBox();
        btnInf = new System.Windows.Forms.Button();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        btnDesc = new System.Windows.Forms.Button();
        label6 = new System.Windows.Forms.Label();
        txtDesc = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(0, 7);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(494, 54);
        label1.TabIndex = 0;
        label1.Text = "Ejercicio de Class Telefono";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtMarca
        // 
        txtMarca.Location = new System.Drawing.Point(265, 115);
        txtMarca.Name = "txtMarca";
        txtMarca.Size = new System.Drawing.Size(213, 23);
        txtMarca.TabIndex = 1;
        // 
        // txtModelo
        // 
        txtModelo.Location = new System.Drawing.Point(265, 231);
        txtModelo.Name = "txtModelo";
        txtModelo.Size = new System.Drawing.Size(213, 23);
        txtModelo.TabIndex = 2;
        // 
        // txtPrecio
        // 
        txtPrecio.Location = new System.Drawing.Point(265, 354);
        txtPrecio.Name = "txtPrecio";
        txtPrecio.Size = new System.Drawing.Size(213, 23);
        txtPrecio.TabIndex = 3;
        // 
        // btnInf
        // 
        btnInf.Location = new System.Drawing.Point(321, 428);
        btnInf.Name = "btnInf";
        btnInf.Size = new System.Drawing.Size(128, 45);
        btnInf.TabIndex = 4;
        btnInf.Text = "Mostrar Información";
        btnInf.UseVisualStyleBackColor = true;
        btnInf.Click += btnInf_Click;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(0, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 11;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(311, 178);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(147, 20);
        label3.TabIndex = 6;
        label3.Text = "Modelo";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(311, 310);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(147, 20);
        label4.TabIndex = 7;
        label4.Text = "Precio";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(32, 83);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(147, 20);
        label5.TabIndex = 8;
        label5.Text = "Descuento";
        // 
        // btnDesc
        // 
        btnDesc.Location = new System.Drawing.Point(51, 178);
        btnDesc.Name = "btnDesc";
        btnDesc.Size = new System.Drawing.Size(128, 45);
        btnDesc.TabIndex = 10;
        btnDesc.Text = "Aplicar Descuento";
        btnDesc.UseVisualStyleBackColor = true;
        btnDesc.Click += btnDesc_Click;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(302, 61);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(147, 20);
        label6.TabIndex = 12;
        label6.Text = "Marca";
        // 
        // txtDesc
        // 
        txtDesc.Location = new System.Drawing.Point(32, 115);
        txtDesc.Name = "txtDesc";
        txtDesc.Size = new System.Drawing.Size(213, 23);
        txtDesc.TabIndex = 13;
        // 
        // Ejercicio3_POO
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(497, 523);
        Controls.Add(txtDesc);
        Controls.Add(label6);
        Controls.Add(btnDesc);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(btnInf);
        Controls.Add(txtPrecio);
        Controls.Add(txtModelo);
        Controls.Add(txtMarca);
        Controls.Add(label1);
        Text = "Ejercicio3_POO";
        // Load += Ejercicio3_POO_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtDesc;

    private System.Windows.Forms.Button btnDesc;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.TextBox txtMarca;
    private System.Windows.Forms.TextBox txtModelo;
    private System.Windows.Forms.TextBox txtPrecio;
    private System.Windows.Forms.Button btnInf;

    private System.Windows.Forms.Label label1;

    #endregion
}