﻿namespace Atividade_1__POO
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mask_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.num_peso = new System.Windows.Forms.NumericUpDown();
            this.num_altura = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.combo_sexo = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.mask_idade = new System.Windows.Forms.MaskedTextBox();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.lbfalso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_peso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_altura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura:";
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(62, 124);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(100, 20);
            this.tx_nome.TabIndex = 2;
            this.tx_nome.TextChanged += new System.EventHandler(this.tx_nome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sexo:";
            // 
            // mask_cpf
            // 
            this.mask_cpf.Location = new System.Drawing.Point(41, 168);
            this.mask_cpf.Mask = "000,000,000-00";
            this.mask_cpf.Name = "mask_cpf";
            this.mask_cpf.Size = new System.Drawing.Size(100, 20);
            this.mask_cpf.TabIndex = 7;
            this.mask_cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mask_cpf_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(332, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "IMC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 15;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(236, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Índice de Massa Corporal";
            // 
            // num_peso
            // 
            this.num_peso.DecimalPlaces = 2;
            this.num_peso.Location = new System.Drawing.Point(52, 216);
            this.num_peso.Name = "num_peso";
            this.num_peso.Size = new System.Drawing.Size(120, 20);
            this.num_peso.TabIndex = 17;
            // 
            // num_altura
            // 
            this.num_altura.DecimalPlaces = 2;
            this.num_altura.Location = new System.Drawing.Point(62, 262);
            this.num_altura.Name = "num_altura";
            this.num_altura.Size = new System.Drawing.Size(120, 20);
            this.num_altura.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // combo_sexo
            // 
            this.combo_sexo.FormattingEnabled = true;
            this.combo_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "gay"});
            this.combo_sexo.Location = new System.Drawing.Point(51, 309);
            this.combo_sexo.Name = "combo_sexo";
            this.combo_sexo.Size = new System.Drawing.Size(121, 21);
            this.combo_sexo.TabIndex = 20;
            this.combo_sexo.SelectedIndexChanged += new System.EventHandler(this.comb_sexo_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Idade:";
            // 
            // mask_idade
            // 
            this.mask_idade.Location = new System.Drawing.Point(62, 86);
            this.mask_idade.Name = "mask_idade";
            this.mask_idade.Size = new System.Drawing.Size(100, 20);
            this.mask_idade.TabIndex = 23;
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Location = new System.Drawing.Point(418, 171);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(64, 13);
            this.lb_resultado.TabIndex = 24;
            this.lb_resultado.Text = "lb_resultado";
            this.lb_resultado.Click += new System.EventHandler(this.label10_Click);
            // 
            // lbfalso
            // 
            this.lbfalso.AutoSize = true;
            this.lbfalso.Location = new System.Drawing.Point(608, 188);
            this.lbfalso.Name = "lbfalso";
            this.lbfalso.Size = new System.Drawing.Size(41, 13);
            this.lbfalso.TabIndex = 25;
            this.lbfalso.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbfalso);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.mask_idade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.combo_sexo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.num_altura);
            this.Controls.Add(this.num_peso);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mask_cpf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "IMC";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_peso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_altura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mask_cpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown num_peso;
        private System.Windows.Forms.NumericUpDown num_altura;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox combo_sexo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mask_idade;
        private System.Windows.Forms.Label lb_resultado;
        private System.Windows.Forms.Label lbfalso;
    }
}

