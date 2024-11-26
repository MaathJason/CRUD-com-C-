using MySqlConnector;
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
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }

        public int Matriz
        {
            get { return matriz; }
            set { matriz = value; }
        }

        public int Filial
        {
            get { return filial; }
            set { filial = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Resp_imediato
        {
            get { return resp_imediato; }
            set { resp_imediato = value; }
        }

        public int Vendas
        {
            get { return vendas; }
            set { vendas = value; }
        }

        public int Recrutamento_selecao
        {
            get { return recrutamento_selecao; }
            set { recrutamento_selecao = value; }
        }

        public int Fornecimentos
        {
            get { return fornecimentos; }
            set { fornecimentos = value; }
        }

        public int Promocoes
        {
            get { return promocoes; }
            set { promocoes = value; }
        }

        public int News_letter
        {
            get { return news_letter; }
            set { news_letter = value; }
        }

        public int Novos_produtos
        {
            get { return novos_produtos; }
            set { novos_produtos = value; }
        }

        public int Garantia
        {
            get { return garantia; }
            set { garantia = value; }
        }

        public int Eventos
        {
            get { return eventos; }
            set { eventos = value; }
        }


        public bool cadastrarDados()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(conexaobanco.servidorbanco);
                MysqlConexaoBanco.Open();

                string insert = $@" insert into cadastroclientes(cnpj,inscricao_estadual,cnae,endereco,numero,complemento,bairro,cidade,cep,uf,matriz,filial,telefone,resp_imediato,vendas,recrutamento_selecao,fornecimentos,promocoes,news_letter,novos_produtos,garantia,eventos)
                values ('{Cnpj}', '{Inscricao_estadual}','{Cnae}','{Endereco}','{Numero}','{Complemento}', '{Bairro}', '{Cidade}', '{Cep}', '{Uf}', {Matriz}, {Filial}, '{Telefone}', '{Resp_imediato}', {Vendas}, {Recrutamento_selecao}, {Fornecimentos}, {Promocoes}, {News_letter}, {Novos_produtos}, {Garantia}, {Eventos})";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = insert;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no banco de dados - método cadastrar dados: " + ex.Message);
                return false;
            }
        }

    }
}