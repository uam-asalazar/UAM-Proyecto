namespace PL_Calculadora
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.grpEntrada = new System.Windows.Forms.GroupBox();
            this.grpCalculo = new System.Windows.Forms.GroupBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtMayor = new System.Windows.Forms.TextBox();
            this.lblMayor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.lblMenor = new System.Windows.Forms.Label();
            this.txtMenor = new System.Windows.Forms.TextBox();
            this.grpEntrada.SuspendLayout();
            this.grpCalculo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(519, 307);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 37);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(250, 47);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 26);
            this.txtNum1.TabIndex = 1;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            this.txtNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum1_KeyPress);
            this.txtNum1.Leave += new System.EventHandler(this.txtNum1_Leave);
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Sylfaen", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(6, 49);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(247, 22);
            this.lblNum1.TabIndex = 2;
            this.lblNum1.Text = "Digite el primero Número ---> ";
            this.lblNum1.Click += new System.EventHandler(this.lblNum1_Click);
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Sylfaen", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(6, 102);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(247, 22);
            this.lblNum2.TabIndex = 4;
            this.lblNum2.Text = "Digite el segundo Número ---> ";
            this.lblNum2.Click += new System.EventHandler(this.lblNum2_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(250, 102);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 26);
            this.txtNum2.TabIndex = 3;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
            this.txtNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum2_KeyPress);
            this.txtNum2.Leave += new System.EventHandler(this.txtNum2_Leave);
            // 
            // grpEntrada
            // 
            this.grpEntrada.Controls.Add(this.txtNum1);
            this.grpEntrada.Controls.Add(this.lblNum2);
            this.grpEntrada.Controls.Add(this.lblNum1);
            this.grpEntrada.Controls.Add(this.txtNum2);
            this.grpEntrada.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEntrada.Location = new System.Drawing.Point(30, 26);
            this.grpEntrada.Name = "grpEntrada";
            this.grpEntrada.Size = new System.Drawing.Size(373, 146);
            this.grpEntrada.TabIndex = 6;
            this.grpEntrada.TabStop = false;
            this.grpEntrada.Text = "Valores de Entrada";
            // 
            // grpCalculo
            // 
            this.grpCalculo.Controls.Add(this.btnSuma);
            this.grpCalculo.Controls.Add(this.btnDivision);
            this.grpCalculo.Controls.Add(this.btnMultiplicacion);
            this.grpCalculo.Controls.Add(this.btnResta);
            this.grpCalculo.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCalculo.Location = new System.Drawing.Point(30, 187);
            this.grpCalculo.Name = "grpCalculo";
            this.grpCalculo.Size = new System.Drawing.Size(373, 121);
            this.grpCalculo.TabIndex = 7;
            this.grpCalculo.TabStop = false;
            this.grpCalculo.Text = "Operadores de cálculo";
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.ForeColor = System.Drawing.Color.Red;
            this.btnSuma.Location = new System.Drawing.Point(27, 34);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(71, 68);
            this.btnSuma.TabIndex = 5;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.Color.Blue;
            this.btnDivision.Location = new System.Drawing.Point(279, 34);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(71, 68);
            this.btnDivision.TabIndex = 4;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.ForeColor = System.Drawing.Color.Green;
            this.btnMultiplicacion.Location = new System.Drawing.Point(193, 34);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(71, 68);
            this.btnMultiplicacion.TabIndex = 3;
            this.btnMultiplicacion.Text = "*";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.ForeColor = System.Drawing.Color.Yellow;
            this.btnResta.Location = new System.Drawing.Point(113, 34);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(71, 68);
            this.btnResta.TabIndex = 1;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(96, 324);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(111, 21);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(213, 315);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(100, 36);
            this.txtResultado.TabIndex = 9;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // txtMayor
            // 
            this.txtMayor.Location = new System.Drawing.Point(167, 48);
            this.txtMayor.Name = "txtMayor";
            this.txtMayor.ReadOnly = true;
            this.txtMayor.Size = new System.Drawing.Size(100, 26);
            this.txtMayor.TabIndex = 11;
            this.txtMayor.TextChanged += new System.EventHandler(this.txtMayor_TextChanged);
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.Font = new System.Drawing.Font("Sylfaen", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayor.Location = new System.Drawing.Point(32, 48);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(129, 22);
            this.lblMayor.TabIndex = 10;
            this.lblMayor.Text = "Número Mayor:";
            this.lblMayor.Click += new System.EventHandler(this.lblMayor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNumero2);
            this.groupBox1.Controls.Add(this.txtNumero2);
            this.groupBox1.Controls.Add(this.lblNumero1);
            this.groupBox1.Controls.Add(this.txtNumero1);
            this.groupBox1.Controls.Add(this.lblMenor);
            this.groupBox1.Controls.Add(this.txtMenor);
            this.groupBox1.Controls.Add(this.lblMayor);
            this.groupBox1.Controls.Add(this.txtMayor);
            this.groupBox1.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(418, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 261);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Adicional";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Font = new System.Drawing.Font("Sylfaen", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero2.Location = new System.Drawing.Point(32, 206);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(130, 22);
            this.lblNumero2.TabIndex = 16;
            this.lblNumero2.Text = "El Número 2 es:";
            this.lblNumero2.Click += new System.EventHandler(this.lblNumero2_Click);
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(167, 206);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.ReadOnly = true;
            this.txtNumero2.Size = new System.Drawing.Size(100, 26);
            this.txtNumero2.TabIndex = 17;
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Font = new System.Drawing.Font("Sylfaen", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero1.Location = new System.Drawing.Point(32, 157);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(130, 22);
            this.lblNumero1.TabIndex = 14;
            this.lblNumero1.Text = "El Número 1 es:";
            this.lblNumero1.Click += new System.EventHandler(this.lblNumero1_Click);
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(167, 157);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.ReadOnly = true;
            this.txtNumero1.Size = new System.Drawing.Size(100, 26);
            this.txtNumero1.TabIndex = 15;
            this.txtNumero1.TextChanged += new System.EventHandler(this.txtNumero1_TextChanged);
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.Font = new System.Drawing.Font("Sylfaen", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenor.Location = new System.Drawing.Point(32, 109);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(129, 22);
            this.lblMenor.TabIndex = 12;
            this.lblMenor.Text = "Número Menor:";
            this.lblMenor.Click += new System.EventHandler(this.lblMenor_Click);
            // 
            // txtMenor
            // 
            this.txtMenor.Location = new System.Drawing.Point(167, 109);
            this.txtMenor.Name = "txtMenor";
            this.txtMenor.ReadOnly = true;
            this.txtMenor.Size = new System.Drawing.Size(100, 26);
            this.txtMenor.TabIndex = 13;
            this.txtMenor.TextChanged += new System.EventHandler(this.txtMenor_TextChanged);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 363);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.grpCalculo);
            this.Controls.Add(this.grpEntrada);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpEntrada.ResumeLayout(false);
            this.grpEntrada.PerformLayout();
            this.grpCalculo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.GroupBox grpEntrada;
        private System.Windows.Forms.GroupBox grpCalculo;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.TextBox txtMayor;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.TextBox txtMenor;
        private System.Windows.Forms.Button btnSuma;
    }
}