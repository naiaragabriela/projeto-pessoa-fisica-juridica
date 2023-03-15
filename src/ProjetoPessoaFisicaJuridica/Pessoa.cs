namespace ProjetoPessoaFisicaJuridica
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }


        public Pessoa(string nome, string telefone1, string telefone2, string email, string endereco)

        {
            Nome = nome;
            Telefone1 = telefone1;
            Telefone1 = telefone2;
            Email = email;
            Endereco = endereco;

        }

        public override string ToString()
        {
            return (Nome + Telefone1 + Telefone2 + Email + Endereco);
        }
    }


}
