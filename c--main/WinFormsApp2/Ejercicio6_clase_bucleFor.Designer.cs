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
        lbl_txt = new System.Windows.Forms.Label();
        txtBox = new System.Windows.Forms.TextBox();
        btn = new System.Windows.Forms.Button();
        listBox = new System.Windows.Forms.ListBox();
        SuspendLayout();
        // 
        // lbl_txt
        // 
        lbl_txt.Location = new System.Drawing.Point(87, 23);
        lbl_txt.Name = "lbl_txt";
        lbl_txt.Size = new System.Drawing.Size(108, 19);
        lbl_txt.TabIndex = 0;
        lbl_txt.Text = "Ingresa un número";
        // 
        // txtBox
        // 
        txtBox.Location = new System.Drawing.Point(23, 59);
        txtBox.Name = "txtBox";
        txtBox.Size = new System.Drawing.Size(236, 23);
        txtBox.TabIndex = 1;
        // 
        // btn
        // 
        btn.Location = new System.Drawing.Point(85, 102);
        btn.Name = "btn";
        btn.Size = new System.Drawing.Size(109, 22);
        btn.TabIndex = 2;
        btn.Text = "Calcular";
        btn.UseVisualStyleBackColor = true;
        btn.Click += btn_Click;
        // 
        // listBox
        // 
        listBox.FormattingEnabled = true;
        listBox.Location = new System.Drawing.Point(31, 165);
        listBox.Name = "listBox";
        listBox.Size = new System.Drawing.Size(227, 244);
        listBox.TabIndex = 3;
        // 
        // Ejercicio6_clase_bucleFor
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(283, 450);
        Controls.Add(listBox);
        Controls.Add(btn);
        Controls.Add(txtBox);
        Controls.Add(lbl_txt);
        Text = "Ejercicio6_clase_bucleFor";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btn;
    private System.Windows.Forms.ListBox listBox;

    private System.Windows.Forms.Label lbl_txt;
    private System.Windows.Forms.TextBox txtBox;

    #endregion
}