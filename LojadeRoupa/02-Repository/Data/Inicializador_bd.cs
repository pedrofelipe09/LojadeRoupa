using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._02_Repository.Data
{
    public static class Inicializador_bd
    {
        private const string ConnectionString = "Data Source=ProdutoCRUD.db";

        public static void Inicializar()
        {
            using var connection = new SQLiteConnection("Data Source=ProdutoCrud.db");
            string criarTabela = @"CREATE TABLE IF NOT EXISTS Produtos(
                                           Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                           Nome TEXT NOT NULL,
                                           Preco REAL NOT NULL,
                                           Descricao TEXT,
                                           Validade INTEGER,
                                           QuantidadeEstoque INTEGER
                                           );";
            connection.Execute(criarTabela);


        }



    }
}
