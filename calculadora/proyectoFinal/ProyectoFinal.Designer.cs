using System.ComponentModel;

namespace proyectoFinal;

partial class ProyectoFinal
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
        result = new System.Windows.Forms.TextBox();
        sumar = new System.Windows.Forms.Button();
        resta = new System.Windows.Forms.Button();
        multiplicacion = new System.Windows.Forms.Button();
        dividir = new System.Windows.Forms.Button();
        borrarDigito = new System.Windows.Forms.Button();
        tres = new System.Windows.Forms.Button();
        dos = new System.Windows.Forms.Button();
        uno = new System.Windows.Forms.Button();
        borrarTodo = new System.Windows.Forms.Button();
        seis = new System.Windows.Forms.Button();
        cinco = new System.Windows.Forms.Button();
        cuatro = new System.Windows.Forms.Button();
        button13 = new System.Windows.Forms.Button();
        ocho = new System.Windows.Forms.Button();
        siete = new System.Windows.Forms.Button();
        total = new System.Windows.Forms.Button();
        punto = new System.Windows.Forms.Button();
        cero = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // result
        // 
        result.Location = new System.Drawing.Point(17, 22);
        result.Name = "result";
        result.Size = new System.Drawing.Size(220, 23);
        result.TabIndex = 0;
        // 
        // sumar
        // 
        sumar.Location = new System.Drawing.Point(17, 80);
        sumar.Name = "sumar";
        sumar.Size = new System.Drawing.Size(50, 50);
        sumar.TabIndex = 1;
        sumar.Text = "+";
        sumar.UseVisualStyleBackColor = true;
        sumar.Click += btnOperador_Click;
        // 
        // resta
        // 
        resta.Location = new System.Drawing.Point(73, 80);
        resta.Name = "resta";
        resta.Size = new System.Drawing.Size(50, 50);
        resta.TabIndex = 2;
        resta.Text = "-";
        resta.UseVisualStyleBackColor = true;
        resta.Click += btnOperador_Click;
        // 
        // multiplicacion
        // 
        multiplicacion.Location = new System.Drawing.Point(129, 80);
        multiplicacion.Name = "multiplicacion";
        multiplicacion.Size = new System.Drawing.Size(50, 50);
        multiplicacion.TabIndex = 3;
        multiplicacion.Text = "*";
        multiplicacion.UseVisualStyleBackColor = true;
        multiplicacion.Click += btnOperador_Click;
        // 
        // dividir
        // 
        dividir.Location = new System.Drawing.Point(185, 80);
        dividir.Name = "dividir";
        dividir.Size = new System.Drawing.Size(50, 50);
        dividir.TabIndex = 4;
        dividir.Text = "/";
        dividir.UseVisualStyleBackColor = true;
        dividir.Click += btnOperador_Click;
        // 
        // borrarDigito
        // 
        borrarDigito.Location = new System.Drawing.Point(185, 136);
        borrarDigito.Name = "borrarDigito";
        borrarDigito.Size = new System.Drawing.Size(50, 50);
        borrarDigito.TabIndex = 8;
        borrarDigito.Text = "<--";
        borrarDigito.UseVisualStyleBackColor = true;
        borrarDigito.Click += btnClearOnlyOne_Click;
        // 
        // tres
        // 
        tres.Location = new System.Drawing.Point(129, 136);
        tres.Name = "tres";
        tres.Size = new System.Drawing.Size(50, 50);
        tres.TabIndex = 7;
        tres.Text = "3";
        tres.UseVisualStyleBackColor = true;
        tres.Click += btnNumero_Click;
        // 
        // dos
        // 
        dos.Location = new System.Drawing.Point(73, 136);
        dos.Name = "dos";
        dos.Size = new System.Drawing.Size(50, 50);
        dos.TabIndex = 6;
        dos.Text = "2";
        dos.UseVisualStyleBackColor = true;
        dos.Click += btnNumero_Click;
        // 
        // uno
        // 
        uno.Location = new System.Drawing.Point(17, 136);
        uno.Name = "uno";
        uno.Size = new System.Drawing.Size(50, 50);
        uno.TabIndex = 5;
        uno.Text = "1";
        uno.UseVisualStyleBackColor = true;
        uno.Click += btnNumero_Click;
        // 
        // borrarTodo
        // 
        borrarTodo.Location = new System.Drawing.Point(185, 192);
        borrarTodo.Name = "borrarTodo";
        borrarTodo.Size = new System.Drawing.Size(50, 50);
        borrarTodo.TabIndex = 12;
        borrarTodo.Text = "CE";
        borrarTodo.UseVisualStyleBackColor = true;
        borrarTodo.Click += btnClear_Click; 
        // 
        // seis
        // 
        seis.Location = new System.Drawing.Point(129, 192);
        seis.Name = "seis";
        seis.Size = new System.Drawing.Size(50, 50);
        seis.TabIndex = 11;
        seis.Text = "6";
        seis.UseVisualStyleBackColor = true;
        seis.Click += btnNumero_Click;
        // 
        // cinco
        // 
        cinco.Location = new System.Drawing.Point(73, 192);
        cinco.Name = "cinco";
        cinco.Size = new System.Drawing.Size(50, 50);
        cinco.TabIndex = 10;
        cinco.Text = "5";
        cinco.UseVisualStyleBackColor = true;
        cinco.Click += btnNumero_Click;
        // 
        // cuatro
        // 
        cuatro.Location = new System.Drawing.Point(17, 192);
        cuatro.Name = "cuatro";
        cuatro.Size = new System.Drawing.Size(50, 50);
        cuatro.TabIndex = 9;
        cuatro.Text = "4";
        cuatro.UseVisualStyleBackColor = true;
        cuatro.Click += btnNumero_Click;
        // 
        // button13
        // 
        button13.Location = new System.Drawing.Point(129, 248);
        button13.Name = "button13";
        button13.Size = new System.Drawing.Size(50, 50);
        button13.TabIndex = 15;
        button13.Text = "9";
        button13.UseVisualStyleBackColor = true;
        button13.Click += btnNumero_Click;
        // 
        // ocho
        // 
        ocho.Location = new System.Drawing.Point(73, 248);
        ocho.Name = "ocho";
        ocho.Size = new System.Drawing.Size(50, 50);
        ocho.TabIndex = 14;
        ocho.Text = "8";
        ocho.UseVisualStyleBackColor = true;
        ocho.Click += btnNumero_Click;
        // 
        // siete
        // 
        siete.Location = new System.Drawing.Point(17, 248);
        siete.Name = "siete";
        siete.Size = new System.Drawing.Size(50, 50);
        siete.TabIndex = 13;
        siete.Text = "7";
        siete.UseVisualStyleBackColor = true;
        siete.Click += btnNumero_Click;
        // 
        // total
        // 
        total.Location = new System.Drawing.Point(185, 248);
        total.Name = "total";
        total.Size = new System.Drawing.Size(50, 106);
        total.TabIndex = 20;
        total.Text = "=";
        total.UseVisualStyleBackColor = true;
        total.Click += btnIgual_Click;
        // 
        // punto
        // 
        punto.Location = new System.Drawing.Point(129, 304);
        punto.Name = "punto";
        punto.Size = new System.Drawing.Size(50, 50);
        punto.TabIndex = 19;
        punto.Text = ".";
        punto.UseVisualStyleBackColor = true;
        // 
        // cero
        // 
        cero.Location = new System.Drawing.Point(17, 304);
        cero.Name = "cero";
        cero.Size = new System.Drawing.Size(106, 50);
        cero.TabIndex = 18;
        cero.Text = "0";
        cero.UseVisualStyleBackColor = true;
        cero.Click += btnNumero_Click;
        // 
        // ProyectoFinal
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(252, 381);
        Controls.Add(total);
        Controls.Add(punto);
        Controls.Add(cero);
        Controls.Add(button13);
        Controls.Add(ocho);
        Controls.Add(siete);
        Controls.Add(borrarTodo);
        Controls.Add(seis);
        Controls.Add(cinco);
        Controls.Add(cuatro);
        Controls.Add(borrarDigito);
        Controls.Add(tres);
        Controls.Add(dos);
        Controls.Add(uno);
        Controls.Add(dividir);
        Controls.Add(multiplicacion);
        Controls.Add(resta);
        Controls.Add(sumar);
        Controls.Add(result);
        Text = "ProyectoFinal";
        Load += ProyectoFinal_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox result;
    private System.Windows.Forms.Button borrarDigito;
    private System.Windows.Forms.Button tres;
    private System.Windows.Forms.Button dos;
    private System.Windows.Forms.Button uno;
    private System.Windows.Forms.Button borrarTodo;
    private System.Windows.Forms.Button seis;
    private System.Windows.Forms.Button cinco;
    private System.Windows.Forms.Button cuatro;
    private System.Windows.Forms.Button button13;
    private System.Windows.Forms.Button ocho;
    private System.Windows.Forms.Button siete;
    private System.Windows.Forms.Button total;
    private System.Windows.Forms.Button punto;
    private System.Windows.Forms.Button cero;
    private System.Windows.Forms.Button resta;
    private System.Windows.Forms.Button sumar;
    private System.Windows.Forms.Button multiplicacion;
    private System.Windows.Forms.Button dividir;

    #endregion
}