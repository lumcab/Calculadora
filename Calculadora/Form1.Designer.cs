﻿namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cajaResultado = new System.Windows.Forms.TextBox();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnModulo = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cajaResultado
            // 
            this.cajaResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaResultado.Location = new System.Drawing.Point(8, 56);
            this.cajaResultado.Name = "cajaResultado";
            this.cajaResultado.ReadOnly = true;
            this.cajaResultado.Size = new System.Drawing.Size(253, 31);
            this.cajaResultado.TabIndex = 0;
            this.cajaResultado.Text = "0";
            this.cajaResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Location = new System.Drawing.Point(17, 13);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(0, 13);
            this.lblHistorial.TabIndex = 1;
            // 
            // btnCero
            // 
            this.btnCero.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCero.Location = new System.Drawing.Point(72, 301);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(59, 47);
            this.btnCero.TabIndex = 3;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = true;
            this.btnCero.UseWaitCursor = true;
            this.btnCero.Click += new System.EventHandler(this.btnCero_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.Location = new System.Drawing.Point(7, 301);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(59, 47);
            this.btnPunto.TabIndex = 4;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.UseWaitCursor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(137, 301);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(59, 47);
            this.btnIgual.TabIndex = 5;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.UseWaitCursor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(201, 301);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(59, 47);
            this.btnSuma.TabIndex = 9;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.UseWaitCursor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnTres
            // 
            this.btnTres.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.Location = new System.Drawing.Point(137, 248);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(59, 47);
            this.btnTres.TabIndex = 8;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.UseWaitCursor = true;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnDos
            // 
            this.btnDos.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDos.Location = new System.Drawing.Point(72, 248);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(59, 47);
            this.btnDos.TabIndex = 7;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.UseWaitCursor = true;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btnUno
            // 
            this.btnUno.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUno.Location = new System.Drawing.Point(7, 248);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(59, 47);
            this.btnUno.TabIndex = 6;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.UseWaitCursor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(201, 248);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(59, 47);
            this.btnResta.TabIndex = 13;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.UseWaitCursor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.Location = new System.Drawing.Point(137, 195);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(59, 47);
            this.btnSeis.TabIndex = 12;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.UseWaitCursor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.Location = new System.Drawing.Point(72, 195);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(59, 47);
            this.btnCinco.TabIndex = 11;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.UseWaitCursor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuatro.Location = new System.Drawing.Point(7, 195);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(59, 47);
            this.btnCuatro.TabIndex = 10;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.UseWaitCursor = true;
            this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.Location = new System.Drawing.Point(201, 198);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(59, 47);
            this.btnMultiplicacion.TabIndex = 17;
            this.btnMultiplicacion.Text = "x";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.UseWaitCursor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueve.Location = new System.Drawing.Point(137, 145);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(59, 47);
            this.btnNueve.TabIndex = 16;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.UseWaitCursor = true;
            this.btnNueve.Click += new System.EventHandler(this.btnNueve_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcho.Location = new System.Drawing.Point(72, 145);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(59, 47);
            this.btnOcho.TabIndex = 15;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.UseWaitCursor = true;
            this.btnOcho.Click += new System.EventHandler(this.btnOcho_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiete.Location = new System.Drawing.Point(7, 145);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(59, 47);
            this.btnSiete.TabIndex = 14;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.UseWaitCursor = true;
            this.btnSiete.Click += new System.EventHandler(this.btnSiete_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(202, 145);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(59, 47);
            this.btnDivision.TabIndex = 21;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.UseWaitCursor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnModulo
            // 
            this.btnModulo.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModulo.Location = new System.Drawing.Point(203, 93);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(59, 47);
            this.btnModulo.TabIndex = 20;
            this.btnModulo.Text = "%";
            this.btnModulo.UseVisualStyleBackColor = true;
            this.btnModulo.UseWaitCursor = true;
            this.btnModulo.Click += new System.EventHandler(this.btnModulo_Click);
            // 
            // btnPotencia
            // 
            this.btnPotencia.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotencia.Location = new System.Drawing.Point(137, 93);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(59, 47);
            this.btnPotencia.TabIndex = 19;
            this.btnPotencia.Text = "^";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.UseWaitCursor = true;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(8, 93);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(59, 47);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "C";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.UseWaitCursor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(72, 92);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(59, 47);
            this.btnBorrar.TabIndex = 22;
            this.btnBorrar.Text = "<";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.UseWaitCursor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 357);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnModulo);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.cajaResultado);
            this.Name = "Form1";
            this.Text = " Calculadora V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cajaResultado;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBorrar;
    }
}

