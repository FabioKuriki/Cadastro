using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Cadastro
{
    class DAO
    {
        public MySqlConnection conexao;
        public string dados;
        public string sql;
        public string resultado;
        public DAO()
        {
            conexao = new MySqlConnection("server = localhost; DataBase=TI18NPessoa; Uid=root; Password=");
            try
            {
                conexao.Open();//Abrir a conexão com o BD
                Console.WriteLine("Conectado com sucesso!");
            }
            catch (Exception erro)
            {
                Console.WriteLine("Algo deu errado! Verifique os dados de conexão!\n\n" + erro);
                conexao.Close();//Fechar a conexão com o BD
            }//Fim do try catch
        }//Fim do método

        //Método Inserir
        public void Inserir(string nome, string telefone, string cidade, string endereco)
        {
            try
            {
                dados = "('', '" + nome + "','" + telefone + "','" + cidade + "','" + endereco + "')";
                sql = "insert into pessoa(codigo, nome, telefone, cidade, endereco) values" + dados;

                MySqlCommand conn = new MySqlCommand(sql, conexao);//Prepara a execução no banco
                resultado = "" + conn.ExecuteNonQuery();//Ctrl + Enter -> Executando o comando no bd
                Console.WriteLine(resultado + "Linha(s) afetada(s)");
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro!! Algo deu errado\n\n\n" + erro);
            }
        }//Fim do método inserir
    }//Fim da classe
}//Fim do projeto
