using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_com_C_
{
    internal class cadastroFuncionarios
    {
        private string cnpj;
        private string inscricao_estadual;
        private string cnae;
        private string endereco;
        private string numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private string cep;
        private string uf;
        private int matriz;
        private int filial;
        private string telefone;
        private string resp_imediato;
        private int vendas;
        private int recrutamento_selecao;
        private int fornecimentos;
        private int promocoes;
        private int news_letter;
        private int novos_produtos;
        private int garantia;
        private int eventos;


        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string Inscricao_estadual
        {
            get { return inscricao_estadual; }
            set { inscricao_estadual = value; }
        }
        public string Cnae
        {
            get { return cnae; }
            set { cnae = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Complemento
        {
           get { return complemento; }
           set { complemento = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }


    }
}