public class Pessoa
{
    public string nome;
    public string sobrenome;
    public string telefone;
    public string celular;
    public int idade;
    public string sexo;
    public string email;
    public double salario;
    public DateOnly nascimento;

    public Pessoa()
    {

    }

    public void DefinirNome(string nome)
    {
        this.nome = nome;
    }

    public void DefinirSobrenome(string sobrenome)
    {
        this.sobrenome = sobrenome;
    }

    public void DefinirTelefone(string telefone)
    {
        this.telefone = telefone;
    }

    public void DefinirCelular(string celular)
    {
        this.celular = celular;
    }

    public void DefinirIdade(int idade)
    {
        this.idade = idade;
    }

    public void DefinirSexo(string sexo)
    {
        this.sexo = sexo;
    }

    public void DefinirEmail(string email)
    {
        this.email = email;
    }

    public void DefinirSalario(double salario)
    {
        this.salario = salario;
    }

    public void DefinirNascimento(DateOnly nascimento)
    {
        this.nascimento = nascimento;
    }

    public void ImprimirPessoa()
    {
        Console.WriteLine($"Nome: {this.nome}");
        Console.WriteLine($"Sobrenome: {this.sobrenome}");
        Console.WriteLine($"Telefone: {this.telefone}");
        Console.WriteLine($"Celular: {this.celular}");
        Console.WriteLine($"Idade: {this.idade}");
        Console.WriteLine($"Sexo: {this.sexo}");
        Console.WriteLine($"Email: {this.email}");
        Console.WriteLine($"Salario: {this.salario}");
        Console.WriteLine($"Nascimento: {this.nascimento}");
    }
}
