using System.ComponentModel;

namespace WinFormsApp2;

partial class Ejercicio4_Edad
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
        txtName = new System.Windows.Forms.TextBox();
        text_Age = new System.Windows.Forms.Label();
        txtAge = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        txt_Name = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(0, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 5;
        // 
        // txtName
        // 
        txtName.Location = new System.Drawing.Point(35, 54);
        txtName.Name = "txtName";
        txtName.Size = new System.Drawing.Size(203, 23);
        txtName.TabIndex = 1;
        // 
        // text_Age
        // 
        text_Age.Location = new System.Drawing.Point(0, 95);
        text_Age.Name = "text_Age";
        text_Age.Size = new System.Drawing.Size(289, 35);
        text_Age.TabIndex = 2;
        text_Age.Text = "Edad:";
        text_Age.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // txtAge
        // 
        txtAge.Location = new System.Drawing.Point(35, 133);
        txtAge.Name = "txtAge";
        txtAge.Size = new System.Drawing.Size(203, 23);
        txtAge.TabIndex = 3;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(57, 250);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(162, 46);
        button1.TabIndex = 4;
        button1.Text = "btn";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // txt_Name
        // 
        txt_Name.Location = new System.Drawing.Point(-8, 10);
        txt_Name.Name = "txt_Name";
        txt_Name.Size = new System.Drawing.Size(290, 23);
        txt_Name.TabIndex = 0;
        txt_Name.Text = "Nombre:";
        txt_Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // Ejercicio4_Edad
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(274, 450);
        Controls.Add(txt_Name);
        Controls.Add(button1);
        Controls.Add(txtAge);
        Controls.Add(text_Age);
        Controls.Add(txtName);
        Controls.Add(label1);
        Text = "Ejercicio4_Edad";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label txt_Name;

    private System.Windows.Forms.TextBox txtAge;
    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label text_Age;

    private System.Windows.Forms.Label label1;

    #endregion
}