

namespace ProjetoPessoaFisicaJuridica
{
  
        internal class Juridica : Pessoa
        {
            public string NomeFantasia { get; set; }
            public string CNPJ { get; set; }
            public Juridica(string nome, string telefone1, string telefone2, string email, string endereco, string nomefantasia, string cnpj) : base(nome, telefone1, telefone2, email, endereco)
            {

                NomeFantasia = nomefantasia;
                CNPJ = cnpj;

            }

            public override string ToString()
            {
                return base.ToString() + " - " + NomeFantasia + " - " + CNPJ;
            }
        }
}
