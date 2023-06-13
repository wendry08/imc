using System;

public class Pessoa
{
    private string idade;
    private string sexo;
    private string nome;
    private double peso;
    private string cpf;
    private double altura;

    public Pessoa(string idade, string sexo, string nome, double peso, string cpf, double altura)
    {
        this.idade = idade;
        this.sexo = sexo;
        this.nome = nome;
        this.peso = peso;
        this.cpf = cpf;
        this.altura = altura;
    }
    public string getNome()
    {
        return nome;
    }
    public void Setnome()
    {
        this.nome = nome;
    }
    public string GetCpf()
    {
        return this.cpf;
    }

    public void Setcpf(string cpf)
    {
        this.cpf = cpf;
    }
    public string getidade()
    {
        return this.idade;
    }
    public void SetIdade(string idade)
    {
        this.idade = idade;
    }
    public string GetSexo()
    {
        return this.sexo;
    }
    public void SetSexo(string sexo)
    {
        this.sexo = sexo;
    }
    public double getpeso(double peso)
    {
        return this.peso;
    }
    public double getAltura()
    {
        return this.altura;
    }
    public void SetAltura(double altura)
    {
        this.altura = altura;
    }

    public (double, string, string) CalcularIMC() // retorna mais de um valor
    {
        double imc = peso / (altura * altura);
        if (imc < 18.5)
        {
            return (imc, "Magreza", "0");
        }
        else if (imc >= 18.5 && imc <= 24.9)
        {
            return (imc, "Normal", "0");
        }
        else if (imc >= 18.5 && imc <= 29.9)
        {
            return (imc, "Sobrepeso", "I");
        }
        else if (imc >= 18.5 && imc <= 39.9)
        {
            return (imc, "Obesidade", "II");

        }
        else
        {
            return (imc, "ObesidadeGrave", "III");
        }
    }
}
       
    
    