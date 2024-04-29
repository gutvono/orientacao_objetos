public class Funcionario : Pessoa
{
    string cargo;
    int codigo;

    public Funcionario() {}

    public void DefinirCargo(string cargo)
    {
        this.cargo = cargo;
    }

    public void DefinirCodigo(int codigo)
    { 
        this.codigo = codigo;
    }

    public void ImprimirFuncionario()
    {
        ImprimirPessoa();
        Console.WriteLine($"Cargo: {this.cargo}");
        Console.WriteLine($"Codigo: {this.codigo}");
    }
}
