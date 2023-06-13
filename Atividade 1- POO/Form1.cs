using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Atividade_1__POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            lb_resultado.Text = "";
            lbfalso.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {

        }

        private void tx_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void mask_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idade = mask_idade.ToString();
            string nome = tx_nome.Text;
            double altura = Convert.ToDouble(num_altura.Text);
            double peso = Convert.ToDouble(num_peso.Text);
            string sexo = combo_sexo.Text;
            string cpf = mask_cpf.Text;

            Pessoa p = new Pessoa(idade, sexo,nome, peso, cpf,altura);
            (double imc, string classificacao, string grau) = p.CalcularIMC();
            lb_resultado.Text = $"o IMC é {imc.ToString("0.00")} \n Sua classificacao é:{classificacao} \n Seu grau é: {grau}";

            
            if(Validacoes.ValidarCPF(cpf))
            {
                lbfalso.Text = "cpf valido";
            }
            else
            {
                lbfalso.Text = "cpf invalido";
            }

           

            MessageBox.Show(idade+ "\n " + nome + "\n" + altura + "\n " + cpf + "\n " + peso + "\n " + sexo);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mask_idade.Clear();
            tx_nome.Clear();
            combo_sexo.SelectedIndex = 0;
            mask_cpf.Clear();
            num_peso.ResetText();
            num_altura.ResetText();

            
            
        }

        private void comb_sexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
