namespace imc
{
    partial class CalculadorIMC
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculadorIMC));
            this.lblIMC = new System.Windows.Forms.Label();
            this.txtPs = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.iblimc2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.BackColor = System.Drawing.Color.Transparent;
            this.lblIMC.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMC.Location = new System.Drawing.Point(52, 35);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(156, 21);
            this.lblIMC.TabIndex = 0;
            this.lblIMC.Text = "Calcule seu IMC";
            this.lblIMC.Click += new System.EventHandler(this.lblIMC_Click);
            // 
            // txtPs
            // 
            this.txtPs.AutoSize = true;
            this.txtPs.BackColor = System.Drawing.Color.Transparent;
            this.txtPs.Location = new System.Drawing.Point(12, 77);
            this.txtPs.Name = "txtPs";
            this.txtPs.Size = new System.Drawing.Size(37, 13);
            this.txtPs.TabIndex = 1;
            this.txtPs.Text = "Peso: ";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.BackColor = System.Drawing.Color.Transparent;
            this.lblAltura.Location = new System.Drawing.Point(9, 116);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(40, 13);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Altura: ";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(56, 74);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(259, 20);
            this.txtPeso.TabIndex = 3;
            this.txtPeso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(56, 113);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(259, 20);
            this.txtAltura.TabIndex = 4;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.Transparent;
            this.BtnCalcular.Location = new System.Drawing.Point(56, 151);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(259, 32);
            this.BtnCalcular.TabIndex = 5;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // iblimc2
            // 
            this.iblimc2.AutoSize = true;
            this.iblimc2.BackColor = System.Drawing.Color.Transparent;
            this.iblimc2.Location = new System.Drawing.Point(12, 202);
            this.iblimc2.Name = "iblimc2";
            this.iblimc2.Size = new System.Drawing.Size(29, 13);
            this.iblimc2.TabIndex = 6;
            this.iblimc2.Text = "IMC:";
            this.iblimc2.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 199);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 20);
            this.textBox1.TabIndex = 7;
            // 
            // CalculadorIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::imc.Properties.Resources.FKN7f6WXsAcZcw0;
            this.ClientSize = new System.Drawing.Size(650, 515);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.iblimc2);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtPs);
            this.Controls.Add(this.lblIMC);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculadorIMC";
            this.Text = " ";
            this.Load += new System.EventHandler(this.CalculadorIMC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.Label txtPs;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label iblimc2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

