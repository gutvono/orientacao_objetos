Pessoa pessoa1, pessoa2, pessoa3;
Cliente cliente1;
Funcionario funcionario1;

//Pessoa CriarPessoa() {
//    Pessoa criarPessoa = new Pessoa();

//    Console.Write("\nInforme o nome: ");
//    criarPessoa.DefinirNome(Console.ReadLine());

//    Console.Write("\nInforme o sobrenome: ");
//    criarPessoa.DefinirSobrenome(Console.ReadLine());

//    Console.Write("\nInforme a idade: ");
//    criarPessoa.DefinirIdade(int.Parse(Console.ReadLine()));

//    Console.Write("\nInforme o telefone: ");
//    criarPessoa.DefinirTelefone((Console.ReadLine()));

//    Console.Write("\nInforme o celular: ");
//    criarPessoa.DefinirCelular(Console.ReadLine());

//    Console.Write("\nInforme o email: ");
//    criarPessoa.DefinirEmail(Console.ReadLine());

//    return criarPessoa;
//}

//pessoa1 = CriarPessoa();
//pessoa2 = CriarPessoa();
//pessoa3 = CriarPessoa();

//pessoa1.MostrarDados();
//pessoa2.MostrarDados();
//pessoa3.MostrarDados();


//Cliente CriarCliente()
//{
//    Cliente cliente = new Cliente();

//    Console.Write("\nInforme o nome: ");
//    cliente.DefinirNome(Console.ReadLine());

//    Console.Write("\nInforme o sobrenome: ");
//    cliente.DefinirSobrenome(Console.ReadLine());

//    Console.Write("\nInforme a idade: ");
//    cliente.DefinirIdade(int.Parse(Console.ReadLine()));

//    Console.Write("\nInforme o telefone: ");
//    cliente.DefinirTelefone((Console.ReadLine()));

//    Console.Write("\nInforme o celular: ");
//    cliente.DefinirCelular(Console.ReadLine());

//    Console.Write("\nInforme o email: ");
//    cliente.DefinirEmail(Console.ReadLine());

//    Console.Write("\nInforme o salario: ");
//    cliente.DefinirSalario(double.Parse(Console.ReadLine()));

//    Console.Write("\nInforme o nascimento: ");
//    cliente.DefinirNascimento(DateOnly.Parse(Console.ReadLine()));

//    Console.Write("\nInforme a conta: ");
//    cliente.DefinirConta(int.Parse(Console.ReadLine()));

//    return cliente;
//}

//Console.WriteLine("\n--------------------------------------------------------\n");
//cliente1.ImprimirCiente();
//Console.WriteLine("\n--------------------------------------------------------\n");

Funcionario CriarFuncionario()
{
    Funcionario funcionario = new Funcionario();

    Console.Write("\nInforme o nome: ");
    funcionario.DefinirNome(Console.ReadLine());

    Console.Write("\nInforme o sobrenome: ");
    funcionario.DefinirSobrenome(Console.ReadLine());

    Console.Write("\nInforme a idade: ");
    funcionario.DefinirIdade(int.Parse(Console.ReadLine()));

    Console.Write("\nInforme o telefone: ");
    funcionario.DefinirTelefone((Console.ReadLine()));

    Console.Write("\nInforme o celular: ");
    funcionario.DefinirCelular(Console.ReadLine());

    Console.Write("\nInforme o email: ");
    funcionario.DefinirEmail(Console.ReadLine());

    Console.Write("\nInforme o salario: ");
    funcionario.DefinirSalario(double.Parse(Console.ReadLine()));

    Console.Write("\nInforme o nascimento: ");
    funcionario.DefinirNascimento(DateOnly.Parse(Console.ReadLine()));

    Console.Write("\nInforme o cargo: ");
    funcionario.DefinirCargo(Console.ReadLine());

    Console.Write("\nInforme o codigo: ");
    funcionario.DefinirCodigo(int.Parse(Console.ReadLine()));

    return funcionario;
}

funcionario1 = CriarFuncionario();

Console.WriteLine("\n--------------------------------------------------------\n");
funcionario1.ImprimirFuncionario();
Console.WriteLine("\n--------------------------------------------------------\n");