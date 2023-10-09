// 
using Classes;

HashSet<Pessoa> pessoas = new HashSet<Pessoa>();

try
{
    Pessoa pessoa = new Pessoa("Alessandro", "", new Telefone("21964109745", ""));
    pessoas.Add(pessoa);

    foreach (var p in pessoas)
    {
        Console.WriteLine(p.Imprimir());
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}



//pessoa.Nome = "Alessandro";
//pessoa.Profissao = "Arquiteto de sistemas";
//pessoa.AdicionarTelefone(new Telefone("21964109745", ""));
//pessoas.Add(pessoa);

//pessoa = new Pessoa();
//pessoa.Nome = "Melissa";
//pessoa.Profissao = "Desenvolvedora";
//pessoa.AdicionarTelefone(new Telefone("21212121212", "Residencial"));
//pessoas.Add(pessoa);

//pessoa = new Pessoa();
//pessoa.Nome = "Humberto";
//pessoa.Profissao = "Analista Contábil";
//pessoa.AdicionarTelefone(new Telefone("21212121212", "Comercial"));
//pessoas.Add(pessoa);

//pessoas.Add(new Pessoa("Alessandro", "Arquiteto de sistemas"));
//pessoas.Add(new Pessoa("Melissa", "Desenvolvedora"));
//pessoas.Add(new Pessoa("Humberto", "Analista Contábil"));



