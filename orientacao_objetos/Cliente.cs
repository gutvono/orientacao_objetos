public class Cliente : Pessoa
{
    public int conta;

    public Cliente() { }

    public void DefinirConta(int conta)
    {
        this.conta = conta;
    }

    public void ImprimirCiente()
    {
        ImprimirPessoa();
        Console.WriteLine($"Conta: {this.conta}");
    }
}