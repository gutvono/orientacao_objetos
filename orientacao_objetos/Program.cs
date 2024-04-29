string telefone, celular, email;


Pessoa pessoa1, pessoa2, pessoa3;


Pessoa CriarPessoa() {
    Pessoa criarPessoa = new Pessoa();
    criarPessoa.nome = criarPessoa.DefinirNome();
    criarPessoa.sobrenome = criarPessoa.DefinirSobrenome();
    criarPessoa.idade = criarPessoa.DefinirIdade();

    Console.WriteLine("Informe o telefone");
    telefone = Console.ReadLine();
    criarPessoa.DefinirTelefone(telefone);

    Console.WriteLine("Informe o celular");
    celular = Console.ReadLine();
    criarPessoa.DefinirCelular(celular);

    Console.WriteLine("Informe o email");
    email = Console.ReadLine();
    criarPessoa.DefinirEmail(email);

    return criarPessoa;
}

pessoa1 = CriarPessoa();
pessoa2 = CriarPessoa();
pessoa3 = CriarPessoa();

pessoa1.MostrarDados();
pessoa2.MostrarDados();
pessoa3.MostrarDados();