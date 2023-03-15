using ProjetoPessoaFisicaJuridica;

Pessoa pessoa = new Pessoa("Naiara ", " 3333-3456 ", " 3232-6758 ", " naiara@phive.com ", " Rua Fluxo Feliz, 10 ");
Fisica fisica = new Fisica("Joao ", " 3333-1111 ", " 3232-2222 ", " joao@phive.com ", " Rua Fluxo Feliz, 11 ", " 332233445-78 ");
Juridica juridica = new Juridica("Ana ", " 3333-4444 ", " 3232-3333 ", " naiara@phive.com ", " Rua Fluxo Feliz, 11 ", " Jogos.LTDA ", " 1234345696059000 ");

Console.WriteLine(pessoa.ToString());
Console.WriteLine(fisica.ToString());
Console.WriteLine(juridica.ToString());

