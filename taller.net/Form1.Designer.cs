namespace taller.net
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnpromedionotas = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnvolumen = new System.Windows.Forms.Button();
            this.btnedadaños = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btntriangulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "calculando masa corp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnpromedionotas
            // 
            this.btnpromedionotas.Location = new System.Drawing.Point(26, 96);
            this.btnpromedionotas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnpromedionotas.Name = "btnpromedionotas";
            this.btnpromedionotas.Size = new System.Drawing.Size(272, 31);
            this.btnpromedionotas.TabIndex = 1;
            this.btnpromedionotas.Text = "promedio notas";
            this.btnpromedionotas.UseVisualStyleBackColor = true;
            this.btnpromedionotas.Click += new System.EventHandler(this.btnpromedionotas_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(26, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 33);
            this.button2.TabIndex = 0;
            this.button2.Text = "Raizcuadrada";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnvolumen
            // 
            this.btnvolumen.Location = new System.Drawing.Point(26, 134);
            this.btnvolumen.Name = "btnvolumen";
            this.btnvolumen.Size = new System.Drawing.Size(272, 32);
            this.btnvolumen.TabIndex = 3;
            this.btnvolumen.Text = "Volumen";
            this.btnvolumen.UseVisualStyleBackColor = true;
            this.btnvolumen.Click += new System.EventHandler(this.btnvolumen_Click);
            // 
            // btnedadaños
            // 
            this.btnedadaños.Location = new System.Drawing.Point(26, 172);
            this.btnedadaños.Name = "btnedadaños";
            this.btnedadaños.Size = new System.Drawing.Size(272, 36);
            this.btnedadaños.TabIndex = 4;
            this.btnedadaños.Text = "edad en segundos";
            this.btnedadaños.UseVisualStyleBackColor = true;
            this.btnedadaños.Click += new System.EventHandler(this.btnedadaños_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(272, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Etapas de la vida";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(389, 64);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(91, 45);
            this.btncerrar.TabIndex = 6;
            this.btncerrar.Text = "cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btntriangulo
            // 
            this.btntriangulo.Location = new System.Drawing.Point(26, 255);
            this.btntriangulo.Name = "btntriangulo";
            this.btntriangulo.Size = new System.Drawing.Size(272, 33);
            this.btntriangulo.TabIndex = 7;
            this.btntriangulo.Text = "area triangulo";
            this.btntriangulo.UseVisualStyleBackColor = true;
            this.btntriangulo.Click += new System.EventHandler(this.btntriangulo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 346);
            this.Controls.Add(this.btntriangulo);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnedadaños);
            this.Controls.Add(this.btnvolumen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnpromedionotas);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnpromedionotas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnvolumen;
        private System.Windows.Forms.Button btnedadaños;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btntriangulo;
    }
}

