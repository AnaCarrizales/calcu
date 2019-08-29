namespace calculadora
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
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnpto = new System.Windows.Forms.Button();
            this.btnmenos = new System.Windows.Forms.Button();
            this.btnmas = new System.Windows.Forms.Button();
            this.btnporcentaje = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pantalla
            // 
            this.Pantalla.Location = new System.Drawing.Point(12, 23);
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.ReadOnly = true;
            this.Pantalla.Size = new System.Drawing.Size(198, 20);
            this.Pantalla.TabIndex = 0;
            this.Pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Pantalla.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(12, 54);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(45, 39);
            this.btnlimpiar.TabIndex = 1;
            this.btnlimpiar.Text = "CE";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.Btnlimpiar_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 99);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(45, 39);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 144);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(45, 39);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 189);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(45, 39);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(12, 234);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(96, 39);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(113, 54);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(45, 39);
            this.btndiv.TabIndex = 2;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.Btndiv_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(63, 99);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(45, 39);
            this.btn8.TabIndex = 3;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(63, 144);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(45, 39);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(63, 189);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(45, 39);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // btnmult
            // 
            this.btnmult.Location = new System.Drawing.Point(165, 99);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(45, 39);
            this.btnmult.TabIndex = 2;
            this.btnmult.Text = "*";
            this.btnmult.UseVisualStyleBackColor = true;
            this.btnmult.Click += new System.EventHandler(this.Btnmult_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(114, 99);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(45, 39);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(114, 144);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(45, 39);
            this.btn6.TabIndex = 4;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(114, 189);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(45, 39);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // btnpto
            // 
            this.btnpto.Location = new System.Drawing.Point(114, 234);
            this.btnpto.Name = "btnpto";
            this.btnpto.Size = new System.Drawing.Size(45, 39);
            this.btnpto.TabIndex = 6;
            this.btnpto.Text = ".";
            this.btnpto.UseVisualStyleBackColor = true;
            this.btnpto.Click += new System.EventHandler(this.Btnpto_Click);
            // 
            // btnmenos
            // 
            this.btnmenos.Location = new System.Drawing.Point(165, 54);
            this.btnmenos.Name = "btnmenos";
            this.btnmenos.Size = new System.Drawing.Size(45, 39);
            this.btnmenos.TabIndex = 2;
            this.btnmenos.Text = "-";
            this.btnmenos.UseVisualStyleBackColor = true;
            this.btnmenos.Click += new System.EventHandler(this.Btnmenos_Click);
            // 
            // btnmas
            // 
            this.btnmas.Location = new System.Drawing.Point(165, 144);
            this.btnmas.Name = "btnmas";
            this.btnmas.Size = new System.Drawing.Size(45, 39);
            this.btnmas.TabIndex = 3;
            this.btnmas.Text = "+";
            this.btnmas.UseVisualStyleBackColor = true;
            this.btnmas.Click += new System.EventHandler(this.Btnmas_Click);
            // 
            // btnporcentaje
            // 
            this.btnporcentaje.Location = new System.Drawing.Point(165, 189);
            this.btnporcentaje.Name = "btnporcentaje";
            this.btnporcentaje.Size = new System.Drawing.Size(45, 39);
            this.btnporcentaje.TabIndex = 4;
            this.btnporcentaje.Text = "%";
            this.btnporcentaje.UseVisualStyleBackColor = true;
            this.btnporcentaje.Click += new System.EventHandler(this.Btnporcentaje_Click);
            // 
            // btnigual
            // 
            this.btnigual.Location = new System.Drawing.Point(165, 234);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(45, 39);
            this.btnigual.TabIndex = 6;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.Btnigual_Click);
            // 
            // BtnC
            // 
            this.BtnC.Location = new System.Drawing.Point(63, 54);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(45, 39);
            this.BtnC.TabIndex = 7;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 300);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btnpto);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnporcentaje);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnmas);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnmenos);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnmult);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.Pantalla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pantalla;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnpto;
        private System.Windows.Forms.Button btnmenos;
        private System.Windows.Forms.Button btnmas;
        private System.Windows.Forms.Button btnporcentaje;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button BtnC;
    }
}

