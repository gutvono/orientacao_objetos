using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pessoa
{
    public string nome;
    public string sobrenome;
    public string telefone;
    public string celular;
    public int idade;
    public string email;

    public Pessoa()
    {

    }

    public string DefinirNome()
    {
        Console.Write("Informe o nome: ");
        return Console.ReadLine();
    }

    public string DefinirSobrenome()
    {
        Console.Write("Informe o sobrenome: ");
        return Console.ReadLine();
    }

    public void DefinirTelefone(string telefone)
    {
        this.telefone = telefone;
    }

    public void DefinirCelular(string celular)
    {
        this.celular = celular;
    }

    public int DefinirIdade()
    {
        return int.Parse(Console.ReadLine());
    }

    public void DefinirEmail(string email)
    {
        this.email = email;
    }

    public void MostrarDados()
    {
        Console.WriteLine("\n--------------------------------------------------------");
        Console.WriteLine($"Este é o seu nome: {this.nome}");
        Console.WriteLine($"Este é o seu sobrenome: {this.sobrenome}");
        Console.WriteLine($"Este é o seu telefone: {this.telefone}");
        Console.WriteLine($"Este é o seu celular: {this.celular}");
        Console.WriteLine($"Este é a sua idade: {this.idade}");
        Console.WriteLine($"Este é o seu email: {this.email}");
        Console.WriteLine("--------------------------------------------------------\n");
    }
}
