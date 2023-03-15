

namespace ProjetoPessoaFisicaJuridica
{
    internal class Fisica : Pessoa
    {
        public string CPF { get; set; }
        public Fisica(string nome, string telefone1, string telefone2, string email, string endereco, string cpf) : base(nome, telefone1, telefone2, email, endereco)
        {
            CPF = cpf;
        }

        public override string ToString()
        {
            return base.ToString() + " - " + CPF;
        }

    }
}
