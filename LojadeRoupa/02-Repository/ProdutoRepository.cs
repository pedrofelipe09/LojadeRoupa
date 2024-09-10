using Dapper.Contrib.Extensions;
using LojadeRoupa._03_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._02_Repository
{
    public class ProdutoRepository
    {
        public readonly string _connectionString;
        public ProdutoRepository(string connection)
        {
            _connectionString = connection;
        }


        public void AdicionarProduto(Produto produto)
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Insert<Produto>(produto);
        }
        //public List<Produto> ListarProdutos()
        ////{
        ////    using var connection = new SQLiteConnection(_connectionString);
        ////    return connection.GetAll<Produto>().ToList();

        ////}




    }
}
