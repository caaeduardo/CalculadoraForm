namespace WindowsFormsApp2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.BTN7 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BTN1 = new System.Windows.Forms.Button();
            this.BTN4 = new System.Windows.Forms.Button();
            this.BTN0 = new System.Windows.Forms.Button();
            this.BTNPonto = new System.Windows.Forms.Button();
            this.BTN5 = new System.Windows.Forms.Button();
            this.BTN2 = new System.Windows.Forms.Button();
            this.BTN8 = new System.Windows.Forms.Button();
            this.BTNIgual = new System.Windows.Forms.Button();
            this.BTN6 = new System.Windows.Forms.Button();
            this.BTN3 = new System.Windows.Forms.Button();
            this.BTN9 = new System.Windows.Forms.Button();
            this.BTNSubtracao = new System.Windows.Forms.Button();
            this.BTNDivisao = new System.Windows.Forms.Button();
            this.BTNMultiplicacao = new System.Windows.Forms.Button();
            this.BTNRestaurar = new System.Windows.Forms.Button();
            this.BTNSoma = new System.Windows.Forms.Button();
            this.LBLVal1 = new System.Windows.Forms.Label();
            this.LBLVal2 = new System.Windows.Forms.Label();
            this.LBLSinal = new System.Windows.Forms.Label();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BTNPorcentagem = new System.Windows.Forms.Button();
            this.BTNCadu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN7
            // 
            this.BTN7.BackColor = System.Drawing.Color.Aquamarine;
            this.BTN7.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN7.Location = new System.Drawing.Point(23, 205);
            this.BTN7.Name = "BTN7";
            this.BTN7.Size = new System.Drawing.Size(78, 72);
            this.BTN7.TabIndex = 0;
            this.BTN7.Text = "7";
            this.BTN7.UseVisualStyleBackColor = false;
            this.BTN7.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 27);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(591, 171);
            this.textBox2.TabIndex = 2;
            // 
            // BTN1
            // 
            this.BTN1.BackColor = System.Drawing.Color.Aquamarine;
            this.BTN1.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN1.Location = new System.Drawing.Point(23, 361);
            this.BTN1.Name = "BTN1";
            this.BTN1.Size = new System.Drawing.Size(78, 72);
            this.BTN1.TabIndex = 3;
            this.BTN1.Text = "1";
            this.BTN1.UseVisualStyleBackColor = false;
            this.BTN1.Click += new System.EventHandler(this.BTN1_Click);
            // 
            // BTN4
            // 
            this.BTN4.BackColor = System.Drawing.Color.Aquamarine;
            this.BTN4.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN4.Location = new System.Drawing.Point(23, 283);
            this.BTN4.Name = "BTN4";
            this.BTN4.Size = new System.Drawing.Size(78, 72);
            this.BTN4.TabIndex = 4;
            this.BTN4.Text = "4";
            this.BTN4.UseVisualStyleBackColor = false;
            this.BTN4.Click += new System.EventHandler(this.BTN4_Click);
            // 
            // BTN0
            // 
            this.BTN0.BackColor = System.Drawing.Color.Aquamarine;
            this.BTN0.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN0.Location = new System.Drawing.Point(23, 439);
            this.BTN0.Name = "BTN0";
            this.BTN0.Size = new System.Drawing.Size(78, 72);
            this.BTN0.TabIndex = 5;
            this.BTN0.Text = "0";
            this.BTN0.UseVisualStyleBackColor = false;
            this.BTN0.Click += new System.EventHandler(this.BTN0_Click);
            // 
            // BTNPonto
            // 
            this.BTNPonto.BackColor = System.Drawing.Color.Aquamarine;
            this.BTNPonto.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPonto.Location = new System.Drawing.Point(147, 439);
            this.BTNPonto.Name = "BTNPonto";
            this.BTNPonto.Size = new System.Drawing.Size(78, 72);
            this.BTNPonto.TabIndex = 9;
            this.BTNPonto.Text = ".";
            this.BTNPonto.UseVisualStyleBackColor = false;
            // 
            // BTN5
            // 
            this.BTN5.BackColor = System.Drawing.Color.Aquamarine;
            this.BTN5.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN5.Location = new System.Drawing.Point(147, 283);
            this.BTN5.Name = "BTN5";
            this.BTN5.Size = new System.Drawing.Size(78, 72);
            this.BTN5.TabIndex = 8;
            this.BTN5.Text = "5";
            this.BTN5.UseVisualStyleBackColor = false;
            this.BTN5.Click += new System.EventHandler(this.BTN5_Click);
            // 
            // BTN2
            // 
            this.BTN2.BackColor = System.Drawing.Color.Aquamarine;
            this.BTN2.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN2.Location = new System.Drawing.Point(147, 361);
            this.BTN2.Name = "BTN2";
            this.BTN2.Size = new System.Drawing.Size(78, 72);
            this.BTN2.TabIndex = 7;
            this.BTN2.Text = "2";
            this.BTN2.UseVisualStyleBackColor = false;
            this.BTN2.Click += new System.EventHandler(this.BTN2_Click);
            // 
            // BTN8
            // 
            this.BTN8.BackColor = System.Drawing.Color.Aquamarine;
            this.BTN8.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN8.Location = new System.Drawing.Point(147, 205);
            this.BTN8.Name = "BTN8";
            this.BTN8.Size = new System.Drawing.Size(78, 72);
            this.BTN8.TabIndex = 6;
            this.BTN8.Text = "8";
            this.BTN8.UseVisualStyleBackColor = false;
            this.BTN8.Click += new System.EventHandler(this.BTN8_Click);
            // 
            // BTNIgual
            // 
            this.BTNIgual.BackColor = System.Drawing.Color.Aquamarine;
            this.BTNIgual.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNIgual.Location = new System.Drawing.Point(281, 439);
            this.BTNIgual.Name = "BTNIgual";
            this.BTNIgual.Size = new System.Drawing.Size(78, 72);
            this.BTNIgual.TabIndex = 13;
            this.BTNIgual.Text = "=";
            this.BTNIgual.UseVisualStyleBackColor = false;
            this.BTNIgual.Click += new System.EventHandler(this.BTNIgual_Click);
            // 
            // BTN6
            // 
            this.BTN6.BackColor = System.Drawing.Color.Aquamarine;
            this.BTN6.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN6.Location = new System.Drawing.Point(281, 283);
            this.BTN6.Name = "BTN6";
            this.BTN6.Size = new System.Drawing.Size(78, 72);
            this.BTN6.TabIndex = 12;
            this.BTN6.Text = "6";
            this.BTN6.UseVisualStyleBackColor = false;
            this.BTN6.Click += new System.EventHandler(this.BTN6_Click);
            // 
            // BTN3
            // 
            this.BTN3.BackColor = System.Drawing.Color.Aquamarine;
            this.BTN3.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN3.Location = new System.Drawing.Point(281, 361);
            this.BTN3.Name = "BTN3";
            this.BTN3.Size = new System.Drawing.Size(78, 72);
            this.BTN3.TabIndex = 11;
            this.BTN3.Text = "3";
            this.BTN3.UseVisualStyleBackColor = false;
            this.BTN3.Click += new System.EventHandler(this.BTN3_Click);
            // 
            // BTN9
            // 
            this.BTN9.BackColor = System.Drawing.Color.Aquamarine;
            this.BTN9.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN9.Location = new System.Drawing.Point(281, 205);
            this.BTN9.Name = "BTN9";
            this.BTN9.Size = new System.Drawing.Size(78, 72);
            this.BTN9.TabIndex = 10;
            this.BTN9.Text = "9";
            this.BTN9.UseVisualStyleBackColor = false;
            this.BTN9.Click += new System.EventHandler(this.BTN9_Click);
            // 
            // BTNSubtracao
            // 
            this.BTNSubtracao.BackColor = System.Drawing.Color.SlateBlue;
            this.BTNSubtracao.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSubtracao.Location = new System.Drawing.Point(419, 439);
            this.BTNSubtracao.Name = "BTNSubtracao";
            this.BTNSubtracao.Size = new System.Drawing.Size(78, 72);
            this.BTNSubtracao.TabIndex = 17;
            this.BTNSubtracao.Text = "-";
            this.BTNSubtracao.UseVisualStyleBackColor = false;
            this.BTNSubtracao.Click += new System.EventHandler(this.button13_Click);
            // 
            // BTNDivisao
            // 
            this.BTNDivisao.BackColor = System.Drawing.Color.SlateBlue;
            this.BTNDivisao.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDivisao.Location = new System.Drawing.Point(419, 283);
            this.BTNDivisao.Name = "BTNDivisao";
            this.BTNDivisao.Size = new System.Drawing.Size(78, 72);
            this.BTNDivisao.TabIndex = 16;
            this.BTNDivisao.Text = "/";
            this.BTNDivisao.UseVisualStyleBackColor = false;
            this.BTNDivisao.Click += new System.EventHandler(this.BTNDivisao_Click);
            // 
            // BTNMultiplicacao
            // 
            this.BTNMultiplicacao.BackColor = System.Drawing.Color.SlateBlue;
            this.BTNMultiplicacao.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMultiplicacao.Location = new System.Drawing.Point(419, 361);
            this.BTNMultiplicacao.Name = "BTNMultiplicacao";
            this.BTNMultiplicacao.Size = new System.Drawing.Size(78, 72);
            this.BTNMultiplicacao.TabIndex = 15;
            this.BTNMultiplicacao.Text = "x";
            this.BTNMultiplicacao.UseVisualStyleBackColor = false;
            this.BTNMultiplicacao.Click += new System.EventHandler(this.BTNMultiplicacao_Click);
            // 
            // BTNRestaurar
            // 
            this.BTNRestaurar.BackColor = System.Drawing.Color.SlateBlue;
            this.BTNRestaurar.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRestaurar.Location = new System.Drawing.Point(419, 205);
            this.BTNRestaurar.Name = "BTNRestaurar";
            this.BTNRestaurar.Size = new System.Drawing.Size(78, 72);
            this.BTNRestaurar.TabIndex = 14;
            this.BTNRestaurar.Text = "C";
            this.BTNRestaurar.UseVisualStyleBackColor = false;
            this.BTNRestaurar.Click += new System.EventHandler(this.BTNRestaurar_Click);
            // 
            // BTNSoma
            // 
            this.BTNSoma.BackColor = System.Drawing.Color.SkyBlue;
            this.BTNSoma.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSoma.Location = new System.Drawing.Point(539, 205);
            this.BTNSoma.Name = "BTNSoma";
            this.BTNSoma.Size = new System.Drawing.Size(78, 72);
            this.BTNSoma.TabIndex = 18;
            this.BTNSoma.Text = "+";
            this.BTNSoma.UseVisualStyleBackColor = false;
            this.BTNSoma.Click += new System.EventHandler(this.BTNSoma_Click);
            // 
            // LBLVal1
            // 
            this.LBLVal1.AutoSize = true;
            this.LBLVal1.BackColor = System.Drawing.Color.White;
            this.LBLVal1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LBLVal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.LBLVal1.Location = new System.Drawing.Point(413, 52);
            this.LBLVal1.Name = "LBLVal1";
            this.LBLVal1.Size = new System.Drawing.Size(30, 31);
            this.LBLVal1.TabIndex = 20;
            this.LBLVal1.Text = "0";
            this.LBLVal1.Click += new System.EventHandler(this.label2_Click);
            // 
            // LBLVal2
            // 
            this.LBLVal2.AutoSize = true;
            this.LBLVal2.BackColor = System.Drawing.Color.White;
            this.LBLVal2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LBLVal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.LBLVal2.Location = new System.Drawing.Point(486, 52);
            this.LBLVal2.Name = "LBLVal2";
            this.LBLVal2.Size = new System.Drawing.Size(30, 31);
            this.LBLVal2.TabIndex = 21;
            this.LBLVal2.Text = "0";
            // 
            // LBLSinal
            // 
            this.LBLSinal.AutoSize = true;
            this.LBLSinal.BackColor = System.Drawing.Color.White;
            this.LBLSinal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LBLSinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.LBLSinal.Location = new System.Drawing.Point(449, 52);
            this.LBLSinal.Name = "LBLSinal";
            this.LBLSinal.Size = new System.Drawing.Size(31, 31);
            this.LBLSinal.TabIndex = 22;
            this.LBLSinal.Text = "+";
            this.LBLSinal.Click += new System.EventHandler(this.label4_Click);
            // 
            // textResultado
            // 
            this.textResultado.BackColor = System.Drawing.Color.White;
            this.textResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.textResultado.Location = new System.Drawing.Point(455, 131);
            this.textResultado.Multiline = true;
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(100, 50);
            this.textResultado.TabIndex = 23;
            this.textResultado.Text = "0";
            this.textResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textResultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BTNPorcentagem
            // 
            this.BTNPorcentagem.BackColor = System.Drawing.Color.Cyan;
            this.BTNPorcentagem.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPorcentagem.Location = new System.Drawing.Point(539, 284);
            this.BTNPorcentagem.Name = "BTNPorcentagem";
            this.BTNPorcentagem.Size = new System.Drawing.Size(75, 149);
            this.BTNPorcentagem.TabIndex = 24;
            this.BTNPorcentagem.Text = "%";
            this.BTNPorcentagem.UseVisualStyleBackColor = false;
            this.BTNPorcentagem.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BTNCadu
            // 
            this.BTNCadu.BackColor = System.Drawing.Color.LightCoral;
            this.BTNCadu.Location = new System.Drawing.Point(539, 448);
            this.BTNCadu.Name = "BTNCadu";
            this.BTNCadu.Size = new System.Drawing.Size(74, 62);
            this.BTNCadu.TabIndex = 25;
            this.BTNCadu.Text = "CADU";
            this.BTNCadu.UseVisualStyleBackColor = false;
            this.BTNCadu.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 580);
            this.Controls.Add(this.BTNCadu);
            this.Controls.Add(this.BTNPorcentagem);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.LBLSinal);
            this.Controls.Add(this.LBLVal2);
            this.Controls.Add(this.LBLVal1);
            this.Controls.Add(this.BTNSoma);
            this.Controls.Add(this.BTNSubtracao);
            this.Controls.Add(this.BTNDivisao);
            this.Controls.Add(this.BTNMultiplicacao);
            this.Controls.Add(this.BTNRestaurar);
            this.Controls.Add(this.BTNIgual);
            this.Controls.Add(this.BTN6);
            this.Controls.Add(this.BTN3);
            this.Controls.Add(this.BTN9);
            this.Controls.Add(this.BTNPonto);
            this.Controls.Add(this.BTN5);
            this.Controls.Add(this.BTN2);
            this.Controls.Add(this.BTN8);
            this.Controls.Add(this.BTN0);
            this.Controls.Add(this.BTN4);
            this.Controls.Add(this.BTN1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BTN7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BTN1;
        private System.Windows.Forms.Button BTN4;
        private System.Windows.Forms.Button BTN0;
        private System.Windows.Forms.Button BTNPonto;
        private System.Windows.Forms.Button BTN5;
        private System.Windows.Forms.Button BTN2;
        private System.Windows.Forms.Button BTN8;
        private System.Windows.Forms.Button BTNIgual;
        private System.Windows.Forms.Button BTN6;
        private System.Windows.Forms.Button BTN3;
        private System.Windows.Forms.Button BTN9;
        private System.Windows.Forms.Button BTNSubtracao;
        private System.Windows.Forms.Button BTNDivisao;
        private System.Windows.Forms.Button BTNMultiplicacao;
        private System.Windows.Forms.Button BTNRestaurar;
        private System.Windows.Forms.Button BTNSoma;
        private System.Windows.Forms.Label LBLVal1;
        private System.Windows.Forms.Label LBLVal2;
        private System.Windows.Forms.Label LBLSinal;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BTNPorcentagem;
        private System.Windows.Forms.Button BTNCadu;
    }
}

