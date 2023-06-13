using System;
using System.Windows.Forms;

public class Validacoes
{
    public static bool ValidarCPF(string cpf)
    {
        //remover traço e pontos do cpf
        cpf = cpf.Replace(".", "");
        cpf = cpf.Replace("-", "");
        
        int soma = 0;
        int sobra = 0;
        string digito;
        string CPF;
        int resultado = 0;
        int retorno = 0;

        //
        if (cpf.Length != 11)
        {

            return false;
        }
        
        CPF = cpf.Substring(0, 9);
        int[] multiplicacao = new int[9] {10,9,8,7,6,5,4,3,2};
        int[] multiplicacao2 = new int[10] {11, 10, 9, 8, 7,6,5,4,3,2};

        for(int i = 0; i < cpf.Length -2; i++)
        {
            soma += Convert.ToInt32(cpf[i].ToString()) * multiplicacao[i];
        }
        sobra = soma % 11;

        if(sobra < 2)
        {
            if (Convert.ToInt32(cpf[9].ToString()) == 0)
            {
                return true;
            }
           
        }
        else
        {
            sobra = 11 - sobra;
        }
        digito = sobra.ToString();
        CPF = cpf + digito;

        for (int i = 0; i < cpf.Length - 1; i++)
        {
            soma += int.Parse(cpf[i].ToString()) * multiplicacao2[i];
        }
        sobra = sobra % 11;

        if (sobra < 2)
        {
            sobra = 0;
        }
        else
        {
            sobra = 11 - sobra;
        }
        digito = digito + sobra.ToString();

        return true;
        Console.WriteLine("cpf valido");



    } 
}