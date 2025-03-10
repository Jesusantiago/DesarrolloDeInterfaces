using System.ComponentModel;

namespace WinFormsApp2;

partial class Ejercicio3_clase_switch
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
        title = new System.Windows.Forms.Label();
        lbl_Title_Day = new System.Windows.Forms.Label();
        lbl_Out = new System.Windows.Forms.TextBox();
        btn_procesar = new System.Windows.Forms.Button();
        lbl_Input = new System.Windows.Forms.ComboBox();
        SuspendLayout();
        // 
        // title
        // 
        title.ForeColor = System.Drawing.Color.Gainsboro;
        title.Location = new System.Drawing.Point(-8, 39);
        title.Name = "title";
        title.Size = new System.Drawing.Size(287, 26);
        title.TabIndex = 0;
        title.Text = "Selecciona un número:";
        title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // lbl_Title_Day
        // 
        lbl_Title_Day.Enabled = false;
        lbl_Title_Day.Font = new System.Drawing.Font("Segoe UI", 9F);
        lbl_Title_Day.ForeColor = System.Drawing.Color.LightGray;
        lbl_Title_Day.Location = new System.Drawing.Point(-8, 119);
        lbl_Title_Day.Name = "lbl_Title_Day";
        lbl_Title_Day.Size = new System.Drawing.Size(287, 20);
        lbl_Title_Day.TabIndex = 2;
        lbl_Title_Day.Text = "Día seleccionado:";
        lbl_Title_Day.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        lbl_Title_Day.Visible = false;
        // 
        // lbl_Out
        // 
        lbl_Out.BackColor = System.Drawing.Color.Bisque;
        lbl_Out.Enabled = false;
        lbl_Out.Location = new System.Drawing.Point(71, 168);
        lbl_Out.Name = "lbl_Out";
        lbl_Out.Size = new System.Drawing.Size(132, 23);
        lbl_Out.TabIndex = 3;
        lbl_Out.Visible = false;
        // 
        // btn_procesar
        // 
        btn_procesar.Location = new System.Drawing.Point(33, 336);
        btn_procesar.Name = "btn_procesar";
        btn_procesar.Size = new System.Drawing.Size(203, 35);
        btn_procesar.TabIndex = 4;
        btn_procesar.Text = "Procesar";
        btn_procesar.UseVisualStyleBackColor = true;
        btn_procesar.Click += btn_procesar_Click;
        // 
        // lbl_Input
        // 
        lbl_Input.BackColor = System.Drawing.Color.Bisque;
        lbl_Input.FormattingEnabled = true;
        lbl_Input.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
        lbl_Input.Location = new System.Drawing.Point(71, 68);
        lbl_Input.Name = "lbl_Input";
        lbl_Input.Size = new System.Drawing.Size(132, 23);
        lbl_Input.TabIndex = 5;
        // 
        // Ejercicio3_clase_switch
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.OliveDrab;
        ClientSize = new System.Drawing.Size(271, 419);
        Controls.Add(lbl_Input);
        Controls.Add(btn_procesar);
        Controls.Add(lbl_Out);
        Controls.Add(lbl_Title_Day);
        Controls.Add(title);
        Text = "Ejercicio3_clase_switch";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ComboBox lbl_Input;

    private System.Windows.Forms.TextBox lbl_Out;
    private System.Windows.Forms.Button btn_procesar;

    private System.Windows.Forms.Label lbl_Title_Day;

    private System.Windows.Forms.Label title;

    #endregion
}